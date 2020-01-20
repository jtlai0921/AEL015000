Public Class Form1

    Dim x, y, dx, dy, score, remainBalls As Integer
    Dim myBall As Image = Image.FromFile("..\..\ball.jpg")
    Dim ballSize As Integer = 36
    Dim lblBricks(40) As Label
    Dim lblStatus(40) As Boolean

    Private Sub Form1_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        Dim g As Graphics = e.Graphics
        g.DrawImage(myBall, x, y, ballSize, ballSize)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        x = x + 10 * dx  ' 移動球
        y = y + 10 * dy
        ' 是否超過邊界, 超過就反彈
        If x >= Me.Width - ballSize Then dx = -1
        If x <= 1 Then dx = 1
        If y <= 1 Then dy = 1
        ' 是否有擋到, 有就反彈
        If y >= 400 - ballSize And y <= 400 And x > lblBar.Left - ballSize And x < lblBar.Left + lblBar.Width Then
            dy = -1
        Else
            If y >= 480 Then   ' 是否超過下邊界, 表示失球
                remainBalls = remainBalls - 1
                lblLost.Text = "剩球數：" & remainBalls
                If remainBalls = 0 Then  ' 沒球了
                    Timer1.Enabled = False
                    MsgBox("遊戲結束")
                    Button1.Enabled = True
                    Exit Sub
                Else
                    NewBall()  ' 重新開球
                End If
            End If
        End If
        ' 計算分數
        Dim i As Integer
        For i = 1 To 40
            If x + ballSize > lblBricks(i).Left And x < lblBricks(i).Left + lblBricks(i).Width And y + ballSize > lblBricks(i).Top And y < lblBricks(i).Top + lblBricks(i).Height And lblStatus(i) = True Then
                lblBricks(i).Visible = False
                score = score + 1
                lblScore.Text = "磚塊數：" & score
                lblStatus(i) = False
                If score >= 40 Then  ' 沒磚塊
                    Timer1.Enabled = False
                    MsgBox("完成此局遊戲")
                    Button1.Enabled = True
                    Exit Sub
                End If
            End If
        Next
        Me.Refresh()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Timer1.Enabled = True : score = 0 : remainBalls = 3
        lblScore.Text = "磚塊數：" & score
        lblLost.Text = "剩球數：" & remainBalls
        NewBall()
        For i = 1 To 40  ' 建立8欄5列40個磚塊的Label
            lblBricks(i) = New Label()
            lblBricks(i).BackColor = Color.Green
            lblBricks(i).Top = 50 + 22 * ((i - 1) \ 8)
            lblBricks(i).Left = (i Mod 8) * 62 + 6
            lblBricks(i).Width = 59
            lblBricks(i).Height = 19
            lblBricks(i).Visible = True
            Me.Controls.Add(lblBricks(i))
            lblStatus(i) = True
        Next
        Button1.Enabled = False
        Me.Refresh()
    End Sub
    ' 開球
    Sub NewBall()
        x = Int(Rnd(10) * (Me.Width - 10) + 10)
        y = 150
        dx = 1 : dy = 1
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If lblBar.Left < 20 Then  ' 向左
            lblBar.Left = 0
        Else
            lblBar.Left = lblBar.Left - 20
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If lblBar.Left > Me.Width - lblBar.Width - 20 Then ' 向右
            lblBar.Left = Me.Width - lblBar.Width
        Else
            lblBar.Left = lblBar.Left + 20
        End If
    End Sub
End Class
