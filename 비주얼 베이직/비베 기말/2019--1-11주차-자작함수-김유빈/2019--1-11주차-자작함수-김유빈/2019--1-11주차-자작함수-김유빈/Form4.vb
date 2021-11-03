Public Class Form4
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Call ChangeSignal(1)
    End Sub
    Private Sub ChangeSignal(ByVal Color As Byte)
        Select Case Color
            Case 1
                PictureBox1.Image = Image.FromFile(CurDir() & "\다가오는 코끼리 두마리.1.jpg")
            Case 2
                PictureBox1.Image = Image.FromFile(CurDir() & "\다가오는 코끼리 두마리.2.jpg")
            Case 3
                PictureBox1.Image = Image.FromFile(CurDir() & "\다가오는 코끼리 두마리.3.jpg")
            Case 4
                PictureBox1.Image = Image.FromFile(CurDir() & "\다가오는 코끼리 두마리.4.jpg")

        End Select
    End Sub
    Dim Sinho_Color As Integer = 1

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        PictureBox1.Image = Image.FromFile(CurDir() & "\" & Sinho_Color & ".ico")
        Sinho_Color = Sinho_Color + 1

        If Sinho_Color > 4 Then
            Sinho_Color = 1
        End If
    End Sub
End Class