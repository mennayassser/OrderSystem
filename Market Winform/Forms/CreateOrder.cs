using Market_Winform.Helpers;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace Market_Winform.Forms
{
    public partial class CreateOrder : Form
    {
        public CreateOrder()
        {
            InitializeComponent();

            LayoutDefault.ConfigureFormLayout(this, labelHelloUser, backButton, buttonRealtime);
            

        }


        private async void button1_Click(object sender, EventArgs e)
        {
            var order = new
            {
                CustomerId = int.Parse(textBoxCustomerID.Text),
                CustomerName = Current.Username,
                Quantity = int.Parse(textBoxQuantity.Text),
                Price = int.Parse(textBoxPrice.Text),
                Products = textBoxProduct.Text,
                Direction = comboBoxDirection.SelectedItem?.ToString()
            };


            var response = await ApiClient.Client.PostAsJsonAsync("http://localhost:7092/api/order", order);

            if (response.IsSuccessStatusCode)
            {
                labelStatus.Text = "Order submitted successfully.";
            }
            else
            {
                var errorDetails = await response.Content.ReadAsStringAsync();
                labelStatus.Text = $"Failed: {response.StatusCode} - {errorDetails}";

            }

        }

        private void InitializeComponent()
        {
            label1 = new Label();
            labelOrderId = new Label();
            labelCustomerId = new Label();
            labelPrice = new Label();
            labelQuantity = new Label();
            labelProduct = new Label();
            labelDirection = new Label();
            comboBoxDirection = new ComboBox();
            buttonSubmit = new Button();
            labelStatus = new Label();
            textBoxProduct = new TextBox();
            textBoxQuantity = new TextBox();
            textBoxPrice = new TextBox();
            textBoxCustomerID = new TextBox();
            backButton = new Button();
            labelHelloUser = new Label();
            buttonRealtime = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ImageAlign = ContentAlignment.TopCenter;
            label1.Location = new Point(192, 38);
            label1.Name = "label1";
            label1.Size = new Size(160, 28);
            label1.TabIndex = 0;
            label1.Text = "PLACE ORDER";
            // 
            // labelOrderId
            // 
            labelOrderId.AutoSize = true;
            labelOrderId.Location = new Point(38, 102);
            labelOrderId.Name = "labelOrderId";
            labelOrderId.Size = new Size(0, 20);
            labelOrderId.TabIndex = 1;
            // 
            // labelCustomerId
            // 
            labelCustomerId.AutoSize = true;
            labelCustomerId.Location = new Point(38, 122);
            labelCustomerId.Name = "labelCustomerId";
            labelCustomerId.Size = new Size(91, 20);
            labelCustomerId.TabIndex = 2;
            labelCustomerId.Text = "Customer ID";
            // 
            // labelPrice
            // 
            labelPrice.AutoSize = true;
            labelPrice.Location = new Point(38, 172);
            labelPrice.Name = "labelPrice";
            labelPrice.Size = new Size(41, 20);
            labelPrice.TabIndex = 3;
            labelPrice.Text = "Price";
            // 
            // labelQuantity
            // 
            labelQuantity.AutoSize = true;
            labelQuantity.Location = new Point(38, 225);
            labelQuantity.Name = "labelQuantity";
            labelQuantity.Size = new Size(65, 20);
            labelQuantity.TabIndex = 4;
            labelQuantity.Text = "Quantity";
            // 
            // labelProduct
            // 
            labelProduct.AutoSize = true;
            labelProduct.Location = new Point(38, 278);
            labelProduct.Name = "labelProduct";
            labelProduct.Size = new Size(66, 20);
            labelProduct.TabIndex = 5;
            labelProduct.Text = "Products";
            // 
            // labelDirection
            // 
            labelDirection.AutoSize = true;
            labelDirection.Location = new Point(38, 328);
            labelDirection.Name = "labelDirection";
            labelDirection.Size = new Size(70, 20);
            labelDirection.TabIndex = 6;
            labelDirection.Text = "Direction";
            // 
            // comboBoxDirection
            // 
            comboBoxDirection.AllowDrop = true;
            comboBoxDirection.BackColor = SystemColors.ControlLight;
            comboBoxDirection.ForeColor = SystemColors.WindowText;
            comboBoxDirection.FormattingEnabled = true;
            comboBoxDirection.Items.AddRange(new object[] { "buy", "sell" });
            comboBoxDirection.Location = new Point(174, 328);
            comboBoxDirection.Name = "comboBoxDirection";
            comboBoxDirection.Size = new Size(151, 28);
            comboBoxDirection.TabIndex = 7;
            comboBoxDirection.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // buttonSubmit
            // 
            buttonSubmit.BackColor = SystemColors.ControlLight;
            buttonSubmit.Font = new Font("Trebuchet MS", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonSubmit.Location = new Point(231, 429);
            buttonSubmit.Name = "buttonSubmit";
            buttonSubmit.Size = new Size(94, 29);
            buttonSubmit.TabIndex = 8;
            buttonSubmit.Text = "SUBMIT";
            buttonSubmit.UseVisualStyleBackColor = false;
            buttonSubmit.Click += button1_Click;
            // 
            // labelStatus
            // 
            labelStatus.AutoSize = true;
            labelStatus.Location = new Point(281, 474);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new Size(0, 20);
            labelStatus.TabIndex = 9;
            // 
            // textBoxProduct
            // 
            textBoxProduct.BackColor = SystemColors.ControlLight;
            textBoxProduct.Location = new Point(174, 278);
            textBoxProduct.Name = "textBoxProduct";
            textBoxProduct.Size = new Size(151, 27);
            textBoxProduct.TabIndex = 11;
            // 
            // textBoxQuantity
            // 
            textBoxQuantity.BackColor = SystemColors.ControlLight;
            textBoxQuantity.Location = new Point(174, 225);
            textBoxQuantity.Name = "textBoxQuantity";
            textBoxQuantity.Size = new Size(151, 27);
            textBoxQuantity.TabIndex = 12;
            // 
            // textBoxPrice
            // 
            textBoxPrice.BackColor = SystemColors.ControlLight;
            textBoxPrice.Location = new Point(174, 169);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.Size = new Size(151, 27);
            textBoxPrice.TabIndex = 13;
            // 
            // textBoxCustomerID
            // 
            textBoxCustomerID.BackColor = SystemColors.ControlLight;
            textBoxCustomerID.Location = new Point(174, 122);
            textBoxCustomerID.Name = "textBoxCustomerID";
            textBoxCustomerID.Size = new Size(151, 27);
            textBoxCustomerID.TabIndex = 14;
            // 
            // backButton
            // 
            backButton.BackColor = SystemColors.ControlLight;
            backButton.FlatStyle = FlatStyle.Flat;
            backButton.ForeColor = SystemColors.WindowText;
            backButton.Location = new Point(12, 491);
            backButton.Name = "backButton";
            backButton.Size = new Size(94, 29);
            backButton.TabIndex = 15;
            backButton.Text = "back";
            backButton.UseVisualStyleBackColor = false;
            backButton.Click += backButton_Click;
            // 
            // labelHelloUser
            // 
            labelHelloUser.AutoSize = true;
            labelHelloUser.Font = new Font("Segoe UI", 11F);
            labelHelloUser.Location = new Point(422, 23);
            labelHelloUser.Name = "labelHelloUser";
            labelHelloUser.Size = new Size(0, 25);
            labelHelloUser.TabIndex = 16;
            // 
            // buttonRealtime
            // 
            buttonRealtime.BackColor = SystemColors.ControlLight;
            buttonRealtime.Font = new Font("Trebuchet MS", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonRealtime.ForeColor = SystemColors.ControlText;
            buttonRealtime.Location = new Point(5, 1);
            buttonRealtime.Name = "buttonRealtime";
            buttonRealtime.Size = new Size(103, 27);
            buttonRealtime.TabIndex = 17;
            buttonRealtime.Text = "REALTIME";
            buttonRealtime.UseVisualStyleBackColor = false;
            buttonRealtime.Click += buttonRealtime_Click;
            // 
            // CreateOrder
            // 
            AllowDrop = true;
            BackColor = SystemColors.GradientActiveCaption;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(588, 521);
            Controls.Add(buttonRealtime);
            Controls.Add(labelHelloUser);
            Controls.Add(backButton);
            Controls.Add(textBoxCustomerID);
            Controls.Add(textBoxPrice);
            Controls.Add(textBoxQuantity);
            Controls.Add(textBoxProduct);
            Controls.Add(labelStatus);
            Controls.Add(buttonSubmit);
            Controls.Add(comboBoxDirection);
            Controls.Add(labelDirection);
            Controls.Add(labelProduct);
            Controls.Add(labelQuantity);
            Controls.Add(labelPrice);
            Controls.Add(labelCustomerId);
            Controls.Add(labelOrderId);
            Controls.Add(label1);
            ForeColor = SystemColors.ControlText;
            Name = "CreateOrder";
            Load += OrderForm_Load;
            ResumeLayout(false);
            PerformLayout();

        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            labelHelloUser.Text = $"Hello, {Current.Username}!";

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private Label label1;
        private Label labelOrderId;
        private Label labelCustomerId;
        private Label labelPrice;
        private Label labelQuantity;
        private Label labelProduct;
        private Label labelDirection;
        private ComboBox comboBoxDirection;
        private Button buttonSubmit;
        private Label labelStatus;
        private TextBox textBoxProduct;
        private TextBox textBoxQuantity;
        private TextBox textBoxPrice;
        private Button backButton;
        private Label labelHelloUser;
        private Button buttonRealtime;
        private TextBox textBoxCustomerID;

        private void textBoxOrderId_TextChanged(object sender, EventArgs e)
        {

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Hide();
            var prev = new OrderMenu();
            prev.Show();
        }

        private void buttonRealtime_Click(object sender, EventArgs e)
        {
            Hide();
            var realtime = new Realtime();
            realtime.Show();
        }
    }
}
