Imports System.Collections.ObjectModel
Imports MySql.Data.MySqlClient
Imports Mysqlx

Public Class Fmanualattendance
    Dim connection As MySqlConnection
    Dim adapter As MySqlDataAdapter
    Dim ds As DataSet
    Dim password As String
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
        rad.AddLine(btnSave.Width, 20, btn.Width, btn.Height - 10)
        'right bottom corner
        rad.AddArc(New Rectangle(btn.Width - 55, btn.Height - 55, 55, 55), 0, 90)
        'left bottom corner
        rad.AddLine(btn.Width - 10, btn.Width, 20, btn.Height)

        rad.AddArc(New Rectangle(0, btn.Height - 50, 50, 50), 90, 90)
        rad.CloseFigure()
        btnSave.Region = New Region(rad)
    End Sub
    Private Sub Fmanualattendance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RCB(btnSave)
        password = Flogin.txtPassword.Text
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        If TxtID.Text = "" Then
            MessageBox.Show("Please enter Student ID", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Try
                reloadTxt("SELECT * FROM tbl_students WHERE Student_ID='" & TxtID.Text & "'")
                If dt.Rows.Count > 0 Then
                    If RadioButton1.Checked = True Then
                        If txtAdmin.Text = password Then
                            insert("INSERT INTO tbl_attendance(Student_ID,Date,TimeIn,StatusIn,TimeOut,StatusOut)VALUES('" & TxtID.Text & "','" & Ldate.Text & "','" & TimeOfDay & "','ENTER','','')")
                        End If
                    ElseIf RadioButton2.Checked = True Then
                        If txtAdmin.Text = password Then
                            updates("UPDATE tbl_attendance SET TimeOut='" & TimeOfDay & "',StatusOut='LEAVE' WHERE Student_ID = '" & TxtID.Text & "' AND Date='" & Ldate.Text & "' AND TimeOut='' AND StatusOut=''")
                        End If
                    End If
                Else
                    MessageBox.Show("Student ID not Registered", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            Catch ex As Exception

            End Try
        End If

        Dim READER As MySqlDataReader
        Try
            strcon.Open()
            Dim Query As String
            Query = "SELECT * FROM tbl_students WHERE Student_ID = '" & TxtID.Text & "'"

            Dim Com = New MySqlCommand(Query, strcon)
            READER = Com.ExecuteReader
            While READER.Read
                txtName.Text = READER.GetString("Fullname")
                txtSection.Text = READER.GetString("Section")
            End While
        Catch ex As Exception

        End Try

    End Sub
    Public Sub timein()
        insert("INSERT INTO tbl_attendance(Student_ID,Date,TimeIn,StatusIn,TimeOut,StatusOut)VALUES('" & TxtID.Text & "','" & Ldate.Text & "','" & TimeOfDay & "','ENTER','','')")

    End Sub
    Public Sub TI()
        reloadTxt("SELECT * FROM tbl_attendance WHERE Student_ID='" & TxtID.Text & "' AND Date='" & Ldate.Text & "' AND StatusIn='ENTER' AND StatusOut='LEAVE'")
        If dt.Rows.Count > 0 Then
            timein()
        End If
    End Sub
    Public Sub timeout()
        reloadTxt("SELECT * FROM tbl_attendance WHERE Student_ID='" & TxtID.Text & "' AND Date='" & Ldate.Text & "' AND StatusIn='ENTER'")
        If dt.Rows.Count > 0 Then
            updates("UPDATE tbl_attendance SET TimeOut='" & TimeOfDay & "',StatusOut='LEAVE' WHERE Student_ID = '" & TxtID.Text & "' AND Date='" & Ldate.Text & "' AND TimeOut='' AND StatusOut=''")
            Try
                TI()
            Catch ex As Exception

            End Try
        Else
            timein()
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Ldate.Text = DateTime.Now.ToString("dd/MM/yyyy")
    End Sub
End Class