using Market_Winform.Forms;
using Market_Winform.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Market_Winform
{
    public partial class OrderMenu : Form
    {

        public OrderMenu()
        {
            InitializeComponent();

            LayoutDefault.ConfigureFormLayout(this, labelHelloUser, backButton, buttonRealtime);
        }

        

        private void OrderMenu_Load(object sender, EventArgs e)
        {
            labelHelloUser.Text = $"Hello, {Current.Username}!";

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonCreateOrder_Click(object sender, EventArgs e)
        {
            var createOrder = new CreateOrder();
            createOrder.Show();
            this.Hide();
        }

        private void buttonGetAll_Click(object sender, EventArgs e)
        {
            var getAll = new GetAllOrders();
            getAll.Show();
            this.Hide();
        }

        private void buttonGetOrderById_Click(object sender, EventArgs e)
        {
            var getById = new GetOrderById();
            getById.Show();
            this.Hide();
        }

        private void buttonUpdateOrder_Click(object sender, EventArgs e)
        {
            var updateOrder = new UpdateOrder();
            this.Invoke(() => updateOrder.Show());
            this.Hide();
        }

        private void buttonDeleteOrder_Click(object sender, EventArgs e)
        {
            var deleteOrder = new DeleteOrder();
            deleteOrder.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Hide();
            var prev = new MainMenu();
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


