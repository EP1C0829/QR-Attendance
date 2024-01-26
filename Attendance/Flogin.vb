Imports System.Reflection.Emit
Imports MySql.Data
Imports MySql.Data.MySqlClient

Public Class Flogin
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
        rad.AddLine(btnLogin.Width, 20, btn.Width, btn.Height - 10)
        'right bottom corner
        rad.AddArc(New Rectangle(btn.Width - 55, btn.Height - 55, 55, 55), 0, 90)
        'left bottom corner
        rad.AddLine(btn.Width - 10, btn.Width, 20, btn.Height)

        rad.AddArc(New Rectangle(0, btn.Height - 50, 50, 50), 90, 90)
        rad.CloseFigure()
        btnLogin.Region = New Region(rad)
    End Sub

    Dim connection As MySqlConnection
    Dim adapter As MySqlDataAdapter
    Dim ds As DataSet

    Private Sub Flogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connection = New MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=thesis_db")
        connection.Open()
        Dim newFont As New Font(Label1.Font.Name, Label1.Font.Size, FontStyle.Underline)
        Label1.Font = newFont
        RCB(btnLogin)
    End Sub

    Private Sub txtUsername_Enter(sender As Object, e As EventArgs) Handles txtUsername.Enter
        If txtUsername.Text = "Username" Then
            txtUsername.Text = ""
            txtUsername.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtUsername_Leave(sender As Object, e As EventArgs) Handles txtUsername.Leave
        If txtUsername.Text = "" Then
            txtUsername.Text = "Username"
            txtUsername.ForeColor = Color.Silver
        End If
    End Sub

    Private Sub txtPassword_Enter(sender As Object, e As EventArgs) Handles txtPassword.Enter
        If txtPassword.Text = "Password" Then
            txtPassword.Text = ""
            txtPassword.ForeColor = Color.Black
            txtPassword.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub txtPassword_Leave(sender As Object, e As EventArgs) Handles txtPassword.Leave
        If txtPassword.Text = "" Then
            txtPassword.Text = "Password"
            txtPassword.ForeColor = Color.Silver
            txtPassword.UseSystemPasswordChar = False
        End If
    End Sub

    Private Sub Spassword_CheckedChanged(sender As Object, e As EventArgs) Handles Spassword.CheckedChanged
        If txtPassword.UseSystemPasswordChar = True Then
            txtPassword.UseSystemPasswordChar = False
        Else
            txtPassword.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        adapter = New MySqlDataAdapter("select UserID, Password from tbl_user where Userid = '" & txtUsername.Text & "' and Password = '" & txtPassword.Text & "'", connection)
        ds = New DataSet()
        adapter.Fill(ds, "Login")
        If (ds.Tables("Login").Rows.Count > 0) Then
            Fmain.Show()
            Me.Hide()
        Else
            MessageBox.Show("Incorrect Username and password combination", "Login")
        End If
    End Sub
End Class