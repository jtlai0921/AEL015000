Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Text = Button1.Text
        Button1.Text = Button2.Text
        Button2.Text = Me.Text
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Text = Button2.Text
        Button2.Text = Button1.Text
        Button1.Text = Me.Text
    End Sub
End Class
