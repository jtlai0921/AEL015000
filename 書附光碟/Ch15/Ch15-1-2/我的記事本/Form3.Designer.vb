﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ptbOutput = New System.Windows.Forms.PictureBox()
        CType(Me.ptbOutput, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(17, 128)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(251, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "啟動"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ptbOutput
        '
        Me.ptbOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ptbOutput.Location = New System.Drawing.Point(17, 9)
        Me.ptbOutput.Name = "ptbOutput"
        Me.ptbOutput.Size = New System.Drawing.Size(251, 113)
        Me.ptbOutput.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.ptbOutput.TabIndex = 2
        Me.ptbOutput.TabStop = False
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 161)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ptbOutput)
        Me.Name = "Form3"
        Me.Text = "啟動"
        CType(Me.ptbOutput, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ptbOutput As System.Windows.Forms.PictureBox
End Class
