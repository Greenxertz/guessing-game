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
            this.btnmin = new MTcontrols.MTbutton.Button();
            this.btnmax = new MTcontrols.MTbutton.Button();
            this.btnclose = new MTcontrols.MTbutton.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.invalidemail = new System.Windows.Forms.Label();
            this.btncancel = new MTcontrols.MTbutton.Button();
            this.btnlogin = new MTcontrols.MTbutton.Button();
            this.pnlribbon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bauhaus 93", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(63, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(461, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "You will need a Spotify account to continue so i would recommend making one.\r\n";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(108, 306);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(355, 20);
            this.txtemail.TabIndex = 8;
            this.txtemail.TextChanged += new System.EventHandler(this.txtemail_TextChanged);
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(108, 345);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(355, 20);
            this.txtpassword.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(127, 81);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(317, 203);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bauhaus 93", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 311);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "Email:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bauhaus 93", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(36, 350);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Password:";
            // 
            // invalidemail
            // 
            this.invalidemail.AutoSize = true;
            this.invalidemail.Font = new System.Drawing.Font("Bauhaus 93", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invalidemail.Location = new System.Drawing.Point(105, 288);
            this.invalidemail.Name = "invalidemail";
            this.invalidemail.Size = new System.Drawing.Size(44, 15);
            this.invalidemail.TabIndex = 13;
            this.invalidemail.Text = "Email:";
            this.invalidemail.Visible = false;
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
            this.btncancel.Location = new System.Drawing.Point(313, 382);
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
            this.btnlogin.Location = new System.Drawing.Point(108, 382);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(150, 40);
            this.btnlogin.TabIndex = 6;
            this.btnlogin.Text = "Login";
            this.btnlogin.TextColor = System.Drawing.Color.White;
            this.btnlogin.UseVisualStyleBackColor = false;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkTurquoise;
            this.ClientSize = new System.Drawing.Size(564, 459);
            this.Controls.Add(this.invalidemail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pnlribbon);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.Text = "Login";
            this.pnlribbon.ResumeLayout(false);
            this.pnlribbon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlribbon;
        private MTcontrols.MTbutton.Button btnmin;
        private MTcontrols.MTbutton.Button btnmax;
        private MTcontrols.MTbutton.Button btnclose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private MTcontrols.MTbutton.Button btnlogin;
        private MTcontrols.MTbutton.Button btncancel;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label invalidemail;
    }
}