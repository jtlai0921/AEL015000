Public Class Form1

    Dim turn As Boolean = True
    Dim board(2, 2) As Integer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' 初始陣列元素值為-3
        For i As Integer = 0 To 2
            For j As Integer = 0 To 2
                board(i, j) = -3
            Next j
        Next i
    End Sub

    Function CheckWin()
        Dim total, total1 As Integer
        ' 檢查每一列和每一欄
        For i As Integer = 0 To 2
            total = 0 : total1 = 0
            For j As Integer = 0 To 2
                total += board(i, j) ' 每一列
                total1 += board(j, i) '每一欄
            Next j
            If total = 0 Or total1 = 0 Then
                MsgBox("遊戲結束！○贏")
                Return True
            End If
            If total = 3 Or total1 = 3 Then
                MsgBox("遊戲結束！✕贏")
                Return True
            End If
        Next i
        ' 檢查對角線
        total = board(0, 0) + board(1, 1) + board(2, 2)
        total1 = board(2, 0) + board(1, 1) + board(0, 2)
        If total = 0 Or total1 = 0 Then
            MsgBox("遊戲結束！○贏")
            Return True
        End If
        If total = 3 Or total1 = 3 Then
            MsgBox("遊戲結束！✕贏")
            Return True
        End If
        Return False
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If turn Then
            Button1.Text = "○"
            board(0, 0) = 0
        Else
            Button1.Text = "✕"
            board(0, 0) = 1
        End If
        turn = Not turn
        CheckWin()  ' 檢查是否有贏家
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If turn Then
            Button2.Text = "○"
            board(0, 1) = 0
        Else
            Button2.Text = "✕"
            board(0, 1) = 1
        End If
        turn = Not turn
        CheckWin()  ' 檢查是否有贏家
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If turn Then
            Button3.Text = "○"
            board(0, 2) = 0
        Else
            Button3.Text = "✕"
            board(0, 2) = 1
        End If
        turn = Not turn
        CheckWin()  ' 檢查是否有贏家
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If turn Then
            Button4.Text = "○"
            board(1, 0) = 0
        Else
            Button4.Text = "✕"
            board(1, 0) = 1
        End If
        turn = Not turn
        CheckWin()  ' 檢查是否有贏家
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If turn Then
            Button5.Text = "○"
            board(1, 1) = 0
        Else
            Button5.Text = "✕"
            board(1, 1) = 1
        End If
        turn = Not turn
        CheckWin()  ' 檢查是否有贏家
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If turn Then
            Button6.Text = "○"
            board(1, 2) = 0
        Else
            Button6.Text = "✕"
            board(1, 2) = 1
        End If
        turn = Not turn
        CheckWin()  ' 檢查是否有贏家
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If turn Then
            Button7.Text = "○"
            board(2, 0) = 0
        Else
            Button7.Text = "✕"
            board(2, 0) = 1
        End If
        turn = Not turn
        CheckWin()  ' 檢查是否有贏家
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If turn Then
            Button8.Text = "○"
            board(2, 1) = 0
        Else
            Button8.Text = "✕"
            board(2, 1) = 1
        End If
        turn = Not turn
        CheckWin()  ' 檢查是否有贏家
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If turn Then
            Button9.Text = "○"
            board(2, 2) = 0
        Else
            Button9.Text = "✕"
            board(2, 2) = 1
        End If
        turn = Not turn
        CheckWin()  ' 檢查是否有贏家
    End Sub
End Class
