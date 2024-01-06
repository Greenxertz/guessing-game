using Microsoft.Web.WebView2.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using static System.Net.WebRequestMethods;
using System.Runtime.CompilerServices;
using System.Data.SqlTypes;

namespace music
{
    public partial class Mainmenu : Form
    {
        public static string filepath = "songslist.txt";//change path on your computer
        public static bool maximise, options, about, year = false;
        public static int iyear;
        public static string URL;
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

        private void pboptions_Click(object sender, EventArgs e)
        {
            options = !options;
            if (options == true)
            {
                pboptions.Size = new System.Drawing.Size(70, 40);
                pnloptions.Size = new System.Drawing.Size(0, 644);
            }
            else
            {
                pboptions.Size = new System.Drawing.Size(160, 40);
                pnloptions.Size = new System.Drawing.Size(210, 644);
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
                Pnlabout.Visible = false;
            }
        }

        private void btnmin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

    

        private void btnYear_Click(object sender, EventArgs e)
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

        private void btnstart_Click(object sender, EventArgs e)
        {
            btnanswer.Enabled = true;
            btnstart.Enabled = false;
            btnstart.Visible = false;
        }

        private void btnconfirmyear_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
          
            switch (true)
            {
                case var _ when r80.Checked:
                    iyear = rnd.Next(1980, 1990);
                    break;
                case var _ when r90.Checked:
                    iyear = rnd.Next(1990, 2000);
                    break;
                case var _ when r2000.Checked:
                    iyear = rnd.Next(2000, 2010);
                    break;
                case var _ when r2010.Checked:
                    iyear = rnd.Next(2010, 2020);
                    break;
                case var _ when r2020.Checked:
                    iyear = rnd.Next(2020, DateTime.Now.Year); 
                    break;
                default:
                    iyear = rnd.Next(1990, DateTime.Now.Year);                   
                    break;
            }

            //spotify access token collected on login
            string accesstoken = Login.accesstoken;
            
            string apiURL = "https://api.spotify.com/v1/search?q=year%3A+"+ iyear.ToString() +"&type=track&market=sa&limit=10&include_external=audio";


            //  webView21.Source = new Uri("https://p.scdn.co/mp3-preview/80df2f56d0948b2c6d189de331dea8233582adaa?cid=60d4b70f0fff4bcc80d879385c17df64");

            songs(accesstoken, apiURL);

            pnlgame.Visible=true;
            pnlgame.BringToFront();


           }


        static async Task songs(string access, string url)
        {
            using (HttpClient client = new HttpClient())
            {
                // Set the Authorization header
                client.DefaultRequestHeaders.Add("Authorization", $"Bearer {access}");

                // Perform the HTTP GET request
                HttpResponseMessage response = await client.GetAsync(url);

                // Check if the request was successful (status code 200)
                if (response.IsSuccessStatusCode)
                {
                    // Read and print the response content
                    string content = await response.Content.ReadAsStringAsync();
                    file.WriteToFile(filepath, content);
                }
                else
                {
                    // Print an error message if the request was not successful
                    MessageBox.Show($"Error: {response.StatusCode} - {response.ReasonPhrase}");
                }
            }
        }

        class file
        {
            public static void WriteToFile(string filepath, string data)
            {
                try
                {
                    // Open the file with FileMode.Truncate to clear its contents
                    using (FileStream fileStream = new FileStream(filepath, FileMode.Truncate, FileAccess.Write))
                    {
                        // Truncate the file, effectively clearing its contents
                        fileStream.SetLength(0);
                    }                   
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }

                try
                {
                    using (StreamWriter file = System.IO.File.AppendText(filepath))
                    {                           
                        file.Write(data);                        
                    }
                }
                catch (IOException e)
                {
                    MessageBox.Show("Error: " + e.Message);
                }
            }
        }

    }

    
}
