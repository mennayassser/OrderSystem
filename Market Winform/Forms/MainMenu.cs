using Market_Winform.Helpers;
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

namespace Market_Winform
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();

            LayoutDefault.ConfigureFormLayout(this, labelHelloUser, backButton, buttonRealtime);
        }

        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonOrderMenu_Click(object sender, EventArgs e)
        {
            var orderMenu = new OrderMenu();
            orderMenu.Show();
            this.Hide();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            labelHelloUser.Text = $"Hello, {Current.Username}!";

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var prev = new Login();
            prev.Show();
        }

        private void labelHelloUser_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void buttonRealtime_Click(object sender, EventArgs e)
        {
            this.Hide();
            var realtime = new Realtime();
            realtime.Show();
        }
    }
}
