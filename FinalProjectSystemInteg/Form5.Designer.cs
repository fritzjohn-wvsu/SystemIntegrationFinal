
namespace FinalProjectSystemInteg
{
    partial class Form5
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
            components = new System.ComponentModel.Container();
            dataGridView1 = new DataGridView();
            bindingSource1 = new BindingSource(components);
            label4 = new Label();
            Product = new TextBox();
            label5 = new Label();
            label6 = new Label();
            TotalPrice = new Label();
            Receipt = new Label();
            label8 = new Label();
            Clear = new Button();
            Confirm = new Button();
            pQuantity = new TextBox();
            pictureBox6 = new PictureBox();
            button2 = new Button();
            button3 = new Button();
            label1 = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            button1 = new Button();
            label2 = new Label();
            label7 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox7 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = Color.Black;
            dataGridView1.Location = new Point(246, 52);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(557, 244);
            dataGridView1.TabIndex = 11;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.LavenderBlush;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.Location = new Point(247, 18);
            label4.Name = "label4";
            label4.Size = new Size(125, 28);
            label4.TabIndex = 12;
            label4.Text = "Product List";
            // 
            // Product
            // 
            Product.Location = new Point(246, 342);
            Product.Name = "Product";
            Product.Size = new Size(196, 27);
            Product.TabIndex = 13;
            Product.TextChanged += Product_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.LavenderBlush;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label5.Location = new Point(247, 310);
            label5.Name = "label5";
            label5.Size = new Size(112, 20);
            label5.TabIndex = 14;
            label5.Text = "Product Name:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.LavenderBlush;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label6.Location = new Point(845, 19);
            label6.Name = "label6";
            label6.Size = new Size(83, 28);
            label6.TabIndex = 16;
            label6.Text = "Receipt";
            // 
            // TotalPrice
            // 
            TotalPrice.AutoSize = true;
            TotalPrice.BackColor = Color.LavenderBlush;
            TotalPrice.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TotalPrice.Location = new Point(854, 310);
            TotalPrice.Name = "TotalPrice";
            TotalPrice.Size = new Size(80, 20);
            TotalPrice.TabIndex = 20;
            TotalPrice.Text = "Total Price";
            // 
            // Receipt
            // 
            Receipt.AutoSize = true;
            Receipt.BackColor = Color.White;
            Receipt.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Receipt.Location = new Point(865, 64);
            Receipt.Name = "Receipt";
            Receipt.Size = new Size(0, 20);
            Receipt.TabIndex = 21;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.LavenderBlush;
            label8.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label8.Location = new Point(556, 310);
            label8.Name = "label8";
            label8.Size = new Size(72, 20);
            label8.TabIndex = 23;
            label8.Text = "Quantity:";
            // 
            // Clear
            // 
            Clear.Location = new Point(380, 384);
            Clear.Name = "Clear";
            Clear.Size = new Size(94, 29);
            Clear.TabIndex = 24;
            Clear.Text = "Clear";
            Clear.UseVisualStyleBackColor = true;
            Clear.Click += Clear_Click;
            // 
            // Confirm
            // 
            Confirm.Location = new Point(246, 384);
            Confirm.Name = "Confirm";
            Confirm.Size = new Size(94, 29);
            Confirm.TabIndex = 27;
            Confirm.Text = "Confirm";
            Confirm.UseVisualStyleBackColor = true;
            Confirm.Click += Confirm_Click;
            // 
            // pQuantity
            // 
            pQuantity.Location = new Point(556, 342);
            pQuantity.Name = "pQuantity";
            pQuantity.Size = new Size(196, 27);
            pQuantity.TabIndex = 28;
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = Color.White;
            pictureBox6.Location = new Point(854, 52);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(301, 244);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 29;
            pictureBox6.TabStop = false;
            pictureBox6.Click += pictureBox6_Click;
            // 
            // button2
            // 
            button2.Location = new Point(854, 355);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 30;
            button2.Text = "Checkout";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // button3
            // 
            button3.Location = new Point(1061, 355);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 31;
            button3.Text = "Void";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI", 9F);
            label1.Location = new Point(81, 128);
            label1.Name = "label1";
            label1.Size = new Size(81, 20);
            label1.TabIndex = 44;
            label1.Text = "Employees";
            label1.Click += label1_Click_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.LavenderBlush;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(79, 184);
            label3.Name = "label3";
            label3.Size = new Size(117, 20);
            label3.TabIndex = 40;
            label3.Text = "Quick Checkout";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Image = Properties.Resources.Floratech__5_;
            pictureBox1.Location = new Point(-12, 87);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(105, 86);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 46;
            pictureBox1.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.White;
            pictureBox4.Image = Properties.Resources.Floratech__4_;
            pictureBox4.Location = new Point(-19, 151);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(114, 82);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 45;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.White;
            pictureBox5.Image = Properties.Resources.Floratech__3_;
            pictureBox5.Location = new Point(5, 292);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(70, 61);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 43;
            pictureBox5.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.LavenderBlush;
            button1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(56, 383);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 41;
            button1.Text = "Logout";
            button1.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Location = new Point(81, 311);
            label2.Name = "label2";
            label2.Size = new Size(108, 20);
            label2.TabIndex = 39;
            label2.Text = "Sales Overview";
            label2.Click += label2_Click_2;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.White;
            label7.Font = new Font("Segoe UI", 9F);
            label7.Location = new Point(80, 248);
            label7.Name = "label7";
            label7.Size = new Size(86, 20);
            label7.TabIndex = 38;
            label7.Text = "Product List";
            label7.Click += label7_Click_1;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.White;
            pictureBox2.Image = Properties.Resources.Floratech;
            pictureBox2.Location = new Point(22, -4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(159, 101);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 37;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.White;
            pictureBox3.Image = Properties.Resources.Floratech__1_;
            pictureBox3.Location = new Point(-20, 207);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(112, 94);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 42;
            pictureBox3.TabStop = false;
            // 
            // pictureBox7
            // 
            pictureBox7.BackColor = Color.White;
            pictureBox7.Location = new Point(-1, -9);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(222, 460);
            pictureBox7.TabIndex = 36;
            pictureBox7.TabStop = false;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            ClientSize = new Size(1183, 450);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox5);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label7);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox7);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(pQuantity);
            Controls.Add(Confirm);
            Controls.Add(Clear);
            Controls.Add(label8);
            Controls.Add(Receipt);
            Controls.Add(TotalPrice);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(Product);
            Controls.Add(label4);
            Controls.Add(dataGridView1);
            Controls.Add(pictureBox6);
            Name = "Form5";
            Text = "Form5";
            Load += Form5_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            throw new NotImplementedException();
        }

#endregion
        private DataGridView dataGridView1;
        private BindingSource bindingSource1;
        private Label label4;
        private TextBox Product;
        private Label label5;
        private Label label6;
        private Label TotalPrice;
        private Label Receipt;
        private Label label8;
        private Button Clear;
        private Button Confirm;
        private TextBox pQuantity;
        private PictureBox pictureBox6;
        private Button button2;
        private Button button3;
        private Label label1;
        private Label label3;
        private PictureBox pictureBox1;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private Button button1;
        private Label label2;
        private Label label7;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox7;
    }
}