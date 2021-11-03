Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Then
            MessageBox.Show("영어문장을 소문자로 입력하세요.", "경고1")
            Exit Sub
        End If
        Dim imunjang_giri As Integer
        imunjang_giri = TextBox1.TextLength
        Dim smunjang(imunjang_giri) As String

        For j = 0 To imunjang_giri - 1
            smunjang(j) = Mid(TextBox1.Text, j + 1, 1)
            If Asc(smunjang(j)) < 97 Or Asc(smunjang(j)) > 122 Then
                MessageBox.Show("평문은 소문자로 입력하셔야 합니다.", "경고2")
                Exit Sub
            End If
        Next
        For j = 0 To imunjang_giri - 1
            If (Asc(smunjang(j)) + 3) > 122 Then
                smunjang(j) = Chr(Asc(smunjang(j)) + 3 - 122 + 96 - 32)
            Else
                smunjang(j) = Chr(Asc(smunjang(j)) + 3 - 32)
            End If
        Next
        For j = 0 To imunjang_giri - 1
            TextBox2.Text = TextBox2.Text + smunjang(j)
        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox2.Text = "" Then
            MessageBox.Show("영어문장을 대문자로 입력하세요.", "경고3")
            Exit Sub
        End If
        Dim imunjang_giri As Integer
        imunjang_giri = TextBox2.TextLength
        Dim smunjang(imunjang_giri) As String

        For j = 0 To imunjang_giri - 1
            smunjang(j) = Mid(TextBox2.Text, j + 1, 1)
            If Asc(smunjang(j)) < 65 Or Asc(smunjang(j)) > 90 Then
                MessageBox.Show("암호문은 대문자로 입력하셔야 합니다.", "경고4")
                Exit Sub
            End If
        Next
        For j = 0 To imunjang_giri - 1
            If (Asc(smunjang(j)) - 3) < 65 Then
                smunjang(j) = Chr(Asc(smunjang(j)) - 3 + 26 + 32)
            Else
                smunjang(j) = Chr(Asc(smunjang(j)) - 3 + 32)
            End If
        Next
        For j = 0 To imunjang_giri - 1
            TextBox3.Text = TextBox3.Text + smunjang(j)
        Next
    End Sub
End Class
