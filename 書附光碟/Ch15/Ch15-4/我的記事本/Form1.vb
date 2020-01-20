﻿Imports System.IO

Public Class Form1

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

    Private Sub mnuItemCut_Click(sender As Object, e As EventArgs) Handles mnuItemCut.Click
        Dim start, length As Integer
        Dim str, strLeft, strRight As String
        ' 存入剪貼簿
        Clipboard.SetDataObject(txtNote.SelectedText)
        ' 刪除選取的文字
        str = txtNote.Text
        start = txtNote.SelectionStart
        length = txtNote.SelectionLength
        strLeft = Mid(str, 1, start)  ' 左邊
        strRight = Mid(str, start + length + 1) ' 右邊
        txtNote.Text = strLeft & strRight
        ' 重設選取位置與長度
        txtNote.SelectionStart = start
        txtNote.SelectionLength = 0
    End Sub

    Private Sub mnuItemCopy_Click(sender As Object, e As EventArgs) Handles mnuItemCopy.Click
        ' 存入剪貼簿
        Clipboard.SetDataObject(txtNote.SelectedText)
    End Sub

    Private Sub mnuItemPaste_Click(sender As Object, e As EventArgs) Handles mnuItemPaste.Click
        ' 取出剪貼簿的內容
        Dim ido As IDataObject = Clipboard.GetDataObject()
        If ido.GetDataPresent(DataFormats.Text) Then
            ' 貼入TextBox文字方塊
            txtNote.SelectedText = ido.GetData(DataFormats.Text).ToString()
        End If
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
    ' 第13章的程式碼
    Function formatDir(strDir As String) As String
        If Microsoft.VisualBasic.Right(strDir, 1) <> "\" Then
            strDir &= "\"
        End If
        Return strDir
    End Function

    Private Sub mnuItemList_Click(sender As Object, e As EventArgs) Handles mnuItemList.Click
        Dim path, out As String
        Dim index As Integer
        ' 取得目前路徑
        path = formatDir(Directory.GetCurrentDirectory())
        ' 輸入路徑
        path = InputBox("請輸入路徑?", "輸入路徑", path)
        path = formatDir(path)
        Try ' 錯誤處理
            ' 顯示目錄清單
            out = "輸入路徑: " & path & vbNewLine
            Dim dirInfo As DirectoryInfo = New DirectoryInfo(path)
            Dim subDirs() As DirectoryInfo = dirInfo.GetDirectories()
            For index = 0 To UBound(subDirs)
                out &= subDirs(index).Name & vbNewLine
            Next
            out &= "-----------" & vbNewLine
            ' 顯示檔案清單
            Dim subFiles() As FileInfo = dirInfo.GetFiles()
            For Each subFile In subFiles
                out &= subFile.Name & vbNewLine
            Next
            txtNote.Text = out
        Catch ex As Exception
            MsgBox("錯誤: 目錄不存在!")
        End Try
    End Sub

    Private Sub mnuItemAttr_Click(sender As Object, e As EventArgs) Handles mnuItemAttr.Click
        Dim out As String = ""
        Dim file As String
        file = Directory.GetCurrentDirectory() & "\我的記事本.exe"
        ' 輸入檔案路徑
        file = InputBox("請輸入檔案路徑?", "輸入檔案路徑", file)
        Try  ' 顯示屬性
            ' 建立FileInfo物件
            Dim fInfo As FileInfo = New FileInfo(file)
            ' 顯示檔案資訊
            out = "檔案名稱: " & fInfo.Name & vbNewLine
            out &= "檔案全名: " & fInfo.FullName & vbNewLine
            out &= "檔案副檔名: " & fInfo.Extension & vbNewLine
            out &= "父資料夾名稱: " & fInfo.Directory.Name & vbNewLine
            out &= "父資料夾全名: " & fInfo.DirectoryName & vbNewLine
            out &= "建立日期: " & fInfo.CreationTime & vbNewLine
            out &= "存取日期: " & fInfo.LastAccessTime & vbNewLine
            out &= "寫入日期: " & fInfo.LastWriteTime & vbNewLine
            out &= "檔案尺寸: " & fInfo.Length & vbNewLine
            txtNote.Text = out
        Catch ex As Exception
            MsgBox("錯誤: 檔案不存在!")
        End Try
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        txtNote.ReadOnly = False
        txtNote.SelectionStart = 0
        txtNote.SelectionLength = 0
        txtNote.Focus()
        ofdOpen.InitialDirectory = Directory.GetCurrentDirectory()
        ofdOpen.Filter = "文字檔案(*.txt)|*.txt|所有檔案(*.*)|*.*"
        ofdOpen.FilterIndex = 2
        ofdOpen.RestoreDirectory = True
        sfdSave.Filter = "文字檔案(*.txt)|*.txt|所有檔案(*.*)|*.*"
        sfdSave.FilterIndex = 2
        sfdSave.RestoreDirectory = True
    End Sub

    Private Sub mnuItemOpen_Click(sender As Object, e As EventArgs) Handles mnuItemOpen.Click
        Dim fileName As String
        ' 開啟FileOpenDialog對話方塊
        If ofdOpen.ShowDialog() = DialogResult.OK Then
            fileName = ofdOpen.FileName  ' 取得選取檔案
            ' 開啟文字檔案
            Dim sr As StreamReader = New StreamReader(fileName)
            txtNote.Text = sr.ReadToEnd()
            sr.Close()   ' 關閉檔案
            txtNote.SelectionStart = 0
            txtNote.SelectionLength = 0
            Me.Text = "我的記事本 - " & fileName
            tsslOutput.Text = "成功讀取檔案: " & fileName
        End If
    End Sub

    Private Sub mnuItemSave_Click(sender As Object, e As EventArgs) Handles mnuItemSave.Click
        Dim fileName As String
        ' 開啟SaveOpenDialog對話方塊
        If sfdSave.ShowDialog() = DialogResult.OK Then
            fileName = sfdSave.FileName  ' 取得選取檔案
            ' 開啟文字檔案
            Dim sw As StreamWriter = New StreamWriter(fileName)
            sw.WriteLine(txtNote.Text)  ' 寫入
            sw.Flush()    ' 將緩衝區資料寫入檔案
            sw.Close()    ' 關閉檔案
            Me.Text = "我的記事本 - " & fileName
            tsslOutput.Text = "成功寫入檔案: " & fileName
        End If
    End Sub

    Private Sub mnuItemFont_Click(sender As Object, e As EventArgs) Handles mnuItemFont.Click
        dlgFont.ShowColor = True  ' 選取字型色彩
        If dlgFont.ShowDialog() = DialogResult.OK Then
            txtNote.Font = dlgFont.Font
            txtNote.ForeColor = dlgFont.Color
        End If
    End Sub

    Private Sub mnuItemForeColor_Click(sender As Object, e As EventArgs) Handles mnuItemForeColor.Click
        dlgColor.AllowFullOpen = False ' 取消自訂色彩
        dlgColor.ShowHelp = True       ' 顯示說明
        dlgColor.Color = txtNote.ForeColor ' 預設值
        dlgColor.ShowDialog()
        txtNote.ForeColor = dlgColor.Color
    End Sub

    Private Sub mnuItemBackColor_Click(sender As Object, e As EventArgs) Handles mnuItemBackColor.Click
        dlgColor.AllowFullOpen = True  ' 自訂色彩
        dlgColor.ShowHelp = False      ' 取消說明
        dlgColor.Color = txtNote.BackColor ' 預設值
        dlgColor.ShowDialog()
        txtNote.BackColor = dlgColor.Color
    End Sub

    Private Sub mnuItemAbout_Click(sender As Object, e As EventArgs) Handles mnuItemAbout.Click
        Dim f2 As Form2
        f2 = New Form2()
        f2.Show()
    End Sub
    ' 第15章的程式碼
    Public strSearch As String

    Private Sub mnuItemSearch_Click(sender As Object, e As EventArgs) Handles mnuItemSearch.Click
        Dim f3 As Form3
        f3 = New Form3()
        f3.ShowDialog()  ' 開啟對話方塊
        If f3.DialogResult = DialogResult.OK Then
            Dim pos As Integer
            ' 搜尋字串
            strSearch = f3.txtSearch.Text
            pos = InStr(1, txtNote.Text, strSearch)
            If pos > 0 Then
                txtNote.SelectionStart = pos - 1
                txtNote.SelectionLength = Len(strSearch)
                txtNote.Focus()
            End If
        End If
    End Sub

    Private Sub mnuItemReplace_Click(sender As Object, e As EventArgs) Handles mnuItemReplace.Click
        Dim f4 As Form4
        f4 = New Form4()
        f4.Show()  ' 開啟表單
    End Sub

    Private Sub mnuItemIE_Click(sender As Object, e As EventArgs) Handles mnuItemIE.Click
        Dim progID As Integer
        progID = Shell("C:\Program Files\Internet " &
           "Explorer\IEXPLORE.EXE", AppWinStyle.MaximizedFocus)
    End Sub

    Private Sub mnuItemPaint_Click(sender As Object, e As EventArgs) Handles mnuItemPaint.Click
        Dim progID As Integer
        progID = Shell("C:\Windows\System32\mspaint.exe",
                        AppWinStyle.NormalFocus)
    End Sub

    Private Sub mnuItemNotePad_Click(sender As Object, e As EventArgs) Handles mnuItemNotePad.Click
        Dim progID As Integer
        progID = Shell("C:\Windows\notepad.exe",
                        AppWinStyle.NormalFocus)
    End Sub
End Class
