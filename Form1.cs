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
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.Diagnostics.PerformanceData;
using System.Net.NetworkInformation;
using System.Threading;


namespace music
{
    public partial class Mainmenu : Form
    {
        public static bool maximise, options, about, year = false;
        public static int iyear, iscore;    
        public static getsong[,] Songs = new getsong[20, 1];
        public static List<getsong> songsList = new List<getsong>();
        private System.Timers.Timer quizTimer;
        private int elapsedTimeInSeconds;
        
       
        public class getsong
        {
            public string Image { get; set; }
            public string Artist { get; set; }
            public string track { get; set; }
            public string PreviewLink { get; set; }
        }


        public Mainmenu()
        {
            Login login = new Login();
            login.ShowDialog();
            this.Hide();
            InitializeComponent();
            quizTimer = new System.Timers.Timer();
            quizTimer.Interval = 1000; 
            quizTimer.Elapsed += QuizTimerElapsed;
            elapsedTimeInSeconds = 0;
        }

        private void QuizTimerElapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            // Update the elapsed time (in seconds)
            elapsedTimeInSeconds++;
            int minutes = elapsedTimeInSeconds / 60;
            int seconds = elapsedTimeInSeconds % 60;

            this.Invoke((MethodInvoker)delegate
            {
                // Update a label or any other UI element to display the elapsed time
                lbltime.Text = $"{minutes:D2}:{seconds:D2}";
            });
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

        public void SelectRandomSongs()
        {
            Random random = new Random();

            // Shuffle the songsList using Fisher-Yates algorithm
            int n = songsList.Count;
            while (n > 1)
            {
                n--;
                int k = random.Next(n + 1);
                var value = songsList[k];
                songsList[k] = songsList[n];
                songsList[n] = value;
            }

            // Take the first 10 elements as random songs
            List<getsong> randomSongs = songsList.Take(10).ToList();

            // Now 'randomSongs' contains 10 randomly selected songs from 'songsList'
            // You can use this list as needed.
            startquiz(randomSongs);

        }

        public async void startquiz(List<getsong> randomsongs)
        {
            var buttonanswer = new TaskCompletionSource<bool>();
            quizTimer.Start();
            // Attach an event handler to the button's click event
            EventHandler buttonClickHandler = (s, args) => buttonanswer.TrySetResult(true);
            btnanswer.Click += buttonClickHandler;

            Random random = new Random();
            int[] pos = new int[4];
            int icount = 1;
            iscore = 0;
            updatecontrols(icount,"" , randomsongs.Count);

            foreach (getsong songs in randomsongs)
            {
                icount++;
               
                webplayer.Source = new Uri(songs.PreviewLink);
                testtxt2.Text = songs.Artist;
                

                List<getsong> otherSongs = randomsongs.Where(song => song != songs).ToList();
                List<getsong> selectedSongs = new List<getsong> { songs };

                List<string> allArtists = otherSongs.Select(song => song.Artist).ToList();

                // Shuffle the list of all available artists
                allArtists = allArtists.OrderBy(artist => random.Next()).ToList();

                // Select the first three unique artists for incorrect answers
                for (int i = 0; i < 3; i++)
                {
                    // Make sure the artist is unique
                    string uniqueArtist = allArtists.FirstOrDefault(artist => !selectedSongs.Select(selectedSong => selectedSong.Artist).Contains(artist));

                    if (uniqueArtist != null)
                    {
                        // Add the song with the unique artist to the selectedSongs list
                        selectedSongs.Add(otherSongs.First(song => song.Artist == uniqueArtist));
                    }
                    else
                    {
                        throw new Exception(uniqueArtist + " produced to many songs in quiz", new ArgumentException("Duplicate artist names in quiz."));
                    }
                }

                // Shuffle the selected songs
                selectedSongs = selectedSongs.OrderBy(song => random.Next()).ToList();

                // Loop through the positions and assign the artist to the corresponding radio button
                for (int i = 0; i < selectedSongs.Count; i++)
                {
                    switch (i)
                    {
                        case 0:
                            rans1.Text = selectedSongs[i].Artist;
                            break;
                        case 1:
                            rans2.Text = selectedSongs[i].Artist;
                            break;
                        case 2:
                            rans3.Text = selectedSongs[i].Artist;
                            break;
                        case 3:
                            rans4.Text = selectedSongs[i].Artist;
                            break;
                        default:
                           
                            break;
                    }
                }

             


                await buttonanswer.Task;                        //keep these together 
                buttonanswer = new TaskCompletionSource<bool>();//
                updatecontrols(icount, songs.Artist, randomsongs.Count);
            }

            btnanswer.Click -= buttonClickHandler;
            quizTimer.Stop();
        }


