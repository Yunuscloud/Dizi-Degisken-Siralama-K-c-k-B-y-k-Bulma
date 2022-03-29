using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int [] sayi ={6,5,2,8,9,45,21,74,13};
        private void button1_Click(object sender, EventArgs e)
        {
            Array.Sort(sayi);
            listBox1.Items.Clear();
            for (int i = 0; i < sayi.Length; i++) 
            {
                listBox1.Items.Add(sayi[i]);
            }
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            Array.Reverse(sayi);
            listBox1.Items.Clear();
            for (int i = 0; i < sayi.Length; i++)
            {
                listBox1.Items.Add(sayi[i]);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = sayi.Max().ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label2.Text = sayi.Min().ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label3.Text = sayi.Sum().ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label4.Text = sayi.Average().ToString();
        }

    }
}
