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
    public partial class Sualichchieu : Form
    {
        public Sualichchieu()
        {
            InitializeComponent();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cập nhật thành công!");

            Form2 otherForm = new Form2();
            this.Hide();
            otherForm.Show();
        }

        private void Sualichchieu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form2 otherForm = new Form2();
            this.Hide();
            otherForm.Show();
        }
    }
}
