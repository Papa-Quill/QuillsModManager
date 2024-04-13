namespace QMM.Util
{
    partial class FColorSelector
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FColorSelector));
            this.LabelDevelopment = new System.Windows.Forms.Label();
            this.PanelBody = new Guna.UI2.WinForms.Guna2Panel();
            this.PanelOutlineBlock6 = new Guna.UI2.WinForms.Guna2Panel();
            this.BtnColorPicker = new Guna.UI2.WinForms.Guna2Button();
            this.PanelOutlineBlock5 = new Guna.UI2.WinForms.Guna2Panel();
            this.PanelOutlineBlock4 = new Guna.UI2.WinForms.Guna2Panel();
            this.TxtHexColor = new Guna.UI2.WinForms.Guna2TextBox();
            this.PanelOutlineBlock3 = new Guna.UI2.WinForms.Guna2Panel();
            this.LabelBlue = new System.Windows.Forms.Label();
            this.PanelOutlineBlock2 = new Guna.UI2.WinForms.Guna2Panel();
            this.PanelOutlineBlock1 = new Guna.UI2.WinForms.Guna2Panel();
            this.LabelGreen = new System.Windows.Forms.Label();
            this.LabelRed = new System.Windows.Forms.Label();
            this.SliderBlue = new System.Windows.Forms.TrackBar();
            this.SliderGreen = new System.Windows.Forms.TrackBar();
            this.SliderRed = new System.Windows.Forms.TrackBar();
            this.TxtRGBColor = new Guna.UI2.WinForms.Guna2TextBox();
            this.PanelHeader = new Guna.UI2.WinForms.Guna2Panel();
            this.BtnClose = new Guna.UI2.WinForms.Guna2Button();
            this.BtnFinishSelection = new Guna.UI2.WinForms.Guna2Button();
            this.ImgIcon = new System.Windows.Forms.PictureBox();
            this.LabelTitle = new System.Windows.Forms.Label();
            this.LabelVersion = new System.Windows.Forms.Label();
            this.PanelColorPreview = new Guna.UI2.WinForms.Guna2Button();
            this.PanelBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SliderBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SliderGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SliderRed)).BeginInit();
            this.PanelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelDevelopment
            // 
            this.LabelDevelopment.AccessibleName = "LabelDevelopment";
            this.LabelDevelopment.AutoSize = true;
            this.LabelDevelopment.BackColor = System.Drawing.Color.Transparent;
            this.LabelDevelopment.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::QMM.Properties.Settings.Default, "TextColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.LabelDevelopment.Font = new System.Drawing.Font("Gadugi", 10F);
            this.LabelDevelopment.ForeColor = global::QMM.Properties.Settings.Default.TextColor;
            this.LabelDevelopment.Location = new System.Drawing.Point(289, 344);
            this.LabelDevelopment.Name = "LabelDevelopment";
            this.LabelDevelopment.Size = new System.Drawing.Size(143, 17);
            this.LabelDevelopment.TabIndex = 22;
            this.LabelDevelopment.Text = "Cosmos Development";
            this.LabelDevelopment.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LabelDevelopment.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoveWindow);
            // 
            // PanelBody
            // 
            this.PanelBody.AccessibleName = "PanelBody";
            this.PanelBody.BackColor = System.Drawing.Color.Transparent;
            this.PanelBody.BorderColor = global::QMM.Properties.Settings.Default.DetailColor;
            this.PanelBody.BorderRadius = global::QMM.Properties.Settings.Default.BorderRadius;
            this.PanelBody.BorderThickness = 1;
            this.PanelBody.Controls.Add(this.PanelColorPreview);
            this.PanelBody.Controls.Add(this.PanelOutlineBlock6);
            this.PanelBody.Controls.Add(this.BtnColorPicker);
            this.PanelBody.Controls.Add(this.PanelOutlineBlock5);
            this.PanelBody.Controls.Add(this.PanelOutlineBlock4);
            this.PanelBody.Controls.Add(this.TxtHexColor);
            this.PanelBody.Controls.Add(this.PanelOutlineBlock3);
            this.PanelBody.Controls.Add(this.LabelBlue);
            this.PanelBody.Controls.Add(this.PanelOutlineBlock2);
            this.PanelBody.Controls.Add(this.PanelOutlineBlock1);
            this.PanelBody.Controls.Add(this.LabelGreen);
            this.PanelBody.Controls.Add(this.LabelRed);
            this.PanelBody.Controls.Add(this.SliderBlue);
            this.PanelBody.Controls.Add(this.SliderGreen);
            this.PanelBody.Controls.Add(this.SliderRed);
            this.PanelBody.Controls.Add(this.TxtRGBColor);
            this.PanelBody.CustomizableEdges.TopLeft = false;
            this.PanelBody.CustomizableEdges.TopRight = false;
            this.PanelBody.DataBindings.Add(new System.Windows.Forms.Binding("BorderColor", global::QMM.Properties.Settings.Default, "DetailColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.PanelBody.DataBindings.Add(new System.Windows.Forms.Binding("BorderRadius", global::QMM.Properties.Settings.Default, "BorderRadius", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.PanelBody.DataBindings.Add(new System.Windows.Forms.Binding("FillColor", global::QMM.Properties.Settings.Default, "BGSecondary", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.PanelBody.FillColor = global::QMM.Properties.Settings.Default.BGSecondary;
            this.PanelBody.Location = new System.Drawing.Point(10, 69);
            this.PanelBody.Name = "PanelBody";
            this.PanelBody.Size = new System.Drawing.Size(417, 273);
            this.PanelBody.TabIndex = 19;
            // 
            // PanelOutlineBlock6
            // 
            this.PanelOutlineBlock6.AccessibleName = "PanelOutlineBlock6";
            this.PanelOutlineBlock6.BackColor = global::QMM.Properties.Settings.Default.BGSecondary;
            this.PanelOutlineBlock6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(167)))), ((int)(((byte)(231)))));
            this.PanelOutlineBlock6.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::QMM.Properties.Settings.Default, "BGSecondary", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.PanelOutlineBlock6.Location = new System.Drawing.Point(97, 7);
            this.PanelOutlineBlock6.Name = "PanelOutlineBlock6";
            this.PanelOutlineBlock6.Size = new System.Drawing.Size(229, 10);
            this.PanelOutlineBlock6.TabIndex = 15;
            // 
            // BtnColorPicker
            // 
            this.BtnColorPicker.AccessibleName = "BtnColorPicker";
            this.BtnColorPicker.Animated = true;
            this.BtnColorPicker.BorderColor = System.Drawing.Color.White;
            this.BtnColorPicker.BorderThickness = 1;
            this.BtnColorPicker.CheckedState.CustomBorderColor = System.Drawing.Color.White;
            this.BtnColorPicker.CheckedState.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnColorPicker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnColorPicker.DataBindings.Add(new System.Windows.Forms.Binding("FillColor", global::QMM.Properties.Settings.Default, "ButtonColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.BtnColorPicker.FillColor = global::QMM.Properties.Settings.Default.ButtonColor;
            this.BtnColorPicker.Font = new System.Drawing.Font("Azonix", 11F);
            this.BtnColorPicker.ForeColor = System.Drawing.Color.White;
            this.BtnColorPicker.HoverState.CustomBorderColor = System.Drawing.Color.White;
            this.BtnColorPicker.Image = ((System.Drawing.Image)(resources.GetObject("BtnColorPicker.Image")));
            this.BtnColorPicker.Location = new System.Drawing.Point(77, 226);
            this.BtnColorPicker.Name = "BtnColorPicker";
            this.BtnColorPicker.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(36)))));
            this.BtnColorPicker.Size = new System.Drawing.Size(30, 30);
            this.BtnColorPicker.TabIndex = 4;
            this.BtnColorPicker.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BtnColorPicker_MouseDown);
            this.BtnColorPicker.MouseHover += new System.EventHandler(this.BtnColorPicker_MouseHover);
            this.BtnColorPicker.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BtnColorPicker_MouseUp);
            // 
            // PanelOutlineBlock5
            // 
            this.PanelOutlineBlock5.AccessibleName = "PanelOutlineBlock5";
            this.PanelOutlineBlock5.BackColor = global::QMM.Properties.Settings.Default.BGSecondary;
            this.PanelOutlineBlock5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(167)))), ((int)(((byte)(231)))));
            this.PanelOutlineBlock5.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::QMM.Properties.Settings.Default, "BGSecondary", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.PanelOutlineBlock5.Location = new System.Drawing.Point(97, 40);
            this.PanelOutlineBlock5.Name = "PanelOutlineBlock5";
            this.PanelOutlineBlock5.Size = new System.Drawing.Size(229, 10);
            this.PanelOutlineBlock5.TabIndex = 15;
            // 
            // PanelOutlineBlock4
            // 
            this.PanelOutlineBlock4.AccessibleName = "PanelOutlineBlock4";
            this.PanelOutlineBlock4.BackColor = global::QMM.Properties.Settings.Default.BGSecondary;
            this.PanelOutlineBlock4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(167)))), ((int)(((byte)(231)))));
            this.PanelOutlineBlock4.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::QMM.Properties.Settings.Default, "BGSecondary", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.PanelOutlineBlock4.Location = new System.Drawing.Point(97, 74);
            this.PanelOutlineBlock4.Name = "PanelOutlineBlock4";
            this.PanelOutlineBlock4.Size = new System.Drawing.Size(229, 10);
            this.PanelOutlineBlock4.TabIndex = 15;
            // 
            // TxtHexColor
            // 
            this.TxtHexColor.AccessibleName = "TxtHexColor";
            this.TxtHexColor.Animated = true;
            this.TxtHexColor.BackColor = System.Drawing.Color.Transparent;
            this.TxtHexColor.BorderColor = global::QMM.Properties.Settings.Default.DetailColor;
            this.TxtHexColor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtHexColor.DataBindings.Add(new System.Windows.Forms.Binding("FillColor", global::QMM.Properties.Settings.Default, "ButtonColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.TxtHexColor.DataBindings.Add(new System.Windows.Forms.Binding("BorderColor", global::QMM.Properties.Settings.Default, "DetailColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.TxtHexColor.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::QMM.Properties.Settings.Default, "TextColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.TxtHexColor.DataBindings.Add(new System.Windows.Forms.Binding("PlaceholderForeColor", global::QMM.Properties.Settings.Default, "PlaceholderColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.TxtHexColor.DefaultText = "";
            this.TxtHexColor.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtHexColor.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtHexColor.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtHexColor.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtHexColor.FillColor = global::QMM.Properties.Settings.Default.ButtonColor;
            this.TxtHexColor.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(167)))), ((int)(((byte)(231)))));
            this.TxtHexColor.Font = new System.Drawing.Font("Gadugi", 10F);
            this.TxtHexColor.ForeColor = global::QMM.Properties.Settings.Default.TextColor;
            this.TxtHexColor.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(167)))), ((int)(((byte)(231)))));
            this.TxtHexColor.Location = new System.Drawing.Point(117, 119);
            this.TxtHexColor.MaxLength = 255;
            this.TxtHexColor.Name = "TxtHexColor";
            this.TxtHexColor.PasswordChar = '\0';
            this.TxtHexColor.PlaceholderForeColor = global::QMM.Properties.Settings.Default.PlaceholderColor;
            this.TxtHexColor.PlaceholderText = "Hex Color";
            this.TxtHexColor.SelectedText = "";
            this.TxtHexColor.Size = new System.Drawing.Size(182, 41);
            this.TxtHexColor.TabIndex = 4;
            this.TxtHexColor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtHexColor.Leave += new System.EventHandler(this.TxtHexColor_Leave);
            // 
            // PanelOutlineBlock3
            // 
            this.PanelOutlineBlock3.AccessibleName = "PanelOutlineBlock3";
            this.PanelOutlineBlock3.BackColor = global::QMM.Properties.Settings.Default.BGSecondary;
            this.PanelOutlineBlock3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(167)))), ((int)(((byte)(231)))));
            this.PanelOutlineBlock3.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::QMM.Properties.Settings.Default, "BGSecondary", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.PanelOutlineBlock3.Location = new System.Drawing.Point(97, 125);
            this.PanelOutlineBlock3.Name = "PanelOutlineBlock3";
            this.PanelOutlineBlock3.Size = new System.Drawing.Size(229, 10);
            this.PanelOutlineBlock3.TabIndex = 15;
            // 
            // LabelBlue
            // 
            this.LabelBlue.AccessibleName = "LabelBlue";
            this.LabelBlue.AutoSize = true;
            this.LabelBlue.BackColor = System.Drawing.Color.Transparent;
            this.LabelBlue.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::QMM.Properties.Settings.Default, "TextColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.LabelBlue.Font = new System.Drawing.Font("Gadugi", 10F);
            this.LabelBlue.ForeColor = global::QMM.Properties.Settings.Default.TextColor;
            this.LabelBlue.Location = new System.Drawing.Point(70, 82);
            this.LabelBlue.Name = "LabelBlue";
            this.LabelBlue.Size = new System.Drawing.Size(16, 17);
            this.LabelBlue.TabIndex = 15;
            this.LabelBlue.Text = "B";
            this.LabelBlue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PanelOutlineBlock2
            // 
            this.PanelOutlineBlock2.AccessibleName = "PanelOutlineBlock2";
            this.PanelOutlineBlock2.BackColor = global::QMM.Properties.Settings.Default.BGSecondary;
            this.PanelOutlineBlock2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(167)))), ((int)(((byte)(231)))));
            this.PanelOutlineBlock2.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::QMM.Properties.Settings.Default, "BGSecondary", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.PanelOutlineBlock2.Location = new System.Drawing.Point(93, 5);
            this.PanelOutlineBlock2.Name = "PanelOutlineBlock2";
            this.PanelOutlineBlock2.Size = new System.Drawing.Size(10, 130);
            this.PanelOutlineBlock2.TabIndex = 15;
            // 
            // PanelOutlineBlock1
            // 
            this.PanelOutlineBlock1.AccessibleName = "PanelOutlineBlock1";
            this.PanelOutlineBlock1.BackColor = global::QMM.Properties.Settings.Default.BGSecondary;
            this.PanelOutlineBlock1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(167)))), ((int)(((byte)(231)))));
            this.PanelOutlineBlock1.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::QMM.Properties.Settings.Default, "BGSecondary", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.PanelOutlineBlock1.Location = new System.Drawing.Point(316, 5);
            this.PanelOutlineBlock1.Name = "PanelOutlineBlock1";
            this.PanelOutlineBlock1.Size = new System.Drawing.Size(10, 128);
            this.PanelOutlineBlock1.TabIndex = 15;
            // 
            // LabelGreen
            // 
            this.LabelGreen.AccessibleName = "LabelGreen";
            this.LabelGreen.AutoSize = true;
            this.LabelGreen.BackColor = System.Drawing.Color.Transparent;
            this.LabelGreen.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::QMM.Properties.Settings.Default, "TextColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.LabelGreen.Font = new System.Drawing.Font("Gadugi", 10F);
            this.LabelGreen.ForeColor = global::QMM.Properties.Settings.Default.TextColor;
            this.LabelGreen.Location = new System.Drawing.Point(69, 48);
            this.LabelGreen.Name = "LabelGreen";
            this.LabelGreen.Size = new System.Drawing.Size(18, 17);
            this.LabelGreen.TabIndex = 15;
            this.LabelGreen.Text = "G";
            this.LabelGreen.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LabelRed
            // 
            this.LabelRed.AccessibleName = "LabelRed";
            this.LabelRed.AutoSize = true;
            this.LabelRed.BackColor = System.Drawing.Color.Transparent;
            this.LabelRed.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::QMM.Properties.Settings.Default, "TextColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.LabelRed.Font = new System.Drawing.Font("Gadugi", 10F);
            this.LabelRed.ForeColor = global::QMM.Properties.Settings.Default.TextColor;
            this.LabelRed.Location = new System.Drawing.Point(70, 14);
            this.LabelRed.Name = "LabelRed";
            this.LabelRed.Size = new System.Drawing.Size(16, 17);
            this.LabelRed.TabIndex = 15;
            this.LabelRed.Text = "R";
            this.LabelRed.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // SliderBlue
            // 
            this.SliderBlue.AccessibleName = "SliderBlue";
            this.SliderBlue.BackColor = global::QMM.Properties.Settings.Default.BGSecondary;
            this.SliderBlue.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::QMM.Properties.Settings.Default, "BGSecondary", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.SliderBlue.Location = new System.Drawing.Point(100, 82);
            this.SliderBlue.Maximum = 255;
            this.SliderBlue.Name = "SliderBlue";
            this.SliderBlue.Size = new System.Drawing.Size(217, 45);
            this.SliderBlue.SmallChange = 5;
            this.SliderBlue.TabIndex = 5;
            this.SliderBlue.TickFrequency = 17;
            this.SliderBlue.TickStyle = System.Windows.Forms.TickStyle.None;
            this.SliderBlue.Scroll += new System.EventHandler(this.Slider_Scroll);
            // 
            // SliderGreen
            // 
            this.SliderGreen.AccessibleName = "SliderGreen";
            this.SliderGreen.BackColor = global::QMM.Properties.Settings.Default.BGSecondary;
            this.SliderGreen.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::QMM.Properties.Settings.Default, "BGSecondary", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.SliderGreen.Location = new System.Drawing.Point(100, 48);
            this.SliderGreen.Maximum = 255;
            this.SliderGreen.Name = "SliderGreen";
            this.SliderGreen.Size = new System.Drawing.Size(217, 45);
            this.SliderGreen.SmallChange = 5;
            this.SliderGreen.TabIndex = 5;
            this.SliderGreen.TickFrequency = 17;
            this.SliderGreen.TickStyle = System.Windows.Forms.TickStyle.None;
            this.SliderGreen.Scroll += new System.EventHandler(this.Slider_Scroll);
            // 
            // SliderRed
            // 
            this.SliderRed.AccessibleName = "SliderRed";
            this.SliderRed.BackColor = global::QMM.Properties.Settings.Default.BGSecondary;
            this.SliderRed.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::QMM.Properties.Settings.Default, "BGSecondary", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.SliderRed.Location = new System.Drawing.Point(100, 14);
            this.SliderRed.Maximum = 255;
            this.SliderRed.Name = "SliderRed";
            this.SliderRed.Size = new System.Drawing.Size(217, 45);
            this.SliderRed.SmallChange = 5;
            this.SliderRed.TabIndex = 5;
            this.SliderRed.TickFrequency = 17;
            this.SliderRed.TickStyle = System.Windows.Forms.TickStyle.None;
            this.SliderRed.Scroll += new System.EventHandler(this.Slider_Scroll);
            // 
            // TxtRGBColor
            // 
            this.TxtRGBColor.AccessibleName = "TxtRGBColor";
            this.TxtRGBColor.Animated = true;
            this.TxtRGBColor.BackColor = System.Drawing.Color.Transparent;
            this.TxtRGBColor.BorderColor = global::QMM.Properties.Settings.Default.DetailColor;
            this.TxtRGBColor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtRGBColor.DataBindings.Add(new System.Windows.Forms.Binding("BorderColor", global::QMM.Properties.Settings.Default, "DetailColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.TxtRGBColor.DataBindings.Add(new System.Windows.Forms.Binding("FillColor", global::QMM.Properties.Settings.Default, "ButtonColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.TxtRGBColor.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::QMM.Properties.Settings.Default, "TextColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.TxtRGBColor.DataBindings.Add(new System.Windows.Forms.Binding("PlaceholderForeColor", global::QMM.Properties.Settings.Default, "PlaceholderColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.TxtRGBColor.DefaultText = "";
            this.TxtRGBColor.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtRGBColor.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtRGBColor.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtRGBColor.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtRGBColor.FillColor = global::QMM.Properties.Settings.Default.ButtonColor;
            this.TxtRGBColor.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(167)))), ((int)(((byte)(231)))));
            this.TxtRGBColor.Font = new System.Drawing.Font("Gadugi", 10F);
            this.TxtRGBColor.ForeColor = global::QMM.Properties.Settings.Default.TextColor;
            this.TxtRGBColor.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(167)))), ((int)(((byte)(231)))));
            this.TxtRGBColor.Location = new System.Drawing.Point(117, 170);
            this.TxtRGBColor.MaxLength = 255;
            this.TxtRGBColor.Name = "TxtRGBColor";
            this.TxtRGBColor.PasswordChar = '\0';
            this.TxtRGBColor.PlaceholderForeColor = global::QMM.Properties.Settings.Default.PlaceholderColor;
            this.TxtRGBColor.PlaceholderText = "RGB Color";
            this.TxtRGBColor.SelectedText = "";
            this.TxtRGBColor.Size = new System.Drawing.Size(182, 41);
            this.TxtRGBColor.TabIndex = 4;
            this.TxtRGBColor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtRGBColor.Leave += new System.EventHandler(this.TxtRGBColor_Leave);
            // 
            // PanelHeader
            // 
            this.PanelHeader.AccessibleName = "PanelHeader";
            this.PanelHeader.BackColor = System.Drawing.Color.Transparent;
            this.PanelHeader.BorderColor = global::QMM.Properties.Settings.Default.DetailColor;
            this.PanelHeader.BorderRadius = global::QMM.Properties.Settings.Default.BorderRadius;
            this.PanelHeader.BorderThickness = 1;
            this.PanelHeader.Controls.Add(this.BtnClose);
            this.PanelHeader.Controls.Add(this.BtnFinishSelection);
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
            this.PanelHeader.Size = new System.Drawing.Size(417, 60);
            this.PanelHeader.TabIndex = 20;
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
            this.BtnClose.HoverState.CustomBorderColor = System.Drawing.Color.White;
            this.BtnClose.Location = new System.Drawing.Point(372, 15);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(36)))));
            this.BtnClose.Size = new System.Drawing.Size(30, 30);
            this.BtnClose.TabIndex = 3;
            this.BtnClose.Text = "X";
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // BtnFinishSelection
            // 
            this.BtnFinishSelection.AccessibleName = "BtnFinishSelection";
            this.BtnFinishSelection.Animated = true;
            this.BtnFinishSelection.BorderColor = System.Drawing.Color.White;
            this.BtnFinishSelection.BorderThickness = 1;
            this.BtnFinishSelection.CheckedState.CustomBorderColor = System.Drawing.Color.White;
            this.BtnFinishSelection.CheckedState.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFinishSelection.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnFinishSelection.DataBindings.Add(new System.Windows.Forms.Binding("FillColor", global::QMM.Properties.Settings.Default, "ButtonColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.BtnFinishSelection.FillColor = global::QMM.Properties.Settings.Default.ButtonColor;
            this.BtnFinishSelection.Font = new System.Drawing.Font("Azonix", 11F);
            this.BtnFinishSelection.ForeColor = System.Drawing.Color.White;
            this.BtnFinishSelection.HoverState.CustomBorderColor = System.Drawing.Color.White;
            this.BtnFinishSelection.Image = ((System.Drawing.Image)(resources.GetObject("BtnFinishSelection.Image")));
            this.BtnFinishSelection.ImageSize = new System.Drawing.Size(16, 16);
            this.BtnFinishSelection.Location = new System.Drawing.Point(327, 15);
            this.BtnFinishSelection.Name = "BtnFinishSelection";
            this.BtnFinishSelection.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(36)))));
            this.BtnFinishSelection.Size = new System.Drawing.Size(30, 30);
            this.BtnFinishSelection.TabIndex = 5;
            this.BtnFinishSelection.Click += new System.EventHandler(this.BtnFinishSelection_Click);
            // 
            // ImgIcon
            // 
            this.ImgIcon.AccessibleName = "ImgIcon";
            this.ImgIcon.BackColor = System.Drawing.Color.Transparent;
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
            this.LabelTitle.Size = new System.Drawing.Size(142, 36);
            this.LabelTitle.TabIndex = 9;
            this.LabelTitle.Text = "Color";
            this.LabelTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoveWindow);
            // 
            // LabelVersion
            // 
            this.LabelVersion.AccessibleName = "LabelVersion";
            this.LabelVersion.AutoSize = true;
            this.LabelVersion.BackColor = System.Drawing.Color.Transparent;
            this.LabelVersion.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::QMM.Properties.Settings.Default, "Version", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.LabelVersion.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::QMM.Properties.Settings.Default, "TextColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.LabelVersion.Font = new System.Drawing.Font("Gadugi", 10F);
            this.LabelVersion.ForeColor = global::QMM.Properties.Settings.Default.TextColor;
            this.LabelVersion.Location = new System.Drawing.Point(8, 344);
            this.LabelVersion.Name = "LabelVersion";
            this.LabelVersion.Size = new System.Drawing.Size(38, 17);
            this.LabelVersion.TabIndex = 21;
            this.LabelVersion.Text = global::QMM.Properties.Settings.Default.Version;
            this.LabelVersion.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoveWindow);
            // 
            // PanelColorPreview
            // 
            this.PanelColorPreview.AccessibleName = "PanelColorPreview";
            this.PanelColorPreview.Animated = true;
            this.PanelColorPreview.BackColor = System.Drawing.Color.Transparent;
            this.PanelColorPreview.BorderColor = global::QMM.Properties.Settings.Default.DetailColor;
            this.PanelColorPreview.BorderThickness = 1;
            this.PanelColorPreview.CheckedState.Font = new System.Drawing.Font("Gadugi", 10F, System.Drawing.FontStyle.Bold);
            this.PanelColorPreview.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelColorPreview.DataBindings.Add(new System.Windows.Forms.Binding("BorderColor", global::QMM.Properties.Settings.Default, "DetailColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.PanelColorPreview.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.PanelColorPreview.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.PanelColorPreview.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.PanelColorPreview.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.PanelColorPreview.FillColor = System.Drawing.Color.Empty;
            this.PanelColorPreview.Font = new System.Drawing.Font("Gadugi", 10F);
            this.PanelColorPreview.ForeColor = System.Drawing.Color.White;
            this.PanelColorPreview.ImageSize = new System.Drawing.Size(16, 16);
            this.PanelColorPreview.Location = new System.Drawing.Point(117, 219);
            this.PanelColorPreview.Name = "PanelColorPreview";
            this.PanelColorPreview.PressedColor = System.Drawing.Color.Empty;
            this.PanelColorPreview.Size = new System.Drawing.Size(182, 45);
            this.PanelColorPreview.TabIndex = 17;
            // 
            // FColorSelector
            // 
            this.AccessibleName = "FColorSelector";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = global::QMM.Properties.Settings.Default.BGPrimary;
            this.ClientSize = new System.Drawing.Size(437, 364);
            this.Controls.Add(this.LabelDevelopment);
            this.Controls.Add(this.PanelBody);
            this.Controls.Add(this.PanelHeader);
            this.Controls.Add(this.LabelVersion);
            this.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::QMM.Properties.Settings.Default, "BGPrimary", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FColorSelector";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QMM | Color Selector";
            this.TopMost = true;
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoveWindow);
            this.PanelBody.ResumeLayout(false);
            this.PanelBody.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SliderBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SliderGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SliderRed)).EndInit();
            this.PanelHeader.ResumeLayout(false);
            this.PanelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelDevelopment;
        private Guna.UI2.WinForms.Guna2Panel PanelBody;
        private Guna.UI2.WinForms.Guna2Panel PanelOutlineBlock6;
        private Guna.UI2.WinForms.Guna2Button BtnColorPicker;
        private Guna.UI2.WinForms.Guna2Panel PanelOutlineBlock5;
        private Guna.UI2.WinForms.Guna2Panel PanelOutlineBlock4;
        private Guna.UI2.WinForms.Guna2TextBox TxtHexColor;
        private Guna.UI2.WinForms.Guna2Panel PanelOutlineBlock3;
        private System.Windows.Forms.Label LabelBlue;
        private Guna.UI2.WinForms.Guna2Panel PanelOutlineBlock2;
        private Guna.UI2.WinForms.Guna2Panel PanelOutlineBlock1;
        private System.Windows.Forms.Label LabelGreen;
        private System.Windows.Forms.Label LabelRed;
        private System.Windows.Forms.TrackBar SliderBlue;
        private System.Windows.Forms.TrackBar SliderGreen;
        private System.Windows.Forms.TrackBar SliderRed;
        private Guna.UI2.WinForms.Guna2TextBox TxtRGBColor;
        private Guna.UI2.WinForms.Guna2Panel PanelHeader;
        private Guna.UI2.WinForms.Guna2Button BtnClose;
        private Guna.UI2.WinForms.Guna2Button BtnFinishSelection;
        private System.Windows.Forms.PictureBox ImgIcon;
        private System.Windows.Forms.Label LabelTitle;
        private System.Windows.Forms.Label LabelVersion;
        private Guna.UI2.WinForms.Guna2Button PanelColorPreview;
    }
}