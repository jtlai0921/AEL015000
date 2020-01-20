Public Class Form1

    Private Sub Form1_Click(sender As Object, e As EventArgs) Handles Me.Click
        Dim g As Graphics = Me.CreateGraphics()
        g.Clear(Color.Yellow)
    End Sub

    Private Sub Form1_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        Dim g As Graphics = e.Graphics
        g.Clear(Color.Blue)
    End Sub
End Class
