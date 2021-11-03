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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Dan, GooGoo;

            for (Dan = 0; Dan < 9; Dan++)
            {
                for (GooGoo = 0; GooGoo < 9; GooGoo++)
                {
                    textBox1.Text = textBox1.Text + (Dan + 1) + " X " + (GooGoo + 1) + " = " + (Dan + 1) * (GooGoo + 1) + System.Environment.NewLine;
                }
                textBox1.Text = textBox1.Text + System.Environment.NewLine;
            }
                
        }
    }
}
