using Market_Winform.Forms;
using Market_Winform.Helpers;
using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Market_Winform
{
    public partial class Login : Form
    {
        // Simple DTOs for response deserialization
        private class LoginResponse
        {
            public string Token { get; set; }
            public string UserName { get; set; }
        }

        public Login()
        {
            InitializeComponent();
            LayoutDefault.ConfigureLayoutB(this);
        }

        private async void buttonLogin_Click(object sender, EventArgs e)
        {
            var userName = textBoxUsername.Text.Trim();
            var password = textBoxPassword.Text.Trim();

            // 1. Basic input validation
            if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please fill in both username and password.",
                                "Validation Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            // 2. Prepare request payload
            var loginUser = new
            {
                UserName = userName,
                Password = password
            };

            try
            {
                // 3. Call Login endpoint
                var response = await ApiClient.Client.PostAsJsonAsync(
                    "http://localhost:5000/api/Login/login",
                    loginUser);

                // 4. Handle different status codes
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    // Successful login
                    var result = await response.Content.ReadFromJsonAsync<LoginResponse>();
                    Current.Token = result.Token;
                    Current.Username = result.UserName;

                    // Attach Bearer token to subsequent requests
                    ApiClient.Client.DefaultRequestHeaders.Authorization =
                        new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", result.Token);

                    MessageBox.Show("Login successful!",
                                    "Welcome",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);

                    // Navigate to main menu
                    new MainMenu().Show();
                    this.Hide();
                }
                else if (response.StatusCode == HttpStatusCode.Unauthorized)
                {
                    MessageBox.Show("Invalid credentials. Please try again.",
                                    "Authentication Failed",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
                else if (response.StatusCode == HttpStatusCode.BadRequest)
                {
                    var error = await response.Content.ReadAsStringAsync();
                    MessageBox.Show(error,
                                    "Bad Request",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                }
                else
                {
                    var errorContent = await response.Content.ReadAsStringAsync();
                    MessageBox.Show($"Unexpected error: {(int)response.StatusCode} {response.ReasonPhrase}\n\nDetails: {errorContent}",
                                    "Error",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show($"Server unreachable: {ex.Message}\n\nPlease ensure the MarketAuth service is running on http://localhost:5000",
                                "Network Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred:\n{ex.Message}",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void labelSignUp_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            new SignUp().Show();
            this.Hide();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
