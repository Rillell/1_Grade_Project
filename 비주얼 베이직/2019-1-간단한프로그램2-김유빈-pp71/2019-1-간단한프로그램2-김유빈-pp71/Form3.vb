Public Class Form3

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim N, i, oddsum, evensum As Integer
        N = TextBox1.Text
        TextBox2.Text = ""
        TextBox3.Text = ""
        For i = 1 To N Step 1
            If (i Mod 2 = 1) Then

            End If
            oddsum = oddsum + i
            If (TextBox2.Text = "") Then
                TextBox2.Text = TextBox2.Text & i
            Else
                TextBox2.Text = TextBox2.Text & " +" & i
            End If

            Else
            evensum = evensum = i
            If (TextBox3.Text = "") Then
                TextBox3.Text = TextBox3.Text & i
            Else
                TextBox3.Text = TextBox3.Text & " +" & i
            End If

        Next
        TextBox2.Text = TextBox2.Text & "=" & oddsum
        TextBox3.Text = TextBox3.Text & "=" & evensum

    End Sub


End Class