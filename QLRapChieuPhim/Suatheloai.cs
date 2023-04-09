using QLRapChieuPhim.Entities;
using QLRapChieuPhim.Infrastructure.Entity_Framework_Core;
using QLRapChieuPhim.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using QLRapChieuPhim.Extensions;


namespace QLRapChieuPhim
{
    public partial class Suatheloai : Form
    {

        private static readonly QLRapChieuPhimDbContext qLRapChieuPhimDbContext = new QLRapChieuPhimDbContext();
        Repository<TheLoai> _theloais = new Repository<TheLoai>(qLRapChieuPhimDbContext);


        public Suatheloai()
        {
            InitializeComponent();
        }

        private void Suatheloai_Load(object sender, EventArgs e)
        {
            textBox1.Init("Nhập mã thể loại");
            textBox2.Init("Nhập tên thể loại");
        }

        private void button1_Click(object sender, EventArgs e)
        {

            var theloai = new TheLoai
            {
                MaTheLoai = textBox1.Text,
                TenTheLoai = textBox2.Text,
            };

            var result = _theloais.Add(theloai);

            this.Hide();
            if (result is true)
                MessageBox.Show("Cập nhật thành công!");

            Login.otherForm.Show();

        }
        private void Suatheloai_FormClosed(object sender, FormClosedEventArgs e)
        {
            HomePage otherForm = new HomePage();
            this.Hide();
            otherForm.Show();
        }
    }
}
