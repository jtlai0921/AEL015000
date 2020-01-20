Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim bet As Integer
        bet = CInt(lblBet.Text) + 10
        If bet > 100 Then
            MsgBox("最大押注是100元")
        Else
            lblBet.Text = CInt(lblBet.Text) + 10
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim bet As Integer
        bet = CInt(lblBet.Text) - 10
        If bet < 10 Then
            MsgBox("最小押注是10元")
        Else
            lblBet.Text = CInt(lblBet.Text) - 10
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If CInt(lblMoney.Text) <= 100 Then ' 金額小於100
            If CInt(lblBet.Text) > CInt(lblMoney.Text) Then
                lblBet.Text = lblMoney.Text
            End If
        End If
        If lblBet.Text <= 0 Then
            MsgBox("遊戲結束!")
        Else
            lblResult.Text = "!!!! 轉動中 !!!!"
            lblMoney.Text = CInt(lblMoney.Text) - CInt(lblBet.Text)
            lblOriginal.Text = CInt(lblMoney.Text)
            StartRoll()  ' 開始遊戲
        End If
    End Sub

    Sub StartRoll()
        Dim slot1, slot2, slot3 As Integer
        Randomize()
        For i = 1 To 10
            ' 更新數字
            lblSlot1.Text = CStr(Int(Rnd() * 10))
            lblSlot2.Text = CStr(Int(Rnd() * 10))
            lblSlot3.Text = CStr(Int(Rnd() * 10))
            Me.Refresh()  ' 更新表單介面
            ' 暫停
            System.Threading.Thread.Sleep(100)
        Next
        slot1 = CInt(lblSlot1.Text)
        slot2 = CInt(lblSlot2.Text)
        slot3 = CInt(lblSlot3.Text)
        GetAward(slot1, slot2, slot3)
    End Sub

    Sub GetAward(slot1 As Integer, slot2 As Integer, slot3 As Integer)
        Dim award As Integer ' 獎金
        If slot1 = 7 And slot2 = 7 And slot3 = 7 Then ' 3個7
            award = (CInt(lblBet.Text) * 20)
            lblMoney.Text = award + CInt(lblOriginal.Text)
            lblResult.Text = "轉中777 = 押注 X 20倍"
        ElseIf slot1 = slot2 And slot2 = slot3 And slot1 = slot3 Then ' 3個相同
            award = (CInt(lblBet.Text) * 10)
            lblMoney.Text = award + CInt(lblOriginal.Text)
            lblResult.Text = "轉中3個 = 押注 X 10倍"
        ElseIf slot1 = slot2 Or slot2 = slot3 Or slot1 = slot3 Then
            award = (CInt(lblBet.Text) * 5) ' 2個相同
            lblMoney.Text = award + CInt(lblOriginal.Text)
            lblResult.Text = "轉中2個 = 押注 X 5倍"
        Else
            lblResult.Text = "!!失敗!! 請再轉一次!!"
        End If
    End Sub
End Class
