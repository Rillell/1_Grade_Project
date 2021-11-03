Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim iMunjang_Giri As Integer

        iMunjang_Giri = TextBox1.TextLength

        Dim sMunjang(iMunjang_Giri) As String

        For j = 0 To iMunjang_Giri - 1
            sMunjang(j) = Mid(TextBox1.Text, j + 1, 1)
        Next

        TextBox2.Text = ""
        For j = 0 To iMunjang_Giri - 1 Step 2
            TextBox2.Text = TextBox2.Text & sMunjang(j + 1) & sMunjang(j)
        Next

    End Sub
End Class
