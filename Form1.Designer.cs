﻿namespace music
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
            this.pnloptions = new System.Windows.Forms.Panel();
            this.lblDarktheme = new System.Windows.Forms.Label();
            this.Pnlabout = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlYear = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.grpYear = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlgame = new System.Windows.Forms.Panel();
            this.lblRound = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.webplayer = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grpAns = new System.Windows.Forms.GroupBox();
            this.btnstart = new MTcontrols.MTbutton.Button();
            this.btnanswer = new MTcontrols.MTbutton.Button();
            this.rans4 = new MTcontrols.MTradio.Radio();
            this.rans2 = new MTcontrols.MTradio.Radio();
            this.rans3 = new MTcontrols.MTradio.Radio();
            this.rans1 = new MTcontrols.MTradio.Radio();
            this.btnconfirmyear = new MTcontrols.MTbutton.Button();
            this.r2020 = new MTcontrols.MTradio.Radio();
            this.r2010 = new MTcontrols.MTradio.Radio();
            this.r2000 = new MTcontrols.MTradio.Radio();
            this.r90 = new MTcontrols.MTradio.Radio();
            this.r80 = new MTcontrols.MTradio.Radio();
            this.btnYear = new MTcontrols.MTbutton.Button();
            this.button1 = new MTcontrols.MTbutton.Button();
            this.toggleButton1 = new MTcontrols.MTtoggle.ToggleButton();
            this.btnmin = new MTcontrols.MTbutton.Button();
            this.btnmax = new MTcontrols.MTbutton.Button();
            this.btnclose = new MTcontrols.MTbutton.Button();
            this.txttest = new System.Windows.Forms.RichTextBox();
            this.pnlribbon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboptions)).BeginInit();
            this.pnloptions.SuspendLayout();
            this.Pnlabout.SuspendLayout();
            this.pnlYear.SuspendLayout();
            this.grpYear.SuspendLayout();
            this.pnlgame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webplayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grpAns.SuspendLayout();
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
            // pnloptions
            // 
            this.pnloptions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pnloptions.Controls.Add(this.btnYear);
            this.pnloptions.Controls.Add(this.button1);
            this.pnloptions.Controls.Add(this.lblDarktheme);
            this.pnloptions.Controls.Add(this.toggleButton1);
            this.pnloptions.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnloptions.Location = new System.Drawing.Point(0, 40);
            this.pnloptions.Name = "pnloptions";
            this.pnloptions.Size = new System.Drawing.Size(210, 644);
            this.pnloptions.TabIndex = 4;
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
            // Pnlabout
            // 
            this.Pnlabout.Controls.Add(this.label1);
            this.Pnlabout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pnlabout.Location = new System.Drawing.Point(210, 40);
            this.Pnlabout.Name = "Pnlabout";
            this.Pnlabout.Size = new System.Drawing.Size(940, 644);
            this.Pnlabout.TabIndex = 5;
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
            this.pnlYear.Controls.Add(this.label3);
            this.pnlYear.Controls.Add(this.btnconfirmyear);
            this.pnlYear.Controls.Add(this.grpYear);
            this.pnlYear.Controls.Add(this.label2);
            this.pnlYear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlYear.Location = new System.Drawing.Point(210, 40);
            this.pnlYear.Name = "pnlYear";
            this.pnlYear.Size = new System.Drawing.Size(940, 644);
            this.pnlYear.TabIndex = 6;
            this.pnlYear.Visible = false;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bauhaus 93", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(63, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(754, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "If a decade is not chosen then all years will be considered for the game.";
            // 
            // grpYear
            // 
            this.grpYear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.grpYear.Controls.Add(this.r2020);
            this.grpYear.Controls.Add(this.r2010);
            this.grpYear.Controls.Add(this.r2000);
            this.grpYear.Controls.Add(this.r90);
            this.grpYear.Controls.Add(this.r80);
            this.grpYear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpYear.Location = new System.Drawing.Point(366, 257);
            this.grpYear.Name = "grpYear";
            this.grpYear.Size = new System.Drawing.Size(122, 159);
            this.grpYear.TabIndex = 1;
            this.grpYear.TabStop = false;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bauhaus 93", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(244, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(375, 48);
            this.label2.TabIndex = 0;
            this.label2.Text = "How good are you? \r\nChoose the decade you wanna try: ";
            // 
            // pnlgame
            // 
            this.pnlgame.Controls.Add(this.txttest);
            this.pnlgame.Controls.Add(this.lblRound);
            this.pnlgame.Controls.Add(this.btnstart);
            this.pnlgame.Controls.Add(this.label7);
            this.pnlgame.Controls.Add(this.label6);
            this.pnlgame.Controls.Add(this.label5);
            this.pnlgame.Controls.Add(this.label4);
            this.pnlgame.Controls.Add(this.webplayer);
            this.pnlgame.Controls.Add(this.btnanswer);
            this.pnlgame.Controls.Add(this.pictureBox1);
            this.pnlgame.Controls.Add(this.grpAns);
            this.pnlgame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlgame.Location = new System.Drawing.Point(210, 40);
            this.pnlgame.Name = "pnlgame";
            this.pnlgame.Size = new System.Drawing.Size(940, 644);
            this.pnlgame.TabIndex = 7;
            this.pnlgame.Visible = false;
            // 
            // lblRound
            // 
            this.lblRound.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRound.AutoSize = true;
            this.lblRound.Font = new System.Drawing.Font("Bauhaus 93", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRound.Location = new System.Drawing.Point(379, 57);
            this.lblRound.Name = "lblRound";
            this.lblRound.Size = new System.Drawing.Size(119, 30);
            this.lblRound.TabIndex = 11;
            this.lblRound.Text = "Round 1";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bauhaus 93", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(172, 404);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 24);
            this.label7.TabIndex = 9;
            this.label7.Text = "00:30";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bauhaus 93", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(90, 380);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 48);
            this.label6.TabIndex = 8;
            this.label6.Text = "Score:\r\nTime:";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bauhaus 93", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(172, 380);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 24);
            this.label5.TabIndex = 7;
            this.label5.Text = "00:30";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bauhaus 93", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(63, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(754, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "If a decade is not chosen then all years will be considered for the game.";
            // 
            // webplayer
            // 
            this.webplayer.AllowExternalDrop = true;
            this.webplayer.CreationProperties = null;
            this.webplayer.DefaultBackgroundColor = System.Drawing.Color.Transparent;
            this.webplayer.Location = new System.Drawing.Point(67, 92);
            this.webplayer.Name = "webplayer";
            this.webplayer.Size = new System.Drawing.Size(293, 259);
            this.webplayer.TabIndex = 3;
            this.webplayer.ZoomFactor = 1D;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(570, 92);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(247, 288);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // grpAns
            // 
            this.grpAns.Controls.Add(this.rans4);
            this.grpAns.Controls.Add(this.rans2);
            this.grpAns.Controls.Add(this.rans3);
            this.grpAns.Controls.Add(this.rans1);
            this.grpAns.Font = new System.Drawing.Font("Bauhaus 93", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpAns.Location = new System.Drawing.Point(176, 439);
            this.grpAns.Name = "grpAns";
            this.grpAns.Size = new System.Drawing.Size(578, 100);
            this.grpAns.TabIndex = 0;
            this.grpAns.TabStop = false;
            this.grpAns.Text = "Whats your answer?";
            // 
            // btnstart
            // 
            this.btnstart.BackColor = System.Drawing.Color.DimGray;
            this.btnstart.BackgroundColor = System.Drawing.Color.DimGray;
            this.btnstart.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnstart.BorderRadius = 20;
            this.btnstart.BorderSize = 0;
            this.btnstart.FlatAppearance.BorderSize = 0;
            this.btnstart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnstart.ForeColor = System.Drawing.Color.White;
            this.btnstart.Location = new System.Drawing.Point(366, 558);
            this.btnstart.Name = "btnstart";
            this.btnstart.Size = new System.Drawing.Size(150, 40);
            this.btnstart.TabIndex = 10;
            this.btnstart.Text = "Start";
            this.btnstart.TextColor = System.Drawing.Color.White;
            this.btnstart.UseVisualStyleBackColor = false;
            this.btnstart.Click += new System.EventHandler(this.btnstart_Click);
            // 
            // btnanswer
            // 
            this.btnanswer.BackColor = System.Drawing.Color.DimGray;
            this.btnanswer.BackgroundColor = System.Drawing.Color.DimGray;
            this.btnanswer.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnanswer.BorderRadius = 20;
            this.btnanswer.BorderSize = 0;
            this.btnanswer.Enabled = false;
            this.btnanswer.FlatAppearance.BorderSize = 0;
            this.btnanswer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnanswer.ForeColor = System.Drawing.Color.White;
            this.btnanswer.Location = new System.Drawing.Point(366, 558);
            this.btnanswer.Name = "btnanswer";
            this.btnanswer.Size = new System.Drawing.Size(150, 40);
            this.btnanswer.TabIndex = 2;
            this.btnanswer.Text = "Lock in Answer";
            this.btnanswer.TextColor = System.Drawing.Color.White;
            this.btnanswer.UseVisualStyleBackColor = false;
            // 
            // rans4
            // 
            this.rans4.AutoSize = true;
            this.rans4.CheckedColor = System.Drawing.Color.MediumSlateBlue;
            this.rans4.Location = new System.Drawing.Point(449, 40);
            this.rans4.MinimumSize = new System.Drawing.Size(0, 21);
            this.rans4.Name = "rans4";
            this.rans4.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.rans4.Size = new System.Drawing.Size(79, 21);
            this.rans4.TabIndex = 3;
            this.rans4.TabStop = true;
            this.rans4.Text = "radio4";
            this.rans4.UnCheckedColor = System.Drawing.Color.Gray;
            this.rans4.UseVisualStyleBackColor = true;
            // 
            // rans2
            // 
            this.rans2.AutoSize = true;
            this.rans2.CheckedColor = System.Drawing.Color.MediumSlateBlue;
            this.rans2.Location = new System.Drawing.Point(174, 40);
            this.rans2.MinimumSize = new System.Drawing.Size(0, 21);
            this.rans2.Name = "rans2";
            this.rans2.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.rans2.Size = new System.Drawing.Size(79, 21);
            this.rans2.TabIndex = 2;
            this.rans2.TabStop = true;
            this.rans2.Text = "radio3";
            this.rans2.UnCheckedColor = System.Drawing.Color.Gray;
            this.rans2.UseVisualStyleBackColor = true;
            // 
            // rans3
            // 
            this.rans3.AutoSize = true;
            this.rans3.CheckedColor = System.Drawing.Color.MediumSlateBlue;
            this.rans3.Location = new System.Drawing.Point(314, 40);
            this.rans3.MinimumSize = new System.Drawing.Size(0, 21);
            this.rans3.Name = "rans3";
            this.rans3.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.rans3.Size = new System.Drawing.Size(79, 21);
            this.rans3.TabIndex = 1;
            this.rans3.TabStop = true;
            this.rans3.Text = "radio2";
            this.rans3.UnCheckedColor = System.Drawing.Color.Gray;
            this.rans3.UseVisualStyleBackColor = true;
            // 
            // rans1
            // 
            this.rans1.AutoSize = true;
            this.rans1.CheckedColor = System.Drawing.Color.MediumSlateBlue;
            this.rans1.Location = new System.Drawing.Point(43, 40);
            this.rans1.MinimumSize = new System.Drawing.Size(0, 21);
            this.rans1.Name = "rans1";
            this.rans1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.rans1.Size = new System.Drawing.Size(79, 21);
            this.rans1.TabIndex = 0;
            this.rans1.TabStop = true;
            this.rans1.Text = "radio1";
            this.rans1.UnCheckedColor = System.Drawing.Color.Gray;
            this.rans1.UseVisualStyleBackColor = true;
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
            this.btnconfirmyear.Location = new System.Drawing.Point(329, 474);
            this.btnconfirmyear.Name = "btnconfirmyear";
            this.btnconfirmyear.Size = new System.Drawing.Size(193, 65);
            this.btnconfirmyear.TabIndex = 3;
            this.btnconfirmyear.Text = "Start";
            this.btnconfirmyear.TextColor = System.Drawing.Color.White;
            this.btnconfirmyear.UseVisualStyleBackColor = false;
            this.btnconfirmyear.Click += new System.EventHandler(this.btnconfirmyear_Click);
            // 
            // r2020
            // 
            this.r2020.AutoSize = true;
            this.r2020.CheckedColor = System.Drawing.Color.DimGray;
            this.r2020.Location = new System.Drawing.Point(29, 127);
            this.r2020.MinimumSize = new System.Drawing.Size(0, 21);
            this.r2020.Name = "r2020";
            this.r2020.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.r2020.Size = new System.Drawing.Size(66, 21);
            this.r2020.TabIndex = 6;
            this.r2020.TabStop = true;
            this.r2020.Text = "2020\'s";
            this.r2020.UnCheckedColor = System.Drawing.Color.DarkSlateGray;
            this.r2020.UseVisualStyleBackColor = true;
            // 
            // r2010
            // 
            this.r2010.AutoSize = true;
            this.r2010.CheckedColor = System.Drawing.Color.DimGray;
            this.r2010.Location = new System.Drawing.Point(29, 100);
            this.r2010.MinimumSize = new System.Drawing.Size(0, 21);
            this.r2010.Name = "r2010";
            this.r2010.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.r2010.Size = new System.Drawing.Size(66, 21);
            this.r2010.TabIndex = 4;
            this.r2010.TabStop = true;
            this.r2010.Text = "2010\'s";
            this.r2010.UnCheckedColor = System.Drawing.Color.DarkSlateGray;
            this.r2010.UseVisualStyleBackColor = true;
            // 
            // r2000
            // 
            this.r2000.AutoSize = true;
            this.r2000.CheckedColor = System.Drawing.Color.DimGray;
            this.r2000.Location = new System.Drawing.Point(29, 73);
            this.r2000.MinimumSize = new System.Drawing.Size(0, 21);
            this.r2000.Name = "r2000";
            this.r2000.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.r2000.Size = new System.Drawing.Size(66, 21);
            this.r2000.TabIndex = 3;
            this.r2000.TabStop = true;
            this.r2000.Text = "2000\'s";
            this.r2000.UnCheckedColor = System.Drawing.Color.DarkSlateGray;
            this.r2000.UseVisualStyleBackColor = true;
            // 
            // r90
            // 
            this.r90.AutoSize = true;
            this.r90.CheckedColor = System.Drawing.Color.DimGray;
            this.r90.Location = new System.Drawing.Point(29, 46);
            this.r90.MinimumSize = new System.Drawing.Size(0, 21);
            this.r90.Name = "r90";
            this.r90.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.r90.Size = new System.Drawing.Size(54, 21);
            this.r90.TabIndex = 2;
            this.r90.TabStop = true;
            this.r90.Text = "90\'s";
            this.r90.UnCheckedColor = System.Drawing.Color.DarkSlateGray;
            this.r90.UseVisualStyleBackColor = true;
            // 
            // r80
            // 
            this.r80.AutoSize = true;
            this.r80.CheckedColor = System.Drawing.Color.DimGray;
            this.r80.Location = new System.Drawing.Point(29, 19);
            this.r80.MinimumSize = new System.Drawing.Size(0, 21);
            this.r80.Name = "r80";
            this.r80.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.r80.Size = new System.Drawing.Size(52, 21);
            this.r80.TabIndex = 1;
            this.r80.TabStop = true;
            this.r80.Text = "80s";
            this.r80.UnCheckedColor = System.Drawing.Color.DarkSlateGray;
            this.r80.UseVisualStyleBackColor = true;
            // 
            // btnYear
            // 
            this.btnYear.BackColor = System.Drawing.Color.DimGray;
            this.btnYear.BackgroundColor = System.Drawing.Color.DimGray;
            this.btnYear.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnYear.BorderRadius = 20;
            this.btnYear.BorderSize = 0;
            this.btnYear.FlatAppearance.BorderSize = 0;
            this.btnYear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYear.ForeColor = System.Drawing.Color.White;
            this.btnYear.Location = new System.Drawing.Point(27, 139);
            this.btnYear.Name = "btnYear";
            this.btnYear.Size = new System.Drawing.Size(157, 40);
            this.btnYear.TabIndex = 4;
            this.btnYear.Text = "Game Mode: Year";
            this.btnYear.TextColor = System.Drawing.Color.White;
            this.btnYear.UseVisualStyleBackColor = false;
            this.btnYear.Click += new System.EventHandler(this.btnYear_Click);
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
            // txttest
            // 
            this.txttest.Location = new System.Drawing.Point(111, 104);
            this.txttest.Name = "txttest";
            this.txttest.Size = new System.Drawing.Size(619, 429);
            this.txttest.TabIndex = 5;
            this.txttest.Text = "";
            // 
            // Mainmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DarkTurquoise;
            this.ClientSize = new System.Drawing.Size(1150, 684);
            this.ControlBox = false;
            this.Controls.Add(this.pnlgame);
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
            this.pnlgame.ResumeLayout(false);
            this.pnlgame.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webplayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grpAns.ResumeLayout(false);
            this.grpAns.PerformLayout();
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
        private MTcontrols.MTbutton.Button btnYear;
        private MTcontrols.MTbutton.Button button1;
        private System.Windows.Forms.Panel Pnlabout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlYear;
        private System.Windows.Forms.GroupBox grpYear;
        private MTcontrols.MTradio.Radio r2000;
        private MTcontrols.MTradio.Radio r90;
        private MTcontrols.MTradio.Radio r80;
        private System.Windows.Forms.Label label2;
        private MTcontrols.MTradio.Radio r2020;
        private MTcontrols.MTradio.Radio r2010;
        private MTcontrols.MTbutton.Button btnconfirmyear;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnlgame;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private Microsoft.Web.WebView2.WinForms.WebView2 webplayer;
        private MTcontrols.MTbutton.Button btnanswer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox grpAns;
        private MTcontrols.MTradio.Radio rans4;
        private MTcontrols.MTradio.Radio rans2;
        private MTcontrols.MTradio.Radio rans3;
        private MTcontrols.MTradio.Radio rans1;
        private MTcontrols.MTbutton.Button btnstart;
        private System.Windows.Forms.Label lblRound;
        private System.Windows.Forms.RichTextBox txttest;
    }
}

