﻿using System;
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
    public partial class Suacumrap : Form
    {
        public Suacumrap()
        {
            InitializeComponent();
        }

        private void Suacumrap_Load(object sender, EventArgs e)
        {

        }

        private void Suacumrap_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form2 otherForm = new Form2();
            this.Hide();
            otherForm.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cập nhật thành công!");

            Form2 otherForm = new Form2();
            this.Hide();
            otherForm.Show();
        }
    }
}
