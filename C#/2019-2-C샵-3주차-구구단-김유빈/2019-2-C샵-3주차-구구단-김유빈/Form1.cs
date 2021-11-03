using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2019_2_C샵_3주차_구구단_김유빈
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i, Dan;

            Dan = int.Parse(textBox1.Text);
            textBox2.Text = "";
            for (i = 1; i <= 9; i++)
            {
                textBox2.Text = textBox2.Text + Dan + " X " + i + " = " + Dan * i + Environment.NewLine;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int i = 1, Dan;

            Dan = int.Parse(textBox4.Text);
            textBox3.Text = "";
            while (i <= 9)
            {
                textBox3.Text = textBox3.Text + Dan + " X " + i + " = " + Dan * i + Environment.NewLine;
                i++;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int i = 1, Dan;

            Dan = int.Parse(textBox6.Text);
            textBox5.Text = "";
            do
            {
                textBox5.Text = textBox5.Text + Dan + " X " + i + " = " + Dan * i + Environment.NewLine;
                i++;
            }while (i <= 9) ;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int i = 1, Dan;

            Dan = int.Parse(textBox8.Text);
            textBox7.Text = "";
            while (true) //무한반복
            {
                textBox7.Text = textBox7.Text + Dan + " X " + i + " = " + Dan * i + Environment.NewLine;
                i++;
                if (i > 9)
                    break;
            }
        }
    }
}
