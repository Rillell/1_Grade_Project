using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2019_2_C샵_5주차_배열이용하기_김유빈
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //int[] GooGoo = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int[] GooGoo = new int[9];
            for ( int i = 0; i < 9; i++) //배열 초기화
            {
                GooGoo[i] = i + 1;
            }
            foreach(int k in GooGoo)
            {
                foreach(int s in GooGoo)
                {
                    textBox1.Text = textBox1.Text + k + "X" + s + "=" + (k * s) + Environment.NewLine;
                }
                textBox1.Text = textBox1.Text + Environment.NewLine;
            }
        }
    }
}
