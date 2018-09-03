using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Litrojan
{
    public partial class MainForm : MaterialForm
    {
        //
        // WARNING: Shit codes incoming!
        //

        TrojanConfigManager tcm;
        TrojanProcessManager tpm;
        TrojanSettingManager tsm;
        TrojanNetworkManager tnm;

        string logHost = "";
        string ALPN
        {
            get
            {
                return ConnectStrings(tcm.Config.ssl.alpn);
            }
        }

        public MainForm()
        {
            InitializeComponent();
            UpdateTxtLogDisplay($"Litrojan ({GlobalVaribleHost.LitrojanVer}) Starting.", "Litrojan");
            InitializeFormMaterial();
            UpdateLblVersionInfo();
            LogicInit();
            DoBinding();
            UpdateTxtLogDisplay($"Litrojan ({GlobalVaribleHost.LitrojanVer}) Started.", "Litrojan");
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            tsm.TrySetRestartTrojan(tsm.Setting.AutoRestartTrojan);
            tsm.TrySetLogSave(tsm.Setting.EnableLogSave);
        }

        #region UIHelper

        public void InitializeFormMaterial()
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            //materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            //materialSkinManager.ColorScheme = new ColorScheme(Primary.Indigo500, Primary.Indigo700, Primary.Indigo100, Accent.Pink200, TextShade.WHITE);
            Sizable = false;
            MaximizeBox = false;
        }
        
        public void UpdateLblVersionInfo()
        {
            LblHomeVersion.Text = $"Litrojan Version: {GlobalVaribleHost.LitrojanVer} / Trojan Version: {GlobalVaribleHost.TrojanVer}";
            LblHomeVersion.Location = new Point((TabHome.Width - LblHomeVersion.Width) / 2, LblHomeVersion.Location.Y);
            LblAboutVersion.Text = $"Litrojan ({GlobalVaribleHost.LitrojanVer})";
            LblAboutVersion.Location = new Point((TabAbout.Width - LblAboutVersion.Width) / 2, LblAboutVersion.Location.Y);
        }

        public void LogicInit()
        {
            tcm = new TrojanConfigManager(LitrojanUtils.GetLocalPath("trojan.json"), UpdateTxtLogDisplay);
            tcm.LoadConfig();
            tpm = new TrojanProcessManager(LitrojanUtils.GetLocalPath("trojan.exe"), UpdateTxtLogDisplay);
            tsm = new TrojanSettingManager(LitrojanUtils.GetLocalPath("settings.json"), UpdateTxtLogDisplay, UpdateNoticeDisplay, tpm);
            tsm.LoadSetting();
            tnm = new TrojanNetworkManager(tcm.Config, UpdateNoticeDisplay);
            UpdateTheme(tsm.Setting.DarkUITheme);
            foreach (var i in panel1.Controls)
            {
                if (i is RadioButton rb && Enum.GetName(typeof(RunMode), tcm.Config.RunMode) == rb.Text)
                {
                    rb.Checked = true;
                    break;
                }
            }
        }

        public void DoBinding()
        {
            TxtLocalAddr.DataBindings.Add("Text", tcm.Config, "local_addr", false, DataSourceUpdateMode.OnPropertyChanged);
            TxtLocalPort.DataBindings.Add("Text", tcm.Config, "local_port", false, DataSourceUpdateMode.OnPropertyChanged);
            TxtRemoAddr.DataBindings.Add("Text", tcm.Config, "remote_addr", false, DataSourceUpdateMode.OnPropertyChanged);
            TxtRemoPort.DataBindings.Add("Text", tcm.Config, "remote_port", false, DataSourceUpdateMode.OnPropertyChanged);
            TxtTargetAddr.DataBindings.Add("Text", tcm.Config, "target_addr", false, DataSourceUpdateMode.OnPropertyChanged);
            TxtTargetPort.DataBindings.Add("Text", tcm.Config, "target_port", false, DataSourceUpdateMode.OnPropertyChanged);
            TxtPass.DataBindings.Add("Text", tcm.Config.password, "", false, DataSourceUpdateMode.OnPropertyChanged);
            TxtPass.BindingContext[tcm.Config.password].Position = 0;
            ChkAppendPayload.DataBindings.Add("Checked", tcm.Config, "append_payload", false, DataSourceUpdateMode.OnPropertyChanged);
            ComLogLevel.DataBindings.Add("SelectedIndex", tcm.Config, "log_level", false, DataSourceUpdateMode.OnPropertyChanged);

            ChkVerify.DataBindings.Add("Checked", tcm.Config.ssl, "verify", false, DataSourceUpdateMode.OnPropertyChanged);
            ChkVerifyHost.DataBindings.Add("Checked", tcm.Config.ssl, "verify_hostname", false, DataSourceUpdateMode.OnPropertyChanged);
            TxtCertPath.DataBindings.Add("Text", tcm.Config.ssl, "cert", false, DataSourceUpdateMode.OnPropertyChanged);
            TxtKeyPath.DataBindings.Add("Text", tcm.Config.ssl, "key", false, DataSourceUpdateMode.OnPropertyChanged);
            TxtKeyPass.DataBindings.Add("Text", tcm.Config.ssl, "key_password", false, DataSourceUpdateMode.OnPropertyChanged);
            TxtCipher.DataBindings.Add("Text", tcm.Config.ssl, "cipher", false, DataSourceUpdateMode.OnPropertyChanged);
            ChkServerCipher.DataBindings.Add("Checked", tcm.Config.ssl, "prefer_server_cipher", false, DataSourceUpdateMode.OnPropertyChanged);
            TxtSNI.DataBindings.Add("Text", tcm.Config.ssl, "sni", false, DataSourceUpdateMode.OnPropertyChanged);
            TxtALPN.DataBindings.Add("Text", ALPN, "", false, DataSourceUpdateMode.OnPropertyChanged);
            ChkReuse.DataBindings.Add("Checked", tcm.Config.ssl, "reuse_session", false, DataSourceUpdateMode.OnPropertyChanged);
            TxtTimeout.DataBindings.Add("Text", tcm.Config.ssl, "session_timeout", false, DataSourceUpdateMode.OnPropertyChanged);
            TxtCurves.DataBindings.Add("Text", tcm.Config.ssl, "curves", false, DataSourceUpdateMode.OnPropertyChanged);

            ChkNoDelay.DataBindings.Add("Checked", tcm.Config.tcp, "no_delay", false, DataSourceUpdateMode.OnPropertyChanged);
            ChkKeepAlive.DataBindings.Add("Checked", tcm.Config.tcp, "keep_alive", false, DataSourceUpdateMode.OnPropertyChanged);
            ChkFastOpen.DataBindings.Add("Checked", tcm.Config.tcp, "fast_open", false, DataSourceUpdateMode.OnPropertyChanged);
            TxtQLEN.DataBindings.Add("Text", tcm.Config.tcp, "fast_open_qlen", false, DataSourceUpdateMode.OnPropertyChanged);

            ChkSQLEnabled.DataBindings.Add("Checked", tcm.Config.mysql, "enabled", false, DataSourceUpdateMode.OnPropertyChanged);
            TxtServerAddr.DataBindings.Add("Text", tcm.Config.mysql, "server_addr", false, DataSourceUpdateMode.OnPropertyChanged);
            TxtServerPort.DataBindings.Add("Text", tcm.Config.mysql, "server_port", false, DataSourceUpdateMode.OnPropertyChanged);
            TxtDatabase.DataBindings.Add("Text", tcm.Config.mysql, "database", false, DataSourceUpdateMode.OnPropertyChanged);
            TxtUsername.DataBindings.Add("Text", tcm.Config.mysql, "username", false, DataSourceUpdateMode.OnPropertyChanged);
            TxtSQLPass.DataBindings.Add("Text", tcm.Config.mysql, "password", false, DataSourceUpdateMode.OnPropertyChanged);

            ChkSettAusa.DataBindings.Add("Checked", tsm.Setting, "EnableLogSave", false, DataSourceUpdateMode.OnPropertyChanged);
            ChkSettAust.DataBindings.Add("Checked", tsm.Setting, "LaunchWithSys", false, DataSourceUpdateMode.OnPropertyChanged);
            ChkSettDark.DataBindings.Add("Checked", tsm.Setting, "DarkUITheme", false, DataSourceUpdateMode.OnPropertyChanged);
            ChkSettMini.DataBindings.Add("Checked", tsm.Setting, "MinimizeToTray", false, DataSourceUpdateMode.OnPropertyChanged);
            ChkSettRest.DataBindings.Add("Checked", tsm.Setting, "AutoRestartTrojan", false, DataSourceUpdateMode.OnPropertyChanged);
        }

        public string ConnectStrings(string[] arr)
        {
            var n = "";
            foreach (var i in arr)
            {
                n += $"{i},";
            }
            return n.TrimEnd(',');
        }

        public void UpdateTxtLogDisplay(string Information, string Source)
        {
            var info = $"[{Source}] {(Source != "TrojanCore" ? $"({DateTime.Now.ToString("s")})" : "")} {Information.Trim()}";
            GlobalVaribleHost.LogBuffer.Add(info);
            logHost += $"{info}\r\n";
            ThreadSetText($"{info}\r\n");
        }

        public void UpdateNoticeDisplay(string Information)
        {
            var info = $"({DateTime.Now.ToString("s")}) {Information.Trim()}\r\n";
            TxtSettStatus.AppendText(info);
        }

        delegate void SetTextCallback(string text);

        private void ThreadSetText(string text)
        {
            if (TxtLogDisplay.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(ThreadSetText);
                Invoke(d, new object[] { text });
            }
            else
            {
                TxtLogDisplay.AppendText(text);
            }
        }

        private void HideWindow()
        {
            NotTrayIcon.Visible = true;
            NotTrayIcon.ShowBalloonTip(500);
            NotTrayIcon.Text = $"Litrojan - {Enum.GetName(typeof(RunStatus), tpm.TrojanStatus())} ({Enum.GetName(typeof(RunMode), tcm.Config.RunMode)})";
            Visible = false;
        }

        private void UpdateTheme(bool IsDark)
        {
            var skmgr = MaterialSkinManager.Instance;
            if (IsDark)
            {
                skmgr.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
                skmgr.Theme = MaterialSkinManager.Themes.DARK;
                TxtLogDisplay.ForeColor = Color.White;
                TxtLogDisplay.BackColor = Color.FromArgb(unchecked((int)0xFF333333));
                TxtSettStatus.ForeColor = Color.White;
                TxtSettStatus.BackColor = Color.FromArgb(unchecked((int)0xFF333333));
            }
            else
            {
                skmgr.ColorScheme = new ColorScheme(Primary.Indigo500, Primary.Indigo700, Primary.Indigo100, Accent.Pink200, TextShade.WHITE);
                skmgr.Theme = MaterialSkinManager.Themes.LIGHT;
                TxtLogDisplay.ForeColor = Color.Black;
                TxtLogDisplay.BackColor = Color.White;
                TxtSettStatus.ForeColor = Color.Black;
                TxtSettStatus.BackColor = Color.White;
            }
        }

        #endregion

        #region Events

        private void BtnLogCopy_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(logHost);
                UpdateTxtLogDisplay("Litrojan logs copied.", "LiUiLogs");
            }
            catch(Exception ex)
            {
                UpdateTxtLogDisplay(LitrojanUtils.ErrorFormatter("Litrojan logs cannot be copied.", ex), "LiUiLogs");
            }
         }

        private void BtnLogClear_Click(object sender, EventArgs e)
        {
            LitrojanUtils.AutoIncrementalSave();
            logHost = "";
            TxtLogDisplay.Clear();
        }

        private void BtnLogSave_Click(object sender, EventArgs e)
        {
            saveFileDialog1.AddExtension = true;
            saveFileDialog1.CheckFileExists = false;
            saveFileDialog1.CheckPathExists = false;
            saveFileDialog1.DefaultExt = "log";
            saveFileDialog1.Filter = "Log files (*.log)|*.log|All files (*.*)|*.*";
            saveFileDialog1.CreatePrompt = true;
            saveFileDialog1.OverwritePrompt = true;
            saveFileDialog1.SupportMultiDottedExtensions = true;
            saveFileDialog1.FileName = $"Litrojan-{DateTime.Now.ToString("s")}.log";
            saveFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    File.WriteAllText(saveFileDialog1.FileName, logHost);
                    UpdateTxtLogDisplay("Litrojan logs saved.", "LiUiLogs");
                }
                catch(Exception ex)
                {
                    UpdateTxtLogDisplay(LitrojanUtils.ErrorFormatter("Litrojan logs cannot be saved.", ex), "LiUiLogs");
                }
            }
            else
            {
                UpdateTxtLogDisplay("Litrojan logs not saved.", "LiUiLogs");
            }
        }

        private void BtnHomeStart_Click(object sender, EventArgs e)
        {
            if (tpm.TrojanStatus() == RunStatus.Stopped)
            {
                var p = tcm.ExportConfig(tcm.Config.RunMode);
                tpm.TrojanStart(p, tcm.Config.RunMode);
                BtnHomeStart.Text = $"Stop {Enum.GetName(typeof(RunMode), tcm.Config.RunMode)}";
                startToolStripMenuItem.Text = $"Stop {Enum.GetName(typeof(RunMode), tcm.Config.RunMode)}";
            }
            else
            {
                tpm.TrojanStop();
                BtnHomeStart.Text = $"Start";
                startToolStripMenuItem.Text = $"Start Trojan";
            }
        }

        private void BtnConfSave_Click(object sender, EventArgs e)
        {
            tcm.SaveConfig();
        }

        private void BtnConfRestore_Click(object sender, EventArgs e)
        {
            tcm.LoadConfig(true);
        }

        private void BtnConfCancel_Click(object sender, EventArgs e)
        {
            tcm.LoadConfig();
        }

        private void TxtALPN_TextChanged(object sender, EventArgs e)
        {
            // yea, i know it's ugly.
            tcm.Config.ssl.alpn = TxtALPN.Text.Split(',');
        }

        private void RdoMode_CheckedChanged(object sender, EventArgs e)
        {
            if(sender is RadioButton rb)
            {
                Enum.TryParse(rb.Text, out RunMode mode);
                tcm.Config.RunMode = mode;
            }
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == WindowState)
            {
                HideWindow();
            }
        }

        private void NotTrayIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Visible = true;
            Activate();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            if (tsm.TryMinimize())
            {
                HideWindow();
            }
            else
            {
                exitLitrojanToolStripMenuItem_Click(this, null);
            }
        }

        private void restartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tpm.TrojanRestart();
        }

        private void exitLitrojanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tsm.TryDisableLogSave();
            tsm.TryManualRestartTrojan();
            tpm.TrojanStop();
            UpdateTxtLogDisplay($"Litrojan ({GlobalVaribleHost.LitrojanVer}) Stopped.", "Litrojan");
            LitrojanUtils.AutoIncrementalSave();
            Environment.Exit(0);
        }

        private void BtnSettExpo_Click(object sender, EventArgs e)
        {
            var p = tcm.ExportConfig(RunMode.Liconf, "", false);
            var s = $"tconf://{LitrojanUtils.Base64Encode(File.ReadAllText(p))}";
            TxtSettStatus.Text = s;
            Clipboard.SetText(s);
        }

        private void BtnSettImpo_Click(object sender, EventArgs e)
        {
            var s = Clipboard.GetText();
            if (!s.StartsWith("tconf://"))
                s = TxtSettStatus.Text;
            if (!s.StartsWith("tconf://"))
            {
                TxtSettStatus.Text = "Please paste share link here.";
                return;
            }
            var p = Path.GetTempFileName();
            s = LitrojanUtils.Base64Decode(s.Remove(0, "tconf://".Length));
            File.WriteAllText(p, s);
            tcm.LoadConfig(p);
        }

        private void BtnSettXxxx_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as MaterialCheckBox).Checked)
            {
                Random rng = new Random();
                BtnSettXxxx.Text = GlobalVaribleHost.Surprise[rng.Next(0, GlobalVaribleHost.Surprise.Length - 1)];
            }
            else
            {
                BtnSettXxxx.Text = "I can still pass through the wall";
            }
        }

        private void ChkSettDark_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTheme((sender as MaterialCheckBox).Checked);
        }

        private void ChkSettAust_CheckedChanged(object sender, EventArgs e)
        {
            if(!tsm.TryLaunchWithSys((sender as MaterialCheckBox).Checked))
            {
                ChkSettAust.CheckedChanged -= ChkSettAust_CheckedChanged;
                ChkSettAust.Checked = !ChkSettAust.Checked;
                ChkSettAust.CheckedChanged += ChkSettAust_CheckedChanged;
            }
        }

        private void ChkSettRest_CheckedChanged(object sender, EventArgs e)
        {
            if (!tsm.TrySetRestartTrojan((sender as MaterialCheckBox).Checked))
            {
                ChkSettRest.CheckedChanged -= ChkSettRest_CheckedChanged;
                ChkSettRest.Checked = !ChkSettRest.Checked;
                ChkSettRest.CheckedChanged += ChkSettRest_CheckedChanged;
            }
        }

        private void ChkSettAusa_CheckedChanged(object sender, EventArgs e)
        {
            if (!tsm.TrySetLogSave((sender as MaterialCheckBox).Checked))
            {
                ChkSettAusa.CheckedChanged -= ChkSettAusa_CheckedChanged;
                ChkSettAusa.Checked = !ChkSettAusa.Checked;
                ChkSettAusa.CheckedChanged += ChkSettAusa_CheckedChanged;
            }
        }

        private void BtnSettSave_Click(object sender, EventArgs e)
        {
            tsm.SaveSetting();
        }

        private void BtnSettRstr_Click(object sender, EventArgs e)
        {
            tsm.LoadSetting();
        }

        private void BtnSettPing_Click(object sender, EventArgs e)
        {
            tnm.Ping();
        }
        #endregion
    }
}
