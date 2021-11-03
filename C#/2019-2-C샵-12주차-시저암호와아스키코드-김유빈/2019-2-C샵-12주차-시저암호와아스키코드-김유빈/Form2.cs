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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
                MessageBox.Show("영어문장을 입력하시고 버튼을 누르세요", "경고1");
            else if (textBox4.Text == "")
                MessageBox.Show("쉬프트 길이를 입력하시고 버튼을 누르세요", "경고2");
            else
            {
                int iMunjang_Giri;
                iMunjang_Giri = textBox1.TextLength;

                string[] cMunjang_Array = new string[iMunjang_Giri];
                for (int iCount = 0; iCount <= iMunjang_Giri - 1; iCount++)
                { //입력 및 영어 소문자 체크 부분
                    cMunjang_Array[iCount] = textBox1.Text.Substring(iCount, 1);
                    char cTemp; int iTemp;
                    cTemp = Convert.ToChar(cMunjang_Array[iCount]); //string을 char에 담기 위한 변환
                    iTemp = Convert.ToInt32(cTemp); //문자에 대한 아스키코드값으로 변환 , char형만 허용된다.
                    if (iTemp < 97 || iTemp > 122)
                    {
                        MessageBox.Show("영어 소문자가 아닙니다.", "경고3");
                        goto Nagara;
                    }
                }
                int iShift_Giri;
                iShift_Giri = int.Parse(textBox4.Text);
                if(iShift_Giri < 1 || iShift_Giri > 25)
                {
                    MessageBox.Show("쉬프트 길이가 적절치 않습니다.", "경고4");
                    goto Nagara;
                }

                textBox2.Text = "";
                for (int iCount = 0; iCount <= iMunjang_Giri - 1; iCount++)
                { //암호화 및 출력 부분
                    char cTemp; int iTemp;
                    cTemp = Convert.ToChar(cMunjang_Array[iCount]); //string을 char에 담기 위한 변환
                    iTemp = Convert.ToInt32(cTemp); //문자에 대한 아스키코드값으로 변환 , char형만 허용된다.
                    if (iTemp + iShift_Giri - 32 > 90)
                        textBox2.Text = textBox2.Text + Convert.ToChar(iTemp + iShift_Giri - 32 - 26); //시저 암호므로 +3, 대문자로 출력해야 하므로 -32
                    else
                        textBox2.Text = textBox2.Text + Convert.ToChar(iTemp + iShift_Giri - 32);
                }
            }
        Nagara:;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
                MessageBox.Show("영어문장을 입력하시고 버튼을 누르세요", "경고5");
            else if (textBox4.Text == "")
                MessageBox.Show("쉬프트 길이를 입력하시고 버튼을 누르세요", "경고6");
            else
            {
                int iMunjang_Giri;
                iMunjang_Giri = textBox2.TextLength;

                string[] cMunjang_Array = new string[iMunjang_Giri];
                for (int iCount = 0; iCount <= iMunjang_Giri - 1; iCount++)
                { //입력 및 영어 소문자 체크 부분
                    cMunjang_Array[iCount] = textBox2.Text.Substring(iCount, 1);
                    char cTemp; int iTemp;
                    cTemp = Convert.ToChar(cMunjang_Array[iCount]); //string을 char에 담기 위한 변환
                    iTemp = Convert.ToInt32(cTemp); //문자에 대한 아스키코드값으로 변환 , char형만 허용된다.
                    if (iTemp < 65 || iTemp > 90)
                    {
                        MessageBox.Show("영어 대문자가 아닙니다.", "경고7");
                        goto Nagara;
                    }
                }
                int iShift_Giri;
                iShift_Giri = int.Parse(textBox4.Text);
                if (iShift_Giri < 1 || iShift_Giri > 25)
                {
                    MessageBox.Show("쉬프트 길이가 적절치 않습니다.", "경고8");
                    goto Nagara;
                }

                textBox3.Text = "";
                for (int iCount = 0; iCount <= iMunjang_Giri - 1; iCount++)
                { //암호화 및 출력 부분
                    char cTemp; int iTemp;
                    cTemp = Convert.ToChar(cMunjang_Array[iCount]); //string을 char에 담기 위한 변환
                    iTemp = Convert.ToInt32(cTemp); //문자에 대한 아스키코드값으로 변환 , char형만 허용된다.
                    if (iTemp - iShift_Giri + 32 < 97)
                        textBox3.Text = textBox3.Text + Convert.ToChar(iTemp - iShift_Giri + 32 + 26); //시저 암호므로 +3, 대문자로 출력해야 하므로 -32
                    else
                        textBox3.Text = textBox3.Text + Convert.ToChar(iTemp - iShift_Giri + 32);
                }
            }
        Nagara:;
        }
    }
}
