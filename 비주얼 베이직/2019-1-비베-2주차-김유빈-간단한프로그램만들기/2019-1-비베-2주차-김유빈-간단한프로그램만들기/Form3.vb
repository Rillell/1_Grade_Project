Public Class Form3
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim N, Sum As Integer

        N = TextBox1.Text

        TextBox2.Text = ""

        For i = 1 To N Step 1

            Sum = Sum + i

            If (i <> N) Then
                TextBox2.Text = TextBox2.Text & i & "+"
            Else
                TextBox2.Text = TextBox2.Text & i & "="
            End If

        Next

        TextBox2.Text = TextBox2.Text & Sum



    End Sub
End Class