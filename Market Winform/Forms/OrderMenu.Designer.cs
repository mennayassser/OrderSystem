namespace Market_Winform
{
    partial class OrderMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            buttonCreateOrder = new Button();
            buttonUpdateOrder = new Button();
            buttonGetAll = new Button();
            buttonGetOrderById = new Button();
            buttonDeleteOrder = new Button();
            backButton = new Button();
            labelHelloUser = new Label();
            buttonRealtime = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 18F, FontStyle.Bold);
            label1.Location = new Point(302, 47);
            label1.Name = "label1";
            label1.Size = new Size(198, 38);
            label1.TabIndex = 0;
            label1.Text = "ORDER MENU";
            label1.Click += label1_Click;
            // 
            // buttonCreateOrder
            // 
            buttonCreateOrder.BackColor = SystemColors.ControlLight;
            buttonCreateOrder.Font = new Font("Trebuchet MS", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonCreateOrder.Location = new Point(302, 137);
            buttonCreateOrder.Name = "buttonCreateOrder";
            buttonCreateOrder.Size = new Size(184, 38);
            buttonCreateOrder.TabIndex = 1;
            buttonCreateOrder.Text = "CREATE ORDER";
            buttonCreateOrder.UseVisualStyleBackColor = false;
            buttonCreateOrder.Click += buttonCreateOrder_Click;
            // 
            // buttonUpdateOrder
            // 
            buttonUpdateOrder.BackColor = SystemColors.ControlLight;
            buttonUpdateOrder.Font = new Font("Trebuchet MS", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonUpdateOrder.Location = new Point(302, 306);
            buttonUpdateOrder.Name = "buttonUpdateOrder";
            buttonUpdateOrder.Size = new Size(184, 38);
            buttonUpdateOrder.TabIndex = 2;
            buttonUpdateOrder.Text = "UPDATE ORDER";
            buttonUpdateOrder.UseVisualStyleBackColor = false;
            buttonUpdateOrder.Click += buttonUpdateOrder_Click;
            // 
            // buttonGetAll
            // 
            buttonGetAll.BackColor = SystemColors.ControlLight;
            buttonGetAll.Font = new Font("Trebuchet MS", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonGetAll.Location = new Point(302, 194);
            buttonGetAll.Name = "buttonGetAll";
            buttonGetAll.Size = new Size(184, 38);
            buttonGetAll.TabIndex = 3;
            buttonGetAll.Text = "GET ALL ORDERS";
            buttonGetAll.UseVisualStyleBackColor = false;
            buttonGetAll.Click += buttonGetAll_Click;
            // 
            // buttonGetOrderById
            // 
            buttonGetOrderById.BackColor = SystemColors.ControlLight;
            buttonGetOrderById.Font = new Font("Trebuchet MS", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonGetOrderById.Location = new Point(302, 252);
            buttonGetOrderById.Name = "buttonGetOrderById";
            buttonGetOrderById.Size = new Size(184, 38);
            buttonGetOrderById.TabIndex = 4;
            buttonGetOrderById.Text = "GET ORDER BY ID";
            buttonGetOrderById.UseVisualStyleBackColor = false;
            buttonGetOrderById.Click += buttonGetOrderById_Click;
            // 
            // buttonDeleteOrder
            // 
            buttonDeleteOrder.BackColor = SystemColors.ControlLight;
            buttonDeleteOrder.Font = new Font("Trebuchet MS", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonDeleteOrder.Location = new Point(302, 363);
            buttonDeleteOrder.Name = "buttonDeleteOrder";
            buttonDeleteOrder.Size = new Size(184, 38);
            buttonDeleteOrder.TabIndex = 5;
            buttonDeleteOrder.Text = "DELETE ORDER";
            buttonDeleteOrder.UseVisualStyleBackColor = false;
            buttonDeleteOrder.Click += buttonDeleteOrder_Click;
            // 
            // backButton
            // 
            backButton.BackColor = SystemColors.ControlLight;
            backButton.FlatStyle = FlatStyle.Flat;
            backButton.ForeColor = SystemColors.WindowText;
            backButton.Location = new Point(12, 487);
            backButton.Name = "backButton";
            backButton.Size = new Size(94, 29);
            backButton.TabIndex = 6;
            backButton.Text = "back";
            backButton.UseVisualStyleBackColor = false;
            backButton.Click += button1_Click;
            // 
            // labelHelloUser
            // 
            labelHelloUser.AutoSize = true;
            labelHelloUser.Font = new Font("Segoe UI", 11F);
            labelHelloUser.Location = new Point(658, 9);
            labelHelloUser.Name = "labelHelloUser";
            labelHelloUser.Size = new Size(0, 25);
            labelHelloUser.TabIndex = 9;
            // 
            // buttonRealtime
            // 
            buttonRealtime.BackColor = SystemColors.ControlLight;
            buttonRealtime.Font = new Font("Trebuchet MS", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonRealtime.ForeColor = SystemColors.ControlText;
            buttonRealtime.Location = new Point(12, 12);
            buttonRealtime.Name = "buttonRealtime";
            buttonRealtime.Size = new Size(103, 27);
            buttonRealtime.TabIndex = 18;
            buttonRealtime.Text = "REALTIME";
            buttonRealtime.UseVisualStyleBackColor = false;
            buttonRealtime.Click += buttonRealtime_Click;
            // 
            // OrderMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(800, 528);
            Controls.Add(buttonRealtime);
            Controls.Add(labelHelloUser);
            Controls.Add(backButton);
            Controls.Add(buttonDeleteOrder);
            Controls.Add(buttonGetOrderById);
            Controls.Add(buttonGetAll);
            Controls.Add(buttonUpdateOrder);
            Controls.Add(buttonCreateOrder);
            Controls.Add(label1);
            ForeColor = SystemColors.ControlText;
            Name = "OrderMenu";
            Text = "OrderMenu";
            Load += OrderMenu_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button buttonCreateOrder;
        private Button buttonUpdateOrder;
        private Button buttonGetAll;
        private Button buttonGetOrderById;
        private Button buttonDeleteOrder;
        private Button backButton;
        private Label labelHelloUser;
        private Button buttonRealtime;
    }
}