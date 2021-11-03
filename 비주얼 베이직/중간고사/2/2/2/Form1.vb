Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        For i = 1 To 9 Step 3
            For j = 1 To 9
                TextBox1.Text = TextBox1.Text & i & " X " & j & " = " & (i * j) & vbTab
                TextBox1.Text = TextBox1.Text & (i + 1) & " X " & j & " = " & ((i + 1) * j) & vbTab
                TextBox1.Text = TextBox1.Text & (i + 2) & " X " & j & " = " & ((i + 2) * j) & vbCrLf

            Next
            TextBox1.Text = TextBox1.Text & vbCrLf
        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim dN, dSum As Double

        dN = TextBox1.Text
        TextBox1.Text = ""
        textbox2.text = ""

        For j = dN To 1 Step -1
            dSum = dSum + j
            If j = 1 Then
                textbox2.text = textbox2.text & j & " = "
            Else
                textbox2.text = textbox2.text & j & " + "
            End If
        Next
        textbox2.text = text2.text & dSum
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        For i = 2 To 9 Step 4
            For j = 1 To 9
                For k = 0 To 3
                    TextBox1.Text = TextBox1.Text & (i + k) & " X " & j & " = " & (i * j)
                Next
                TextBox1.Text = TextBox1.Text & vbCrLf
            Next
            TextBox1.Text = TextBox1.Text & vbCrLf
        Next
    End Sub
End Class




