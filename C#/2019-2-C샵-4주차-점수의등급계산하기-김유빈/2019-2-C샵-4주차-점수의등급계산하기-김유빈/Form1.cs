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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int iJumsu;
            string sDoongub = ""; //초기화

            if (textBox1.Text == "")
                MessageBox.Show("점수를 입력하고 버튼을 누르시오", "경고1");
            else
            {
                iJumsu = int.Parse(textBox1.Text);
                if (iJumsu < 0 || iJumsu > 100)
                    MessageBox.Show("0 ~ 100사이의 점수를 입력하시오", "경고2");
                else
                {
                    if (iJumsu > 95)
                        sDoongub = "A+";
                    else if(iJumsu > 89)
                        sDoongub = "A0";
                    else if (iJumsu > 85)
                        sDoongub = "B+";
                    else if (iJumsu > 79)
                        sDoongub = "B0";
                    else if (iJumsu > 75)
                        sDoongub = "C+";
                    else if (iJumsu > 69)
                        sDoongub = "C0";
                    else if (iJumsu > 65)
                        sDoongub = "D+";
                    else if (iJumsu > 59)
                        sDoongub = "D0";
                    else
                        sDoongub = "F";

                //만약 초기화가 되어있지 않는다면 가로 안에  textBox2.Text = sDoongub; 을 놓아야 한다.   
                }
                textBox2.Text = sDoongub;
            }
        }
    }
}
