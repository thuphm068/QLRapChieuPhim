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
using QLRapChieuPhim.Extensions;



namespace QLRapChieuPhim
{
    public partial class Suacumrap : Form
    {
        private static readonly QLRapChieuPhimDbContext qLRapChieuPhimDbContext = new QLRapChieuPhimDbContext();
        Repository<CumRap> _cumraps = new Repository<CumRap>(qLRapChieuPhimDbContext);




        public Suacumrap()
        {
            InitializeComponent();
        }

        private void Suacumrap_Load(object sender, EventArgs e)
        {
            textBox10.Init("Nhập mã cụm");
            textBox11.Init("Nhập tên cụm");
            textBox12.Init("Nhập địa chỉ");

        }

        private void Suacumrap_FormClosed(object sender, FormClosedEventArgs e)
        {
            HomePage otherForm = new HomePage();
            this.Hide();
            otherForm.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {

            
            var cumrap = new CumRap
            {
                MaCum = textBox10.Text,
                TenCum = textBox11.Text,
                DiaChi = textBox12.Text,
            };

            var result = _cumraps.Add(cumrap);

            this.Hide();
            if (result is true)
                MessageBox.Show("Cập nhật thành công!");
            Login.otherForm.Show();
        }
    }
}
