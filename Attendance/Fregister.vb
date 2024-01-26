Public Class Fregister
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
        rad.AddLine(btnRegisterNS.Width, 20, btn.Width, btn.Height - 10)
        'right bottom corner
        rad.AddArc(New Rectangle(btn.Width - 55, btn.Height - 55, 55, 55), 0, 90)
        'left bottom corner
        rad.AddLine(btn.Width - 10, btn.Width, 20, btn.Height)

        rad.AddArc(New Rectangle(0, btn.Height - 50, 50, 50), 90, 90)
        rad.CloseFigure()
        btnRegisterNS.Region = New Region(rad)

    End Sub

    Private Sub Fregister_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RCB(btnRegisterNS)
    End Sub
    Private Sub txtStudentID_Enter(sender As Object, e As EventArgs) Handles txtStudentID.Enter
        If txtStudentID.Text = "##-#-#####" Then
            txtStudentID.Text = ""
            txtStudentID.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtStudentID_Leave(sender As Object, e As EventArgs) Handles txtStudentID.Leave
        If txtStudentID.Text = "" Then
            txtStudentID.Text = "##-#-#####"
            txtStudentID.ForeColor = Color.Silver
        End If
    End Sub

    Private Sub txtSection_Enter(sender As Object, e As EventArgs) Handles txtSection.Enter
        If txtSection.Text = "XXXXX #-#" Then
            txtSection.Text = ""
            txtSection.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtSection_Leave(sender As Object, e As EventArgs) Handles txtSection.Leave
        If txtSection.Text = "" Then
            txtSection.Text = "XXXXX #-#"
            txtSection.ForeColor = Color.Silver
        End If
    End Sub

    Private Sub txtEmail_Enter(sender As Object, e As EventArgs) Handles txtEmail.Enter
        If txtEmail.Text = "xxxxxxxxxx.cvt@eac.edu.ph" Then
            txtEmail.Text = ""
            txtEmail.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtEmail_Leave(sender As Object, e As EventArgs) Handles txtEmail.Leave
        If txtEmail.Text = "" Then
            txtEmail.Text = "xxxxxxxxxx.cvt@eac.edu.ph"
            txtEmail.ForeColor = Color.Silver
        End If
    End Sub

    Private Sub txtStudentName_Enter(sender As Object, e As EventArgs) Handles txtStudentName.Enter
        If txtStudentName.Text = "Surname, First name, M.I." Then
            txtStudentName.Text = ""
            txtStudentName.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtStudentName_Leave(sender As Object, e As EventArgs) Handles txtStudentName.Leave
        If txtStudentName.Text = "" Then
            txtStudentName.Text = "Surname, First name, M.I."
            txtStudentName.ForeColor = Color.Silver
        End If
    End Sub

    Private Sub txtEmergency_Enter(sender As Object, e As EventArgs) Handles txtEmergency.Enter
        If txtEmergency.Text = "#### ### ####" Then
            txtEmergency.Text = ""
            txtEmergency.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtEmergency_Leave(sender As Object, e As EventArgs) Handles txtEmergency.Leave
        If txtEmergency.Text = "" Then
            txtEmergency.Text = "#### ### ####"
            txtEmergency.ForeColor = Color.Silver
        End If
    End Sub

    Private Sub btnRegisterNS_Click(sender As Object, e As EventArgs) Handles btnRegisterNS.Click
        Try
            insert("INSERT INTO tbl_students(Student_ID,Fullname,Section,Emergency,Email)VALUES('" & txtStudentID.Text & "','" & txtStudentName.Text & "','" & txtSection.Text & "','" & txtEmergency.Text & "','" & txtEmail.Text & "')")
        Catch ex As Exception

        End Try
    End Sub
End Class