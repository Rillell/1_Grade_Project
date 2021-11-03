﻿Public Class Form1
    Dim Jjeom_Flag As Boolean = False    'true:점찍혀있음, false:안찍혀있음
    Dim Sutja As Double
    Dim Yousanja As String = ""
    Dim Clear_Flag As Boolean = False 'True:지우고 숫자표시, False:그냥 숫자표시
    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If Clear_Flag = True Then
            TextBox1.Text = ""
            Clear_Flag = False

        End If
        TextBox1.Text = TextBox1.Text & "9"
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If Clear_Flag = True Then
            TextBox1.Text = ""
            Clear_Flag = False
        End If
        TextBox1.Text = TextBox1.Text & "8"
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If Clear_Flag = True Then
            TextBox1.Text = ""
            Clear_Flag = False
        End If
        TextBox1.Text = TextBox1.Text & "7"
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        If Clear_Flag = True Then
            TextBox1.Text = ""
            Clear_Flag = False
        End If
        TextBox1.Text = TextBox1.Text & "6"
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        If Clear_Flag = True Then
            TextBox1.Text = ""
            Clear_Flag = False
        End If
        TextBox1.Text = TextBox1.Text & "5"
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        If Clear_Flag = True Then
            TextBox1.Text = ""
            Clear_Flag = False
        End If
        TextBox1.Text = TextBox1.Text & "4"
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        If Clear_Flag = True Then
            TextBox1.Text = ""
            Clear_Flag = False
        End If
        TextBox1.Text = TextBox1.Text & "3"
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        If Clear_Flag = True Then
            TextBox1.Text = ""
            Clear_Flag = False
        End If
        TextBox1.Text = TextBox1.Text & "2"
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        If Clear_Flag = True Then
            TextBox1.Text = ""
            Clear_Flag = False
        End If
        TextBox1.Text = TextBox1.Text & "1"
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        If TextBox1.Text <> "" Then
            TextBox1.Text = TextBox1.Text & "0"
        End If
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        If Clear_Flag = True Then
            TextBox1.Text = ""
            Clear_Flag = False
        End If

        If Jjeom_Flag = False Then
            If TextBox1.Text = "" Then
                TextBox1.Text = "0"
            End If

            TextBox1.Text = TextBox1.Text & "."
            Jjeom_Flag = True
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'C버튼을 눌렀을때

        TextBox1.Text = ""
        Clear_Flag = False
        Jjeom_Flag = False
        Sutja = 0
        Yousanja = ""

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        '←
        If TextBox1.Text <> "" Then
            If Microsoft.VisualBasic.Right(TextBox1.Text, 1) = "." Then
                Jjeom_Flag = False
            End If
            TextBox1.Text = Microsoft.VisualBasic.Left(TextBox1.Text, TextBox1.TextLength - 1)
        End If
        If TextBox1.Text = "0" Then
            TextBox1.Text = ""
        End If
    End Sub

    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click
        '+ 버튼을 눌렀을때
        If TextBox1.Text = "" Then
            Exit Sub
        End If

        If Yousanja = "" Then

        Else
            Call Operation()
        End If

        Sutja = TextBox1.Text
        Yousanja = "+"
        Clear_Flag = True
        Jjeom_Flag = False
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        '- 버튼을 눌렀을때
        If TextBox1.Text = "" Then
            Exit Sub
        End If

        If Yousanja = "" Then

        Else
            Call Operation()
        End If

        Sutja = TextBox1.Text
        Yousanja = "-"
        Clear_Flag = True
        Jjeom_Flag = False
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        'X 버튼을 눌렀을때
        If TextBox1.Text = "" Then
            Exit Sub
        End If

        If Yousanja = "" Then

        Else
            Call Operation()
        End If

        Sutja = TextBox1.Text
        Yousanja = "X"
        Clear_Flag = True
        Jjeom_Flag = False
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        '÷ 버튼을 눌렀을때
        If TextBox1.Text = "" Then
            Exit Sub
        End If

        If Yousanja = "" Then

        Else
            Call Operation()
        End If

        Sutja = TextBox1.Text
        Yousanja = "÷"
        Clear_Flag = True
        Jjeom_Flag = False
    End Sub

    Private Sub Operation() '자작함수
        If Yousanja = "+" Then
            TextBox1.Text = Sutja + TextBox1.Text
        ElseIf Yousanja = "-" Then
            TextBox1.Text = Sutja - TextBox1.Text
        ElseIf Yousanja = "X" Then
            TextBox1.Text = Sutja * TextBox1.Text
        ElseIf Yousanja = "÷" Then
            TextBox1.Text = Sutja / TextBox1.Text
        ElseIf Yousanja = "Mod" Then
            TextBox1.Text = Sutja Mod TextBox1.Text
        End If
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        '=을 눌렀을때
        Call Operation()
        Jjeom_Flag = False    'true:점찍혀있음, false:안찍혀있음
        Sutja = 0
        Yousanja = ""
        Clear_Flag = True

    End Sub
    Private m_iPosition, m_ilnc As Integer

    Private Sub 공학계산기ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 공학계산기ToolStripMenuItem.Click
        '일반계산기에서 공학용 계산기 메뉴를 선택했을때
        Dim objFrmSub As Form2 = New Form2()
        objFrmSub.Show()
        Me.Hide()
    End Sub

    Private Sub 일반계산기ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 일반계산기ToolStripMenuItem.Click
        '일반계산기에서 일반계산기 메뉴를 선택했을때
        '따라서 아무것도 해줄것이 없음
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        일반계산기ToolStripMenuItem.Checked = True
        공학계산기ToolStripMenuItem.Checked = False
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        '1/x 역수 취하는 버튼
        TextBox1.Text = 1 / TextBox1.Text
        Sutja = 0
        Yousanja = ""
        Clear_Flag = True
        Jjeom_Flag = False

    End Sub

    Private Sub 종료ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 종료ToolStripMenuItem.Click
        End
    End Sub

    Private Sub 한학기를마치며ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 한학기를마치며ToolStripMenuItem.Click
        Dim objFrmSub As Form3 = New Form3()
        objFrmSub.Show()
        Me.Hide()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        'Mod 버튼을 눌렀을때
        If TextBox1.Text = "" Then
            Exit Sub
        End If

        If Yousanja = "" Then

        Else
            Call Operation()
        End If

        Sutja = TextBox1.Text
        Yousanja = "Mod"
        Clear_Flag = True
        Jjeom_Flag = False
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'sin 버튼
        TextBox1.Text = Math.Sin(TextBox1.Text)
        Sutja = 0
        Yousanja = ""
        Clear_Flag = True
        Jjeom_Flag = False
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        'π 버튼을 눌렀을때
        TextBox1.Text = Math.PI
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label2.Text = Now() '현재 날짜와 시각 표시

        If m_iPosition = 5 Then m_ilnc = -1
        If m_iPosition = 0 Then m_ilnc = 1

        '시계추 이동
        m_iPosition = m_iPosition + m_ilnc
        hsbTimer.Value = m_iPosition
    End Sub
End Class
