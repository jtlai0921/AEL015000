Public Class Form1

    Dim intApple As Integer = 0
    Dim intSony As Integer = 0
    Dim intNokia As Integer = 0
    Dim intSamsung As Integer = 0
    Dim intHTC As Integer = 0
    Dim total As Integer = 0

    Private Sub lblButton_Click(sender As Object, e As EventArgs) Handles lblButton.Click
        If ltbName.Items.IndexOf(txtName.Text) = -1 Then
            ' 姓名不存在, 所以新增參與投票的使用者名稱
            ltbName.Items.Add(txtName.Text)
            total += 1
            txtTotal.Text = total
            GroupBox1.Enabled = True  ' 啟用GroupBox
            lblButton.Enabled = False
            rdbApple.Checked = False   ' 清除選擇
            rdbSony.Checked = False
            rdbNokia.Checked = False
            rdbSamsung.Checked = False
            rdbHTC.Checked = False
        Else
            MsgBox("使用者姓名已經存在!")
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        GroupBox1.Enabled = False  ' 不啟用GroupBox
    End Sub

    Private Sub rdbApple_CheckedChanged(sender As Object, e As EventArgs) Handles rdbApple.CheckedChanged
        If rdbApple.Checked = True Then
            intApple += 1
            txtApple.Text = intApple
            GroupBox1.Enabled = False
            lblButton.Enabled = True
        End If
    End Sub

    Private Sub rdbSony_CheckedChanged(sender As Object, e As EventArgs) Handles rdbSony.CheckedChanged
        If rdbSony.Checked = True Then
            intSony += 1
            txtSony.Text = intSony
            GroupBox1.Enabled = False
            lblButton.Enabled = True
        End If
    End Sub

    Private Sub rdbNokia_CheckedChanged(sender As Object, e As EventArgs) Handles rdbNokia.CheckedChanged
        If rdbNokia.Checked = True Then
            intNokia += 1
            txtNokia.Text = intNokia
            GroupBox1.Enabled = False
            lblButton.Enabled = True
        End If
    End Sub

    Private Sub rdbSamsung_CheckedChanged(sender As Object, e As EventArgs) Handles rdbSamsung.CheckedChanged
        If rdbSamsung.Checked = True Then
            intSamsung += 1
            txtSamsung.Text = intSamsung
            GroupBox1.Enabled = False
            lblButton.Enabled = True
        End If
    End Sub

    Private Sub rdbHTC_CheckedChanged(sender As Object, e As EventArgs) Handles rdbHTC.CheckedChanged
        If rdbHTC.Checked = True Then
            intHTC += 1
            txtHTC.Text = intHTC
            GroupBox1.Enabled = False
            lblButton.Enabled = True
        End If
    End Sub
End Class
