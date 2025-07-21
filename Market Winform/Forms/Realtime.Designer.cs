namespace Market_Winform
{
    partial class Realtime
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
            RealtimeDataGrid = new DataGridView();
            backButton = new Button();
            labelHelloUser = new Label();
            ((System.ComponentModel.ISupportInitialize)RealtimeDataGrid).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(279, 40);
            label1.Name = "label1";
            label1.Size = new Size(265, 36);
            label1.TabIndex = 0;
            label1.Text = "REALTIME UPDATES";
            label1.Click += label1_Click;
            // 
            // RealtimeDataGrid
            // 
            RealtimeDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            RealtimeDataGrid.Location = new Point(12, 135);
            RealtimeDataGrid.Name = "RealtimeDataGrid";
            RealtimeDataGrid.RowHeadersWidth = 51;
            RealtimeDataGrid.Size = new Size(776, 239);
            RealtimeDataGrid.TabIndex = 1;
            RealtimeDataGrid.CellContentClick += dataGridView1_CellContentClick;
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
            // labelHelloUser
            // 
            labelHelloUser.AutoSize = true;
            labelHelloUser.Font = new Font("Segoe UI", 11F);
            labelHelloUser.Location = new Point(638, 18);
            labelHelloUser.Name = "labelHelloUser";
            labelHelloUser.Size = new Size(0, 25);
            labelHelloUser.TabIndex = 10;
            // 
            // Realtime
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(labelHelloUser);
            Controls.Add(backButton);
            Controls.Add(RealtimeDataGrid);
            Controls.Add(label1);
            Name = "Realtime";
            Text = "Realtime";
            Load += Realtime_Load;
            ((System.ComponentModel.ISupportInitialize)RealtimeDataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView RealtimeDataGrid;
        private Button backButton;
        private Label labelHelloUser;
    }
}