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
        public static string email, password, accesstoken, clients, clientt, useremail;
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
        {//connect to database and call relevent urls
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
                //check if user exists in database(db)
                var checkUrl = "http://localhost:3000/userCheck";
                var checkResponse = await httpClient.PostAsync(checkUrl, checkData);

                string checkResult = await checkResponse.Content.ReadAsStringAsync();
                //if statement used for validation, check if non registered users use login will then direct them to signup 
                //and if user utilizes signup the program will state that they have an account and direct them to the login page
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
                        //if user does not exist, api is called to register the user with data provided
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
                    }//prevents user from signing in with signup 
                    else if (checkResult == "Incorrect password")
                    {
                        MessageBox.Show("You seem to have an account already");
                        txtemail.Text = useremail;
                        txtpassword.Focus();
                        btncancel2_Click(sender, e);
                    }
                }                                
                //collect necessary details for spotify from db, more secure method than hard coding details 
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
                //call class to obtain access token from spotify utilising data from the spotify details api call 
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
        {//validate that an email format is used 
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
            //call method to test variables of signup page and unlock the pages final button
            unlockbutton();
        }

        private void unlockbutton()
        {
            //tests to see if all criteria are met and then will enable the sign up button 
            if ((lblInvalidEmail.Visible == false) && (lblInvalidPass.Visible == false) && (txtConfirmPass.Text != "") && (txtSignEmail.Text != ""))
            {
                btnSignup.Enabled = true;
            }
            else
            {
                btnSignup.Enabled = false;
            }
            //tests to see if all criteria are met and then will enable the login button 
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
        {//return to login page and clear all variables
            txtSignEmail.Clear();
            txtSignPass.Clear();
            txtConfirmPass.Clear();

            lblInvalidEmail.Visible = false;

            pnlSignup.Visible = false;
        }

        private void txtpassword_TextChanged(object sender, EventArgs e)
        {//calls unlock method for login button on text change 
            unlockbutton();
        }

        private void txtSignPass_TextChanged(object sender, EventArgs e)
        {//displays wether both password and confirm password are not the same and then calls method to enable/disable signup button
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
            //call the connect method
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
            //close applicaion
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
            //calls method to check if button can be enabled or not 
            unlockbutton();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("By Canceling you have chosen to close the application, Goodbye!", "Goodbye!");
            Application.Exit();
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



