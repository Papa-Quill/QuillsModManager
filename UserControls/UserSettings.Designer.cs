using QMM.Util;

namespace QMM
{
    partial class UserSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserSettings));
            this.LabelRemember = new System.Windows.Forms.Label();
            this.PanelSEEBody = new Guna.UI2.WinForms.Guna2Panel();
            this.BtnOpenSavesDir = new Guna.UI2.WinForms.Guna2Button();
            this.BtnOpenGameDir = new Guna.UI2.WinForms.Guna2Button();
            this.ComboBoxThemes = new Guna.UI2.WinForms.Guna2ComboBox();
            this.BtnSetPlaceholder = new Guna.UI2.WinForms.Guna2Button();
            this.BtnSetText = new Guna.UI2.WinForms.Guna2Button();
            this.BtnOpenAppDir = new Guna.UI2.WinForms.Guna2Button();
            this.BtnSelectGameDir = new Guna.UI2.WinForms.Guna2Button();
            this.BtnSetButton = new Guna.UI2.WinForms.Guna2Button();
            this.BtnSetDetailActive = new Guna.UI2.WinForms.Guna2Button();
            this.BtnSetDetail = new Guna.UI2.WinForms.Guna2Button();
            this.BtnSetTertiary = new Guna.UI2.WinForms.Guna2Button();
            this.BtnSetSecondary = new Guna.UI2.WinForms.Guna2Button();
            this.BtnSetPrimary = new Guna.UI2.WinForms.Guna2Button();
            this.BtnFormShadows = new Guna.UI2.WinForms.Guna2Button();
            this.BtnRoundButtons = new Guna.UI2.WinForms.Guna2Button();
            this.BtnToolTips = new Guna.UI2.WinForms.Guna2Button();
            this.BtnSelectColor = new Guna.UI2.WinForms.Guna2Button();
            this.TxtRoundAmount = new Guna.UI2.WinForms.Guna2TextBox();
            this.TxtColorInput = new Guna.UI2.WinForms.Guna2TextBox();
            this.PanelSEEHeader = new Guna.UI2.WinForms.Guna2Panel();
            this.BtnClose = new Guna.UI2.WinForms.Guna2Button();
            this.BtnMinimize = new Guna.UI2.WinForms.Guna2Button();
            this.BtnResetSettings = new Guna.UI2.WinForms.Guna2Button();
            this.BtnSave = new Guna.UI2.WinForms.Guna2Button();
            this.ImgIcon = new System.Windows.Forms.PictureBox();
            this.LabelTitle = new System.Windows.Forms.Label();
            this.LabelVersion = new System.Windows.Forms.Label();
            this.TxtModDescription = new Guna.UI2.WinForms.Guna2TextBox();
            this.PanelSEEBody.SuspendLayout();
            this.PanelSEEHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelRemember
            // 
            this.LabelRemember.AccessibleName = "LabelRemember";
            this.LabelRemember.AutoSize = true;
            this.LabelRemember.BackColor = System.Drawing.Color.Transparent;
            this.LabelRemember.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::QMM.Properties.Settings.Default, "TextColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.LabelRemember.Font = new System.Drawing.Font("Gadugi", 10F);
            this.LabelRemember.ForeColor = global::QMM.Properties.Settings.Default.TextColor;
            this.LabelRemember.Location = new System.Drawing.Point(666, 358);
            this.LabelRemember.Name = "LabelRemember";
            this.LabelRemember.Size = new System.Drawing.Size(129, 17);
            this.LabelRemember.TabIndex = 22;
            this.LabelRemember.Text = "Remember To Save!";
            this.LabelRemember.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LabelRemember.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoveWindow);
            // 
            // PanelSEEBody
            // 
            this.PanelSEEBody.AccessibleName = "PanelSEEBody";
            this.PanelSEEBody.BackColor = System.Drawing.Color.Transparent;
            this.PanelSEEBody.BorderColor = global::QMM.Properties.Settings.Default.DetailColor;
            this.PanelSEEBody.BorderRadius = global::QMM.Properties.Settings.Default.BorderRadius;
            this.PanelSEEBody.BorderThickness = 1;
            this.PanelSEEBody.Controls.Add(this.TxtModDescription);
            this.PanelSEEBody.Controls.Add(this.BtnOpenSavesDir);
            this.PanelSEEBody.Controls.Add(this.BtnOpenGameDir);
            this.PanelSEEBody.Controls.Add(this.ComboBoxThemes);
            this.PanelSEEBody.Controls.Add(this.BtnSetPlaceholder);
            this.PanelSEEBody.Controls.Add(this.BtnSetText);
            this.PanelSEEBody.Controls.Add(this.BtnOpenAppDir);
            this.PanelSEEBody.Controls.Add(this.BtnSelectGameDir);
            this.PanelSEEBody.Controls.Add(this.BtnSetButton);
            this.PanelSEEBody.Controls.Add(this.BtnSetDetailActive);
            this.PanelSEEBody.Controls.Add(this.BtnSetDetail);
            this.PanelSEEBody.Controls.Add(this.BtnSetTertiary);
            this.PanelSEEBody.Controls.Add(this.BtnSetSecondary);
            this.PanelSEEBody.Controls.Add(this.BtnSetPrimary);
            this.PanelSEEBody.Controls.Add(this.BtnFormShadows);
            this.PanelSEEBody.Controls.Add(this.BtnRoundButtons);
            this.PanelSEEBody.Controls.Add(this.BtnToolTips);
            this.PanelSEEBody.Controls.Add(this.BtnSelectColor);
            this.PanelSEEBody.Controls.Add(this.TxtRoundAmount);
            this.PanelSEEBody.Controls.Add(this.TxtColorInput);
            this.PanelSEEBody.CustomizableEdges.TopLeft = false;
            this.PanelSEEBody.CustomizableEdges.TopRight = false;
            this.PanelSEEBody.DataBindings.Add(new System.Windows.Forms.Binding("BorderRadius", global::QMM.Properties.Settings.Default, "BorderRadius", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.PanelSEEBody.DataBindings.Add(new System.Windows.Forms.Binding("BorderColor", global::QMM.Properties.Settings.Default, "DetailColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.PanelSEEBody.DataBindings.Add(new System.Windows.Forms.Binding("FillColor", global::QMM.Properties.Settings.Default, "BGSecondary", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.PanelSEEBody.FillColor = global::QMM.Properties.Settings.Default.BGSecondary;
            this.PanelSEEBody.Location = new System.Drawing.Point(10, 69);
            this.PanelSEEBody.Name = "PanelSEEBody";
            this.PanelSEEBody.Size = new System.Drawing.Size(780, 287);
            this.PanelSEEBody.TabIndex = 19;
            // 
            // BtnOpenSavesDir
            // 
            this.BtnOpenSavesDir.AccessibleName = "BtnOpenSavesDir";
            this.BtnOpenSavesDir.Animated = true;
            this.BtnOpenSavesDir.BackColor = System.Drawing.Color.Transparent;
            this.BtnOpenSavesDir.BorderColor = global::QMM.Properties.Settings.Default.DetailColor;
            this.BtnOpenSavesDir.BorderThickness = 1;
            this.BtnOpenSavesDir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnOpenSavesDir.DataBindings.Add(new System.Windows.Forms.Binding("BorderColor", global::QMM.Properties.Settings.Default, "DetailColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.BtnOpenSavesDir.DataBindings.Add(new System.Windows.Forms.Binding("FillColor", global::QMM.Properties.Settings.Default, "ButtonColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.BtnOpenSavesDir.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::QMM.Properties.Settings.Default, "TextColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.BtnOpenSavesDir.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnOpenSavesDir.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnOpenSavesDir.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnOpenSavesDir.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnOpenSavesDir.FillColor = global::QMM.Properties.Settings.Default.ButtonColor;
            this.BtnOpenSavesDir.Font = new System.Drawing.Font("Gadugi", 10F);
            this.BtnOpenSavesDir.ForeColor = global::QMM.Properties.Settings.Default.TextColor;
            this.BtnOpenSavesDir.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(167)))), ((int)(((byte)(231)))));
            this.BtnOpenSavesDir.ImageSize = new System.Drawing.Size(16, 16);
            this.BtnOpenSavesDir.Location = new System.Drawing.Point(587, 176);
            this.BtnOpenSavesDir.Name = "BtnOpenSavesDir";
            this.BtnOpenSavesDir.Size = new System.Drawing.Size(182, 45);
            this.BtnOpenSavesDir.TabIndex = 11;
            this.BtnOpenSavesDir.Text = "Open Saves Dir";
            this.BtnOpenSavesDir.Click += new System.EventHandler(this.BtnOpenSavesDir_Click);
            // 
            // BtnOpenGameDir
            // 
            this.BtnOpenGameDir.AccessibleName = "BtnOpenGameDir";
            this.BtnOpenGameDir.Animated = true;
            this.BtnOpenGameDir.BackColor = System.Drawing.Color.Transparent;
            this.BtnOpenGameDir.BorderColor = global::QMM.Properties.Settings.Default.DetailColor;
            this.BtnOpenGameDir.BorderThickness = 1;
            this.BtnOpenGameDir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnOpenGameDir.DataBindings.Add(new System.Windows.Forms.Binding("BorderColor", global::QMM.Properties.Settings.Default, "DetailColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.BtnOpenGameDir.DataBindings.Add(new System.Windows.Forms.Binding("FillColor", global::QMM.Properties.Settings.Default, "ButtonColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.BtnOpenGameDir.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::QMM.Properties.Settings.Default, "TextColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.BtnOpenGameDir.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnOpenGameDir.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnOpenGameDir.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnOpenGameDir.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnOpenGameDir.FillColor = global::QMM.Properties.Settings.Default.ButtonColor;
            this.BtnOpenGameDir.Font = new System.Drawing.Font("Gadugi", 10F);
            this.BtnOpenGameDir.ForeColor = global::QMM.Properties.Settings.Default.TextColor;
            this.BtnOpenGameDir.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(167)))), ((int)(((byte)(231)))));
            this.BtnOpenGameDir.ImageSize = new System.Drawing.Size(16, 16);
            this.BtnOpenGameDir.Location = new System.Drawing.Point(587, 66);
            this.BtnOpenGameDir.Name = "BtnOpenGameDir";
            this.BtnOpenGameDir.Size = new System.Drawing.Size(182, 45);
            this.BtnOpenGameDir.TabIndex = 11;
            this.BtnOpenGameDir.Text = "Open Game Dir";
            this.BtnOpenGameDir.Click += new System.EventHandler(this.BtnOpenGameDir_Click);
            // 
            // ComboBoxThemes
            // 
            this.ComboBoxThemes.AccessibleName = "ComboBoxThemes";
            this.ComboBoxThemes.BackColor = System.Drawing.Color.Transparent;
            this.ComboBoxThemes.BorderColor = global::QMM.Properties.Settings.Default.DetailColor;
            this.ComboBoxThemes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ComboBoxThemes.DataBindings.Add(new System.Windows.Forms.Binding("FillColor", global::QMM.Properties.Settings.Default, "ButtonColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ComboBoxThemes.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::QMM.Properties.Settings.Default, "TextColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ComboBoxThemes.DataBindings.Add(new System.Windows.Forms.Binding("BorderColor", global::QMM.Properties.Settings.Default, "DetailColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ComboBoxThemes.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboBoxThemes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxThemes.FillColor = global::QMM.Properties.Settings.Default.ButtonColor;
            this.ComboBoxThemes.FocusedColor = System.Drawing.Color.Cyan;
            this.ComboBoxThemes.FocusedState.BorderColor = System.Drawing.Color.Cyan;
            this.ComboBoxThemes.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ComboBoxThemes.ForeColor = global::QMM.Properties.Settings.Default.TextColor;
            this.ComboBoxThemes.HoverState.BorderColor = System.Drawing.Color.Red;
            this.ComboBoxThemes.ItemHeight = 39;
            this.ComboBoxThemes.Items.AddRange(new object[] {
            "- Theme Presets -",
            "Simple Dark",
            "Simple Light",
            "GCT v2",
            "Cosmos",
            "Rosé Pine",
            "Rosé Pine Moon"});
            this.ComboBoxThemes.Location = new System.Drawing.Point(395, 11);
            this.ComboBoxThemes.Name = "ComboBoxThemes";
            this.ComboBoxThemes.Size = new System.Drawing.Size(180, 45);
            this.ComboBoxThemes.StartIndex = 0;
            this.ComboBoxThemes.TabIndex = 9;
            this.ComboBoxThemes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ComboBoxThemes.TextOffset = new System.Drawing.Point(13, 0);
            this.ComboBoxThemes.SelectedIndexChanged += new System.EventHandler(this.ComboBoxThemes_SelectedIndexChanged);
            // 
            // BtnSetPlaceholder
            // 
            this.BtnSetPlaceholder.AccessibleName = "BtnSetPlaceholder";
            this.BtnSetPlaceholder.Animated = true;
            this.BtnSetPlaceholder.BackColor = System.Drawing.Color.Transparent;
            this.BtnSetPlaceholder.BorderColor = global::QMM.Properties.Settings.Default.DetailColor;
            this.BtnSetPlaceholder.BorderThickness = 1;
            this.BtnSetPlaceholder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSetPlaceholder.DataBindings.Add(new System.Windows.Forms.Binding("BorderColor", global::QMM.Properties.Settings.Default, "DetailColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.BtnSetPlaceholder.DataBindings.Add(new System.Windows.Forms.Binding("FillColor", global::QMM.Properties.Settings.Default, "ButtonColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.BtnSetPlaceholder.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::QMM.Properties.Settings.Default, "TextColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.BtnSetPlaceholder.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnSetPlaceholder.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnSetPlaceholder.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnSetPlaceholder.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnSetPlaceholder.FillColor = global::QMM.Properties.Settings.Default.ButtonColor;
            this.BtnSetPlaceholder.Font = new System.Drawing.Font("Gadugi", 10F);
            this.BtnSetPlaceholder.ForeColor = global::QMM.Properties.Settings.Default.TextColor;
            this.BtnSetPlaceholder.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(167)))), ((int)(((byte)(231)))));
            this.BtnSetPlaceholder.ImageSize = new System.Drawing.Size(16, 16);
            this.BtnSetPlaceholder.Location = new System.Drawing.Point(203, 231);
            this.BtnSetPlaceholder.Name = "BtnSetPlaceholder";
            this.BtnSetPlaceholder.Size = new System.Drawing.Size(182, 45);
            this.BtnSetPlaceholder.TabIndex = 6;
            this.BtnSetPlaceholder.Text = "Set Placeholder Color";
            this.BtnSetPlaceholder.Click += new System.EventHandler(this.BtnSetPlaceholder_Click);
            // 
            // BtnSetText
            // 
            this.BtnSetText.AccessibleName = "BtnSetText";
            this.BtnSetText.Animated = true;
            this.BtnSetText.BackColor = System.Drawing.Color.Transparent;
            this.BtnSetText.BorderColor = global::QMM.Properties.Settings.Default.DetailColor;
            this.BtnSetText.BorderThickness = 1;
            this.BtnSetText.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSetText.DataBindings.Add(new System.Windows.Forms.Binding("BorderColor", global::QMM.Properties.Settings.Default, "DetailColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.BtnSetText.DataBindings.Add(new System.Windows.Forms.Binding("FillColor", global::QMM.Properties.Settings.Default, "ButtonColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.BtnSetText.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::QMM.Properties.Settings.Default, "TextColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.BtnSetText.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnSetText.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnSetText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnSetText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnSetText.FillColor = global::QMM.Properties.Settings.Default.ButtonColor;
            this.BtnSetText.Font = new System.Drawing.Font("Gadugi", 10F);
            this.BtnSetText.ForeColor = global::QMM.Properties.Settings.Default.TextColor;
            this.BtnSetText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(167)))), ((int)(((byte)(231)))));
            this.BtnSetText.ImageSize = new System.Drawing.Size(16, 16);
            this.BtnSetText.Location = new System.Drawing.Point(11, 231);
            this.BtnSetText.Name = "BtnSetText";
            this.BtnSetText.Size = new System.Drawing.Size(182, 45);
            this.BtnSetText.TabIndex = 6;
            this.BtnSetText.Text = "Set Text Color";
            this.BtnSetText.Click += new System.EventHandler(this.BtnSetText_Click);
            // 
            // BtnOpenAppDir
            // 
            this.BtnOpenAppDir.AccessibleName = "BtnOpenAppDir";
            this.BtnOpenAppDir.Animated = true;
            this.BtnOpenAppDir.BackColor = System.Drawing.Color.Transparent;
            this.BtnOpenAppDir.BorderColor = global::QMM.Properties.Settings.Default.DetailColor;
            this.BtnOpenAppDir.BorderThickness = 1;
            this.BtnOpenAppDir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnOpenAppDir.DataBindings.Add(new System.Windows.Forms.Binding("BorderColor", global::QMM.Properties.Settings.Default, "DetailColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.BtnOpenAppDir.DataBindings.Add(new System.Windows.Forms.Binding("FillColor", global::QMM.Properties.Settings.Default, "ButtonColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.BtnOpenAppDir.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::QMM.Properties.Settings.Default, "TextColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.BtnOpenAppDir.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnOpenAppDir.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnOpenAppDir.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnOpenAppDir.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnOpenAppDir.FillColor = global::QMM.Properties.Settings.Default.ButtonColor;
            this.BtnOpenAppDir.Font = new System.Drawing.Font("Gadugi", 10F);
            this.BtnOpenAppDir.ForeColor = global::QMM.Properties.Settings.Default.TextColor;
            this.BtnOpenAppDir.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(167)))), ((int)(((byte)(231)))));
            this.BtnOpenAppDir.ImageSize = new System.Drawing.Size(16, 16);
            this.BtnOpenAppDir.Location = new System.Drawing.Point(587, 121);
            this.BtnOpenAppDir.Name = "BtnOpenAppDir";
            this.BtnOpenAppDir.Size = new System.Drawing.Size(182, 45);
            this.BtnOpenAppDir.TabIndex = 6;
            this.BtnOpenAppDir.Text = "Open Application Dir";
            this.BtnOpenAppDir.Click += new System.EventHandler(this.OpenAppDir_Click);
            // 
            // BtnSelectGameDir
            // 
            this.BtnSelectGameDir.AccessibleName = "BtnSelectGameDir";
            this.BtnSelectGameDir.Animated = true;
            this.BtnSelectGameDir.BackColor = System.Drawing.Color.Transparent;
            this.BtnSelectGameDir.BorderColor = global::QMM.Properties.Settings.Default.DetailColor;
            this.BtnSelectGameDir.BorderThickness = 1;
            this.BtnSelectGameDir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSelectGameDir.DataBindings.Add(new System.Windows.Forms.Binding("BorderColor", global::QMM.Properties.Settings.Default, "DetailColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.BtnSelectGameDir.DataBindings.Add(new System.Windows.Forms.Binding("FillColor", global::QMM.Properties.Settings.Default, "ButtonColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.BtnSelectGameDir.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::QMM.Properties.Settings.Default, "TextColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.BtnSelectGameDir.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnSelectGameDir.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnSelectGameDir.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnSelectGameDir.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnSelectGameDir.FillColor = global::QMM.Properties.Settings.Default.ButtonColor;
            this.BtnSelectGameDir.Font = new System.Drawing.Font("Gadugi", 10F);
            this.BtnSelectGameDir.ForeColor = global::QMM.Properties.Settings.Default.TextColor;
            this.BtnSelectGameDir.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(167)))), ((int)(((byte)(231)))));
            this.BtnSelectGameDir.ImageSize = new System.Drawing.Size(16, 16);
            this.BtnSelectGameDir.Location = new System.Drawing.Point(587, 11);
            this.BtnSelectGameDir.Name = "BtnSelectGameDir";
            this.BtnSelectGameDir.Size = new System.Drawing.Size(182, 45);
            this.BtnSelectGameDir.TabIndex = 6;
            this.BtnSelectGameDir.Text = "Select Game Dir";
            this.BtnSelectGameDir.Click += new System.EventHandler(this.BtnSelectGameDir_Click);
            // 
            // BtnSetButton
            // 
            this.BtnSetButton.AccessibleName = "BtnSetButton";
            this.BtnSetButton.Animated = true;
            this.BtnSetButton.BackColor = System.Drawing.Color.Transparent;
            this.BtnSetButton.BorderColor = global::QMM.Properties.Settings.Default.DetailColor;
            this.BtnSetButton.BorderRadius = 8;
            this.BtnSetButton.BorderThickness = 1;
            this.BtnSetButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSetButton.DataBindings.Add(new System.Windows.Forms.Binding("BorderColor", global::QMM.Properties.Settings.Default, "DetailColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.BtnSetButton.DataBindings.Add(new System.Windows.Forms.Binding("FillColor", global::QMM.Properties.Settings.Default, "ButtonColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.BtnSetButton.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::QMM.Properties.Settings.Default, "TextColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.BtnSetButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnSetButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnSetButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnSetButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnSetButton.FillColor = global::QMM.Properties.Settings.Default.ButtonColor;
            this.BtnSetButton.Font = new System.Drawing.Font("Gadugi", 10F);
            this.BtnSetButton.ForeColor = global::QMM.Properties.Settings.Default.TextColor;
            this.BtnSetButton.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(167)))), ((int)(((byte)(231)))));
            this.BtnSetButton.ImageSize = new System.Drawing.Size(16, 16);
            this.BtnSetButton.Location = new System.Drawing.Point(203, 176);
            this.BtnSetButton.Name = "BtnSetButton";
            this.BtnSetButton.Size = new System.Drawing.Size(182, 45);
            this.BtnSetButton.TabIndex = 6;
            this.BtnSetButton.Text = "Set Button Color";
            this.BtnSetButton.Click += new System.EventHandler(this.BtnSetButton_Click);
            // 
            // BtnSetDetailActive
            // 
            this.BtnSetDetailActive.AccessibleName = "BtnSetDetailActive";
            this.BtnSetDetailActive.Animated = true;
            this.BtnSetDetailActive.BackColor = System.Drawing.Color.Transparent;
            this.BtnSetDetailActive.BorderColor = global::QMM.Properties.Settings.Default.DetailColor;
            this.BtnSetDetailActive.BorderThickness = 1;
            this.BtnSetDetailActive.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSetDetailActive.DataBindings.Add(new System.Windows.Forms.Binding("BorderColor", global::QMM.Properties.Settings.Default, "DetailColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.BtnSetDetailActive.DataBindings.Add(new System.Windows.Forms.Binding("FillColor", global::QMM.Properties.Settings.Default, "ButtonColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.BtnSetDetailActive.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::QMM.Properties.Settings.Default, "TextColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.BtnSetDetailActive.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnSetDetailActive.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnSetDetailActive.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnSetDetailActive.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnSetDetailActive.FillColor = global::QMM.Properties.Settings.Default.ButtonColor;
            this.BtnSetDetailActive.Font = new System.Drawing.Font("Gadugi", 10F);
            this.BtnSetDetailActive.ForeColor = global::QMM.Properties.Settings.Default.TextColor;
            this.BtnSetDetailActive.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(167)))), ((int)(((byte)(231)))));
            this.BtnSetDetailActive.ImageSize = new System.Drawing.Size(16, 16);
            this.BtnSetDetailActive.Location = new System.Drawing.Point(11, 176);
            this.BtnSetDetailActive.Name = "BtnSetDetailActive";
            this.BtnSetDetailActive.Size = new System.Drawing.Size(182, 45);
            this.BtnSetDetailActive.TabIndex = 6;
            this.BtnSetDetailActive.Text = "Set Detail Active Color";
            this.BtnSetDetailActive.Click += new System.EventHandler(this.BtnSetDetailActive_Click);
            // 
            // BtnSetDetail
            // 
            this.BtnSetDetail.AccessibleName = "BtnSetDetail";
            this.BtnSetDetail.Animated = true;
            this.BtnSetDetail.BackColor = System.Drawing.Color.Transparent;
            this.BtnSetDetail.BorderColor = global::QMM.Properties.Settings.Default.DetailColor;
            this.BtnSetDetail.BorderThickness = 1;
            this.BtnSetDetail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSetDetail.DataBindings.Add(new System.Windows.Forms.Binding("BorderColor", global::QMM.Properties.Settings.Default, "DetailColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.BtnSetDetail.DataBindings.Add(new System.Windows.Forms.Binding("FillColor", global::QMM.Properties.Settings.Default, "ButtonColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.BtnSetDetail.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::QMM.Properties.Settings.Default, "TextColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.BtnSetDetail.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnSetDetail.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnSetDetail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnSetDetail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnSetDetail.FillColor = global::QMM.Properties.Settings.Default.ButtonColor;
            this.BtnSetDetail.Font = new System.Drawing.Font("Gadugi", 10F);
            this.BtnSetDetail.ForeColor = global::QMM.Properties.Settings.Default.TextColor;
            this.BtnSetDetail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(167)))), ((int)(((byte)(231)))));
            this.BtnSetDetail.ImageSize = new System.Drawing.Size(16, 16);
            this.BtnSetDetail.Location = new System.Drawing.Point(203, 121);
            this.BtnSetDetail.Name = "BtnSetDetail";
            this.BtnSetDetail.Size = new System.Drawing.Size(182, 45);
            this.BtnSetDetail.TabIndex = 6;
            this.BtnSetDetail.Text = "Set Detail Color";
            this.BtnSetDetail.Click += new System.EventHandler(this.BtnSetDetail_Click);
            // 
            // BtnSetTertiary
            // 
            this.BtnSetTertiary.AccessibleName = "BtnSetTertiary";
            this.BtnSetTertiary.Animated = true;
            this.BtnSetTertiary.BackColor = System.Drawing.Color.Transparent;
            this.BtnSetTertiary.BorderColor = global::QMM.Properties.Settings.Default.DetailColor;
            this.BtnSetTertiary.BorderThickness = 1;
            this.BtnSetTertiary.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSetTertiary.DataBindings.Add(new System.Windows.Forms.Binding("BorderColor", global::QMM.Properties.Settings.Default, "DetailColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.BtnSetTertiary.DataBindings.Add(new System.Windows.Forms.Binding("FillColor", global::QMM.Properties.Settings.Default, "ButtonColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.BtnSetTertiary.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::QMM.Properties.Settings.Default, "TextColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.BtnSetTertiary.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnSetTertiary.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnSetTertiary.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnSetTertiary.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnSetTertiary.FillColor = global::QMM.Properties.Settings.Default.ButtonColor;
            this.BtnSetTertiary.Font = new System.Drawing.Font("Gadugi", 10F);
            this.BtnSetTertiary.ForeColor = global::QMM.Properties.Settings.Default.TextColor;
            this.BtnSetTertiary.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(167)))), ((int)(((byte)(231)))));
            this.BtnSetTertiary.ImageSize = new System.Drawing.Size(16, 16);
            this.BtnSetTertiary.Location = new System.Drawing.Point(11, 121);
            this.BtnSetTertiary.Name = "BtnSetTertiary";
            this.BtnSetTertiary.Size = new System.Drawing.Size(182, 45);
            this.BtnSetTertiary.TabIndex = 6;
            this.BtnSetTertiary.Text = "Set Tertiary Color";
            this.BtnSetTertiary.Click += new System.EventHandler(this.BtnSetTertiary_Click);
            // 
            // BtnSetSecondary
            // 
            this.BtnSetSecondary.AccessibleName = "BtnSetSecondary";
            this.BtnSetSecondary.Animated = true;
            this.BtnSetSecondary.BackColor = System.Drawing.Color.Transparent;
            this.BtnSetSecondary.BorderColor = global::QMM.Properties.Settings.Default.DetailColor;
            this.BtnSetSecondary.BorderThickness = 1;
            this.BtnSetSecondary.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSetSecondary.DataBindings.Add(new System.Windows.Forms.Binding("BorderColor", global::QMM.Properties.Settings.Default, "DetailColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.BtnSetSecondary.DataBindings.Add(new System.Windows.Forms.Binding("FillColor", global::QMM.Properties.Settings.Default, "ButtonColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.BtnSetSecondary.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::QMM.Properties.Settings.Default, "TextColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.BtnSetSecondary.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnSetSecondary.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnSetSecondary.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnSetSecondary.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnSetSecondary.FillColor = global::QMM.Properties.Settings.Default.ButtonColor;
            this.BtnSetSecondary.Font = new System.Drawing.Font("Gadugi", 10F);
            this.BtnSetSecondary.ForeColor = global::QMM.Properties.Settings.Default.TextColor;
            this.BtnSetSecondary.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(167)))), ((int)(((byte)(231)))));
            this.BtnSetSecondary.ImageSize = new System.Drawing.Size(16, 16);
            this.BtnSetSecondary.Location = new System.Drawing.Point(203, 66);
            this.BtnSetSecondary.Name = "BtnSetSecondary";
            this.BtnSetSecondary.Size = new System.Drawing.Size(182, 45);
            this.BtnSetSecondary.TabIndex = 6;
            this.BtnSetSecondary.Text = "Set Secondary Color";
            this.BtnSetSecondary.Click += new System.EventHandler(this.BtnSetSecondary_Click);
            // 
            // BtnSetPrimary
            // 
            this.BtnSetPrimary.AccessibleName = "BtnSetPrimary";
            this.BtnSetPrimary.Animated = true;
            this.BtnSetPrimary.BackColor = System.Drawing.Color.Transparent;
            this.BtnSetPrimary.BorderColor = global::QMM.Properties.Settings.Default.DetailColor;
            this.BtnSetPrimary.BorderThickness = 1;
            this.BtnSetPrimary.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSetPrimary.DataBindings.Add(new System.Windows.Forms.Binding("BorderColor", global::QMM.Properties.Settings.Default, "DetailColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.BtnSetPrimary.DataBindings.Add(new System.Windows.Forms.Binding("FillColor", global::QMM.Properties.Settings.Default, "ButtonColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.BtnSetPrimary.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::QMM.Properties.Settings.Default, "TextColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.BtnSetPrimary.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnSetPrimary.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnSetPrimary.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnSetPrimary.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnSetPrimary.FillColor = global::QMM.Properties.Settings.Default.ButtonColor;
            this.BtnSetPrimary.Font = new System.Drawing.Font("Gadugi", 10F);
            this.BtnSetPrimary.ForeColor = global::QMM.Properties.Settings.Default.TextColor;
            this.BtnSetPrimary.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(167)))), ((int)(((byte)(231)))));
            this.BtnSetPrimary.ImageSize = new System.Drawing.Size(16, 16);
            this.BtnSetPrimary.Location = new System.Drawing.Point(11, 66);
            this.BtnSetPrimary.Name = "BtnSetPrimary";
            this.BtnSetPrimary.Size = new System.Drawing.Size(182, 45);
            this.BtnSetPrimary.TabIndex = 6;
            this.BtnSetPrimary.Text = "Set Primary Color";
            this.BtnSetPrimary.Click += new System.EventHandler(this.BtnSetPrimary_Click);
            // 
            // BtnFormShadows
            // 
            this.BtnFormShadows.AccessibleName = "BtnFormShadows";
            this.BtnFormShadows.Animated = true;
            this.BtnFormShadows.BackColor = System.Drawing.Color.Transparent;
            this.BtnFormShadows.BorderColor = global::QMM.Properties.Settings.Default.DetailColor;
            this.BtnFormShadows.BorderThickness = 1;
            this.BtnFormShadows.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.BtnFormShadows.Checked = true;
            this.BtnFormShadows.CheckedState.BorderColor = System.Drawing.Color.Transparent;
            this.BtnFormShadows.CheckedState.Font = new System.Drawing.Font("Gadugi", 10F);
            this.BtnFormShadows.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnFormShadows.DataBindings.Add(new System.Windows.Forms.Binding("BorderColor", global::QMM.Properties.Settings.Default, "DetailColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.BtnFormShadows.DataBindings.Add(new System.Windows.Forms.Binding("FillColor", global::QMM.Properties.Settings.Default, "ButtonColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.BtnFormShadows.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::QMM.Properties.Settings.Default, "TextColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.BtnFormShadows.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnFormShadows.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnFormShadows.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnFormShadows.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnFormShadows.FillColor = global::QMM.Properties.Settings.Default.ButtonColor;
            this.BtnFormShadows.Font = new System.Drawing.Font("Gadugi", 10F);
            this.BtnFormShadows.ForeColor = global::QMM.Properties.Settings.Default.TextColor;
            this.BtnFormShadows.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(167)))), ((int)(((byte)(231)))));
            this.BtnFormShadows.ImageSize = new System.Drawing.Size(16, 16);
            this.BtnFormShadows.Location = new System.Drawing.Point(395, 176);
            this.BtnFormShadows.Name = "BtnFormShadows";
            this.BtnFormShadows.Size = new System.Drawing.Size(182, 45);
            this.BtnFormShadows.TabIndex = 8;
            this.BtnFormShadows.Text = "Form Shadows";
            this.BtnFormShadows.Click += new System.EventHandler(this.BtnFormShadows_Click);
            this.BtnFormShadows.MouseEnter += new System.EventHandler(this.BtnFormShadows_MouseHover);
            // 
            // BtnRoundButtons
            // 
            this.BtnRoundButtons.AccessibleName = "BtnRoundButtons";
            this.BtnRoundButtons.Animated = true;
            this.BtnRoundButtons.BackColor = System.Drawing.Color.Transparent;
            this.BtnRoundButtons.BorderColor = global::QMM.Properties.Settings.Default.DetailColor;
            this.BtnRoundButtons.BorderThickness = 1;
            this.BtnRoundButtons.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.BtnRoundButtons.Checked = true;
            this.BtnRoundButtons.CheckedState.BorderColor = System.Drawing.Color.Transparent;
            this.BtnRoundButtons.CheckedState.Font = new System.Drawing.Font("Gadugi", 10F);
            this.BtnRoundButtons.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRoundButtons.DataBindings.Add(new System.Windows.Forms.Binding("BorderColor", global::QMM.Properties.Settings.Default, "DetailColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.BtnRoundButtons.DataBindings.Add(new System.Windows.Forms.Binding("FillColor", global::QMM.Properties.Settings.Default, "ButtonColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.BtnRoundButtons.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::QMM.Properties.Settings.Default, "TextColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.BtnRoundButtons.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnRoundButtons.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnRoundButtons.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnRoundButtons.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnRoundButtons.FillColor = global::QMM.Properties.Settings.Default.ButtonColor;
            this.BtnRoundButtons.Font = new System.Drawing.Font("Gadugi", 10F);
            this.BtnRoundButtons.ForeColor = global::QMM.Properties.Settings.Default.TextColor;
            this.BtnRoundButtons.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(167)))), ((int)(((byte)(231)))));
            this.BtnRoundButtons.ImageSize = new System.Drawing.Size(16, 16);
            this.BtnRoundButtons.Location = new System.Drawing.Point(395, 121);
            this.BtnRoundButtons.Name = "BtnRoundButtons";
            this.BtnRoundButtons.Size = new System.Drawing.Size(182, 45);
            this.BtnRoundButtons.TabIndex = 8;
            this.BtnRoundButtons.Text = "Round Controls";
            this.BtnRoundButtons.Click += new System.EventHandler(this.BtnRoundControls_Click);
            this.BtnRoundButtons.MouseEnter += new System.EventHandler(this.BtnRoundControls_MouseHover);
            // 
            // BtnToolTips
            // 
            this.BtnToolTips.AccessibleName = "BtnToolTips";
            this.BtnToolTips.Animated = true;
            this.BtnToolTips.BackColor = System.Drawing.Color.Transparent;
            this.BtnToolTips.BorderColor = global::QMM.Properties.Settings.Default.DetailColor;
            this.BtnToolTips.BorderThickness = 1;
            this.BtnToolTips.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.BtnToolTips.CheckedState.BorderColor = System.Drawing.Color.Transparent;
            this.BtnToolTips.CheckedState.Font = new System.Drawing.Font("Gadugi", 10F);
            this.BtnToolTips.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnToolTips.DataBindings.Add(new System.Windows.Forms.Binding("BorderColor", global::QMM.Properties.Settings.Default, "DetailColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.BtnToolTips.DataBindings.Add(new System.Windows.Forms.Binding("FillColor", global::QMM.Properties.Settings.Default, "ButtonColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.BtnToolTips.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::QMM.Properties.Settings.Default, "TextColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.BtnToolTips.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnToolTips.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnToolTips.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnToolTips.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnToolTips.FillColor = global::QMM.Properties.Settings.Default.ButtonColor;
            this.BtnToolTips.Font = new System.Drawing.Font("Gadugi", 10F);
            this.BtnToolTips.ForeColor = global::QMM.Properties.Settings.Default.TextColor;
            this.BtnToolTips.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(167)))), ((int)(((byte)(231)))));
            this.BtnToolTips.ImageSize = new System.Drawing.Size(16, 16);
            this.BtnToolTips.Location = new System.Drawing.Point(395, 231);
            this.BtnToolTips.Name = "BtnToolTips";
            this.BtnToolTips.Size = new System.Drawing.Size(182, 45);
            this.BtnToolTips.TabIndex = 8;
            this.BtnToolTips.Text = " Tool Tips";
            this.BtnToolTips.Click += new System.EventHandler(this.BtnToolTips_Click);
            this.BtnToolTips.MouseEnter += new System.EventHandler(this.BtnToolTips_MouseHover);
            // 
            // BtnSelectColor
            // 
            this.BtnSelectColor.AccessibleName = "BtnSelectColor";
            this.BtnSelectColor.Animated = true;
            this.BtnSelectColor.BackColor = System.Drawing.Color.Transparent;
            this.BtnSelectColor.BorderColor = global::QMM.Properties.Settings.Default.DetailColor;
            this.BtnSelectColor.BorderThickness = 1;
            this.BtnSelectColor.CheckedState.Font = new System.Drawing.Font("Gadugi", 10F, System.Drawing.FontStyle.Bold);
            this.BtnSelectColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSelectColor.DataBindings.Add(new System.Windows.Forms.Binding("BorderColor", global::QMM.Properties.Settings.Default, "DetailColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.BtnSelectColor.DataBindings.Add(new System.Windows.Forms.Binding("FillColor", global::QMM.Properties.Settings.Default, "ButtonColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.BtnSelectColor.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::QMM.Properties.Settings.Default, "TextColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.BtnSelectColor.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnSelectColor.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnSelectColor.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnSelectColor.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnSelectColor.FillColor = global::QMM.Properties.Settings.Default.ButtonColor;
            this.BtnSelectColor.Font = new System.Drawing.Font("Gadugi", 10F);
            this.BtnSelectColor.ForeColor = global::QMM.Properties.Settings.Default.TextColor;
            this.BtnSelectColor.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(167)))), ((int)(((byte)(231)))));
            this.BtnSelectColor.ImageSize = new System.Drawing.Size(16, 16);
            this.BtnSelectColor.Location = new System.Drawing.Point(203, 11);
            this.BtnSelectColor.Name = "BtnSelectColor";
            this.BtnSelectColor.Size = new System.Drawing.Size(182, 45);
            this.BtnSelectColor.TabIndex = 8;
            this.BtnSelectColor.Text = "Select Color";
            this.BtnSelectColor.Click += new System.EventHandler(this.BtnColor_Click);
            // 
            // TxtRoundAmount
            // 
            this.TxtRoundAmount.AccessibleName = "TxtRoundAmount";
            this.TxtRoundAmount.Animated = true;
            this.TxtRoundAmount.BackColor = System.Drawing.Color.Transparent;
            this.TxtRoundAmount.BorderColor = global::QMM.Properties.Settings.Default.DetailColor;
            this.TxtRoundAmount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtRoundAmount.DataBindings.Add(new System.Windows.Forms.Binding("BorderColor", global::QMM.Properties.Settings.Default, "DetailColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.TxtRoundAmount.DataBindings.Add(new System.Windows.Forms.Binding("FillColor", global::QMM.Properties.Settings.Default, "ButtonColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.TxtRoundAmount.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::QMM.Properties.Settings.Default, "TextColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.TxtRoundAmount.DataBindings.Add(new System.Windows.Forms.Binding("PlaceholderForeColor", global::QMM.Properties.Settings.Default, "PlaceholderColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.TxtRoundAmount.DefaultText = "";
            this.TxtRoundAmount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtRoundAmount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtRoundAmount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtRoundAmount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtRoundAmount.FillColor = global::QMM.Properties.Settings.Default.ButtonColor;
            this.TxtRoundAmount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(167)))), ((int)(((byte)(231)))));
            this.TxtRoundAmount.Font = new System.Drawing.Font("Gadugi", 10F);
            this.TxtRoundAmount.ForeColor = global::QMM.Properties.Settings.Default.TextColor;
            this.TxtRoundAmount.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(167)))), ((int)(((byte)(231)))));
            this.TxtRoundAmount.Location = new System.Drawing.Point(395, 68);
            this.TxtRoundAmount.MaxLength = 255;
            this.TxtRoundAmount.Name = "TxtRoundAmount";
            this.TxtRoundAmount.PasswordChar = '\0';
            this.TxtRoundAmount.PlaceholderForeColor = global::QMM.Properties.Settings.Default.PlaceholderColor;
            this.TxtRoundAmount.PlaceholderText = "Rounded Amount";
            this.TxtRoundAmount.SelectedText = "";
            this.TxtRoundAmount.Size = new System.Drawing.Size(182, 41);
            this.TxtRoundAmount.TabIndex = 4;
            this.TxtRoundAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtRoundAmount.TextChanged += new System.EventHandler(this.TxtRoundAmount_TextChanged);
            this.TxtRoundAmount.MouseEnter += new System.EventHandler(this.TxtRoundAmount_MouseHover);
            // 
            // TxtColorInput
            // 
            this.TxtColorInput.AccessibleName = "TxtColorInput";
            this.TxtColorInput.Animated = true;
            this.TxtColorInput.BackColor = System.Drawing.Color.Transparent;
            this.TxtColorInput.BorderColor = global::QMM.Properties.Settings.Default.DetailColor;
            this.TxtColorInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtColorInput.DataBindings.Add(new System.Windows.Forms.Binding("BorderColor", global::QMM.Properties.Settings.Default, "DetailColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.TxtColorInput.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::QMM.Properties.Settings.Default, "TextColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.TxtColorInput.DataBindings.Add(new System.Windows.Forms.Binding("FillColor", global::QMM.Properties.Settings.Default, "ButtonColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.TxtColorInput.DataBindings.Add(new System.Windows.Forms.Binding("PlaceholderForeColor", global::QMM.Properties.Settings.Default, "PlaceholderColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.TxtColorInput.DefaultText = "";
            this.TxtColorInput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtColorInput.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtColorInput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtColorInput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtColorInput.FillColor = global::QMM.Properties.Settings.Default.ButtonColor;
            this.TxtColorInput.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(167)))), ((int)(((byte)(231)))));
            this.TxtColorInput.Font = new System.Drawing.Font("Gadugi", 10F);
            this.TxtColorInput.ForeColor = global::QMM.Properties.Settings.Default.TextColor;
            this.TxtColorInput.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(167)))), ((int)(((byte)(231)))));
            this.TxtColorInput.Location = new System.Drawing.Point(11, 13);
            this.TxtColorInput.MaxLength = 255;
            this.TxtColorInput.Name = "TxtColorInput";
            this.TxtColorInput.PasswordChar = '\0';
            this.TxtColorInput.PlaceholderForeColor = global::QMM.Properties.Settings.Default.PlaceholderColor;
            this.TxtColorInput.PlaceholderText = "Color Input";
            this.TxtColorInput.SelectedText = "";
            this.TxtColorInput.Size = new System.Drawing.Size(182, 41);
            this.TxtColorInput.TabIndex = 4;
            this.TxtColorInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PanelSEEHeader
            // 
            this.PanelSEEHeader.AccessibleName = "PanelSEEHeader";
            this.PanelSEEHeader.BackColor = System.Drawing.Color.Transparent;
            this.PanelSEEHeader.BorderColor = global::QMM.Properties.Settings.Default.DetailColor;
            this.PanelSEEHeader.BorderRadius = global::QMM.Properties.Settings.Default.BorderRadius;
            this.PanelSEEHeader.BorderThickness = 1;
            this.PanelSEEHeader.Controls.Add(this.BtnClose);
            this.PanelSEEHeader.Controls.Add(this.BtnMinimize);
            this.PanelSEEHeader.Controls.Add(this.BtnResetSettings);
            this.PanelSEEHeader.Controls.Add(this.BtnSave);
            this.PanelSEEHeader.Controls.Add(this.ImgIcon);
            this.PanelSEEHeader.Controls.Add(this.LabelTitle);
            this.PanelSEEHeader.CustomizableEdges.BottomLeft = false;
            this.PanelSEEHeader.CustomizableEdges.BottomRight = false;
            this.PanelSEEHeader.DataBindings.Add(new System.Windows.Forms.Binding("BorderRadius", global::QMM.Properties.Settings.Default, "BorderRadius", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.PanelSEEHeader.DataBindings.Add(new System.Windows.Forms.Binding("BorderColor", global::QMM.Properties.Settings.Default, "DetailColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.PanelSEEHeader.DataBindings.Add(new System.Windows.Forms.Binding("FillColor", global::QMM.Properties.Settings.Default, "BGTertiary", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.PanelSEEHeader.FillColor = global::QMM.Properties.Settings.Default.BGTertiary;
            this.PanelSEEHeader.Location = new System.Drawing.Point(10, 10);
            this.PanelSEEHeader.Name = "PanelSEEHeader";
            this.PanelSEEHeader.Size = new System.Drawing.Size(780, 60);
            this.PanelSEEHeader.TabIndex = 20;
            this.PanelSEEHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoveWindow);
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
            this.BtnClose.Location = new System.Drawing.Point(735, 15);
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
            this.BtnMinimize.BackColor = System.Drawing.Color.Transparent;
            this.BtnMinimize.BorderColor = System.Drawing.Color.White;
            this.BtnMinimize.BorderThickness = 1;
            this.BtnMinimize.CheckedState.CustomBorderColor = System.Drawing.Color.White;
            this.BtnMinimize.CheckedState.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnMinimize.DataBindings.Add(new System.Windows.Forms.Binding("FillColor", global::QMM.Properties.Settings.Default, "ButtonColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.BtnMinimize.FillColor = global::QMM.Properties.Settings.Default.ButtonColor;
            this.BtnMinimize.Font = new System.Drawing.Font("Azonix", 11F);
            this.BtnMinimize.ForeColor = System.Drawing.Color.White;
            this.BtnMinimize.HoverState.CustomBorderColor = System.Drawing.Color.White;
            this.BtnMinimize.Location = new System.Drawing.Point(690, 15);
            this.BtnMinimize.Name = "BtnMinimize";
            this.BtnMinimize.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(36)))));
            this.BtnMinimize.Size = new System.Drawing.Size(30, 30);
            this.BtnMinimize.TabIndex = 4;
            this.BtnMinimize.Text = "-";
            this.BtnMinimize.Click += new System.EventHandler(this.BtnMinimize_Click);
            // 
            // BtnResetSettings
            // 
            this.BtnResetSettings.AccessibleName = "BtnResetSettings";
            this.BtnResetSettings.Animated = true;
            this.BtnResetSettings.BackColor = System.Drawing.Color.Transparent;
            this.BtnResetSettings.BorderColor = System.Drawing.Color.White;
            this.BtnResetSettings.BorderThickness = 1;
            this.BtnResetSettings.CheckedState.CustomBorderColor = System.Drawing.Color.White;
            this.BtnResetSettings.CheckedState.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnResetSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnResetSettings.DataBindings.Add(new System.Windows.Forms.Binding("FillColor", global::QMM.Properties.Settings.Default, "ButtonColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.BtnResetSettings.FillColor = global::QMM.Properties.Settings.Default.ButtonColor;
            this.BtnResetSettings.Font = new System.Drawing.Font("Azonix", 11F);
            this.BtnResetSettings.ForeColor = System.Drawing.Color.White;
            this.BtnResetSettings.HoverState.CustomBorderColor = System.Drawing.Color.White;
            this.BtnResetSettings.Image = ((System.Drawing.Image)(resources.GetObject("BtnResetSettings.Image")));
            this.BtnResetSettings.Location = new System.Drawing.Point(600, 15);
            this.BtnResetSettings.Name = "BtnResetSettings";
            this.BtnResetSettings.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(36)))));
            this.BtnResetSettings.Size = new System.Drawing.Size(30, 30);
            this.BtnResetSettings.TabIndex = 5;
            this.BtnResetSettings.Click += new System.EventHandler(this.BtnResetSettings_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.AccessibleName = "BtnSave";
            this.BtnSave.Animated = true;
            this.BtnSave.BackColor = System.Drawing.Color.Transparent;
            this.BtnSave.BorderColor = System.Drawing.Color.White;
            this.BtnSave.BorderThickness = 1;
            this.BtnSave.CheckedState.CustomBorderColor = System.Drawing.Color.White;
            this.BtnSave.CheckedState.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSave.DataBindings.Add(new System.Windows.Forms.Binding("FillColor", global::QMM.Properties.Settings.Default, "ButtonColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.BtnSave.FillColor = global::QMM.Properties.Settings.Default.ButtonColor;
            this.BtnSave.Font = new System.Drawing.Font("Azonix", 11F);
            this.BtnSave.ForeColor = System.Drawing.Color.White;
            this.BtnSave.HoverState.CustomBorderColor = System.Drawing.Color.White;
            this.BtnSave.Image = ((System.Drawing.Image)(resources.GetObject("BtnSave.Image")));
            this.BtnSave.ImageSize = new System.Drawing.Size(16, 16);
            this.BtnSave.Location = new System.Drawing.Point(645, 15);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(36)))));
            this.BtnSave.Size = new System.Drawing.Size(30, 30);
            this.BtnSave.TabIndex = 5;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            this.BtnSave.MouseEnter += new System.EventHandler(this.BtnSave_MouseHover);
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
            this.LabelTitle.Size = new System.Drawing.Size(351, 36);
            this.LabelTitle.TabIndex = 9;
            this.LabelTitle.Text = "User Settings";
            this.LabelTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoveWindow);
            // 
            // LabelVersion
            // 
            this.LabelVersion.AccessibleName = "LabelVersion";
            this.LabelVersion.BackColor = System.Drawing.Color.Transparent;
            this.LabelVersion.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::QMM.Properties.Settings.Default, "TextColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.LabelVersion.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::QMM.Properties.Settings.Default, "Version", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.LabelVersion.Font = new System.Drawing.Font("Gadugi", 10F);
            this.LabelVersion.ForeColor = global::QMM.Properties.Settings.Default.TextColor;
            this.LabelVersion.Location = new System.Drawing.Point(8, 358);
            this.LabelVersion.Name = "LabelVersion";
            this.LabelVersion.Size = new System.Drawing.Size(179, 17);
            this.LabelVersion.TabIndex = 21;
            this.LabelVersion.Text = global::QMM.Properties.Settings.Default.Version;
            this.LabelVersion.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoveWindow);
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
            this.TxtModDescription.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::QMM.Properties.Settings.Default, "TextColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.TxtModDescription.DataBindings.Add(new System.Windows.Forms.Binding("PlaceholderForeColor", global::QMM.Properties.Settings.Default, "PlaceholderColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.TxtModDescription.DataBindings.Add(new System.Windows.Forms.Binding("FillColor", global::QMM.Properties.Settings.Default, "ButtonColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.TxtModDescription.DefaultText = "May require a restart!";
            this.TxtModDescription.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtModDescription.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtModDescription.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtModDescription.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtModDescription.FillColor = global::QMM.Properties.Settings.Default.ButtonColor;
            this.TxtModDescription.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(86)))));
            this.TxtModDescription.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.TxtModDescription.ForeColor = global::QMM.Properties.Settings.Default.TextColor;
            this.TxtModDescription.HideSelection = false;
            this.TxtModDescription.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(86)))));
            this.TxtModDescription.Location = new System.Drawing.Point(587, 234);
            this.TxtModDescription.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtModDescription.MaxLength = 255;
            this.TxtModDescription.Multiline = true;
            this.TxtModDescription.Name = "TxtModDescription";
            this.TxtModDescription.PasswordChar = '\0';
            this.TxtModDescription.PlaceholderForeColor = global::QMM.Properties.Settings.Default.PlaceholderColor;
            this.TxtModDescription.PlaceholderText = "";
            this.TxtModDescription.ReadOnly = true;
            this.TxtModDescription.SelectedText = "";
            this.TxtModDescription.Size = new System.Drawing.Size(182, 39);
            this.TxtModDescription.TabIndex = 16;
            this.TxtModDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // UserSettings
            // 
            this.AccessibleName = "UserSettings";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = global::QMM.Properties.Settings.Default.BGPrimary;
            this.ClientSize = new System.Drawing.Size(800, 378);
            this.Controls.Add(this.LabelRemember);
            this.Controls.Add(this.PanelSEEBody);
            this.Controls.Add(this.PanelSEEHeader);
            this.Controls.Add(this.LabelVersion);
            this.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::QMM.Properties.Settings.Default, "BGPrimary", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UserSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QMM | User Settings";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoveWindow);
            this.PanelSEEBody.ResumeLayout(false);
            this.PanelSEEHeader.ResumeLayout(false);
            this.PanelSEEHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelRemember;
        private Guna.UI2.WinForms.Guna2Panel PanelSEEBody;
        private Guna.UI2.WinForms.Guna2ComboBox ComboBoxThemes;
        private Guna.UI2.WinForms.Guna2Button BtnSetPlaceholder;
        private Guna.UI2.WinForms.Guna2Button BtnSetText;
        private Guna.UI2.WinForms.Guna2Button BtnSelectGameDir;
        private Guna.UI2.WinForms.Guna2Button BtnSetButton;
        private Guna.UI2.WinForms.Guna2Button BtnSetDetailActive;
        private Guna.UI2.WinForms.Guna2Button BtnSetDetail;
        private Guna.UI2.WinForms.Guna2Button BtnSetTertiary;
        private Guna.UI2.WinForms.Guna2Button BtnSetSecondary;
        private Guna.UI2.WinForms.Guna2Button BtnSetPrimary;
        private Guna.UI2.WinForms.Guna2Button BtnFormShadows;
        private Guna.UI2.WinForms.Guna2Button BtnRoundButtons;
        private Guna.UI2.WinForms.Guna2Button BtnToolTips;
        private Guna.UI2.WinForms.Guna2Button BtnSelectColor;
        private Guna.UI2.WinForms.Guna2TextBox TxtRoundAmount;
        private Guna.UI2.WinForms.Guna2TextBox TxtColorInput;
        private Guna.UI2.WinForms.Guna2Panel PanelSEEHeader;
        private Guna.UI2.WinForms.Guna2Button BtnClose;
        private Guna.UI2.WinForms.Guna2Button BtnMinimize;
        private Guna.UI2.WinForms.Guna2Button BtnResetSettings;
        private Guna.UI2.WinForms.Guna2Button BtnSave;
        private System.Windows.Forms.PictureBox ImgIcon;
        private System.Windows.Forms.Label LabelTitle;
        private System.Windows.Forms.Label LabelVersion;
        private Guna.UI2.WinForms.Guna2Button BtnOpenAppDir;
        private Guna.UI2.WinForms.Guna2Button BtnOpenGameDir;
        private Guna.UI2.WinForms.Guna2Button BtnOpenSavesDir;
        private Guna.UI2.WinForms.Guna2TextBox TxtModDescription;
    }
}