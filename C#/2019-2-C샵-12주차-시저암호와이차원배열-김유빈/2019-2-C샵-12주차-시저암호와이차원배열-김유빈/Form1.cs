using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2019_2_C샵_12주차_시저암호와이차원배열_김유빈
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] Alphabet_Small = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
        string[] Alphabet_Big = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };

        private void button1_Click(object sender, EventArgs e)
        {    
            if (textBox1.Text == "")
                MessageBox.Show("영어문장을 입력하시고 버튼을 누르세요", "경고1");
            else
            {
                int iMunjang_Giri;
                iMunjang_Giri = textBox1.TextLength;

                string[] cMunjang_Array = new string[iMunjang_Giri];
                for (int iCount = 0; iCount <= iMunjang_Giri - 1; iCount++) //문장을 불러들이는 것
                {
                    cMunjang_Array[iCount] = textBox1.Text.Substring(iCount, 1);
                    int iTemp = 0;
                    for(int i = 0; i<=25; i++) //알파벳 소문자에 해당되는지 돌리는 것
                    {
                        if(cMunjang_Array[iCount] == Alphabet_Small[i]) //소문자가 맞으면 iTemp가 하나씩 증가
                        {
                            iTemp++;
                        }
                    }
                    if(iTemp == 0)
                    {
                        MessageBox.Show("영어 소문자가 아닙니다.", "경고2");
                        goto Nagara;
                    }
                }
                textBox2.Text = "";  //암호화 시작
                for(int iCount = 0; iCount <= iMunjang_Giri - 1; iCount++)
                {
                    for(int i = 0; i <= 25; i++)
                    {
                        if(cMunjang_Array[iCount] == Alphabet_Small[i])
                        {
                            if (i + 3 < 26)
                                textBox2.Text = textBox2.Text + Alphabet_Big[i + 3]; //a를 입력하면 D가 출력
                            else
                                textBox2.Text = textBox2.Text + Alphabet_Big[(i + 3) - 26];
                        }
                    }
                }
            }
            Nagara: textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
                MessageBox.Show("영어문장을 입력하시고 버튼을 누르세요", "경고3");
            else
            {
                int iMunjang_Giri;
                iMunjang_Giri = textBox2.TextLength;

                string[] cMunjang_Array = new string[iMunjang_Giri];
                for (int iCount = 0; iCount <= iMunjang_Giri - 1; iCount++) 
                {
                    cMunjang_Array[iCount] = textBox2.Text.Substring(iCount, 1);
                    int iTemp = 0;
                    for (int i = 0; i <= 25; i++) 
                    {
                        if (cMunjang_Array[iCount] == Alphabet_Big[i])
                        {
                            iTemp++;
                        }
                    }
                    if (iTemp == 0)
                    {
                        MessageBox.Show("영어 대문자가 아닙니다.", "경고4");
                        goto Nagara;
                    }
                }
                textBox3.Text = "";  //암호화 시작
                for (int iCount = 0; iCount <= iMunjang_Giri - 1; iCount++)
                {
                    for (int i = 0; i <= 25; i++)
                    {
                        if (cMunjang_Array[iCount] == Alphabet_Big[i])
                        {
                            if (i - 3 >= 0)
                                textBox3.Text = textBox3.Text + Alphabet_Small[i - 3]; 
                            else
                                textBox3.Text = textBox3.Text + Alphabet_Small[(i - 3) + 26];
                        }
                    }
                }
            }
        Nagara: textBox1.Focus();
        }
    }
}
