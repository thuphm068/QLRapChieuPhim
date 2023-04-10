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
using static Azure.Core.HttpHeader;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.ComponentModel.Design.ObjectSelectorEditor;


namespace QLRapChieuPhim
{
    public partial class Suaphim : Form
    {

        private static readonly QLRapChieuPhimDbContext qLRapChieuPhimDbContext = new QLRapChieuPhimDbContext();
        Repository<PhimTheLoaiPhu> _phimtheloaiphus = new Repository<PhimTheLoaiPhu>(qLRapChieuPhimDbContext);
        Repository<Phim> _phims = new Repository<Phim>(qLRapChieuPhimDbContext);
        Repository<TheLoai> _theloais = new Repository<TheLoai>(qLRapChieuPhimDbContext);

        List<TheLoai> theloais = new List<TheLoai>();
        public Suaphim()
        {
            InitializeComponent();
            theloais = _theloais.GetAll();
            comboBox1.DataSource = theloais.Select(x => x.TenTheLoai).ToList();

        }

        private void button28_Click(object sender, EventArgs e)
        {
            bool temp = false;
            if (comboBox7.SelectedItem.Equals("Có") || comboBox6.SelectedItem.Equals("Có"))
                temp = true;
            else
                temp = false;

            bool coLongTieng = false;
            if (comboBox6.SelectedItem.Equals("Có"))
            {
                coLongTieng = true;
            }

            bool co3D = false;
            if (comboBox7.SelectedItem.Equals("Có"))
            {
                co3D = true;
            }


            var matheloai = theloais.FirstOrDefault(x => x.TenTheLoai == comboBox1.SelectedItem.ToString());
            if (matheloai == null)
            {
                return;
            }

            var phim = new Phim
            {
                MaPhim = textBox35.Text,
                TenPhim = textBox34.Text,
                MaTheLoaiChinh = matheloai.MaTheLoai,
                ThoiLuong = Int32.Parse(textBox31.Text),
                CoLa3D = co3D,
                CoLongTieng = coLongTieng,

            };
            var result = _phims.Add(phim);



            var matheloaiphu = theloais.FirstOrDefault(x => x.TenTheLoai == comboBox2.SelectedItem.ToString());
            if (matheloaiphu == null)
            {
                return;
            }
            var phimtheloaiphu = new PhimTheLoaiPhu
            {
                MaPhim = textBox35.Text,
                MaTheLoai = matheloaiphu.MaTheLoai,
            };
            result = _phimtheloaiphus.Add(phimtheloaiphu);


            this.Hide();
            if (result is true)
                MessageBox.Show("Cập nhật thành công!");

            Login.otherForm.Show();
        }

        private void Suaphim_FormClosed(object sender, FormClosedEventArgs e)
        {
            HomePage otherForm = new HomePage();
            this.Hide();
            otherForm.Show();
        }

        private void Suaphim_Load(object sender, EventArgs e)
        {
            textBox35.Init("Nhập mã phim");
            textBox34.Init("Nhập tên phim");
            textBox31.Init("Nhập thời lượng");

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.DataSource = theloais.Where(i => i.TenTheLoai != comboBox1.SelectedItem).Select(i => i.TenTheLoai).ToList();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
