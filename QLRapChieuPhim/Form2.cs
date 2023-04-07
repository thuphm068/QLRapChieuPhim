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

namespace QLRapChieuPhim
{
    public partial class Form2 : Form
    {
        private static readonly QLRapChieuPhimDbContext qLRapChieuPhimDbContext = new QLRapChieuPhimDbContext();
        Repository<PhimTheLoaiPhu> _phimtheloaiphus = new Repository<PhimTheLoaiPhu>(qLRapChieuPhimDbContext);
        Repository<SuatChieu> _suatchieus = new Repository<SuatChieu>(qLRapChieuPhimDbContext);
        Repository<Rap> _raps = new Repository<Rap>(qLRapChieuPhimDbContext);
        Repository<CumRap> _cumraps = new Repository<CumRap>(qLRapChieuPhimDbContext);
        Repository<KeHoach> _kehoachs = new Repository<KeHoach>(qLRapChieuPhimDbContext);
        Repository<LichChieu> _lichchieus = new Repository<LichChieu>(qLRapChieuPhimDbContext);
        Repository<Phim> _phims = new Repository<Phim>(qLRapChieuPhimDbContext);
        Repository<TheLoai> _theloais = new Repository<TheLoai>(qLRapChieuPhimDbContext);

        //Repository<> _s = new Repository<>(qLRapChieuPhimDbContext);


        public TaiKhoanDangNhap TaiKhoanDangNhap { get; set; }



        public Form2()
        {
            InitializeComponent();
            // qLRapChieuPhimDbContext.CumRaps;
            // _cumraps1.

        }

        public Form2(TaiKhoanDangNhap taiKhoanDangNhap)
        {
            InitializeComponent();
            // qLRapChieuPhimDbContext.CumRaps;
            // _cumraps1.
            TaiKhoanDangNhap = taiKhoanDangNhap;

            label6.Text = taiKhoanDangNhap.HoTen;
        }

        void otherForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var list = _theloais.GetAll();
            list = list
                .Where(
                x => x.MaTheLoai.ToUpper().Contains((textBox4.Text.ToUpper())))
                .ToList();

            dataGridView7tl.DataSource = list;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

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
            // DataTable bindingList = _kehoachs.GetAll();
            BindingList<KeHoach> bindingList = new BindingList<KeHoach>(_kehoachs.GetAll());
            dataGridView1.DataSource = bindingList;
            textBox3.Init("Nhập mã phim/mã cụm");


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
                panel5theloai.Visible = false;
                BindingList<CumRap> cumRaps = new BindingList<CumRap>(_cumraps.GetAll());

