Public Class Form2
    Private Sub 공학계산기ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 공학계산기ToolStripMenuItem.Click
        '공학계산기에서 공학계산기를 눌러봐야 아무것도 없음
    End Sub

    Private Sub 일반계산기ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 일반계산기ToolStripMenuItem.Click
        '공학계산기에서 일반계산기를 눌렀을때
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        공학계산기ToolStripMenuItem.Checked = True
        일반계산기ToolStripMenuItem.Checked = False
    End Sub

    Private Sub 종료ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 종료ToolStripMenuItem.Click
        End
    End Sub

    Private Sub Button26_Click(sender As Object, e As EventArgs) Handles Button26.Click
        'Mod 버튼

    End Sub
End Class