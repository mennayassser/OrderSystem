using MarketService.Domain;
using Market_Winform.Helpers;
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

namespace Market_Winform
{
    public partial class GetAllOrders : Form
    {
        private readonly HttpClient client = new HttpClient();
        public GetAllOrders()
        {
            InitializeComponent();

            this.Load += OrdersForm_Load;
        }

        private async Task LoadOrdersAsync()
        {
            try
            {
                var response = await ApiClient.Client.GetAsync("http://localhost:7092/api/order");
                ordersGridView.DataSource = response;

                var rawJson = await response.Content.ReadAsStringAsync();


                var orders = JsonSerializer.Deserialize<List<Order>>(rawJson, new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });


                ordersGridView.DataSource = orders;

            }
            catch (Exception ex)
            {
                string fullError = ex.InnerException?.Message ?? ex.Message;
                MessageBox.Show("Error loading orders:\n" + fullError);
            }

        }


        private async void OrdersForm_Load(object sender, EventArgs e)
        {
            await LoadOrdersAsync();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void GetAllOrders_Load(object sender, EventArgs e)
        {
            labelHelloUser.Text = $"Hello, {Current.Username}!";

        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
