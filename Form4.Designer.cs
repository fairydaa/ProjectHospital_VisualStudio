namespace hospital_1
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
            button1 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            dataGridView1 = new DataGridView();
            button4 = new Button();
            button5 = new Button();
            label5 = new Label();
            button6 = new Button();
            button2 = new Button();
            button7 = new Button();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(27, 31);
            button1.Name = "button1";
            button1.Size = new Size(94, 23);
            button1.TabIndex = 0;
            button1.Text = "<< Kembali";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(138, 89);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(204, 23);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(138, 118);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(204, 23);
            textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(138, 147);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(204, 23);
            textBox3.TabIndex = 3;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(138, 176);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(204, 23);
            textBox4.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 92);
            label1.Name = "label1";
            label1.Size = new Size(68, 15);
            label1.TabIndex = 5;
            label1.Text = "Nama Obat";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 121);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 6;
            label2.Text = "Indikasi";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 150);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 7;
            label3.Text = "Kuantitas";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 179);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 8;
            label4.Text = "Harga";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(365, 89);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(506, 243);
            dataGridView1.TabIndex = 10;
            // 
            // button4
            // 
            button4.Location = new Point(682, 338);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 12;
            button4.Text = "Edit";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(778, 338);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 13;
            button5.Text = "Hapus";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(589, 71);
            label5.Name = "label5";
            label5.Size = new Size(98, 15);
            label5.TabIndex = 14;
            label5.Text = "Table Daftar Obat";
            // 
            // button6
            // 
            button6.Location = new Point(157, 214);
            button6.Name = "button6";
            button6.Size = new Size(75, 23);
            button6.TabIndex = 20;
            button6.Text = "Reset";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button2
            // 
            button2.Location = new Point(253, 214);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 21;
            button2.Text = "Simpan";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button7
            // 
            button7.Location = new Point(531, 339);
            button7.Name = "button7";
            button7.Size = new Size(75, 23);
            button7.TabIndex = 22;
            button7.Text = "Cari";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(234, 32);
            textBox5.Margin = new Padding(3, 2, 3, 2);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(108, 23);
            textBox5.TabIndex = 27;
            textBox5.Visible = false;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // textBox6
            // 
            textBox6.ForeColor = SystemColors.ScrollBar;
            textBox6.Location = new Point(365, 339);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(147, 23);
            textBox6.TabIndex = 28;
            textBox6.Text = "Cari data obat";
            textBox6.TextChanged += textBox6_TextChanged;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(883, 450);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(button7);
            Controls.Add(button2);
            Controls.Add(button6);
            Controls.Add(label5);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(dataGridView1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Name = "Form4";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Data Obat";
            Load += Form4_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private DataGridView dataGridView1;
        private Button button4;
        private Button button5;
        private Label label5;
        private Button button6;
        private Button button2;
        private Button button7;
        private TextBox textBox5;
        private TextBox textBox6;
    }
}