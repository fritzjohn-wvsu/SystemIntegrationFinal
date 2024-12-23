namespace FinalProjectSystemInteg
{
    partial class Form4
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
            productName = new TextBox();
            stockQuantity = new TextBox();
            Save = new Button();
            category = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(275, 44);
            label1.Name = "label1";
            label1.Size = new Size(213, 46);
            label1.TabIndex = 0;
            label1.Text = "Add Product";
            // 
            // productName
            // 
            productName.Location = new Point(219, 146);
            productName.Name = "productName";
            productName.Size = new Size(323, 27);
            productName.TabIndex = 1;
            productName.TextChanged += productName_TextChanged;
            // 
            // stockQuantity
            // 
            stockQuantity.Location = new Point(219, 284);
            stockQuantity.Name = "stockQuantity";
            stockQuantity.Size = new Size(323, 27);
            stockQuantity.TabIndex = 2;
            stockQuantity.TextChanged += stockQuantity_TextChanged;
            // 
            // Save
            // 
            Save.Location = new Point(219, 337);
            Save.Name = "Save";
            Save.Size = new Size(94, 29);
            Save.TabIndex = 3;
            Save.Text = "Save";
            Save.UseVisualStyleBackColor = true;
            Save.Click += Save_Click;
            // 
            // category
            // 
            category.FormattingEnabled = true;
            category.Items.AddRange(new object[] { "Fresh Flowers", "Artificial Flowers" });
            category.Location = new Point(219, 215);
            category.Name = "category";
            category.Size = new Size(323, 28);
            category.TabIndex = 4;
            category.SelectedIndexChanged += category_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(218, 120);
            label2.Name = "label2";
            label2.Size = new Size(111, 20);
            label2.TabIndex = 5;
            label2.Text = "Product Name: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(218, 190);
            label3.Name = "label3";
            label3.Size = new Size(76, 20);
            label3.TabIndex = 6;
            label3.Text = "Category: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(219, 261);
            label4.Name = "label4";
            label4.Size = new Size(112, 20);
            label4.TabIndex = 7;
            label4.Text = "Stock Quantity: ";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Back;
            pictureBox1.Location = new Point(20, 15);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(27, 28);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(category);
            Controls.Add(Save);
            Controls.Add(stockQuantity);
            Controls.Add(productName);
            Controls.Add(label1);
            Name = "Form4";
            Text = "Form4";
            Load += Form4_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox productName;
        private TextBox stockQuantity;
        private Button Save;
        private ComboBox category;
        private Label label2;
        private Label label3;
        private Label label4;
        private PictureBox pictureBox1;
    }
}