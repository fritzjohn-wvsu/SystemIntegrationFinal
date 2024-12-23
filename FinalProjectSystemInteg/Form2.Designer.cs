namespace FinalProjectSystemInteg
{
    partial class Form2
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
            Username = new TextBox();
            Password = new TextBox();
            Login = new Button();
            ShowPass = new CheckBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(330, 58);
            label1.Name = "label1";
            label1.Size = new Size(124, 46);
            label1.TabIndex = 0;
            label1.Text = "LOGIN";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(226, 153);
            label2.Name = "label2";
            label2.Size = new Size(78, 20);
            label2.TabIndex = 1;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(226, 241);
            label3.Name = "label3";
            label3.Size = new Size(73, 20);
            label3.TabIndex = 2;
            label3.Text = "Password";
            // 
            // Username
            // 
            Username.BackColor = Color.White;
            Username.Location = new Point(226, 181);
            Username.Name = "Username";
            Username.Size = new Size(325, 27);
            Username.TabIndex = 3;
            // 
            // Password
            // 
            Password.BackColor = Color.White;
            Password.Location = new Point(226, 272);
            Password.Name = "Password";
            Password.PasswordChar = '*';
            Password.Size = new Size(325, 27);
            Password.TabIndex = 4;
            // 
            // Login
            // 
            Login.Location = new Point(338, 356);
            Login.Name = "Login";
            Login.Size = new Size(94, 29);
            Login.TabIndex = 5;
            Login.Text = "Login";
            Login.UseVisualStyleBackColor = true;
            Login.Click += Login_Click;
            // 
            // ShowPass
            // 
            ShowPass.AutoSize = true;
            ShowPass.Font = new Font("Segoe UI", 6F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ShowPass.Location = new Point(226, 314);
            ShowPass.Name = "ShowPass";
            ShowPass.Size = new Size(95, 17);
            ShowPass.TabIndex = 6;
            ShowPass.Text = "Show Password";
            ShowPass.UseVisualStyleBackColor = true;
            ShowPass.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 473);
            Controls.Add(ShowPass);
            Controls.Add(Login);
            Controls.Add(Password);
            Controls.Add(Username);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox Username;
        private TextBox Password;
        private Button Login;
        private CheckBox ShowPass;
    }
}