        private void updatecontrols(int icount, string artist, int songcount)
        {
            if (lblRound.Text != "Round 10" )
                lblRound.Text = "Round " + icount.ToString();
            else
                lblRound.Text = "Game Done!!!";

            foreach (Control control in grpAns.Controls)
            {
               
                if ( control is RadioButton radiobutton)
                {
                    if (radiobutton.Text == artist && radiobutton.Checked)
                        iscore++;
                    radiobutton.Checked = false;
                }

            }
            lblscore.Text = iscore.ToString() + " / " + songcount.ToString() ;

        }

        public void writetorich()
        {

            StringBuilder sb = new StringBuilder();

            testtxt.Clear();
            foreach (var currentSong in songsList)
            {
                sb.AppendLine($"Image: {currentSong.Image}");
                sb.AppendLine($"Artist: {currentSong.Artist}");
                sb.AppendLine($"song: {currentSong.track}");
                sb.AppendLine($"Preview Link: {currentSong.PreviewLink}");
                sb.AppendLine();
            }           
            testtxt.Text = sb.ToString();
        } 

        private bool IsHyperlinkSelected(int selectionStart, int selectionLength)
        {
            // You can implement your logic to determine if the selected text is within a hyperlink.
            // This might involve checking the formatting or any other criteria based on your application.

            // For demonstration purposes, let's assume that a hyperlink is denoted by square brackets.
            string text = testtxt.Text.Substring(selectionStart, selectionLength);
            return text.Contains("[") && text.Contains("]");
        }

        private void testtxt_DoubleClick(object sender, EventArgs e)
        {

            int selectionStart = testtxt.SelectionStart;
            int selectionLength = testtxt.SelectionLength;

            
            if (selectionLength > 0)
            {
                string selectedText = testtxt.Text.Substring(selectionStart, selectionLength);

                if (IsHyperlinkSelected(selectionStart, selectionLength))
                {
                    webplayer.Source = new Uri(selectedText);
                }
                else
                {                   
                    webplayer.Source = new Uri(selectedText);
                }

            }
        }

        private void btnanswer_Click(object sender, EventArgs e)
        {

        }


        private async void btnconfirmyear_Click(object sender, EventArgs e)
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
            
            string apiURL = "https://api.spotify.com/v1/search?q=year%3A+"+ iyear.ToString() +"&type=track&market=sa&limit=20&include_external=audio";

            await songs(accesstoken, apiURL);

            pnlgame.Visible=true;
            pnlgame.BringToFront();

            songsList.RemoveAll(song => string.IsNullOrEmpty(song.PreviewLink) || songsList.Any(other => other != song && other.PreviewLink == song.PreviewLink));//remove duplicates via link and remove songs without a link 
            SelectRandomSongs();
            writetorich();
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
                    collectsongs(content);
                }
                else
                {
                    // Print an error message if the request was not successful
                    MessageBox.Show($"Error: {response.StatusCode} - {response.ReasonPhrase}");
                }
            }
        }

         private static void collectsongs(string content)
        {            
            try
            {
                songsList.Clear();
                // Read the JSON content from the file
                string json = content;

                // Deserialize the JSON data
                var data = JsonConvert.DeserializeObject<JObject>(json);

                // Access the relevant information
                JArray items = data["tracks"]["items"] as JArray;             

                for (int i = 0; i < items.Count; i++)
                {
                    // Extract image, artist, and preview link
                    string image = items[i]["album"]["images"][0]["url"].ToString();
                    string artist = items[i]["artists"][0]["name"].ToString();
                    string trackName = items[i]["name"].ToString(); 
                    string previewLink = items[i]["preview_url"].ToString();

                    // Create a Song object and add it to the list
                    getsong song = new getsong
                    {
                        Image = image,
                        Artist = artist,
                        track = trackName,
                        PreviewLink = previewLink
                    };
                    songsList.Add(song);
                }   
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
         }
    }


    
}
