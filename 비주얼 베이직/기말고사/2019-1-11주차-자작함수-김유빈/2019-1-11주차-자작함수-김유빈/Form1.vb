Public Class Form1
    Dim Sinho_Color_1 As Integer = 1
    Dim Sinho_Color_2 As Integer = 1
    Dim Sinho_Color_3 As Integer = 1
    Dim Sinho_Color_1_Max As Integer = 5
    Dim Sinho_Color_2_Max As Integer = 6
    Dim Sinho_Color_3_Max As Integer = 4

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        PictureBox1.Image = Image.FromFile(CurDir() & "\다가오는 코끼리 두마리\" & Sinho_Color_1 & ".jpg")
        PictureBox2.Image = Image.FromFile(CurDir() & "\돌아서는 오버액션토끼\" & Sinho_Color_2 & ".jpg")
        PictureBox3.Image = Image.FromFile(CurDir() & "\엄마에게 다가가는 새끼 코끼리\" & Sinho_Color_3 & ".jpg")

        Sinho_Color_1 = Sinho_Color_1 + 1
        Sinho_Color_2 = Sinho_Color_2 + 1
        Sinho_Color_3 = Sinho_Color_3 + 1

        If Sinho_Color_1 > 5 Then
            Sinho_Color_1 = 1
        End If
        If Sinho_Color_2 > 6 Then
            Sinho_Color_2 = 1
        End If
        If Sinho_Color_3 > 4 Then
            Sinho_Color_3 = 1
        End If
    End Sub
End Class
