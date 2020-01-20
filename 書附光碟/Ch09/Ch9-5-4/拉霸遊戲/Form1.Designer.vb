<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
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

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請不要使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblOriginal = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lblSlot3 = New System.Windows.Forms.Label()
        Me.lblSlot2 = New System.Windows.Forms.Label()
        Me.lblSlot1 = New System.Windows.Forms.Label()
        Me.lblBet = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblMoney = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoEllipsis = True
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("新細明體", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Label4.Location = New System.Drawing.Point(15, 181)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(120, 21)
        Me.Label4.TabIndex = 41
        Me.Label4.Text = "拉霸前金額:"
        '
        'lblOriginal
        '
        Me.lblOriginal.BackColor = System.Drawing.SystemColors.ControlText
        Me.lblOriginal.Font = New System.Drawing.Font("微軟正黑體", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblOriginal.ForeColor = System.Drawing.Color.Lime
        Me.lblOriginal.Location = New System.Drawing.Point(141, 164)
        Me.lblOriginal.Name = "lblOriginal"
        Me.lblOriginal.Size = New System.Drawing.Size(133, 40)
        Me.lblOriginal.TabIndex = 40
        Me.lblOriginal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoEllipsis = True
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Label2.Location = New System.Drawing.Point(313, 113)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 16)
        Me.Label2.TabIndex = 38
        Me.Label2.Text = "押注控制"
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("新細明體", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(357, 132)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(52, 30)
        Me.Button2.TabIndex = 36
        Me.Button2.Text = "-"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("新細明體", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(289, 132)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(52, 30)
        Me.Button1.TabIndex = 35
        Me.Button1.Text = "+"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lblSlot3
        '
        Me.lblSlot3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblSlot3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSlot3.Font = New System.Drawing.Font("微軟正黑體", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSlot3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblSlot3.Location = New System.Drawing.Point(189, 61)
        Me.lblSlot3.Name = "lblSlot3"
        Me.lblSlot3.Size = New System.Drawing.Size(71, 83)
        Me.lblSlot3.TabIndex = 34
        Me.lblSlot3.Text = "0"
        Me.lblSlot3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSlot2
        '
        Me.lblSlot2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblSlot2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSlot2.Font = New System.Drawing.Font("微軟正黑體", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSlot2.ForeColor = System.Drawing.Color.Green
        Me.lblSlot2.Location = New System.Drawing.Point(108, 61)
        Me.lblSlot2.Name = "lblSlot2"
        Me.lblSlot2.Size = New System.Drawing.Size(75, 83)
        Me.lblSlot2.TabIndex = 33
        Me.lblSlot2.Text = "0"
        Me.lblSlot2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSlot1
        '
        Me.lblSlot1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblSlot1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSlot1.Font = New System.Drawing.Font("微軟正黑體", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSlot1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblSlot1.Location = New System.Drawing.Point(27, 61)
        Me.lblSlot1.Name = "lblSlot1"
        Me.lblSlot1.Size = New System.Drawing.Size(75, 83)
        Me.lblSlot1.TabIndex = 32
        Me.lblSlot1.Text = "0"
        Me.lblSlot1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblBet
        '
        Me.lblBet.BackColor = System.Drawing.SystemColors.ControlText
        Me.lblBet.Font = New System.Drawing.Font("微軟正黑體", 32.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblBet.ForeColor = System.Drawing.Color.Cyan
        Me.lblBet.Location = New System.Drawing.Point(289, 46)
        Me.lblBet.Name = "lblBet"
        Me.lblBet.Size = New System.Drawing.Size(120, 59)
        Me.lblBet.TabIndex = 30
        Me.lblBet.Text = "100"
        Me.lblBet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("新細明體", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(289, 170)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(120, 98)
        Me.Button3.TabIndex = 26
        Me.Button3.Text = "啟動轉輪"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(15, 50)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(259, 106)
        Me.Label3.TabIndex = 43
        Me.Label3.Text = "Label3"
        '
        'Label1
        '
        Me.Label1.AutoEllipsis = True
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("新細明體", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Label1.Location = New System.Drawing.Point(285, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 21)
        Me.Label1.TabIndex = 48
        Me.Label1.Text = "押注金額"
        '
        'lblResult
        '
        Me.lblResult.BackColor = System.Drawing.Color.Black
        Me.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblResult.Font = New System.Drawing.Font("新細明體", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblResult.ForeColor = System.Drawing.Color.White
        Me.lblResult.Location = New System.Drawing.Point(17, 9)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(257, 34)
        Me.lblResult.TabIndex = 51
        Me.lblResult.Text = "== 拉霸遊戲 =="
        Me.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AutoEllipsis = True
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("新細明體", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Label5.Location = New System.Drawing.Point(15, 240)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(120, 21)
        Me.Label5.TabIndex = 53
        Me.Label5.Text = "拉霸後金額:"
        '
        'lblMoney
        '
        Me.lblMoney.BackColor = System.Drawing.SystemColors.ControlText
        Me.lblMoney.Font = New System.Drawing.Font("微軟正黑體", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblMoney.ForeColor = System.Drawing.Color.Lime
        Me.lblMoney.Location = New System.Drawing.Point(140, 219)
        Me.lblMoney.Name = "lblMoney"
        Me.lblMoney.Size = New System.Drawing.Size(134, 48)
        Me.lblMoney.TabIndex = 52
        Me.lblMoney.Text = "1000"
        Me.lblMoney.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(424, 281)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblMoney)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblOriginal)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblSlot3)
        Me.Controls.Add(Me.lblSlot2)
        Me.Controls.Add(Me.lblSlot1)
        Me.Controls.Add(Me.lblBet)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label3)
        Me.Name = "Form1"
        Me.Text = "拉霸遊戲"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblOriginal As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents lblSlot3 As System.Windows.Forms.Label
    Friend WithEvents lblSlot2 As System.Windows.Forms.Label
    Friend WithEvents lblSlot1 As System.Windows.Forms.Label
    Friend WithEvents lblBet As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblResult As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblMoney As System.Windows.Forms.Label

End Class
