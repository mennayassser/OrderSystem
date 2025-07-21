using MarketService.Domain;
using Microsoft.AspNetCore.SignalR.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using Market_Winform.Helpers;

namespace Market_Winform
{
    public partial class Realtime : Form
    {
        private readonly BindingList<Order> _orders = new BindingList<Order>();
        private HubConnection _hubConnection;

        public Realtime()
        {
            InitializeComponent();

            LayoutDefault.ConfigureLayoutB(this);


            labelHelloUser.Location = new Point(this.ClientSize.Width - labelHelloUser.Width - 20, 20);
            labelHelloUser.Anchor = AnchorStyles.Top | AnchorStyles.Right;

            backButton.FlatStyle = FlatStyle.Flat;
            backButton.Location = new Point(20, this.ClientSize.Height - backButton.Height - 20);
            backButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;

            RealtimeDataGrid.AutoGenerateColumns = true;

        }

        private async void Realtime_Load(object sender, EventArgs e)
        {
            System.Net.ServicePointManager.ServerCertificateValidationCallback +=
      (sender2, cert, chain, sslPolicyErrors) => true;

            labelHelloUser.Text = $"Hello, {Current.Username}!";

            try
            {
                var response = await ApiClient.Client.GetAsync("http://localhost:7092/api/order");
                RealtimeDataGrid.DataSource = response;

                var rawJson = await response.Content.ReadAsStringAsync();


                var orders = JsonSerializer.Deserialize<List<Order>>(rawJson, new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });


                _orders.Clear();
                foreach (var order in orders)
                {
                    _orders.Add(order);
                }
                RealtimeDataGrid.DataSource = _orders;

            }
            catch (Exception ex)
            {
                string fullError = ex.InnerException?.Message ?? ex.Message;
                MessageBox.Show("Error loading orders:\n" + fullError);
            }

            _hubConnection = new HubConnectionBuilder()
        .WithUrl("http://localhost:7167/orderhub") 
        .WithAutomaticReconnect()
        .Build();

            await _hubConnection.StartAsync();

            _hubConnection.On<Order>("ReceiveOrder", order =>
            {
                Invoke(() => Invoke(() => _orders.Add(order)));
            });

            
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var prev = new OrderMenu();
            prev.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
