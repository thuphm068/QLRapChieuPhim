namespace QLRapChieuPhim
{
    partial class Suarap
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
            button19 = new Button();
            textBox15 = new TextBox();
            textBox14 = new TextBox();
            textBox13 = new TextBox();
            label33 = new Label();
            label32 = new Label();
            label31 = new Label();
            label30 = new Label();
            SuspendLayout();
            // 
            // button19
            // 
            button19.BackColor = Color.FromArgb(240, 132, 132);
            button19.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button19.Location = new Point(631, 653);
            button19.Name = "button19";
            button19.Size = new Size(180, 55);
            button19.TabIndex = 23;
            button19.Text = "Cập nhật";
            button19.UseVisualStyleBackColor = false;
            button19.Click += button19_Click;
            // 
            // textBox15
            // 
            textBox15.Location = new Point(508, 540);
            textBox15.Name = "textBox15";
            textBox15.Size = new Size(461, 39);
            textBox15.TabIndex = 22;
            textBox15.TextChanged += textBox15_TextChanged;
            // 
            // textBox14
            // 
            textBox14.Location = new Point(508, 439);
            textBox14.Name = "textBox14";
            textBox14.Size = new Size(461, 39);
            textBox14.TabIndex = 21;
            textBox14.TextChanged += textBox14_TextChanged;
            // 
            // textBox13
            // 
            textBox13.Location = new Point(506, 332);
            textBox13.Name = "textBox13";
            textBox13.Size = new Size(461, 39);
            textBox13.TabIndex = 20;
            textBox13.TextChanged += textBox13_TextChanged;
            // 
            // label33
            // 
            label33.AutoSize = true;
            label33.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label33.Location = new Point(510, 505);
            label33.Name = "label33";
            label33.Size = new Size(102, 32);
            label33.TabIndex = 19;
            label33.Text = "Mã cụm";
            label33.Click += label33_Click;
            // 
            // label32
            // 
            label32.AutoSize = true;
            label32.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label32.Location = new Point(508, 404);
            label32.Name = "label32";
            label32.Size = new Size(117, 32);
            label32.TabIndex = 18;
            label32.Text = "Tổng ghế";
            label32.Click += label32_Click;
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label31.Location = new Point(506, 297);
            label31.Name = "label31";
            label31.Size = new Size(92, 32);
            label31.TabIndex = 17;
            label31.Text = "Mã rạp";
            label31.Click += label31_Click;
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label30.Location = new Point(506, 220);
            label30.Name = "label30";
            label30.Size = new Size(196, 37);
            label30.TabIndex = 16;
            label30.Text = "Thêm rạp mới";
            label30.Click += label30_Click;
            // 
            // Suarap
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1474, 929);
            Controls.Add(button19);
            Controls.Add(textBox15);
            Controls.Add(textBox14);
            Controls.Add(textBox13);
            Controls.Add(label33);
            Controls.Add(label32);
            Controls.Add(label31);
            Controls.Add(label30);
            Name = "Suarap";
            Text = "Suarap";
            FormClosed += Suarap_FormClosed;
            Load += Suarap_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button19;
        private TextBox textBox15;
        private TextBox textBox14;
        private TextBox textBox13;
        private Label label33;
        private Label label32;
        private Label label31;
        private Label label30;
    }
}