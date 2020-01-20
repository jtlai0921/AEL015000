Public Class Form2

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim path As String = "\VB2012\Ch15\" ' 檔案路徑
        Dim gif = New Bitmap(path & "sample.gif")
        ptbOutput.Image = gif
    End Sub
End Class