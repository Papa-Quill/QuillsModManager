namespace QMM.Info_Forms
{
    partial class FMessageBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FMessageBox));
            this.PanelMessageBox = new Guna.UI2.WinForms.Guna2Panel();
            this.LabelMessage = new System.Windows.Forms.Label();
            this.PanelHeader = new Guna.UI2.WinForms.Guna2Panel();
            this.BtnClose = new Guna.UI2.WinForms.Guna2Button();
            this.BtnNo = new Guna.UI2.WinForms.Guna2Button();
            this.BtnYes = new Guna.UI2.WinForms.Guna2Button();
            this.imgIcon = new System.Windows.Forms.PictureBox();
            this.LabelTitle = new System.Windows.Forms.Label();
            this.PanelMessageBox.SuspendLayout();
            this.PanelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelMessageBox
            // 
            this.PanelMessageBox.AccessibleName = "PanelMessageBox";
            this.PanelMessageBox.BackColor = System.Drawing.Color.Transparent;
            this.PanelMessageBox.BorderColor = global::QMM.Properties.Settings.Default.DetailColor;
            this.PanelMessageBox.BorderRadius = global::QMM.Properties.Settings.Default.BorderRadius;
            this.PanelMessageBox.BorderThickness = 1;
            this.PanelMessageBox.Controls.Add(this.LabelMessage);
            this.PanelMessageBox.CustomizableEdges.TopLeft = false;
            this.PanelMessageBox.CustomizableEdges.TopRight = false;
            this.PanelMessageBox.DataBindings.Add(new System.Windows.Forms.Binding("FillColor", global::QMM.Properties.Settings.Default, "BGSecondary", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.PanelMessageBox.DataBindings.Add(new System.Windows.Forms.Binding("BorderRadius", global::QMM.Properties.Settings.Default, "BorderRadius", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.PanelMessageBox.DataBindings.Add(new System.Windows.Forms.Binding("BorderColor", global::QMM.Properties.Settings.Default, "DetailColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.PanelMessageBox.FillColor = global::QMM.Properties.Settings.Default.BGSecondary;
            this.PanelMessageBox.Location = new System.Drawing.Point(10, 69);
            this.PanelMessageBox.Name = "PanelMessageBox";
            this.PanelMessageBox.Size = new System.Drawing.Size(541, 192);
            this.PanelMessageBox.TabIndex = 16;
            // 
            // LabelMessage
            // 
            this.LabelMessage.AccessibleName = "LabelMessage";
            this.LabelMessage.AutoSize = true;
            this.LabelMessage.BackColor = System.Drawing.Color.Transparent;
            this.LabelMessage.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::QMM.Properties.Settings.Default, "TextColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.LabelMessage.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::QMM.Properties.Settings.Default, "TxtNotif", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.LabelMessage.Font = new System.Drawing.Font("Gadugi", 15F);
            this.LabelMessage.ForeColor = global::QMM.Properties.Settings.Default.TextColor;
            this.LabelMessage.Location = new System.Drawing.Point(10, 10);
            this.LabelMessage.MaximumSize = new System.Drawing.Size(522, 1000);
            this.LabelMessage.Name = "LabelMessage";
            this.LabelMessage.Size = new System.Drawing.Size(132, 24);
            this.LabelMessage.TabIndex = 16;
            this.LabelMessage.Text = global::QMM.Properties.Settings.Default.TxtNotif;
            // 
            // PanelHeader
            // 
            this.PanelHeader.AccessibleName = "PanelHeader";
            this.PanelHeader.BackColor = System.Drawing.Color.Transparent;
            this.PanelHeader.BorderColor = global::QMM.Properties.Settings.Default.DetailColor;
            this.PanelHeader.BorderRadius = global::QMM.Properties.Settings.Default.BorderRadius;
            this.PanelHeader.BorderThickness = 1;
            this.PanelHeader.Controls.Add(this.BtnClose);
            this.PanelHeader.Controls.Add(this.BtnNo);
            this.PanelHeader.Controls.Add(this.BtnYes);
            this.PanelHeader.Controls.Add(this.imgIcon);
            this.PanelHeader.Controls.Add(this.LabelTitle);
            this.PanelHeader.CustomizableEdges.BottomLeft = false;
            this.PanelHeader.CustomizableEdges.BottomRight = false;
            this.PanelHeader.DataBindings.Add(new System.Windows.Forms.Binding("FillColor", global::QMM.Properties.Settings.Default, "BGTertiary", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.PanelHeader.DataBindings.Add(new System.Windows.Forms.Binding("BorderRadius", global::QMM.Properties.Settings.Default, "BorderRadius", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.PanelHeader.DataBindings.Add(new System.Windows.Forms.Binding("BorderColor", global::QMM.Properties.Settings.Default, "DetailColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.PanelHeader.FillColor = global::QMM.Properties.Settings.Default.BGTertiary;
            this.PanelHeader.Location = new System.Drawing.Point(10, 10);
            this.PanelHeader.Name = "PanelHeader";
            this.PanelHeader.Size = new System.Drawing.Size(541, 60);
            this.PanelHeader.TabIndex = 15;
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
            this.BtnClose.Location = new System.Drawing.Point(496, 15);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(36)))));
            this.BtnClose.Size = new System.Drawing.Size(30, 30);
            this.BtnClose.TabIndex = 11;
            this.BtnClose.Text = "X";
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // BtnNo
            // 
            this.BtnNo.AccessibleDescription = "";
            this.BtnNo.AccessibleName = "BtnNo";
            this.BtnNo.Animated = true;
            this.BtnNo.BorderColor = System.Drawing.Color.White;
            this.BtnNo.BorderThickness = 1;
            this.BtnNo.CheckedState.CustomBorderColor = System.Drawing.Color.White;
            this.BtnNo.CheckedState.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnNo.DataBindings.Add(new System.Windows.Forms.Binding("FillColor", global::QMM.Properties.Settings.Default, "ButtonColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.BtnNo.FillColor = global::QMM.Properties.Settings.Default.ButtonColor;
            this.BtnNo.Font = new System.Drawing.Font("Azonix", 11F);
            this.BtnNo.ForeColor = System.Drawing.Color.White;
            this.BtnNo.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(167)))), ((int)(((byte)(231)))));
            this.BtnNo.Location = new System.Drawing.Point(379, 15);
            this.BtnNo.Name = "BtnNo";
            this.BtnNo.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(36)))));
            this.BtnNo.Size = new System.Drawing.Size(66, 30);
            this.BtnNo.TabIndex = 4;
            this.BtnNo.Text = "No";
            this.BtnNo.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // BtnYes
            // 
            this.BtnYes.AccessibleName = "BtnYes";
            this.BtnYes.Animated = true;
            this.BtnYes.BorderColor = System.Drawing.Color.White;
            this.BtnYes.BorderThickness = 1;
            this.BtnYes.CheckedState.CustomBorderColor = System.Drawing.Color.White;
            this.BtnYes.CheckedState.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnYes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnYes.DataBindings.Add(new System.Windows.Forms.Binding("FillColor", global::QMM.Properties.Settings.Default, "ButtonColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.BtnYes.FillColor = global::QMM.Properties.Settings.Default.ButtonColor;
            this.BtnYes.Font = new System.Drawing.Font("Azonix", 11F);
            this.BtnYes.ForeColor = System.Drawing.Color.White;
            this.BtnYes.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(167)))), ((int)(((byte)(231)))));
            this.BtnYes.Location = new System.Drawing.Point(460, 15);
            this.BtnYes.Name = "BtnYes";
            this.BtnYes.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(36)))));
            this.BtnYes.Size = new System.Drawing.Size(66, 30);
            this.BtnYes.TabIndex = 4;
            this.BtnYes.Text = "Yes";
            this.BtnYes.Click += new System.EventHandler(this.BtnYes_Click);
            // 
            // imgIcon
            // 
            this.imgIcon.AccessibleName = "imgIcon";
            this.imgIcon.Image = global::QMM.Properties.Resources.AnimatedQuillDiamond;
            this.imgIcon.Location = new System.Drawing.Point(10, 6);
            this.imgIcon.MaximumSize = new System.Drawing.Size(48, 48);
            this.imgIcon.MinimumSize = new System.Drawing.Size(48, 48);
            this.imgIcon.Name = "imgIcon";
            this.imgIcon.Size = new System.Drawing.Size(48, 48);
            this.imgIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
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
            this.LabelTitle.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTitle.ForeColor = global::QMM.Properties.Settings.Default.TextColor;
            this.LabelTitle.Location = new System.Drawing.Point(66, 10);
            this.LabelTitle.Name = "LabelTitle";
            this.LabelTitle.Size = new System.Drawing.Size(150, 40);
            this.LabelTitle.TabIndex = 9;
            this.LabelTitle.Text = "LabelTitle";
            this.LabelTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoveWindow);
            // 
            // FMessageBox
            // 
            this.AccessibleName = "MessageBox";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = global::QMM.Properties.Settings.Default.BGPrimary;
            this.ClientSize = new System.Drawing.Size(561, 272);
            this.Controls.Add(this.PanelMessageBox);
            this.Controls.Add(this.PanelHeader);
            this.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::QMM.Properties.Settings.Default, "BGPrimary", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FMessageBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MessageBox";
            this.TopMost = true;
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoveWindow);
            this.PanelMessageBox.ResumeLayout(false);
            this.PanelMessageBox.PerformLayout();
            this.PanelHeader.ResumeLayout(false);
            this.PanelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel PanelMessageBox;
        private System.Windows.Forms.Label LabelMessage;
        private Guna.UI2.WinForms.Guna2Panel PanelHeader;
        public Guna.UI2.WinForms.Guna2Button BtnClose;
        public Guna.UI2.WinForms.Guna2Button BtnNo;
        public Guna.UI2.WinForms.Guna2Button BtnYes;
        private System.Windows.Forms.PictureBox imgIcon;
        private System.Windows.Forms.Label LabelTitle;
    }
}