Public Class Form1

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If MsgBox("確認結束表單 ?", MsgBoxStyle.OkCancel) =
                                 MsgBoxResult.Cancel Then
            e.Cancel = True
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.Width = 310
        Me.Height = 190
    End Sub

    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        Me.Width = 310
        Me.Height = 190
    End Sub
End Class
