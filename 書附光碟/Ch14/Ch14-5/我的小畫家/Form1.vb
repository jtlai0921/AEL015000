Public Class Form1

    Dim buffer As Bitmap
    Dim x, y As Integer
    Dim g As Graphics
    Dim pen As Pen
    Dim brush1 As SolidBrush
    Dim brush2 As TextureBrush

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        pen = New Pen(Color.Red, 1)
        brush1 = New SolidBrush(Color.Blue)
        brush2 = New TextureBrush(New Bitmap("\VB2012\Ch14\back.bmp"))
        g = Me.CreateGraphics()
        ' 建立緩衝區的Bitmap物件
        buffer = New Bitmap(Me.ClientSize.Width, Me.ClientSize.Height)
    End Sub

    Private Sub Form1_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        ' 準備繪出直線, 長方形和橢圓形
        If mnuItemLine.Checked Or mnuItemRectangle.Checked Or mnuItemEllipse.Checked Then
            x = e.X : y = e.Y  ' 指定開始座標
        End If
        If mnuItemText.Checked Then  ' 繪出文字內容
            Dim font As Font = New Font("標楷體", 14)
            Dim str As String = "Visual Basic程式設計"
            ' 繪在Buttfer
            Dim g1 As Graphics = Graphics.FromImage(buffer)
            If mnuItemSolid.Checked Then
                g1.DrawString(str, font, brush1, e.X, e.Y)
            Else
                g1.DrawString(str, font, brush2, e.X, e.Y)
            End If
            Me.Refresh()  ' 重繪
        End If
    End Sub

    Private Sub Form1_MouseUp(sender As Object, e As MouseEventArgs) Handles Me.MouseUp
        If mnuItemRectangle.Checked Then ' 繪出長方形
            Dim g1 As Graphics = Graphics.FromImage(buffer)
            If mnuItemNotFill.Checked Then
                g1.DrawRectangle(pen, x, y, e.X - x, e.Y - y)
            Else
                If mnuItemSolid.Checked Then
                    g1.FillRectangle(brush1, x, y, e.X - x, e.Y - y)
                Else
                    g1.FillRectangle(brush2, x, y, e.X - x, e.Y - y)
                End If
            End If
            Me.Refresh()  ' 重繪
        End If
        If mnuItemEllipse.Checked Then   ' 繪出橢圓形
            Dim g1 As Graphics = Graphics.FromImage(buffer)
            If mnuItemNotFill.Checked Then
                g1.DrawEllipse(pen, x, y, e.X - x, e.Y - y)
            Else
                If mnuItemSolid.Checked Then
                    g1.FillEllipse(brush1, x, y, e.X - x, e.Y - y)
                Else
                    g1.FillEllipse(brush2, x, y, e.X - x, e.Y - y)
                End If
            End If
            Me.Refresh()  ' 重繪
        End If
    End Sub

    Private Sub mnuItemNotFill_Click(sender As Object, e As EventArgs) Handles mnuItemNotFill.Click
        If mnuItemNotFill.Checked Then
            mnuItemNotFill.Checked = False
        Else
            mnuItemNotFill.Checked = True
        End If
    End Sub

    Private Sub Form1_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        If e.Button = MouseButtons.Left And mnuItemLine.Checked Then
            pen.Width = 2
            ' 畫線在Buffer
            Dim g1 As Graphics = Graphics.FromImage(buffer)
            g1.DrawLine(pen, x, y, e.X, e.Y)
            ' 繪在畫布
            g.DrawLine(pen, x, y, e.X, e.Y)
            x = e.X
            y = e.Y
        End If
    End Sub

    Private Sub Form1_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        g.Clear(Color.White)
        g.DrawImage(buffer, 0, 0)  ' 重繪Bitmap物件
    End Sub

    Private Sub mnuItemLine_Click(sender As Object, e As EventArgs) Handles mnuItemLine.Click
        mnuItemLine.Checked = True
        mnuItemText.Checked = False
    End Sub

    Private Sub mnuItemText_Click(sender As Object, e As EventArgs) Handles mnuItemText.Click
        mnuItemLine.Checked = False
        mnuItemText.Checked = True
    End Sub

    Private Sub mnuItemRed_Click(sender As Object, e As EventArgs) Handles mnuItemRed.Click
        mnuItemRed.Checked = True
        mnuItemBlue.Checked = False
        mnuItemGreen.Checked = False
        pen.Color = Color.Red
    End Sub

    Private Sub mnuItemGreen_Click(sender As Object, e As EventArgs) Handles mnuItemGreen.Click
        mnuItemRed.Checked = False
        mnuItemBlue.Checked = False
        mnuItemGreen.Checked = True
        pen.Color = Color.Green
    End Sub

    Private Sub mnuItemBlue_Click(sender As Object, e As EventArgs) Handles mnuItemBlue.Click
        mnuItemRed.Checked = False
        mnuItemBlue.Checked = True
        mnuItemGreen.Checked = False
        pen.Color = Color.Blue
    End Sub

    Private Sub mnuItemSolid_Click(sender As Object, e As EventArgs) Handles mnuItemSolid.Click
        mnuItemSolid.Checked = True
        mnuItemTexture.Checked = False
    End Sub

    Private Sub mnuItemTexture_Click(sender As Object, e As EventArgs) Handles mnuItemTexture.Click
        mnuItemSolid.Checked = False
        mnuItemTexture.Checked = True
    End Sub

    Private Sub mnuItemRectangle_Click(sender As Object, e As EventArgs) Handles mnuItemRectangle.Click
        mnuItemLine.Checked = False
        mnuItemText.Checked = False
        mnuItemRectangle.Checked = True
        mnuItemEllipse.Checked = False
    End Sub

    Private Sub mnuItemEllipse_Click(sender As Object, e As EventArgs) Handles mnuItemEllipse.Click
        mnuItemLine.Checked = False
        mnuItemText.Checked = False
        mnuItemRectangle.Checked = False
        mnuItemEllipse.Checked = True
    End Sub
    
    Private Sub mnuItemImage_Click(sender As Object, e As EventArgs) Handles mnuItemImage.Click
        Dim path As String = "\VB2012\Ch14\" ' 檔案路徑
        Dim g1 As Graphics = Graphics.FromImage(buffer)
        Dim bmp = New Bitmap(path & "sample.bmp")
        g1.DrawImage(bmp, 1, 25, bmp.Width, bmp.Height + 25)
        Me.Refresh()
    End Sub

    Private Sub mnuItemSmall_Click(sender As Object, e As EventArgs) Handles mnuItemSmall.Click
        Dim path As String = "\VB2012\Ch14\" ' 檔案路徑
        Dim g1 As Graphics = Graphics.FromImage(buffer)
        Dim bmp = New Bitmap(path & "sample.bmp")
        g1.DrawImage(bmp, 200, 25, bmp.Width \ 2, (bmp.Height + 25) \ 2)
        Me.Refresh()
    End Sub

    Private Sub mnuItemSave_Click(sender As Object, e As EventArgs) Handles mnuItemSave.Click
        Dim path As String = "\VB2012\Ch14\" ' 檔案路徑
        buffer.Save(path & "sample.jpg")
    End Sub

    Private Sub mnuItemClear_Click(sender As Object, e As EventArgs) Handles mnuItemClear.Click
        Dim g1 As Graphics = Graphics.FromImage(buffer)
        g1.Clear(Color.White)
        Me.Refresh()
    End Sub
End Class
