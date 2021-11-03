Public Class Form2
    Dim i, j, iMunjang_giri As Integer
    Dim Alphabet_so() = {"a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z"}
    Dim Alphabet_Dae() = {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"}
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Then
            MessageBox.Show("영어문장의 소문자로 입력하고 버튼을 누르시오", "경고")
            Exit Sub
        End If
        iMunjang_giri = TextBox1.TextLength
        Dim sMunjang(iMunjang_giri) As String

        For j = 0 To iMunjang_giri - 1
            sMunjang(j) = Mid(TextBox1.Text, j + 1, 1)
        Next
        TextBox2.Text = ""
        For j = 0 To iMunjang_giri - 1
            For i = 0 To 25
                If sMunjang(j) = Alphabet_so(i) Then
                    Exit Sub
                End If
            Next
            If (i + 3) > 25 Then
            Else
                TextBox2.Text = TextBox2.Text & Alphabet_Dae((i + 3) - 26)
            End If
            TextBox2.Text = TextBox2.Text & Alphabet_Dae(i + 3)
        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        iMunjang_giri = TextBox2.TextLength
        Dim sMunjang(iMunjang_giri) As String
        TextBox3.Text = ""
        For i = 0 To iMunjang_giri - 1
            sMunjang(i) = Mid(TextBox2.Text, i + 1, 1)

        Next
        For j = 0 To iMunjang_giri - 1
            For i = 0 To 25 Step 1
                If sMunjang(j) = Alphabet_Dae(i) Then
                    Exit For
                End If
            Next
            If (i - 3) < 0 Then
                TextBox3.Text = TextBox3.Text & Alphabet_so((i - 3) + 26)
            Else
                TextBox3.Text = TextBox3.Text & Alphabet_so(i - 3)
            End If
        Next
    End Sub
End Class