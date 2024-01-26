Imports MySql.Data.MySqlClient
Public Class Fedit
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
        rad.AddLine(btnEditDetails.Width, 20, btn.Width, btn.Height - 10)
        'right bottom corner
        rad.AddArc(New Rectangle(btn.Width - 55, btn.Height - 55, 55, 55), 0, 90)
        'left bottom corner
        rad.AddLine(btn.Width - 10, btn.Width, 20, btn.Height)

        rad.AddArc(New Rectangle(0, btn.Height - 50, 50, 50), 90, 90)
        rad.CloseFigure()
        btnEditDetails.Region = New Region(rad)

    End Sub
    Dim connection As MySqlConnection
    Dim adapter As MySqlDataAdapter
    Dim dt As New DataTable
    Dim command As New MySqlCommand

    Private Sub Fedit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RCB(btnEditDetails)
    End Sub

    Private Sub btnEditDetails_Click(sender As Object, e As EventArgs) Handles btnEditDetails.Click
        Dim sql As String = "update tbl_students set Student_ID='" & txtStudentID.Text & "',Fullname='" & txtStudentName.Text & "',Section='" & txtSection.Text & "',Emergency='" & txtEmergency.Text & "',Email='" & txtEmail.Text & "' where Student_ID='" & Fstudents.txtStudentID.Text & "'"
        connection = New MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=thesis_db")
        connection.Open()
        command = New MySqlCommand(sql, connection)
        command.Connection = connection
        command.ExecuteNonQuery()
        MessageBox.Show("Updated successfully")
        adapter = New MySqlDataAdapter("Select * from tbl_students", connection)
        adapter.Fill(dt)
        Fstudents.DataGridView1.DataSource = dt
    End Sub
End Class