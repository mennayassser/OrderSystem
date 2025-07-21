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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Market_Winform
{
    public partial class DeleteOrder : Form
    {
        public DeleteOrder()
        {
            InitializeComponent();

            LayoutDefault.ConfigureFormLayout(this, labelHelloUser, backButton, buttonRealtime);

           
        }

        private void DeleteOrder_Load(object sender, EventArgs e)
        {
            labelHelloUser.Text = $"Hello, {Current.Username}!";

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private async void buttonDelete_Click(object sender, EventArgs e)
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

            var response = await ApiClient.Client.DeleteAsync($"http://localhost:7092/api/order/{id}");

            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Order deleted successfully.");
            }
            else if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
            {
                MessageBox.Show("Order not found.");
            }
            else
            {
                MessageBox.Show($"Error deleting order: {response.StatusCode}");
            }
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