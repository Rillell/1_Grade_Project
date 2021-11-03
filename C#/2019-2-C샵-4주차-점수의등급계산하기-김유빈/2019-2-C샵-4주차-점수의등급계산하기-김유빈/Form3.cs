using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2019_2_C샵_4주차_점수의등급계산하기_김유빈
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i, iErr_Counter = 0;
            int[] iJumsu = new int[7];
            string[] sDoongub = new string[7];

            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" ||
                textBox5.Text == "" || textBox6.Text == "" || textBox7.Text == "")
                MessageBox.Show("모든 입력을 하시고 버튼을 누르시오", "경고1");
            else
            {
                iJumsu[0] = int.Parse(textBox1.Text);
                iJumsu[1] = int.Parse(textBox2.Text);
                iJumsu[2] = int.Parse(textBox3.Text);
                iJumsu[3] = int.Parse(textBox4.Text);
                iJumsu[4] = int.Parse(textBox5.Text);
                iJumsu[5] = int.Parse(textBox6.Text);
                iJumsu[6] = int.Parse(textBox7.Text);

                for(i = 0; i < 7; i++)
                {
                    if (iJumsu[i] < 0 || iJumsu[i] > 100)
                        iErr_Counter++;
                }
                if (iErr_Counter > 0)
                    MessageBox.Show("0 ~ 100 사이의 점수를 " + iErr_Counter.ToString() + "번 확인하고", "경고2");

                else
                {
                    for(i = 0; i < 7; i++)
                    {
                        if (iJumsu[i] > 95)
                            sDoongub[i] = "A+";
                        else if (iJumsu[i] > 89)
                            sDoongub[i] = "A0";
                        else if (iJumsu[i] > 85)
                            sDoongub[i] = "B+";
                        else if (iJumsu[i] > 79)
                            sDoongub[i] = "B0";
                        else if (iJumsu[i] > 75)
                            sDoongub[i] = "C+";
                        else if (iJumsu[i] > 69)
                            sDoongub[i] = "C0";
                        else if (iJumsu[i] > 65)
                            sDoongub[i] = "D+";
                        else if (iJumsu[i] > 59)
                            sDoongub[i] = "D0";
                        else
                            sDoongub[i] = "F";
                    }
                    textBox8.Text = sDoongub[0];
                    textBox9.Text = sDoongub[1];
                    textBox10.Text = sDoongub[2];
                    textBox11.Text = sDoongub[3];
                    textBox12.Text = sDoongub[4];
                    textBox13.Text = sDoongub[5];
                    textBox14.Text = sDoongub[6];
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
