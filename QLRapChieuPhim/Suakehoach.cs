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
    public partial class Suakehoach : Form
    {

        private static readonly QLRapChieuPhimDbContext qLRapChieuPhimDbContext = new QLRapChieuPhimDbContext();
        Repository<KeHoach> _kehoachs = new Repository<KeHoach>(qLRapChieuPhimDbContext);


        public Suakehoach()
        {
            InitializeComponent();
        }

        private void Suakehoach_Load(object sender, EventArgs e)
        {
            textBox5.Init("Nhập mã phim");
            textBox6.Init("Nhập mã cụm");
            textBox7.Init("Nhập ngày khởi chiếu");
            textBox8.Init("Nhập ngày kết thúc");
            textBox9.Init("Nhập ghi chú");

        }

        private void Suakehoach_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form2 otherForm = new Form2();
            this.Hide();
            otherForm.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            var kehoach = new KeHoach
            {
                MaPhim = textBox5.Text,
                MaCum = textBox6.Text,
                NgayKhoiChieu = DateTime.Parse(textBox7.Text),
                NgayKetThuc = DateTime.Parse(textBox8.Text),
                GhiChu = textBox9.Text,

            };

            var result = _kehoachs.Add(kehoach);

            this.Hide();
            if (result is true)
                MessageBox.Show("Cập nhật thành công!");
            Login.otherForm.Show();
        }
    }
}
