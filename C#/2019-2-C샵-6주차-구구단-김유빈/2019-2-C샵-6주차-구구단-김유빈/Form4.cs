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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Dan, GooGoo;
       
            for (Dan = 1; Dan < 10; Dan = Dan + 3)
            {
                for (GooGoo = 1; GooGoo < 10; GooGoo++)
                {
                    textBox1.Text = textBox1.Text + Dan + " X " + GooGoo + " = " + Dan * GooGoo + "         " +
                         (Dan + 1) + " X " + GooGoo + " = " + ((Dan + 1) * GooGoo) + "          " + 
                         (Dan + 2) + " X " + GooGoo + " = " + ((Dan + 2) * GooGoo) + System.Environment.NewLine;
                }
                textBox1.Text = textBox1.Text + System.Environment.NewLine;
            }
        }
    }
}
