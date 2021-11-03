Public Class Form5
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        For i = 1 To 9
            For j = 1 To 9
                TextBox1.Text = TextBox1.Text & i & " X " & j & " = " & (i * j) & vbCrLf
            Next
            TextBox1.Text = TextBox1.Text & vbCrLf
        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim i, j As Integer
        i = 1
        j = 1

        Do Until i > 9
            Do Until j > 9
                TextBox2.Text = TextBox2.Text & i & " X " & j & " = " & (i * j) & vbCrLf
                j = j + i
            Loop
            j = 1
            i = i + 1
            TextBox2.Text = TextBox2.Text & vbCrLf
        Loop
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim i, j As Integer
        i = 1
        j = 1

        Do
            Do
                TextBox3.Text = TextBox3.Text & i & " X " & j & " = " & (i * j) & vbCrLf
                j = j + i
            Loop Until j > 9
            j = 1
            i = i + 1
            TextBox3.Text = TextBox3.Text & vbCrLf
        Loop Until i > 9
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim i, j As Integer
        i = 1
        j = 1

        Do While i <= 9
            Do While j <= 9
                TextBox4.Text = TextBox4.Text & i & " X " & j & " = " & (i * j) & vbCrLf
                j = j + i
            Loop
            j = 1
            i = i + 1
            TextBox4.Text = TextBox4.Text & vbCrLf
        Loop
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim i, j As Integer
        i = 1
        j = 1

        Do
            Do
                TextBox5.Text = TextBox5.Text & i & " X " & j & " = " & (i * j) & vbCrLf
                j = j + i
            Loop While j <= 9
            j = 1
            i = i + 1
            TextBox5.Text = TextBox5.Text & vbCrLf
        Loop While i <= 9
    End Sub
End Class