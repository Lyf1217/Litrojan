using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Threading;

namespace Litrojan
{
    public partial class MainForm : MaterialForm
    {
        //
        // WARNING: Shit codes incoming!
        //

        TrojanConfigManager tcm;
        TrojanProcessManager tpm;
        Thread autosave;
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

        #region UIHelper

        public void InitializeFormMaterial()
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Indigo500, Primary.Indigo700, Primary.Indigo100, Accent.Pink200, TextShade.WHITE);
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
            tcm = new TrojanConfigManager(LitrojanUtils.GetLocalPath("config.json"), UpdateTxtLogDisplay);
            tpm = new TrojanProcessManager(LitrojanUtils.GetLocalPath("trojan.exe"), UpdateTxtLogDisplay);
            tcm.LoadConfig();

            foreach(var i in panel1.Controls)
            {
                if (i is RadioButton rb && Enum.GetName(typeof(RunMode), tcm.Config.RunMode) == rb.Text)
                {
                    rb.Checked = true;
                    break;
                }
            }

            autosave = new Thread(LitrojanUtils.AutoSave);
            autosave.Start();
        }

        public void DoBinding()
        {
            TxtLocalAddr.DataBindings.Add("Text", tcm.Config, "local_addr");
            TxtLocalPort.DataBindings.Add("Text", tcm.Config, "local_port");
            TxtRemoAddr.DataBindings.Add("Text", tcm.Config, "remote_addr");
            TxtRemoPort.DataBindings.Add("Text", tcm.Config, "remote_port");
            TxtTargetAddr.DataBindings.Add("Text", tcm.Config, "target_addr");
            TxtTargetPort.DataBindings.Add("Text", tcm.Config, "target_port");
            TxtPass.DataBindings.Add("Text", tcm.Config.password, "");
            TxtPass.BindingContext[tcm.Config.password].Position = 0;
            ChkAppendPayload.DataBindings.Add("Checked", tcm.Config, "append_payload");
            ComLogLevel.DataBindings.Add("SelectedIndex", tcm.Config, "log_level");

            ChkVerify.DataBindings.Add("Checked", tcm.Config.ssl, "verify");
            ChkVerifyHost.DataBindings.Add("Checked", tcm.Config.ssl, "verify_hostname");
            TxtCertPath.DataBindings.Add("Text", tcm.Config.ssl, "cert");
            TxtKeyPath.DataBindings.Add("Text", tcm.Config.ssl, "key");
            TxtKeyPass.DataBindings.Add("Text", tcm.Config.ssl, "key_password");
            TxtCipher.DataBindings.Add("Text", tcm.Config.ssl, "cipher");
            ChkServerCipher.DataBindings.Add("Checked", tcm.Config.ssl, "prefer_server_cipher");
            TxtSNI.DataBindings.Add("Text", tcm.Config.ssl, "sni");
            TxtALPN.DataBindings.Add("Text", ALPN, "");
            ChkReuse.DataBindings.Add("Checked", tcm.Config.ssl, "reuse_session");
            TxtTimeout.DataBindings.Add("Text", tcm.Config.ssl, "session_timeout");
            TxtCurves.DataBindings.Add("Text", tcm.Config.ssl, "curves");

            ChkNoDelay.DataBindings.Add("Checked", tcm.Config.tcp, "no_delay");
            ChkKeepAlive.DataBindings.Add("Checked", tcm.Config.tcp, "keep_alive");
            ChkFastOpen.DataBindings.Add("Checked", tcm.Config.tcp, "fast_open");
            TxtQLEN.DataBindings.Add("Text", tcm.Config.tcp, "fast_open_qlen");

            ChkSQLEnabled.DataBindings.Add("Checked", tcm.Config.mysql, "enabled");
            TxtServerAddr.DataBindings.Add("Text", tcm.Config.mysql, "server_addr");
            TxtServerPort.DataBindings.Add("Text", tcm.Config.mysql, "server_port");
            TxtDatabase.DataBindings.Add("Text", tcm.Config.mysql, "database");
            TxtUsername.DataBindings.Add("Text", tcm.Config.mysql, "username");
            TxtSQLPass.DataBindings.Add("Text", tcm.Config.mysql, "password");
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

        public void UpdateTxtLogDisplay(string Infomation, string Source)
        {
            var info = $"[{Source}] {(Source != "TrojanCore" ? $"({DateTime.Now.ToString("s")})" : "")} {Infomation.Trim()}";
            GlobalVaribleHost.LogBuffer.Add(info);
            logHost += $"{info}\r\n";
            ThreadSetText($"{info}\r\n");
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

        #endregion

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
            if (GlobalVaribleHost.TrojanStatus == RunStatus.Stopped)
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
                NotTrayIcon.Visible = true;
                NotTrayIcon.ShowBalloonTip(500);
                NotTrayIcon.Text = $"Litrojan - {Enum.GetName(typeof(RunStatus), GlobalVaribleHost.TrojanStatus)} ({Enum.GetName(typeof(RunMode), tcm.Config.RunMode)})";
                Visible = false;
            }
        }

        private void NotTrayIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Visible = true;
            Activate();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //base.OnFormClosing(e);
            e.Cancel = true;
            NotTrayIcon.Visible = true;
            NotTrayIcon.ShowBalloonTip(500);
            NotTrayIcon.Text = $"Litrojan - {Enum.GetName(typeof(RunStatus), GlobalVaribleHost.TrojanStatus)} ({Enum.GetName(typeof(RunMode), tcm.Config.RunMode)})";
            Visible = false;
        }

        private void restartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tpm.TrojanRestart();
        }

        private void exitLitrojanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            autosave.Abort();
            tpm.TrojanStop();
            UpdateTxtLogDisplay($"Litrojan ({GlobalVaribleHost.LitrojanVer}) Stopped.", "Litrojan");
            LitrojanUtils.AutoIncrementalSave();
            Environment.Exit(0);
        }
    }
}
