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
    public partial class frBai3 : Form
    {   List<string> list = new List<string>();

        public frBai3()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var tu = textBox1.Text;
            var nghia = textBox2.Text;
            listBox1.Items.Add(tu);
            list.Add(nghia);
            //listBox2.Items.Add(nghia);
            //list.Add(nghia);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var stt = listBox1.SelectedIndex;
            textBox3.Text = list[stt];
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