                dataGridView2.DataSource = cumRaps;
                textBox6.Init("Nhập mã cụm rạp");

            }
            else
            {
                panel7cumrap.Visible = false;
                panel6kh.Visible = false;
                panel10phim.Visible = false;
                panel5theloai.Visible = false;

                panel8rap.Visible = true;
                dataGridView4.DataSource = _raps.GetAll();
                textBox5.Init("Nhập mã rạp");

            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel6kh.Visible = false;
            panel7cumrap.Visible = false;
            panel8rap.Visible = false;
            panel10phim.Visible = false;
            panel5theloai.Visible = false;
            panel9lichchieu.Visible = true;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridView5.DataSource = _lichchieus.GetAll();


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
            var phims = _phims.GetAll();
            //var theloaiphus = _phimtheloaiphus.GetAll();

            //var result = from phim in phims 
            //             join theloai in theloaiphus
            //             on phim.MaPhim equals theloai.MaPhim
            //             select new {
            //                 phim,
            //                theloaiphu = theloai
            //             };
            dataGridView6.DataSource = phims;

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
            dataGridView7tl.DataSource = _theloais.GetAll();
            textBox1.Init("Nhập mã thể loại");

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

        private void panel8rap_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView5_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            qLRapChieuPhimDbContext.SaveChanges();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            var list = _kehoachs.GetAll();
            list = list
                .Where(
                x => x.MaCum.ToUpper().Contains((textBox3.Text.ToUpper()))
                ||
                 x.MaPhim.ToUpper().Contains((textBox3.Text.ToUpper())))
                .ToList();

            dataGridView1.DataSource = list;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow dvr in dataGridView1.Rows)
            {

                if (dvr.Cells[0].Value is not null)
                {
                    var obj = (KeHoach)dvr.DataBoundItem;

                    var deletedobject = qLRapChieuPhimDbContext.KeHoachs.FirstOrDefault(x => x.MaCum == obj.MaCum && x.MaPhim == obj.MaPhim && x.NgayKetThuc == obj.NgayKetThuc);
                    //_kehoachs.Delete((KeHoach)dataGridView1.Rows[0].DataBoundItem);
                    if (deletedobject == null) continue;
                    _kehoachs.Delete(deletedobject);
                    MessageBox.Show("Xóa thành công!");
                }

            }
            qLRapChieuPhimDbContext.SaveChanges();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow dvr in dataGridView5.Rows)
            {

                if (dvr.Cells[0].Value is not null)
                {
                    var obj = (LichChieu)dvr.DataBoundItem;

                    var deletedobject = qLRapChieuPhimDbContext.LichChieus.FirstOrDefault(x => x.MaPhim == obj.MaPhim && x.MaRap == obj.MaRap && x.NgayChieu == obj.NgayChieu);
                    //_kehoachs.Delete((KeHoach)dataGridView1.Rows[0].DataBoundItem);
                    if (deletedobject == null) continue;
                    _lichchieus.Delete(deletedobject);
                    MessageBox.Show("Xóa thành công!");
                }

            }
            qLRapChieuPhimDbContext.SaveChanges();
        }


        private async void button11_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow dvr in dataGridView2.Rows)
            {
                if (dvr.Cells[0].Value is not null)
                {
                    await _cumraps.Delete(((CumRap)dvr.DataBoundItem).MaCum);

                    MessageBox.Show("Xóa thành công!");
                }
            }
        }

        private async void button24_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow dvr in dataGridView6.Rows)
            {
                if (dvr.Cells[0].Value is not null)
                {
                    await _phims.Delete(((Phim)dvr.DataBoundItem).MaPhim);

                    MessageBox.Show("Xóa thành công!");
                }
            }
        }

        private async void button1_Click_1(object sender, EventArgs e)
        {
            foreach (DataGridViewRow dvr in dataGridView7tl.Rows)
            {
                if (dvr.Cells[0].Value is not null)
                {
                    await _theloais.Delete(((TheLoai)dvr.DataBoundItem).MaTheLoai);

                    MessageBox.Show("Xóa thành công!");
                }
            }
        }

        private async void button17_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow dvr in dataGridView4.Rows)
            {
                if (dvr.Cells[0].Value is not null)
                {
                    await _raps.Delete(((Rap)dvr.DataBoundItem).MaRap);

                    MessageBox.Show("Xóa thành công!");
                }
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            qLRapChieuPhimDbContext.SaveChanges();

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            var list = _lichchieus.GetAll();
            list = list
                .Where(
                x => x.MaPhim.ToUpper().Contains((textBox4.Text.ToUpper()))
                ||
                 x.MaRap.ToUpper().Contains((textBox4.Text.ToUpper())))
                .ToList();

            dataGridView5.DataSource = list;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //THÊM RẠP
            Suarap otherForm = new Suarap();
            this.Hide();
            otherForm.Show();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            var list = _cumraps.GetAll();
            list = list
                .Where(
                x => x.MaCum.ToUpper().Contains((textBox6.Text.ToUpper())))
                .ToList();

            dataGridView2.DataSource = list;
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            var list = _theloais.GetAll();
            list = list
                .Where(
                x => x.MaTheLoai.ToUpper().Contains((textBox1.Text.ToUpper())))
                .ToList();

            dataGridView7tl.DataSource = list;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            var list = _phims.GetAll();
            list = list
                .Where(
                x => x.MaPhim.ToUpper().Contains((textBox2.Text.ToUpper())))
                .ToList();

            dataGridView6.DataSource = list;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            var list = _raps.GetAll();
            list = list
                .Where(
                x => x.MaRap.ToUpper().Contains((textBox5.Text.ToUpper())))
                .ToList();

            dataGridView4.DataSource = list;
        }

        private void button23_Click(object sender, EventArgs e)
        {
            qLRapChieuPhimDbContext.SaveChanges();

        }

        private void button18_Click_1(object sender, EventArgs e)
        {
            qLRapChieuPhimDbContext.SaveChanges();

        }

        private void button19_Click(object sender, EventArgs e)
        {
            qLRapChieuPhimDbContext.SaveChanges();

        }

        private void button20_Click(object sender, EventArgs e)
        {
            qLRapChieuPhimDbContext.SaveChanges();

        }
    }
}
