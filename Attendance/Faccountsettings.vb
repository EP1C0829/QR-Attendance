Imports MySql.Data
Imports MySql.Data.MySqlClient

Public Class Faccountsettings
    Dim connection As MySqlConnection
    Dim command As MySqlCommand
    Dim username As String
    Dim password As String

    Private Sub Faccountsettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connection = New MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=thesis_db")
        connection.Open()

        username = Flogin.txtUsername.Text
        password = Flogin.txtPassword.Text

    End Sub

    Private Sub txtCurrentpass_Enter(sender As Object, e As EventArgs) Handles txtCurrentpass.Enter
        If txtCurrentpass.Text = "Current Password" Then
            txtCurrentpass.Text = ""
            txtCurrentpass.ForeColor = Color.Black
            txtCurrentpass.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub txtCurrentpass_Leave(sender As Object, e As EventArgs) Handles txtCurrentpass.Leave
        If txtCurrentpass.Text = "" Then
            txtCurrentpass.Text = "Current Password"
            txtCurrentpass.ForeColor = Color.Silver
            txtCurrentpass.UseSystemPasswordChar = False
        End If
    End Sub
    Private Sub txtNewpass_Enter(sender As Object, e As EventArgs) Handles txtNewpass.Enter
        If txtNewpass.Text = "New Password" Then
            txtNewpass.Text = ""
            txtNewpass.ForeColor = Color.Black
            txtNewpass.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub txtNewpass_Leave(sender As Object, e As EventArgs) Handles txtNewpass.Leave
        If txtNewpass.Text = "" Then
            txtNewpass.Text = "New Password"
            txtNewpass.ForeColor = Color.Silver
            txtNewpass.UseSystemPasswordChar = False
        End If
    End Sub
    Private Sub txtConfirmpass_Enter(sender As Object, e As EventArgs) Handles txtConfirmpass.Enter
        If txtConfirmpass.Text = "Confirm Password" Then
            txtConfirmpass.Text = ""
            txtConfirmpass.ForeColor = Color.Black
            txtConfirmpass.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub txtConfirmpass_Leave(sender As Object, e As EventArgs) Handles txtConfirmpass.Leave
        If txtConfirmpass.Text = "" Then
            txtConfirmpass.Text = "Confirm Password"
            txtConfirmpass.ForeColor = Color.Silver
            txtConfirmpass.UseSystemPasswordChar = False
        End If
    End Sub

    Private Sub Spassword_CheckedChanged(sender As Object, e As EventArgs) Handles Spassword.CheckedChanged
        If txtCurrentpass.UseSystemPasswordChar = True And txtNewpass.UseSystemPasswordChar = True And txtConfirmpass.UseSystemPasswordChar = True Then
            txtCurrentpass.UseSystemPasswordChar = False
            txtNewpass.UseSystemPasswordChar = False
            txtConfirmpass.UseSystemPasswordChar = False
        Else
            txtCurrentpass.UseSystemPasswordChar = False
            txtNewpass.UseSystemPasswordChar = True
            txtConfirmpass.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub btnSavepass_Click(sender As Object, e As EventArgs) Handles btnSavepass.Click
        If (txtCurrentpass.Text = "" And txtNewpass.Text = "" And txtConfirmpass.Text = "") Then
            MessageBox.Show("all information are required")
        ElseIf (txtCurrentpass.Text <> password) Then
            MessageBox.Show("Wrong password")
        ElseIf (txtNewpass.Text <> txtConfirmpass.Text) Then
            MessageBox.Show("New password and Confirmation password didn't matched")
        Else
            command = New MySqlCommand()
            command.CommandText = "update tbl_user set Password = '" & txtConfirmpass.Text & "' where UserID = '" & username & "'"
            command.Connection = connection
            command.ExecuteNonQuery()
            MessageBox.Show("Password Updated")
        End If
    End Sub
End Class