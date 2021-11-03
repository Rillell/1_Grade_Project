using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2019_2_C샵_6주차_구구단_김유빈
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Dan = 8;
            int GooGoo;

            for(GooGoo = 0; GooGoo < 9; GooGoo++)
            {
                textBox1.Text = textBox1.Text + Dan + " X " + (GooGoo + 1) + " = " + Dan * (GooGoo + 1) + System.Environment.NewLine;
            }
        }
    }
}
