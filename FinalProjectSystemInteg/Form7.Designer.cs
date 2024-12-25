
namespace FinalProjectSystemInteg
{
    partial class Form7
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
            pictureBox1 = new PictureBox();
            label5 = new Label();
            price = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            category = new ComboBox();
            Save = new Button();
            stockQuantity = new TextBox();
            productName = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold);
            label1.Location = new Point(296, 50);
            label1.Name = "label1";
            label1.Size = new Size(209, 46);
            label1.TabIndex = 0;
            label1.Text = "Edit Product";
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Back;
            pictureBox1.Location = new Point(34, 25);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(27, 28);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(240, 306);
            label5.Name = "label5";
            label5.Size = new Size(48, 20);
            label5.TabIndex = 19;
            label5.Text = "Price: ";
            // 
            // price
            // 
            price.Location = new Point(239, 334);
            price.Name = "price";
            price.Size = new Size(323, 27);
            price.TabIndex = 18;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(240, 248);
            label4.Name = "label4";
            label4.Size = new Size(112, 20);
            label4.TabIndex = 17;
            label4.Text = "Stock Quantity: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(239, 177);
            label3.Name = "label3";
            label3.Size = new Size(76, 20);
            label3.TabIndex = 16;
            label3.Text = "Category: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(239, 107);
            label2.Name = "label2";
            label2.Size = new Size(111, 20);
            label2.TabIndex = 15;
            label2.Text = "Product Name: ";
            // 
            // category
            // 
            category.FormattingEnabled = true;
            category.Items.AddRange(new object[] { "Fresh Flowers", "Artificial Flowers" });
            category.Location = new Point(240, 202);
            category.Name = "category";
            category.Size = new Size(323, 28);
            category.TabIndex = 14;
            // 
            // Save
            // 
            Save.Location = new Point(240, 376);
            Save.Name = "Save";
            Save.Size = new Size(94, 29);
            Save.TabIndex = 13;
            Save.Text = "Save";
            Save.UseVisualStyleBackColor = true;
            Save.Click += Save_Click;
            // 
            // stockQuantity
            // 
            stockQuantity.Location = new Point(240, 271);
            stockQuantity.Name = "stockQuantity";
            stockQuantity.Size = new Size(323, 27);
            stockQuantity.TabIndex = 12;
            // 
            // productName
            // 
            productName.Location = new Point(240, 133);
            productName.Name = "productName";
            productName.Size = new Size(323, 27);
            productName.TabIndex = 11;
            // 
            // Form7
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(price);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(category);
            Controls.Add(Save);
            Controls.Add(stockQuantity);
            Controls.Add(productName);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Name = "Form7";
            Text = "Form7";
            Load += Form7_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private Label label5;
        private TextBox price;
        private Label label4;
        private Label label3;
        private Label label2;
        private ComboBox category;
        private Button Save;
        private TextBox stockQuantity;
        private TextBox productName;
    }
}