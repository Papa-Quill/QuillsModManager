namespace QMM.Info_Forms
{
    partial class MainInfoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainInfoForm));
            this.LabelWatermark = new System.Windows.Forms.Label();
            this.PanelBody = new Guna.UI2.WinForms.Guna2Panel();
            this.BtnOpenRepo = new Guna.UI2.WinForms.Guna2Button();
            this.BtnJoinDiscord = new Guna.UI2.WinForms.Guna2Button();
            this.LabelInfo = new System.Windows.Forms.Label();
            this.PanelHeader = new Guna.UI2.WinForms.Guna2Panel();
            this.BtnClose = new Guna.UI2.WinForms.Guna2Button();
            this.imgIcon = new System.Windows.Forms.PictureBox();
            this.LabelTitle = new System.Windows.Forms.Label();
            this.LabelVersion = new System.Windows.Forms.Label();
            this.PanelBody.SuspendLayout();
            this.PanelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelWatermark
            // 
            this.LabelWatermark.AccessibleName = "LabelWatermark";
            this.LabelWatermark.AutoSize = true;
            this.LabelWatermark.BackColor = System.Drawing.Color.Transparent;
            this.LabelWatermark.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LabelWatermark.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::QMM.Properties.Settings.Default, "TextColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.LabelWatermark.Font = new System.Drawing.Font("Gadugi", 10F);
            this.LabelWatermark.ForeColor = global::QMM.Properties.Settings.Default.TextColor;
            this.LabelWatermark.Location = new System.Drawing.Point(268, 265);
            this.LabelWatermark.Name = "LabelWatermark";
            this.LabelWatermark.Size = new System.Drawing.Size(143, 17);
            this.LabelWatermark.TabIndex = 19;
            this.LabelWatermark.Text = "Cosmos Development";
            this.LabelWatermark.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LabelWatermark.Click += new System.EventHandler(this.LabelWatermark_Click);
            // 
            // PanelBody
            // 
            this.PanelBody.AccessibleName = "PanelBody";
            this.PanelBody.BackColor = System.Drawing.Color.Transparent;
            this.PanelBody.BorderColor = global::QMM.Properties.Settings.Default.DetailColor;
            this.PanelBody.BorderRadius = global::QMM.Properties.Settings.Default.BorderRadius;
            this.PanelBody.BorderThickness = 1;
            this.PanelBody.Controls.Add(this.BtnOpenRepo);
            this.PanelBody.Controls.Add(this.BtnJoinDiscord);
            this.PanelBody.Controls.Add(this.LabelInfo);
            this.PanelBody.CustomizableEdges.TopLeft = false;
            this.PanelBody.CustomizableEdges.TopRight = false;
            this.PanelBody.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::QMM.Properties.Settings.Default, "BGSecondary", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.PanelBody.DataBindings.Add(new System.Windows.Forms.Binding("BorderRadius", global::QMM.Properties.Settings.Default, "BorderRadius", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.PanelBody.DataBindings.Add(new System.Windows.Forms.Binding("BorderColor", global::QMM.Properties.Settings.Default, "DetailColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.PanelBody.DataBindings.Add(new System.Windows.Forms.Binding("FillColor", global::QMM.Properties.Settings.Default, "BGSecondary", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.PanelBody.FillColor = global::QMM.Properties.Settings.Default.BGSecondary;
            this.PanelBody.ForeColor = global::QMM.Properties.Settings.Default.BGSecondary;
            this.PanelBody.Location = new System.Drawing.Point(10, 71);
            this.PanelBody.Name = "PanelBody";
            this.PanelBody.Size = new System.Drawing.Size(396, 192);
            this.PanelBody.TabIndex = 16;
            // 
            // BtnOpenRepo
            // 
            this.BtnOpenRepo.AccessibleName = "BtnOpenRepo";
            this.BtnOpenRepo.Animated = true;
            this.BtnOpenRepo.BackColor = System.Drawing.Color.Transparent;
            this.BtnOpenRepo.BorderColor = global::QMM.Properties.Settings.Default.DetailColor;
            this.BtnOpenRepo.BorderThickness = 1;
            this.BtnOpenRepo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnOpenRepo.DataBindings.Add(new System.Windows.Forms.Binding("BorderColor", global::QMM.Properties.Settings.Default, "DetailColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.BtnOpenRepo.DataBindings.Add(new System.Windows.Forms.Binding("FillColor", global::QMM.Properties.Settings.Default, "ButtonColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.BtnOpenRepo.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::QMM.Properties.Settings.Default, "TextColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.BtnOpenRepo.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnOpenRepo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnOpenRepo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnOpenRepo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnOpenRepo.FillColor = global::QMM.Properties.Settings.Default.ButtonColor;
            this.BtnOpenRepo.Font = new System.Drawing.Font("Gadugi", 10F);
            this.BtnOpenRepo.ForeColor = global::QMM.Properties.Settings.Default.TextColor;
            this.BtnOpenRepo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(167)))), ((int)(((byte)(231)))));
            this.BtnOpenRepo.Image = ((System.Drawing.Image)(resources.GetObject("BtnOpenRepo.Image")));
            this.BtnOpenRepo.ImageOffset = new System.Drawing.Point(-2, 0);
            this.BtnOpenRepo.ImageSize = new System.Drawing.Size(16, 16);
            this.BtnOpenRepo.Location = new System.Drawing.Point(199, 136);
            this.BtnOpenRepo.Name = "BtnOpenRepo";
            this.BtnOpenRepo.Size = new System.Drawing.Size(182, 45);
            this.BtnOpenRepo.TabIndex = 17;
            this.BtnOpenRepo.Text = "Open GitHub Repo";
            this.BtnOpenRepo.Click += new System.EventHandler(this.LabelWatermark_Click);
            // 
            // BtnJoinDiscord
            // 
            this.BtnJoinDiscord.AccessibleName = "BtnJoinDiscord";
            this.BtnJoinDiscord.Animated = true;
            this.BtnJoinDiscord.BackColor = System.Drawing.Color.Transparent;
            this.BtnJoinDiscord.BorderColor = global::QMM.Properties.Settings.Default.DetailColor;
            this.BtnJoinDiscord.BorderThickness = 1;
            this.BtnJoinDiscord.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnJoinDiscord.DataBindings.Add(new System.Windows.Forms.Binding("BorderColor", global::QMM.Properties.Settings.Default, "DetailColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.BtnJoinDiscord.DataBindings.Add(new System.Windows.Forms.Binding("FillColor", global::QMM.Properties.Settings.Default, "ButtonColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.BtnJoinDiscord.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::QMM.Properties.Settings.Default, "TextColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.BtnJoinDiscord.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnJoinDiscord.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnJoinDiscord.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnJoinDiscord.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnJoinDiscord.FillColor = global::QMM.Properties.Settings.Default.ButtonColor;
            this.BtnJoinDiscord.Font = new System.Drawing.Font("Gadugi", 10F);
            this.BtnJoinDiscord.ForeColor = global::QMM.Properties.Settings.Default.TextColor;
            this.BtnJoinDiscord.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(167)))), ((int)(((byte)(231)))));
            this.BtnJoinDiscord.Image = ((System.Drawing.Image)(resources.GetObject("BtnJoinDiscord.Image")));
            this.BtnJoinDiscord.ImageOffset = new System.Drawing.Point(-2, 0);
            this.BtnJoinDiscord.ImageSize = new System.Drawing.Size(16, 12);
            this.BtnJoinDiscord.Location = new System.Drawing.Point(11, 136);
            this.BtnJoinDiscord.Name = "BtnJoinDiscord";
            this.BtnJoinDiscord.Size = new System.Drawing.Size(182, 45);
            this.BtnJoinDiscord.TabIndex = 17;
            this.BtnJoinDiscord.Text = "Join Discord";
            this.BtnJoinDiscord.Click += new System.EventHandler(this.BtnJoinDiscord_Click);
            // 
            // LabelInfo
            // 
            this.LabelInfo.AccessibleName = "LabelInfo";
            this.LabelInfo.AutoSize = true;
            this.LabelInfo.BackColor = System.Drawing.Color.Transparent;
            this.LabelInfo.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::QMM.Properties.Settings.Default, "TextColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.LabelInfo.Font = new System.Drawing.Font("Gadugi", 12F);
            this.LabelInfo.ForeColor = global::QMM.Properties.Settings.Default.TextColor;
            this.LabelInfo.Location = new System.Drawing.Point(31, 20);
            this.LabelInfo.Name = "LabelInfo";
            this.LabelInfo.Size = new System.Drawing.Size(334, 95);
            this.LabelInfo.TabIndex = 16;
            this.LabelInfo.Text = "QMM (Quill\'s Mod Manager) is a tool made for\r\nCastle Crashers modding. It targets" +
    " file mods.\r\nv1.0.0 was created on April 12th 2024.\r\n\r\nCreated by Papa Quill";
            this.LabelInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PanelHeader
            // 
            this.PanelHeader.AccessibleName = "PanelHeader";
            this.PanelHeader.BackColor = System.Drawing.Color.Transparent;
            this.PanelHeader.BorderColor = global::QMM.Properties.Settings.Default.DetailColor;
            this.PanelHeader.BorderRadius = global::QMM.Properties.Settings.Default.BorderRadius;
            this.PanelHeader.BorderThickness = 1;
            this.PanelHeader.Controls.Add(this.BtnClose);
            this.PanelHeader.Controls.Add(this.imgIcon);
            this.PanelHeader.Controls.Add(this.LabelTitle);
            this.PanelHeader.CustomizableEdges.BottomLeft = false;
            this.PanelHeader.CustomizableEdges.BottomRight = false;
            this.PanelHeader.DataBindings.Add(new System.Windows.Forms.Binding("FillColor", global::QMM.Properties.Settings.Default, "BGTertiary", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.PanelHeader.DataBindings.Add(new System.Windows.Forms.Binding("BorderRadius", global::QMM.Properties.Settings.Default, "BorderRadius", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.PanelHeader.DataBindings.Add(new System.Windows.Forms.Binding("BorderColor", global::QMM.Properties.Settings.Default, "DetailColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.PanelHeader.FillColor = global::QMM.Properties.Settings.Default.BGTertiary;
            this.PanelHeader.Location = new System.Drawing.Point(10, 11);
            this.PanelHeader.Name = "PanelHeader";
            this.PanelHeader.Size = new System.Drawing.Size(396, 60);
            this.PanelHeader.TabIndex = 17;
            this.PanelHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoveWindow);
            // 
            // BtnClose
            // 
            this.BtnClose.AccessibleName = "BtnClose";
            this.BtnClose.Animated = true;
            this.BtnClose.BackColor = System.Drawing.Color.Transparent;
            this.BtnClose.BorderColor = System.Drawing.Color.White;
            this.BtnClose.BorderThickness = 1;
            this.BtnClose.CheckedState.CustomBorderColor = System.Drawing.Color.White;
            this.BtnClose.CheckedState.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnClose.DataBindings.Add(new System.Windows.Forms.Binding("FillColor", global::QMM.Properties.Settings.Default, "ButtonColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.BtnClose.FillColor = global::QMM.Properties.Settings.Default.ButtonColor;
            this.BtnClose.Font = new System.Drawing.Font("Azonix", 11F);
            this.BtnClose.ForeColor = System.Drawing.Color.White;
            this.BtnClose.HoverState.CustomBorderColor = System.Drawing.Color.White;
            this.BtnClose.Location = new System.Drawing.Point(351, 15);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(36)))));
            this.BtnClose.Size = new System.Drawing.Size(30, 30);
            this.BtnClose.TabIndex = 11;
            this.BtnClose.Text = "X";
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // imgIcon
            // 
            this.imgIcon.AccessibleName = "imgIcon";
            this.imgIcon.Image = global::QMM.Properties.Resources.AnimatedQuillDiamond;
            this.imgIcon.Location = new System.Drawing.Point(7, 4);
            this.imgIcon.Name = "imgIcon";
            this.imgIcon.Size = new System.Drawing.Size(52, 52);
            this.imgIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgIcon.TabIndex = 10;
            this.imgIcon.TabStop = false;
            this.imgIcon.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoveWindow);
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
            this.LabelTitle.Size = new System.Drawing.Size(105, 36);
            this.LabelTitle.TabIndex = 9;
            this.LabelTitle.Text = "Info";
            this.LabelTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoveWindow);
            // 
            // LabelVersion
            // 
            this.LabelVersion.AccessibleName = "LabelVersion";
            this.LabelVersion.BackColor = System.Drawing.Color.Transparent;
            this.LabelVersion.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::QMM.Properties.Settings.Default, "Version", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.LabelVersion.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::QMM.Properties.Settings.Default, "TextColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.LabelVersion.Font = new System.Drawing.Font("Gadugi", 10F);
            this.LabelVersion.ForeColor = global::QMM.Properties.Settings.Default.TextColor;
            this.LabelVersion.Location = new System.Drawing.Point(8, 265);
            this.LabelVersion.Name = "LabelVersion";
            this.LabelVersion.Size = new System.Drawing.Size(179, 17);
            this.LabelVersion.TabIndex = 18;
            this.LabelVersion.Text = global::QMM.Properties.Settings.Default.Version;
            this.LabelVersion.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoveWindow);
            // 
            // MainInfoForm
            // 
            this.AccessibleName = "MainInfoForm";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = global::QMM.Properties.Settings.Default.BGPrimary;
            this.ClientSize = new System.Drawing.Size(416, 284);
            this.Controls.Add(this.LabelWatermark);
            this.Controls.Add(this.PanelBody);
            this.Controls.Add(this.PanelHeader);
            this.Controls.Add(this.LabelVersion);
            this.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::QMM.Properties.Settings.Default, "BGPrimary", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainInfoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QMM | Main Info Form";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoveWindow);
            this.PanelBody.ResumeLayout(false);
            this.PanelBody.PerformLayout();
            this.PanelHeader.ResumeLayout(false);
            this.PanelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelWatermark;
        private Guna.UI2.WinForms.Guna2Panel PanelBody;
        private System.Windows.Forms.Label LabelInfo;
        private Guna.UI2.WinForms.Guna2Panel PanelHeader;
        private Guna.UI2.WinForms.Guna2Button BtnClose;
        private System.Windows.Forms.PictureBox imgIcon;
        private System.Windows.Forms.Label LabelTitle;
        private System.Windows.Forms.Label LabelVersion;
        private Guna.UI2.WinForms.Guna2Button BtnJoinDiscord;
        private Guna.UI2.WinForms.Guna2Button BtnOpenRepo;
    }
}