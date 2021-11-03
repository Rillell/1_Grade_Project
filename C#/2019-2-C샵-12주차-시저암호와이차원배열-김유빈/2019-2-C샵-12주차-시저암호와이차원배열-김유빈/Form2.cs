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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        string[,] Alphabet = { { "a", "A" }, { "b","B"},{ "c" ,"C"}, { "d","D" }, { "e" ,"E"}, { "f","F" }, { "g","G" }, { "h","H" }, { "i","I" }, { "j","J" }, { "k" ,"K"}, { "l","L" },
            { "m","M" }, { "n","N" }, { "o","O" }, { "p","P" }, { "q","Q" }, { "r","R" }, { "s","S" }, { "t","T" }, { "u" ,"U"}, { "v","V" }, { "w","W" }, { "x","X" }, { "y","Y" }, { "z","Z" } };
        //2차원 배열 선언 a,b,c ... A,B,C 순서로 
        //00 10 20 30 ... => a, b, c...
        //01 11 21 31 ... => A, B, C...
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
                    for (int i = 0; i <= 25; i++) //알파벳 소문자에 해당되는지 돌리는 것
                    {
                        if (cMunjang_Array[iCount] == Alphabet[i,0]) //소문자가 맞으면 iTemp가 하나씩 증가
                        {
                            iTemp++;
                        }
                    }
                    if (iTemp == 0)
                    {
                        MessageBox.Show("영어 소문자가 아닙니다.", "경고2");
                        goto Nagara;
                    }
                }
                textBox2.Text = "";  //암호화 시작
                for (int iCount = 0; iCount <= iMunjang_Giri - 1; iCount++)
                {
                    for (int i = 0; i <= 25; i++)
                    {
                        if (cMunjang_Array[iCount] == Alphabet[i,0])
                        {
                            if (i + 3 < 26)
                                textBox2.Text = textBox2.Text + Alphabet[i + 3 ,1]; //a를 입력하면 D가 출력
                            else
                                textBox2.Text = textBox2.Text + Alphabet[(i + 3) - 26 , 1];
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
                for (int iCount = 0; iCount <= iMunjang_Giri - 1; iCount++) //문장을 불러들이는 것
                {
                    cMunjang_Array[iCount] = textBox2.Text.Substring(iCount, 1);
                    int iTemp = 0;
                    for (int i = 0; i <= 25; i++) //알파벳 소문자에 해당되는지 돌리는 것
                    {
                        if (cMunjang_Array[iCount] == Alphabet[i,1]) //소문자가 맞으면 iTemp가 하나씩 증가
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
                        if (cMunjang_Array[iCount] == Alphabet[i,1])
                        {
                            if (i - 3 >= 0)
                                textBox3.Text = textBox3.Text + Alphabet[i - 3, 0]; //a를 입력하면 D가 출력
                            else
                                textBox3.Text = textBox3.Text + Alphabet[(i - 3) + 26 , 0];
                        }
                    }
                }
            }
        Nagara: textBox1.Focus();
        }
    }
}
    

