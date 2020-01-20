﻿Public Class Form1

    Dim total As Integer = 0

    Private Sub txtName_DoubleClick(sender As Object, e As EventArgs) Handles txtName.DoubleClick
        If txtName.BackColor = Color.Yellow Then
            txtName.BackColor = Color.White
        Else
            txtName.BackColor = Color.Yellow
        End If
    End Sub

    Private Sub lblButton_Click(sender As Object, e As EventArgs) Handles lblButton.Click
        If ltbName.Items.IndexOf(txtName.Text) = -1 Then
            ' 姓名不存在, 所以新增參與投票的使用者名稱
            ltbName.Items.Add(txtName.Text)
            total += 1
            txtTotal.Text = total
        Else
            MsgBox("使用者姓名已經存在!")
        End If
    End Sub

    Private Sub ltbName_MouseEnter(sender As Object, e As EventArgs) Handles ltbName.MouseEnter
        ltbName.BackColor = Color.LightGray
    End Sub

    Private Sub ltbName_MouseLeave(sender As Object, e As EventArgs) Handles ltbName.MouseLeave
        ltbName.BackColor = Color.White
    End Sub
End Class
