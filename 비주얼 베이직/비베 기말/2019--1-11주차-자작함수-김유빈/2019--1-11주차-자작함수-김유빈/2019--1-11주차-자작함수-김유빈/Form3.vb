Public Class Form3
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '    Call ChangeSignal(2) '노랑
    End Sub
    Private Sub ChangeSignal(ByVal Color As Byte)
        Select Case Color
            Case 1
                PictureBox1.Image = Image.FromFile(CurDir() & "\blue.ico")
            Case 2
                PictureBox1.Image = Image.FromFile(CurDir() & "\yellow.ico")
            Case 3
                PictureBox1.Image = Image.FromFile(CurDir() & "\red.ico")
            Case 4
                PictureBox1.Image = Image.FromFile(CurDir() & "\yellow.ico")

        End Select
    End Sub
    Dim Sinho_Color As Integer = 1
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim Sinho_Color As Integer = 1
        PictureBox1.Image = Image.FromFile(CurDir() & "\" & Sinho_Color & ".ico")
        Sinho_Color = Sinho_Color + 1

        If Sinho_Color > 4 Then
            Sinho_Color = 1
        End If
        'Call ChangeSignal(Sinho_Color)



        'If Sinho_Color > 4 Then
        '    Sinho_Color = 1
        'End If
    End Sub
End Class