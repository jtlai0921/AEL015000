﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.txtOpd2 = New System.Windows.Forms.TextBox()
        Me.txtOpd1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtOpd2
        '
        Me.txtOpd2.Location = New System.Drawing.Point(81, 47)
        Me.txtOpd2.Name = "txtOpd2"
        Me.txtOpd2.Size = New System.Drawing.Size(86, 22)
        Me.txtOpd2.TabIndex = 22
        Me.txtOpd2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtOpd1
        '
        Me.txtOpd1.Location = New System.Drawing.Point(81, 16)
        Me.txtOpd1.Name = "txtOpd1"
        Me.txtOpd1.Size = New System.Drawing.Size(86, 22)
        Me.txtOpd1.TabIndex = 21
        Me.txtOpd1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 12)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "運算元2:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 12)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "運算元1:"
        '
        'lblOutput
        '
        Me.lblOutput.BackColor = System.Drawing.SystemColors.ControlText
        Me.lblOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblOutput.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblOutput.ForeColor = System.Drawing.SystemColors.Control
        Me.lblOutput.Location = New System.Drawing.Point(173, 16)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(156, 50)
        Me.lblOutput.TabIndex = 23
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(14, 98)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 21)
        Me.Button1.TabIndex = 24
        Me.Button1.Text = "加法"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(95, 98)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 21)
        Me.Button2.TabIndex = 25
        Me.Button2.Text = "減法"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(175, 98)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 21)
        Me.Button3.TabIndex = 26
        Me.Button3.Text = "乘法"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(256, 98)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 21)
        Me.Button4.TabIndex = 27
        Me.Button4.Text = "除法"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(14, 124)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 21)
        Me.Button5.TabIndex = 28
        Me.Button5.Text = "餘數"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(95, 124)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(75, 21)
        Me.Button6.TabIndex = 29
        Me.Button6.Text = "指數"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(176, 124)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(106, 21)
        Me.Button7.TabIndex = 30
        Me.Button7.Text = "整數除法"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(344, 161)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblOutput)
        Me.Controls.Add(Me.txtOpd2)
        Me.Controls.Add(Me.txtOpd1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "算術計算機"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtOpd2 As System.Windows.Forms.TextBox
    Friend WithEvents txtOpd1 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblOutput As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button

End Class
