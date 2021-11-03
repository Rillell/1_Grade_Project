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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int iJumsu;
            string sDoongub; 

            if (textBox1.Text == "")
                MessageBox.Show("점수를 입력하고 버튼을 누르시오", "경고1");
            else
            {
                iJumsu = int.Parse(textBox1.Text);
                if (iJumsu < 0 || iJumsu > 100)
                    MessageBox.Show("0 ~ 100사이의 점수를 입력하시오", "경고2");
                else
                {
                    switch(iJumsu/5)
                    {
                        case 20:
                        case 19:                       
                            sDoongub = "A+"; break;
                        case 18:
                            sDoongub = "A0"; break;
                        case 17:
                            sDoongub = "B+"; break;
                        case 16:
                            sDoongub = "B0"; break;
                        case 15:
                            sDoongub = "C+"; break;
                        case 14:
                            sDoongub = "C0"; break;
                        case 13:
                            sDoongub = "D+"; break;
                        case 12:
                            sDoongub = "D0"; break;
                        default:
                            sDoongub = "F"; break;

                    }
                    textBox2.Text = sDoongub;
                }
            }
        }
    }
}
