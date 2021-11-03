using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2019_2_C샵_10주차_배열길이따기_김유빈
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
                MessageBox.Show("문장을 입력하시고 버튼을 누르세요", "경고1");
            else
            {
                int iMunjang_Giri;
                iMunjang_Giri = textBox1.TextLength;

                //textBox2.Text = iMunjang_Giri.ToString();
                string[] sMunjang_Array = new string[iMunjang_Giri];

                for (int i = 0; i <= iMunjang_Giri - 1; i++)
                {
                    sMunjang_Array[i] = textBox1.Text.Substring(i, 1); // i가 하나씩 증가한다.
                }
                textBox2.Text = "";
                for (int i = iMunjang_Giri - 1; i >= 0; i--)
                {
                    textBox2.Text = textBox2.Text + sMunjang_Array[i]; //문장을 거꾸로
                }

                //for (int i = 0; i <= iMunjang_Giri - 1; i++)
                //{
                //    textBox2.Text = sMunjang_Array[i] + textBox2.Text;
                //    //textBox2.Text = textBox2.Text + sMunjang_Array[(iMunjang_Giri - 1) -1]; //둘중 하나 사용
                //}
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
                MessageBox.Show("문장을 입력하시고 버튼을 누르세요", "경고2");
            else
            {
                int iMunjang_Giri;
                iMunjang_Giri = textBox2.TextLength;

                //textBox2.Text = iMunjang_Giri.ToString();
                string[] sMunjang_Array = new string[iMunjang_Giri];

                for (int i = 0; i <= iMunjang_Giri - 1; i++)
                {
                    sMunjang_Array[i] = textBox2.Text.Substring(i, 1); // i가 하나씩 증가한다.
                }
                textBox3.Text = "";
                for (int i = iMunjang_Giri - 1; i >= 0; i--)
                {
                    textBox3.Text = textBox3.Text + sMunjang_Array[i]; //문장을 거꾸로=> 복호화
                }
            }
        }
    }
}
