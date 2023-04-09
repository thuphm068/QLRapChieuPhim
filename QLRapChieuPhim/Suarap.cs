using QLRapChieuPhim.Entities;
using QLRapChieuPhim.Infrastructure.Entity_Framework_Core;
using QLRapChieuPhim.Infrastructure.Repositories;
using QLRapChieuPhim.Extensions;
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

namespace QLRapChieuPhim
{
    public partial class Suarap : Form
    {

        private static readonly QLRapChieuPhimDbContext qLRapChieuPhimDbContext = new QLRapChieuPhimDbContext();
        Repository<Rap> _raps = new Repository<Rap>(qLRapChieuPhimDbContext);

        public Suarap()
        {
            InitializeComponent();
        }

        private void button19_Click(object sender, EventArgs e)
        {

            var rap = new Rap
            {
                MaRap = textBox13.Text,
                TongGhe = Int32.Parse(textBox14.Text),
                MaCum = textBox15.Text,

            };

            var result = _raps.Add(rap);

            this.Hide();
            if (result is true)
                MessageBox.Show("Cập nhật thành công!");
            Login.otherForm.Show();


        }

        private void Suarap_FormClosed(object sender, FormClosedEventArgs e)
        {
            HomePage otherForm = new HomePage();
            this.Hide();
            otherForm.Show();
        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {
        }

        private void label33_Click(object sender, EventArgs e)
        {
        }

        private void label32_Click(object sender, EventArgs e)
        {
        }

        private void label31_Click(object sender, EventArgs e)
        {
        }

        private void label30_Click(object sender, EventArgs e)
        {
        }

        private void Suarap_Load(object sender, EventArgs e)
        {
            textBox13.Init("Nhậ mã rạp");
            textBox14.Init("Nhập tổng ghế");
            textBox15.Init("Nhập mã cụm");

        }
    }
}
