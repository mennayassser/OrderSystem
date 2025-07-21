namespace Market_Winform
{
    partial class GetAllOrders
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
            ordersGridView = new DataGridView();
            backButton = new Button();
            labelHelloUser = new Label();
            buttonRealtime = new Button();
            ((System.ComponentModel.ISupportInitialize)ordersGridView).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(324, 51);
            label1.Name = "label1";
            label1.Size = new Size(172, 36);
            label1.TabIndex = 0;
            label1.Text = "ALL ORDERS";
            label1.Click += label1_Click;
            // 
            // ordersGridView
            // 
            ordersGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ordersGridView.Location = new Point(2, 121);
            ordersGridView.Name = "ordersGridView";
            ordersGridView.RowHeadersWidth = 51;
            ordersGridView.Size = new Size(809, 278);
            ordersGridView.TabIndex = 1;
            ordersGridView.CellContentClick += dataGridView1_CellContentClick;
            // 
            // backButton
            // 
            backButton.BackColor = SystemColors.ControlLight;
            backButton.FlatStyle = FlatStyle.Flat;
            backButton.ForeColor = SystemColors.WindowText;
            backButton.Location = new Point(12, 437);
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
            labelHelloUser.Location = new Point(676, 19);
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
            // GetAllOrders
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(833, 467);
            Controls.Add(buttonRealtime);
            Controls.Add(labelHelloUser);
            Controls.Add(backButton);
            Controls.Add(ordersGridView);
            Controls.Add(label1);
            Name = "GetAllOrders";
            Text = "GetAll";
            Load += GetAllOrders_Load;
            ((System.ComponentModel.ISupportInitialize)ordersGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView ordersGridView;
        private Button backButton;
        private Label labelHelloUser;
        private Button buttonRealtime;
    }
}