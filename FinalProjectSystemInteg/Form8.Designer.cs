namespace FinalProjectSystemInteg
{
    partial class Form8
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
            label4 = new Label();
            dataGridView1 = new DataGridView();
            filter = new ComboBox();
            search = new TextBox();
            label5 = new Label();
            button2 = new Button();
            button3 = new Button();
            pictureBox6 = new PictureBox();
            button4 = new Button();
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
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.LavenderBlush;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.Location = new Point(245, 30);
            label4.Name = "label4";
            label4.Size = new Size(102, 28);
            label4.TabIndex = 20;
            label4.Text = "Overview";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(499, 91);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(554, 319);
            dataGridView1.TabIndex = 21;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // filter
            // 
            filter.FormattingEnabled = true;
            filter.Location = new Point(901, 57);
            filter.Name = "filter";
            filter.Size = new Size(151, 28);
            filter.TabIndex = 22;
            filter.SelectedIndexChanged += filter_SelectedIndexChanged;
            // 
            // search
            // 
            search.Location = new Point(245, 120);
            search.Name = "search";
            search.Size = new Size(225, 27);
            search.TabIndex = 23;
            search.TextChanged += textBox1_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.LavenderBlush;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(245, 88);
            label5.Name = "label5";
            label5.Size = new Size(59, 20);
            label5.TabIndex = 24;
            label5.Text = "Search:";
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(245, 162);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 25;
            button2.Text = "Search";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.White;
            button3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(372, 231);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 26;
            button3.Text = "Delete all";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = Color.Black;
            pictureBox6.Location = new Point(243, 200);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(230, 2);
            pictureBox6.TabIndex = 27;
            pictureBox6.TabStop = false;
            // 
            // button4
            // 
            button4.BackColor = Color.White;
            button4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Location = new Point(243, 232);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 28;
            button4.Text = "Delete";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI", 9F);
            label1.Location = new Point(81, 132);
            label1.Name = "label1";
            label1.Size = new Size(81, 20);
            label1.TabIndex = 44;
            label1.Text = "Employees";
            label1.Click += label1_Click_2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Location = new Point(79, 188);
            label3.Name = "label3";
            label3.Size = new Size(111, 20);
            label3.TabIndex = 40;
            label3.Text = "Quick Checkout";
            label3.Click += label3_Click_2;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Image = Properties.Resources.Floratech__5_;
            pictureBox1.Location = new Point(-12, 91);
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
            pictureBox4.Location = new Point(-19, 155);
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
            pictureBox5.Location = new Point(5, 296);
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
            button1.Location = new Point(56, 387);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 41;
            button1.Text = "Logout";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.LavenderBlush;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(81, 315);
            label2.Name = "label2";
            label2.Size = new Size(114, 20);
            label2.TabIndex = 39;
            label2.Text = "Sales Overview";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.White;
            label7.Font = new Font("Segoe UI", 9F);
            label7.Location = new Point(80, 252);
            label7.Name = "label7";
            label7.Size = new Size(86, 20);
            label7.TabIndex = 38;
            label7.Text = "Product List";
            label7.Click += label7_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.White;
            pictureBox2.Image = Properties.Resources.Floratech;
            pictureBox2.Location = new Point(22, 0);
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
            pictureBox3.Location = new Point(-20, 211);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(112, 94);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 42;
            pictureBox3.TabStop = false;
            // 
            // pictureBox7
            // 
            pictureBox7.BackColor = Color.White;
            pictureBox7.Location = new Point(-1, -5);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(222, 460);
            pictureBox7.TabIndex = 36;
            pictureBox7.TabStop = false;
            pictureBox7.Click += pictureBox7_Click;
            // 
            // Form8
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            ClientSize = new Size(1085, 450);
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
            Controls.Add(button4);
            Controls.Add(pictureBox6);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label5);
            Controls.Add(search);
            Controls.Add(filter);
            Controls.Add(dataGridView1);
            Controls.Add(label4);
            Name = "Form8";
            Text = "Form8";
            Load += Form8_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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

        #endregion
        private Label label4;
        private DataGridView dataGridView1;
        private ComboBox filter;
        private TextBox search;
        private Label label5;
        private Button button2;
        private Button button3;
        private PictureBox pictureBox6;
        private Button button4;
        private TextBox textBox1;
        private Label label6;
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