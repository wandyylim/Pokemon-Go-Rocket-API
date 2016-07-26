﻿namespace PokemonGo.RocketAPI.Window
{
    partial class SettingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.authTypeLabel = new System.Windows.Forms.Label();
            this.authTypeCb = new System.Windows.Forms.ComboBox();
            this.ptcUserLabel = new System.Windows.Forms.Label();
            this.ptcPasswordLabel = new System.Windows.Forms.Label();
            this.latLabel = new System.Windows.Forms.Label();
            this.longiLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ptcUserText = new System.Windows.Forms.TextBox();
            this.ptcPassText = new System.Windows.Forms.TextBox();
            this.latitudeText = new System.Windows.Forms.TextBox();
            this.longitudeText = new System.Windows.Forms.TextBox();
            this.razzmodeCb = new System.Windows.Forms.ComboBox();
            this.razzSettingText = new System.Windows.Forms.TextBox();
            this.transferTypeCb = new System.Windows.Forms.ComboBox();
            this.transferCpThresText = new System.Windows.Forms.TextBox();
            this.evolveAllChk = new System.Windows.Forms.CheckBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.gMapControl1 = new GMap.NET.WindowsForms.GMapControl();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.IVThreshold = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pokestopRadius = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // authTypeLabel
            // 
            this.authTypeLabel.AutoSize = true;
            this.authTypeLabel.Location = new System.Drawing.Point(12, 13);
            this.authTypeLabel.Name = "authTypeLabel";
            this.authTypeLabel.Size = new System.Drawing.Size(59, 13);
            this.authTypeLabel.TabIndex = 0;
            this.authTypeLabel.Text = "Auth Type:";
            // 
            // authTypeCb
            // 
            this.authTypeCb.FormattingEnabled = true;
            this.authTypeCb.Items.AddRange(new object[] {
            "Ptc",
            "Google"});
            this.authTypeCb.Location = new System.Drawing.Point(113, 10);
            this.authTypeCb.Name = "authTypeCb";
            this.authTypeCb.Size = new System.Drawing.Size(75, 21);
            this.authTypeCb.TabIndex = 1;
            this.authTypeCb.SelectedIndexChanged += new System.EventHandler(this.authTypeCb_SelectedIndexChanged);
            // 
            // ptcUserLabel
            // 
            this.ptcUserLabel.AutoSize = true;
            this.ptcUserLabel.Location = new System.Drawing.Point(12, 42);
            this.ptcUserLabel.Name = "ptcUserLabel";
            this.ptcUserLabel.Size = new System.Drawing.Size(77, 13);
            this.ptcUserLabel.TabIndex = 2;
            this.ptcUserLabel.Text = "Ptc Username:";
            // 
            // ptcPasswordLabel
            // 
            this.ptcPasswordLabel.AutoSize = true;
            this.ptcPasswordLabel.Location = new System.Drawing.Point(12, 68);
            this.ptcPasswordLabel.Name = "ptcPasswordLabel";
            this.ptcPasswordLabel.Size = new System.Drawing.Size(75, 13);
            this.ptcPasswordLabel.TabIndex = 3;
            this.ptcPasswordLabel.Text = "Ptc Password:";
            // 
            // latLabel
            // 
            this.latLabel.AutoSize = true;
            this.latLabel.Location = new System.Drawing.Point(12, 94);
            this.latLabel.Name = "latLabel";
            this.latLabel.Size = new System.Drawing.Size(48, 13);
            this.latLabel.TabIndex = 4;
            this.latLabel.Text = "Latitude:";
            // 
            // longiLabel
            // 
            this.longiLabel.AutoSize = true;
            this.longiLabel.Location = new System.Drawing.Point(12, 120);
            this.longiLabel.Name = "longiLabel";
            this.longiLabel.Size = new System.Drawing.Size(57, 13);
            this.longiLabel.TabIndex = 5;
            this.longiLabel.Text = "Longitude:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Razzberry mode:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Transfer Type:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Evolve all pokemon:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Trsfr CP Threshold:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Razzberry Setting:";
            // 
            // ptcUserText
            // 
            this.ptcUserText.Location = new System.Drawing.Point(113, 39);
            this.ptcUserText.Name = "ptcUserText";
            this.ptcUserText.Size = new System.Drawing.Size(100, 20);
            this.ptcUserText.TabIndex = 11;
            // 
            // ptcPassText
            // 
            this.ptcPassText.Location = new System.Drawing.Point(113, 65);
            this.ptcPassText.Name = "ptcPassText";
            this.ptcPassText.Size = new System.Drawing.Size(100, 20);
            this.ptcPassText.TabIndex = 12;
            // 
            // latitudeText
            // 
            this.latitudeText.Location = new System.Drawing.Point(113, 91);
            this.latitudeText.Name = "latitudeText";
            this.latitudeText.Size = new System.Drawing.Size(100, 20);
            this.latitudeText.TabIndex = 13;
            // 
            // longitudeText
            // 
            this.longitudeText.Location = new System.Drawing.Point(113, 117);
            this.longitudeText.Name = "longitudeText";
            this.longitudeText.Size = new System.Drawing.Size(100, 20);
            this.longitudeText.TabIndex = 14;
            // 
            // razzmodeCb
            // 
            this.razzmodeCb.FormattingEnabled = true;
            this.razzmodeCb.Items.AddRange(new object[] {
            "probability",
            "cp"});
            this.razzmodeCb.Location = new System.Drawing.Point(113, 143);
            this.razzmodeCb.Name = "razzmodeCb";
            this.razzmodeCb.Size = new System.Drawing.Size(100, 21);
            this.razzmodeCb.TabIndex = 15;
            // 
            // razzSettingText
            // 
            this.razzSettingText.Location = new System.Drawing.Point(113, 170);
            this.razzSettingText.Name = "razzSettingText";
            this.razzSettingText.Size = new System.Drawing.Size(37, 20);
            this.razzSettingText.TabIndex = 16;
            // 
            // transferTypeCb
            // 
            this.transferTypeCb.FormattingEnabled = true;
            this.transferTypeCb.Items.AddRange(new object[] {
            "none",
            "cp",
            "leaveStrongest",
            "duplicate",
            "all"});
            this.transferTypeCb.Location = new System.Drawing.Point(113, 196);
            this.transferTypeCb.Name = "transferTypeCb";
            this.transferTypeCb.Size = new System.Drawing.Size(100, 21);
            this.transferTypeCb.TabIndex = 17;
            // 
            // transferCpThresText
            // 
            this.transferCpThresText.Location = new System.Drawing.Point(113, 224);
            this.transferCpThresText.Name = "transferCpThresText";
            this.transferCpThresText.Size = new System.Drawing.Size(100, 20);
            this.transferCpThresText.TabIndex = 18;
            // 
            // evolveAllChk
            // 
            this.evolveAllChk.AutoSize = true;
            this.evolveAllChk.Location = new System.Drawing.Point(113, 256);
            this.evolveAllChk.Name = "evolveAllChk";
            this.evolveAllChk.Size = new System.Drawing.Size(15, 14);
            this.evolveAllChk.TabIndex = 19;
            this.evolveAllChk.UseVisualStyleBackColor = true;
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(75, 276);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 20;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // gMapControl1
            // 
            this.gMapControl1.Bearing = 0F;
            this.gMapControl1.CanDragMap = true;
            this.gMapControl1.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapControl1.GrayScaleMode = false;
            this.gMapControl1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapControl1.LevelsKeepInMemmory = 5;
            this.gMapControl1.Location = new System.Drawing.Point(235, 13);
            this.gMapControl1.MarkersEnabled = true;
            this.gMapControl1.MaxZoom = 2;
            this.gMapControl1.MinZoom = 2;
            this.gMapControl1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMapControl1.Name = "gMapControl1";
            this.gMapControl1.NegativeMode = false;
            this.gMapControl1.PolygonsEnabled = true;
            this.gMapControl1.RetryLoadTile = 0;
            this.gMapControl1.RoutesEnabled = true;
            this.gMapControl1.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMapControl1.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMapControl1.ShowTileGridLines = false;
            this.gMapControl1.Size = new System.Drawing.Size(230, 231);
            this.gMapControl1.TabIndex = 22;
            this.gMapControl1.Zoom = 0D;
            this.gMapControl1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gMapControl1_MouseClick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(150, 250);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(282, 256);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "label6";
            // 
            // IVThreshold
            // 
            this.IVThreshold.Location = new System.Drawing.Point(151, 306);
            this.IVThreshold.Margin = new System.Windows.Forms.Padding(4);
            this.IVThreshold.Name = "IVThreshold";
            this.IVThreshold.Size = new System.Drawing.Size(132, 22);
            this.IVThreshold.TabIndex = 26;
            this.IVThreshold.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 309);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 17);
            this.label7.TabIndex = 25;
            this.label7.Text = "IV Threshold:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // pokestopRadius
            // 
            this.pokestopRadius.Location = new System.Drawing.Point(151, 336);
            this.pokestopRadius.Margin = new System.Windows.Forms.Padding(4);
            this.pokestopRadius.Name = "pokestopRadius";
            this.pokestopRadius.Size = new System.Drawing.Size(132, 22);
            this.pokestopRadius.TabIndex = 28;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 339);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 17);
            this.label8.TabIndex = 27;
            this.label8.Text = "Pokestop Radius:";
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 298);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.gMapControl1);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.evolveAllChk);
            this.Controls.Add(this.transferCpThresText);
            this.Controls.Add(this.transferTypeCb);
            this.Controls.Add(this.razzSettingText);
            this.Controls.Add(this.razzmodeCb);
            this.Controls.Add(this.longitudeText);
            this.Controls.Add(this.latitudeText);
            this.Controls.Add(this.ptcPassText);
            this.Controls.Add(this.ptcUserText);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.longiLabel);
            this.Controls.Add(this.latLabel);
            this.Controls.Add(this.ptcPasswordLabel);
            this.Controls.Add(this.ptcUserLabel);
            this.Controls.Add(this.authTypeCb);
            this.Controls.Add(this.authTypeLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SettingsForm";
            this.Padding = new System.Windows.Forms.Padding(9);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label authTypeLabel;
        private System.Windows.Forms.ComboBox authTypeCb;
        private System.Windows.Forms.Label ptcUserLabel;
        private System.Windows.Forms.Label ptcPasswordLabel;
        private System.Windows.Forms.Label latLabel;
        private System.Windows.Forms.Label longiLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ptcUserText;
        private System.Windows.Forms.TextBox ptcPassText;
        private System.Windows.Forms.TextBox latitudeText;
        private System.Windows.Forms.TextBox longitudeText;
        private System.Windows.Forms.ComboBox razzmodeCb;
        private System.Windows.Forms.TextBox razzSettingText;
        private System.Windows.Forms.ComboBox transferTypeCb;
        private System.Windows.Forms.TextBox transferCpThresText;
        private System.Windows.Forms.CheckBox evolveAllChk;
        private System.Windows.Forms.Button saveBtn;
        private GMap.NET.WindowsForms.GMapControl gMapControl1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
    }
}
