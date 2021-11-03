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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String Temp;

            if (textBox1.Text == "")
                MessageBox.Show("문자 입력하고 버튼을 누르시오", "경고1");
            else
            {
                Temp = textBox1.Text;
                if (Temp != "수" && Temp != "우" && Temp != "미" && Temp != "양" && Temp != "가")
                    MessageBox.Show("맞는 문자를 입력하시오", "경고2");
                else
                {
                    switch(Temp)
                    {
                        case "가":
                            textBox2.Text = "매우 분발하세요"; break;
                        case "양":
                            textBox2.Text = "분발하세요"; break;
                        case "미":
                            textBox2.Text = "보통입니다"; break;
                        case "우":
                            textBox2.Text = "잘했습니다"; break;
                        default:
                            textBox2.Text = "매우 잘했습니다"; break;
                    }
                }
                //{
                //    if (Temp == "가")
                //        textBox2.Text = "매우 분발하세요";
                //    else if (Temp == "양")
                //        textBox2.Text = "분발하세요";
                //    else if (Temp == "미")
                //        textBox2.Text = "보통입니다";
                //    else if (Temp == "우")
                //        textBox2.Text = "잘했습니다";
                //    else //(Temp == "수")
                //        textBox2.Text = "매우 잘했습니다";
                //}
            }
        }
    }
}
