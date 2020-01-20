﻿Public Class Form1

    Sub ShowPrompt(msg As String)
        lblOutput.Text = msg
    End Sub

    Function ReturnChange(Amount As Integer, Unit As Integer)
        Dim Change As Integer = 0  ' 計算零錢數
        ' 換零錢的迴圈
        Do While Amount >= Unit
            Amount = Amount - Unit  ' 每次減一單位
            Change = Change + 1
        Loop
        Return Change
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Amount, Unit As Integer
        Amount = CInt(txtAmount.Text)
        Unit = CInt(txtUnit.Text)
        Call ShowPrompt("可兌換數:")   ' 呼叫程序
        lblOutput.Text &= ReturnChange(Amount, Unit)  ' 呼叫函數
    End Sub
End Class
