using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2019_2_C샵_2주차_두숫자의연산_김유빈
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            long Sum1 = 0;
            long Sum2 = 0;
            int num, i;

            num = int.Parse(textBox1.Text);
            textBox2.Text = "0";
            textBox3.Text = "0";

            for (i = 1; i <= num; ++i)
            
                if (i % 2 == 1)
                {
                    Sum2 = Sum2 + i;
                    textBox2.Text = textBox2.Text  + " + " + i;
                }



                else if (i % 2 == 0)
                {
                    Sum1 = Sum1 + i;
                    textBox3.Text = textBox3.Text + " + "+ i ;

                };
                textBox3.Text = textBox3.Text + " = " + Sum1;
                textBox2.Text = textBox2.Text + " = " + Sum2;
            }
        }
    }

