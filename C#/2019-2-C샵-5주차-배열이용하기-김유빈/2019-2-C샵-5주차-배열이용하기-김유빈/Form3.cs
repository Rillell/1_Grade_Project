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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 1; i < 10; i = i + 3)
            {
                for (int j = 1; j < 10; j++)
                {
                    for (int k = 0; k < 3; k++)
                    {
                        textBox1.Text = textBox1.Text + (i + k) + " X " + j + " = " + (i + k) * j + "     ";
                    }
                    textBox1.Text = textBox1.Text + "\r\n";
                }
                textBox1.Text = textBox1.Text + "\r\n";
            }
        }
    }
}
