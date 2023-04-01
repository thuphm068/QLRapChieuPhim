namespace QLRapChieuPhim
{
    partial class Suacumrap
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
            button13 = new Button();
            textBox12 = new TextBox();
            textBox11 = new TextBox();
            textBox10 = new TextBox();
            label22 = new Label();
            label21 = new Label();
            label20 = new Label();
            label19 = new Label();
            SuspendLayout();
            // 
            // button13
            // 
            button13.BackColor = Color.FromArgb(240, 132, 132);
            button13.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button13.Location = new Point(625, 651);
            button13.Name = "button13";
            button13.Size = new Size(201, 59);
            button13.TabIndex = 23;
            button13.Text = "Cập nhật";
            button13.UseVisualStyleBackColor = false;
            button13.Click += button13_Click;
            // 
            // textBox12
            // 
            textBox12.Location = new Point(510, 522);
            textBox12.Name = "textBox12";
            textBox12.Size = new Size(391, 39);
            textBox12.TabIndex = 22;
            // 
            // textBox11
            // 
            textBox11.Location = new Point(508, 420);
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(393, 39);
            textBox11.TabIndex = 21;
            // 
            // textBox10
            // 
            textBox10.Location = new Point(510, 319);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(391, 39);
            textBox10.TabIndex = 20;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label22.Location = new Point(510, 484);
            label22.Name = "label22";
            label22.Size = new Size(88, 32);
            label22.TabIndex = 19;
            label22.Text = "Địa chỉ";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label21.Location = new Point(510, 385);
            label21.Name = "label21";
            label21.Size = new Size(105, 32);
            label21.TabIndex = 18;
            label21.Text = "Tên cụm";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label20.Location = new Point(510, 284);
            label20.Name = "label20";
            label20.Size = new Size(102, 32);
            label20.TabIndex = 17;
            label20.Text = "Mã cụm";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point);
            label19.Location = new Point(510, 202);
            label19.Name = "label19";
            label19.Size = new Size(257, 37);
            label19.TabIndex = 16;
            label19.Text = "Thêm cụm rạp mới";
            // 
            // Suacumrap
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1474, 929);
            Controls.Add(button13);
            Controls.Add(textBox12);
            Controls.Add(textBox11);
            Controls.Add(textBox10);
            Controls.Add(label22);
            Controls.Add(label21);
            Controls.Add(label20);
            Controls.Add(label19);
            Name = "Suacumrap";
            Text = "Suacumrap";
            FormClosed += Suacumrap_FormClosed;
            Load += Suacumrap_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button13;
        private TextBox textBox12;
        private TextBox textBox11;
        private TextBox textBox10;
        private Label label22;
        private Label label21;
        private Label label20;
        private Label label19;
    }
}