using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Net.Http;
using Newtonsoft.Json.Linq;

namespace music
{
    

    public partial class Login : Form
    {
        public static bool maximise = false;
        public static string email, password;
        public Login()
        {
            
            InitializeComponent();
        }

    private void btnmin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        
        private async void btnlogin_Click(object sender, EventArgs e)
        {
            // Usage example
            var accessToken = await SpotifyAuth.GetAccessToken("3255eb67936e45f2b8c8da7d271abf56", "e59e758328024b31936d750a735f990d");

            var httpClient = new HttpClient();
            var user = new { username = txtemail.Text, password = txtpassword.Text, access_token = accessToken };
            var json = Newtonsoft.Json.JsonConvert.SerializeObject(user);
            var data = new StringContent(json, Encoding.UTF8, "application/json");

            var url = "http://localhost:3000/register";
            var response = await httpClient.PostAsync(url, data);

            string result = await response.Content.ReadAsStringAsync();
            MessageBox.Show(result);
            if (result == "User registered successfully")
            {
                this.Close();
            }
        }

     

        private void btnmax_Click(object sender, EventArgs e)
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

        private void btncancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("By Canceling you have chosen to close the application, Goodbye!","Goodbye!");
            Application.Exit();
        }
    }


    class DataProtect
    {
        // Generate a secure random key and IV
        public class EncryptedData
        {
            public string EncryptedEmail { get; set; }
            public string EncryptedPassword { get; set; }
        }

        public static EncryptedData Encrypt(string email, string password)
        {
            using (Aes aes = Aes.Create())
            {
                // Generate a random key and IV for each encryption operation
                aes.GenerateKey();
                aes.GenerateIV();

                EncryptedData encryptedData = new EncryptedData();

                // Encrypt Email
                using (MemoryStream emailMemoryStream = new MemoryStream())
                {
                    using (CryptoStream emailCryptoStream = new CryptoStream(emailMemoryStream, aes.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        byte[] emailBytes = Encoding.UTF8.GetBytes(email);
                        emailCryptoStream.Write(emailBytes, 0, emailBytes.Length);
                    }

                    byte[] encryptedEmailBytes = emailMemoryStream.ToArray();
                    encryptedData.EncryptedEmail = Convert.ToBase64String(encryptedEmailBytes);
                }

                // Encrypt Password
                using (MemoryStream passwordMemoryStream = new MemoryStream())
                {
                    using (CryptoStream passwordCryptoStream = new CryptoStream(passwordMemoryStream, aes.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        byte[] passwordBytes = Encoding.UTF8.GetBytes(password);
                        passwordCryptoStream.Write(passwordBytes, 0, passwordBytes.Length);
                    }

                    byte[] encryptedPasswordBytes = passwordMemoryStream.ToArray();
                    encryptedData.EncryptedPassword = Convert.ToBase64String(encryptedPasswordBytes);
                }

                return encryptedData;
            }
        }
        
    }
    


    class file
    {
        public static void WriteToFile(string filepath, string data)
        {
            try
            {
                using (StreamWriter file = File.AppendText(filepath))
                {
                    DateTime date = DateTime.Now;
                    file.WriteLine(date+","+data);
                    
                }
            }
            catch (IOException e)
            {
                MessageBox.Show("Error: " + e.Message);
            }
        }
    }

    class SpotifyAuth
    {
        public static async Task<string> GetAccessToken(string clientId, string clientSecret)
        {
            using (var client = new HttpClient())
            {
                // Encode Client ID and Client Secret
                var credentials = Convert.ToBase64String(Encoding.UTF8.GetBytes($"{clientId}:{clientSecret}"));

                // Prepare request
                var request = new HttpRequestMessage(HttpMethod.Post, "https://accounts.spotify.com/api/token");
                request.Headers.Add("Authorization", $"Basic {credentials}");
                request.Content = new StringContent("grant_type=client_credentials", Encoding.UTF8, "application/x-www-form-urlencoded");

                // Send the request
                var response = await client.SendAsync(request);
              
                if (response.IsSuccessStatusCode)
                {
                    // Parse the response and return the access token
                    var content = await response.Content.ReadAsStringAsync();
                    var data = JObject.Parse(content);
                    MessageBox.Show(data["access_token"].ToString());
                    return data["access_token"].ToString();
                }
                else
                {
                    throw new Exception("Failed to obtain access token");
                }
            }
        }
    }
}



   