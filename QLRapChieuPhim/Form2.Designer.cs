using QLRapChieuPhim.Utilities;
using System.Windows.Forms;

namespace QLRapChieuPhim
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
            LinkLabel linkLabel1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            button1 = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            panel3 = new Panel();
            label6 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            label4 = new Label();
            panel1 = new Panel();
            label5 = new Label();
            pictureBox2 = new PictureBox();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            comboBox1 = new ComboBox();
            button2 = new Button();
            linkLabel1 = new LinkLabel();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(851, 662);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(191, 32);
            linkLabel1.TabIndex = 13;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Quên mật khẩu?";
            // 
            // button1
            // 
            button1.BackColor = Color.LightGray;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(851, 582);
            button1.Name = "button1";
            button1.Size = new Size(180, 60);
            button1.TabIndex = 8;
            button1.Text = "Đăng nhập";
            button1.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(759, 315);
            label3.Name = "label3";
            label3.Size = new Size(161, 32);
            label3.TabIndex = 14;
            label3.Text = "ĐĂNG NHẬP";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(759, 483);
            label2.Name = "label2";
            label2.Size = new Size(119, 32);
            label2.TabIndex = 12;
            label2.Text = "Mật khẩu";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(759, 382);
            label1.Name = "label1";
            label1.Size = new Size(38, 32);
            label1.TabIndex = 11;
            label1.Text = "ID";
            // 
            // textBox2
            // 
            textBox2.ForeColor = Color.Gray;
            textBox2.Location = new Point(759, 518);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(376, 39);
            textBox2.TabIndex = 10;
            textBox2.UseSystemPasswordChar = true;
            // 
            // textBox1
            // 
            textBox1.ForeColor = Color.Gray;
            textBox1.Location = new Point(759, 417);
            textBox1.MaxLength = 20;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(376, 39);
            textBox1.TabIndex = 9;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(224, 224, 224);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(pictureBox1);
            panel3.Location = new Point(370, 11);
            panel3.Name = "panel3";
            panel3.Size = new Size(1524, 134);
            panel3.TabIndex = 17;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ButtonShadow;
            label6.Location = new Point(1067, 51);
            label6.Name = "label6";
            label6.Size = new Size(148, 37);
            label6.TabIndex = 11;
            label6.Text = "Đăng nhập";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1001, 36);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(60, 60);
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(89, 53, 53);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(1, 11);
            panel2.Name = "panel2";
            panel2.Size = new Size(370, 117);
            panel2.TabIndex = 16;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 22.125F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(238, 240, 142);
            label4.Location = new Point(96, 18);
            label4.Name = "label4";
            label4.Size = new Size(157, 78);
            label4.TabIndex = 9;
            label4.Text = "TMS";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(82, 85, 93);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(button2);
            panel1.Location = new Point(1, 126);
            panel1.Name = "panel1";
            panel1.Size = new Size(370, 871);
            panel1.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.ControlDark;
            label5.Location = new Point(96, 48);
            label5.Name = "label5";
            label5.Size = new Size(132, 32);
            label5.TabIndex = 11;
            label5.Text = "Đăng nhập";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(33, 31);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(66, 65);
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.Control;
            button5.Location = new Point(33, 423);
            button5.Name = "button5";
            button5.Size = new Size(301, 46);
            button5.TabIndex = 11;
            button5.Text = "Thể loại";
            button5.TextAlign = ContentAlignment.MiddleLeft;
            button5.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.Control;
            button4.ForeColor = Color.Black;
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(33, 345);
            button4.Name = "button4";
            button4.Size = new Size(301, 46);
            button4.TabIndex = 10;
            button4.Text = "Phim";
            button4.TextAlign = ContentAlignment.MiddleLeft;
            button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.Control;
            button3.ForeColor = Color.Black;
            button3.Location = new Point(33, 271);
            button3.Name = "button3";
            button3.Size = new Size(301, 46);
            button3.TabIndex = 9;
            button3.Text = "Lịch chiếu";
            button3.TextAlign = ContentAlignment.MiddleLeft;
            button3.UseVisualStyleBackColor = false;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = SystemColors.Control;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(33, 126);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(306, 40);
            comboBox1.TabIndex = 8;
            comboBox1.Text = "Cụm rạp";
            // 
            // button2
            // 
            button2.BackColor = SystemColors.Control;
            button2.ForeColor = Color.Black;
            button2.Location = new Point(33, 195);
            button2.Name = "button2";
            button2.Size = new Size(306, 46);
            button2.TabIndex = 8;
            button2.Text = "Kế hoạch chiếu phim";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.UseVisualStyleBackColor = false;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1894, 1009);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(linkLabel1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form2";
            Text = "Form2";
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Panel panel3;
        private Label label6;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Label label4;
        private Panel panel1;
        private Label label5;
        private PictureBox pictureBox2;
        private Button button5;
        private Button button4;
        private Button button3;
        private ComboBox comboBox1;
        private Button button2;
    }
}