namespace QMM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.LabelMadeBy = new System.Windows.Forms.Label();
            this.LabelVersion = new System.Windows.Forms.Label();
            this.PanelBody = new Guna.UI2.WinForms.Guna2Panel();
            this.LabelProgress = new System.Windows.Forms.Label();
            this.ProgressBar = new Guna.UI2.WinForms.Guna2ProgressBar();
            this.BtnRestoreSave = new Guna.UI2.WinForms.Guna2Button();
            this.BtnRestoreBackup = new Guna.UI2.WinForms.Guna2Button();
            this.BtnBackupSave = new Guna.UI2.WinForms.Guna2Button();
            this.BtnCreateBackup = new Guna.UI2.WinForms.Guna2Button();
            this.BtnLaunchGame = new Guna.UI2.WinForms.Guna2Button();
            this.PanelModList = new Guna.UI2.WinForms.Guna2Panel();
            this.BtnCloseInfo = new Guna.UI2.WinForms.Guna2Button();
            this.BtnRemoveMod = new Guna.UI2.WinForms.Guna2Button();
            this.BtnRefreshModList = new Guna.UI2.WinForms.Guna2Button();
            this.BtnAddMod = new Guna.UI2.WinForms.Guna2Button();
            this.PanelHeader = new Guna.UI2.WinForms.Guna2Panel();
            this.BtnClose = new Guna.UI2.WinForms.Guna2Button();
            this.BtnMinimize = new Guna.UI2.WinForms.Guna2Button();
            this.BtnInfo = new Guna.UI2.WinForms.Guna2Button();
            this.BtnUserSettings = new Guna.UI2.WinForms.Guna2Button();
            this.ImgIcon = new System.Windows.Forms.PictureBox();
            this.LabelTitle = new System.Windows.Forms.Label();
            this.PanelBody.SuspendLayout();
            this.PanelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelMadeBy
            // 
            this.LabelMadeBy.AccessibleName = "LabelMadeBy";
            this.LabelMadeBy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LabelMadeBy.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::QMM.Properties.Settings.Default, "TextColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.LabelMadeBy.Font = new System.Drawing.Font("Gadugi", 10F);
            this.LabelMadeBy.ForeColor = global::QMM.Properties.Settings.Default.TextColor;
            this.LabelMadeBy.Location = new System.Drawing.Point(507, 501);
            this.LabelMadeBy.Name = "LabelMadeBy";
            this.LabelMadeBy.Size = new System.Drawing.Size(128, 17);
            this.LabelMadeBy.TabIndex = 12;
            this.LabelMadeBy.Text = "Made By Papa Quill";
            this.LabelMadeBy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LabelMadeBy.Click += new System.EventHandler(this.LabelMadeBy_Click);
            // 
            // LabelVersion
            // 
            this.LabelVersion.AccessibleName = "LabelVersion";
            this.LabelVersion.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::QMM.Properties.Settings.Default, "Version", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.LabelVersion.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::QMM.Properties.Settings.Default, "TextColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.LabelVersion.Font = new System.Drawing.Font("Gadugi", 10F);
            this.LabelVersion.ForeColor = global::QMM.Properties.Settings.Default.TextColor;
            this.LabelVersion.Location = new System.Drawing.Point(7, 501);
            this.LabelVersion.Name = "LabelVersion";
            this.LabelVersion.Size = new System.Drawing.Size(179, 17);
            this.LabelVersion.TabIndex = 11;
            this.LabelVersion.Text = global::QMM.Properties.Settings.Default.Version;
            this.LabelVersion.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoveWindow);
            // 
            // PanelBody
            // 
            this.PanelBody.AccessibleName = "PanelBody";
            this.PanelBody.BackColor = System.Drawing.Color.Transparent;
            this.PanelBody.BorderColor = global::QMM.Properties.Settings.Default.DetailColor;
            this.PanelBody.BorderRadius = global::QMM.Properties.Settings.Default.BorderRadius;
            this.PanelBody.BorderThickness = 1;
            this.PanelBody.Controls.Add(this.LabelProgress);
            this.PanelBody.Controls.Add(this.ProgressBar);
            this.PanelBody.Controls.Add(this.BtnRestoreSave);
            this.PanelBody.Controls.Add(this.BtnRestoreBackup);
            this.PanelBody.Controls.Add(this.BtnBackupSave);
            this.PanelBody.Controls.Add(this.BtnCreateBackup);
            this.PanelBody.Controls.Add(this.BtnLaunchGame);
            this.PanelBody.Controls.Add(this.PanelModList);
            this.PanelBody.Controls.Add(this.BtnCloseInfo);
            this.PanelBody.Controls.Add(this.BtnRemoveMod);
            this.PanelBody.Controls.Add(this.BtnRefreshModList);
            this.PanelBody.Controls.Add(this.BtnAddMod);
            this.PanelBody.CustomizableEdges.TopLeft = false;
            this.PanelBody.CustomizableEdges.TopRight = false;
            this.PanelBody.DataBindings.Add(new System.Windows.Forms.Binding("FillColor", global::QMM.Properties.Settings.Default, "BGSecondary", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.PanelBody.DataBindings.Add(new System.Windows.Forms.Binding("BorderRadius", global::QMM.Properties.Settings.Default, "BorderRadius", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.PanelBody.DataBindings.Add(new System.Windows.Forms.Binding("BorderColor", global::QMM.Properties.Settings.Default, "DetailColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.PanelBody.FillColor = global::QMM.Properties.Settings.Default.BGSecondary;
            this.PanelBody.Location = new System.Drawing.Point(10, 69);
            this.PanelBody.Name = "PanelBody";
            this.PanelBody.Size = new System.Drawing.Size(623, 430);
            this.PanelBody.TabIndex = 8;
            // 
            // LabelProgress
            // 
            this.LabelProgress.AccessibleName = "LabelProgress";
            this.LabelProgress.AutoSize = true;
            this.LabelProgress.Cursor = System.Windows.Forms.Cursors.Default;
            this.LabelProgress.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::QMM.Properties.Settings.Default, "TextColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.LabelProgress.Font = new System.Drawing.Font("Gadugi", 10F);
            this.LabelProgress.ForeColor = global::QMM.Properties.Settings.Default.TextColor;
            this.LabelProgress.Location = new System.Drawing.Point(387, 374);
            this.LabelProgress.Name = "LabelProgress";
            this.LabelProgress.Size = new System.Drawing.Size(64, 17);
            this.LabelProgress.TabIndex = 12;
            this.LabelProgress.Text = "Progress:";
            this.LabelProgress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LabelProgress.Visible = false;
            // 
            // ProgressBar
            // 
            this.ProgressBar.AccessibleName = "ProgressBar";
            this.ProgressBar.BackColor = System.Drawing.Color.Transparent;
            this.ProgressBar.BorderColor = global::QMM.Properties.Settings.Default.DetailColor;
            this.ProgressBar.BorderThickness = 1;
            this.ProgressBar.Cursor = System.Windows.Forms.Cursors.Default;
            this.ProgressBar.DataBindings.Add(new System.Windows.Forms.Binding("BorderColor", global::QMM.Properties.Settings.Default, "DetailColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ProgressBar.DataBindings.Add(new System.Windows.Forms.Binding("FillColor", global::QMM.Properties.Settings.Default, "ButtonColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ProgressBar.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::QMM.Properties.Settings.Default, "TextColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ProgressBar.DataBindings.Add(new System.Windows.Forms.Binding("ProgressColor2", global::QMM.Properties.Settings.Default, "DetailActive", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ProgressBar.DataBindings.Add(new System.Windows.Forms.Binding("ProgressColor", global::QMM.Properties.Settings.Default, "BGTertiary", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ProgressBar.FillColor = global::QMM.Properties.Settings.Default.ButtonColor;
            this.ProgressBar.Font = new System.Drawing.Font("Gadugi", 10F);
            this.ProgressBar.ForeColor = global::QMM.Properties.Settings.Default.TextColor;
            this.ProgressBar.Location = new System.Drawing.Point(390, 394);
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.ProgressColor = global::QMM.Properties.Settings.Default.BGTertiary;
            this.ProgressBar.ProgressColor2 = global::QMM.Properties.Settings.Default.DetailActive;
            this.ProgressBar.ShowText = true;
            this.ProgressBar.Size = new System.Drawing.Size(222, 26);
            this.ProgressBar.TabIndex = 10;
            this.ProgressBar.Text = "Create Backup";
            this.ProgressBar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.ProgressBar.Visible = false;
            // 
            // BtnRestoreSave
            // 
            this.BtnRestoreSave.AccessibleName = "BtnRestoreSave";
            this.BtnRestoreSave.Animated = true;
            this.BtnRestoreSave.BackColor = System.Drawing.Color.Transparent;
            this.BtnRestoreSave.BorderColor = global::QMM.Properties.Settings.Default.DetailColor;
            this.BtnRestoreSave.BorderThickness = 1;
            this.BtnRestoreSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRestoreSave.DataBindings.Add(new System.Windows.Forms.Binding("BorderColor", global::QMM.Properties.Settings.Default, "DetailColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.BtnRestoreSave.DataBindings.Add(new System.Windows.Forms.Binding("FillColor", global::QMM.Properties.Settings.Default, "ButtonColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.BtnRestoreSave.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::QMM.Properties.Settings.Default, "TextColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.BtnRestoreSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnRestoreSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnRestoreSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnRestoreSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnRestoreSave.FillColor = global::QMM.Properties.Settings.Default.ButtonColor;
            this.BtnRestoreSave.Font = new System.Drawing.Font("Gadugi", 10F);
            this.BtnRestoreSave.ForeColor = global::QMM.Properties.Settings.Default.TextColor;
            this.BtnRestoreSave.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(167)))), ((int)(((byte)(231)))));
            this.BtnRestoreSave.ImageSize = new System.Drawing.Size(16, 16);
            this.BtnRestoreSave.Location = new System.Drawing.Point(390, 230);
            this.BtnRestoreSave.Name = "BtnRestoreSave";
            this.BtnRestoreSave.Size = new System.Drawing.Size(222, 45);
            this.BtnRestoreSave.TabIndex = 10;
            this.BtnRestoreSave.Text = "Restore Save";
            this.BtnRestoreSave.Click += new System.EventHandler(this.BtnRestoreSave_Click);
            // 
            // BtnRestoreBackup
            // 
            this.BtnRestoreBackup.AccessibleName = "BtnRestoreBackup";
            this.BtnRestoreBackup.Animated = true;
            this.BtnRestoreBackup.BackColor = System.Drawing.Color.Transparent;
            this.BtnRestoreBackup.BorderColor = global::QMM.Properties.Settings.Default.DetailColor;
            this.BtnRestoreBackup.BorderThickness = 1;
            this.BtnRestoreBackup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRestoreBackup.DataBindings.Add(new System.Windows.Forms.Binding("BorderColor", global::QMM.Properties.Settings.Default, "DetailColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.BtnRestoreBackup.DataBindings.Add(new System.Windows.Forms.Binding("FillColor", global::QMM.Properties.Settings.Default, "ButtonColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.BtnRestoreBackup.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::QMM.Properties.Settings.Default, "TextColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.BtnRestoreBackup.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnRestoreBackup.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnRestoreBackup.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnRestoreBackup.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnRestoreBackup.FillColor = global::QMM.Properties.Settings.Default.ButtonColor;
            this.BtnRestoreBackup.Font = new System.Drawing.Font("Gadugi", 10F);
            this.BtnRestoreBackup.ForeColor = global::QMM.Properties.Settings.Default.TextColor;
            this.BtnRestoreBackup.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(167)))), ((int)(((byte)(231)))));
            this.BtnRestoreBackup.ImageSize = new System.Drawing.Size(16, 16);
            this.BtnRestoreBackup.Location = new System.Drawing.Point(390, 120);
            this.BtnRestoreBackup.Name = "BtnRestoreBackup";
            this.BtnRestoreBackup.Size = new System.Drawing.Size(222, 45);
            this.BtnRestoreBackup.TabIndex = 10;
            this.BtnRestoreBackup.Text = "Restore Backup";
            this.BtnRestoreBackup.Click += new System.EventHandler(this.BtnRestoreBackup_Click);
            // 
            // BtnBackupSave
            // 
            this.BtnBackupSave.AccessibleName = "BtnBackupSave";
            this.BtnBackupSave.Animated = true;
            this.BtnBackupSave.BackColor = System.Drawing.Color.Transparent;
            this.BtnBackupSave.BorderColor = global::QMM.Properties.Settings.Default.DetailColor;
            this.BtnBackupSave.BorderThickness = 1;
            this.BtnBackupSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnBackupSave.DataBindings.Add(new System.Windows.Forms.Binding("BorderColor", global::QMM.Properties.Settings.Default, "DetailColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.BtnBackupSave.DataBindings.Add(new System.Windows.Forms.Binding("FillColor", global::QMM.Properties.Settings.Default, "ButtonColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.BtnBackupSave.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::QMM.Properties.Settings.Default, "TextColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.BtnBackupSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnBackupSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnBackupSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnBackupSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnBackupSave.FillColor = global::QMM.Properties.Settings.Default.ButtonColor;
            this.BtnBackupSave.Font = new System.Drawing.Font("Gadugi", 10F);
            this.BtnBackupSave.ForeColor = global::QMM.Properties.Settings.Default.TextColor;
            this.BtnBackupSave.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(167)))), ((int)(((byte)(231)))));
            this.BtnBackupSave.ImageSize = new System.Drawing.Size(16, 16);
            this.BtnBackupSave.Location = new System.Drawing.Point(390, 175);
            this.BtnBackupSave.Name = "BtnBackupSave";
            this.BtnBackupSave.Size = new System.Drawing.Size(222, 45);
            this.BtnBackupSave.TabIndex = 10;
            this.BtnBackupSave.Text = "Backup Save";
            this.BtnBackupSave.Click += new System.EventHandler(this.BtnBackupSave_Click);
            // 
            // BtnCreateBackup
            // 
            this.BtnCreateBackup.AccessibleName = "BtnCreateBackup";
            this.BtnCreateBackup.Animated = true;
            this.BtnCreateBackup.BackColor = System.Drawing.Color.Transparent;
            this.BtnCreateBackup.BorderColor = global::QMM.Properties.Settings.Default.DetailColor;
            this.BtnCreateBackup.BorderThickness = 1;
            this.BtnCreateBackup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCreateBackup.DataBindings.Add(new System.Windows.Forms.Binding("BorderColor", global::QMM.Properties.Settings.Default, "DetailColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.BtnCreateBackup.DataBindings.Add(new System.Windows.Forms.Binding("FillColor", global::QMM.Properties.Settings.Default, "ButtonColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.BtnCreateBackup.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::QMM.Properties.Settings.Default, "TextColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.BtnCreateBackup.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnCreateBackup.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnCreateBackup.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnCreateBackup.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnCreateBackup.FillColor = global::QMM.Properties.Settings.Default.ButtonColor;
            this.BtnCreateBackup.Font = new System.Drawing.Font("Gadugi", 10F);
            this.BtnCreateBackup.ForeColor = global::QMM.Properties.Settings.Default.TextColor;
            this.BtnCreateBackup.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(167)))), ((int)(((byte)(231)))));
            this.BtnCreateBackup.ImageSize = new System.Drawing.Size(16, 16);
            this.BtnCreateBackup.Location = new System.Drawing.Point(390, 65);
            this.BtnCreateBackup.Name = "BtnCreateBackup";
            this.BtnCreateBackup.Size = new System.Drawing.Size(222, 45);
            this.BtnCreateBackup.TabIndex = 10;
            this.BtnCreateBackup.Text = "Create Backup";
            this.BtnCreateBackup.Click += new System.EventHandler(this.BtnCreateBackup_Click);
            // 
            // BtnLaunchGame
            // 
            this.BtnLaunchGame.AccessibleName = "BtnLaunchGame";
            this.BtnLaunchGame.Animated = true;
            this.BtnLaunchGame.BackColor = System.Drawing.Color.Transparent;
            this.BtnLaunchGame.BorderColor = global::QMM.Properties.Settings.Default.DetailColor;
            this.BtnLaunchGame.BorderThickness = 1;
            this.BtnLaunchGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnLaunchGame.DataBindings.Add(new System.Windows.Forms.Binding("BorderColor", global::QMM.Properties.Settings.Default, "DetailColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.BtnLaunchGame.DataBindings.Add(new System.Windows.Forms.Binding("FillColor", global::QMM.Properties.Settings.Default, "ButtonColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.BtnLaunchGame.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::QMM.Properties.Settings.Default, "TextColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.BtnLaunchGame.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnLaunchGame.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnLaunchGame.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnLaunchGame.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnLaunchGame.FillColor = global::QMM.Properties.Settings.Default.ButtonColor;
            this.BtnLaunchGame.Font = new System.Drawing.Font("Gadugi", 10F);
            this.BtnLaunchGame.ForeColor = global::QMM.Properties.Settings.Default.TextColor;
            this.BtnLaunchGame.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(167)))), ((int)(((byte)(231)))));
            this.BtnLaunchGame.ImageSize = new System.Drawing.Size(16, 16);
            this.BtnLaunchGame.Location = new System.Drawing.Point(390, 10);
            this.BtnLaunchGame.Name = "BtnLaunchGame";
            this.BtnLaunchGame.Size = new System.Drawing.Size(222, 45);
            this.BtnLaunchGame.TabIndex = 10;
            this.BtnLaunchGame.Text = "Launch Game";
            this.BtnLaunchGame.Click += new System.EventHandler(this.BtnLaunchGame_Click);
            // 
            // PanelModList
            // 
            this.PanelModList.AccessibleName = "PanelModList";
            this.PanelModList.AutoScroll = true;
            this.PanelModList.BackColor = System.Drawing.Color.Transparent;
            this.PanelModList.BorderColor = global::QMM.Properties.Settings.Default.DetailColor;
            this.PanelModList.BorderRadius = global::QMM.Properties.Settings.Default.BorderRadius;
            this.PanelModList.BorderThickness = 1;
            this.PanelModList.DataBindings.Add(new System.Windows.Forms.Binding("FillColor", global::QMM.Properties.Settings.Default, "BGSecondary", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.PanelModList.DataBindings.Add(new System.Windows.Forms.Binding("BorderRadius", global::QMM.Properties.Settings.Default, "BorderRadius", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.PanelModList.DataBindings.Add(new System.Windows.Forms.Binding("BorderColor", global::QMM.Properties.Settings.Default, "DetailColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.PanelModList.FillColor = global::QMM.Properties.Settings.Default.BGSecondary;
            this.PanelModList.Location = new System.Drawing.Point(10, 10);
            this.PanelModList.Name = "PanelModList";
            this.PanelModList.Size = new System.Drawing.Size(370, 410);
            this.PanelModList.TabIndex = 9;
            // 
            // BtnCloseInfo
            // 
            this.BtnCloseInfo.AccessibleDescription = "";
            this.BtnCloseInfo.AccessibleName = "BtnCloseInfo";
            this.BtnCloseInfo.Animated = true;
            this.BtnCloseInfo.BorderColor = global::QMM.Properties.Settings.Default.DetailColor;
            this.BtnCloseInfo.BorderThickness = 1;
            this.BtnCloseInfo.CheckedState.CustomBorderColor = System.Drawing.Color.White;
            this.BtnCloseInfo.CheckedState.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCloseInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCloseInfo.DataBindings.Add(new System.Windows.Forms.Binding("FillColor", global::QMM.Properties.Settings.Default, "ButtonColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.BtnCloseInfo.DataBindings.Add(new System.Windows.Forms.Binding("BorderColor", global::QMM.Properties.Settings.Default, "DetailColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.BtnCloseInfo.FillColor = global::QMM.Properties.Settings.Default.ButtonColor;
            this.BtnCloseInfo.Font = new System.Drawing.Font("Azonix", 11F);
            this.BtnCloseInfo.ForeColor = System.Drawing.Color.White;
            this.BtnCloseInfo.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(167)))), ((int)(((byte)(231)))));
            this.BtnCloseInfo.Image = ((System.Drawing.Image)(resources.GetObject("BtnCloseInfo.Image")));
            this.BtnCloseInfo.ImageSize = new System.Drawing.Size(16, 16);
            this.BtnCloseInfo.Location = new System.Drawing.Point(571, 285);
            this.BtnCloseInfo.Name = "BtnCloseInfo";
            this.BtnCloseInfo.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(36)))));
            this.BtnCloseInfo.Size = new System.Drawing.Size(41, 30);
            this.BtnCloseInfo.TabIndex = 6;
            this.BtnCloseInfo.Click += new System.EventHandler(this.BtnCloseInfo_Click);
            // 
            // BtnRemoveMod
            // 
            this.BtnRemoveMod.AccessibleDescription = "";
            this.BtnRemoveMod.AccessibleName = "BtnRemoveMod";
            this.BtnRemoveMod.Animated = true;
            this.BtnRemoveMod.BorderColor = global::QMM.Properties.Settings.Default.DetailColor;
            this.BtnRemoveMod.BorderThickness = 1;
            this.BtnRemoveMod.CheckedState.CustomBorderColor = System.Drawing.Color.White;
            this.BtnRemoveMod.CheckedState.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRemoveMod.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRemoveMod.DataBindings.Add(new System.Windows.Forms.Binding("FillColor", global::QMM.Properties.Settings.Default, "ButtonColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.BtnRemoveMod.DataBindings.Add(new System.Windows.Forms.Binding("BorderColor", global::QMM.Properties.Settings.Default, "DetailColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.BtnRemoveMod.FillColor = global::QMM.Properties.Settings.Default.ButtonColor;
            this.BtnRemoveMod.Font = new System.Drawing.Font("Azonix", 11F);
            this.BtnRemoveMod.ForeColor = System.Drawing.Color.White;
            this.BtnRemoveMod.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(167)))), ((int)(((byte)(231)))));
            this.BtnRemoveMod.Image = ((System.Drawing.Image)(resources.GetObject("BtnRemoveMod.Image")));
            this.BtnRemoveMod.ImageSize = new System.Drawing.Size(16, 16);
            this.BtnRemoveMod.Location = new System.Drawing.Point(511, 285);
            this.BtnRemoveMod.Name = "BtnRemoveMod";
            this.BtnRemoveMod.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(36)))));
            this.BtnRemoveMod.Size = new System.Drawing.Size(41, 30);
            this.BtnRemoveMod.TabIndex = 6;
            this.BtnRemoveMod.Click += new System.EventHandler(this.BtnRemoveMod_Click);
            // 
            // BtnRefreshModList
            // 
            this.BtnRefreshModList.AccessibleDescription = "";
            this.BtnRefreshModList.AccessibleName = "BtnRefreshModList";
            this.BtnRefreshModList.Animated = true;
            this.BtnRefreshModList.BorderColor = global::QMM.Properties.Settings.Default.DetailColor;
            this.BtnRefreshModList.BorderThickness = 1;
            this.BtnRefreshModList.CheckedState.CustomBorderColor = System.Drawing.Color.White;
            this.BtnRefreshModList.CheckedState.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRefreshModList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRefreshModList.DataBindings.Add(new System.Windows.Forms.Binding("FillColor", global::QMM.Properties.Settings.Default, "ButtonColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.BtnRefreshModList.DataBindings.Add(new System.Windows.Forms.Binding("BorderColor", global::QMM.Properties.Settings.Default, "DetailColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.BtnRefreshModList.FillColor = global::QMM.Properties.Settings.Default.ButtonColor;
            this.BtnRefreshModList.Font = new System.Drawing.Font("Azonix", 11F);
            this.BtnRefreshModList.ForeColor = System.Drawing.Color.White;
            this.BtnRefreshModList.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(167)))), ((int)(((byte)(231)))));
            this.BtnRefreshModList.Image = ((System.Drawing.Image)(resources.GetObject("BtnRefreshModList.Image")));
            this.BtnRefreshModList.ImageSize = new System.Drawing.Size(17, 16);
            this.BtnRefreshModList.Location = new System.Drawing.Point(451, 285);
            this.BtnRefreshModList.Name = "BtnRefreshModList";
            this.BtnRefreshModList.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(36)))));
            this.BtnRefreshModList.Size = new System.Drawing.Size(41, 30);
            this.BtnRefreshModList.TabIndex = 6;
            this.BtnRefreshModList.Click += new System.EventHandler(this.BtnRefreshButtons_Click);
            // 
            // BtnAddMod
            // 
            this.BtnAddMod.AccessibleName = "BtnAddMod";
            this.BtnAddMod.Animated = true;
            this.BtnAddMod.BorderColor = global::QMM.Properties.Settings.Default.DetailColor;
            this.BtnAddMod.BorderThickness = 1;
            this.BtnAddMod.CheckedState.CustomBorderColor = System.Drawing.Color.White;
            this.BtnAddMod.CheckedState.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddMod.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAddMod.DataBindings.Add(new System.Windows.Forms.Binding("FillColor", global::QMM.Properties.Settings.Default, "ButtonColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.BtnAddMod.DataBindings.Add(new System.Windows.Forms.Binding("BorderColor", global::QMM.Properties.Settings.Default, "DetailColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.BtnAddMod.FillColor = global::QMM.Properties.Settings.Default.ButtonColor;
            this.BtnAddMod.Font = new System.Drawing.Font("Azonix", 11F);
            this.BtnAddMod.ForeColor = System.Drawing.Color.White;
            this.BtnAddMod.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(167)))), ((int)(((byte)(231)))));
            this.BtnAddMod.Image = ((System.Drawing.Image)(resources.GetObject("BtnAddMod.Image")));
            this.BtnAddMod.ImageSize = new System.Drawing.Size(17, 16);
            this.BtnAddMod.Location = new System.Drawing.Point(391, 285);
            this.BtnAddMod.Name = "BtnAddMod";
            this.BtnAddMod.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(36)))));
            this.BtnAddMod.Size = new System.Drawing.Size(41, 30);
            this.BtnAddMod.TabIndex = 6;
            this.BtnAddMod.Click += new System.EventHandler(this.BtnAddMod_Click);
            // 
            // PanelHeader
            // 
            this.PanelHeader.AccessibleName = "PanelHeader";
            this.PanelHeader.BackColor = System.Drawing.Color.Transparent;
            this.PanelHeader.BorderColor = global::QMM.Properties.Settings.Default.DetailColor;
            this.PanelHeader.BorderRadius = global::QMM.Properties.Settings.Default.BorderRadius;
            this.PanelHeader.BorderThickness = 1;
            this.PanelHeader.Controls.Add(this.BtnClose);
            this.PanelHeader.Controls.Add(this.BtnMinimize);
            this.PanelHeader.Controls.Add(this.BtnInfo);
            this.PanelHeader.Controls.Add(this.BtnUserSettings);
            this.PanelHeader.Controls.Add(this.ImgIcon);
            this.PanelHeader.Controls.Add(this.LabelTitle);
            this.PanelHeader.CustomizableEdges.BottomLeft = false;
            this.PanelHeader.CustomizableEdges.BottomRight = false;
            this.PanelHeader.DataBindings.Add(new System.Windows.Forms.Binding("BorderRadius", global::QMM.Properties.Settings.Default, "BorderRadius", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.PanelHeader.DataBindings.Add(new System.Windows.Forms.Binding("BorderColor", global::QMM.Properties.Settings.Default, "DetailColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.PanelHeader.DataBindings.Add(new System.Windows.Forms.Binding("FillColor", global::QMM.Properties.Settings.Default, "BGTertiary", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.PanelHeader.FillColor = global::QMM.Properties.Settings.Default.BGTertiary;
            this.PanelHeader.Location = new System.Drawing.Point(10, 10);
            this.PanelHeader.Name = "PanelHeader";
            this.PanelHeader.Size = new System.Drawing.Size(623, 60);
            this.PanelHeader.TabIndex = 7;
            this.PanelHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoveWindow);
            // 
            // BtnClose
            // 
            this.BtnClose.AccessibleName = "BtnClose";
            this.BtnClose.Animated = true;
            this.BtnClose.BorderColor = System.Drawing.Color.White;
            this.BtnClose.BorderThickness = 1;
            this.BtnClose.CheckedState.CustomBorderColor = System.Drawing.Color.White;
            this.BtnClose.CheckedState.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnClose.DataBindings.Add(new System.Windows.Forms.Binding("FillColor", global::QMM.Properties.Settings.Default, "ButtonColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.BtnClose.FillColor = global::QMM.Properties.Settings.Default.ButtonColor;
            this.BtnClose.Font = new System.Drawing.Font("Azonix", 11F);
            this.BtnClose.ForeColor = System.Drawing.Color.White;
            this.BtnClose.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(167)))), ((int)(((byte)(231)))));
            this.BtnClose.Location = new System.Drawing.Point(582, 15);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(36)))));
            this.BtnClose.Size = new System.Drawing.Size(30, 30);
            this.BtnClose.TabIndex = 3;
            this.BtnClose.Text = "X";
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // BtnMinimize
            // 
            this.BtnMinimize.AccessibleName = "BtnMinimize";
            this.BtnMinimize.Animated = true;
            this.BtnMinimize.BorderColor = System.Drawing.Color.White;
            this.BtnMinimize.BorderThickness = 1;
            this.BtnMinimize.CheckedState.CustomBorderColor = System.Drawing.Color.White;
            this.BtnMinimize.CheckedState.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnMinimize.DataBindings.Add(new System.Windows.Forms.Binding("FillColor", global::QMM.Properties.Settings.Default, "ButtonColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.BtnMinimize.FillColor = global::QMM.Properties.Settings.Default.ButtonColor;
            this.BtnMinimize.Font = new System.Drawing.Font("Azonix", 11F);
            this.BtnMinimize.ForeColor = System.Drawing.Color.White;
            this.BtnMinimize.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(167)))), ((int)(((byte)(231)))));
            this.BtnMinimize.Location = new System.Drawing.Point(537, 15);
            this.BtnMinimize.Name = "BtnMinimize";
            this.BtnMinimize.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(36)))));
            this.BtnMinimize.Size = new System.Drawing.Size(30, 30);
            this.BtnMinimize.TabIndex = 4;
            this.BtnMinimize.Text = "-";
            this.BtnMinimize.Click += new System.EventHandler(this.BtnMinimize_Click);
            // 
            // BtnInfo
            // 
            this.BtnInfo.AccessibleName = "BtnInfo";
            this.BtnInfo.Animated = true;
            this.BtnInfo.BorderColor = System.Drawing.Color.White;
            this.BtnInfo.BorderThickness = 1;
            this.BtnInfo.CheckedState.CustomBorderColor = System.Drawing.Color.White;
            this.BtnInfo.CheckedState.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnInfo.DataBindings.Add(new System.Windows.Forms.Binding("FillColor", global::QMM.Properties.Settings.Default, "ButtonColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.BtnInfo.FillColor = global::QMM.Properties.Settings.Default.ButtonColor;
            this.BtnInfo.Font = new System.Drawing.Font("Azonix", 11F);
            this.BtnInfo.ForeColor = System.Drawing.Color.White;
            this.BtnInfo.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(167)))), ((int)(((byte)(231)))));
            this.BtnInfo.Location = new System.Drawing.Point(492, 15);
            this.BtnInfo.Name = "BtnInfo";
            this.BtnInfo.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(36)))));
            this.BtnInfo.Size = new System.Drawing.Size(30, 30);
            this.BtnInfo.TabIndex = 5;
            this.BtnInfo.Text = "?";
            this.BtnInfo.Click += new System.EventHandler(this.BtnInfo_Click);
            // 
            // BtnUserSettings
            // 
            this.BtnUserSettings.AccessibleName = "BtnUserSettings";
            this.BtnUserSettings.Animated = true;
            this.BtnUserSettings.BorderColor = System.Drawing.Color.White;
            this.BtnUserSettings.BorderThickness = 1;
            this.BtnUserSettings.CheckedState.CustomBorderColor = System.Drawing.Color.White;
            this.BtnUserSettings.CheckedState.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUserSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnUserSettings.DataBindings.Add(new System.Windows.Forms.Binding("FillColor", global::QMM.Properties.Settings.Default, "ButtonColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.BtnUserSettings.FillColor = global::QMM.Properties.Settings.Default.ButtonColor;
            this.BtnUserSettings.Font = new System.Drawing.Font("Azonix", 11F);
            this.BtnUserSettings.ForeColor = System.Drawing.Color.White;
            this.BtnUserSettings.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(167)))), ((int)(((byte)(231)))));
            this.BtnUserSettings.Image = ((System.Drawing.Image)(resources.GetObject("BtnUserSettings.Image")));
            this.BtnUserSettings.ImageOffset = new System.Drawing.Point(1, 1);
            this.BtnUserSettings.ImageSize = new System.Drawing.Size(30, 30);
            this.BtnUserSettings.Location = new System.Drawing.Point(447, 15);
            this.BtnUserSettings.Name = "BtnUserSettings";
            this.BtnUserSettings.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(36)))));
            this.BtnUserSettings.Size = new System.Drawing.Size(30, 30);
            this.BtnUserSettings.TabIndex = 6;
            this.BtnUserSettings.Click += new System.EventHandler(this.BtnUserSettings_Click);
            // 
            // ImgIcon
            // 
            this.ImgIcon.AccessibleName = "ImgIcon";
            this.ImgIcon.Image = global::QMM.Properties.Resources.AnimatedQuillDiamond;
            this.ImgIcon.Location = new System.Drawing.Point(7, 4);
            this.ImgIcon.Name = "ImgIcon";
            this.ImgIcon.Size = new System.Drawing.Size(52, 52);
            this.ImgIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImgIcon.TabIndex = 10;
            this.ImgIcon.TabStop = false;
            this.ImgIcon.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoveWindow);
            // 
            // LabelTitle
            // 
            this.LabelTitle.AccessibleName = "LabelTitle";
            this.LabelTitle.AutoSize = true;
            this.LabelTitle.BackColor = System.Drawing.Color.Transparent;
            this.LabelTitle.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::QMM.Properties.Settings.Default, "TextColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.LabelTitle.Font = new System.Drawing.Font("Azonix", 27F);
            this.LabelTitle.ForeColor = global::QMM.Properties.Settings.Default.TextColor;
            this.LabelTitle.Location = new System.Drawing.Point(66, 14);
            this.LabelTitle.Name = "LabelTitle";
            this.LabelTitle.Size = new System.Drawing.Size(102, 36);
            this.LabelTitle.TabIndex = 9;
            this.LabelTitle.Text = "QMM";
            this.LabelTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoveWindow);
            // 
            // MainForm
            // 
            this.AccessibleName = "MainForm";
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = global::QMM.Properties.Settings.Default.BGPrimary;
            this.ClientSize = new System.Drawing.Size(643, 521);
            this.Controls.Add(this.LabelMadeBy);
            this.Controls.Add(this.LabelVersion);
            this.Controls.Add(this.PanelBody);
            this.Controls.Add(this.PanelHeader);
            this.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::QMM.Properties.Settings.Default, "BGPrimary", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quill\'s Mod Manager";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoveWindow);
            this.PanelBody.ResumeLayout(false);
            this.PanelBody.PerformLayout();
            this.PanelHeader.ResumeLayout(false);
            this.PanelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel PanelHeader;
        private Guna.UI2.WinForms.Guna2Button BtnClose;
        private Guna.UI2.WinForms.Guna2Button BtnMinimize;
        private Guna.UI2.WinForms.Guna2Button BtnInfo;
        private Guna.UI2.WinForms.Guna2Button BtnAddMod;
        private Guna.UI2.WinForms.Guna2Button BtnUserSettings;
        private System.Windows.Forms.PictureBox ImgIcon;
        private System.Windows.Forms.Label LabelTitle;
        private Guna.UI2.WinForms.Guna2Panel PanelBody;
        private System.Windows.Forms.Label LabelMadeBy;
        private System.Windows.Forms.Label LabelVersion;
        private Guna.UI2.WinForms.Guna2Panel PanelModList;
        private Guna.UI2.WinForms.Guna2Button BtnRefreshModList;
        private Guna.UI2.WinForms.Guna2Button BtnRemoveMod;
        private Guna.UI2.WinForms.Guna2Button BtnLaunchGame;
        private Guna.UI2.WinForms.Guna2Button BtnCloseInfo;
        private Guna.UI2.WinForms.Guna2Button BtnCreateBackup;
        private Guna.UI2.WinForms.Guna2ProgressBar ProgressBar;
        private System.Windows.Forms.Label LabelProgress;
        private Guna.UI2.WinForms.Guna2Button BtnRestoreSave;
        private Guna.UI2.WinForms.Guna2Button BtnRestoreBackup;
        private Guna.UI2.WinForms.Guna2Button BtnBackupSave;
    }
}

