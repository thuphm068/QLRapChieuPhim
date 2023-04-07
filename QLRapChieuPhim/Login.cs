using Microsoft.Extensions.DependencyInjection;
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
    public partial class Login : Form
    {

        private static readonly QLRapChieuPhimDbContext qLRapChieuPhimDbContext = new QLRapChieuPhimDbContext();
        TKDNRepository _tkdns = new TKDNRepository(qLRapChieuPhimDbContext);
        public static Form2 otherForm;

        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            var username = textBox1.Text;
            var pw = textBox2.Text;
            var user = _tkdns.Login(username, pw);
            if ( user is not null)
            {
                otherForm = new Form2(user);
                otherForm.FormClosed += new FormClosedEventHandler(otherForm_FormClosed);
                this.Hide();
                otherForm.Show();
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại!");
            }

            
          

        }


        void otherForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void Login_Load(object sender, EventArgs e)
        {
        }
    }
}
