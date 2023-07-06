namespace hospital_1
{
    partial class Form3
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
            textBox4 = new TextBox();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            button4 = new Button();
            button5 = new Button();
            dataGridView1 = new DataGridView();
            label7 = new Label();
            dateTimePicker1 = new DateTimePicker();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            comboBox1 = new ComboBox();
            textBox3 = new TextBox();
            button3 = new Button();
            button6 = new Button();
            textBox5 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(26, 28);
            button1.Name = "button1";
            button1.Size = new Size(123, 23);
            button1.TabIndex = 0;
            button1.Text = "<< Kembali";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(127, 85);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(216, 23);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(127, 114);
            textBox2.MaxLength = 16;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(216, 23);
            textBox2.TabIndex = 2;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(127, 172);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(216, 23);
            textBox4.TabIndex = 4;
            // 
            // button2
            // 
            button2.Location = new Point(223, 265);
            button2.Name = "button2";
            button2.Size = new Size(119, 23);
            button2.TabIndex = 7;
            button2.Text = "Simpan";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 88);
            label1.Name = "label1";
            label1.Size = new Size(87, 15);
            label1.TabIndex = 8;
            label1.Text = "Nama Lengkap";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 117);
            label2.Name = "label2";
            label2.Size = new Size(79, 15);
            label2.TabIndex = 9;
            label2.Text = "NIK (No. KTP)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 146);
            label3.Name = "label3";
            label3.Size = new Size(77, 15);
            label3.TabIndex = 10;
            label3.Text = "Tanggal Lahir";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 175);
            label4.Name = "label4";
            label4.Size = new Size(75, 15);
            label4.TabIndex = 11;
            label4.Text = "Tempat Lahir";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(26, 204);
            label5.Name = "label5";
            label5.Size = new Size(78, 15);
            label5.TabIndex = 12;
            label5.Text = "Jenis Kelamin";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(26, 233);
            label6.Name = "label6";
            label6.Size = new Size(65, 15);
            label6.TabIndex = 13;
            label6.Text = "Spesialisasi";
            // 
            // button4
            // 
            button4.Location = new Point(847, 338);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 18;
            button4.Text = "Hapus";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(126, 265);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 19;
            button5.Text = "Reset";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(361, 85);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(561, 246);
            dataGridView1.TabIndex = 20;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(593, 67);
            label7.Name = "label7";
            label7.Size = new Size(107, 15);
            label7.TabIndex = 21;
            label7.Text = "Table Daftar Dokter";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(127, 142);
            dateTimePicker1.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(216, 23);
            dateTimePicker1.TabIndex = 22;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(127, 201);
            radioButton1.Margin = new Padding(3, 2, 3, 2);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(69, 19);
            radioButton1.TabIndex = 23;
            radioButton1.TabStop = true;
            radioButton1.Text = "Laki-laki";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(251, 202);
            radioButton2.Margin = new Padding(3, 2, 3, 2);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(86, 19);
            radioButton2.TabIndex = 24;
            radioButton2.TabStop = true;
            radioButton2.Text = "Perempuan";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(127, 231);
            comboBox1.Margin = new Padding(3, 2, 3, 2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(216, 23);
            comboBox1.TabIndex = 25;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(223, 31);
            textBox3.Margin = new Padding(3, 2, 3, 2);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(119, 23);
            textBox3.TabIndex = 26;
            textBox3.Visible = false;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // button3
            // 
            button3.Location = new Point(759, 338);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(82, 22);
            button3.TabIndex = 28;
            button3.Text = "Edit";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button6
            // 
            button6.Location = new Point(518, 338);
            button6.Margin = new Padding(3, 2, 3, 2);
            button6.Name = "button6";
            button6.Size = new Size(82, 22);
            button6.TabIndex = 29;
            button6.Text = "Cari";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // textBox5
            // 
            textBox5.ForeColor = SystemColors.ButtonShadow;
            textBox5.Location = new Point(361, 338);
            textBox5.Margin = new Padding(3, 2, 3, 2);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(152, 23);
            textBox5.TabIndex = 27;
            textBox5.Text = "Cari Data Dokter";
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 413);
            ControlBox = false;
            Controls.Add(button6);
            Controls.Add(button3);
            Controls.Add(textBox5);
            Controls.Add(textBox3);
            Controls.Add(comboBox1);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(dateTimePicker1);
            Controls.Add(label7);
            Controls.Add(dataGridView1);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(textBox4);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Data Dokter";
            Load += Form3_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox4;
        private Button button2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button button4;
        private Button button5;
        private DataGridView dataGridView1;
        private Label label7;
        private DateTimePicker dateTimePicker1;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private ComboBox comboBox1;
        private TextBox textBox3;
        private Button button3;
        private Button button6;
        private TextBox textBox5;
    }
}