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
        Me.mnuMain = New System.Windows.Forms.MenuStrip()
        Me.mnuItemFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuItemImage = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuItemSmall = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuItemSave = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuItemClear = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuItemMethod = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuItemLine = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuItemText = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuItemRectangle = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuItemEllipse = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuItemPen = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuItemRed = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuItemGreen = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuItemBlue = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuItemSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuItemSolid = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuItemTexture = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuItemFormat = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuItemNotFill = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnuMain
        '
        Me.mnuMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuItemFile, Me.mnuItemMethod, Me.mnuItemPen, Me.mnuItemFormat})
        Me.mnuMain.Location = New System.Drawing.Point(0, 0)
        Me.mnuMain.Name = "mnuMain"
        Me.mnuMain.Size = New System.Drawing.Size(334, 24)
        Me.mnuMain.TabIndex = 2
        Me.mnuMain.Text = "MenuStrip1"
        '
        'mnuItemFile
        '
        Me.mnuItemFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuItemImage, Me.mnuItemSmall, Me.ToolStripSeparator2, Me.mnuItemSave, Me.mnuItemClear})
        Me.mnuItemFile.Name = "mnuItemFile"
        Me.mnuItemFile.Size = New System.Drawing.Size(57, 20)
        Me.mnuItemFile.Text = "檔案(&F)"
        '
        'mnuItemImage
        '
        Me.mnuItemImage.Name = "mnuItemImage"
        Me.mnuItemImage.Size = New System.Drawing.Size(152, 22)
        Me.mnuItemImage.Text = "載入原始圖片"
        '
        'mnuItemSmall
        '
        Me.mnuItemSmall.Name = "mnuItemSmall"
        Me.mnuItemSmall.Size = New System.Drawing.Size(152, 22)
        Me.mnuItemSmall.Text = "載入縮小圖片"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(149, 6)
        '
        'mnuItemSave
        '
        Me.mnuItemSave.Name = "mnuItemSave"
        Me.mnuItemSave.Size = New System.Drawing.Size(152, 22)
        Me.mnuItemSave.Text = "儲存圖片"
        '
        'mnuItemClear
        '
        Me.mnuItemClear.Name = "mnuItemClear"
        Me.mnuItemClear.Size = New System.Drawing.Size(152, 22)
        Me.mnuItemClear.Text = "清除圖片"
        '
        'mnuItemMethod
        '
        Me.mnuItemMethod.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuItemLine, Me.mnuItemText, Me.mnuItemRectangle, Me.mnuItemEllipse})
        Me.mnuItemMethod.Name = "mnuItemMethod"
        Me.mnuItemMethod.Size = New System.Drawing.Size(87, 20)
        Me.mnuItemMethod.Text = "繪圖方法(&M)"
        '
        'mnuItemLine
        '
        Me.mnuItemLine.Checked = True
        Me.mnuItemLine.CheckState = System.Windows.Forms.CheckState.Checked
        Me.mnuItemLine.Name = "mnuItemLine"
        Me.mnuItemLine.Size = New System.Drawing.Size(134, 22)
        Me.mnuItemLine.Text = "畫線"
        '
        'mnuItemText
        '
        Me.mnuItemText.Name = "mnuItemText"
        Me.mnuItemText.Size = New System.Drawing.Size(134, 22)
        Me.mnuItemText.Text = "繪出文字"
        '
        'mnuItemRectangle
        '
        Me.mnuItemRectangle.Name = "mnuItemRectangle"
        Me.mnuItemRectangle.Size = New System.Drawing.Size(134, 22)
        Me.mnuItemRectangle.Text = "繪出長方形"
        '
        'mnuItemEllipse
        '
        Me.mnuItemEllipse.Name = "mnuItemEllipse"
        Me.mnuItemEllipse.Size = New System.Drawing.Size(134, 22)
        Me.mnuItemEllipse.Text = "繪出橢圓形"
        '
        'mnuItemPen
        '
        Me.mnuItemPen.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuItemRed, Me.mnuItemGreen, Me.mnuItemBlue, Me.mnuItemSeparator, Me.mnuItemSolid, Me.mnuItemTexture})
        Me.mnuItemPen.Name = "mnuItemPen"
        Me.mnuItemPen.Size = New System.Drawing.Size(87, 20)
        Me.mnuItemPen.Text = "畫筆/筆刷(&P)"
        '
        'mnuItemRed
        '
        Me.mnuItemRed.Checked = True
        Me.mnuItemRed.CheckState = System.Windows.Forms.CheckState.Checked
        Me.mnuItemRed.Name = "mnuItemRed"
        Me.mnuItemRed.Size = New System.Drawing.Size(122, 22)
        Me.mnuItemRed.Text = "紅色畫筆"
        '
        'mnuItemGreen
        '
        Me.mnuItemGreen.Name = "mnuItemGreen"
        Me.mnuItemGreen.Size = New System.Drawing.Size(122, 22)
        Me.mnuItemGreen.Text = "綠色畫筆"
        '
        'mnuItemBlue
        '
        Me.mnuItemBlue.Name = "mnuItemBlue"
        Me.mnuItemBlue.Size = New System.Drawing.Size(122, 22)
        Me.mnuItemBlue.Text = "藍色畫筆"
        '
        'mnuItemSeparator
        '
        Me.mnuItemSeparator.Name = "mnuItemSeparator"
        Me.mnuItemSeparator.Size = New System.Drawing.Size(119, 6)
        '
        'mnuItemSolid
        '
        Me.mnuItemSolid.Checked = True
        Me.mnuItemSolid.CheckState = System.Windows.Forms.CheckState.Checked
        Me.mnuItemSolid.Name = "mnuItemSolid"
        Me.mnuItemSolid.Size = New System.Drawing.Size(122, 22)
        Me.mnuItemSolid.Text = "色彩筆刷"
        '
        'mnuItemTexture
        '
        Me.mnuItemTexture.Name = "mnuItemTexture"
        Me.mnuItemTexture.Size = New System.Drawing.Size(122, 22)
        Me.mnuItemTexture.Text = "圖片筆刷"
        '
        'mnuItemFormat
        '
        Me.mnuItemFormat.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuItemNotFill})
        Me.mnuItemFormat.Name = "mnuItemFormat"
        Me.mnuItemFormat.Size = New System.Drawing.Size(57, 20)
        Me.mnuItemFormat.Text = "樣式(&F)"
        '
        'mnuItemNotFill
        '
        Me.mnuItemNotFill.Checked = True
        Me.mnuItemNotFill.CheckState = System.Windows.Forms.CheckState.Checked
        Me.mnuItemNotFill.Name = "mnuItemNotFill"
        Me.mnuItemNotFill.Size = New System.Drawing.Size(110, 22)
        Me.mnuItemNotFill.Text = "不填滿"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(334, 211)
        Me.Controls.Add(Me.mnuMain)
        Me.Name = "Form1"
        Me.Text = "我的小畫家"
        Me.mnuMain.ResumeLayout(False)
        Me.mnuMain.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mnuMain As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuItemPen As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuItemRed As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuItemGreen As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuItemBlue As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuItemSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuItemSolid As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuItemTexture As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuItemMethod As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuItemLine As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuItemText As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuItemRectangle As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuItemEllipse As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuItemFormat As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuItemNotFill As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuItemFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuItemImage As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuItemSmall As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuItemSave As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuItemClear As System.Windows.Forms.ToolStripMenuItem

End Class
