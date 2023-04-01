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
    public partial class Suarap : Form
    {
        public Suarap()
        {
            InitializeComponent();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cập nhật thành công!");

            Form2 otherForm = new Form2();
            this.Hide();
            otherForm.Show();
        }

        private void Suarap_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form2 otherForm = new Form2();
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

        public static implicit operator Suarap(Sualichchieu v)
        {
            throw new NotImplementedException();
        }
    }
}
