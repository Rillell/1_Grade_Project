using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2019_2_C샵_15주차_기말고사풀이및레포트_김유빈
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] Cheon = new int[10];

            for(int i = 0; i < 10; i++)
            {
                Cheon[i] = i + 1;
            }
            foreach(int k in Cheon)
            {
                foreach(int s in Cheon)
                {
                    textBox1.Text = textBox1.Text + k + " X " + s + " = " + k * s + "\r\n";
                }
                textBox1.Text = textBox1.Text + "\r\n";
            }
        }
    }
}
