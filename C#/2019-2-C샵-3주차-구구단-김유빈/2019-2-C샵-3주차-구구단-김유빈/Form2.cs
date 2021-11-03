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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i, Dan;
            textBox2.Text = "";
            for (Dan = 1; Dan <= 9; Dan++)
            {
                for (i = 1; i <= 9; i++)
                {
                    textBox2.Text = textBox2.Text + Dan + " X " + i + " = " + Dan * i + Environment.NewLine;
                }
                textBox2.Text= textBox2.Text+ Environment.NewLine;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int i = 1, Dan = 1;
            textBox3.Text = "";

            {
                while (Dan <= 9)
                {
                    while (i <= 9)

                    {
                        textBox3.Text = textBox3.Text + Dan + " X " + i + " = " + Dan * i + Environment.NewLine;
                        i++;
                    }
                    textBox3.Text = textBox3.Text + Environment.NewLine;
                    i = 1;
                    Dan++;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int i = 1, Dan = 1;
            textBox5.Text = "";

            {
                do
                {
                    do
                    {
                        textBox5.Text = textBox5.Text + Dan + " X " + i + " = " + Dan * i + Environment.NewLine;
                        i++;
                    } while (i <= 9);
                    i = 1;
                    Dan++;
                    textBox5.Text = textBox5.Text + Environment.NewLine;
                } while (Dan <= 9);
               
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int i = 1, Dan = 1;
            textBox7.Text = "";

            while (true)
            {
                while (true) //무한반복
                {
                    textBox7.Text = textBox7.Text + Dan + " X " + i + " = " + Dan * i + Environment.NewLine;
                    i++;
                    if (i > 9)
                        break;
                }
                    i = 1;
                    Dan++;
                    if (Dan > 9)
                        break;
                textBox7.Text = textBox7.Text + Environment.NewLine;

            }
        }
    }
}
