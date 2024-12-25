namespace FinalProjectSystemInteg
{
    partial class Form6
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
            password = new TextBox();
            Confirm = new Button();
            Cancel = new Button();
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // password
            // 
            password.Location = new Point(193, 182);
            password.Name = "password";
            password.Size = new Size(410, 27);
            password.TabIndex = 0;
            // 
            // Confirm
            // 
            Confirm.Location = new Point(509, 232);
            Confirm.Name = "Confirm";
            Confirm.Size = new Size(94, 29);
            Confirm.TabIndex = 1;
            Confirm.Text = "Confirm";
            Confirm.UseVisualStyleBackColor = true;
            Confirm.Click += Confirm_Click;
            // 
            // Cancel
            // 
            Cancel.Location = new Point(193, 232);
            Cancel.Name = "Cancel";
            Cancel.Size = new Size(94, 29);
            Cancel.TabIndex = 2;
            Cancel.Text = "Cancel";
            Cancel.UseVisualStyleBackColor = true;
            Cancel.Click += Cancel_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(193, 148);
            label1.Name = "label1";
            label1.Size = new Size(136, 20);
            label1.TabIndex = 3;
            label1.Text = "Input the Password:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(329, 83);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Floratech;
            pictureBox1.Location = new Point(335, 27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(115, 92);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Cancel);
            Controls.Add(Confirm);
            Controls.Add(password);
            Name = "Form6";
            Text = "Form6";
            Load += Form6_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox password;
        private Button Confirm;
        private Button Cancel;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
    }
}