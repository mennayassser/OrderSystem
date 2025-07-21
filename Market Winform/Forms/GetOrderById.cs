using Market.Models;
using Market.Models;
using Market_Winform.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Market_Winform
{
    public partial class GetOrderById : Form
    {
        public GetOrderById()
        {
            InitializeComponent();

            LayoutDefault.ConfigureFormLayout(this, labelHelloUser, backButton, buttonRealtime);
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void GetOrderById_Load(object sender, EventArgs e)
        {
            labelHelloUser.Text = $"Hello, {Current.Username}!";

        }

        private async Task LoadOrderByIdAsync(int id)
        {

            var response = await ApiClient.Client.GetAsync($"https://localhost:7092/api/order/{id}");

            if (!response.IsSuccessStatusCode)
            {
                MessageBox.Show($"Error: {response.StatusCode}");
                return;
            }

            var rawJson = await response.Content.ReadAsStringAsync();

            var order = JsonSerializer.Deserialize<Order>(rawJson, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            });

            gridViewOrders.DataSource = new List<Order> { order };

        }


        private async void buttonSearchById_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxOrderId.Text))
            {
                MessageBox.Show("Order ID is required.");
                return;
            }


            if (!int.TryParse(textBoxOrderId.Text, out int id))
            {
                MessageBox.Show("Invalid ID format.");
                return;
            }

            await LoadOrderByIdAsync(id);

        }

        private void gridViewOrders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var prev = new OrderMenu();
            prev.Show();
        }

        private void buttonRealtime_Click(object sender, EventArgs e)
        {
            this.Hide();
            var realtime = new Realtime();
            realtime.Show();
        }
    }
}
