using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2019_2_C샵_15주차_기말고사풀이및레포트_김유빈
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
                MessageBox.Show("영어문장을 입력하시고 버튼을 누르세요", "경고1");
            else
            {
                int iMunjang_Giri;
                iMunjang_Giri = textBox1.TextLength;
             
                string[] cMunjang_Array = new string[iMunjang_Giri];
                for (int iCount = 0; iCount <= iMunjang_Giri - 1; iCount++)
                {
                    cMunjang_Array[iCount] = textBox1.Text.Substring(iCount, 1);
                    char cTemp; int iTemp;
                    cTemp = Convert.ToChar(cMunjang_Array[iCount]);
                    iTemp = Convert.ToInt32(cTemp); //문자에 대한 아스키코드값으로 변환
                    if (iTemp < 97 || iTemp > 122)
                    {
                        MessageBox.Show("영어소문자가 아닙니다", "경고2");
                        goto Nagara;
                    }
                }
                textBox2.Text = "";
                int iLater = 10;
                for (int iCount = 0; iCount <= iMunjang_Giri - 1; iCount = iCount + 2)
                {
                    char cTemp; int iTemp;
                    cTemp = Convert.ToChar(cMunjang_Array[iCount]);
                    iTemp = Convert.ToInt32(cTemp); //문자에 대한 아스키코드값으로 변환
                    textBox2.Text = textBox2.Text + "  " + (iTemp) + "  " + iLater;
                    iLater++;
                    if (iLater == 101)
                        iLater = 10;
                    
                }

            Nagara:;
            }
        }
    }
}
