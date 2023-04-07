using QLRapChieuPhim.Entities;
using QLRapChieuPhim.Extensions;
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

namespace QLRapChieuPhim
{
    public partial class Sualichchieu : Form
    {
        private static readonly QLRapChieuPhimDbContext qLRapChieuPhimDbContext = new QLRapChieuPhimDbContext();
        Repository<LichChieu> _lichchieus = new Repository<LichChieu>(qLRapChieuPhimDbContext);

        public Sualichchieu()
        {
            InitializeComponent();
        }

        private void button23_Click(object sender, EventArgs e)
        {

            var lichchieu = new LichChieu
            {
                MaPhim = textBox17.Text,
                MaRap = textBox18.Text,
                NgayChieu = DateTime.Parse(textBox19.Text),
                ChuoiMaSuat = textBox20.Text,

            };

            var result = _lichchieus.Add(lichchieu);

            this.Hide();
            if (result is true)
                MessageBox.Show("Cập nhật thành công!");
            Login.otherForm.Show();
        }

        private void Sualichchieu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form2 otherForm = new Form2();
            this.Hide();
            otherForm.Show();
        }

        private void Sualichchieu_Load(object sender, EventArgs e)
        {
            textBox17.Init("Nhập mã phim");
            textBox18.Init("Nhập mã rạp");
            textBox19.Init("Nhập ngày chiếu");
            textBox20.Init("Nhập chuỗi mã suất");

        }
    }
}
