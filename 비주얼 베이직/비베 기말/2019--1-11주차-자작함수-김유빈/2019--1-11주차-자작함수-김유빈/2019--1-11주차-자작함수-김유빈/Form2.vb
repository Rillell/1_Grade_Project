Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        PictureBox1.Image = Image.FromFile(CurDir() & "\blue.ico")

    End Sub

    Private Sub ChangeSignal(ByVal Color As Byte)
        Select Case Color
            Case 1
                PictureBox1.Image = Image.FromFile(CurDir() & "\red.ico")
            Case 2
                PictureBox1.Image = Image.FromFile(CurDir() & "\yellow.ico")
            Case 3
                PictureBox1.Image = Image.FromFile(CurDir() & "\blue.ico")
        End Select
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Call ChangeSignal(1) '빨강
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Call ChangeSignal(2) '노랑
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Call ChangeSignal(3) '녹색
    End Sub
End Class