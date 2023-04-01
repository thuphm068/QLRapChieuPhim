using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLRapChieuPhim
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        void otherForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //panel6.Visible = false;

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            panel7cumrap.Visible = false;
            panel8rap.Visible = false;
            panel9lichchieu.Visible = false;
            panel10phim.Visible = false;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            panel6kh.Location = new Point(50, 30);
            panel6kh.Visible = true;
            label7.Visible = true;
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);


        }

        private void button9_Click(object sender, EventArgs e)
        {
            panel6kh.Visible = false;
            panel7cumrap.Visible = false;
            panel8rap.Visible = false;
            panel9lichchieu.Visible = false;
            panel10phim.Visible = false;

            Button button = (Button)sender;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);



        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);

            if (comboBox1.SelectedItem.Equals("Cụm rạp"))
            {
                panel7cumrap.Visible = true;
                panel6kh.Visible = false;
                panel8rap.Visible = false;
                panel10phim.Visible = false;
            }
            else
            {
                panel7cumrap.Visible = false;
                panel6kh.Visible = false;
                panel10phim.Visible = false;
                panel8rap.Visible = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel6kh.Visible = false;
            panel7cumrap.Visible = false;
            panel8rap.Visible = false;
            panel10phim.Visible = false;
            panel9lichchieu.Visible = true;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);

            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);

        }
        private void button4_Click(object sender, EventArgs e)
        {
            panel6kh.Visible = false;
            panel7cumrap.Visible = false;
            panel8rap.Visible = false;
            panel9lichchieu.Visible = false;
            panel5theloai.Visible = false;

            panel10phim.Visible = true;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);

            button4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel6kh.Visible = false;
            panel7cumrap.Visible = false;
            panel8rap.Visible = false;
            panel9lichchieu.Visible = false;
            panel10phim.Visible = false;
            panel5theloai.Visible = true;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);

        }


        private void button8_Click_1(object sender, EventArgs e)
        {
            Suatheloai otherForm = new Suatheloai();
            this.Hide();
            otherForm.Show();
        }

        private void button25_Click_1(object sender, EventArgs e)
        {
            Suaphim otherForm = new Suaphim();
            this.Hide();
            otherForm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Suakehoach otherForm = new Suakehoach();
            this.Hide();
            otherForm.Show();

        }


        private void button22_Click(object sender, EventArgs e)
        {
            Sualichchieu otherForm = new Sualichchieu();
            this.Hide();
            otherForm.Show();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Suarap otherForm = new Suarap();
            this.Hide();
            otherForm.Show();
        }

        private void button12_Click_1(object sender, EventArgs e)
        {
            Suacumrap otherForm = new Suacumrap();
            this.Hide();
            otherForm.Show();
        }


        private void button25_Click(object sender, EventArgs e)
        {

        }



        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void panel8rap_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel9lichchieu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabPage14_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }


    }
}
