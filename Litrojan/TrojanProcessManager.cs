using System;
using System.Diagnostics;
using System.IO;

namespace Litrojan
{
    internal class TrojanProcessManager
    {
        private string exePath;
        private string _confPath;
        private RunMode _Mode;
        private Process proc;
        private event InfoDispDelegate infoDisp;

        public TrojanProcessManager(string TrojanPath, InfoDispDelegate InfoDisp)
        {
            exePath = TrojanPath;
            proc = null;
            infoDisp = InfoDisp;
            _Mode = RunMode.None;
        }

        public void TrojanRestart()
        {
            if (string.IsNullOrEmpty(_confPath) || _Mode == RunMode.None)
            {
                infoDisp("Trojan instance cannot restart due to lack of information.", "LiProcMgmt");
                return;
            }
            TrojanStop();
            TrojanStart(_confPath, _Mode);
        }

        public void TrojanStop()
        {
            infoDisp("Stopping Trojan instance.", "LiProcMgmt");
            if (GlobalVaribleHost.TrojanStatus == RunStatus.Stopped)
            {
                infoDisp("Trojan instance already stopped.", "LiProcMgmt");
                return;
            }

            bool bKilled = false;
            if ((proc?.Id).HasValue && proc.Id > 0)
            {
                try
                {
                    proc.Kill();
                    bKilled = true;
                }
                catch(Exception e)
                {
                    infoDisp(LitrojanUtils.ErrorFormatter("Failed to stop Trojan instance.", e), "LiProcMgmt");
                }
                    
            }
            if (!bKilled)
            {
                infoDisp($"Trying wildcard kill.", "LiProcMgmt");

                // Main Target
                var killTarget = Process.GetProcessesByName(Path.GetFileName(exePath));
                BatchKill(killTarget);

                // Other Target
                foreach (string vName in GlobalVaribleHost.TrojanProcesses)
                {
                    killTarget = Process.GetProcessesByName(vName);
                    BatchKill(killTarget);
                }
            }

            GlobalVaribleHost.TrojanStatus = RunStatus.Stopped;

            void BatchKill(Process[] Target)
            {
                foreach (Process p in Target)
                {
                    infoDisp($"Wildcard killing \"{p.MainModule.FileName}\"({p.Id}).", "LiProcMgmt");
                    try
                    {
                        p.Kill();
                    }
                    catch (Exception e)
                    {
                        infoDisp(LitrojanUtils.ErrorFormatter($"Failed to kill \"{p.MainModule.FileName}\"({p.Id}).", e), "LiProcMgmt");
                    }
                }
            }
        }

        public void TrojanStart(string confPath, RunMode Mode)
        {
            _confPath = confPath;
            _Mode = Mode;
            infoDisp($"Starting Trojan instance as {Enum.GetName(typeof(RunMode), Mode)}.", "LiProcMgmt");
            if (GlobalVaribleHost.TrojanStatus == RunStatus.Running)
            {
                infoDisp("Trojan instance already running.", "LiProcMgmt");
                return;
            }

            try
            {
                proc = new Process();
                proc.StartInfo.FileName = exePath;
                proc.StartInfo.UseShellExecute = false;
                proc.StartInfo.CreateNoWindow = true;
                proc.StartInfo.Arguments = $"\"{confPath}\"";

                proc.StartInfo.RedirectStandardOutput = true;
                proc.StartInfo.RedirectStandardError = true;
                
                proc.OutputDataReceived += new DataReceivedEventHandler((sender, e) =>
                {
                    if (!string.IsNullOrEmpty(e.Data))
                    {
                        infoDisp(e.Data, "TrojanCore");
                    }
                });
                proc.ErrorDataReceived += new DataReceivedEventHandler((sender, e) =>
                {
                    if (!string.IsNullOrEmpty(e.Data))
                    {
                        infoDisp(e.Data, "TrojanCore"); // well, stderr is used
                    }
                });

                proc.Start();
                proc.BeginOutputReadLine();
                proc.BeginErrorReadLine();
                GlobalVaribleHost.TrojanStatus = RunStatus.Running;
            }
            catch (Exception e)
            {
                infoDisp(LitrojanUtils.ErrorFormatter($"Failed to start Trojan instance.", e), "LiProcMgmt");
                GlobalVaribleHost.TrojanStatus = RunStatus.Exceptional;
            }
        }
    }
}
