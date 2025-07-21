using Market_Winform.Helpers;
using MarketAuth.Models;
using System;
using System.Net;
using System.Net.Http.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Market_Winform.Forms
{
    public partial class SignUp : Form
    {
        // DTOs to deserialize API responses
        private class SignUpResponse { public string UserName { get; set; } }
        private class LoginResponse { public string Token { get; set; } public string UserName { get; set; } }

        public SignUp()
        {
            InitializeComponent();
            LayoutDefault.ConfigureLayoutB(this);
        }

        private async void buttonSignUp_Click(object sender, EventArgs e)
        {
            var userName = textBoxUsername.Text.Trim();
            var password = textBoxPassword.Text.Trim();

            // 1. Validate inputs
            if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show(
                    "Username and password are required.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            // 2. Build payload
            var newUser = new
            {
                UserName = userName,
                Password = password
            };

            try
            {
                // 3. Call SignUp endpoint
                var response = await ApiClient.Client.PostAsJsonAsync(
                    "http://localhost:5000/api/SignUp/signup",
                    newUser
                );

                // 4. Handle results
                if (response.StatusCode == HttpStatusCode.Created)
                {
                    var result = await response.Content.ReadFromJsonAsync<SignUpResponse>();
                    Current.Username = result.UserName;

                    // 5. Auto-login on successful sign-up
                    await PerformLogin(userName, password);
                }
                else if (response.StatusCode == HttpStatusCode.Conflict)
                {
                    MessageBox.Show(
                        "User already exists. Try logging in instead.",
                        "Conflict",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation
                    );
                }
                else if (response.StatusCode == HttpStatusCode.BadRequest)
                {
                    var error = await response.Content.ReadAsStringAsync();
                    MessageBox.Show(
                        error,
                        "Bad Request",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                }
                else
                {
                    MessageBox.Show(
                        $"Unexpected error: {(int)response.StatusCode} {response.ReasonPhrase}",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show(
                    $"Cannot reach server: {ex.Message}",
                    "Network Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"An unexpected error occurred:\n{ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // Helper to log in immediately after a successful sign-up
        private async Task PerformLogin(string userName, string password)
        {
            try
            {
                var loginUser = new
                {
                    UserName = userName,
                    Password = password
                };

                var loginResponse = await ApiClient.Client.PostAsJsonAsync(
                    "http://localhost:5000/api/Login/login",
                    loginUser
                );

                if (loginResponse.IsSuccessStatusCode)
                {
                    var data = await loginResponse.Content.ReadFromJsonAsync<LoginResponse>();
                    Current.Token = data.Token;
                    Current.Username = data.UserName;
                    ApiClient.Client.DefaultRequestHeaders.Authorization =
                        new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", data.Token);

                    MessageBox.Show(
                        "Sign-up and login successful!",
                        "Welcome",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                    new MainMenu().Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show(
                        "Signed up, but automatic login failed. Please log in manually.",
                        "Partial Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                    new Login().Show();
                    this.Hide();
                }
                            }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Login failed: {ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                new Login().Show();
                this.Hide();
            }
        }

        // Unused but required event handlers
        private void SignUp_Load(object sender, EventArgs e) { }
        private void textBoxUsername_TextChanged(object sender, EventArgs e) { }
        private void textBoxPassword_TextChanged(object sender, EventArgs e) { }

    }
}
