namespace music
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.pnlribbon = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblinvalidformat = new System.Windows.Forms.Label();
            this.lblsignup = new System.Windows.Forms.Label();
            this.pnlSignup = new System.Windows.Forms.Panel();
            this.lblInvalidPass = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtConfirmPass = new System.Windows.Forms.TextBox();
            this.lblInvalidEmail = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSignPass = new System.Windows.Forms.TextBox();
            this.txtSignEmail = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btncancel2 = new MTcontrols.MTbutton.Button();
            this.btnSignup = new MTcontrols.MTbutton.Button();
            this.btncancel = new MTcontrols.MTbutton.Button();
            this.btnlogin = new MTcontrols.MTbutton.Button();
            this.btnmin = new MTcontrols.MTbutton.Button();
            this.btnmax = new MTcontrols.MTbutton.Button();
            this.btnclose = new MTcontrols.MTbutton.Button();
            this.pnlribbon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlSignup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlribbon
            // 
            this.pnlribbon.BackColor = System.Drawing.Color.Teal;
            this.pnlribbon.Controls.Add(this.label1);
            this.pnlribbon.Controls.Add(this.btnmin);
            this.pnlribbon.Controls.Add(this.btnmax);
            this.pnlribbon.Controls.Add(this.btnclose);
            this.pnlribbon.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlribbon.Location = new System.Drawing.Point(0, 0);
            this.pnlribbon.Name = "pnlribbon";
            this.pnlribbon.Size = new System.Drawing.Size(564, 40);
            this.pnlribbon.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bauhaus 93", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(123, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Welcome to guess the song!";
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(110, 274);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(355, 20);
            this.txtemail.TabIndex = 8;
            this.txtemail.TextChanged += new System.EventHandler(this.txtemail_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(127, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(317, 203);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bauhaus 93", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 279);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "Email:";
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(110, 313);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(355, 20);
            this.txtpassword.TabIndex = 9;
            this.txtpassword.TextChanged += new System.EventHandler(this.txtpassword_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bauhaus 93", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(38, 318);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Password:";
            // 
            // lblinvalidformat
            // 
            this.lblinvalidformat.AutoSize = true;
            this.lblinvalidformat.Font = new System.Drawing.Font("Bauhaus 93", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblinvalidformat.Location = new System.Drawing.Point(107, 256);
            this.lblinvalidformat.Name = "lblinvalidformat";
            this.lblinvalidformat.Size = new System.Drawing.Size(154, 15);
            this.lblinvalidformat.TabIndex = 13;
            this.lblinvalidformat.Text = "Email is in invalid format!";
            this.lblinvalidformat.Visible = false;
            // 
            // lblsignup
            // 
            this.lblsignup.AutoSize = true;
            this.lblsignup.Font = new System.Drawing.Font("Bauhaus 93", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsignup.Location = new System.Drawing.Point(191, 402);
            this.lblsignup.Name = "lblsignup";
            this.lblsignup.Size = new System.Drawing.Size(185, 15);
            this.lblsignup.TabIndex = 14;
            this.lblsignup.Text = "First time playing? Sign up here";
            this.lblsignup.Click += new System.EventHandler(this.lblsignup_Click);
            // 
            // pnlSignup
            // 
            this.pnlSignup.Controls.Add(this.lblInvalidPass);
            this.pnlSignup.Controls.Add(this.label7);
            this.pnlSignup.Controls.Add(this.txtConfirmPass);
            this.pnlSignup.Controls.Add(this.lblInvalidEmail);
            this.pnlSignup.Controls.Add(this.label5);
            this.pnlSignup.Controls.Add(this.label6);
            this.pnlSignup.Controls.Add(this.txtSignPass);
            this.pnlSignup.Controls.Add(this.txtSignEmail);
            this.pnlSignup.Controls.Add(this.btncancel2);
            this.pnlSignup.Controls.Add(this.btnSignup);
            this.pnlSignup.Controls.Add(this.pictureBox2);
            this.pnlSignup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSignup.Location = new System.Drawing.Point(0, 40);
            this.pnlSignup.Name = "pnlSignup";
            this.pnlSignup.Size = new System.Drawing.Size(564, 419);
            this.pnlSignup.TabIndex = 15;
            this.pnlSignup.Visible = false;
            // 
            // lblInvalidPass
            // 
            this.lblInvalidPass.AutoSize = true;
            this.lblInvalidPass.Font = new System.Drawing.Font("Bauhaus 93", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvalidPass.Location = new System.Drawing.Point(297, 311);
            this.lblInvalidPass.Name = "lblInvalidPass";
            this.lblInvalidPass.Size = new System.Drawing.Size(156, 15);
            this.lblInvalidPass.TabIndex = 23;
            this.lblInvalidPass.Text = "Passwords do not match!!";
            this.lblInvalidPass.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bauhaus 93", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(125, 311);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 15);
            this.label7.TabIndex = 22;
            this.label7.Text = "Confirm Password:";
            // 
            // txtConfirmPass
            // 
            this.txtConfirmPass.Location = new System.Drawing.Point(128, 331);
            this.txtConfirmPass.Name = "txtConfirmPass";
            this.txtConfirmPass.Size = new System.Drawing.Size(325, 20);
            this.txtConfirmPass.TabIndex = 21;
            this.txtConfirmPass.TextChanged += new System.EventHandler(this.txtConfirmPass_TextChanged);
            // 
            // lblInvalidEmail
            // 
            this.lblInvalidEmail.AutoSize = true;
            this.lblInvalidEmail.Font = new System.Drawing.Font("Bauhaus 93", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvalidEmail.Location = new System.Drawing.Point(298, 229);
            this.lblInvalidEmail.Name = "lblInvalidEmail";
            this.lblInvalidEmail.Size = new System.Drawing.Size(154, 15);
            this.lblInvalidEmail.TabIndex = 20;
            this.lblInvalidEmail.Text = "Email is in invalid format!";
            this.lblInvalidEmail.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bauhaus 93", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(124, 270);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 15);
            this.label5.TabIndex = 19;
            this.label5.Text = "Password:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bauhaus 93", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(124, 229);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 15);
            this.label6.TabIndex = 18;
            this.label6.Text = "Email:";
            // 
            // txtSignPass
            // 
            this.txtSignPass.Location = new System.Drawing.Point(128, 288);
            this.txtSignPass.Name = "txtSignPass";
            this.txtSignPass.Size = new System.Drawing.Size(326, 20);
            this.txtSignPass.TabIndex = 17;
            this.txtSignPass.TextChanged += new System.EventHandler(this.txtSignPass_TextChanged);
            // 
            // txtSignEmail
            // 
            this.txtSignEmail.Location = new System.Drawing.Point(127, 247);
            this.txtSignEmail.Name = "txtSignEmail";
            this.txtSignEmail.Size = new System.Drawing.Size(325, 20);
            this.txtSignEmail.TabIndex = 16;
            this.txtSignEmail.TextChanged += new System.EventHandler(this.txtSignEmail_TextChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(110, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(354, 228);
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // btncancel2
            // 
            this.btncancel2.BackColor = System.Drawing.Color.DimGray;
            this.btncancel2.BackgroundColor = System.Drawing.Color.DimGray;
            this.btncancel2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btncancel2.BorderRadius = 20;
            this.btncancel2.BorderSize = 0;
            this.btncancel2.FlatAppearance.BorderSize = 0;
            this.btncancel2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncancel2.Font = new System.Drawing.Font("Bauhaus 93", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancel2.ForeColor = System.Drawing.Color.White;
            this.btncancel2.Location = new System.Drawing.Point(315, 362);
            this.btncancel2.Name = "btncancel2";
            this.btncancel2.Size = new System.Drawing.Size(150, 40);
            this.btncancel2.TabIndex = 15;
            this.btncancel2.Text = "Cancel";
            this.btncancel2.TextColor = System.Drawing.Color.White;
            this.btncancel2.UseVisualStyleBackColor = false;
            this.btncancel2.Click += new System.EventHandler(this.btncancel2_Click);
            // 
            // btnSignup
            // 
            this.btnSignup.BackColor = System.Drawing.Color.DimGray;
            this.btnSignup.BackgroundColor = System.Drawing.Color.DimGray;
            this.btnSignup.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnSignup.BorderRadius = 20;
            this.btnSignup.BorderSize = 0;
            this.btnSignup.Enabled = false;
            this.btnSignup.FlatAppearance.BorderSize = 0;
            this.btnSignup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignup.Font = new System.Drawing.Font("Bauhaus 93", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignup.ForeColor = System.Drawing.Color.White;
            this.btnSignup.Location = new System.Drawing.Point(111, 362);
            this.btnSignup.Name = "btnSignup";
            this.btnSignup.Size = new System.Drawing.Size(150, 40);
            this.btnSignup.TabIndex = 14;
            this.btnSignup.Text = "Sign Up";
            this.btnSignup.TextColor = System.Drawing.Color.White;
            this.btnSignup.UseVisualStyleBackColor = false;
            this.btnSignup.Click += new System.EventHandler(this.btnSignup_Click);
            // 
            // btncancel
            // 
            this.btncancel.BackColor = System.Drawing.Color.DimGray;
            this.btncancel.BackgroundColor = System.Drawing.Color.DimGray;
            this.btncancel.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btncancel.BorderRadius = 20;
            this.btncancel.BorderSize = 0;
            this.btncancel.FlatAppearance.BorderSize = 0;
            this.btncancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncancel.Font = new System.Drawing.Font("Bauhaus 93", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancel.ForeColor = System.Drawing.Color.White;
            this.btncancel.Location = new System.Drawing.Point(315, 350);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(150, 40);
            this.btncancel.TabIndex = 7;
            this.btncancel.Text = "Cancel";
            this.btncancel.TextColor = System.Drawing.Color.White;
            this.btncancel.UseVisualStyleBackColor = false;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // btnlogin
            // 
            this.btnlogin.BackColor = System.Drawing.Color.DimGray;
            this.btnlogin.BackgroundColor = System.Drawing.Color.DimGray;
            this.btnlogin.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnlogin.BorderRadius = 20;
            this.btnlogin.BorderSize = 0;
            this.btnlogin.Enabled = false;
            this.btnlogin.FlatAppearance.BorderSize = 0;
            this.btnlogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlogin.Font = new System.Drawing.Font("Bauhaus 93", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogin.ForeColor = System.Drawing.Color.White;
            this.btnlogin.Location = new System.Drawing.Point(110, 350);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(150, 40);
            this.btnlogin.TabIndex = 6;
            this.btnlogin.Text = "Login";
            this.btnlogin.TextColor = System.Drawing.Color.White;
            this.btnlogin.UseVisualStyleBackColor = false;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
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
            this.btnmin.Location = new System.Drawing.Point(444, 0);
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
            this.btnmax.Location = new System.Drawing.Point(484, 0);
            this.btnmax.Name = "btnmax";
            this.btnmax.Size = new System.Drawing.Size(40, 40);
            this.btnmax.TabIndex = 0;
            this.btnmax.TextColor = System.Drawing.Color.White;
            this.btnmax.UseVisualStyleBackColor = false;
            this.btnmax.Click += new System.EventHandler(this.btnmax_Click);
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
            this.btnclose.Location = new System.Drawing.Point(524, 0);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(40, 40);
            this.btnclose.TabIndex = 1;
            this.btnclose.Text = "X";
            this.btnclose.TextColor = System.Drawing.Color.Black;
            this.btnclose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnclose.UseVisualStyleBackColor = false;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkTurquoise;
            this.ClientSize = new System.Drawing.Size(564, 459);
            this.Controls.Add(this.pnlSignup);
            this.Controls.Add(this.lblsignup);
            this.Controls.Add(this.lblinvalidformat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.pnlribbon);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.Text = "Login";
            this.pnlribbon.ResumeLayout(false);
            this.pnlribbon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlSignup.ResumeLayout(false);
            this.pnlSignup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlribbon;
        private MTcontrols.MTbutton.Button btnmin;
        private MTcontrols.MTbutton.Button btnmax;
        private MTcontrols.MTbutton.Button btnclose;
        private System.Windows.Forms.Label label1;
        private MTcontrols.MTbutton.Button btnlogin;
        private MTcontrols.MTbutton.Button btncancel;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblinvalidformat;
        private System.Windows.Forms.Label lblsignup;
        private System.Windows.Forms.Panel pnlSignup;
        private System.Windows.Forms.Label lblInvalidEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSignPass;
        private System.Windows.Forms.TextBox txtSignEmail;
        private MTcontrols.MTbutton.Button btncancel2;
        private MTcontrols.MTbutton.Button btnSignup;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblInvalidPass;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtConfirmPass;
    }
}