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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            long num, i;
            long Sum = 0;

            num = long.Parse(textBox1.Text);
            textBox2.Text = "";
            for(i=1; i<=num; i++)
            {
                Sum = Sum + i;
                if (i == num)
                    textBox2.Text = textBox2.Text + i + " = ";
                else
                    textBox2.Text = textBox2.Text + i + " + ";
            }
           
            textBox2.Text = textBox2.Text + Sum;
        }
    }
}
