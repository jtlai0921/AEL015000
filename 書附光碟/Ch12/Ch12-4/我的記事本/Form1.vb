﻿Public Class Form1

    Dim strSelectedText As String

    Private Sub mnuItemExit_Click(sender As Object, e As EventArgs) Handles mnuItemExit.Click
        End
    End Sub

    Private Sub mnuItemInput_Click(sender As Object, e As EventArgs) Handles mnuItemInput.Click
        If mnuItemInput.Checked Then
            txtNote.ReadOnly = True   ' 關
            mnuItemInput.Checked = False
        Else
            txtNote.ReadOnly = False  ' 開
            mnuItemInput.Checked = True
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        txtNote.ReadOnly = False
        txtNote.SelectionStart = 0
        txtNote.SelectionLength = 0
        txtNote.Focus()
    End Sub

    Private Sub mnuItemCut_Click(sender As Object, e As EventArgs) Handles mnuItemCut.Click
        strSelectedText = txtNote.SelectedText  ' 取得選取內容
        ' 呼叫strCut()函數
        txtNote.Text = strCut(txtNote.Text, txtNote.SelectionStart, Len(strSelectedText))
    End Sub

    Private Sub mnuItemCopy_Click(sender As Object, e As EventArgs) Handles mnuItemCopy.Click
        strSelectedText = txtNote.SelectedText  ' 保留選取的內容
    End Sub

    Private Sub mnuItemPaste_Click(sender As Object, e As EventArgs) Handles mnuItemPaste.Click
        ' 呼叫strPaste()函數
        txtNote.Text = strPaste(txtNote.Text, strSelectedText, txtNote.SelectionStart)
    End Sub

    Private Sub cmnuItemCut_Click(sender As Object, e As EventArgs) Handles cmnuItemCut.Click
        strSelectedText = txtNote.SelectedText  ' 取得選取內容
        ' 呼叫strCut()函數
        txtNote.Text = strCut(txtNote.Text, txtNote.SelectionStart, Len(strSelectedText))
    End Sub

    Private Sub cmnuItemCopy_Click(sender As Object, e As EventArgs) Handles cmnuItemCopy.Click
        strSelectedText = txtNote.SelectedText  ' 保留選取的內容
    End Sub

    Private Sub cmnuItemPaste_Click(sender As Object, e As EventArgs) Handles cmnuItemPaste.Click
        ' 呼叫strPaste()函數
        txtNote.Text = strPaste(txtNote.Text, strSelectedText, txtNote.SelectionStart)
    End Sub

    Function strCut(str As String, pos As Integer, length As Integer) As String
        Dim strLeft, strRight As String
        ' 選取位置的左邊字串
        strLeft = Mid(str, 1, pos)
        ' 剪下文字內容的右邊字串
        strRight = Mid(str, pos + length + 1)
        ' 刪除選取的內容
        Return strLeft & strRight
    End Function

    Function strPaste(str As String, selectedText As String, pos As Integer) As String
        Dim strLeft, strRight As String
        strLeft = Mid(str, 1, pos)
        strRight = Mid(str, pos + 1)
        Return strLeft & selectedText & strRight
    End Function

    Private Sub tlsbCut_Click(sender As Object, e As EventArgs) Handles tlsbCut.Click
        strSelectedText = txtNote.SelectedText  ' 取得選取內容
        txtNote.Text = strCut(txtNote.Text, txtNote.SelectionStart, Len(strSelectedText))
    End Sub

    Private Sub tlsbCopy_Click(sender As Object, e As EventArgs) Handles tlsbCopy.Click
        strSelectedText = txtNote.SelectedText  ' 保留選取的內容
    End Sub

    Private Sub tlsbPaste_Click(sender As Object, e As EventArgs) Handles tlsbPaste.Click
        txtNote.Text = strPaste(txtNote.Text, strSelectedText, txtNote.SelectionStart)
    End Sub

    Private Sub tlsbSearch_Click(sender As Object, e As EventArgs) Handles tlsbSearch.Click
        Dim pos As Integer
        pos = InStr(1, txtNote.Text, tlstSearch.Text)
        If pos > 0 Then ' 找到
            txtNote.SelectionStart = pos - 1
            txtNote.SelectionLength = Len(tlstSearch.Text)
            txtNote.Focus()  ' 取得焦點
            tsslOutput.Text = "位置: " & pos & " 長度: " & Len(tlstSearch.Text)
        End If
    End Sub

    Private Sub mnuItemStatus_Click(sender As Object, e As EventArgs) Handles mnuItemStatus.Click
        If mnuItemStatus.Checked Then
            stsOutput.Visible = False
            mnuItemStatus.Checked = False
        Else
            stsOutput.Visible = True
            mnuItemStatus.Checked = True
        End If
    End Sub
End Class
