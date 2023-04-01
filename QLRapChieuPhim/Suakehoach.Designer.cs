namespace QLRapChieuPhim
{
    partial class Suakehoach
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
            button10 = new Button();
            textBox9 = new TextBox();
            label17 = new Label();
            textBox8 = new TextBox();
            textBox7 = new TextBox();
            label16 = new Label();
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            SuspendLayout();
            // 
            // button10
            // 
            button10.BackColor = Color.FromArgb(240, 132, 132);
            button10.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button10.Location = new Point(528, 688);
            button10.Name = "button10";
            button10.Size = new Size(188, 56);
            button10.TabIndex = 32;
            button10.Text = "Cập nhật";
            button10.UseVisualStyleBackColor = false;
            button10.Click += button10_Click;
            // 
            // textBox9
            // 
            textBox9.Location = new Point(409, 557);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(390, 39);
            textBox9.TabIndex = 31;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label17.Location = new Point(409, 522);
            label17.Name = "label17";
            label17.Size = new Size(97, 32);
            label17.TabIndex = 30;
            label17.Text = "Ghi chú";
            // 
            // textBox8
            // 
            textBox8.Location = new Point(698, 455);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(250, 39);
            textBox8.TabIndex = 29;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(409, 455);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(250, 39);
            textBox7.TabIndex = 28;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label16.Location = new Point(409, 420);
            label16.Name = "label16";
            label16.Size = new Size(380, 32);
            label16.TabIndex = 27;
            label16.Text = "Ngày khởi chiếu và ngày kết thúc";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(409, 353);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(380, 39);
            textBox6.TabIndex = 26;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(409, 256);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(380, 39);
            textBox5.TabIndex = 25;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label15.Location = new Point(409, 318);
            label15.Name = "label15";
            label15.Size = new Size(102, 32);
            label15.TabIndex = 24;
            label15.Text = "Mã cụm";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label14.Location = new Point(409, 221);
            label14.Name = "label14";
            label14.Size = new Size(111, 32);
            label14.TabIndex = 23;
            label14.Text = "Mã phim";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(409, 135);
            label13.Name = "label13";
            label13.Size = new Size(478, 45);
            label13.TabIndex = 22;
            label13.Text = "Thêm kế hoạch chiếu phim mới";
            // 
            // Suakehoach
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1374, 929);
            Controls.Add(button10);
            Controls.Add(textBox9);
            Controls.Add(label17);
            Controls.Add(textBox8);
            Controls.Add(textBox7);
            Controls.Add(label16);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(label13);
            Name = "Suakehoach";
            Text = "Suakehoach";
            FormClosed += Suakehoach_FormClosed;
            Load += Suakehoach_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button10;
        private TextBox textBox9;
        private Label label17;
        private TextBox textBox8;
        private TextBox textBox7;
        private Label label16;
        private TextBox textBox6;
        private TextBox textBox5;
        private Label label15;
        private Label label14;
        private Label label13;
    }
}