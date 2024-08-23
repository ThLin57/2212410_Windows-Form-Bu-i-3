using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2212410_BT2
{
    public partial class frmBai2 : Form
    {
        public frmBai2()
        {
            InitializeComponent();
        }

        private void a_Click(object sender, EventArgs e)
        {
            var item = lsbDanhSachHH.SelectedItem;
            lsbDSHangBo.Items.Add(item);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var item = lsbDSHangBo.SelectedItem;
            lsbDSHangBo.Items.Remove(lsbDSHangBo.SelectedItem);
            lsbDanhSachHH.Items.Add(item);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int soTien = 0;
            foreach (var hang in lsbDSHangBo.Items)
            {
                switch (hang)
                {
                    case "Chuột":
                        soTien+=100000;
                        break;
                    case "Bàn Phím":
                        soTien += 100000;
                        break;
                    case "Máy In":
                        soTien += 130000;
                        break;
                    case "USB Kingmax":
                        soTien += 140000;
                        break;
                    default:    
                        break;
                }
                lbSoTien.Text = soTien.ToString();
            }
        }
    }
}
