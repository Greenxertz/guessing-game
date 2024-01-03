namespace music
{
    partial class Mainmenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mainmenu));
            this.pnlribbon = new System.Windows.Forms.Panel();
            this.pboptions = new System.Windows.Forms.PictureBox();
            this.btnmin = new MTcontrols.MTbutton.Button();
            this.btnmax = new MTcontrols.MTbutton.Button();
            this.btnclose = new MTcontrols.MTbutton.Button();
            this.pnloptions = new System.Windows.Forms.Panel();
            this.btnGenre = new MTcontrols.MTbutton.Button();
            this.button1 = new MTcontrols.MTbutton.Button();
            this.lblDarktheme = new System.Windows.Forms.Label();
            this.toggleButton1 = new MTcontrols.MTtoggle.ToggleButton();
            this.Pnlabout = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlYear = new System.Windows.Forms.Panel();
            this.btnconfirmyear = new MTcontrols.MTbutton.Button();
            this.grpYear = new System.Windows.Forms.GroupBox();
            this.radio7 = new MTcontrols.MTradio.Radio();
            this.radio5 = new MTcontrols.MTradio.Radio();
            this.radio4 = new MTcontrols.MTradio.Radio();
            this.radio3 = new MTcontrols.MTradio.Radio();
            this.radio2 = new MTcontrols.MTradio.Radio();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlribbon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboptions)).BeginInit();
            this.pnloptions.SuspendLayout();
            this.Pnlabout.SuspendLayout();
            this.pnlYear.SuspendLayout();
            this.grpYear.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlribbon
            // 
            this.pnlribbon.BackColor = System.Drawing.Color.Teal;
            this.pnlribbon.Controls.Add(this.pboptions);
            this.pnlribbon.Controls.Add(this.btnmin);
            this.pnlribbon.Controls.Add(this.btnmax);
            this.pnlribbon.Controls.Add(this.btnclose);
            this.pnlribbon.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlribbon.Location = new System.Drawing.Point(0, 0);
            this.pnlribbon.Name = "pnlribbon";
            this.pnlribbon.Size = new System.Drawing.Size(1150, 40);
            this.pnlribbon.TabIndex = 3;
            // 
            // pboptions
            // 
            this.pboptions.Dock = System.Windows.Forms.DockStyle.Left;
            this.pboptions.Image = ((System.Drawing.Image)(resources.GetObject("pboptions.Image")));
            this.pboptions.Location = new System.Drawing.Point(0, 0);
            this.pboptions.Name = "pboptions";
            this.pboptions.Size = new System.Drawing.Size(160, 40);
            this.pboptions.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pboptions.TabIndex = 3;
            this.pboptions.TabStop = false;
            this.pboptions.Click += new System.EventHandler(this.pboptions_Click);
            // 
            // btnmin
            // 
            this.btnmin.BackColor = System.Drawing.Color.DimGray;
            this.btnmin.BackgroundColor = System.Drawing.Color.DimGray;
            this.btnmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnmin.BorderColor = System.Drawing.Color.Black;
            this.btnmin.BorderRadius = 20;
            this.btnmin.BorderSize = 2;
            this.btnmin.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnmin.FlatAppearance.BorderSize = 0;
            this.btnmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmin.ForeColor = System.Drawing.Color.Black;
            this.btnmin.Location = new System.Drawing.Point(1030, 0);
            this.btnmin.Name = "btnmin";
            this.btnmin.Size = new System.Drawing.Size(40, 40);
            this.btnmin.TabIndex = 2;
            this.btnmin.Text = "--";
            this.btnmin.TextColor = System.Drawing.Color.Black;
            this.btnmin.UseVisualStyleBackColor = false;
            this.btnmin.Click += new System.EventHandler(this.btnmin_Click);
            // 
            // btnmax
            // 
            this.btnmax.BackColor = System.Drawing.Color.DimGray;
            this.btnmax.BackgroundColor = System.Drawing.Color.DimGray;
            this.btnmax.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnmax.BackgroundImage")));
            this.btnmax.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnmax.BorderColor = System.Drawing.Color.Black;
            this.btnmax.BorderRadius = 20;
            this.btnmax.BorderSize = 2;
            this.btnmax.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnmax.FlatAppearance.BorderSize = 0;
            this.btnmax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmax.ForeColor = System.Drawing.Color.White;
            this.btnmax.Location = new System.Drawing.Point(1070, 0);
            this.btnmax.Name = "btnmax";
            this.btnmax.Size = new System.Drawing.Size(40, 40);
            this.btnmax.TabIndex = 0;
            this.btnmax.TextColor = System.Drawing.Color.White;
            this.btnmax.UseVisualStyleBackColor = false;
            this.btnmax.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnclose
            // 
            this.btnclose.BackColor = System.Drawing.Color.DimGray;
            this.btnclose.BackgroundColor = System.Drawing.Color.DimGray;
            this.btnclose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnclose.BorderColor = System.Drawing.Color.Black;
            this.btnclose.BorderRadius = 20;
            this.btnclose.BorderSize = 2;
            this.btnclose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnclose.FlatAppearance.BorderSize = 0;
            this.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclose.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.ForeColor = System.Drawing.Color.Black;
            this.btnclose.Location = new System.Drawing.Point(1110, 0);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(40, 40);
            this.btnclose.TabIndex = 1;
            this.btnclose.Text = "X";
            this.btnclose.TextColor = System.Drawing.Color.Black;
            this.btnclose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnclose.UseVisualStyleBackColor = false;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // pnloptions
            // 
            this.pnloptions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pnloptions.Controls.Add(this.btnGenre);
            this.pnloptions.Controls.Add(this.button1);
            this.pnloptions.Controls.Add(this.lblDarktheme);
            this.pnloptions.Controls.Add(this.toggleButton1);
            this.pnloptions.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnloptions.Location = new System.Drawing.Point(0, 40);
            this.pnloptions.Name = "pnloptions";
            this.pnloptions.Size = new System.Drawing.Size(210, 644);
            this.pnloptions.TabIndex = 4;
            // 
            // btnGenre
            // 
            this.btnGenre.BackColor = System.Drawing.Color.DimGray;
            this.btnGenre.BackgroundColor = System.Drawing.Color.DimGray;
            this.btnGenre.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnGenre.BorderRadius = 20;
            this.btnGenre.BorderSize = 0;
            this.btnGenre.FlatAppearance.BorderSize = 0;
            this.btnGenre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenre.ForeColor = System.Drawing.Color.White;
            this.btnGenre.Location = new System.Drawing.Point(27, 177);
            this.btnGenre.Name = "btnGenre";
            this.btnGenre.Size = new System.Drawing.Size(157, 40);
            this.btnGenre.TabIndex = 4;
            this.btnGenre.Text = "Game Mode: Genre";
            this.btnGenre.TextColor = System.Drawing.Color.White;
            this.btnGenre.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DimGray;
            this.button1.BackgroundColor = System.Drawing.Color.DimGray;
            this.button1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.button1.BorderRadius = 20;
            this.button1.BorderSize = 0;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(27, 85);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 40);
            this.button1.TabIndex = 2;
            this.button1.Text = "About Me";
            this.button1.TextColor = System.Drawing.Color.White;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // lblDarktheme
            // 
            this.lblDarktheme.AutoSize = true;
            this.lblDarktheme.Font = new System.Drawing.Font("Bauhaus 93", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDarktheme.Location = new System.Drawing.Point(24, 29);
            this.lblDarktheme.Name = "lblDarktheme";
            this.lblDarktheme.Size = new System.Drawing.Size(104, 18);
            this.lblDarktheme.TabIndex = 1;
            this.lblDarktheme.Text = "Dark Theme";
            // 
            // toggleButton1
            // 
            this.toggleButton1.AutoSize = true;
            this.toggleButton1.Location = new System.Drawing.Point(134, 29);
            this.toggleButton1.MaximumSize = new System.Drawing.Size(60, 40);
            this.toggleButton1.MinimumSize = new System.Drawing.Size(50, 20);
            this.toggleButton1.Name = "toggleButton1";
            this.toggleButton1.OffBackColor = System.Drawing.Color.Black;
            this.toggleButton1.OffToggleColor = System.Drawing.Color.WhiteSmoke;
            this.toggleButton1.OnBackColor = System.Drawing.Color.WhiteSmoke;
            this.toggleButton1.OnToggleColor = System.Drawing.Color.Black;
            this.toggleButton1.Size = new System.Drawing.Size(50, 20);
            this.toggleButton1.TabIndex = 0;
            this.toggleButton1.UseVisualStyleBackColor = true;
            this.toggleButton1.CheckedChanged += new System.EventHandler(this.toggleButton1_CheckedChanged);
            // 
            // Pnlabout
            // 
            this.Pnlabout.Controls.Add(this.label1);
            this.Pnlabout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pnlabout.Location = new System.Drawing.Point(210, 40);
            this.Pnlabout.Name = "Pnlabout";
            this.Pnlabout.Size = new System.Drawing.Size(940, 644);
            this.Pnlabout.TabIndex = 5;
            this.Pnlabout.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bauhaus 93", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(797, 288);
            this.label1.TabIndex = 0;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // pnlYear
            // 
            this.pnlYear.Controls.Add(this.btnconfirmyear);
            this.pnlYear.Controls.Add(this.grpYear);
            this.pnlYear.Controls.Add(this.label2);
            this.pnlYear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlYear.Location = new System.Drawing.Point(210, 40);
            this.pnlYear.Name = "pnlYear";
            this.pnlYear.Size = new System.Drawing.Size(940, 644);
            this.pnlYear.TabIndex = 6;
            this.pnlYear.Visible = false;
            this.pnlYear.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlYear_Paint);
            // 
            // btnconfirmyear
            // 
            this.btnconfirmyear.BackColor = System.Drawing.Color.DimGray;
            this.btnconfirmyear.BackgroundColor = System.Drawing.Color.DimGray;
            this.btnconfirmyear.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnconfirmyear.BorderRadius = 20;
            this.btnconfirmyear.BorderSize = 0;
            this.btnconfirmyear.FlatAppearance.BorderSize = 0;
            this.btnconfirmyear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnconfirmyear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnconfirmyear.ForeColor = System.Drawing.Color.White;
            this.btnconfirmyear.Location = new System.Drawing.Point(330, 401);
            this.btnconfirmyear.Name = "btnconfirmyear";
            this.btnconfirmyear.Size = new System.Drawing.Size(193, 65);
            this.btnconfirmyear.TabIndex = 3;
            this.btnconfirmyear.Text = "Start";
            this.btnconfirmyear.TextColor = System.Drawing.Color.White;
            this.btnconfirmyear.UseVisualStyleBackColor = false;
            // 
            // grpYear
            // 
            this.grpYear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.grpYear.Controls.Add(this.radio7);
            this.grpYear.Controls.Add(this.radio5);
            this.grpYear.Controls.Add(this.radio4);
            this.grpYear.Controls.Add(this.radio3);
            this.grpYear.Controls.Add(this.radio2);
            this.grpYear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpYear.Location = new System.Drawing.Point(105, 85);
            this.grpYear.Name = "grpYear";
            this.grpYear.Size = new System.Drawing.Size(122, 159);
            this.grpYear.TabIndex = 1;
            this.grpYear.TabStop = false;
            // 
            // radio7
            // 
            this.radio7.AutoSize = true;
            this.radio7.CheckedColor = System.Drawing.Color.DimGray;
            this.radio7.Location = new System.Drawing.Point(29, 127);
            this.radio7.MinimumSize = new System.Drawing.Size(0, 21);
            this.radio7.Name = "radio7";
            this.radio7.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.radio7.Size = new System.Drawing.Size(66, 21);
            this.radio7.TabIndex = 6;
            this.radio7.TabStop = true;
            this.radio7.Text = "2020\'s";
            this.radio7.UnCheckedColor = System.Drawing.Color.DarkSlateGray;
            this.radio7.UseVisualStyleBackColor = true;
            // 
            // radio5
            // 
            this.radio5.AutoSize = true;
            this.radio5.CheckedColor = System.Drawing.Color.DimGray;
            this.radio5.Location = new System.Drawing.Point(29, 100);
            this.radio5.MinimumSize = new System.Drawing.Size(0, 21);
            this.radio5.Name = "radio5";
            this.radio5.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.radio5.Size = new System.Drawing.Size(66, 21);
            this.radio5.TabIndex = 4;
            this.radio5.TabStop = true;
            this.radio5.Text = "2010\'s";
            this.radio5.UnCheckedColor = System.Drawing.Color.DarkSlateGray;
            this.radio5.UseVisualStyleBackColor = true;
            // 
            // radio4
            // 
            this.radio4.AutoSize = true;
            this.radio4.CheckedColor = System.Drawing.Color.DimGray;
            this.radio4.Location = new System.Drawing.Point(29, 73);
            this.radio4.MinimumSize = new System.Drawing.Size(0, 21);
            this.radio4.Name = "radio4";
            this.radio4.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.radio4.Size = new System.Drawing.Size(66, 21);
            this.radio4.TabIndex = 3;
            this.radio4.TabStop = true;
            this.radio4.Text = "2000\'s";
            this.radio4.UnCheckedColor = System.Drawing.Color.DarkSlateGray;
            this.radio4.UseVisualStyleBackColor = true;
            // 
            // radio3
            // 
            this.radio3.AutoSize = true;
            this.radio3.CheckedColor = System.Drawing.Color.DimGray;
            this.radio3.Location = new System.Drawing.Point(29, 46);
            this.radio3.MinimumSize = new System.Drawing.Size(0, 21);
            this.radio3.Name = "radio3";
            this.radio3.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.radio3.Size = new System.Drawing.Size(54, 21);
            this.radio3.TabIndex = 2;
            this.radio3.TabStop = true;
            this.radio3.Text = "90\'s";
            this.radio3.UnCheckedColor = System.Drawing.Color.DarkSlateGray;
            this.radio3.UseVisualStyleBackColor = true;
            // 
            // radio2
            // 
            this.radio2.AutoSize = true;
            this.radio2.CheckedColor = System.Drawing.Color.DimGray;
            this.radio2.Location = new System.Drawing.Point(29, 19);
            this.radio2.MinimumSize = new System.Drawing.Size(0, 21);
            this.radio2.Name = "radio2";
            this.radio2.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.radio2.Size = new System.Drawing.Size(52, 21);
            this.radio2.TabIndex = 1;
            this.radio2.TabStop = true;
            this.radio2.Text = "80s";
            this.radio2.UnCheckedColor = System.Drawing.Color.DarkSlateGray;
            this.radio2.UseVisualStyleBackColor = true;
            this.radio2.CheckedChanged += new System.EventHandler(this.radio2_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bauhaus 93", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(375, 48);
            this.label2.TabIndex = 0;
            this.label2.Text = "How good are you? \r\nChoose the decade you wanna try: ";
            // 
            // Mainmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DarkTurquoise;
            this.ClientSize = new System.Drawing.Size(1150, 684);
            this.ControlBox = false;
            this.Controls.Add(this.pnlYear);
            this.Controls.Add(this.Pnlabout);
            this.Controls.Add(this.pnloptions);
            this.Controls.Add(this.pnlribbon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Mainmenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            this.pnlribbon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pboptions)).EndInit();
            this.pnloptions.ResumeLayout(false);
            this.pnloptions.PerformLayout();
            this.Pnlabout.ResumeLayout(false);
            this.Pnlabout.PerformLayout();
            this.pnlYear.ResumeLayout(false);
            this.pnlYear.PerformLayout();
            this.grpYear.ResumeLayout(false);
            this.grpYear.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MTcontrols.MTbutton.Button btnmax;
        private MTcontrols.MTbutton.Button btnclose;
        private MTcontrols.MTbutton.Button btnmin;
        private System.Windows.Forms.Panel pnlribbon;
        private System.Windows.Forms.Panel pnloptions;
        private MTcontrols.MTtoggle.ToggleButton toggleButton1;
        private System.Windows.Forms.Label lblDarktheme;
        private System.Windows.Forms.PictureBox pboptions;
        private MTcontrols.MTbutton.Button btnGenre;
        private MTcontrols.MTbutton.Button button1;
        private System.Windows.Forms.Panel Pnlabout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlYear;
        private System.Windows.Forms.GroupBox grpYear;
        private MTcontrols.MTradio.Radio radio4;
        private MTcontrols.MTradio.Radio radio3;
        private MTcontrols.MTradio.Radio radio2;
        private System.Windows.Forms.Label label2;
        private MTcontrols.MTradio.Radio radio7;
        private MTcontrols.MTradio.Radio radio5;
        private MTcontrols.MTbutton.Button btnconfirmyear;
    }
}

