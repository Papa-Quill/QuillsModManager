namespace QMM.Info_Forms
{
    partial class FModInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FModInfo));
            this.ImgIcon = new System.Windows.Forms.PictureBox();
            this.LabelModAuthor = new System.Windows.Forms.Label();
            this.LabelModVersion = new System.Windows.Forms.Label();
            this.BtnLaunchMod = new Guna.UI2.WinForms.Guna2Button();
            this.TxtModDescription = new Guna.UI2.WinForms.Guna2TextBox();
            this.TxtModTitle = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ImgIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // ImgIcon
            // 
            this.ImgIcon.AccessibleName = "ImgIcon";
            this.ImgIcon.BackColor = global::QMM.Properties.Settings.Default.BGSecondary;
            this.ImgIcon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ImgIcon.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::QMM.Properties.Settings.Default, "BGSecondary", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ImgIcon.Image = global::QMM.Properties.Resources.NoImage;
            this.ImgIcon.Location = new System.Drawing.Point(10, 10);
            this.ImgIcon.Name = "ImgIcon";
            this.ImgIcon.Size = new System.Drawing.Size(180, 180);
            this.ImgIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImgIcon.TabIndex = 11;
            this.ImgIcon.TabStop = false;
            // 
            // LabelModAuthor
            // 
            this.LabelModAuthor.AccessibleName = "LabelModAuthor";
            this.LabelModAuthor.BackColor = System.Drawing.Color.Transparent;
            this.LabelModAuthor.Cursor = System.Windows.Forms.Cursors.Default;
            this.LabelModAuthor.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::QMM.Properties.Settings.Default, "TextColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.LabelModAuthor.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.LabelModAuthor.ForeColor = global::QMM.Properties.Settings.Default.TextColor;
            this.LabelModAuthor.Location = new System.Drawing.Point(6, 485);
            this.LabelModAuthor.Name = "LabelModAuthor";
            this.LabelModAuthor.Size = new System.Drawing.Size(132, 21);
            this.LabelModAuthor.TabIndex = 13;
            this.LabelModAuthor.Text = "LabelModAuthor";
            this.LabelModAuthor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LabelModVersion
            // 
            this.LabelModVersion.AccessibleName = "LabelModVersion";
            this.LabelModVersion.BackColor = System.Drawing.Color.Transparent;
            this.LabelModVersion.Cursor = System.Windows.Forms.Cursors.Default;
            this.LabelModVersion.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::QMM.Properties.Settings.Default, "TextColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.LabelModVersion.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.LabelModVersion.ForeColor = global::QMM.Properties.Settings.Default.TextColor;
            this.LabelModVersion.Location = new System.Drawing.Point(137, 485);
            this.LabelModVersion.Name = "LabelModVersion";
            this.LabelModVersion.Size = new System.Drawing.Size(58, 21);
            this.LabelModVersion.TabIndex = 13;
            this.LabelModVersion.Text = "v4.7.1";
            this.LabelModVersion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // BtnLaunchMod
            // 
            this.BtnLaunchMod.AccessibleName = "BtnLaunchMod";
            this.BtnLaunchMod.Animated = true;
            this.BtnLaunchMod.BackColor = System.Drawing.Color.Transparent;
            this.BtnLaunchMod.BorderColor = global::QMM.Properties.Settings.Default.DetailColor;
            this.BtnLaunchMod.BorderThickness = 1;
            this.BtnLaunchMod.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnLaunchMod.DataBindings.Add(new System.Windows.Forms.Binding("BorderColor", global::QMM.Properties.Settings.Default, "DetailColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.BtnLaunchMod.DataBindings.Add(new System.Windows.Forms.Binding("FillColor", global::QMM.Properties.Settings.Default, "ButtonColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.BtnLaunchMod.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::QMM.Properties.Settings.Default, "TextColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.BtnLaunchMod.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnLaunchMod.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnLaunchMod.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnLaunchMod.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnLaunchMod.FillColor = global::QMM.Properties.Settings.Default.ButtonColor;
            this.BtnLaunchMod.Font = new System.Drawing.Font("Gadugi", 10F);
            this.BtnLaunchMod.ForeColor = global::QMM.Properties.Settings.Default.TextColor;
            this.BtnLaunchMod.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(167)))), ((int)(((byte)(231)))));
            this.BtnLaunchMod.ImageSize = new System.Drawing.Size(16, 16);
            this.BtnLaunchMod.Location = new System.Drawing.Point(10, 431);
            this.BtnLaunchMod.Name = "BtnLaunchMod";
            this.BtnLaunchMod.Size = new System.Drawing.Size(180, 45);
            this.BtnLaunchMod.TabIndex = 14;
            this.BtnLaunchMod.Text = "Install Mod!";
            this.BtnLaunchMod.Click += new System.EventHandler(this.BtnLaunchMod_Click);
            // 
            // TxtModDescription
            // 
            this.TxtModDescription.AccessibleName = "TxtModDescription";
            this.TxtModDescription.Animated = true;
            this.TxtModDescription.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.TxtModDescription.BackColor = System.Drawing.Color.Transparent;
            this.TxtModDescription.BorderColor = global::QMM.Properties.Settings.Default.DetailColor;
            this.TxtModDescription.Cursor = System.Windows.Forms.Cursors.Default;
            this.TxtModDescription.DataBindings.Add(new System.Windows.Forms.Binding("BorderColor", global::QMM.Properties.Settings.Default, "DetailColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.TxtModDescription.DataBindings.Add(new System.Windows.Forms.Binding("FillColor", global::QMM.Properties.Settings.Default, "BGSecondary", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.TxtModDescription.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::QMM.Properties.Settings.Default, "TextColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.TxtModDescription.DataBindings.Add(new System.Windows.Forms.Binding("PlaceholderForeColor", global::QMM.Properties.Settings.Default, "PlaceholderColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.TxtModDescription.DefaultText = "TxtModDescription\r\nLorem ipsum dolor sit amet, consectetur adipiscing elit. Donec" +
    " lobortis magna lorem, vel facilisis lacus sollicitudin ac.";
            this.TxtModDescription.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtModDescription.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtModDescription.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtModDescription.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtModDescription.FillColor = global::QMM.Properties.Settings.Default.BGSecondary;
            this.TxtModDescription.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(86)))));
            this.TxtModDescription.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.TxtModDescription.ForeColor = global::QMM.Properties.Settings.Default.TextColor;
            this.TxtModDescription.HideSelection = false;
            this.TxtModDescription.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(86)))));
            this.TxtModDescription.Location = new System.Drawing.Point(10, 266);
            this.TxtModDescription.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtModDescription.MaxLength = 255;
            this.TxtModDescription.Multiline = true;
            this.TxtModDescription.Name = "TxtModDescription";
            this.TxtModDescription.PasswordChar = '\0';
            this.TxtModDescription.PlaceholderForeColor = global::QMM.Properties.Settings.Default.PlaceholderColor;
            this.TxtModDescription.PlaceholderText = "TxtModDescription";
            this.TxtModDescription.ReadOnly = true;
            this.TxtModDescription.SelectedText = "";
            this.TxtModDescription.Size = new System.Drawing.Size(180, 156);
            this.TxtModDescription.TabIndex = 15;
            this.TxtModDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtModTitle
            // 
            this.TxtModTitle.AccessibleName = "TxtModTitle";
            this.TxtModTitle.Animated = true;
            this.TxtModTitle.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.TxtModTitle.BackColor = System.Drawing.Color.Transparent;
            this.TxtModTitle.BorderColor = global::QMM.Properties.Settings.Default.DetailColor;
            this.TxtModTitle.Cursor = System.Windows.Forms.Cursors.Default;
            this.TxtModTitle.DataBindings.Add(new System.Windows.Forms.Binding("BorderColor", global::QMM.Properties.Settings.Default, "DetailColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.TxtModTitle.DataBindings.Add(new System.Windows.Forms.Binding("FillColor", global::QMM.Properties.Settings.Default, "BGSecondary", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.TxtModTitle.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::QMM.Properties.Settings.Default, "TextColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.TxtModTitle.DataBindings.Add(new System.Windows.Forms.Binding("PlaceholderForeColor", global::QMM.Properties.Settings.Default, "PlaceholderColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.TxtModTitle.DefaultText = "TxtModTitle and more title text";
            this.TxtModTitle.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtModTitle.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtModTitle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtModTitle.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtModTitle.FillColor = global::QMM.Properties.Settings.Default.BGSecondary;
            this.TxtModTitle.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(86)))));
            this.TxtModTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtModTitle.ForeColor = global::QMM.Properties.Settings.Default.TextColor;
            this.TxtModTitle.HideSelection = false;
            this.TxtModTitle.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(86)))));
            this.TxtModTitle.Location = new System.Drawing.Point(11, 199);
            this.TxtModTitle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtModTitle.MaxLength = 255;
            this.TxtModTitle.Multiline = true;
            this.TxtModTitle.Name = "TxtModTitle";
            this.TxtModTitle.PasswordChar = '\0';
            this.TxtModTitle.PlaceholderForeColor = global::QMM.Properties.Settings.Default.PlaceholderColor;
            this.TxtModTitle.PlaceholderText = "TxtModTitle";
            this.TxtModTitle.ReadOnly = true;
            this.TxtModTitle.SelectedText = "";
            this.TxtModTitle.Size = new System.Drawing.Size(179, 59);
            this.TxtModTitle.TabIndex = 15;
            this.TxtModTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FModInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = global::QMM.Properties.Settings.Default.BGPrimary;
            this.ClientSize = new System.Drawing.Size(200, 516);
            this.Controls.Add(this.BtnLaunchMod);
            this.Controls.Add(this.LabelModVersion);
            this.Controls.Add(this.LabelModAuthor);
            this.Controls.Add(this.ImgIcon);
            this.Controls.Add(this.TxtModTitle);
            this.Controls.Add(this.TxtModDescription);
            this.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::QMM.Properties.Settings.Default, "BGPrimary", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FModInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FModInfo";
            ((System.ComponentModel.ISupportInitialize)(this.ImgIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ImgIcon;
        private System.Windows.Forms.Label LabelModAuthor;
        private System.Windows.Forms.Label LabelModVersion;
        private Guna.UI2.WinForms.Guna2Button BtnLaunchMod;
        private Guna.UI2.WinForms.Guna2TextBox TxtModDescription;
        private Guna.UI2.WinForms.Guna2TextBox TxtModTitle;
    }
}