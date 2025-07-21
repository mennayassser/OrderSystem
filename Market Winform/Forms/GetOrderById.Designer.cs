namespace Market_Winform
{
    partial class GetOrderById
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
            label2 = new Label();
            textBoxOrderId = new TextBox();
            buttonSearchById = new Button();
            gridViewOrders = new DataGridView();
            backButton = new Button();
            labelHelloUser = new Label();
            buttonRealtime = new Button();
            ((System.ComponentModel.ISupportInitialize)gridViewOrders).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(250, 43);
            label1.Name = "label1";
            label1.Size = new Size(316, 36);
            label1.TabIndex = 0;
            label1.Text = "SEARCH FOR AN ORDER";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(102, 164);
            label2.Name = "label2";
            label2.Size = new Size(86, 25);
            label2.TabIndex = 1;
            label2.Text = "Insert ID";
            label2.Click += label2_Click_1;
            // 
            // textBoxOrderId
            // 
            textBoxOrderId.BackColor = SystemColors.ControlLight;
            textBoxOrderId.Location = new Point(293, 162);
            textBoxOrderId.Name = "textBoxOrderId";
            textBoxOrderId.Size = new Size(125, 27);
            textBoxOrderId.TabIndex = 2;
            // 
            // buttonSearchById
            // 
            buttonSearchById.BackColor = SystemColors.ControlLight;
            buttonSearchById.Font = new Font("Trebuchet MS", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSearchById.Location = new Point(536, 160);
            buttonSearchById.Name = "buttonSearchById";
            buttonSearchById.Size = new Size(94, 29);
            buttonSearchById.TabIndex = 4;
            buttonSearchById.Text = "SEARCH";
            buttonSearchById.UseVisualStyleBackColor = false;
            buttonSearchById.Click += buttonSearchById_Click;
            // 
            // gridViewOrders
            // 
            gridViewOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridViewOrders.Location = new Point(23, 290);
            gridViewOrders.Name = "gridViewOrders";
            gridViewOrders.RowHeadersWidth = 51;
            gridViewOrders.Size = new Size(742, 95);
            gridViewOrders.TabIndex = 5;
            gridViewOrders.CellContentClick += gridViewOrders_CellContentClick;
            // 
            // backButton
            // 
            backButton.BackColor = SystemColors.ControlLight;
            backButton.FlatStyle = FlatStyle.Flat;
            backButton.ForeColor = SystemColors.WindowText;
            backButton.Location = new Point(12, 473);
            backButton.Name = "backButton";
            backButton.Size = new Size(94, 29);
            backButton.TabIndex = 7;
            backButton.Text = "back";
            backButton.UseVisualStyleBackColor = false;
            backButton.Click += backButton_Click;
            // 
            // labelHelloUser
            // 
            labelHelloUser.AutoSize = true;
            labelHelloUser.Font = new Font("Segoe UI", 11F);
            labelHelloUser.Location = new Point(797, 9);
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
            // GetOrderById
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(944, 514);
            Controls.Add(buttonRealtime);
            Controls.Add(labelHelloUser);
            Controls.Add(backButton);
            Controls.Add(gridViewOrders);
            Controls.Add(buttonSearchById);
            Controls.Add(textBoxOrderId);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "GetOrderById";
            Text = "GetOrderById";
            Load += GetOrderById_Load;
            ((System.ComponentModel.ISupportInitialize)gridViewOrders).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBoxOrderId;
        private Button buttonSearchById;
        private DataGridView gridViewOrders;
        private Button backButton;
        private Label labelHelloUser;
        private Button buttonRealtime;
    }
}