namespace QLRapChieuPhim
{
    partial class Sualichchieu
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
            button23 = new Button();
            textBox20 = new TextBox();
            textBox17 = new TextBox();
            label41 = new Label();
            label40 = new Label();
            label39 = new Label();
            label38 = new Label();
            label37 = new Label();
            comboBox1 = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            SuspendLayout();
            // 
            // button23
            // 
            button23.BackColor = Color.FromArgb(240, 132, 132);
            button23.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button23.Location = new Point(606, 673);
            button23.Name = "button23";
            button23.Size = new Size(190, 55);
            button23.TabIndex = 29;
            button23.Text = "Cập nhật";
            button23.UseVisualStyleBackColor = false;
            button23.Click += button23_Click;
            // 
            // textBox20
            // 
            textBox20.Location = new Point(501, 560);
            textBox20.Name = "textBox20";
            textBox20.Size = new Size(404, 39);
            textBox20.TabIndex = 28;
            // 
            // textBox17
            // 
            textBox17.Location = new Point(505, 319);
            textBox17.Name = "textBox17";
            textBox17.Size = new Size(404, 39);
            textBox17.TabIndex = 25;
            textBox17.TextChanged += textBox17_TextChanged;
            // 
            // label41
            // 
            label41.AutoSize = true;
            label41.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label41.Location = new Point(501, 525);
            label41.Name = "label41";
            label41.Size = new Size(171, 32);
            label41.TabIndex = 24;
            label41.Text = "Chuỗi mã suất";
            // 
            // label40
            // 
            label40.AutoSize = true;
            label40.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label40.Location = new Point(498, 399);
            label40.Name = "label40";
            label40.Size = new Size(136, 32);
            label40.TabIndex = 23;
            label40.Text = "Ngày chiếu";
            // 
            // label39
            // 
            label39.AutoSize = true;
            label39.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label39.Location = new Point(505, 169);
            label39.Name = "label39";
            label39.Size = new Size(92, 32);
            label39.TabIndex = 22;
            label39.Text = "Mã rạp";
            // 
            // label38
            // 
            label38.AutoSize = true;
            label38.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label38.Location = new Point(501, 284);
            label38.Name = "label38";
            label38.Size = new Size(111, 32);
            label38.TabIndex = 21;
            label38.Text = "Mã phim";
            // 
            // label37
            // 
            label37.AutoSize = true;
            label37.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label37.Location = new Point(527, 77);
            label37.Name = "label37";
            label37.Size = new Size(346, 37);
            label37.TabIndex = 20;
            label37.Text = "Thêm lịch chiếu phim mới";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(505, 205);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(242, 40);
            comboBox1.TabIndex = 30;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(501, 444);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(400, 39);
            dateTimePicker1.TabIndex = 31;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // Sualichchieu
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1474, 929);
            Controls.Add(dateTimePicker1);
            Controls.Add(comboBox1);
            Controls.Add(button23);
            Controls.Add(textBox20);
            Controls.Add(textBox17);
            Controls.Add(label41);
            Controls.Add(label40);
            Controls.Add(label39);
            Controls.Add(label38);
            Controls.Add(label37);
            Name = "Sualichchieu";
            Text = "Sualichchieu";
            FormClosed += Sualichchieu_FormClosed;
            Load += Sualichchieu_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button23;
        private TextBox textBox20;
        private TextBox textBox17;
        private Label label41;
        private Label label40;
        private Label label39;
        private Label label38;
        private Label label37;
        private ComboBox comboBox1;
        private DateTimePicker dateTimePicker1;
    }
}