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
    public partial class Form1 : Form
    {
        private TextBox[] txtInput, txtOutput; // <-- 추가
        public Form1()
        {
            InitializeComponent();
            txtInput = new TextBox[] {textBox1, textBox2, textBox3, textBox4, textBox5, textBox6, textBox7};
            txtOutput = new TextBox[] {textBox8, textBox9, textBox10, textBox11, textBox12, textBox13, textBox14};
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = 0;
            int[] iJumsu = new int[7];
            string[] sDoongub = new string[7];

            for(i = 0; i < 7; i++)
            {
                if(txtInput[i].Text == "")
                {
                    MessageBox.Show("TextBox" + (i + 1) + ".Text" + " 가 비어있음", "경고1"); //배열은 0부터 시작하기 때문에 +1 을 한다.
                    goto Retry;
                }
            }
            for (i = 0; i < 7; i++) //입력테스트박스 로부터 데이터를 읽어옴.
            {
                iJumsu[i] = int.Parse(txtInput[i].Text);
            }
            for (i = 0; i < 7; i++)
            {
                if (iJumsu[i] < 0 || iJumsu[i] > 100)
                {
                    MessageBox.Show("TextBox" + (i + 1) + ".Text" + " 의 점수가 이상함", "경고2");
                    goto Retry;
                }
            }
            for(i = 0; i < 7; i++) //등급계산
            {
                if (iJumsu[i] > 94)
                    sDoongub[i] = "A+";
                else if (iJumsu[i] > 89)
                    sDoongub[i] = "A0";
                else if (iJumsu[i] > 84)
                    sDoongub[i] = "B+";
                else if (iJumsu[i] > 79)
                    sDoongub[i] = "B0";
                else if (iJumsu[i] > 74)
                    sDoongub[i] = "C+";
                else if (iJumsu[i] > 69)
                    sDoongub[i] = "C0";
                else if (iJumsu[i] > 64)
                    sDoongub[i] = "D+";
                else if (iJumsu[i] > 59)
                    sDoongub[i] = "D0";
                else
                    sDoongub[i] = "F";
            }
            for (i = 0; i < 7; i++) //등급출력
            {
                txtOutput[i].Text = sDoongub[i];
            }
            Retry: i = 0;
        }
    }
}
