using Market.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using Market_Winform.Helpers;

namespace Market_Winform
{
    public partial class UpdateOrder : Form
    {
        public UpdateOrder()
        {
            InitializeComponent();

            LayoutDefault.ConfigureFormLayout(this, labelHelloUser, backButton, buttonRealtime);

        }

        private async void UpdateOrder_Load(object sender, EventArgs e)
        {
            labelHelloUser.Text = $"Hello, {Current.Username}!";

            if (string.IsNullOrWhiteSpace(textBoxOrderId.Text))
            {
                MessageBox.Show("Order ID is required.");
                return;
            }
            int id = int.Parse(textBoxOrderId.Text);
            var response = await ApiClient.Client.GetAsync($"https://localhost:7092/api/order/{id}");

            if (response.IsSuccessStatusCode)
            {
                var order = await response.Content.ReadFromJsonAsync<Order>();
            }
            else
            {
                MessageBox.Show("Order not found.");
            }

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var prev = new OrderMenu();
            prev.Show();
        }

        private void buttonSearchById_Click(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {

            if (!int.TryParse(textBoxOrderId.Text, out int orderId))
            {
                MessageBox.Show("Please enter a valid Order ID.");
                return;
            }

            var existingResponse = await ApiClient.Client.GetAsync($"https://localhost:7092/api/order/{orderId}");
            if (!existingResponse.IsSuccessStatusCode)
            {
                MessageBox.Show("Order not found.");
                return;
            }

            var existingOrder = await existingResponse.Content.ReadFromJsonAsync<Order>();
            if (existingOrder == null)
            {
                MessageBox.Show("Error reading order data.");
                return;
            }

            var updatedOrder = new Order
            {
                CustomerName = Current.Username,
                Quantity = int.Parse(textBoxQuantity.Text),
                Price = int.Parse(textBoxPrice.Text),
                Products = textBoxProducts.Text,
                Direction = comboBoxDirection.SelectedItem?.ToString()
            };

            var response = await ApiClient.Client.PutAsJsonAsync($"https://localhost:7092/api/order/{orderId}", updatedOrder);

            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Order updated successfully.");
            }
            else
            {
                var error = await response.Content.ReadAsStringAsync();
                MessageBox.Show($"Update failed: {response.StatusCode}\n{error}");
            }
        }

        private async void buttonView_Click(object sender, EventArgs e)
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

        private void buttonRealtime_Click(object sender, EventArgs e)
        {
            this.Hide();
            var realtime = new Realtime();
            realtime.Show();
        }
    }
}

