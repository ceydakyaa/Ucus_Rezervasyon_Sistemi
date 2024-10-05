namespace Ucus_Rezervasyon_Sistemi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            groupBox1 = new GroupBox();
            label9 = new Label();
            button2 = new Button();
            maskedTextBox1 = new MaskedTextBox();
            label4 = new Label();
            label3 = new Label();
            dateTimePicker1 = new DateTimePicker();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            groupBox2 = new GroupBox();
            button1 = new Button();
            maskedTextBox3 = new MaskedTextBox();
            maskedTextBox2 = new MaskedTextBox();
            textBox1 = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            listBox1 = new ListBox();
            listBox2 = new ListBox();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label8 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(maskedTextBox1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(7, 107);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(341, 179);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Uçuş Bilgileri";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(244, 142);
            label9.Name = "label9";
            label9.Size = new Size(50, 20);
            label9.TabIndex = 11;
            label9.Text = "label9";
            label9.Visible = false;
            label9.Click += label9_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 192, 255);
            button2.Font = new Font("Microsoft JhengHei", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(285, 47);
            button2.Name = "button2";
            button2.Size = new Size(45, 43);
            button2.TabIndex = 10;
            button2.Text = "<>";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(81, 135);
            maskedTextBox1.Mask = "90:00";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(125, 27);
            maskedTextBox1.TabIndex = 6;
            maskedTextBox1.ValidatingType = typeof(DateTime);
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(32, 138);
            label4.Name = "label4";
            label4.Size = new Size(41, 20);
            label4.TabIndex = 5;
            label4.Text = "Saat:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 104);
            label3.Name = "label3";
            label3.Size = new Size(43, 20);
            label3.TabIndex = 4;
            label3.Text = "Tarih:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(81, 104);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(202, 27);
            dateTimePicker1.TabIndex = 3;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Ankara", "Bursa", "Adana", "Elazığ", "Samsun" });
            comboBox1.Location = new Point(81, 70);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(202, 28);
            comboBox1.TabIndex = 0;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Ankara", "Bursa", "Adana", "Elazığ", "Samsun" });
            comboBox2.Location = new Point(81, 36);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(202, 28);
            comboBox2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 36);
            label1.Name = "label1";
            label1.Size = new Size(69, 20);
            label1.TabIndex = 0;
            label1.Text = "Nereden:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 73);
            label2.Name = "label2";
            label2.Size = new Size(59, 20);
            label2.TabIndex = 1;
            label2.Text = "Nereye:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(maskedTextBox3);
            groupBox2.Controls.Add(maskedTextBox2);
            groupBox2.Controls.Add(textBox1);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label7);
            groupBox2.Location = new Point(343, 107);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(345, 179);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Yolcu Bilgileri";
            // 
            // button1
            // 
            button1.BackColor = Color.Yellow;
            button1.Location = new Point(147, 135);
            button1.Name = "button1";
            button1.Size = new Size(125, 29);
            button1.TabIndex = 7;
            button1.Text = "Kaydet";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // maskedTextBox3
            // 
            maskedTextBox3.Location = new Point(147, 97);
            maskedTextBox3.Mask = "(999) 000-0000";
            maskedTextBox3.Name = "maskedTextBox3";
            maskedTextBox3.Size = new Size(125, 27);
            maskedTextBox3.TabIndex = 6;
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Location = new Point(147, 64);
            maskedTextBox2.Mask = "00000000000";
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(125, 27);
            maskedTextBox2.TabIndex = 5;
            maskedTextBox2.ValidatingType = typeof(int);
            // 
            // textBox1
            // 
            textBox1.Location = new Point(147, 33);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(22, 39);
            label5.Name = "label5";
            label5.Size = new Size(119, 20);
            label5.TabIndex = 1;
            label5.Text = "Yolcu Ad Soyad: ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(113, 70);
            label6.Name = "label6";
            label6.Size = new Size(28, 20);
            label6.TabIndex = 2;
            label6.Text = "TC:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(80, 104);
            label7.Name = "label7";
            label7.Size = new Size(61, 20);
            label7.TabIndex = 3;
            label7.Text = "Telefon:";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.HorizontalScrollbar = true;
            listBox1.Location = new Point(7, 287);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(681, 104);
            listBox1.TabIndex = 8;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.Location = new Point(496, 387);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(8, 4);
            listBox2.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label8);
            panel1.Location = new Point(7, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(681, 89);
            panel1.TabIndex = 9;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(336, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe Script", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label8.Location = new Point(16, 22);
            label8.Name = "label8";
            label8.Size = new Size(268, 38);
            label8.TabIndex = 0;
            label8.Text = "Jüpiter Hava Yolları";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(701, 442);
            Controls.Add(panel1);
            Controls.Add(listBox1);
            Controls.Add(listBox2);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private DateTimePicker dateTimePicker1;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Label label1;
        private Label label2;
        private MaskedTextBox maskedTextBox1;
        private Label label4;
        private Label label3;
        private TextBox textBox1;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button button1;
        private MaskedTextBox maskedTextBox3;
        private MaskedTextBox maskedTextBox2;
        private ListBox listBox1;
        private ListBox listBox2;
        private Panel panel1;
        private Label label8;
        private PictureBox pictureBox1;
        private Button button2;
        private Label label9;
    }
}
