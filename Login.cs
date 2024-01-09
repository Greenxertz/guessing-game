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
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Text.RegularExpressions;

namespace music
{
    public partial class Login : Form
    {
        public static bool maximise, blogin, bsignUp = false;
        public static string email, password, accesstoken, clients, clientt;
        public Login()
        {

            InitializeComponent();
        }

        private void btnmin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            blogin = true;
            bsignUp = false;
            email = txtemail.Text;
            password = txtpassword.Text;
            dbConnect(email, password, sender, e);
        }

        private async void dbConnect(string useremail, string userpass, object sender, EventArgs e)
        {
            try
            {
                var httpClient = new HttpClient();

                var user = new
                {
                    username = useremail,
                    password = userpass                   
                };
                var json = Newtonsoft.Json.JsonConvert.SerializeObject(user);

                var checkData = new StringContent(json, Encoding.UTF8, "application/json");

                var checkUrl = "http://localhost:3000/userCheck";
                var checkResponse = await httpClient.PostAsync(checkUrl, checkData);

                string checkResult = await checkResponse.Content.ReadAsStringAsync();

                if (blogin == true)
                {
                    if (checkResult == "User does exist")
                    {
                        this.Close();
                    }
                    else if (checkResult == "User does not exist")
                    {
                        MessageBox.Show("You seem to not have an account.");

                        txtSignEmail.Text = txtemail.Text;
                        lblsignup_Click(sender, e);
                    }
                    else if (checkResult == "Incorrect password")
                    {
                        MessageBox.Show("Incorrect password");
                    }
                }
                else if (bsignUp == true)
                {
                    if (checkResult == "User does exist")
                    {
                        MessageBox.Show("You seem to have an account already");
                        txtemail.Text = useremail;
                        txtpassword.Focus();
                        btncancel2_Click(sender, e);
                    }
                    else if (checkResult == "User does not exist")
                    {
                        var registerData = new StringContent(json, Encoding.UTF8, "application/json");
                        var registerUrl = "http://localhost:3000/signup";
                        try
                        {
                            var registerResponse = await httpClient.PostAsync(registerUrl, registerData);
                            string registerResult = await registerResponse.Content.ReadAsStringAsync();
                            if (registerResult == "User registered successfully")
                            {
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("There seems to be an error please try again later.");
                            }
                        }
                        catch (Exception ex)
                        {
                            // Handle or log the exception
                            MessageBox.Show($"Error during POST request: {ex.Message}");
                        }
                    }
                    else if (checkResult == "Incorrect password")
                    {
                        MessageBox.Show("You seem to have an account already");
                        txtemail.Text = useremail;
                        txtpassword.Focus();
                        btncancel2_Click(sender, e);
                    }
                }                                        

                var encryptedData = DataProtect.Encrypt(useremail, userpass);

                var dataurl = "http://localhost:3000/spotify-details";
                var dataresponse = await httpClient.GetAsync(dataurl);
                string dataresult = await dataresponse.Content.ReadAsStringAsync();
                if (dataresult != "Internal Server Error")
                {
                    var jsonData = JsonConvert.DeserializeObject<JArray>(dataresult);

                    foreach (var item in jsonData)
                    {
                        clientt = item["clientId"].ToString();
                        clients = item["secretId"].ToString();
                    }
                }
                else
                    MessageBox.Show(dataresult);

                var accessToken = await SpotifyAuth.GetAccessToken(clientt, clients);
                accesstoken = accessToken;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void lblsignup_Click(object sender, EventArgs e)
        {
            pnlSignup.Visible = true;
            txtemail.Clear();
            txtpassword.Clear();
        }

        private void txtSignEmail_TextChanged(object sender, EventArgs e)
        {
            string emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            Regex regex = new Regex(emailPattern);
            if (regex.IsMatch(txtSignEmail.Text) == true)
            {
                lblInvalidEmail.Visible = false;
            }
            else
            {
                lblInvalidEmail.Visible = true;
            }
            unlockbutton();
        }

        private void txtConfirmPass_TextChanged(object sender, EventArgs e)
        {
            if (txtSignPass.Text == txtConfirmPass.Text)
            {
                lblInvalidPass.Visible = false;
            }
            else
            {
                lblInvalidPass.Visible = true;
            }
            unlockbutton();
        }

        private void unlockbutton()
        {
            if ((lblInvalidEmail.Visible == false) && (lblInvalidPass.Visible == false) && (txtConfirmPass.Text != "") && (txtSignEmail.Text != ""))
            {
                btnSignup.Enabled = true;
            }
            else
            {
                btnSignup.Enabled = false;
            }

            if ((txtpassword.Text != "") &&(lblinvalidformat.Visible==false))
            {
                btnlogin.Enabled = true;
            }
            else
            {
                btnlogin.Enabled = false; 
            }

        }

        private void btncancel2_Click(object sender, EventArgs e)
        {
            txtSignEmail.Clear();
            txtSignPass.Clear();
            txtConfirmPass.Clear();

            lblInvalidEmail.Visible = false;

            pnlSignup.Visible = false;
        }

        private void txtpassword_TextChanged(object sender, EventArgs e)
        {
            unlockbutton();
        }

        private void txtSignPass_TextChanged(object sender, EventArgs e)
        {
            if (txtSignPass.Text == txtConfirmPass.Text)
            {
                lblInvalidPass.Visible = false;
            }
            else
            {
                lblInvalidPass.Visible = true;
            }
            unlockbutton();
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            email = txtSignEmail.Text;
            password = txtSignPass.Text;
            bsignUp = true;
            blogin = false;
            dbConnect(email, password, sender, e);
        }

        private void btnmax_Click(object sender, EventArgs e)
        {//add functions to maximise button 
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

        private void txtemail_TextChanged(object sender, EventArgs e)
        {//validate email against normal conventions 
            string emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            Regex regex = new Regex(emailPattern);
            if (regex.IsMatch(txtemail.Text) == true)
            {
                lblinvalidformat.Visible = false;               
            }
            else
            {
                lblinvalidformat.Visible = true;               
            }
            unlockbutton();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("By Canceling you have chosen to close the application, Goodbye!", "Goodbye!");
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
                    //  MessageBox.Show(data["access_token"].ToString());
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



