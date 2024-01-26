Imports System.Windows.Controls
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient

Public Class Form1
    Dim reader As MySqlDataReader
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadAttendance()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Ldate.Text = DateTime.Now.ToString("dd/MM/yyyy")
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtStudentID.Text = "" Then
            MessageBox.Show("Please scan QR code!", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Try
                reloadTxt("SELECT * FROM tbl_students WHERE Student_ID='" & txtStudentID.Text & "'")
                If dt.Rows.Count > 0 Then
                    timeout()
                    Call Form1_Load(sender, e)
                Else
                    MessageBox.Show("Student ID not Registered", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            Catch ex As Exception

            End Try
        End If
    End Sub

    Public Sub timein()
        insert("INSERT INTO tbl_attendance(Student_ID,Date,TimeIn,StatusIn,TimeOut,StatusOut)VALUES('" & txtStudentID.Text & "','" & Ldate.Text & "','" & TimeOfDay & "','ENTER','','')")

    End Sub
    Public Sub TI()
        reloadTxt("SELECT * FROM tbl_attendance WHERE Student_ID='" & txtStudentID.Text & "' AND Date='" & Ldate.Text & "' AND StatusIn='ENTER' AND StatusOut='LEAVE'")
        If dt.Rows.Count > 0 Then
            timein()
        End If
    End Sub
    Public Sub timeout()
        reloadTxt("SELECT * FROM tbl_attendance WHERE Student_ID='" & txtStudentID.Text & "' AND Date='" & Ldate.Text & "' AND StatusIn='ENTER'")
        If dt.Rows.Count > 0 Then
            updates("UPDATE tbl_attendance SET TimeOut='" & TimeOfDay & "',StatusOut='LEAVE' WHERE Student_ID = '" & txtStudentID.Text & "' AND Date='" & Ldate.Text & "' AND TimeOut='' AND StatusOut=''")

            Try
                TI()
            Catch ex As Exception

            End Try
        Else
            timein()

        End If
    End Sub

    Public Sub loadAttendance()
        Try
            reload("SELECT * FROM tbl_attendance", Dattendance)
        Catch ex As Exception

        End Try
    End Sub
End Class