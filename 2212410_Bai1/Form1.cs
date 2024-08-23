using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2212410_Bai1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtNhapTen_TextChanged(object sender, EventArgs e)
        {
            txtSaoChep.Text = txtNhapTen.Text;
        }

        private void btXuLy_Click(object sender, EventArgs e)
        {
            var tenDangNhap = txtNhapTen.Text;
            MessageBox.Show($"Xin chao ban {tenDangNhap}.Rat vui duoc gap ban", "Thong diep chao mung");
        }

        private void btSaoChep_Click(object sender, EventArgs e)
        {
            txtSaoChep.Text = txtNhapTen.Text;
        }
    }
}
