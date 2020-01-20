Public Class Form3

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim f1 As Form1
        f1 = New Form1()
        f1.Show()
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim path As String = "\VB2012\Ch15\" ' 檔案路徑
        Dim gif = New Bitmap(path & "start.gif")
        ptbOutput.Image = gif
    End Sub
End Class