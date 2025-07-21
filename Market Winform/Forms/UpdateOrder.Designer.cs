namespace Market_Winform
{
    partial class UpdateOrder
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
            labelUpdateOrder = new Label();
            textBoxOrderId = new TextBox();
            label2 = new Label();
            backButton = new Button();
            label1 = new Label();
            comboBoxDirection = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBoxPrice = new TextBox();
            textBoxQuantity = new TextBox();
            textBoxProducts = new TextBox();
            buttonUpdate = new Button();
            labelHelloUser = new Label();
            buttonView = new Button();
            gridViewOrders = new DataGridView();
            buttonRealtime = new Button();
            ((System.ComponentModel.ISupportInitialize)gridViewOrders).BeginInit();
            SuspendLayout();
            // 
            // labelUpdateOrder
            // 
            labelUpdateOrder.AutoSize = true;
            labelUpdateOrder.Font = new Font("Trebuchet MS", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelUpdateOrder.Location = new Point(298, 31);
            labelUpdateOrder.Name = "labelUpdateOrder";
            labelUpdateOrder.Size = new Size(280, 36);
            labelUpdateOrder.TabIndex = 0;
            labelUpdateOrder.Text = "EDIT ORDER DETAILS";
            // 
            // textBoxOrderId
            // 
            textBoxOrderId.BackColor = SystemColors.ControlLight;
            textBoxOrderId.Location = new Point(220, 113);
            textBoxOrderId.Name = "textBoxOrderId";
            textBoxOrderId.Size = new Size(125, 27);
            textBoxOrderId.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(72, 112);
            label2.Name = "label2";
            label2.Size = new Size(86, 25);
            label2.TabIndex = 4;
            label2.Text = "Insert ID";
            // 
            // backButton
            // 
            backButton.BackColor = SystemColors.ControlLight;
            backButton.FlatStyle = FlatStyle.Flat;
            backButton.ForeColor = SystemColors.WindowText;
            backButton.Location = new Point(12, 409);
            backButton.Name = "backButton";
            backButton.Size = new Size(94, 29);
            backButton.TabIndex = 7;
            backButton.Text = "back";
            backButton.UseVisualStyleBackColor = false;
            backButton.Click += backButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(43, 175);
            label1.Name = "label1";
            label1.Size = new Size(115, 23);
            label1.TabIndex = 8;
            label1.Text = "Updated Price";
            // 
            // comboBoxDirection
            // 
            comboBoxDirection.AllowDrop = true;
            comboBoxDirection.BackColor = SystemColors.ControlLight;
            comboBoxDirection.FormattingEnabled = true;
            comboBoxDirection.Items.AddRange(new object[] { "buy", "sell" });
            comboBoxDirection.Location = new Point(592, 236);
            comboBoxDirection.Name = "comboBoxDirection";
            comboBoxDirection.Size = new Size(151, 28);
            comboBoxDirection.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Trebuchet MS", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(15, 241);
            label3.Name = "label3";
            label3.Size = new Size(143, 23);
            label3.TabIndex = 10;
            label3.Text = "Updated Quantity";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Trebuchet MS", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(406, 175);
            label4.Name = "label4";
            label4.Size = new Size(143, 23);
            label4.TabIndex = 11;
            label4.Text = "Updated Products";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Trebuchet MS", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(402, 241);
            label5.Name = "label5";
            label5.Size = new Size(147, 23);
            label5.TabIndex = 12;
            label5.Text = "Updated Direction";
            // 
            // textBoxPrice
            // 
            textBoxPrice.BackColor = SystemColors.ControlLight;
            textBoxPrice.Location = new Point(194, 171);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.Size = new Size(151, 27);
            textBoxPrice.TabIndex = 13;
            // 
            // textBoxQuantity
            // 
            textBoxQuantity.BackColor = SystemColors.ControlLight;
            textBoxQuantity.Location = new Point(194, 237);
            textBoxQuantity.Name = "textBoxQuantity";
            textBoxQuantity.Size = new Size(151, 27);
            textBoxQuantity.TabIndex = 14;
            // 
            // textBoxProducts
            // 
            textBoxProducts.BackColor = SystemColors.ControlLight;
            textBoxProducts.Location = new Point(592, 171);
            textBoxProducts.Name = "textBoxProducts";
            textBoxProducts.Size = new Size(151, 27);
            textBoxProducts.TabIndex = 15;
            // 
            // buttonUpdate
            // 
            buttonUpdate.BackColor = SystemColors.ControlLight;
            buttonUpdate.Font = new Font("Trebuchet MS", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonUpdate.Location = new Point(607, 428);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(94, 29);
            buttonUpdate.TabIndex = 16;
            buttonUpdate.Text = "UPDATE";
            buttonUpdate.UseVisualStyleBackColor = false;
            buttonUpdate.Click += button1_Click;
            // 
            // labelHelloUser
            // 
            labelHelloUser.AutoSize = true;
            labelHelloUser.Font = new Font("Segoe UI", 11F);
            labelHelloUser.Location = new Point(656, 9);
            labelHelloUser.Name = "labelHelloUser";
            labelHelloUser.Size = new Size(0, 25);
            labelHelloUser.TabIndex = 17;
            // 
            // buttonView
            // 
            buttonView.BackColor = SystemColors.ControlLight;
            buttonView.Font = new Font("Trebuchet MS", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonView.Location = new Point(484, 108);
            buttonView.Name = "buttonView";
            buttonView.Size = new Size(94, 29);
            buttonView.TabIndex = 18;
            buttonView.Text = "VIEW";
            buttonView.UseVisualStyleBackColor = false;
            buttonView.Click += buttonView_Click;
            // 
            // gridViewOrders
            // 
            gridViewOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridViewOrders.Location = new Point(6, 308);
            gridViewOrders.Name = "gridViewOrders";
            gridViewOrders.RowHeadersWidth = 51;
            gridViewOrders.Size = new Size(782, 95);
            gridViewOrders.TabIndex = 19;
            // 
            // buttonRealtime
            // 
            buttonRealtime.BackColor = SystemColors.ControlLight;
            buttonRealtime.Font = new Font("Trebuchet MS", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonRealtime.ForeColor = SystemColors.ControlText;
            buttonRealtime.Location = new Point(12, 12);
            buttonRealtime.Name = "buttonRealtime";
            buttonRealtime.Size = new Size(103, 27);
            buttonRealtime.TabIndex = 20;
            buttonRealtime.Text = "REALTIME";
            buttonRealtime.UseVisualStyleBackColor = false;
            buttonRealtime.Click += buttonRealtime_Click;
            // 
            // UpdateOrder
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(800, 515);
            Controls.Add(buttonRealtime);
            Controls.Add(gridViewOrders);
            Controls.Add(buttonView);
            Controls.Add(labelHelloUser);
            Controls.Add(buttonUpdate);
            Controls.Add(textBoxProducts);
            Controls.Add(textBoxQuantity);
            Controls.Add(textBoxPrice);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(comboBoxDirection);
            Controls.Add(label1);
            Controls.Add(backButton);
            Controls.Add(label2);
            Controls.Add(textBoxOrderId);
            Controls.Add(labelUpdateOrder);
            Name = "UpdateOrder";
            Text = "UpdateOrder";
            Load += UpdateOrder_Load;
            ((System.ComponentModel.ISupportInitialize)gridViewOrders).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelUpdateOrder;
        private TextBox textBoxOrderId;
        private Label label2;
        private Button backButton;
        private Label label1;
        private ComboBox comboBoxDirection;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBoxPrice;
        private TextBox textBoxQuantity;
        private TextBox textBoxProducts;
        private Button buttonUpdate;
        private Label labelHelloUser;
        private Button buttonView;
        private DataGridView gridViewOrders;
        private Button buttonRealtime;
    }
}