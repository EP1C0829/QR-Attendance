Imports MySql.Data.MySqlClient
Imports Mysqlx

Public Class Fstudents
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
        rad.AddLine(btnRegister.Width, 20, btn.Width, btn.Height - 10)
        'right bottom corner
        rad.AddArc(New Rectangle(btn.Width - 55, btn.Height - 55, 55, 55), 0, 90)
        'left bottom corner
        rad.AddLine(btn.Width - 10, btn.Width, 20, btn.Height)

        rad.AddArc(New Rectangle(0, btn.Height - 50, 50, 50), 90, 90)
        rad.CloseFigure()
        btnRegister.Region = New Region(rad)
        btnEdit.Region = New Region(rad)
        btnDelete.Region = New Region(rad)
    End Sub

    Dim connection As MySqlConnection
    Dim adapter As MySqlDataAdapter
    Dim dt As New DataTable
    Private Sub Fstudents_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RCB(btnRegister)
        RCB(btnEdit)
        RCB(btnDelete)
        reload_data()
        connection = New MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=thesis_db")
        connection.Open()
        adapter = New MySqlDataAdapter("Select * from tbl_students", connection)
        adapter.Fill(dt)
        DataGridView1.DataSource = dt
        DataGridView1.Columns(0).Visible = False
    End Sub

    Public Sub reload_data()
        Try
            reload("SELECT * FROM tbl_students", DataGridView1)
        Catch ex As Exception

        End Try
    End Sub


    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Fregister.Show()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Fedit.Show()
    End Sub
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Fqr.txtStudentID.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString.Trim
        txtStudentID.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString.Trim
        Fedit.txtStudentID.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString.Trim
        Fedit.txtStudentName.Text = DataGridView1.CurrentRow.Cells(2).Value.ToString.Trim
        Fedit.txtSection.Text = DataGridView1.CurrentRow.Cells(3).Value.ToString.Trim
        Fedit.txtEmergency.Text = DataGridView1.CurrentRow.Cells(4).Value.ToString.Trim
        Fedit.txtEmail.Text = DataGridView1.CurrentRow.Cells(5).Value.ToString.Trim
    End Sub

    Private Sub txtStudentID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtStudentID.KeyPress
        Try
            If Asc(e.KeyChar) = 13 Then
                Dim dv As DataView
                dv = dt.DefaultView
                dv.RowFilter = String.Format("Student_ID like '%{0}'", txtStudentID.Text)
                DataGridView1.DataSource = dv.ToTable()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        connection.Close()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        For i As Integer = 0 To DataGridView1.SelectedRows.Count - 1
            Dim command As New MySqlCommand("delete from tbl_students where ID = @ID", connection)
            command.Parameters.AddWithValue("ID", DataGridView1.SelectedRows(i).Cells(0).Value.ToString())
            command.ExecuteNonQuery()
            connection.Close()
        Next
        reload_data()
        MessageBox.Show("Data Deleted Successfully")
    End Sub


End Class