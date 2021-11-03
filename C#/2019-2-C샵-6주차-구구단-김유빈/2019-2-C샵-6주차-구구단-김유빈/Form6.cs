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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //int Dan, GooGoo;
            //int k;

            //for (Dan = 1; Dan < 10; Dan = Dan + 9)
            //{
            //    for (GooGoo = 1; GooGoo < 10; GooGoo++)
            //    {
            //        for (k = 0; k < 9; k++)
            //        {
            //            textBox1.Text = textBox1.Text + (Dan + k) + " X " + GooGoo + " = " + (Dan + k) * GooGoo + "         ";
            //        }
            //        textBox1.Text = textBox1.Text + System.Environment.NewLine;
            //    }
            //    textBox1.Text = textBox1.Text + System.Environment.NewLine;
            //}
            int Dan;
            int GooGoo;

            for(GooGoo = 1; GooGoo < 10; GooGoo++)
            {
                for(Dan = 1; Dan < 10; Dan++)
                {
                    textBox1.Text = textBox1.Text + Dan + " X " + GooGoo + " = " + Dan * GooGoo + "         ";
                }
                textBox1.Text = textBox1.Text + System.Environment.NewLine;
            }
        }
    }
}
