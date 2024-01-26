Imports ClosedXML.Excel
Imports MySql.Data.MySqlClient
Public Class Freports
    Private Sub RCB(btn As Button)
        btn.FlatStyle = FlatStyle.Flat
        btn.FlatAppearance.BorderSize = 0
        btn.Cursor = Cursors.Hand

        Dim rad As New Drawing2D.GraphicsPath
        rad.StartFigure()
        'left top corner
        rad.AddArc(New Rectangle(0, 0, 50, 50), 180, 90)
        rad.AddLine(10, 0, btn.Width - 20, 0)
        'right top corner
        rad.AddArc(New Rectangle(btn.Width - 55, 0, 55, 55), -90, 90)
        rad.AddLine(btnExport.Width, 20, btn.Width, btn.Height - 10)
        'right bottom corner
        rad.AddArc(New Rectangle(btn.Width - 55, btn.Height - 55, 55, 55), 0, 90)
        'left bottom corner
        rad.AddLine(btn.Width - 10, btn.Width, 20, btn.Height)

        rad.AddArc(New Rectangle(0, btn.Height - 50, 50, 50), 90, 90)
        rad.CloseFigure()
        btnExport.Region = New Region(rad)
    End Sub
    Private Sub Freports_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RCB(btnExport)
        loadattendance()
        'DataGridView1.Columns(3).Visible = False
        'DataGridView1.Columns(5).Visible = False
        Try
            reloadTxt("SELECT * FROM tbl_attendance WHERE StatusIn='ENTER'")
            If dt.Rows.Count > 0 Then
                Label4.Text = dt.Rows.Count.ToString
            End If
        Catch ex As Exception

        End Try
        Try
            reloadTxt("SELECT * FROM tbl_attendance WHERE StatusOut='LEAVE'")
            If dt.Rows.Count > 0 Then
                Label5.Text = dt.Rows.Count.ToString
            End If
        Catch ex As Exception

        End Try
        Timer1.Start()
    End Sub
    Public Sub loadattendance()
        Try
            reload("SELECT * FROM tbl_attendance", DataGridView1)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim CurrentDateTime As DateTime
        CurrentDateTime = DateTime.Now
        Label7.Text = CurrentDateTime.ToString("hh:mm:ss  tt")
    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click
        Call loadattendance()
    End Sub

    Private Sub btnFilter_Click(sender As Object, e As EventArgs) Handles btnFilter.Click
        Try
            reload("SELECT * FROM tbl_attendance WHERE  tbl_attendance.Date BETWEEN '" & DTPfrom.Text & "' AND '" & DTPto.Text & "'", DataGridView1)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        Try
            If Asc(e.KeyChar) = 13 Then
                Dim dv As DataView
                dv = dt.DefaultView
                dv.RowFilter = String.Format("Student_ID like '%{0}'", TextBox1.Text)
                DataGridView1.DataSource = dv.ToTable()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        Try
            Dim xlApp As Microsoft.Office.Interop.Excel.Application
            Dim xlWorkBook As Microsoft.Office.Interop.Excel.Workbook
            Dim xlWorkSheet As Microsoft.Office.Interop.Excel.Worksheet
            Dim misValue As Object = System.Reflection.Missing.Value
            Dim i As Integer
            Dim j As Integer
            xlApp = New Microsoft.Office.Interop.Excel.Application
            xlWorkBook = xlApp.Workbooks.Add(misValue)
            xlWorkSheet = xlWorkBook.Sheets("sheet1")
            xlWorkSheet.Columns.AutoFit()
            For i = 0 To DataGridView1.RowCount - 2
                For j = 0 To DataGridView1.ColumnCount - 1
                    For k As Integer = 1 To DataGridView1.Columns.Count
                        xlWorkSheet.Cells(1, k) = DataGridView1.Columns(k - 1).HeaderText
                        xlWorkSheet.Cells(i + 2, j + 1) = DataGridView1(j, i).Value.ToString()
                    Next
                Next
            Next
            Dim fName As String = ""
            Using sfd As New SaveFileDialog
                sfd.Title = "Save As"
                sfd.OverwritePrompt = True
                sfd.FileName = fName
                sfd.DefaultExt = ".xlsx"
                sfd.Filter = "Excel Workbook(*.xlsx)|"
                sfd.AddExtension = True
                If sfd.ShowDialog() = DialogResult.OK Then
                    xlWorkSheet.SaveAs(sfd.FileName)
                    xlWorkBook.Close()
                    xlApp.Quit()
                    releaseObject(xlApp)
                    releaseObject(xlWorkBook)
                    releaseObject(xlWorkSheet)
                    MsgBox("Successfully Exported!", MsgBoxStyle.Information)
                End If
            End Using
        Catch ex As Exception
            MsgBox("Error Occur! " & vbCrLf & "Code error: " & ex.Message)
        End Try
    End Sub
    Private Sub releaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub
End Class