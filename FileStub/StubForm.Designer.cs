namespace FileStub
{
    partial class StubForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StubForm));
            this.label5 = new System.Windows.Forms.Label();
            this.pnTarget = new System.Windows.Forms.Panel();
            this.btnUnloadTarget = new System.Windows.Forms.Button();
            this.lbTarget = new System.Windows.Forms.Label();
            this.cbTargetType = new System.Windows.Forms.ComboBox();
            this.btnBrowseTarget = new System.Windows.Forms.Button();
            this.btnTargetSettings = new System.Windows.Forms.Button();
            this.btnKillProcess = new System.Windows.Forms.Button();
            this.lbArgs = new System.Windows.Forms.Label();
            this.tbArgs = new System.Windows.Forms.TextBox();
            this.lbExecution = new System.Windows.Forms.Label();
            this.pnSideBar = new System.Windows.Forms.Panel();
            this.lbTargetStatus = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClearAllBackups = new System.Windows.Forms.Button();
            this.pnGlitchHarvesterOpen = new System.Windows.Forms.Panel();
            this.btnRestoreBackup = new System.Windows.Forms.Button();
            this.btnResetBackup = new System.Windows.Forms.Button();
            this.cbSelectedExecution = new System.Windows.Forms.ComboBox();
            this.pnTargetExecution = new System.Windows.Forms.Panel();
            this.btnEditExec = new System.Windows.Forms.Button();
            this.lbTargetExecution = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnTargetType = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnClearTargets = new System.Windows.Forms.Button();
            this.btnSetBaseDir = new System.Windows.Forms.Button();
            this.btnLoadTargets = new System.Windows.Forms.Button();
            this.lbTargets = new System.Windows.Forms.ListBox();
            this.lbDragAndDrop = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.nmFooterPadding = new RTCV.UI.Components.Controls.MultiUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.nmHeaderPadding = new RTCV.UI.Components.Controls.MultiUpDown();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.btnExtendPanel = new System.Windows.Forms.Button();
            this.lbTargetTypeDisplay = new System.Windows.Forms.Label();
            this.pnTarget.SuspendLayout();
            this.pnSideBar.SuspendLayout();
            this.pnTargetExecution.SuspendLayout();
            this.pnTargetType.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel10.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(5, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Loaded target information";
            // 
            // pnTarget
            // 
            this.pnTarget.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnTarget.Controls.Add(this.lbTarget);
            this.pnTarget.Location = new System.Drawing.Point(589, 80);
            this.pnTarget.Name = "pnTarget";
            this.pnTarget.Size = new System.Drawing.Size(408, 61);
            this.pnTarget.TabIndex = 13;
            this.pnTarget.Tag = "color:dark1";
            // 
            // btnUnloadTarget
            // 
            this.btnUnloadTarget.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnUnloadTarget.FlatAppearance.BorderSize = 0;
            this.btnUnloadTarget.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUnloadTarget.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.btnUnloadTarget.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnUnloadTarget.Location = new System.Drawing.Point(378, 4);
            this.btnUnloadTarget.Name = "btnUnloadTarget";
            this.btnUnloadTarget.Size = new System.Drawing.Size(57, 21);
            this.btnUnloadTarget.TabIndex = 42;
            this.btnUnloadTarget.TabStop = false;
            this.btnUnloadTarget.Tag = "color:dark2";
            this.btnUnloadTarget.Text = "Unload";
            this.btnUnloadTarget.UseVisualStyleBackColor = false;
            this.btnUnloadTarget.Visible = false;
            this.btnUnloadTarget.Click += new System.EventHandler(this.BtnUnloadTarget_Click);
            // 
            // lbTarget
            // 
            this.lbTarget.BackColor = System.Drawing.Color.Transparent;
            this.lbTarget.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lbTarget.ForeColor = System.Drawing.Color.White;
            this.lbTarget.Location = new System.Drawing.Point(12, 6);
            this.lbTarget.Name = "lbTarget";
            this.lbTarget.Padding = new System.Windows.Forms.Padding(3, 6, 1, 1);
            this.lbTarget.Size = new System.Drawing.Size(380, 47);
            this.lbTarget.TabIndex = 36;
            this.lbTarget.Tag = "";
            this.lbTarget.Text = "No target loaded";
            // 
            // cbTargetType
            // 
            this.cbTargetType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.cbTargetType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTargetType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbTargetType.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cbTargetType.ForeColor = System.Drawing.Color.White;
            this.cbTargetType.FormattingEnabled = true;
            this.cbTargetType.Location = new System.Drawing.Point(14, 15);
            this.cbTargetType.Name = "cbTargetType";
            this.cbTargetType.Size = new System.Drawing.Size(411, 29);
            this.cbTargetType.TabIndex = 118;
            this.cbTargetType.TabStop = false;
            this.cbTargetType.Tag = "color:normal";
            this.cbTargetType.SelectedIndexChanged += new System.EventHandler(this.CbTargetType_SelectedIndexChanged);
            // 
            // btnBrowseTarget
            // 
            this.btnBrowseTarget.BackColor = System.Drawing.Color.Gray;
            this.btnBrowseTarget.FlatAppearance.BorderSize = 0;
            this.btnBrowseTarget.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowseTarget.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.btnBrowseTarget.ForeColor = System.Drawing.Color.White;
            this.btnBrowseTarget.Location = new System.Drawing.Point(311, 130);
            this.btnBrowseTarget.Name = "btnBrowseTarget";
            this.btnBrowseTarget.Size = new System.Drawing.Size(116, 32);
            this.btnBrowseTarget.TabIndex = 35;
            this.btnBrowseTarget.TabStop = false;
            this.btnBrowseTarget.Tag = "color:light1";
            this.btnBrowseTarget.Text = "Browse files";
            this.btnBrowseTarget.UseVisualStyleBackColor = false;
            this.btnBrowseTarget.Click += new System.EventHandler(this.BtnBrowseTarget_Click);
            // 
            // btnTargetSettings
            // 
            this.btnTargetSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTargetSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnTargetSettings.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnTargetSettings.FlatAppearance.BorderSize = 0;
            this.btnTargetSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTargetSettings.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.btnTargetSettings.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnTargetSettings.Image = ((System.Drawing.Image)(resources.GetObject("btnTargetSettings.Image")));
            this.btnTargetSettings.Location = new System.Drawing.Point(966, 13);
            this.btnTargetSettings.Name = "btnTargetSettings";
            this.btnTargetSettings.Size = new System.Drawing.Size(32, 32);
            this.btnTargetSettings.TabIndex = 172;
            this.btnTargetSettings.TabStop = false;
            this.btnTargetSettings.Tag = "color:dark1";
            this.btnTargetSettings.UseVisualStyleBackColor = false;
            this.btnTargetSettings.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BtnTargetSettings_MouseDown);
            // 
            // btnKillProcess
            // 
            this.btnKillProcess.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKillProcess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnKillProcess.FlatAppearance.BorderSize = 0;
            this.btnKillProcess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKillProcess.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.btnKillProcess.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnKillProcess.Location = new System.Drawing.Point(314, 53);
            this.btnKillProcess.Name = "btnKillProcess";
            this.btnKillProcess.Size = new System.Drawing.Size(81, 32);
            this.btnKillProcess.TabIndex = 55;
            this.btnKillProcess.TabStop = false;
            this.btnKillProcess.Tag = "color:dark2";
            this.btnKillProcess.Text = "Kill Process";
            this.btnKillProcess.UseVisualStyleBackColor = false;
            this.btnKillProcess.Click += new System.EventHandler(this.BtnKillProcess_Click);
            // 
            // lbArgs
            // 
            this.lbArgs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbArgs.AutoSize = true;
            this.lbArgs.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lbArgs.ForeColor = System.Drawing.Color.White;
            this.lbArgs.Location = new System.Drawing.Point(12, 90);
            this.lbArgs.Name = "lbArgs";
            this.lbArgs.Size = new System.Drawing.Size(29, 13);
            this.lbArgs.TabIndex = 54;
            this.lbArgs.Text = "args";
            // 
            // tbArgs
            // 
            this.tbArgs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbArgs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.tbArgs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbArgs.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.tbArgs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tbArgs.Location = new System.Drawing.Point(41, 91);
            this.tbArgs.Name = "tbArgs";
            this.tbArgs.Size = new System.Drawing.Size(354, 15);
            this.tbArgs.TabIndex = 53;
            this.tbArgs.Tag = "color:dark2";
            // 
            // lbExecution
            // 
            this.lbExecution.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbExecution.BackColor = System.Drawing.Color.Transparent;
            this.lbExecution.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lbExecution.ForeColor = System.Drawing.Color.White;
            this.lbExecution.Location = new System.Drawing.Point(14, 49);
            this.lbExecution.Margin = new System.Windows.Forms.Padding(0);
            this.lbExecution.Name = "lbExecution";
            this.lbExecution.Padding = new System.Windows.Forms.Padding(2, 2, 1, 1);
            this.lbExecution.Size = new System.Drawing.Size(297, 32);
            this.lbExecution.TabIndex = 42;
            this.lbExecution.Tag = "";
            this.lbExecution.Text = "No execution set";
            // 
            // pnSideBar
            // 
            this.pnSideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.pnSideBar.Controls.Add(this.lbTargetStatus);
            this.pnSideBar.Controls.Add(this.label2);
            this.pnSideBar.Controls.Add(this.btnClearAllBackups);
            this.pnSideBar.Controls.Add(this.pnGlitchHarvesterOpen);
            this.pnSideBar.Controls.Add(this.btnRestoreBackup);
            this.pnSideBar.Controls.Add(this.btnResetBackup);
            this.pnSideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnSideBar.Location = new System.Drawing.Point(0, 0);
            this.pnSideBar.Name = "pnSideBar";
            this.pnSideBar.Size = new System.Drawing.Size(118, 479);
            this.pnSideBar.TabIndex = 174;
            this.pnSideBar.Tag = "color:dark3";
            // 
            // lbTargetStatus
            // 
            this.lbTargetStatus.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lbTargetStatus.ForeColor = System.Drawing.Color.White;
            this.lbTargetStatus.Location = new System.Drawing.Point(9, 37);
            this.lbTargetStatus.Name = "lbTargetStatus";
            this.lbTargetStatus.Size = new System.Drawing.Size(110, 44);
            this.lbTargetStatus.TabIndex = 123;
            this.lbTargetStatus.Text = "No target selected";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(8, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 19);
            this.label2.TabIndex = 122;
            this.label2.Text = "Status";
            // 
            // btnClearAllBackups
            // 
            this.btnClearAllBackups.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnClearAllBackups.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnClearAllBackups.FlatAppearance.BorderSize = 0;
            this.btnClearAllBackups.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearAllBackups.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnClearAllBackups.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnClearAllBackups.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClearAllBackups.Location = new System.Drawing.Point(0, 166);
            this.btnClearAllBackups.Name = "btnClearAllBackups";
            this.btnClearAllBackups.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btnClearAllBackups.Size = new System.Drawing.Size(133, 34);
            this.btnClearAllBackups.TabIndex = 121;
            this.btnClearAllBackups.TabStop = false;
            this.btnClearAllBackups.Tag = "color:dark3";
            this.btnClearAllBackups.Text = "Clear All Backups";
            this.btnClearAllBackups.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClearAllBackups.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClearAllBackups.UseVisualStyleBackColor = false;
            this.btnClearAllBackups.Visible = false;
            this.btnClearAllBackups.Click += new System.EventHandler(this.BtnClearAllBackups_Click);
            // 
            // pnGlitchHarvesterOpen
            // 
            this.pnGlitchHarvesterOpen.BackColor = System.Drawing.Color.Gray;
            this.pnGlitchHarvesterOpen.Location = new System.Drawing.Point(-19, 188);
            this.pnGlitchHarvesterOpen.Name = "pnGlitchHarvesterOpen";
            this.pnGlitchHarvesterOpen.Size = new System.Drawing.Size(23, 25);
            this.pnGlitchHarvesterOpen.TabIndex = 8;
            this.pnGlitchHarvesterOpen.Tag = "color:light1";
            this.pnGlitchHarvesterOpen.Visible = false;
            // 
            // btnRestoreBackup
            // 
            this.btnRestoreBackup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnRestoreBackup.Enabled = false;
            this.btnRestoreBackup.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnRestoreBackup.FlatAppearance.BorderSize = 0;
            this.btnRestoreBackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestoreBackup.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnRestoreBackup.ForeColor = System.Drawing.Color.White;
            this.btnRestoreBackup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRestoreBackup.Location = new System.Drawing.Point(0, 90);
            this.btnRestoreBackup.Name = "btnRestoreBackup";
            this.btnRestoreBackup.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btnRestoreBackup.Size = new System.Drawing.Size(133, 34);
            this.btnRestoreBackup.TabIndex = 119;
            this.btnRestoreBackup.TabStop = false;
            this.btnRestoreBackup.Tag = "color:dark3";
            this.btnRestoreBackup.Text = "Restore Backup";
            this.btnRestoreBackup.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRestoreBackup.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRestoreBackup.UseVisualStyleBackColor = false;
            this.btnRestoreBackup.Click += new System.EventHandler(this.BtnRestoreBackup_Click);
            // 
            // btnResetBackup
            // 
            this.btnResetBackup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnResetBackup.Enabled = false;
            this.btnResetBackup.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnResetBackup.FlatAppearance.BorderSize = 0;
            this.btnResetBackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetBackup.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnResetBackup.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnResetBackup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnResetBackup.Location = new System.Drawing.Point(0, 128);
            this.btnResetBackup.Name = "btnResetBackup";
            this.btnResetBackup.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btnResetBackup.Size = new System.Drawing.Size(133, 34);
            this.btnResetBackup.TabIndex = 120;
            this.btnResetBackup.TabStop = false;
            this.btnResetBackup.Tag = "color:dark3";
            this.btnResetBackup.Text = "Reset Backup";
            this.btnResetBackup.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnResetBackup.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnResetBackup.UseVisualStyleBackColor = false;
            this.btnResetBackup.Click += new System.EventHandler(this.BtnResetBackup_Click);
            // 
            // cbSelectedExecution
            // 
            this.cbSelectedExecution.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbSelectedExecution.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.cbSelectedExecution.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSelectedExecution.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbSelectedExecution.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cbSelectedExecution.ForeColor = System.Drawing.Color.White;
            this.cbSelectedExecution.FormattingEnabled = true;
            this.cbSelectedExecution.Location = new System.Drawing.Point(14, 14);
            this.cbSelectedExecution.Name = "cbSelectedExecution";
            this.cbSelectedExecution.Size = new System.Drawing.Size(297, 29);
            this.cbSelectedExecution.TabIndex = 117;
            this.cbSelectedExecution.TabStop = false;
            this.cbSelectedExecution.Tag = "color:normal";
            this.cbSelectedExecution.SelectedIndexChanged += new System.EventHandler(this.CbSelectedExecution_SelectedIndexChanged);
            // 
            // pnTargetExecution
            // 
            this.pnTargetExecution.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnTargetExecution.Controls.Add(this.btnEditExec);
            this.pnTargetExecution.Controls.Add(this.cbSelectedExecution);
            this.pnTargetExecution.Controls.Add(this.lbExecution);
            this.pnTargetExecution.Controls.Add(this.btnKillProcess);
            this.pnTargetExecution.Controls.Add(this.tbArgs);
            this.pnTargetExecution.Controls.Add(this.lbArgs);
            this.pnTargetExecution.Location = new System.Drawing.Point(586, 182);
            this.pnTargetExecution.Name = "pnTargetExecution";
            this.pnTargetExecution.Size = new System.Drawing.Size(410, 119);
            this.pnTargetExecution.TabIndex = 176;
            this.pnTargetExecution.Tag = "color:dark1";
            // 
            // btnEditExec
            // 
            this.btnEditExec.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditExec.BackColor = System.Drawing.Color.Gray;
            this.btnEditExec.FlatAppearance.BorderSize = 0;
            this.btnEditExec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditExec.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.btnEditExec.ForeColor = System.Drawing.Color.White;
            this.btnEditExec.Location = new System.Drawing.Point(314, 13);
            this.btnEditExec.Name = "btnEditExec";
            this.btnEditExec.Size = new System.Drawing.Size(81, 32);
            this.btnEditExec.TabIndex = 118;
            this.btnEditExec.TabStop = false;
            this.btnEditExec.Tag = "color:light1";
            this.btnEditExec.Text = "Edit Exec";
            this.btnEditExec.UseVisualStyleBackColor = false;
            this.btnEditExec.Click += new System.EventHandler(this.BtnEditExec_Click);
            // 
            // lbTargetExecution
            // 
            this.lbTargetExecution.AutoSize = true;
            this.lbTargetExecution.BackColor = System.Drawing.Color.Transparent;
            this.lbTargetExecution.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.lbTargetExecution.ForeColor = System.Drawing.Color.White;
            this.lbTargetExecution.Location = new System.Drawing.Point(5, 6);
            this.lbTargetExecution.Name = "lbTargetExecution";
            this.lbTargetExecution.Size = new System.Drawing.Size(95, 15);
            this.lbTargetExecution.TabIndex = 175;
            this.lbTargetExecution.Text = "Target execution";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(5, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 15);
            this.label1.TabIndex = 177;
            this.label1.Text = "Target Type";
            // 
            // pnTargetType
            // 
            this.pnTargetType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnTargetType.Controls.Add(this.cbTargetType);
            this.pnTargetType.Controls.Add(this.lbTargetTypeDisplay);
            this.pnTargetType.Location = new System.Drawing.Point(131, 81);
            this.pnTargetType.Name = "pnTargetType";
            this.pnTargetType.Size = new System.Drawing.Size(440, 60);
            this.pnTargetType.TabIndex = 119;
            this.pnTargetType.Tag = "color:dark1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(5, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 15);
            this.label3.TabIndex = 178;
            this.label3.Text = "File Loading";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.btnUnloadTarget);
            this.panel2.Controls.Add(this.btnClearTargets);
            this.panel2.Controls.Add(this.btnSetBaseDir);
            this.panel2.Controls.Add(this.btnLoadTargets);
            this.panel2.Controls.Add(this.lbTargets);
            this.panel2.Controls.Add(this.lbDragAndDrop);
            this.panel2.Controls.Add(this.btnBrowseTarget);
            this.panel2.Location = new System.Drawing.Point(131, 181);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(440, 277);
            this.panel2.TabIndex = 179;
            this.panel2.Tag = "color:dark1";
            // 
            // btnClearTargets
            // 
            this.btnClearTargets.BackColor = System.Drawing.Color.Gray;
            this.btnClearTargets.FlatAppearance.BorderSize = 0;
            this.btnClearTargets.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearTargets.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.btnClearTargets.ForeColor = System.Drawing.Color.White;
            this.btnClearTargets.Location = new System.Drawing.Point(14, 234);
            this.btnClearTargets.Name = "btnClearTargets";
            this.btnClearTargets.Size = new System.Drawing.Size(277, 32);
            this.btnClearTargets.TabIndex = 116;
            this.btnClearTargets.TabStop = false;
            this.btnClearTargets.Tag = "color:light1";
            this.btnClearTargets.Text = "Clear targets";
            this.btnClearTargets.UseVisualStyleBackColor = false;
            this.btnClearTargets.Click += new System.EventHandler(this.btnClearTargets_Click);
            // 
            // btnSetBaseDir
            // 
            this.btnSetBaseDir.BackColor = System.Drawing.Color.Gray;
            this.btnSetBaseDir.FlatAppearance.BorderSize = 0;
            this.btnSetBaseDir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetBaseDir.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.btnSetBaseDir.ForeColor = System.Drawing.Color.White;
            this.btnSetBaseDir.Location = new System.Drawing.Point(311, 170);
            this.btnSetBaseDir.Name = "btnSetBaseDir";
            this.btnSetBaseDir.Size = new System.Drawing.Size(116, 32);
            this.btnSetBaseDir.TabIndex = 115;
            this.btnSetBaseDir.TabStop = false;
            this.btnSetBaseDir.Tag = "color:light1";
            this.btnSetBaseDir.Text = "Set base dir";
            this.btnSetBaseDir.UseVisualStyleBackColor = false;
            this.btnSetBaseDir.Click += new System.EventHandler(this.btnSetBaseDir_Click);
            // 
            // btnLoadTargets
            // 
            this.btnLoadTargets.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoadTargets.BackColor = System.Drawing.Color.Gray;
            this.btnLoadTargets.FlatAppearance.BorderSize = 0;
            this.btnLoadTargets.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadTargets.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.btnLoadTargets.ForeColor = System.Drawing.Color.White;
            this.btnLoadTargets.Image = ((System.Drawing.Image)(resources.GetObject("btnLoadTargets.Image")));
            this.btnLoadTargets.Location = new System.Drawing.Point(311, 210);
            this.btnLoadTargets.Name = "btnLoadTargets";
            this.btnLoadTargets.Size = new System.Drawing.Size(116, 56);
            this.btnLoadTargets.TabIndex = 114;
            this.btnLoadTargets.TabStop = false;
            this.btnLoadTargets.Tag = "color:light1";
            this.btnLoadTargets.Text = " Load targets into RTCV";
            this.btnLoadTargets.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLoadTargets.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLoadTargets.UseVisualStyleBackColor = false;
            this.btnLoadTargets.Click += new System.EventHandler(this.btnLoadTargets_Click);
            // 
            // lbTargets
            // 
            this.lbTargets.AllowDrop = true;
            this.lbTargets.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTargets.BackColor = System.Drawing.Color.Gray;
            this.lbTargets.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbTargets.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lbTargets.ForeColor = System.Drawing.Color.White;
            this.lbTargets.FormattingEnabled = true;
            this.lbTargets.HorizontalScrollbar = true;
            this.lbTargets.IntegralHeight = false;
            this.lbTargets.Location = new System.Drawing.Point(14, 15);
            this.lbTargets.Name = "lbTargets";
            this.lbTargets.ScrollAlwaysVisible = true;
            this.lbTargets.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbTargets.Size = new System.Drawing.Size(277, 210);
            this.lbTargets.TabIndex = 113;
            this.lbTargets.Tag = "color:light1";
            this.lbTargets.SelectedIndexChanged += new System.EventHandler(this.lbTargets_SelectedIndexChanged);
            this.lbTargets.DragDrop += new System.Windows.Forms.DragEventHandler(this.lbTargets_DragDrop);
            this.lbTargets.DragEnter += new System.Windows.Forms.DragEventHandler(this.lbTargets_DragEnter);
            // 
            // lbDragAndDrop
            // 
            this.lbDragAndDrop.AllowDrop = true;
            this.lbDragAndDrop.BackColor = System.Drawing.Color.Transparent;
            this.lbDragAndDrop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbDragAndDrop.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lbDragAndDrop.ForeColor = System.Drawing.Color.LightGray;
            this.lbDragAndDrop.Location = new System.Drawing.Point(311, 16);
            this.lbDragAndDrop.Name = "lbDragAndDrop";
            this.lbDragAndDrop.Padding = new System.Windows.Forms.Padding(16);
            this.lbDragAndDrop.Size = new System.Drawing.Size(116, 96);
            this.lbDragAndDrop.TabIndex = 37;
            this.lbDragAndDrop.Tag = "color:light2";
            this.lbDragAndDrop.Text = "Quick Load Drag and drop zone";
            this.lbDragAndDrop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbDragAndDrop.DragDrop += new System.Windows.Forms.DragEventHandler(this.lbDragAndDrop_DragDrop);
            this.lbDragAndDrop.DragEnter += new System.Windows.Forms.DragEventHandler(this.lbDragAndDrop_DragEnter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(5, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 15);
            this.label4.TabIndex = 180;
            this.label4.Text = "Selected Target settings";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.nmFooterPadding);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label23);
            this.panel3.Controls.Add(this.nmHeaderPadding);
            this.panel3.Location = new System.Drawing.Point(586, 341);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(206, 119);
            this.panel3.TabIndex = 177;
            this.panel3.Tag = "color:dark1";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Gray;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(14, 77);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(181, 32);
            this.button2.TabIndex = 146;
            this.button2.TabStop = false;
            this.button2.Tag = "color:light1";
            this.button2.Text = "Save target padding";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // nmFooterPadding
            // 
            this.nmFooterPadding.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.nmFooterPadding.Font = new System.Drawing.Font("Consolas", 8.25F);
            this.nmFooterPadding.ForeColor = System.Drawing.Color.White;
            this.nmFooterPadding.Hexadecimal = true;
            this.nmFooterPadding.Location = new System.Drawing.Point(109, 38);
            this.nmFooterPadding.Maximum = new decimal(new int[] {
            -1,
            -1,
            0,
            0});
            this.nmFooterPadding.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nmFooterPadding.Name = "nmFooterPadding";
            this.nmFooterPadding.Size = new System.Drawing.Size(86, 20);
            this.nmFooterPadding.TabIndex = 145;
            this.nmFooterPadding.Tag = "color:dark2";
            this.nmFooterPadding.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(12, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 13);
            this.label7.TabIndex = 144;
            this.label7.Text = "Footer padding";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.label23.ForeColor = System.Drawing.Color.White;
            this.label23.Location = new System.Drawing.Point(12, 14);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(91, 13);
            this.label23.TabIndex = 142;
            this.label23.Text = "Header padding";
            // 
            // nmHeaderPadding
            // 
            this.nmHeaderPadding.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.nmHeaderPadding.Font = new System.Drawing.Font("Consolas", 8.25F);
            this.nmHeaderPadding.ForeColor = System.Drawing.Color.White;
            this.nmHeaderPadding.Hexadecimal = true;
            this.nmHeaderPadding.Location = new System.Drawing.Point(109, 12);
            this.nmHeaderPadding.Maximum = new decimal(new int[] {
            -1,
            -1,
            0,
            0});
            this.nmHeaderPadding.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nmHeaderPadding.Name = "nmHeaderPadding";
            this.nmHeaderPadding.Size = new System.Drawing.Size(86, 20);
            this.nmHeaderPadding.TabIndex = 143;
            this.nmHeaderPadding.Tag = "color:dark2";
            this.nmHeaderPadding.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Location = new System.Drawing.Point(808, 341);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(189, 119);
            this.panel4.TabIndex = 181;
            this.panel4.Tag = "color:dark1";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(9, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 15);
            this.label9.TabIndex = 183;
            this.label9.Text = "Base dir";
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(11, 29);
            this.label8.Name = "label8";
            this.label8.Padding = new System.Windows.Forms.Padding(3, 6, 1, 1);
            this.label8.Size = new System.Drawing.Size(162, 80);
            this.label8.TabIndex = 37;
            this.label8.Tag = "";
            this.label8.Text = "(unset)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(5, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 15);
            this.label6.TabIndex = 182;
            this.label6.Text = "Global Target settings";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.panel5.Controls.Add(this.label6);
            this.panel5.Location = new System.Drawing.Point(808, 315);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(189, 32);
            this.panel5.TabIndex = 184;
            this.panel5.Tag = "color:dark3";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.panel6.Controls.Add(this.label4);
            this.panel6.Location = new System.Drawing.Point(586, 315);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(206, 32);
            this.panel6.TabIndex = 185;
            this.panel6.Tag = "color:dark3";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.panel7.Controls.Add(this.lbTargetExecution);
            this.panel7.Location = new System.Drawing.Point(586, 156);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(411, 32);
            this.panel7.TabIndex = 186;
            this.panel7.Tag = "color:dark3";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.panel8.Controls.Add(this.label5);
            this.panel8.Location = new System.Drawing.Point(587, 54);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(411, 32);
            this.panel8.TabIndex = 187;
            this.panel8.Tag = "color:dark3";
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.panel9.Controls.Add(this.label1);
            this.panel9.Location = new System.Drawing.Point(131, 55);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(440, 32);
            this.panel9.TabIndex = 188;
            this.panel9.Tag = "color:dark3";
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.panel10.Controls.Add(this.label3);
            this.panel10.Location = new System.Drawing.Point(131, 156);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(440, 32);
            this.panel10.TabIndex = 189;
            this.panel10.Tag = "color:dark3";
            // 
            // btnExtendPanel
            // 
            this.btnExtendPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExtendPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnExtendPanel.FlatAppearance.BorderSize = 0;
            this.btnExtendPanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExtendPanel.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.btnExtendPanel.ForeColor = System.Drawing.Color.White;
            this.btnExtendPanel.Location = new System.Drawing.Point(822, 13);
            this.btnExtendPanel.Name = "btnExtendPanel";
            this.btnExtendPanel.Size = new System.Drawing.Size(132, 32);
            this.btnExtendPanel.TabIndex = 190;
            this.btnExtendPanel.TabStop = false;
            this.btnExtendPanel.Tag = "color:dark1";
            this.btnExtendPanel.Text = "Advanced Options";
            this.btnExtendPanel.UseVisualStyleBackColor = false;
            this.btnExtendPanel.Click += new System.EventHandler(this.btnExtendPanel_Click);
            // 
            // lbTargetTypeDisplay
            // 
            this.lbTargetTypeDisplay.BackColor = System.Drawing.Color.Transparent;
            this.lbTargetTypeDisplay.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lbTargetTypeDisplay.ForeColor = System.Drawing.Color.White;
            this.lbTargetTypeDisplay.Location = new System.Drawing.Point(11, 13);
            this.lbTargetTypeDisplay.Name = "lbTargetTypeDisplay";
            this.lbTargetTypeDisplay.Padding = new System.Windows.Forms.Padding(3, 6, 1, 1);
            this.lbTargetTypeDisplay.Size = new System.Drawing.Size(387, 36);
            this.lbTargetTypeDisplay.TabIndex = 119;
            this.lbTargetTypeDisplay.Tag = "";
            this.lbTargetTypeDisplay.Text = "_";
            // 
            // StubForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(1010, 479);
            this.Controls.Add(this.btnExtendPanel);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnTargetType);
            this.Controls.Add(this.pnTargetExecution);
            this.Controls.Add(this.pnSideBar);
            this.Controls.Add(this.btnTargetSettings);
            this.Controls.Add(this.pnTarget);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel10);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(516, 352);
            this.Name = "StubForm";
            this.Tag = "color:dark2";
            this.Text = "File Stub ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StubForm_FormClosing);
            this.Load += new System.EventHandler(this.StubForm_Load);
            this.pnTarget.ResumeLayout(false);
            this.pnSideBar.ResumeLayout(false);
            this.pnSideBar.PerformLayout();
            this.pnTargetExecution.ResumeLayout(false);
            this.pnTargetExecution.PerformLayout();
            this.pnTargetType.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel pnTarget;
        public System.Windows.Forms.Button btnTargetSettings;
        public System.Windows.Forms.Label lbArgs;
        public System.Windows.Forms.TextBox tbArgs;
        public System.Windows.Forms.Label lbExecution;
        private System.Windows.Forms.Panel pnSideBar;
        public System.Windows.Forms.Button btnClearAllBackups;
        internal System.Windows.Forms.Panel pnGlitchHarvesterOpen;
        public System.Windows.Forms.Button btnRestoreBackup;
        public System.Windows.Forms.Button btnResetBackup;
        private System.Windows.Forms.Button btnKillProcess;
        public System.Windows.Forms.ComboBox cbSelectedExecution;
        private System.Windows.Forms.Panel pnTargetExecution;
        public System.Windows.Forms.Label lbTargetExecution;
        private System.Windows.Forms.Button btnBrowseTarget;
        public System.Windows.Forms.Label lbTarget;
        private System.Windows.Forms.Button btnEditExec;
        private System.Windows.Forms.Button btnUnloadTarget;
        public System.Windows.Forms.Label lbTargetStatus;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.ComboBox cbTargetType;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnTargetType;
        public System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.Label lbDragAndDrop;
        public System.Windows.Forms.Button btnLoadTargets;
        public System.Windows.Forms.ListBox lbTargets;
        private System.Windows.Forms.Button btnSetBaseDir;
        public RTCV.UI.Components.Controls.MultiUpDown nmFooterPadding;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label23;
        public RTCV.UI.Components.Controls.MultiUpDown nmHeaderPadding;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnClearTargets;
        private System.Windows.Forms.Panel panel4;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Button btnExtendPanel;
        public System.Windows.Forms.Label lbTargetTypeDisplay;
    }
}

