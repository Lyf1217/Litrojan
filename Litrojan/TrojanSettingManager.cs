using Microsoft.Win32;
using Newtonsoft.Json;
using System;
using System.Diagnostics;
using System.IO;
using System.Threading;

namespace Litrojan
{
    internal class TrojanSettingManager
    {
        public string SettPath;
        public TrojanSetting Setting;
        private event InfoDispDelegate infoDisp;
        private event NoticeDispDelegate notiDisp;
        private Thread autosave;
        private Thread autorestart;
        private TrojanProcessManager tpm;

        public TrojanSettingManager(string SettingPath, InfoDispDelegate InfoDisp, NoticeDispDelegate NotiDisp, TrojanProcessManager Tpm)
        {
            infoDisp = InfoDisp;
            notiDisp = NotiDisp;
            infoDisp("Loading setting file", "LiSettMgmt");

            SettPath = SettingPath;
            Setting = new TrojanSetting();

            autosave = new Thread(AutoSave);
            autorestart = new Thread(AutoDetect);

            tpm = Tpm;
        }

        public void SaveSetting()
        {
            var s = JsonConvert.SerializeObject(Setting);
            File.WriteAllText(SettPath, s);
            infoDisp("Setting file saved.", "LiSettMgmt");
        }

        public bool LoadSetting()
        {
            if (!File.Exists(SettPath))
            {
                infoDisp("Setting file not exist, creating new.", "LiSettMgmt");
                SaveSetting();
            }
            JsonConvert.PopulateObject(File.ReadAllText(SettPath), Setting);

            return true;
        }

        public bool TryLaunchWithSys(bool stat)
        {
            try
            {
                RegistryKey rk = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);

                bool succ = false;

                if (stat)
                {
                    rk.SetValue("Litrojan", Process.GetCurrentProcess().MainModule.FileName);
                    succ = rk.GetValue("Litrojan") != null;
                }
                else
                {
                    rk.DeleteValue("Litrojan", false);
                    succ = rk.GetValue("Litrojan") == null;
                }

                infoDisp(succ 
                    ? $"Auto launch configured to {stat}." 
                    : $"Auto launch cannot be configured to {stat}.", "LiSettMgmt");
                notiDisp(succ 
                    ? $"Auto launch configured to {stat}." 
                    : $"Auto launch cannot be configured to {stat}.");

                return succ;
            }
            catch(Exception e)
            {
                infoDisp(LitrojanUtils.ErrorFormatter("Failed to configure auto launch.", e), "LiSettMgmt");
                return false;
            }
        }

        public bool TryMinimize()
        {
            return Setting.MinimizeToTray;
        }

        public bool TrySetRestartTrojan(bool stat)
        {
            bool succ = stat ? TryAutoRestartTrojan() : TryManualRestartTrojan();
            infoDisp(succ 
                ? $"Auto restart configured to {stat}." 
                : $"Auto restart cannot be configured to {stat}.", "LiSettMgmt");
            notiDisp(succ 
                ? $"Auto restart configured to {stat}." 
                : $"Auto restart cannot be configured to {stat}.");
            return succ;
        }

        public bool TrySetLogSave(bool stat)
        {
            bool succ = stat ? TryEnableLogSave() : TryDisableLogSave();
            infoDisp(succ 
                ? $"Auto log configured to {stat}." 
                : $"Auto log cannot be configured to {stat}.", "LiSettMgmt");
            notiDisp(succ 
                ? $"Auto log configured to {stat}." 
                : $"Auto log cannot be configured to {stat}.");
            return succ;
        }

        public bool TryAutoRestartTrojan()
        {
            int i = 0;
            if (autorestart.IsAlive)
                return true;
            
            autorestart = new Thread(AutoDetect);
            autorestart.Start();
            while (!autorestart.IsAlive && i++ < 100) Thread.Sleep(1);
            return autorestart.IsAlive;
        }

        public bool TryManualRestartTrojan()
        {
            int i = 0;
            if (!autorestart.IsAlive)
                return true;
            autorestart.Abort();
            while (autorestart.IsAlive && i++ < 100) Thread.Sleep(1);
            return !autorestart.IsAlive;
        }

        public bool TryEnableLogSave()
        {
            int i = 0;
            if (autosave.IsAlive)
                return true;

            autosave = new Thread(AutoSave);
            autosave.Start();
            while (!autosave.IsAlive && i++ < 100) Thread.Sleep(1);
            return autosave.IsAlive;
        }

        public bool TryDisableLogSave()
        {
            int i = 0;
            if (!autosave.IsAlive)
                return true;
            autosave.Abort();
            while (autosave.IsAlive && i++ < 100) Thread.Sleep(1);
            return !autosave.IsAlive;
        }

        public void AutoSave()
        {
            for (; ; )
            {
                LitrojanUtils.AutoIncrementalSave();
                Thread.Sleep(5000);
            }
        }

        public void AutoDetect()
        {
            for(; ; )
            {
                if (tpm.TrojanStatus() == RunStatus.UnexpectedExit)
                    tpm.TrojanRestart();
                Thread.Sleep(5000);
            }
        }
    }
}
