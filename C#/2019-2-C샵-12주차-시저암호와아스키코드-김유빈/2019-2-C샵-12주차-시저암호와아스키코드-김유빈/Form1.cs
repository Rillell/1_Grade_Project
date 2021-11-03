using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2019_2_C샵_12주차_시저암호와아스키코드_김유빈
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //A ~ Z : 65~90 ,  a~z: 97~122  아스키 코트값
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
                MessageBox.Show("영어문장을 입력하시고 버튼을 누르세요", "경고1");
            else
            {
                int iMunjang_Giri;
                iMunjang_Giri = textBox1.TextLength;

                string[] cMunjang_Array = new string[iMunjang_Giri];
                for(int iCount = 0; iCount <= iMunjang_Giri - 1; iCount++)
                { //입력 및 영어 소문자 체크 부분
                    cMunjang_Array[iCount] = textBox1.Text.Substring(iCount,1);
                    char cTemp; int iTemp;
                    cTemp = Convert.ToChar(cMunjang_Array[iCount]); //string을 char에 담기 위한 변환
                    iTemp = Convert.ToInt32(cTemp); //문자에 대한 아스키코드값으로 변환 , char형만 허용된다.
                    if(iTemp < 97 || iTemp > 122)
                    {
                        MessageBox.Show("영어 소문자가 아닙니다.","경고2");
                        goto Nagara;
                    }
                }
                textBox2.Text = ""; 
                for(int iCount = 0; iCount <= iMunjang_Giri - 1; iCount++)
                { //암호화 및 출력 부분
                    char cTemp; int iTemp;
                    cTemp = Convert.ToChar(cMunjang_Array[iCount]); //string을 char에 담기 위한 변환
                    iTemp = Convert.ToInt32(cTemp); //문자에 대한 아스키코드값으로 변환 , char형만 허용된다.
                    if(iTemp + 3 - 32 > 90)
                    textBox2.Text = textBox2.Text + Convert.ToChar(iTemp + 3 - 32 - 26); //시저 암호므로 +3, 대문자로 출력해야 하므로 -32
                    else
                        textBox2.Text = textBox2.Text + Convert.ToChar(iTemp + 3 - 32);
                }
            }
        Nagara:;
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
                { //입력 및 영어 대문자 체크 부분
                    cMunjang_Array[iCount] = textBox2.Text.Substring(iCount, 1);
                    char cTemp; int iTemp;
                    cTemp = Convert.ToChar(cMunjang_Array[iCount]); //string을 char에 담기 위한 변환
                    iTemp = Convert.ToInt32(cTemp); //문자에 대한 아스키코드값으로 변환 , char형만 허용된다.
                    if (iTemp < 65 || iTemp > 90)
                    {
                        MessageBox.Show("영어 대문자가 아닙니다.", "경고4");
                        goto Nagara;
                    }
                }
                textBox3.Text = "";
                for (int iCount = 0; iCount <= iMunjang_Giri - 1; iCount++)
                { //복호화 및 출력 부분
                    char cTemp; int iTemp;
                    cTemp = Convert.ToChar(cMunjang_Array[iCount]); //string을 char에 담기 위한 변환
                    iTemp = Convert.ToInt32(cTemp); //문자에 대한 아스키코드값으로 변환 , char형만 허용된다.
                    if (iTemp - 3 + 32 < 97)
                        textBox3.Text = textBox3.Text + Convert.ToChar(iTemp - 3 + 32 + 26);
                    else
                        textBox3.Text = textBox3.Text + Convert.ToChar(iTemp - 3 + 32);
                }
            }
        Nagara:;
        }
    }
}
