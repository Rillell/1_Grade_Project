using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2019_2_C샵_9주차_중간고사풀이_김유빈
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Sutja, Sum = 0;
            if (textBox1.Text == "")
                MessageBox.Show("숫자를 입력하고 버튼을 누르시오", "경고1");
            else
            {
                Sutja = int.Parse(textBox1.Text);
                if (Sutja < 2)
                    MessageBox.Show("1보다 큰 숫자를 입력하시오", "경고2");
                else
                {
                    for(int i = Sutja; i >= 1; i--)
                    {
                        Sum = Sum + i;
                        if (i == 1)
                            textBox2.Text = textBox2.Text + i + " = " + Sum;
                        else
                            textBox2.Text = textBox2.Text + i + " + ";
                    }
                    //textBox2.Text = textBox2.Text + Sum;
                }
            }
        }
    }
}
