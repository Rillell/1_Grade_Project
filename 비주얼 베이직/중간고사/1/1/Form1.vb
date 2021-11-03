Public Class Form1
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Dim i, N, oddsum, Evensum As Integer

        N = TextBox1.Text
        TextBox2.Text = ""
        TextBox3.Text = ""
        For i = 1 To N Step 1
            If (i Mod 2 = 1) Then
                oddsum = oddsum + i
                If (TextBox2.Text = "") Then
                    TextBox2.Text = TextBox2.Text & i
                Else
                    TextBox2.Text = TextBox2.Text & " + " & i
                End If

            Else
                Evensum = Evensum + i
                If (TextBox3.Text = "") Then
                    TextBox3.Text = TextBox3.Text & i
                Else
                    TextBox3.Text = TextBox3.Text & " + " & i
                End If
            End If
        Next
        TextBox2.Text = TextBox2.Text & " = " & oddsum
        TextBox3.Text = TextBox3.Text & " = " & Evensum
    End Sub
End Class
