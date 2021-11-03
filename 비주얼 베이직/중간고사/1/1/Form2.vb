Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim N, i, Sum0, Sum1, Sum2 As Integer
        N = TextBox1.Text

        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""

        For i = 0 To N Step 1
            If (i Mod 3 = 0) Then
                Sum0 = Sum0 + i
                If (TextBox2.Text = "") Then
                    TextBox2.Text = TextBox2.Text & i
                Else
                    TextBox2.Text = TextBox2.Text & " + " & i
                End If
            ElseIf (i Mod 3 = 1) Then
                Sum1 = Sum1 + i
                If (TextBox3.Text = "") Then
                    TextBox3.Text = TextBox3.Text & i
                Else
                    TextBox3.Text = TextBox3.Text & " + " & i
                End If
            Else
                Sum2 = Sum2 + i
                If (TextBox4.Text = "") Then
                    TextBox4.Text = TextBox4.Text & i
                Else
                    TextBox4.Text = TextBox4.Text & " + " & i
                End If
            End If
        Next
        TextBox2.Text = TextBox2.Text & " = " & Sum0
        TextBox3.Text = TextBox3.Text & " = " & Sum1
        TextBox4.Text = TextBox4.Text & " = " & Sum2
    End Sub
End Class