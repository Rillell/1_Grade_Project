Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If (TextBox1.Text = "김유빈" And TextBox2.Text = "1122") Then
            Label3.Text = TextBox1.Text + " 님 반갑습니다"
        Else
            Label3.Text = "아이디와 비밀번호를 확인해주세요"

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Label3.Text = "다시 입력해주세요."
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox1.Focus()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        End
    End Sub
End Class
