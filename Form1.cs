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
using System.Drawing.Imaging;
using Accord.Imaging.Filters;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using System.Net;





namespace music
{
    public partial class Mainmenu : Form
    {
        public static bool maximise, options, about, year, genre, bscore = false;
        public static int iscore;
        public static string sgenre, smode,syear;
        public static getsong[,] Songs = new getsong[20, 1];
        public static List<getsong> songsList = new List<getsong>();
        public static List<Userlist> scoreList = new List<Userlist>();
        private System.Timers.Timer quizTimer;
        private int elapsedTimeInSeconds;

        public class getsong
        {
            public string Image { get; set; }
            public string Artist { get; set; }
            public string track { get; set; }
            public string PreviewLink { get; set; }
        }

        public class Userlist
        {
            public string username { get; set; }
            public string gamemode { get; set; }
            public string score { get; set; }
            public string time { get; set; }
        }

        public Mainmenu()
        {
            Login login = new Login();
            login.ShowDialog();
            this.Hide();
            InitializeComponent();
            pnlfinal.Visible = false;
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
                // Update the time label in quiz 
                lbltime.Text = $"{minutes:D2}:{seconds:D2}";
            });
        }

        private void toggleButton1_CheckedChanged(object sender, EventArgs e)
        {//apply dark theme or not 
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
                lblDarktheme.ForeColor = Color.Black;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //maximise the application or reverse 
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
            //close application
            Application.Exit();
        }

        private void pboptions_Click(object sender, EventArgs e)
        {
            //when options image clicked, panel with options appears or disapears, following the materialistric design 
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

        private void btnaboutme_Click_1(object sender, EventArgs e)
        {//opens the panel containing inofrmation about me 
            about = !about;
            if (about == true)
            {
                Pnlabout.BringToFront();
                Pnlabout.Visible = true;
                year = false;
                genre = false;
                bscore = false;
            }

        }

        private void btnmin_Click(object sender, EventArgs e)
        {
            //minimise application
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnYear_Click(object sender, EventArgs e)
        {//set panel containing the year selection to be active
            year = !year;
            if (year == true)
            {
                foreach (RadioButton radio in grpYear.Controls)
                {
                    if (radio.Checked == true)
                    {
                        radio.Checked = false;
                    }
                }
                pnlYear.BringToFront();
                pnlYear.Visible = true;
                about = false;
                genre = false;
                bscore = false;
            }


        }

        public async void SelectRandomSongs()
        {
            Random random = new Random();

            // Shuffle the songsList 
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
            //start quiz with the 10 selected songs
            await startquiz(randomSongs);
        }

        public async Task startquiz(List<getsong> randomsongs)
        {//core program, the quiz 
            btnnext.Enabled = false;
            btnnext.Visible = false;
            var buttonanswer = new TaskCompletionSource<bool>();
            elapsedTimeInSeconds = 0;
            quizTimer.Start();

            // Attach an event handler to the button's click event
            EventHandler buttonClickHandler = (s, args) => buttonanswer.TrySetResult(true);
            btnanswer.Click += buttonClickHandler;

            Random random = new Random();
            int[] pos = new int[4];
            int icount = 1;
            iscore = 0;
            updatecontrols(icount, "", randomsongs.Count);

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("incase you want any of the songs in the quiz here is the list.\nAll images and song previews were supplied by spotify.");
            sb.AppendLine();
            //using the foreach loop for the list we make the quiz 
            //10 questions long
            foreach (getsong songs in randomsongs)
            {
                sb.AppendLine($"Artist: {songs.Artist}");
                sb.AppendLine($"song: {songs.track}");
                sb.AppendLine();
                //creat an http as the list we receive contains the preview links supplied spotify as well as the links to the songs image 
                HttpClient httpClient = new HttpClient();
                icount++;
                //call the link to be search in the webplayer, webplayer 2 utilised as it has audio playback features 
                webplayer.Source = new Uri(songs.PreviewLink);
                //using the link for the songs image we fetch the image and then produce a pixel effect to help users take a guess on the answer 
                Bitmap pixelatedImage = ApplyPixelateEffect(songs.Image, 20);
                if (pixelatedImage != null)
                {
                    pictureBox1.Image = pixelatedImage;
                    pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                }


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

                webplayer.Stop();
            }

            btnanswer.Click -= buttonClickHandler;
            quizTimer.Stop();

            btnnext.Visible = true;
            btnnext.Enabled = true;

            rtxtsong.Text = sb.ToString();


        }

        private Bitmap ApplyPixelateEffect(string imageUrl, int pixelationLevel)
        {//uytilising accorrd nuget package we process the image to have a pixel effect
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    byte[] imageData = client.GetByteArrayAsync(imageUrl).Result;

                    using (MemoryStream memoryStream = new MemoryStream(imageData))
                    {
                        Bitmap originalImage = new Bitmap(memoryStream);

                        int newWidth = originalImage.Width / pixelationLevel;
                        int newHeight = originalImage.Height / pixelationLevel;

                        // Create a Pixellate filter with the desired grid size
                        Pixellate pixellateFilter = new Pixellate(pixelationLevel);

                        // Apply the filter to the original image
                        Bitmap pixelatedImage = pixellateFilter.Apply(originalImage);

                        return pixelatedImage;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error downloading or processing image: {ex.Message}");
                return null;
            }
        }

        private void updatecontrols(int icount, string artist, int songcount)
        {
            //during the foreach loop of songs we run this method to update controls on the quiz form to show time,
            //score and reset the radio button selection as well as check if the user chose the correct answer
            if (lblRound.Text != "Round 10")
                lblRound.Text = "Round " + icount.ToString();
            else
                lblRound.Text = "Game Done!!!";

            foreach (Control control in grpAns.Controls)
            {

                if (control is RadioButton radiobutton)
                {
                    if (radiobutton.Text == artist && radiobutton.Checked)
                        iscore++;
                    radiobutton.Checked = false;
                }

            }
            lblscore.Text = iscore.ToString() + " / " + songcount.ToString();

        }

        private async void btncongenre_Click(object sender, EventArgs e)
        {
            //collect chosen genre for quiz
            switch (true)
            {
                case var _ when rrock.Checked:
                    sgenre = "rock";
                    break;
                case var _ when rclassical.Checked:
                    sgenre = "classical";
                    break;
                case var _ when rcountry.Checked:
                    sgenre = "country";
                    break;
                case var _ when rjazz.Checked:
                    sgenre = "jazz";
                    break;
                case var _ when rpop.Checked:
                    sgenre = "pop";
                    break;
                default:

                    break;
            }
            smode = "Genre: " + sgenre;
            //spotify access token collected on login
            string accesstoken = Login.accesstoken;

            string apiURL = "https://api.spotify.com/v1/search?q=genre%3A" + sgenre + "&type=track%2Cartist&market=sa&limit=20&include_external=audio";


            await songs(accesstoken, apiURL);

            pnlgame.Visible = true;
            pnlgame.BringToFront();
            //remove duplicates via link and remove songs without a link 

            songsList.RemoveAll(song => string.IsNullOrEmpty(song.PreviewLink) || songsList.Any(other => other != song && other.PreviewLink == song.PreviewLink));
            SelectRandomSongs();
        }

        private void btnnoupload_Click(object sender, EventArgs e)
        {//if user chooses not to upload their score they will be direct to teh about page with no background process
            MessageBox.Show("Thank you for playing, you will be redirected to the about me page.");
            btnaboutme_Click_1(sender, e);
        }

        private async void btnyesupload_Click(object sender, EventArgs e)
        {//if the user wishes to upload their score a http is created and we call the sql api to post and update the db to have the users results 
            var httpClient = new HttpClient();
            //collect data to convert to json
            var user = new
            {
                username = Login.email,
                gamemode = smode,
                score = iscore.ToString(),
                time = lbltime.Text
            };
            //convert to json
            var json = Newtonsoft.Json.JsonConvert.SerializeObject(user);
            //encode the json 
            var uploadData = new StringContent(json, Encoding.UTF8, "application/json");
            var uploadUrl = "http://localhost:3000/upload_score";
            //call the upload and wait on upload response 
            var uploadResponse = await httpClient.PostAsync(uploadUrl, uploadData);
            //collect response and show response message as well as return user to score panel to view the scores of all users 
            string uploadResult = await uploadResponse.Content.ReadAsStringAsync();
            MessageBox.Show(uploadResult + ", You will no be directed back to the high score page.");

            smode = "";
            iscore = 0;
            lbltime.Text = "";
            btnscore_Click(sender, e);

        }

        private void btnYouentry_Click(object sender, EventArgs e)
        {
            //sort score list to view only user attempts
            var currentUserEntries = scoreList.Where(item => item.username == Login.email ).OrderBy(item => item.time);
            writeHighscore(currentUserEntries);
        }

        private void btnhighscores_Click(object sender, EventArgs e)
        {//sort list by highest score to lowest 
            var orderedEntries = scoreList.OrderByDescending(item => int.Parse(item.score));
            writeHighscore(orderedEntries);
        }

        private void btnlowscore_Click(object sender, EventArgs e)
        {//sort list by lowest score to highest 
            var orderedEntries = scoreList.OrderBy(item => int.Parse(item.score));
            writeHighscore(orderedEntries);
        }

        private void btnquicktime_Click(object sender, EventArgs e)
        {//sort scores by quickest time to slowest 
            var orderedEntries = scoreList.OrderBy(item => (item.time));
            writeHighscore(orderedEntries);
        }

        private void btnslowtime_Click(object sender, EventArgs e)
        {//sort scores by slowest time to quickest 
            var orderedEntries = scoreList.OrderByDescending(item => (item.time));
            writeHighscore(orderedEntries);
        }

        private async void btnscore_Click(object sender, EventArgs e)
        {//open panel containing scores and display to user the scores from over time 
           
            bscore = !bscore;
            if (bscore == true)
            {
                pnlscore.BringToFront();
                pnlscore.Visible = true;
                about = false;
                year = false;
                genre = false;
            }
             //create http for collection of scores from db 
            var httpClient = new HttpClient();

            var fetchUrl = "http://localhost:3000/retreive_data";
            var fetchResponse = await httpClient.GetAsync(fetchUrl);
            
            string fetchResult = await fetchResponse.Content.ReadAsStringAsync();
            //receive response from db if error arises it shows the log else it collects the data and populates a list 
            if (fetchResult != "Internal Server Error")
            {
                var jsonData = JsonConvert.DeserializeObject<JArray>(fetchResult);
                scoreList.Clear();
                foreach (var item in jsonData)
                {
                    Userlist Lscore = new Userlist
                    {
                        username = item["username"].ToString(),
                        gamemode = item["gamemode"].ToString(),
                        score = item["score"].ToString(),
                        time = item["time"].ToString()

                    };
                    //ading the items into the list 
                    scoreList.Add(Lscore);                    
                }
                
                
            }
            else
                MessageBox.Show(fetchResult);
            //write the details of the list to the richtextbox on the scores page, teh text box is set as readonly 
            writeHighscore(scoreList);            
        }

        private void writeHighscore(IEnumerable<Userlist> entries)
        {
            //this section called multiple times for displaying the high score list in the high score page hence justified to become its own method 
            StringBuilder sb = new StringBuilder();

            foreach (Userlist item in entries)
            {
                sb.AppendLine($"Username: {item.username}\nGamemode: {item.gamemode}\nScore: {item.score}\nTime: {item.time}\n\n");
            }

            rtxtScore.Text = sb.ToString();
        }

        private void btnnext_Click(object sender, EventArgs e)
        {//directs user to the quiz results panel displaying their details for the quiz 
            webplayer.Source = new Uri("about:blank");
            pnlfinal.Visible = true;
            pnlfinal.BringToFront();
            lblfinalscore.Text = iscore.ToString();
            lblfinaltime.Text = lbltime.Text;
        }

        private void btngenre_Click(object sender, EventArgs e)
        {//genre panel is set as active panel
            rrock.Checked = true;
            genre = !genre;
            if (genre == true)
            {
                pnlgenre.BringToFront();
                pnlgenre.Visible = true;
                about = false;
                year = false;
                bscore = false;
            }
        }

        private async void btnconfirmyear_Click(object sender, EventArgs e)
        {       //collect the year 
            switch (true)
            {
                case var _ when r80.Checked:
                    syear = "1980-1989";
                    break;
                case var _ when r90.Checked:
                    syear = "1990-1999";
                    break;
                case var _ when r2000.Checked:
                    syear = "2000-2009";
                    break;
                case var _ when r2010.Checked:
                    syear = "2010-2019";
                    break;
                case var _ when r2020.Checked:
                    syear = "2020-2024"; 
                    break;
                default:
                    syear = "1980-2024";
                    break;
            }
            smode = "Year: " + syear.ToString();
            //spotify access token collected on login
            string accesstoken = Login.accesstoken;
            //request the list from spotify 
            string apiURL = " https://api.spotify.com/v1/search?q="+syear+"&type=track&market=sa&limit=30&include_external=audio";
      
        
            await songs(accesstoken, apiURL);

            pnlgame.Visible = true;
            pnlgame.BringToFront();
            //remove duplicates via link and remove songs without a link 
            songsList.RemoveAll(song => string.IsNullOrEmpty(song.PreviewLink) || songsList.Any(other => other != song && other.PreviewLink == song.PreviewLink));
            SelectRandomSongs();

        }

        static async Task songs(string access, string url)
        {
            using (HttpClient client = new HttpClient())
            {
                // Set the Authorization header
                client.DefaultRequestHeaders.Add("Authorization", $"Bearer {access}");
                
                HttpResponseMessage response = await client.GetAsync(url);

                // Check if the request was successful (status code 200)
                if (response.IsSuccessStatusCode)
                {                  
                    string content = await response.Content.ReadAsStringAsync();
                    collectsongs(content);
                }
                // If the response is Unauthorized (401), obtain a new access token
                else if (response.StatusCode == HttpStatusCode.Unauthorized)
                {                    
                    MessageBox.Show($"Error: {response.StatusCode} - {response.ReasonPhrase}");
                    access = await SpotifyAuth.GetAccessToken(Login.clientt, Login.clients);
                    await songs(access, url);
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

                    //add objects to list songslist
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
