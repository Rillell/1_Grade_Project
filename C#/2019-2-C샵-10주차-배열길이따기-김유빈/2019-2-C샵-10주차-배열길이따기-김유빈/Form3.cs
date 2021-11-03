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
    public partial class Form3 : Form
    {
        public Form3()
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


                if (iMunjang_Giri % 3 == 1)
                {   //padding 작업(무의미한 글자 두개 추가)
                    textBox1.Text = textBox1.Text + "가나";
                    iMunjang_Giri = iMunjang_Giri + 2;
                }
                else if(iMunjang_Giri % 3 == 2)
                {
                    textBox1.Text = textBox1.Text + "가";
                    iMunjang_Giri = iMunjang_Giri + 1;
                }

                string[] sMunjang_Array = new string[iMunjang_Giri];

                for (int i = 0; i <= iMunjang_Giri - 1; i++)
                {   //문장에서 한글자씩 잘라서 배열로 읽어들어옴.
                    sMunjang_Array[i] = textBox1.Text.Substring(i, 1);
                }
                textBox2.Text = "";
                for (int i = 0; i <= iMunjang_Giri - 1; i = i + 3)
                {
                    textBox2.Text = textBox2.Text + sMunjang_Array[i + 1] + sMunjang_Array[i] + sMunjang_Array[i + 2];
                }
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

                string[] sMunjang_Array = new string[iMunjang_Giri];

                for (int i = 0; i <= iMunjang_Giri - 1; i++)
                {   //문장에서 한글자씩 잘라서 배열로 읽어들어옴.
                    sMunjang_Array[i] = textBox2.Text.Substring(i, 1);
                }
                textBox3.Text = "";
                for (int i = 0; i <= iMunjang_Giri - 1; i = i + 3)
                {
                    textBox3.Text = textBox3.Text + sMunjang_Array[i + 1] + sMunjang_Array[i] + sMunjang_Array[i + 2];
                }
            }
        }
    }
}
