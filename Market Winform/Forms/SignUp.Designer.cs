namespace Market_Winform.Forms
{
    partial class SignUp
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
            label3 = new Label();
            textBoxUsername = new TextBox();
            textBoxPassword = new TextBox();
            buttonSignUp = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(335, 54);
            label1.Name = "label1";
            label1.Size = new Size(111, 36);
            label1.TabIndex = 0;
            label1.Text = "Sign Up";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(201, 181);
            label2.Name = "label2";
            label2.Size = new Size(111, 26);
            label2.TabIndex = 3;
            label2.Text = "USERNAME";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(201, 247);
            label3.Name = "label3";
            label3.Size = new Size(113, 26);
            label3.TabIndex = 4;
            label3.Text = "PASSWORD";
            // 
            // textBoxUsername
            // 
            textBoxUsername.BackColor = SystemColors.ControlLight;
            textBoxUsername.Location = new Point(351, 180);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(183, 27);
            textBoxUsername.TabIndex = 5;
            textBoxUsername.TextChanged += textBoxUsername_TextChanged;
            // 
            // textBoxPassword
            // 
            textBoxPassword.BackColor = SystemColors.ControlLight;
            textBoxPassword.Location = new Point(351, 248);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.Size = new Size(183, 27);
            textBoxPassword.TabIndex = 7;
            textBoxPassword.TextChanged += textBoxPassword_TextChanged;
            // 
            // buttonSignUp
            // 
            buttonSignUp.BackColor = SystemColors.ControlLight;
            buttonSignUp.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSignUp.Location = new Point(335, 364);
            buttonSignUp.Name = "buttonSignUp";
            buttonSignUp.Size = new Size(126, 38);
            buttonSignUp.TabIndex = 9;
            buttonSignUp.Text = "Sign Up";
            buttonSignUp.UseVisualStyleBackColor = false;
            buttonSignUp.Click += buttonSignUp_Click;
            // 
            // SignUp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonSignUp);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxUsername);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "SignUp";
            Text = "SignUp";
            Load += SignUp_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBoxUsername;
        private TextBox textBoxPassword;
        private Button buttonSignUp;
    }
}