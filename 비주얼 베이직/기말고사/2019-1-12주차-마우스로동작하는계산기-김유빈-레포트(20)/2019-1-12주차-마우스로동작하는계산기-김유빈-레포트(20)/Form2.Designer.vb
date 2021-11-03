<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form은 Dispose를 재정의하여 구성 요소 목록을 정리합니다.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows Form 디자이너에 필요합니다.
    Private components As System.ComponentModel.IContainer

    '참고: 다음 프로시저는 Windows Form 디자이너에 필요합니다.
    '수정하려면 Windows Form 디자이너를 사용하십시오.  
    '코드 편집기에서는 수정하지 마세요.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.hsbTimer = New System.Windows.Forms.HScrollBar()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.파일ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.일반계산기ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.공학계산기ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.종료ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.보기ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.한학기를마치며ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.일반계산기사용법ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.일반계산기사용법ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.공학계산기사용법ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.도움말ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.개발환경ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.버전정보ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Button23 = New System.Windows.Forms.Button()
        Me.Button22 = New System.Windows.Forms.Button()
        Me.Button21 = New System.Windows.Forms.Button()
        Me.Button20 = New System.Windows.Forms.Button()
        Me.Button19 = New System.Windows.Forms.Button()
        Me.Button18 = New System.Windows.Forms.Button()
        Me.Button17 = New System.Windows.Forms.Button()
        Me.Button16 = New System.Windows.Forms.Button()
        Me.Button14 = New System.Windows.Forms.Button()
        Me.Button13 = New System.Windows.Forms.Button()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button15 = New System.Windows.Forms.Button()
        Me.Button24 = New System.Windows.Forms.Button()
        Me.Button25 = New System.Windows.Forms.Button()
        Me.Button26 = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'hsbTimer
        '
        Me.hsbTimer.Location = New System.Drawing.Point(365, 346)
        Me.hsbTimer.Maximum = 14
        Me.hsbTimer.Name = "hsbTimer"
        Me.hsbTimer.Size = New System.Drawing.Size(319, 62)
        Me.hsbTimer.TabIndex = 50
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("맑은 고딕", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label2.Location = New System.Drawing.Point(366, 280)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(319, 60)
        Me.Label2.TabIndex = 49
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("굴림", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label1.Location = New System.Drawing.Point(11, 421)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(310, 19)
        Me.Label1.TabIndex = 48
        Me.Label1.Text = "This Calculator made by K.Y.B"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("굴림", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(0, 27)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(696, 41)
        Me.TextBox1.TabIndex = 28
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.파일ToolStripMenuItem, Me.보기ToolStripMenuItem, Me.도움말ToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(699, 24)
        Me.MenuStrip1.TabIndex = 47
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        '파일ToolStripMenuItem
        '
        Me.파일ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.일반계산기ToolStripMenuItem, Me.공학계산기ToolStripMenuItem, Me.ToolStripMenuItem1, Me.종료ToolStripMenuItem})
        Me.파일ToolStripMenuItem.Name = "파일ToolStripMenuItem"
        Me.파일ToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.파일ToolStripMenuItem.Text = "파일"
        '
        '일반계산기ToolStripMenuItem
        '
        Me.일반계산기ToolStripMenuItem.Name = "일반계산기ToolStripMenuItem"
        Me.일반계산기ToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.일반계산기ToolStripMenuItem.Text = "일반 계산기"
        '
        '공학계산기ToolStripMenuItem
        '
        Me.공학계산기ToolStripMenuItem.Name = "공학계산기ToolStripMenuItem"
        Me.공학계산기ToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.공학계산기ToolStripMenuItem.Text = "공학 계산기"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(149, 6)
        '
        '종료ToolStripMenuItem
        '
        Me.종료ToolStripMenuItem.Name = "종료ToolStripMenuItem"
        Me.종료ToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.종료ToolStripMenuItem.Text = "종료"
        '
        '보기ToolStripMenuItem
        '
        Me.보기ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.한학기를마치며ToolStripMenuItem, Me.일반계산기사용법ToolStripMenuItem, Me.ToolStripMenuItem2, Me.일반계산기사용법ToolStripMenuItem1, Me.공학계산기사용법ToolStripMenuItem})
        Me.보기ToolStripMenuItem.Name = "보기ToolStripMenuItem"
        Me.보기ToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.보기ToolStripMenuItem.Text = "보기"
        '
        '한학기를마치며ToolStripMenuItem
        '
        Me.한학기를마치며ToolStripMenuItem.Name = "한학기를마치며ToolStripMenuItem"
        Me.한학기를마치며ToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.한학기를마치며ToolStripMenuItem.Text = "개발자 소개"
        '
        '일반계산기사용법ToolStripMenuItem
        '
        Me.일반계산기사용법ToolStripMenuItem.Name = "일반계산기사용법ToolStripMenuItem"
        Me.일반계산기사용법ToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.일반계산기사용법ToolStripMenuItem.Text = "하고픈 말"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(167, 6)
        '
        '일반계산기사용법ToolStripMenuItem1
        '
        Me.일반계산기사용법ToolStripMenuItem1.Name = "일반계산기사용법ToolStripMenuItem1"
        Me.일반계산기사용법ToolStripMenuItem1.Size = New System.Drawing.Size(170, 22)
        Me.일반계산기사용법ToolStripMenuItem1.Text = "일반계산기 사용법"
        '
        '공학계산기사용법ToolStripMenuItem
        '
        Me.공학계산기사용법ToolStripMenuItem.Name = "공학계산기사용법ToolStripMenuItem"
        Me.공학계산기사용법ToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.공학계산기사용법ToolStripMenuItem.Text = "공학계산기 사용법"
        '
        '도움말ToolStripMenuItem
        '
        Me.도움말ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.개발환경ToolStripMenuItem, Me.버전정보ToolStripMenuItem})
        Me.도움말ToolStripMenuItem.Name = "도움말ToolStripMenuItem"
        Me.도움말ToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.도움말ToolStripMenuItem.Text = "도움말"
        '
        '개발환경ToolStripMenuItem
        '
        Me.개발환경ToolStripMenuItem.Name = "개발환경ToolStripMenuItem"
        Me.개발환경ToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.개발환경ToolStripMenuItem.Text = "개발환경"
        '
        '버전정보ToolStripMenuItem
        '
        Me.버전정보ToolStripMenuItem.Name = "버전정보ToolStripMenuItem"
        Me.버전정보ToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.버전정보ToolStripMenuItem.Text = "버전 정보"
        '
        'Button23
        '
        Me.Button23.Font = New System.Drawing.Font("돋움", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Button23.Location = New System.Drawing.Point(257, 74)
        Me.Button23.Name = "Button23"
        Me.Button23.Size = New System.Drawing.Size(77, 62)
        Me.Button23.TabIndex = 68
        Me.Button23.Text = "+"
        Me.Button23.UseVisualStyleBackColor = True
        '
        'Button22
        '
        Me.Button22.Font = New System.Drawing.Font("돋움", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Button22.Location = New System.Drawing.Point(174, 74)
        Me.Button22.Name = "Button22"
        Me.Button22.Size = New System.Drawing.Size(77, 62)
        Me.Button22.TabIndex = 67
        Me.Button22.Text = "."
        Me.Button22.UseVisualStyleBackColor = True
        '
        'Button21
        '
        Me.Button21.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button21.Font = New System.Drawing.Font("돋움", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Button21.Location = New System.Drawing.Point(15, 346)
        Me.Button21.Name = "Button21"
        Me.Button21.Size = New System.Drawing.Size(153, 62)
        Me.Button21.TabIndex = 66
        Me.Button21.Text = "0"
        Me.Button21.UseVisualStyleBackColor = False
        '
        'Button20
        '
        Me.Button20.Font = New System.Drawing.Font("돋움", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Button20.Location = New System.Drawing.Point(174, 346)
        Me.Button20.Name = "Button20"
        Me.Button20.Size = New System.Drawing.Size(160, 62)
        Me.Button20.TabIndex = 65
        Me.Button20.Text = "="
        Me.Button20.UseVisualStyleBackColor = True
        '
        'Button19
        '
        Me.Button19.Font = New System.Drawing.Font("돋움", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Button19.Location = New System.Drawing.Point(257, 278)
        Me.Button19.Name = "Button19"
        Me.Button19.Size = New System.Drawing.Size(77, 62)
        Me.Button19.TabIndex = 64
        Me.Button19.Text = "-"
        Me.Button19.UseVisualStyleBackColor = True
        '
        'Button18
        '
        Me.Button18.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button18.Font = New System.Drawing.Font("돋움", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Button18.Location = New System.Drawing.Point(174, 278)
        Me.Button18.Name = "Button18"
        Me.Button18.Size = New System.Drawing.Size(77, 62)
        Me.Button18.TabIndex = 63
        Me.Button18.Text = "3"
        Me.Button18.UseVisualStyleBackColor = False
        '
        'Button17
        '
        Me.Button17.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button17.Font = New System.Drawing.Font("돋움", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Button17.Location = New System.Drawing.Point(95, 278)
        Me.Button17.Name = "Button17"
        Me.Button17.Size = New System.Drawing.Size(73, 62)
        Me.Button17.TabIndex = 62
        Me.Button17.Text = "2"
        Me.Button17.UseVisualStyleBackColor = False
        '
        'Button16
        '
        Me.Button16.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button16.Font = New System.Drawing.Font("돋움", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Button16.Location = New System.Drawing.Point(15, 278)
        Me.Button16.Name = "Button16"
        Me.Button16.Size = New System.Drawing.Size(74, 62)
        Me.Button16.TabIndex = 61
        Me.Button16.Text = "1"
        Me.Button16.UseVisualStyleBackColor = False
        '
        'Button14
        '
        Me.Button14.Font = New System.Drawing.Font("돋움", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Button14.Location = New System.Drawing.Point(257, 210)
        Me.Button14.Name = "Button14"
        Me.Button14.Size = New System.Drawing.Size(77, 62)
        Me.Button14.TabIndex = 60
        Me.Button14.Text = "X"
        Me.Button14.UseVisualStyleBackColor = True
        '
        'Button13
        '
        Me.Button13.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button13.Font = New System.Drawing.Font("돋움", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Button13.Location = New System.Drawing.Point(174, 210)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(77, 62)
        Me.Button13.TabIndex = 59
        Me.Button13.Text = "6"
        Me.Button13.UseVisualStyleBackColor = False
        '
        'Button12
        '
        Me.Button12.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button12.Font = New System.Drawing.Font("돋움", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Button12.Location = New System.Drawing.Point(95, 210)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(73, 62)
        Me.Button12.TabIndex = 58
        Me.Button12.Text = "5"
        Me.Button12.UseVisualStyleBackColor = False
        '
        'Button11
        '
        Me.Button11.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button11.Font = New System.Drawing.Font("돋움", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Button11.Location = New System.Drawing.Point(15, 210)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(74, 62)
        Me.Button11.TabIndex = 57
        Me.Button11.Text = "4"
        Me.Button11.UseVisualStyleBackColor = False
        '
        'Button9
        '
        Me.Button9.Font = New System.Drawing.Font("돋움", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Button9.Location = New System.Drawing.Point(257, 142)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(77, 62)
        Me.Button9.TabIndex = 56
        Me.Button9.Text = "÷"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button8.Font = New System.Drawing.Font("돋움", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Button8.Location = New System.Drawing.Point(174, 142)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(77, 62)
        Me.Button8.TabIndex = 55
        Me.Button8.Text = "9"
        Me.Button8.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button7.Font = New System.Drawing.Font("돋움", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Button7.Location = New System.Drawing.Point(95, 142)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(73, 62)
        Me.Button7.TabIndex = 54
        Me.Button7.Text = "8"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button6.Font = New System.Drawing.Font("돋움", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Button6.Location = New System.Drawing.Point(15, 142)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(74, 62)
        Me.Button6.TabIndex = 53
        Me.Button6.Text = "7"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("돋움", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Button2.Location = New System.Drawing.Point(95, 74)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(73, 62)
        Me.Button2.TabIndex = 52
        Me.Button2.Text = "C"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("돋움", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Button1.Location = New System.Drawing.Point(15, 74)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(74, 62)
        Me.Button1.TabIndex = 51
        Me.Button1.Text = "←"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("돋움", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Button3.Location = New System.Drawing.Point(365, 74)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(77, 62)
        Me.Button3.TabIndex = 69
        Me.Button3.Text = "sin"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("돋움", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Button4.Location = New System.Drawing.Point(365, 142)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(77, 62)
        Me.Button4.TabIndex = 70
        Me.Button4.Text = "cos"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("돋움", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Button5.Location = New System.Drawing.Point(365, 210)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(77, 62)
        Me.Button5.TabIndex = 71
        Me.Button5.Text = "tan"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button10
        '
        Me.Button10.Font = New System.Drawing.Font("돋움", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Button10.Location = New System.Drawing.Point(448, 74)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(77, 62)
        Me.Button10.TabIndex = 72
        Me.Button10.Text = "x^2"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'Button15
        '
        Me.Button15.Font = New System.Drawing.Font("돋움", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Button15.Location = New System.Drawing.Point(448, 142)
        Me.Button15.Name = "Button15"
        Me.Button15.Size = New System.Drawing.Size(77, 62)
        Me.Button15.TabIndex = 73
        Me.Button15.Text = "x^y"
        Me.Button15.UseVisualStyleBackColor = True
        '
        'Button24
        '
        Me.Button24.Font = New System.Drawing.Font("돋움", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Button24.Location = New System.Drawing.Point(448, 210)
        Me.Button24.Name = "Button24"
        Me.Button24.Size = New System.Drawing.Size(77, 62)
        Me.Button24.TabIndex = 74
        Me.Button24.Text = "x^3"
        Me.Button24.UseVisualStyleBackColor = True
        '
        'Button25
        '
        Me.Button25.Font = New System.Drawing.Font("돋움", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Button25.Location = New System.Drawing.Point(531, 74)
        Me.Button25.Name = "Button25"
        Me.Button25.Size = New System.Drawing.Size(77, 62)
        Me.Button25.TabIndex = 75
        Me.Button25.Text = "←"
        Me.Button25.UseVisualStyleBackColor = True
        '
        'Button26
        '
        Me.Button26.Font = New System.Drawing.Font("돋움", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Button26.Location = New System.Drawing.Point(531, 142)
        Me.Button26.Name = "Button26"
        Me.Button26.Size = New System.Drawing.Size(94, 62)
        Me.Button26.TabIndex = 76
        Me.Button26.Text = "Mod"
        Me.Button26.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(699, 445)
        Me.Controls.Add(Me.Button26)
        Me.Controls.Add(Me.Button25)
        Me.Controls.Add(Me.Button24)
        Me.Controls.Add(Me.Button15)
        Me.Controls.Add(Me.Button10)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button23)
        Me.Controls.Add(Me.Button22)
        Me.Controls.Add(Me.Button21)
        Me.Controls.Add(Me.Button20)
        Me.Controls.Add(Me.Button19)
        Me.Controls.Add(Me.Button18)
        Me.Controls.Add(Me.Button17)
        Me.Controls.Add(Me.Button16)
        Me.Controls.Add(Me.Button14)
        Me.Controls.Add(Me.Button13)
        Me.Controls.Add(Me.Button12)
        Me.Controls.Add(Me.Button11)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.hsbTimer)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "Form2"
        Me.Text = "공학계산기"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents hsbTimer As HScrollBar
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents 파일ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 일반계산기ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 공학계산기ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
    Friend WithEvents 종료ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 보기ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 한학기를마치며ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 일반계산기사용법ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripSeparator
    Friend WithEvents 일반계산기사용법ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents 공학계산기사용법ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 도움말ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 개발환경ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 버전정보ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Button23 As Button
    Friend WithEvents Button22 As Button
    Friend WithEvents Button21 As Button
    Friend WithEvents Button20 As Button
    Friend WithEvents Button19 As Button
    Friend WithEvents Button18 As Button
    Friend WithEvents Button17 As Button
    Friend WithEvents Button16 As Button
    Friend WithEvents Button14 As Button
    Friend WithEvents Button13 As Button
    Friend WithEvents Button12 As Button
    Friend WithEvents Button11 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button10 As Button
    Friend WithEvents Button15 As Button
    Friend WithEvents Button24 As Button
    Friend WithEvents Button25 As Button
    Friend WithEvents Button26 As Button
End Class
