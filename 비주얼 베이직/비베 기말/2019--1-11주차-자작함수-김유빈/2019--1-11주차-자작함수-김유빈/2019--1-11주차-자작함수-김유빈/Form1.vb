Public Class Form1

    Private m_iPosition, m_ilnc As Integer '시계수의 방향과 위치'

    Private Sub tmrTimer_Tick(sender As Object, e As EventArgs) Handles tmrTimer.Tick

        Label1.Text = Now() '현재 날짜와 시각 표시

        If m_iPosition = 5 Then m_ilnc = -1
        If m_iPosition = 0 Then m_ilnc = 1

        '시계추 이동
        m_iPosition = m_iPosition + m_ilnc
        hsbTimer.Value = m_iPosition
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        m_ilnc = 1 '시계추의 방향'
        m_iPosition = 0 '시계추의 위치값'
    End Sub
End Class
