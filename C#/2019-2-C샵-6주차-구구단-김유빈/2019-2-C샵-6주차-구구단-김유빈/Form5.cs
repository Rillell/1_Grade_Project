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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Dan, GooGoo;
            int k;

            for (Dan = 2; Dan < 10; Dan = Dan + 4)
            {
                for (GooGoo = 1; GooGoo < 10; GooGoo++)
                {
                    for (k = 0; k < 4; k++)
                    {
                        textBox1.Text = textBox1.Text + (Dan + k) + " X " + GooGoo + " = " + (Dan + k) * GooGoo + "         " ; 
                    }
                    textBox1.Text = textBox1.Text + System.Environment.NewLine;
                }
            textBox1.Text = textBox1.Text + System.Environment.NewLine;
            }
        }
    }
}
