namespace Market_Winform
{
    partial class DeleteOrder
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
            buttonDelete = new Button();
            backButton = new Button();
            labelHelloUser = new Label();
            buttonRealtime = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(301, 55);
            label1.Name = "label1";
            label1.Size = new Size(217, 36);
            label1.TabIndex = 0;
            label1.Text = "DELETE ORDER ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(106, 175);
            label2.Name = "label2";
            label2.Size = new Size(145, 26);
            label2.TabIndex = 1;
            label2.Text = "Insert Order ID";
            label2.Click += label2_Click;
            // 
            // textBoxOrderId
            // 
            textBoxOrderId.BackColor = SystemColors.ControlLight;
            textBoxOrderId.Location = new Point(316, 174);
            textBoxOrderId.Name = "textBoxOrderId";
            textBoxOrderId.Size = new Size(125, 27);
            textBoxOrderId.TabIndex = 2;
            // 
            // buttonDelete
            // 
            buttonDelete.BackColor = SystemColors.ControlLight;
            buttonDelete.Font = new Font("Trebuchet MS", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonDelete.Location = new Point(519, 172);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(94, 29);
            buttonDelete.TabIndex = 3;
            buttonDelete.Text = "DELETE";
            buttonDelete.UseVisualStyleBackColor = false;
            buttonDelete.Click += buttonDelete_Click;
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
            labelHelloUser.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelHelloUser.Location = new Point(613, 24);
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
            // DeleteOrder
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonRealtime);
            Controls.Add(labelHelloUser);
            Controls.Add(backButton);
            Controls.Add(buttonDelete);
            Controls.Add(textBoxOrderId);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "DeleteOrder";
            Text = "Delete";
            Load += DeleteOrder_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBoxOrderId;
        private Button buttonDelete;
        private Button backButton;
        private Label labelHelloUser;
        private Button buttonRealtime;
    }
}