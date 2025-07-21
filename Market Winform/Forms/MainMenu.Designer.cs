namespace Market_Winform
{
    partial class MainMenu
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
            buttonProductMenu = new Button();
            buttonOrderMenu = new Button();
            backButton = new Button();
            helloUser = new Label();
            labelHelloUser = new Label();
            SERVICE = new Label();
            buttonRealtime = new Button();
            SuspendLayout();
            // 
            // buttonProductMenu
            // 
            buttonProductMenu.BackColor = SystemColors.ControlLight;
            buttonProductMenu.Font = new Font("Trebuchet MS", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonProductMenu.ForeColor = SystemColors.ControlText;
            buttonProductMenu.Location = new Point(295, 200);
            buttonProductMenu.Name = "buttonProductMenu";
            buttonProductMenu.Size = new Size(179, 48);
            buttonProductMenu.TabIndex = 1;
            buttonProductMenu.Text = "Product Menu";
            buttonProductMenu.UseVisualStyleBackColor = false;
            // 
            // buttonOrderMenu
            // 
            buttonOrderMenu.BackColor = SystemColors.ControlLight;
            buttonOrderMenu.Font = new Font("Trebuchet MS", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonOrderMenu.Location = new Point(295, 287);
            buttonOrderMenu.Name = "buttonOrderMenu";
            buttonOrderMenu.Size = new Size(179, 48);
            buttonOrderMenu.TabIndex = 2;
            buttonOrderMenu.Text = "Order Menu";
            buttonOrderMenu.UseVisualStyleBackColor = false;
            buttonOrderMenu.Click += buttonOrderMenu_Click;
            // 
            // backButton
            // 
            backButton.BackColor = SystemColors.ControlLight;
            backButton.FlatStyle = FlatStyle.Flat;
            backButton.ForeColor = SystemColors.WindowText;
            backButton.Location = new Point(12, 451);
            backButton.Name = "backButton";
            backButton.Size = new Size(94, 29);
            backButton.TabIndex = 7;
            backButton.Text = "back";
            backButton.UseVisualStyleBackColor = false;
            backButton.Click += backButton_Click;
            // 
            // helloUser
            // 
            helloUser.Location = new Point(0, 0);
            helloUser.Name = "helloUser";
            helloUser.Size = new Size(100, 23);
            helloUser.TabIndex = 0;
            // 
            // labelHelloUser
            // 
            labelHelloUser.AutoSize = true;
            labelHelloUser.Font = new Font("Segoe UI", 11F);
            labelHelloUser.Location = new Point(619, 24);
            labelHelloUser.Name = "labelHelloUser";
            labelHelloUser.Size = new Size(0, 25);
            labelHelloUser.TabIndex = 8;
            labelHelloUser.Click += labelHelloUser_Click;
            // 
            // SERVICE
            // 
            SERVICE.AutoSize = true;
            SERVICE.Font = new Font("Trebuchet MS", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SERVICE.Location = new Point(273, 79);
            SERVICE.Name = "SERVICE";
            SERVICE.Size = new Size(233, 36);
            SERVICE.TabIndex = 9;
            SERVICE.Text = "CHOOSE SERVICE";
            SERVICE.Click += label1_Click_1;
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
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(800, 492);
            Controls.Add(buttonRealtime);
            Controls.Add(SERVICE);
            Controls.Add(labelHelloUser);
            Controls.Add(helloUser);
            Controls.Add(backButton);
            Controls.Add(buttonOrderMenu);
            Controls.Add(buttonProductMenu);
            Name = "MainMenu";
            Text = "MainMenu";
            Load += MainMenu_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button buttonProductMenu;
        private Button buttonOrderMenu;
        private Button backButton;
        private Label helloUser;
        private Label labelHelloUser;
        private Label SERVICE;
        private Button buttonRealtime;
    }
}