Public Class Form3
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim i, j As Integer
        TextBox1.Text = ""
        For i = 1 To 9 Step 1
            For j = 1 To 9 Step 1
                TextBox1.Text = TextBox1.Text & i & " X " & j & " = " & (i * j) & vbCrLf
            Next
            TextBox1.Text = TextBox1.Text & vbCrLf

        Next

    End Sub
End Class