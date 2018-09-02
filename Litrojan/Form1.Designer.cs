namespace Litrojan
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.BtnModeSave = new MaterialSkin.Controls.MaterialTabControl();
            this.TabHome = new System.Windows.Forms.TabPage();
            this.LblHomeVersion = new MaterialSkin.Controls.MaterialLabel();
            this.MatLabelBanner = new MaterialSkin.Controls.MaterialLabel();
            this.BtnHomeStart = new MaterialSkin.Controls.MaterialRaisedButton();
            this.TabConfig = new System.Windows.Forms.TabPage();
            this.materialLabel25 = new MaterialSkin.Controls.MaterialLabel();
            this.TxtALPN = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.TxtSNI = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.TxtCipher = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.TxtKeyPass = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.TxtKeyPath = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.TxtCertPath = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.TxtPass = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.TxtRemoPort = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.TxtRemoAddr = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.TxtLocalPort = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.TxtLocalAddr = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel14 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel13 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel12 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel11 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.ComLogLevel = new System.Windows.Forms.ComboBox();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.BtnConfRestore = new MaterialSkin.Controls.MaterialFlatButton();
            this.BtnConfCancel = new MaterialSkin.Controls.MaterialFlatButton();
            this.BtnConfSave = new MaterialSkin.Controls.MaterialRaisedButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.RdoModeS = new MaterialSkin.Controls.MaterialRadioButton();
            this.RdoModeR = new MaterialSkin.Controls.MaterialRadioButton();
            this.RdoModeC = new MaterialSkin.Controls.MaterialRadioButton();
            this.TabMode = new System.Windows.Forms.TabPage();
            this.materialLabel24 = new MaterialSkin.Controls.MaterialLabel();
            this.TxtTargetPort = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.TxtTargetAddr = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel23 = new MaterialSkin.Controls.MaterialLabel();
            this.TxtCurves = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel22 = new MaterialSkin.Controls.MaterialLabel();
            this.TxtTimeout = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel21 = new MaterialSkin.Controls.MaterialLabel();
            this.TxtQLEN = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel20 = new MaterialSkin.Controls.MaterialLabel();
            this.materialDivider2 = new MaterialSkin.Controls.MaterialDivider();
            this.materialLabel19 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel18 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel17 = new MaterialSkin.Controls.MaterialLabel();
            this.TxtSQLPass = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.TxtUsername = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.TxtDatabase = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.ChkSQLEnabled = new MaterialSkin.Controls.MaterialCheckBox();
            this.TxtServerPort = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel16 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel15 = new MaterialSkin.Controls.MaterialLabel();
            this.TxtServerAddr = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.ChkFastOpen = new MaterialSkin.Controls.MaterialCheckBox();
            this.ChkKeepAlive = new MaterialSkin.Controls.MaterialCheckBox();
            this.ChkNoDelay = new MaterialSkin.Controls.MaterialCheckBox();
            this.ChkReuse = new MaterialSkin.Controls.MaterialCheckBox();
            this.ChkServerCipher = new MaterialSkin.Controls.MaterialCheckBox();
            this.ChkVerifyHost = new MaterialSkin.Controls.MaterialCheckBox();
            this.ChkVerify = new MaterialSkin.Controls.MaterialCheckBox();
            this.ChkAppendPayload = new MaterialSkin.Controls.MaterialCheckBox();
            this.BtnAdvnRestore = new MaterialSkin.Controls.MaterialFlatButton();
            this.BtnAdvnCancel = new MaterialSkin.Controls.MaterialFlatButton();
            this.BtnAdvnSave = new MaterialSkin.Controls.MaterialRaisedButton();
            this.TabLog = new System.Windows.Forms.TabPage();
            this.BtnLogSave = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BtnLogCopy = new MaterialSkin.Controls.MaterialFlatButton();
            this.BtnLogClear = new MaterialSkin.Controls.MaterialFlatButton();
            this.TxtLogDisplay = new System.Windows.Forms.TextBox();
            this.TabAbout = new System.Windows.Forms.TabPage();
            this.LblAboutVersion = new MaterialSkin.Controls.MaterialLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.materialLabel26 = new MaterialSkin.Controls.MaterialLabel();
            this.MatTabSelector = new MaterialSkin.Controls.MaterialTabSelector();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.NotTrayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitLitrojanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnModeSave.SuspendLayout();
            this.TabHome.SuspendLayout();
            this.TabConfig.SuspendLayout();
            this.panel1.SuspendLayout();
            this.TabMode.SuspendLayout();
            this.TabLog.SuspendLayout();
            this.TabAbout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnModeSave
            // 
            this.BtnModeSave.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnModeSave.Controls.Add(this.TabHome);
            this.BtnModeSave.Controls.Add(this.TabConfig);
            this.BtnModeSave.Controls.Add(this.TabMode);
            this.BtnModeSave.Controls.Add(this.TabLog);
            this.BtnModeSave.Controls.Add(this.TabAbout);
            this.BtnModeSave.Depth = 0;
            this.BtnModeSave.Location = new System.Drawing.Point(12, 111);
            this.BtnModeSave.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnModeSave.Name = "BtnModeSave";
            this.BtnModeSave.SelectedIndex = 0;
            this.BtnModeSave.Size = new System.Drawing.Size(602, 305);
            this.BtnModeSave.TabIndex = 0;
            // 
            // TabHome
            // 
            this.TabHome.BackColor = System.Drawing.Color.White;
            this.TabHome.Controls.Add(this.LblHomeVersion);
            this.TabHome.Controls.Add(this.MatLabelBanner);
            this.TabHome.Controls.Add(this.BtnHomeStart);
            this.TabHome.Location = new System.Drawing.Point(4, 22);
            this.TabHome.Name = "TabHome";
            this.TabHome.Padding = new System.Windows.Forms.Padding(3);
            this.TabHome.Size = new System.Drawing.Size(594, 279);
            this.TabHome.TabIndex = 0;
            this.TabHome.Text = "Home";
            // 
            // LblHomeVersion
            // 
            this.LblHomeVersion.AutoSize = true;
            this.LblHomeVersion.Depth = 0;
            this.LblHomeVersion.Enabled = false;
            this.LblHomeVersion.Font = new System.Drawing.Font("Roboto", 11F);
            this.LblHomeVersion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblHomeVersion.Location = new System.Drawing.Point(119, 260);
            this.LblHomeVersion.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblHomeVersion.Name = "LblHomeVersion";
            this.LblHomeVersion.Size = new System.Drawing.Size(368, 19);
            this.LblHomeVersion.TabIndex = 2;
            this.LblHomeVersion.Text = "Litrojan Version: DevPre / Trojan Version: 2017/11/11";
            // 
            // MatLabelBanner
            // 
            this.MatLabelBanner.AutoSize = true;
            this.MatLabelBanner.Depth = 0;
            this.MatLabelBanner.Font = new System.Drawing.Font("Roboto", 11F);
            this.MatLabelBanner.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.MatLabelBanner.Location = new System.Drawing.Point(164, 62);
            this.MatLabelBanner.MouseState = MaterialSkin.MouseState.HOVER;
            this.MatLabelBanner.Name = "MatLabelBanner";
            this.MatLabelBanner.Size = new System.Drawing.Size(265, 19);
            this.MatLabelBanner.TabIndex = 2;
            this.MatLabelBanner.Text = "Litrojan - Lite User Interface for Trojan";
            // 
            // BtnHomeStart
            // 
            this.BtnHomeStart.Depth = 0;
            this.BtnHomeStart.Location = new System.Drawing.Point(222, 118);
            this.BtnHomeStart.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnHomeStart.Name = "BtnHomeStart";
            this.BtnHomeStart.Primary = true;
            this.BtnHomeStart.Size = new System.Drawing.Size(150, 44);
            this.BtnHomeStart.TabIndex = 1;
            this.BtnHomeStart.Text = "Start";
            this.BtnHomeStart.UseVisualStyleBackColor = true;
            this.BtnHomeStart.Click += new System.EventHandler(this.BtnHomeStart_Click);
            // 
            // TabConfig
            // 
            this.TabConfig.BackColor = System.Drawing.Color.White;
            this.TabConfig.Controls.Add(this.materialLabel25);
            this.TabConfig.Controls.Add(this.TxtALPN);
            this.TabConfig.Controls.Add(this.TxtSNI);
            this.TabConfig.Controls.Add(this.TxtCipher);
            this.TabConfig.Controls.Add(this.TxtKeyPass);
            this.TabConfig.Controls.Add(this.TxtKeyPath);
            this.TabConfig.Controls.Add(this.TxtCertPath);
            this.TabConfig.Controls.Add(this.TxtPass);
            this.TabConfig.Controls.Add(this.TxtRemoPort);
            this.TabConfig.Controls.Add(this.TxtRemoAddr);
            this.TabConfig.Controls.Add(this.TxtLocalPort);
            this.TabConfig.Controls.Add(this.TxtLocalAddr);
            this.TabConfig.Controls.Add(this.materialLabel14);
            this.TabConfig.Controls.Add(this.materialLabel13);
            this.TabConfig.Controls.Add(this.materialLabel12);
            this.TabConfig.Controls.Add(this.materialLabel11);
            this.TabConfig.Controls.Add(this.materialLabel10);
            this.TabConfig.Controls.Add(this.materialLabel9);
            this.TabConfig.Controls.Add(this.materialDivider1);
            this.TabConfig.Controls.Add(this.materialLabel3);
            this.TabConfig.Controls.Add(this.materialLabel8);
            this.TabConfig.Controls.Add(this.ComLogLevel);
            this.TabConfig.Controls.Add(this.materialLabel7);
            this.TabConfig.Controls.Add(this.materialLabel6);
            this.TabConfig.Controls.Add(this.materialLabel4);
            this.TabConfig.Controls.Add(this.materialLabel5);
            this.TabConfig.Controls.Add(this.materialLabel2);
            this.TabConfig.Controls.Add(this.materialLabel1);
            this.TabConfig.Controls.Add(this.BtnConfRestore);
            this.TabConfig.Controls.Add(this.BtnConfCancel);
            this.TabConfig.Controls.Add(this.BtnConfSave);
            this.TabConfig.Controls.Add(this.panel1);
            this.TabConfig.Location = new System.Drawing.Point(4, 22);
            this.TabConfig.Name = "TabConfig";
            this.TabConfig.Padding = new System.Windows.Forms.Padding(3);
            this.TabConfig.Size = new System.Drawing.Size(594, 279);
            this.TabConfig.TabIndex = 1;
            this.TabConfig.Text = "Config";
            // 
            // materialLabel25
            // 
            this.materialLabel25.AutoSize = true;
            this.materialLabel25.Depth = 0;
            this.materialLabel25.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel25.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel25.Location = new System.Drawing.Point(24, 222);
            this.materialLabel25.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel25.Name = "materialLabel25";
            this.materialLabel25.Size = new System.Drawing.Size(47, 19);
            this.materialLabel25.TabIndex = 46;
            this.materialLabel25.Text = "Mode";
            // 
            // TxtALPN
            // 
            this.TxtALPN.Depth = 0;
            this.TxtALPN.Hint = "";
            this.TxtALPN.Location = new System.Drawing.Point(437, 188);
            this.TxtALPN.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtALPN.Name = "TxtALPN";
            this.TxtALPN.PasswordChar = '\0';
            this.TxtALPN.SelectedText = "";
            this.TxtALPN.SelectionLength = 0;
            this.TxtALPN.SelectionStart = 0;
            this.TxtALPN.Size = new System.Drawing.Size(150, 23);
            this.TxtALPN.TabIndex = 42;
            this.TxtALPN.UseSystemPasswordChar = false;
            this.TxtALPN.TextChanged += new System.EventHandler(this.TxtALPN_TextChanged);
            // 
            // TxtSNI
            // 
            this.TxtSNI.Depth = 0;
            this.TxtSNI.Hint = "";
            this.TxtSNI.Location = new System.Drawing.Point(437, 158);
            this.TxtSNI.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtSNI.Name = "TxtSNI";
            this.TxtSNI.PasswordChar = '\0';
            this.TxtSNI.SelectedText = "";
            this.TxtSNI.SelectionLength = 0;
            this.TxtSNI.SelectionStart = 0;
            this.TxtSNI.Size = new System.Drawing.Size(150, 23);
            this.TxtSNI.TabIndex = 41;
            this.TxtSNI.UseSystemPasswordChar = false;
            // 
            // TxtCipher
            // 
            this.TxtCipher.Depth = 0;
            this.TxtCipher.Hint = "";
            this.TxtCipher.Location = new System.Drawing.Point(437, 127);
            this.TxtCipher.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtCipher.Name = "TxtCipher";
            this.TxtCipher.PasswordChar = '\0';
            this.TxtCipher.SelectedText = "";
            this.TxtCipher.SelectionLength = 0;
            this.TxtCipher.SelectionStart = 0;
            this.TxtCipher.Size = new System.Drawing.Size(150, 23);
            this.TxtCipher.TabIndex = 40;
            this.TxtCipher.UseSystemPasswordChar = false;
            // 
            // TxtKeyPass
            // 
            this.TxtKeyPass.Depth = 0;
            this.TxtKeyPass.Hint = "";
            this.TxtKeyPass.Location = new System.Drawing.Point(437, 97);
            this.TxtKeyPass.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtKeyPass.Name = "TxtKeyPass";
            this.TxtKeyPass.PasswordChar = '●';
            this.TxtKeyPass.SelectedText = "";
            this.TxtKeyPass.SelectionLength = 0;
            this.TxtKeyPass.SelectionStart = 0;
            this.TxtKeyPass.Size = new System.Drawing.Size(150, 23);
            this.TxtKeyPass.TabIndex = 39;
            this.TxtKeyPass.UseSystemPasswordChar = false;
            // 
            // TxtKeyPath
            // 
            this.TxtKeyPath.Depth = 0;
            this.TxtKeyPath.Hint = "";
            this.TxtKeyPath.Location = new System.Drawing.Point(437, 67);
            this.TxtKeyPath.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtKeyPath.Name = "TxtKeyPath";
            this.TxtKeyPath.PasswordChar = '\0';
            this.TxtKeyPath.SelectedText = "";
            this.TxtKeyPath.SelectionLength = 0;
            this.TxtKeyPath.SelectionStart = 0;
            this.TxtKeyPath.Size = new System.Drawing.Size(150, 23);
            this.TxtKeyPath.TabIndex = 38;
            this.TxtKeyPath.UseSystemPasswordChar = false;
            // 
            // TxtCertPath
            // 
            this.TxtCertPath.Depth = 0;
            this.TxtCertPath.Hint = "";
            this.TxtCertPath.Location = new System.Drawing.Point(437, 37);
            this.TxtCertPath.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtCertPath.Name = "TxtCertPath";
            this.TxtCertPath.PasswordChar = '\0';
            this.TxtCertPath.SelectedText = "";
            this.TxtCertPath.SelectionLength = 0;
            this.TxtCertPath.SelectionStart = 0;
            this.TxtCertPath.Size = new System.Drawing.Size(150, 23);
            this.TxtCertPath.TabIndex = 37;
            this.TxtCertPath.UseSystemPasswordChar = false;
            // 
            // TxtPass
            // 
            this.TxtPass.Depth = 0;
            this.TxtPass.Hint = "";
            this.TxtPass.Location = new System.Drawing.Point(130, 158);
            this.TxtPass.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtPass.Name = "TxtPass";
            this.TxtPass.PasswordChar = '●';
            this.TxtPass.SelectedText = "";
            this.TxtPass.SelectionLength = 0;
            this.TxtPass.SelectionStart = 0;
            this.TxtPass.Size = new System.Drawing.Size(150, 23);
            this.TxtPass.TabIndex = 36;
            this.TxtPass.UseSystemPasswordChar = false;
            // 
            // TxtRemoPort
            // 
            this.TxtRemoPort.Depth = 0;
            this.TxtRemoPort.Hint = "";
            this.TxtRemoPort.Location = new System.Drawing.Point(130, 127);
            this.TxtRemoPort.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtRemoPort.Name = "TxtRemoPort";
            this.TxtRemoPort.PasswordChar = '\0';
            this.TxtRemoPort.SelectedText = "";
            this.TxtRemoPort.SelectionLength = 0;
            this.TxtRemoPort.SelectionStart = 0;
            this.TxtRemoPort.Size = new System.Drawing.Size(150, 23);
            this.TxtRemoPort.TabIndex = 35;
            this.TxtRemoPort.UseSystemPasswordChar = false;
            // 
            // TxtRemoAddr
            // 
            this.TxtRemoAddr.Depth = 0;
            this.TxtRemoAddr.Hint = "";
            this.TxtRemoAddr.Location = new System.Drawing.Point(130, 97);
            this.TxtRemoAddr.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtRemoAddr.Name = "TxtRemoAddr";
            this.TxtRemoAddr.PasswordChar = '\0';
            this.TxtRemoAddr.SelectedText = "";
            this.TxtRemoAddr.SelectionLength = 0;
            this.TxtRemoAddr.SelectionStart = 0;
            this.TxtRemoAddr.Size = new System.Drawing.Size(150, 23);
            this.TxtRemoAddr.TabIndex = 34;
            this.TxtRemoAddr.UseSystemPasswordChar = false;
            // 
            // TxtLocalPort
            // 
            this.TxtLocalPort.Depth = 0;
            this.TxtLocalPort.Hint = "";
            this.TxtLocalPort.Location = new System.Drawing.Point(130, 67);
            this.TxtLocalPort.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtLocalPort.Name = "TxtLocalPort";
            this.TxtLocalPort.PasswordChar = '\0';
            this.TxtLocalPort.SelectedText = "";
            this.TxtLocalPort.SelectionLength = 0;
            this.TxtLocalPort.SelectionStart = 0;
            this.TxtLocalPort.Size = new System.Drawing.Size(150, 23);
            this.TxtLocalPort.TabIndex = 33;
            this.TxtLocalPort.UseSystemPasswordChar = false;
            // 
            // TxtLocalAddr
            // 
            this.TxtLocalAddr.Depth = 0;
            this.TxtLocalAddr.Hint = "";
            this.TxtLocalAddr.Location = new System.Drawing.Point(130, 37);
            this.TxtLocalAddr.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtLocalAddr.Name = "TxtLocalAddr";
            this.TxtLocalAddr.PasswordChar = '\0';
            this.TxtLocalAddr.SelectedText = "";
            this.TxtLocalAddr.SelectionLength = 0;
            this.TxtLocalAddr.SelectionStart = 0;
            this.TxtLocalAddr.Size = new System.Drawing.Size(150, 23);
            this.TxtLocalAddr.TabIndex = 32;
            this.TxtLocalAddr.UseSystemPasswordChar = false;
            // 
            // materialLabel14
            // 
            this.materialLabel14.AutoSize = true;
            this.materialLabel14.Depth = 0;
            this.materialLabel14.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel14.Location = new System.Drawing.Point(324, 188);
            this.materialLabel14.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel14.Name = "materialLabel14";
            this.materialLabel14.Size = new System.Drawing.Size(47, 19);
            this.materialLabel14.TabIndex = 30;
            this.materialLabel14.Text = "ALPN";
            // 
            // materialLabel13
            // 
            this.materialLabel13.AutoSize = true;
            this.materialLabel13.Depth = 0;
            this.materialLabel13.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel13.Location = new System.Drawing.Point(324, 158);
            this.materialLabel13.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel13.Name = "materialLabel13";
            this.materialLabel13.Size = new System.Drawing.Size(33, 19);
            this.materialLabel13.TabIndex = 29;
            this.materialLabel13.Text = "SNI";
            // 
            // materialLabel12
            // 
            this.materialLabel12.AutoSize = true;
            this.materialLabel12.Depth = 0;
            this.materialLabel12.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel12.Location = new System.Drawing.Point(324, 127);
            this.materialLabel12.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel12.Name = "materialLabel12";
            this.materialLabel12.Size = new System.Drawing.Size(52, 19);
            this.materialLabel12.TabIndex = 28;
            this.materialLabel12.Text = "Cipher";
            // 
            // materialLabel11
            // 
            this.materialLabel11.AutoSize = true;
            this.materialLabel11.Depth = 0;
            this.materialLabel11.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel11.Location = new System.Drawing.Point(324, 97);
            this.materialLabel11.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel11.Name = "materialLabel11";
            this.materialLabel11.Size = new System.Drawing.Size(103, 19);
            this.materialLabel11.TabIndex = 25;
            this.materialLabel11.Text = "Key Password";
            // 
            // materialLabel10
            // 
            this.materialLabel10.AutoSize = true;
            this.materialLabel10.Depth = 0;
            this.materialLabel10.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel10.Location = new System.Drawing.Point(324, 67);
            this.materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel10.Name = "materialLabel10";
            this.materialLabel10.Size = new System.Drawing.Size(67, 19);
            this.materialLabel10.TabIndex = 24;
            this.materialLabel10.Text = "Key Path";
            // 
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel9.Location = new System.Drawing.Point(324, 37);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(71, 19);
            this.materialLabel9.TabIndex = 20;
            this.materialLabel9.Text = "Cert Path";
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(293, 0);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(1, 300);
            this.materialDivider1.TabIndex = 19;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(307, 8);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(35, 19);
            this.materialLabel3.TabIndex = 18;
            this.materialLabel3.Text = "SSL";
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel8.Location = new System.Drawing.Point(7, 8);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(75, 19);
            this.materialLabel8.TabIndex = 17;
            this.materialLabel8.Text = "GENERAL";
            // 
            // ComLogLevel
            // 
            this.ComLogLevel.FormattingEnabled = true;
            this.ComLogLevel.Items.AddRange(new object[] {
            "All",
            "Info",
            "Warn",
            "Error",
            "Fatal",
            "Off"});
            this.ComLogLevel.Location = new System.Drawing.Point(130, 189);
            this.ComLogLevel.Name = "ComLogLevel";
            this.ComLogLevel.Size = new System.Drawing.Size(150, 21);
            this.ComLogLevel.TabIndex = 16;
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel7.Location = new System.Drawing.Point(24, 188);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(73, 19);
            this.materialLabel7.TabIndex = 15;
            this.materialLabel7.Text = "Log Level";
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(24, 158);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(75, 19);
            this.materialLabel6.TabIndex = 13;
            this.materialLabel6.Text = "Password";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(24, 127);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(93, 19);
            this.materialLabel4.TabIndex = 11;
            this.materialLabel4.Text = "Remote Port";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(24, 97);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(96, 19);
            this.materialLabel5.TabIndex = 9;
            this.materialLabel5.Text = "Remote Addr";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(24, 67);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(78, 19);
            this.materialLabel2.TabIndex = 5;
            this.materialLabel2.Text = "Local Port";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(24, 37);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(81, 19);
            this.materialLabel1.TabIndex = 3;
            this.materialLabel1.Text = "Local Addr";
            // 
            // BtnConfRestore
            // 
            this.BtnConfRestore.AutoSize = true;
            this.BtnConfRestore.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnConfRestore.Depth = 0;
            this.BtnConfRestore.Location = new System.Drawing.Point(435, 241);
            this.BtnConfRestore.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BtnConfRestore.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnConfRestore.Name = "BtnConfRestore";
            this.BtnConfRestore.Primary = false;
            this.BtnConfRestore.Size = new System.Drawing.Size(71, 36);
            this.BtnConfRestore.TabIndex = 2;
            this.BtnConfRestore.Text = "Restore";
            this.BtnConfRestore.UseVisualStyleBackColor = true;
            this.BtnConfRestore.Click += new System.EventHandler(this.BtnConfRestore_Click);
            // 
            // BtnConfCancel
            // 
            this.BtnConfCancel.AutoSize = true;
            this.BtnConfCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnConfCancel.Depth = 0;
            this.BtnConfCancel.Location = new System.Drawing.Point(514, 241);
            this.BtnConfCancel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BtnConfCancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnConfCancel.Name = "BtnConfCancel";
            this.BtnConfCancel.Primary = false;
            this.BtnConfCancel.Size = new System.Drawing.Size(64, 36);
            this.BtnConfCancel.TabIndex = 1;
            this.BtnConfCancel.Text = "Cancel";
            this.BtnConfCancel.UseVisualStyleBackColor = true;
            this.BtnConfCancel.Click += new System.EventHandler(this.BtnConfCancel_Click);
            // 
            // BtnConfSave
            // 
            this.BtnConfSave.Depth = 0;
            this.BtnConfSave.Location = new System.Drawing.Point(353, 241);
            this.BtnConfSave.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnConfSave.Name = "BtnConfSave";
            this.BtnConfSave.Primary = true;
            this.BtnConfSave.Size = new System.Drawing.Size(75, 36);
            this.BtnConfSave.TabIndex = 0;
            this.BtnConfSave.Text = "Save";
            this.BtnConfSave.UseVisualStyleBackColor = true;
            this.BtnConfSave.Click += new System.EventHandler(this.BtnConfSave_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.RdoModeS);
            this.panel1.Controls.Add(this.RdoModeR);
            this.panel1.Controls.Add(this.RdoModeC);
            this.panel1.Location = new System.Drawing.Point(71, 218);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(209, 34);
            this.panel1.TabIndex = 47;
            // 
            // RdoModeS
            // 
            this.RdoModeS.AutoSize = true;
            this.RdoModeS.Depth = 0;
            this.RdoModeS.Font = new System.Drawing.Font("Roboto", 10F);
            this.RdoModeS.Location = new System.Drawing.Point(0, 0);
            this.RdoModeS.Margin = new System.Windows.Forms.Padding(0);
            this.RdoModeS.MouseLocation = new System.Drawing.Point(-1, -1);
            this.RdoModeS.MouseState = MaterialSkin.MouseState.HOVER;
            this.RdoModeS.Name = "RdoModeS";
            this.RdoModeS.Ripple = true;
            this.RdoModeS.Size = new System.Drawing.Size(68, 30);
            this.RdoModeS.TabIndex = 43;
            this.RdoModeS.TabStop = true;
            this.RdoModeS.Text = "Server";
            this.RdoModeS.UseVisualStyleBackColor = true;
            this.RdoModeS.CheckedChanged += new System.EventHandler(this.RdoMode_CheckedChanged);
            // 
            // RdoModeR
            // 
            this.RdoModeR.AutoSize = true;
            this.RdoModeR.Depth = 0;
            this.RdoModeR.Font = new System.Drawing.Font("Roboto", 10F);
            this.RdoModeR.Location = new System.Drawing.Point(132, 0);
            this.RdoModeR.Margin = new System.Windows.Forms.Padding(0);
            this.RdoModeR.MouseLocation = new System.Drawing.Point(-1, -1);
            this.RdoModeR.MouseState = MaterialSkin.MouseState.HOVER;
            this.RdoModeR.Name = "RdoModeR";
            this.RdoModeR.Ripple = true;
            this.RdoModeR.Size = new System.Drawing.Size(70, 30);
            this.RdoModeR.TabIndex = 45;
            this.RdoModeR.TabStop = true;
            this.RdoModeR.Text = "Router";
            this.RdoModeR.UseVisualStyleBackColor = true;
            this.RdoModeR.CheckedChanged += new System.EventHandler(this.RdoMode_CheckedChanged);
            // 
            // RdoModeC
            // 
            this.RdoModeC.AutoSize = true;
            this.RdoModeC.Depth = 0;
            this.RdoModeC.Font = new System.Drawing.Font("Roboto", 10F);
            this.RdoModeC.Location = new System.Drawing.Point(68, 0);
            this.RdoModeC.Margin = new System.Windows.Forms.Padding(0);
            this.RdoModeC.MouseLocation = new System.Drawing.Point(-1, -1);
            this.RdoModeC.MouseState = MaterialSkin.MouseState.HOVER;
            this.RdoModeC.Name = "RdoModeC";
            this.RdoModeC.Ripple = true;
            this.RdoModeC.Size = new System.Drawing.Size(64, 30);
            this.RdoModeC.TabIndex = 44;
            this.RdoModeC.TabStop = true;
            this.RdoModeC.Text = "Client";
            this.RdoModeC.UseVisualStyleBackColor = true;
            this.RdoModeC.CheckedChanged += new System.EventHandler(this.RdoMode_CheckedChanged);
            // 
            // TabMode
            // 
            this.TabMode.BackColor = System.Drawing.Color.White;
            this.TabMode.Controls.Add(this.materialLabel24);
            this.TabMode.Controls.Add(this.TxtTargetPort);
            this.TabMode.Controls.Add(this.TxtTargetAddr);
            this.TabMode.Controls.Add(this.materialLabel23);
            this.TabMode.Controls.Add(this.TxtCurves);
            this.TabMode.Controls.Add(this.materialLabel22);
            this.TabMode.Controls.Add(this.TxtTimeout);
            this.TabMode.Controls.Add(this.materialLabel21);
            this.TabMode.Controls.Add(this.TxtQLEN);
            this.TabMode.Controls.Add(this.materialLabel20);
            this.TabMode.Controls.Add(this.materialDivider2);
            this.TabMode.Controls.Add(this.materialLabel19);
            this.TabMode.Controls.Add(this.materialLabel18);
            this.TabMode.Controls.Add(this.materialLabel17);
            this.TabMode.Controls.Add(this.TxtSQLPass);
            this.TabMode.Controls.Add(this.TxtUsername);
            this.TabMode.Controls.Add(this.TxtDatabase);
            this.TabMode.Controls.Add(this.ChkSQLEnabled);
            this.TabMode.Controls.Add(this.TxtServerPort);
            this.TabMode.Controls.Add(this.materialLabel16);
            this.TabMode.Controls.Add(this.materialLabel15);
            this.TabMode.Controls.Add(this.TxtServerAddr);
            this.TabMode.Controls.Add(this.ChkFastOpen);
            this.TabMode.Controls.Add(this.ChkKeepAlive);
            this.TabMode.Controls.Add(this.ChkNoDelay);
            this.TabMode.Controls.Add(this.ChkReuse);
            this.TabMode.Controls.Add(this.ChkServerCipher);
            this.TabMode.Controls.Add(this.ChkVerifyHost);
            this.TabMode.Controls.Add(this.ChkVerify);
            this.TabMode.Controls.Add(this.ChkAppendPayload);
            this.TabMode.Controls.Add(this.BtnAdvnRestore);
            this.TabMode.Controls.Add(this.BtnAdvnCancel);
            this.TabMode.Controls.Add(this.BtnAdvnSave);
            this.TabMode.Location = new System.Drawing.Point(4, 22);
            this.TabMode.Name = "TabMode";
            this.TabMode.Padding = new System.Windows.Forms.Padding(3);
            this.TabMode.Size = new System.Drawing.Size(594, 279);
            this.TabMode.TabIndex = 2;
            this.TabMode.Text = "Advanced";
            // 
            // materialLabel24
            // 
            this.materialLabel24.AutoSize = true;
            this.materialLabel24.Depth = 0;
            this.materialLabel24.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel24.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel24.Location = new System.Drawing.Point(10, 240);
            this.materialLabel24.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel24.Name = "materialLabel24";
            this.materialLabel24.Size = new System.Drawing.Size(84, 19);
            this.materialLabel24.TabIndex = 35;
            this.materialLabel24.Text = "Target Port";
            // 
            // TxtTargetPort
            // 
            this.TxtTargetPort.Depth = 0;
            this.TxtTargetPort.Hint = "";
            this.TxtTargetPort.Location = new System.Drawing.Point(103, 240);
            this.TxtTargetPort.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtTargetPort.Name = "TxtTargetPort";
            this.TxtTargetPort.PasswordChar = '\0';
            this.TxtTargetPort.SelectedText = "";
            this.TxtTargetPort.SelectionLength = 0;
            this.TxtTargetPort.SelectionStart = 0;
            this.TxtTargetPort.Size = new System.Drawing.Size(186, 23);
            this.TxtTargetPort.TabIndex = 34;
            this.TxtTargetPort.UseSystemPasswordChar = false;
            // 
            // TxtTargetAddr
            // 
            this.TxtTargetAddr.Depth = 0;
            this.TxtTargetAddr.Hint = "";
            this.TxtTargetAddr.Location = new System.Drawing.Point(103, 210);
            this.TxtTargetAddr.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtTargetAddr.Name = "TxtTargetAddr";
            this.TxtTargetAddr.PasswordChar = '\0';
            this.TxtTargetAddr.SelectedText = "";
            this.TxtTargetAddr.SelectionLength = 0;
            this.TxtTargetAddr.SelectionStart = 0;
            this.TxtTargetAddr.Size = new System.Drawing.Size(186, 23);
            this.TxtTargetAddr.TabIndex = 33;
            this.TxtTargetAddr.UseSystemPasswordChar = false;
            // 
            // materialLabel23
            // 
            this.materialLabel23.AutoSize = true;
            this.materialLabel23.Depth = 0;
            this.materialLabel23.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel23.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel23.Location = new System.Drawing.Point(10, 210);
            this.materialLabel23.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel23.Name = "materialLabel23";
            this.materialLabel23.Size = new System.Drawing.Size(87, 19);
            this.materialLabel23.TabIndex = 32;
            this.materialLabel23.Text = "Target Addr";
            // 
            // TxtCurves
            // 
            this.TxtCurves.Depth = 0;
            this.TxtCurves.Hint = "";
            this.TxtCurves.Location = new System.Drawing.Point(71, 180);
            this.TxtCurves.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtCurves.Name = "TxtCurves";
            this.TxtCurves.PasswordChar = '\0';
            this.TxtCurves.SelectedText = "";
            this.TxtCurves.SelectionLength = 0;
            this.TxtCurves.SelectionStart = 0;
            this.TxtCurves.Size = new System.Drawing.Size(218, 23);
            this.TxtCurves.TabIndex = 31;
            this.TxtCurves.UseSystemPasswordChar = false;
            // 
            // materialLabel22
            // 
            this.materialLabel22.AutoSize = true;
            this.materialLabel22.Depth = 0;
            this.materialLabel22.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel22.Location = new System.Drawing.Point(10, 180);
            this.materialLabel22.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel22.Name = "materialLabel22";
            this.materialLabel22.Size = new System.Drawing.Size(55, 19);
            this.materialLabel22.TabIndex = 30;
            this.materialLabel22.Text = "Curves";
            // 
            // TxtTimeout
            // 
            this.TxtTimeout.Depth = 0;
            this.TxtTimeout.Hint = "";
            this.TxtTimeout.Location = new System.Drawing.Point(231, 147);
            this.TxtTimeout.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtTimeout.Name = "TxtTimeout";
            this.TxtTimeout.PasswordChar = '\0';
            this.TxtTimeout.SelectedText = "";
            this.TxtTimeout.SelectionLength = 0;
            this.TxtTimeout.SelectionStart = 0;
            this.TxtTimeout.Size = new System.Drawing.Size(58, 23);
            this.TxtTimeout.TabIndex = 29;
            this.TxtTimeout.UseSystemPasswordChar = false;
            // 
            // materialLabel21
            // 
            this.materialLabel21.AutoSize = true;
            this.materialLabel21.Depth = 0;
            this.materialLabel21.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel21.Location = new System.Drawing.Point(167, 147);
            this.materialLabel21.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel21.Name = "materialLabel21";
            this.materialLabel21.Size = new System.Drawing.Size(65, 19);
            this.materialLabel21.TabIndex = 28;
            this.materialLabel21.Text = "Timeout";
            // 
            // TxtQLEN
            // 
            this.TxtQLEN.Depth = 0;
            this.TxtQLEN.Hint = "";
            this.TxtQLEN.Location = new System.Drawing.Point(214, 114);
            this.TxtQLEN.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtQLEN.Name = "TxtQLEN";
            this.TxtQLEN.PasswordChar = '\0';
            this.TxtQLEN.SelectedText = "";
            this.TxtQLEN.SelectionLength = 0;
            this.TxtQLEN.SelectionStart = 0;
            this.TxtQLEN.Size = new System.Drawing.Size(75, 23);
            this.TxtQLEN.TabIndex = 27;
            this.TxtQLEN.UseSystemPasswordChar = false;
            // 
            // materialLabel20
            // 
            this.materialLabel20.AutoSize = true;
            this.materialLabel20.Depth = 0;
            this.materialLabel20.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel20.Location = new System.Drawing.Point(167, 114);
            this.materialLabel20.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel20.Name = "materialLabel20";
            this.materialLabel20.Size = new System.Drawing.Size(47, 19);
            this.materialLabel20.TabIndex = 26;
            this.materialLabel20.Text = "QLEN";
            // 
            // materialDivider2
            // 
            this.materialDivider2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider2.Depth = 0;
            this.materialDivider2.Location = new System.Drawing.Point(300, 2);
            this.materialDivider2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider2.Name = "materialDivider2";
            this.materialDivider2.Size = new System.Drawing.Size(1, 300);
            this.materialDivider2.TabIndex = 25;
            this.materialDivider2.Text = "materialDivider2";
            // 
            // materialLabel19
            // 
            this.materialLabel19.AutoSize = true;
            this.materialLabel19.Depth = 0;
            this.materialLabel19.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel19.Location = new System.Drawing.Point(310, 171);
            this.materialLabel19.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel19.Name = "materialLabel19";
            this.materialLabel19.Size = new System.Drawing.Size(75, 19);
            this.materialLabel19.TabIndex = 24;
            this.materialLabel19.Text = "Password";
            // 
            // materialLabel18
            // 
            this.materialLabel18.AutoSize = true;
            this.materialLabel18.Depth = 0;
            this.materialLabel18.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel18.Location = new System.Drawing.Point(310, 138);
            this.materialLabel18.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel18.Name = "materialLabel18";
            this.materialLabel18.Size = new System.Drawing.Size(77, 19);
            this.materialLabel18.TabIndex = 23;
            this.materialLabel18.Text = "Username";
            // 
            // materialLabel17
            // 
            this.materialLabel17.AutoSize = true;
            this.materialLabel17.Depth = 0;
            this.materialLabel17.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel17.Location = new System.Drawing.Point(310, 105);
            this.materialLabel17.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel17.Name = "materialLabel17";
            this.materialLabel17.Size = new System.Drawing.Size(72, 19);
            this.materialLabel17.TabIndex = 22;
            this.materialLabel17.Text = "Database";
            // 
            // TxtSQLPass
            // 
            this.TxtSQLPass.Depth = 0;
            this.TxtSQLPass.Hint = "";
            this.TxtSQLPass.Location = new System.Drawing.Point(395, 171);
            this.TxtSQLPass.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtSQLPass.Name = "TxtSQLPass";
            this.TxtSQLPass.PasswordChar = '●';
            this.TxtSQLPass.SelectedText = "";
            this.TxtSQLPass.SelectionLength = 0;
            this.TxtSQLPass.SelectionStart = 0;
            this.TxtSQLPass.Size = new System.Drawing.Size(192, 23);
            this.TxtSQLPass.TabIndex = 21;
            this.TxtSQLPass.UseSystemPasswordChar = false;
            // 
            // TxtUsername
            // 
            this.TxtUsername.Depth = 0;
            this.TxtUsername.Hint = "";
            this.TxtUsername.Location = new System.Drawing.Point(395, 138);
            this.TxtUsername.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtUsername.Name = "TxtUsername";
            this.TxtUsername.PasswordChar = '\0';
            this.TxtUsername.SelectedText = "";
            this.TxtUsername.SelectionLength = 0;
            this.TxtUsername.SelectionStart = 0;
            this.TxtUsername.Size = new System.Drawing.Size(192, 23);
            this.TxtUsername.TabIndex = 20;
            this.TxtUsername.UseSystemPasswordChar = false;
            // 
            // TxtDatabase
            // 
            this.TxtDatabase.Depth = 0;
            this.TxtDatabase.Hint = "";
            this.TxtDatabase.Location = new System.Drawing.Point(395, 105);
            this.TxtDatabase.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtDatabase.Name = "TxtDatabase";
            this.TxtDatabase.PasswordChar = '\0';
            this.TxtDatabase.SelectedText = "";
            this.TxtDatabase.SelectionLength = 0;
            this.TxtDatabase.SelectionStart = 0;
            this.TxtDatabase.Size = new System.Drawing.Size(192, 23);
            this.TxtDatabase.TabIndex = 19;
            this.TxtDatabase.UseSystemPasswordChar = false;
            // 
            // ChkSQLEnabled
            // 
            this.ChkSQLEnabled.AutoSize = true;
            this.ChkSQLEnabled.Depth = 0;
            this.ChkSQLEnabled.Font = new System.Drawing.Font("Roboto", 10F);
            this.ChkSQLEnabled.Location = new System.Drawing.Point(308, 7);
            this.ChkSQLEnabled.Margin = new System.Windows.Forms.Padding(0);
            this.ChkSQLEnabled.MouseLocation = new System.Drawing.Point(-1, -1);
            this.ChkSQLEnabled.MouseState = MaterialSkin.MouseState.HOVER;
            this.ChkSQLEnabled.Name = "ChkSQLEnabled";
            this.ChkSQLEnabled.Ripple = true;
            this.ChkSQLEnabled.Size = new System.Drawing.Size(166, 30);
            this.ChkSQLEnabled.TabIndex = 18;
            this.ChkSQLEnabled.Text = "Authenticator Enabled";
            this.ChkSQLEnabled.UseVisualStyleBackColor = true;
            // 
            // TxtServerPort
            // 
            this.TxtServerPort.Depth = 0;
            this.TxtServerPort.Hint = "";
            this.TxtServerPort.Location = new System.Drawing.Point(395, 72);
            this.TxtServerPort.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtServerPort.Name = "TxtServerPort";
            this.TxtServerPort.PasswordChar = '\0';
            this.TxtServerPort.SelectedText = "";
            this.TxtServerPort.SelectionLength = 0;
            this.TxtServerPort.SelectionStart = 0;
            this.TxtServerPort.Size = new System.Drawing.Size(192, 23);
            this.TxtServerPort.TabIndex = 17;
            this.TxtServerPort.UseSystemPasswordChar = false;
            // 
            // materialLabel16
            // 
            this.materialLabel16.AutoSize = true;
            this.materialLabel16.Depth = 0;
            this.materialLabel16.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel16.Location = new System.Drawing.Point(310, 72);
            this.materialLabel16.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel16.Name = "materialLabel16";
            this.materialLabel16.Size = new System.Drawing.Size(83, 19);
            this.materialLabel16.TabIndex = 16;
            this.materialLabel16.Text = "Server Port";
            // 
            // materialLabel15
            // 
            this.materialLabel15.AutoSize = true;
            this.materialLabel15.Depth = 0;
            this.materialLabel15.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel15.Location = new System.Drawing.Point(310, 39);
            this.materialLabel15.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel15.Name = "materialLabel15";
            this.materialLabel15.Size = new System.Drawing.Size(86, 19);
            this.materialLabel15.TabIndex = 15;
            this.materialLabel15.Text = "Server Addr";
            // 
            // TxtServerAddr
            // 
            this.TxtServerAddr.Depth = 0;
            this.TxtServerAddr.Hint = "";
            this.TxtServerAddr.Location = new System.Drawing.Point(395, 39);
            this.TxtServerAddr.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtServerAddr.Name = "TxtServerAddr";
            this.TxtServerAddr.PasswordChar = '\0';
            this.TxtServerAddr.SelectedText = "";
            this.TxtServerAddr.SelectionLength = 0;
            this.TxtServerAddr.SelectionStart = 0;
            this.TxtServerAddr.Size = new System.Drawing.Size(192, 23);
            this.TxtServerAddr.TabIndex = 14;
            this.TxtServerAddr.UseSystemPasswordChar = false;
            // 
            // ChkFastOpen
            // 
            this.ChkFastOpen.AutoSize = true;
            this.ChkFastOpen.Depth = 0;
            this.ChkFastOpen.Font = new System.Drawing.Font("Roboto", 10F);
            this.ChkFastOpen.Location = new System.Drawing.Point(165, 75);
            this.ChkFastOpen.Margin = new System.Windows.Forms.Padding(0);
            this.ChkFastOpen.MouseLocation = new System.Drawing.Point(-1, -1);
            this.ChkFastOpen.MouseState = MaterialSkin.MouseState.HOVER;
            this.ChkFastOpen.Name = "ChkFastOpen";
            this.ChkFastOpen.Ripple = true;
            this.ChkFastOpen.Size = new System.Drawing.Size(122, 30);
            this.ChkFastOpen.TabIndex = 13;
            this.ChkFastOpen.Text = "TCP Fast Open";
            this.ChkFastOpen.UseVisualStyleBackColor = true;
            // 
            // ChkKeepAlive
            // 
            this.ChkKeepAlive.AutoSize = true;
            this.ChkKeepAlive.Depth = 0;
            this.ChkKeepAlive.Font = new System.Drawing.Font("Roboto", 10F);
            this.ChkKeepAlive.Location = new System.Drawing.Point(165, 41);
            this.ChkKeepAlive.Margin = new System.Windows.Forms.Padding(0);
            this.ChkKeepAlive.MouseLocation = new System.Drawing.Point(-1, -1);
            this.ChkKeepAlive.MouseState = MaterialSkin.MouseState.HOVER;
            this.ChkKeepAlive.Name = "ChkKeepAlive";
            this.ChkKeepAlive.Ripple = true;
            this.ChkKeepAlive.Size = new System.Drawing.Size(124, 30);
            this.ChkKeepAlive.TabIndex = 12;
            this.ChkKeepAlive.Text = "TCP Keep Alive";
            this.ChkKeepAlive.UseVisualStyleBackColor = true;
            // 
            // ChkNoDelay
            // 
            this.ChkNoDelay.AutoSize = true;
            this.ChkNoDelay.Depth = 0;
            this.ChkNoDelay.Font = new System.Drawing.Font("Roboto", 10F);
            this.ChkNoDelay.Location = new System.Drawing.Point(165, 7);
            this.ChkNoDelay.Margin = new System.Windows.Forms.Padding(0);
            this.ChkNoDelay.MouseLocation = new System.Drawing.Point(-1, -1);
            this.ChkNoDelay.MouseState = MaterialSkin.MouseState.HOVER;
            this.ChkNoDelay.Name = "ChkNoDelay";
            this.ChkNoDelay.Ripple = true;
            this.ChkNoDelay.Size = new System.Drawing.Size(114, 30);
            this.ChkNoDelay.TabIndex = 11;
            this.ChkNoDelay.Text = "TCP No Delay";
            this.ChkNoDelay.UseVisualStyleBackColor = true;
            // 
            // ChkReuse
            // 
            this.ChkReuse.AutoSize = true;
            this.ChkReuse.Depth = 0;
            this.ChkReuse.Font = new System.Drawing.Font("Roboto", 10F);
            this.ChkReuse.Location = new System.Drawing.Point(7, 143);
            this.ChkReuse.Margin = new System.Windows.Forms.Padding(0);
            this.ChkReuse.MouseLocation = new System.Drawing.Point(-1, -1);
            this.ChkReuse.MouseState = MaterialSkin.MouseState.HOVER;
            this.ChkReuse.Name = "ChkReuse";
            this.ChkReuse.Ripple = true;
            this.ChkReuse.Size = new System.Drawing.Size(120, 30);
            this.ChkReuse.TabIndex = 10;
            this.ChkReuse.Text = "Reuse Session";
            this.ChkReuse.UseVisualStyleBackColor = true;
            // 
            // ChkServerCipher
            // 
            this.ChkServerCipher.AutoSize = true;
            this.ChkServerCipher.Depth = 0;
            this.ChkServerCipher.Font = new System.Drawing.Font("Roboto", 10F);
            this.ChkServerCipher.Location = new System.Drawing.Point(7, 109);
            this.ChkServerCipher.Margin = new System.Windows.Forms.Padding(0);
            this.ChkServerCipher.MouseLocation = new System.Drawing.Point(-1, -1);
            this.ChkServerCipher.MouseState = MaterialSkin.MouseState.HOVER;
            this.ChkServerCipher.Name = "ChkServerCipher";
            this.ChkServerCipher.Ripple = true;
            this.ChkServerCipher.Size = new System.Drawing.Size(154, 30);
            this.ChkServerCipher.TabIndex = 9;
            this.ChkServerCipher.Text = "Prefer Server Cipher";
            this.ChkServerCipher.UseVisualStyleBackColor = true;
            // 
            // ChkVerifyHost
            // 
            this.ChkVerifyHost.AutoSize = true;
            this.ChkVerifyHost.Depth = 0;
            this.ChkVerifyHost.Font = new System.Drawing.Font("Roboto", 10F);
            this.ChkVerifyHost.Location = new System.Drawing.Point(7, 75);
            this.ChkVerifyHost.Margin = new System.Windows.Forms.Padding(0);
            this.ChkVerifyHost.MouseLocation = new System.Drawing.Point(-1, -1);
            this.ChkVerifyHost.MouseState = MaterialSkin.MouseState.HOVER;
            this.ChkVerifyHost.Name = "ChkVerifyHost";
            this.ChkVerifyHost.Ripple = true;
            this.ChkVerifyHost.Size = new System.Drawing.Size(133, 30);
            this.ChkVerifyHost.TabIndex = 8;
            this.ChkVerifyHost.Text = "Verify Hostname";
            this.ChkVerifyHost.UseVisualStyleBackColor = true;
            // 
            // ChkVerify
            // 
            this.ChkVerify.AutoSize = true;
            this.ChkVerify.Depth = 0;
            this.ChkVerify.Font = new System.Drawing.Font("Roboto", 10F);
            this.ChkVerify.Location = new System.Drawing.Point(7, 41);
            this.ChkVerify.Margin = new System.Windows.Forms.Padding(0);
            this.ChkVerify.MouseLocation = new System.Drawing.Point(-1, -1);
            this.ChkVerify.MouseState = MaterialSkin.MouseState.HOVER;
            this.ChkVerify.Name = "ChkVerify";
            this.ChkVerify.Ripple = true;
            this.ChkVerify.Size = new System.Drawing.Size(95, 30);
            this.ChkVerify.TabIndex = 7;
            this.ChkVerify.Text = "Verify Cert";
            this.ChkVerify.UseVisualStyleBackColor = true;
            // 
            // ChkAppendPayload
            // 
            this.ChkAppendPayload.AutoSize = true;
            this.ChkAppendPayload.Depth = 0;
            this.ChkAppendPayload.Font = new System.Drawing.Font("Roboto", 10F);
            this.ChkAppendPayload.Location = new System.Drawing.Point(7, 7);
            this.ChkAppendPayload.Margin = new System.Windows.Forms.Padding(0);
            this.ChkAppendPayload.MouseLocation = new System.Drawing.Point(-1, -1);
            this.ChkAppendPayload.MouseState = MaterialSkin.MouseState.HOVER;
            this.ChkAppendPayload.Name = "ChkAppendPayload";
            this.ChkAppendPayload.Ripple = true;
            this.ChkAppendPayload.Size = new System.Drawing.Size(130, 30);
            this.ChkAppendPayload.TabIndex = 6;
            this.ChkAppendPayload.Text = "Append Payload";
            this.ChkAppendPayload.UseVisualStyleBackColor = true;
            // 
            // BtnAdvnRestore
            // 
            this.BtnAdvnRestore.AutoSize = true;
            this.BtnAdvnRestore.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnAdvnRestore.Depth = 0;
            this.BtnAdvnRestore.Location = new System.Drawing.Point(444, 241);
            this.BtnAdvnRestore.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BtnAdvnRestore.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnAdvnRestore.Name = "BtnAdvnRestore";
            this.BtnAdvnRestore.Primary = false;
            this.BtnAdvnRestore.Size = new System.Drawing.Size(71, 36);
            this.BtnAdvnRestore.TabIndex = 5;
            this.BtnAdvnRestore.Text = "Restore";
            this.BtnAdvnRestore.UseVisualStyleBackColor = true;
            this.BtnAdvnRestore.Click += new System.EventHandler(this.BtnConfRestore_Click);
            // 
            // BtnAdvnCancel
            // 
            this.BtnAdvnCancel.AutoSize = true;
            this.BtnAdvnCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnAdvnCancel.Depth = 0;
            this.BtnAdvnCancel.Location = new System.Drawing.Point(523, 241);
            this.BtnAdvnCancel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BtnAdvnCancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnAdvnCancel.Name = "BtnAdvnCancel";
            this.BtnAdvnCancel.Primary = false;
            this.BtnAdvnCancel.Size = new System.Drawing.Size(64, 36);
            this.BtnAdvnCancel.TabIndex = 4;
            this.BtnAdvnCancel.Text = "Cancel";
            this.BtnAdvnCancel.UseVisualStyleBackColor = true;
            this.BtnAdvnCancel.Click += new System.EventHandler(this.BtnConfCancel_Click);
            // 
            // BtnAdvnSave
            // 
            this.BtnAdvnSave.Depth = 0;
            this.BtnAdvnSave.Location = new System.Drawing.Point(362, 241);
            this.BtnAdvnSave.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnAdvnSave.Name = "BtnAdvnSave";
            this.BtnAdvnSave.Primary = true;
            this.BtnAdvnSave.Size = new System.Drawing.Size(75, 36);
            this.BtnAdvnSave.TabIndex = 3;
            this.BtnAdvnSave.Text = "Save";
            this.BtnAdvnSave.UseVisualStyleBackColor = true;
            this.BtnAdvnSave.Click += new System.EventHandler(this.BtnConfSave_Click);
            // 
            // TabLog
            // 
            this.TabLog.BackColor = System.Drawing.Color.White;
            this.TabLog.Controls.Add(this.BtnLogSave);
            this.TabLog.Controls.Add(this.BtnLogCopy);
            this.TabLog.Controls.Add(this.BtnLogClear);
            this.TabLog.Controls.Add(this.TxtLogDisplay);
            this.TabLog.Location = new System.Drawing.Point(4, 22);
            this.TabLog.Name = "TabLog";
            this.TabLog.Padding = new System.Windows.Forms.Padding(3);
            this.TabLog.Size = new System.Drawing.Size(594, 279);
            this.TabLog.TabIndex = 3;
            this.TabLog.Text = "Log";
            // 
            // BtnLogSave
            // 
            this.BtnLogSave.Depth = 0;
            this.BtnLogSave.Location = new System.Drawing.Point(349, 241);
            this.BtnLogSave.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnLogSave.Name = "BtnLogSave";
            this.BtnLogSave.Primary = true;
            this.BtnLogSave.Size = new System.Drawing.Size(112, 36);
            this.BtnLogSave.TabIndex = 3;
            this.BtnLogSave.Text = "Save To File";
            this.BtnLogSave.UseVisualStyleBackColor = true;
            this.BtnLogSave.Click += new System.EventHandler(this.BtnLogSave_Click);
            // 
            // BtnLogCopy
            // 
            this.BtnLogCopy.AutoSize = true;
            this.BtnLogCopy.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnLogCopy.Depth = 0;
            this.BtnLogCopy.Location = new System.Drawing.Point(468, 241);
            this.BtnLogCopy.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BtnLogCopy.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnLogCopy.Name = "BtnLogCopy";
            this.BtnLogCopy.Primary = false;
            this.BtnLogCopy.Size = new System.Drawing.Size(48, 36);
            this.BtnLogCopy.TabIndex = 2;
            this.BtnLogCopy.Text = "Copy";
            this.BtnLogCopy.UseVisualStyleBackColor = true;
            this.BtnLogCopy.Click += new System.EventHandler(this.BtnLogCopy_Click);
            // 
            // BtnLogClear
            // 
            this.BtnLogClear.AutoSize = true;
            this.BtnLogClear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnLogClear.Depth = 0;
            this.BtnLogClear.Location = new System.Drawing.Point(524, 241);
            this.BtnLogClear.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BtnLogClear.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnLogClear.Name = "BtnLogClear";
            this.BtnLogClear.Primary = false;
            this.BtnLogClear.Size = new System.Drawing.Size(54, 36);
            this.BtnLogClear.TabIndex = 1;
            this.BtnLogClear.Text = "Clear";
            this.BtnLogClear.UseVisualStyleBackColor = true;
            this.BtnLogClear.Click += new System.EventHandler(this.BtnLogClear_Click);
            // 
            // TxtLogDisplay
            // 
            this.TxtLogDisplay.Location = new System.Drawing.Point(6, 6);
            this.TxtLogDisplay.Multiline = true;
            this.TxtLogDisplay.Name = "TxtLogDisplay";
            this.TxtLogDisplay.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtLogDisplay.Size = new System.Drawing.Size(579, 229);
            this.TxtLogDisplay.TabIndex = 0;
            // 
            // TabAbout
            // 
            this.TabAbout.BackColor = System.Drawing.Color.White;
            this.TabAbout.Controls.Add(this.LblAboutVersion);
            this.TabAbout.Controls.Add(this.pictureBox1);
            this.TabAbout.Controls.Add(this.materialLabel26);
            this.TabAbout.Location = new System.Drawing.Point(4, 22);
            this.TabAbout.Name = "TabAbout";
            this.TabAbout.Padding = new System.Windows.Forms.Padding(3);
            this.TabAbout.Size = new System.Drawing.Size(594, 279);
            this.TabAbout.TabIndex = 4;
            this.TabAbout.Text = "About";
            // 
            // LblAboutVersion
            // 
            this.LblAboutVersion.AutoSize = true;
            this.LblAboutVersion.Depth = 0;
            this.LblAboutVersion.Font = new System.Drawing.Font("Roboto", 11F);
            this.LblAboutVersion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblAboutVersion.Location = new System.Drawing.Point(219, 163);
            this.LblAboutVersion.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblAboutVersion.Name = "LblAboutVersion";
            this.LblAboutVersion.Size = new System.Drawing.Size(155, 19);
            this.LblAboutVersion.TabIndex = 2;
            this.LblAboutVersion.Text = "Litrojan (Dev Preview)";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Litrojan.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(247, 48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // materialLabel26
            // 
            this.materialLabel26.AutoSize = true;
            this.materialLabel26.Depth = 0;
            this.materialLabel26.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel26.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel26.Location = new System.Drawing.Point(180, 194);
            this.materialLabel26.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel26.Name = "materialLabel26";
            this.materialLabel26.Size = new System.Drawing.Size(233, 19);
            this.materialLabel26.TabIndex = 0;
            this.materialLabel26.Text = "Made with 💗 by Chigusa Yakumo";
            // 
            // MatTabSelector
            // 
            this.MatTabSelector.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MatTabSelector.BaseTabControl = this.BtnModeSave;
            this.MatTabSelector.Depth = 0;
            this.MatTabSelector.Location = new System.Drawing.Point(0, 64);
            this.MatTabSelector.MouseState = MaterialSkin.MouseState.HOVER;
            this.MatTabSelector.Name = "MatTabSelector";
            this.MatTabSelector.Size = new System.Drawing.Size(625, 48);
            this.MatTabSelector.TabIndex = 1;
            this.MatTabSelector.Text = "materialTabSelector1";
            // 
            // NotTrayIcon
            // 
            this.NotTrayIcon.BalloonTipText = "Litrojan has minimized to notification area.";
            this.NotTrayIcon.BalloonTipTitle = "Litrojan";
            this.NotTrayIcon.ContextMenuStrip = this.contextMenuStrip1;
            this.NotTrayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("NotTrayIcon.Icon")));
            this.NotTrayIcon.Text = "Litrojan is running";
            this.NotTrayIcon.Visible = true;
            this.NotTrayIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.NotTrayIcon_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startToolStripMenuItem,
            this.restartToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitLitrojanToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(147, 76);
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.startToolStripMenuItem.Text = "Start Trojan";
            this.startToolStripMenuItem.Click += new System.EventHandler(this.BtnHomeStart_Click);
            // 
            // restartToolStripMenuItem
            // 
            this.restartToolStripMenuItem.Name = "restartToolStripMenuItem";
            this.restartToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.restartToolStripMenuItem.Text = "Restart Trojan";
            this.restartToolStripMenuItem.Click += new System.EventHandler(this.restartToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(143, 6);
            // 
            // exitLitrojanToolStripMenuItem
            // 
            this.exitLitrojanToolStripMenuItem.Name = "exitLitrojanToolStripMenuItem";
            this.exitLitrojanToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.exitLitrojanToolStripMenuItem.Text = "Exit Litrojan";
            this.exitLitrojanToolStripMenuItem.Click += new System.EventHandler(this.exitLitrojanToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(617, 412);
            this.Controls.Add(this.MatTabSelector);
            this.Controls.Add(this.BtnModeSave);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Litrojan - Lite User Interface for Trojan";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.BtnModeSave.ResumeLayout(false);
            this.TabHome.ResumeLayout(false);
            this.TabHome.PerformLayout();
            this.TabConfig.ResumeLayout(false);
            this.TabConfig.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.TabMode.ResumeLayout(false);
            this.TabMode.PerformLayout();
            this.TabLog.ResumeLayout(false);
            this.TabLog.PerformLayout();
            this.TabAbout.ResumeLayout(false);
            this.TabAbout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl BtnModeSave;
        private System.Windows.Forms.TabPage TabHome;
        private System.Windows.Forms.TabPage TabConfig;
        private MaterialSkin.Controls.MaterialTabSelector MatTabSelector;
        private System.Windows.Forms.TabPage TabLog;
        private System.Windows.Forms.TabPage TabAbout;
        private MaterialSkin.Controls.MaterialRaisedButton BtnHomeStart;
        private MaterialSkin.Controls.MaterialFlatButton BtnConfCancel;
        private MaterialSkin.Controls.MaterialRaisedButton BtnConfSave;
        private MaterialSkin.Controls.MaterialFlatButton BtnConfRestore;
        private MaterialSkin.Controls.MaterialLabel MatLabelBanner;
        private MaterialSkin.Controls.MaterialRaisedButton BtnLogSave;
        private MaterialSkin.Controls.MaterialFlatButton BtnLogCopy;
        private MaterialSkin.Controls.MaterialFlatButton BtnLogClear;
        private System.Windows.Forms.TextBox TxtLogDisplay;
        private MaterialSkin.Controls.MaterialLabel LblHomeVersion;
        private System.Windows.Forms.TabPage TabMode;
        private MaterialSkin.Controls.MaterialFlatButton BtnAdvnRestore;
        private MaterialSkin.Controls.MaterialFlatButton BtnAdvnCancel;
        private MaterialSkin.Controls.MaterialRaisedButton BtnAdvnSave;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private System.Windows.Forms.ComboBox ComLogLevel;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private MaterialSkin.Controls.MaterialLabel materialLabel11;
        private MaterialSkin.Controls.MaterialLabel materialLabel10;
        private MaterialSkin.Controls.MaterialLabel materialLabel14;
        private MaterialSkin.Controls.MaterialLabel materialLabel13;
        private MaterialSkin.Controls.MaterialLabel materialLabel12;
        private MaterialSkin.Controls.MaterialCheckBox ChkFastOpen;
        private MaterialSkin.Controls.MaterialCheckBox ChkKeepAlive;
        private MaterialSkin.Controls.MaterialCheckBox ChkNoDelay;
        private MaterialSkin.Controls.MaterialCheckBox ChkReuse;
        private MaterialSkin.Controls.MaterialCheckBox ChkServerCipher;
        private MaterialSkin.Controls.MaterialCheckBox ChkVerifyHost;
        private MaterialSkin.Controls.MaterialCheckBox ChkVerify;
        private MaterialSkin.Controls.MaterialCheckBox ChkAppendPayload;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtPass;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtRemoPort;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtRemoAddr;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtLocalPort;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtLocalAddr;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtALPN;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtSNI;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtCipher;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtKeyPass;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtKeyPath;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtCertPath;
        private MaterialSkin.Controls.MaterialLabel materialLabel19;
        private MaterialSkin.Controls.MaterialLabel materialLabel18;
        private MaterialSkin.Controls.MaterialLabel materialLabel17;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtSQLPass;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtUsername;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtDatabase;
        private MaterialSkin.Controls.MaterialCheckBox ChkSQLEnabled;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtServerPort;
        private MaterialSkin.Controls.MaterialLabel materialLabel16;
        private MaterialSkin.Controls.MaterialLabel materialLabel15;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtServerAddr;
        private MaterialSkin.Controls.MaterialDivider materialDivider2;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtQLEN;
        private MaterialSkin.Controls.MaterialLabel materialLabel20;
        private MaterialSkin.Controls.MaterialLabel materialLabel24;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtTargetPort;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtTargetAddr;
        private MaterialSkin.Controls.MaterialLabel materialLabel23;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtCurves;
        private MaterialSkin.Controls.MaterialLabel materialLabel22;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtTimeout;
        private MaterialSkin.Controls.MaterialLabel materialLabel21;
        private MaterialSkin.Controls.MaterialLabel materialLabel25;
        private MaterialSkin.Controls.MaterialRadioButton RdoModeR;
        private MaterialSkin.Controls.MaterialRadioButton RdoModeC;
        private MaterialSkin.Controls.MaterialRadioButton RdoModeS;
        private MaterialSkin.Controls.MaterialLabel materialLabel26;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialLabel LblAboutVersion;
        private System.Windows.Forms.NotifyIcon NotTrayIcon;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitLitrojanToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}

