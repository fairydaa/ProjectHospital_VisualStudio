namespace hospital_1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            button5 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            groupBox2 = new GroupBox();
            button4 = new Button();
            label1 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button5);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Location = new Point(23, 16);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(754, 120);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Master data";
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(255, 128, 128);
            button5.Location = new Point(730, 0);
            button5.Name = "button5";
            button5.Size = new Size(24, 23);
            button5.TabIndex = 3;
            button5.Text = "X";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button3
            // 
            button3.Location = new Point(314, 38);
            button3.Name = "button3";
            button3.Size = new Size(100, 23);
            button3.TabIndex = 2;
            button3.Text = "Data Obat";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(173, 38);
            button2.Name = "button2";
            button2.Size = new Size(100, 23);
            button2.TabIndex = 1;
            button2.Text = "Data Dokter";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(31, 38);
            button1.Name = "button1";
            button1.Size = new Size(100, 23);
            button1.TabIndex = 0;
            button1.Text = "Data Pasien";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button4);
            groupBox2.Location = new Point(23, 188);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(750, 126);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Data Pemerikasaan/CheckUp";
            // 
            // button4
            // 
            button4.Location = new Point(31, 33);
            button4.Name = "button4";
            button4.Size = new Size(100, 23);
            button4.TabIndex = 0;
            button4.Text = "Data CheckUp";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 317);
            label1.Name = "label1";
            label1.Size = new Size(392, 15);
            label1.TabIndex = 2;
            label1.Text = "Dikembangkan Oleh: D3 Teknik Informatika - Politeknik Negeri Semarang";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(817, 350);
            ControlBox = false;
            Controls.Add(label1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Rumah Sakit Mitra Sehat";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Button button5;
        private Button button3;
        private Button button2;
        private Button button1;
        private GroupBox groupBox2;
        private Button button4;
        private Label label1;
    }
}