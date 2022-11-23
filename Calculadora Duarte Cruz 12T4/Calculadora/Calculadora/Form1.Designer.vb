<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim bttIgual As System.Windows.Forms.Button
        Me.bttAdicao = New System.Windows.Forms.Button()
        Me.bttDivisao = New System.Windows.Forms.Button()
        Me.bttSubtracao = New System.Windows.Forms.Button()
        Me.bttMultiplicacao = New System.Windows.Forms.Button()
        Me.bttLimpar = New System.Windows.Forms.Button()
        Me.bttSair = New System.Windows.Forms.Button()
        Me.btt1 = New System.Windows.Forms.Button()
        Me.btt2 = New System.Windows.Forms.Button()
        Me.btt3 = New System.Windows.Forms.Button()
        Me.btt4 = New System.Windows.Forms.Button()
        Me.btt5 = New System.Windows.Forms.Button()
        Me.btt6 = New System.Windows.Forms.Button()
        Me.btt7 = New System.Windows.Forms.Button()
        Me.btt8 = New System.Windows.Forms.Button()
        Me.btt9 = New System.Windows.Forms.Button()
        Me.btt0 = New System.Windows.Forms.Button()
        Me.bttPonto = New System.Windows.Forms.Button()
        Me.bttPotencia = New System.Windows.Forms.Button()
        Me.lblResultado = New System.Windows.Forms.Label()
        Me.bttC = New System.Windows.Forms.Button()
        Me.bttRaiz = New System.Windows.Forms.Button()
        Me.bttMenu = New System.Windows.Forms.Button()
        Me.bttPi = New System.Windows.Forms.Button()
        Me.bttPotencia10 = New System.Windows.Forms.Button()
        Me.bttRad = New System.Windows.Forms.Button()
        Me.bttFResolvente = New System.Windows.Forms.Button()
        Me.txtX = New System.Windows.Forms.TextBox()
        Me.bttDeg = New System.Windows.Forms.Button()
        Me.bttMenu2 = New System.Windows.Forms.Button()
        Me.bttLog = New System.Windows.Forms.Button()
        Me.bttCr = New System.Windows.Forms.Button()
        Me.bttPr = New System.Windows.Forms.Button()
        Me.bttArredondar = New System.Windows.Forms.Button()
        Me.bttConversor = New System.Windows.Forms.Button()
        Me.bttFracaoreduzida = New System.Windows.Forms.Button()
        Me.bttDecFra = New System.Windows.Forms.Button()
        Me.bttOFF2 = New System.Windows.Forms.Button()
        Me.bttSenm1 = New System.Windows.Forms.Button()
        Me.bttCosm1 = New System.Windows.Forms.Button()
        Me.bttTanm1 = New System.Windows.Forms.Button()
        bttIgual = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'bttIgual
        '
        bttIgual.BackColor = System.Drawing.SystemColors.ActiveBorder
        bttIgual.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        bttIgual.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        bttIgual.Location = New System.Drawing.Point(646, 471)
        bttIgual.Name = "bttIgual"
        bttIgual.Size = New System.Drawing.Size(142, 123)
        bttIgual.TabIndex = 4
        bttIgual.Text = "="
        bttIgual.UseVisualStyleBackColor = False
        AddHandler bttIgual.Click, AddressOf Me.bttIgual_Click
        '
        'bttAdicao
        '
        Me.bttAdicao.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.bttAdicao.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.bttAdicao.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.bttAdicao.Location = New System.Drawing.Point(646, 232)
        Me.bttAdicao.Name = "bttAdicao"
        Me.bttAdicao.Size = New System.Drawing.Size(142, 123)
        Me.bttAdicao.TabIndex = 0
        Me.bttAdicao.Text = "+"
        Me.bttAdicao.UseVisualStyleBackColor = False
        '
        'bttDivisao
        '
        Me.bttDivisao.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.bttDivisao.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.bttDivisao.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.bttDivisao.Location = New System.Drawing.Point(646, 352)
        Me.bttDivisao.Name = "bttDivisao"
        Me.bttDivisao.Size = New System.Drawing.Size(142, 123)
        Me.bttDivisao.TabIndex = 1
        Me.bttDivisao.Text = "/"
        Me.bttDivisao.UseVisualStyleBackColor = False
        '
        'bttSubtracao
        '
        Me.bttSubtracao.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.bttSubtracao.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.bttSubtracao.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.bttSubtracao.Location = New System.Drawing.Point(507, 232)
        Me.bttSubtracao.Name = "bttSubtracao"
        Me.bttSubtracao.Size = New System.Drawing.Size(142, 123)
        Me.bttSubtracao.TabIndex = 2
        Me.bttSubtracao.Text = "-"
        Me.bttSubtracao.UseVisualStyleBackColor = False
        '
        'bttMultiplicacao
        '
        Me.bttMultiplicacao.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.bttMultiplicacao.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.bttMultiplicacao.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.bttMultiplicacao.Location = New System.Drawing.Point(507, 352)
        Me.bttMultiplicacao.Name = "bttMultiplicacao"
        Me.bttMultiplicacao.Size = New System.Drawing.Size(142, 123)
        Me.bttMultiplicacao.TabIndex = 3
        Me.bttMultiplicacao.Text = "X"
        Me.bttMultiplicacao.UseVisualStyleBackColor = False
        '
        'bttLimpar
        '
        Me.bttLimpar.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.bttLimpar.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.bttLimpar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.bttLimpar.Location = New System.Drawing.Point(646, 136)
        Me.bttLimpar.Name = "bttLimpar"
        Me.bttLimpar.Size = New System.Drawing.Size(142, 100)
        Me.bttLimpar.TabIndex = 5
        Me.bttLimpar.Text = "AC"
        Me.bttLimpar.UseVisualStyleBackColor = False
        '
        'bttSair
        '
        Me.bttSair.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.bttSair.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.bttSair.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.bttSair.Location = New System.Drawing.Point(508, 589)
        Me.bttSair.Name = "bttSair"
        Me.bttSair.Size = New System.Drawing.Size(280, 100)
        Me.bttSair.TabIndex = 6
        Me.bttSair.Text = "OFF"
        Me.bttSair.UseVisualStyleBackColor = False
        '
        'btt1
        '
        Me.btt1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btt1.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btt1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btt1.Location = New System.Drawing.Point(72, 255)
        Me.btt1.Name = "btt1"
        Me.btt1.Size = New System.Drawing.Size(99, 94)
        Me.btt1.TabIndex = 7
        Me.btt1.Text = "1"
        Me.btt1.UseVisualStyleBackColor = False
        '
        'btt2
        '
        Me.btt2.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btt2.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btt2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btt2.Location = New System.Drawing.Point(168, 255)
        Me.btt2.Name = "btt2"
        Me.btt2.Size = New System.Drawing.Size(99, 94)
        Me.btt2.TabIndex = 8
        Me.btt2.Text = "2"
        Me.btt2.UseVisualStyleBackColor = False
        '
        'btt3
        '
        Me.btt3.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btt3.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btt3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btt3.Location = New System.Drawing.Point(263, 255)
        Me.btt3.Name = "btt3"
        Me.btt3.Size = New System.Drawing.Size(99, 94)
        Me.btt3.TabIndex = 9
        Me.btt3.Text = "3"
        Me.btt3.UseVisualStyleBackColor = False
        '
        'btt4
        '
        Me.btt4.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btt4.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btt4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btt4.Location = New System.Drawing.Point(72, 343)
        Me.btt4.Name = "btt4"
        Me.btt4.Size = New System.Drawing.Size(99, 94)
        Me.btt4.TabIndex = 10
        Me.btt4.Text = "4"
        Me.btt4.UseVisualStyleBackColor = False
        '
        'btt5
        '
        Me.btt5.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btt5.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btt5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btt5.Location = New System.Drawing.Point(168, 343)
        Me.btt5.Name = "btt5"
        Me.btt5.Size = New System.Drawing.Size(99, 94)
        Me.btt5.TabIndex = 11
        Me.btt5.Text = "5"
        Me.btt5.UseVisualStyleBackColor = False
        '
        'btt6
        '
        Me.btt6.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btt6.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btt6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btt6.Location = New System.Drawing.Point(263, 343)
        Me.btt6.Name = "btt6"
        Me.btt6.Size = New System.Drawing.Size(99, 94)
        Me.btt6.TabIndex = 12
        Me.btt6.Text = "6"
        Me.btt6.UseVisualStyleBackColor = False
        '
        'btt7
        '
        Me.btt7.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btt7.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btt7.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btt7.Location = New System.Drawing.Point(72, 434)
        Me.btt7.Name = "btt7"
        Me.btt7.Size = New System.Drawing.Size(99, 94)
        Me.btt7.TabIndex = 13
        Me.btt7.Text = "7"
        Me.btt7.UseVisualStyleBackColor = False
        '
        'btt8
        '
        Me.btt8.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btt8.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btt8.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btt8.Location = New System.Drawing.Point(168, 434)
        Me.btt8.Name = "btt8"
        Me.btt8.Size = New System.Drawing.Size(99, 94)
        Me.btt8.TabIndex = 14
        Me.btt8.Text = "8"
        Me.btt8.UseVisualStyleBackColor = False
        '
        'btt9
        '
        Me.btt9.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btt9.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btt9.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btt9.Location = New System.Drawing.Point(263, 434)
        Me.btt9.Name = "btt9"
        Me.btt9.Size = New System.Drawing.Size(99, 94)
        Me.btt9.TabIndex = 15
        Me.btt9.Text = "9"
        Me.btt9.UseVisualStyleBackColor = False
        '
        'btt0
        '
        Me.btt0.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btt0.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btt0.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btt0.Location = New System.Drawing.Point(168, 524)
        Me.btt0.Name = "btt0"
        Me.btt0.Size = New System.Drawing.Size(99, 94)
        Me.btt0.TabIndex = 16
        Me.btt0.Text = "0"
        Me.btt0.UseVisualStyleBackColor = False
        '
        'bttPonto
        '
        Me.bttPonto.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.bttPonto.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.bttPonto.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.bttPonto.Location = New System.Drawing.Point(263, 524)
        Me.bttPonto.Name = "bttPonto"
        Me.bttPonto.Size = New System.Drawing.Size(99, 94)
        Me.bttPonto.TabIndex = 17
        Me.bttPonto.Text = "."
        Me.bttPonto.UseVisualStyleBackColor = False
        '
        'bttPotencia
        '
        Me.bttPotencia.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.bttPotencia.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.bttPotencia.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.bttPotencia.Location = New System.Drawing.Point(72, 524)
        Me.bttPotencia.Name = "bttPotencia"
        Me.bttPotencia.Size = New System.Drawing.Size(99, 94)
        Me.bttPotencia.TabIndex = 18
        Me.bttPotencia.Text = "^"
        Me.bttPotencia.UseVisualStyleBackColor = False
        '
        'lblResultado
        '
        Me.lblResultado.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblResultado.AutoEllipsis = True
        Me.lblResultado.BackColor = System.Drawing.Color.Azure
        Me.lblResultado.Font = New System.Drawing.Font("Segoe UI", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblResultado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblResultado.Location = New System.Drawing.Point(72, 136)
        Me.lblResultado.MaximumSize = New System.Drawing.Size(285, 72)
        Me.lblResultado.MinimumSize = New System.Drawing.Size(285, 72)
        Me.lblResultado.Name = "lblResultado"
        Me.lblResultado.Size = New System.Drawing.Size(285, 72)
        Me.lblResultado.TabIndex = 19
        Me.lblResultado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'bttC
        '
        Me.bttC.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.bttC.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.bttC.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.bttC.Location = New System.Drawing.Point(507, 136)
        Me.bttC.Name = "bttC"
        Me.bttC.Size = New System.Drawing.Size(142, 100)
        Me.bttC.TabIndex = 20
        Me.bttC.Text = "C"
        Me.bttC.UseVisualStyleBackColor = False
        '
        'bttRaiz
        '
        Me.bttRaiz.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.bttRaiz.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.bttRaiz.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.bttRaiz.Location = New System.Drawing.Point(507, 471)
        Me.bttRaiz.Name = "bttRaiz"
        Me.bttRaiz.Size = New System.Drawing.Size(142, 123)
        Me.bttRaiz.TabIndex = 22
        Me.bttRaiz.Text = "√"
        Me.bttRaiz.UseVisualStyleBackColor = False
        '
        'bttMenu
        '
        Me.bttMenu.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.bttMenu.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.bttMenu.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.bttMenu.Location = New System.Drawing.Point(507, 48)
        Me.bttMenu.Name = "bttMenu"
        Me.bttMenu.Size = New System.Drawing.Size(280, 90)
        Me.bttMenu.TabIndex = 23
        Me.bttMenu.Text = "MENU"
        Me.bttMenu.UseVisualStyleBackColor = False
        '
        'bttPi
        '
        Me.bttPi.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.bttPi.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.bttPi.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.bttPi.Location = New System.Drawing.Point(783, 471)
        Me.bttPi.Name = "bttPi"
        Me.bttPi.Size = New System.Drawing.Size(142, 123)
        Me.bttPi.TabIndex = 25
        Me.bttPi.Text = "π"
        Me.bttPi.UseVisualStyleBackColor = False
        Me.bttPi.Visible = False
        '
        'bttPotencia10
        '
        Me.bttPotencia10.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.bttPotencia10.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.bttPotencia10.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.bttPotencia10.Location = New System.Drawing.Point(919, 233)
        Me.bttPotencia10.Name = "bttPotencia10"
        Me.bttPotencia10.Size = New System.Drawing.Size(142, 123)
        Me.bttPotencia10.TabIndex = 26
        Me.bttPotencia10.Text = "x10"
        Me.bttPotencia10.UseVisualStyleBackColor = False
        Me.bttPotencia10.Visible = False
        '
        'bttRad
        '
        Me.bttRad.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.bttRad.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.bttRad.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.bttRad.Location = New System.Drawing.Point(1052, 352)
        Me.bttRad.Name = "bttRad"
        Me.bttRad.Size = New System.Drawing.Size(152, 123)
        Me.bttRad.TabIndex = 27
        Me.bttRad.Text = "RAD"
        Me.bttRad.UseVisualStyleBackColor = False
        Me.bttRad.Visible = False
        '
        'bttFResolvente
        '
        Me.bttFResolvente.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.bttFResolvente.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.bttFResolvente.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.bttFResolvente.Location = New System.Drawing.Point(1052, 136)
        Me.bttFResolvente.Name = "bttFResolvente"
        Me.bttFResolvente.Size = New System.Drawing.Size(152, 100)
        Me.bttFResolvente.TabIndex = 28
        Me.bttFResolvente.Text = "FÓRMULA RESOLVENTE"
        Me.bttFResolvente.UseVisualStyleBackColor = False
        Me.bttFResolvente.Visible = False
        '
        'txtX
        '
        Me.txtX.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.txtX.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtX.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtX.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtX.Location = New System.Drawing.Point(1005, 266)
        Me.txtX.Margin = New System.Windows.Forms.Padding(0)
        Me.txtX.Name = "txtX"
        Me.txtX.Size = New System.Drawing.Size(14, 25)
        Me.txtX.TabIndex = 29
        Me.txtX.Text = "e"
        Me.txtX.Visible = False
        '
        'bttDeg
        '
        Me.bttDeg.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.bttDeg.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.bttDeg.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.bttDeg.Location = New System.Drawing.Point(1052, 471)
        Me.bttDeg.Name = "bttDeg"
        Me.bttDeg.Size = New System.Drawing.Size(152, 123)
        Me.bttDeg.TabIndex = 30
        Me.bttDeg.Text = "DEG"
        Me.bttDeg.UseVisualStyleBackColor = False
        Me.bttDeg.Visible = False
        '
        'bttMenu2
        '
        Me.bttMenu2.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.bttMenu2.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.bttMenu2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.bttMenu2.Location = New System.Drawing.Point(508, 48)
        Me.bttMenu2.Name = "bttMenu2"
        Me.bttMenu2.Size = New System.Drawing.Size(844, 90)
        Me.bttMenu2.TabIndex = 31
        Me.bttMenu2.Text = "MENU"
        Me.bttMenu2.UseVisualStyleBackColor = False
        Me.bttMenu2.Visible = False
        '
        'bttLog
        '
        Me.bttLog.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.bttLog.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.bttLog.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.bttLog.Location = New System.Drawing.Point(919, 136)
        Me.bttLog.Name = "bttLog"
        Me.bttLog.Size = New System.Drawing.Size(142, 100)
        Me.bttLog.TabIndex = 32
        Me.bttLog.Text = "log"
        Me.bttLog.UseVisualStyleBackColor = False
        Me.bttLog.Visible = False
        '
        'bttCr
        '
        Me.bttCr.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.bttCr.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.bttCr.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.bttCr.Location = New System.Drawing.Point(919, 471)
        Me.bttCr.Name = "bttCr"
        Me.bttCr.Size = New System.Drawing.Size(142, 123)
        Me.bttCr.TabIndex = 34
        Me.bttCr.Text = "nCr"
        Me.bttCr.UseVisualStyleBackColor = False
        Me.bttCr.Visible = False
        '
        'bttPr
        '
        Me.bttPr.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.bttPr.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.bttPr.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.bttPr.Location = New System.Drawing.Point(919, 352)
        Me.bttPr.Name = "bttPr"
        Me.bttPr.Size = New System.Drawing.Size(142, 123)
        Me.bttPr.TabIndex = 35
        Me.bttPr.Text = "nPr"
        Me.bttPr.UseVisualStyleBackColor = False
        Me.bttPr.Visible = False
        '
        'bttArredondar
        '
        Me.bttArredondar.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.bttArredondar.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.bttArredondar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.bttArredondar.Location = New System.Drawing.Point(1052, 233)
        Me.bttArredondar.Name = "bttArredondar"
        Me.bttArredondar.Size = New System.Drawing.Size(152, 123)
        Me.bttArredondar.TabIndex = 36
        Me.bttArredondar.Text = "ARREDONDAR"
        Me.bttArredondar.UseVisualStyleBackColor = False
        Me.bttArredondar.Visible = False
        '
        'bttConversor
        '
        Me.bttConversor.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.bttConversor.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.bttConversor.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.bttConversor.Location = New System.Drawing.Point(1200, 234)
        Me.bttConversor.Name = "bttConversor"
        Me.bttConversor.Size = New System.Drawing.Size(152, 123)
        Me.bttConversor.TabIndex = 37
        Me.bttConversor.Text = "CONVERSOR"
        Me.bttConversor.UseVisualStyleBackColor = False
        Me.bttConversor.Visible = False
        '
        'bttFracaoreduzida
        '
        Me.bttFracaoreduzida.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.bttFracaoreduzida.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.bttFracaoreduzida.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.bttFracaoreduzida.Location = New System.Drawing.Point(1200, 352)
        Me.bttFracaoreduzida.Name = "bttFracaoreduzida"
        Me.bttFracaoreduzida.Size = New System.Drawing.Size(152, 123)
        Me.bttFracaoreduzida.TabIndex = 38
        Me.bttFracaoreduzida.Text = "FRAÇÃO REDUZIDA"
        Me.bttFracaoreduzida.UseVisualStyleBackColor = False
        Me.bttFracaoreduzida.Visible = False
        '
        'bttDecFra
        '
        Me.bttDecFra.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.bttDecFra.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.bttDecFra.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.bttDecFra.Location = New System.Drawing.Point(1200, 471)
        Me.bttDecFra.Name = "bttDecFra"
        Me.bttDecFra.Size = New System.Drawing.Size(152, 123)
        Me.bttDecFra.TabIndex = 39
        Me.bttDecFra.Text = "DEC <-> FRA"
        Me.bttDecFra.UseVisualStyleBackColor = False
        Me.bttDecFra.Visible = False
        '
        'bttOFF2
        '
        Me.bttOFF2.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.bttOFF2.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.bttOFF2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.bttOFF2.Location = New System.Drawing.Point(508, 589)
        Me.bttOFF2.Name = "bttOFF2"
        Me.bttOFF2.Size = New System.Drawing.Size(844, 100)
        Me.bttOFF2.TabIndex = 40
        Me.bttOFF2.Text = "OFF"
        Me.bttOFF2.UseVisualStyleBackColor = False
        Me.bttOFF2.Visible = False
        '
        'bttSenm1
        '
        Me.bttSenm1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.bttSenm1.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.bttSenm1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.bttSenm1.Location = New System.Drawing.Point(783, 136)
        Me.bttSenm1.Name = "bttSenm1"
        Me.bttSenm1.Size = New System.Drawing.Size(142, 100)
        Me.bttSenm1.TabIndex = 41
        Me.bttSenm1.Text = "sen-1"
        Me.bttSenm1.UseVisualStyleBackColor = False
        Me.bttSenm1.Visible = False
        '
        'bttCosm1
        '
        Me.bttCosm1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.bttCosm1.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.bttCosm1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.bttCosm1.Location = New System.Drawing.Point(783, 233)
        Me.bttCosm1.Name = "bttCosm1"
        Me.bttCosm1.Size = New System.Drawing.Size(142, 123)
        Me.bttCosm1.TabIndex = 42
        Me.bttCosm1.Text = "cos-1"
        Me.bttCosm1.UseVisualStyleBackColor = False
        Me.bttCosm1.Visible = False
        '
        'bttTanm1
        '
        Me.bttTanm1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.bttTanm1.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.bttTanm1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.bttTanm1.Location = New System.Drawing.Point(783, 352)
        Me.bttTanm1.Name = "bttTanm1"
        Me.bttTanm1.Size = New System.Drawing.Size(142, 123)
        Me.bttTanm1.TabIndex = 43
        Me.bttTanm1.Text = "tan-1"
        Me.bttTanm1.UseVisualStyleBackColor = False
        Me.bttTanm1.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1374, 701)
        Me.Controls.Add(Me.bttTanm1)
        Me.Controls.Add(Me.bttCosm1)
        Me.Controls.Add(Me.txtX)
        Me.Controls.Add(Me.bttOFF2)
        Me.Controls.Add(Me.bttDecFra)
        Me.Controls.Add(Me.bttFracaoreduzida)
        Me.Controls.Add(Me.bttConversor)
        Me.Controls.Add(Me.bttLog)
        Me.Controls.Add(Me.bttMenu2)
        Me.Controls.Add(Me.bttMenu)
        Me.Controls.Add(Me.bttSair)
        Me.Controls.Add(Me.bttRaiz)
        Me.Controls.Add(Me.bttC)
        Me.Controls.Add(Me.lblResultado)
        Me.Controls.Add(Me.bttPotencia)
        Me.Controls.Add(Me.bttPonto)
        Me.Controls.Add(Me.btt0)
        Me.Controls.Add(Me.btt9)
        Me.Controls.Add(Me.btt8)
        Me.Controls.Add(Me.btt7)
        Me.Controls.Add(Me.btt6)
        Me.Controls.Add(Me.btt5)
        Me.Controls.Add(Me.btt4)
        Me.Controls.Add(Me.btt3)
        Me.Controls.Add(Me.btt2)
        Me.Controls.Add(Me.btt1)
        Me.Controls.Add(Me.bttLimpar)
        Me.Controls.Add(bttIgual)
        Me.Controls.Add(Me.bttMultiplicacao)
        Me.Controls.Add(Me.bttSubtracao)
        Me.Controls.Add(Me.bttDivisao)
        Me.Controls.Add(Me.bttAdicao)
        Me.Controls.Add(Me.bttPr)
        Me.Controls.Add(Me.bttDeg)
        Me.Controls.Add(Me.bttRad)
        Me.Controls.Add(Me.bttPi)
        Me.Controls.Add(Me.bttFResolvente)
        Me.Controls.Add(Me.bttPotencia10)
        Me.Controls.Add(Me.bttArredondar)
        Me.Controls.Add(Me.bttSenm1)
        Me.Controls.Add(Me.bttCr)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents bttAdicao As Button
    Friend WithEvents bttDivisao As Button
    Friend WithEvents bttSubtracao As Button
    Friend WithEvents bttMultiplicacao As Button
    Friend WithEvents bttIgual As Button
    Friend WithEvents bttLimpar As Button
    Friend WithEvents bttSair As Button
    Friend WithEvents btt1 As Button
    Friend WithEvents btt2 As Button
    Friend WithEvents btt3 As Button
    Friend WithEvents btt4 As Button
    Friend WithEvents btt5 As Button
    Friend WithEvents btt6 As Button
    Friend WithEvents btt7 As Button
    Friend WithEvents btt8 As Button
    Friend WithEvents btt9 As Button
    Friend WithEvents btt0 As Button
    Friend WithEvents bttPonto As Button
    Friend WithEvents bttPotencia As Button
    Friend WithEvents lblResultado As Label
    Friend WithEvents bttC As Button
    Friend WithEvents bttRaiz As Button
    Friend WithEvents bttMenu As Button
    Friend WithEvents bttPi As Button
    Friend WithEvents bttPotencia10 As Button
    Friend WithEvents bttRad As Button
    Friend WithEvents bttFResolvente As Button
    Friend WithEvents txtX As TextBox
    Friend WithEvents bttDeg As Button
    Friend WithEvents bttMenu2 As Button
    Friend WithEvents bttLog As Button
    Friend WithEvents bttCr As Button
    Friend WithEvents bttPr As Button
    Friend WithEvents bttArredondar As Button
    Friend WithEvents bttConversor As Button
    Friend WithEvents bttFracaoreduzida As Button
    Friend WithEvents bttDecFra As Button
    Friend WithEvents bttOFF2 As Button
    Friend WithEvents bttSenm1 As Button
    Friend WithEvents bttCosm1 As Button
    Friend WithEvents bttTanm1 As Button
End Class
