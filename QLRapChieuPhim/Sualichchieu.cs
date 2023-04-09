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
        Repository<Rap> _raps = new Repository<Rap>(qLRapChieuPhimDbContext);
        Repository<CumRap> _cumraps = new Repository<CumRap>(qLRapChieuPhimDbContext);
        Repository<KeHoach> _kehoachs = new Repository<KeHoach>(qLRapChieuPhimDbContext);

        List<Rap> raps = new List<Rap>();
        List<KeHoach> kehoachs = new List<KeHoach>();
        //public static TaiKhoanDangNhap TaiKhoanDangNhap { get; set; }
        string macum = "";

        public Sualichchieu()
        {
            InitializeComponent();
            raps = _raps.GetAll();


        }
        public Sualichchieu(string macum)
        {
            InitializeComponent();
            raps = _raps.GetAll();
            comboBox1.DataSource = raps.Where(x => x.MaCum == macum).Select(x => x.MaRap).ToList();
            //Select(x => x.MaCum).ToList();
            this.macum = macum;
        }

        private void button23_Click(object sender, EventArgs e)
        {
            //var lichchieu = qLRapChieuPhimDbContext.LichChieus.FirstOrDefault(x =)
            var lichchieu = new LichChieu
            {
                MaPhim = textBox17.Text,
                MaRap = comboBox1.SelectedItem.ToString(),
                NgayChieu = DateTime.Parse(dateTimePicker1.Text),
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
            HomePage otherForm = new HomePage();
            this.Hide();
            otherForm.Show();
        }

        private void Sualichchieu_Load(object sender, EventArgs e)
        {
            textBox17.Init("Nhập mã phim");
            textBox20.Init("Nhập chuỗi mã suất");

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {

            kehoachs = _kehoachs.GetAll();
            if (textBox17 != null && textBox17.Text != "" && textBox17.Text != "Nhập mã phim")
            {
                try
                {
                    var search = kehoachs.FirstOrDefault(x => x.MaPhim == textBox17.Text && x.MaCum == macum);
                    if (search != null)
                    {

                        dateTimePicker1.MaxDate = search.NgayKetThuc;
                        dateTimePicker1.MinDate = search.NgayKhoiChieu;


                    }


                }
                catch (Exception ex)
                {
                    return;
                }
            }

        }
    }
}
