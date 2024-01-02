using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace music
{
    public partial class Mainmenu : Form
    {
        public static bool maximise, options, about, year = false;
        public Mainmenu()
        {
            Login login = new Login();
            login.ShowDialog();
            this.Hide();
            InitializeComponent();
            

        }

        private void toggleButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (toggleButton1.Checked == true)
            {
                pnloptions.BackColor = SystemColors.WindowFrame;
                pnlribbon.BackColor = Color.FromArgb(64, 64, 64); ;
                this.BackColor = Color.DarkGray;
                lblDarktheme.ForeColor = Color.Snow;
            }
            else
            {
                pnloptions.BackColor = Color.PaleTurquoise;
                pnlribbon.BackColor = Color.Teal;
                this.BackColor = Color.DarkTurquoise;
                lblDarktheme.ForeColor = Color.Black ;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

            maximise = !maximise;
            if (maximise == true)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnmin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radio6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radio2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pnlYear_Paint(object sender, PaintEventArgs e)
        {

        }

        private void year_Click(object sender, EventArgs e)
        {
            year = !year;
            if (year == true)
            {
                pnlYear.BringToFront();
                pnlYear.Visible = true;
                about = false;
            }
            else
            {
                pnlYear.Visible = false;
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            about = !about;
            if (about == true)
            {
                Pnlabout.BringToFront();
                Pnlabout.Visible = true;
               year = false;
            }
            else
            {
                Pnlabout.Visible=false;
            }
        }

        private void pboptions_Click(object sender, EventArgs e)
        {
            options = !options;
            if (options == true)
            {
                pboptions.Size = new System.Drawing.Size(70, 40);
                pnloptions.Size = new System.Drawing.Size(0,644);
            }
            else
            {
                pboptions.Size = new System.Drawing.Size(160, 40);
                pnloptions.Size = new System.Drawing.Size(210, 644);
            } 
        }
    }
}
