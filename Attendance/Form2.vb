Imports AForge
Imports AForge.Video
Imports AForge.Video.DirectShow
Imports Google.Protobuf.WellKnownTypes
Imports MessagingToolkit.QRCode.Codec
Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Windows

Imports System.Net
Imports System.Net.Mail

Public Class Form2
    Dim cam As VideoCaptureDevice
    Dim bitmap As Bitmap
    Dim reader As QRCodeDecoder

    Private Sub capture(ByVal sender As System.Object, ByVal eventArgs As NewFrameEventArgs)
        bitmap = DirectCast(eventArgs.Frame.Clone(), Bitmap)
        PictureBox1.Image = DirectCast(eventArgs.Frame.Clone(), Bitmap)
    End Sub
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadAttendance()
    End Sub

    Private Sub btnCamera_Click(sender As Object, e As EventArgs) Handles btnCamera.Click
        Dim camera As VideoCaptureDeviceForm = New VideoCaptureDeviceForm
        If camera.ShowDialog() = Windows.Forms.DialogResult.OK Then
            cam = camera.VideoDevice
            AddHandler cam.NewFrame, New NewFrameEventHandler(AddressOf capture)
            cam.Start()
        End If
    End Sub
    Private Sub btnScan_Click(sender As Object, e As EventArgs) Handles btnScan.Click
        Try
            reader = New QRCodeDecoder
            txtStudentID.Text = reader.Decode(New Data.QRCodeBitmapImage(PictureBox1.Image))
            MessageBox.Show("Decoded")
        Catch ex As Exception

        End Try
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Ldate.Text = DateTime.Now.ToString("dd/MM/yyyy")
    End Sub
    Public Sub attendance()
        Try
            reloadTxt("SELECT * FROM tbl_students WHERE Student_ID = '" & txtStudentID.Text & "'")
            If dt.Rows.Count > 0 Then
                reloadTxt("SELECT * FROM tbl_attendance WHERE Student_ID='" & txtStudentID.Text & "' AND Date='" & Ldate.Text & "' AND StatusIn='ENTER' AND StatusOut=''")
                If dt.Rows.Count > 0 Then
                    Try
                        reloadTxt("SELECT * FROM tbl_attendance WHERE Student_ID='" & txtStudentID.Text & "' AND Date='" & Ldate.Text & "' AND StatusIn='ENTER' AND StatusOut=''")
                        If dt.Rows.Count > 0 Then
                            updates("UPDATE tbl_attendance SET TimeOut='" & TimeOfDay & "',StatusOut='LEAVE' WHERE Student_ID = '" & txtStudentID.Text & "' AND Date='" & Ldate.Text & "' AND TimeOut='' AND StatusOut=''")
                            SendEmailOut(txtStudentID.Text)
                            loadAttendance()

                        End If
                    Catch ex As Exception

                    End Try
                Else
                    insert("INSERT INTO tbl_attendance(Student_ID,Date,TimeIn,StatusIn,TimeOut,StatusOut)VALUES('" & txtStudentID.Text & "','" & Ldate.Text & "','" & TimeOfDay & "','ENTER','','')")
                    SendEmailIn(txtStudentID.Text)
                    loadAttendance()
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub
    Public Sub loadAttendance()
        Try
            reload("SELECT * FROM tbl_attendance", Dattendance)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub btnAttendance_Click(sender As Object, e As EventArgs) Handles btnAttendance.Click
        Try
            If txtStudentID.Text = "" Then
                MessageBox.Show("Please scan QR code!", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                attendance()
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub SendEmailIn(studentID As String)
        ' Set your Gmail credentials
        Dim smtpUsername As String = "ricco0829@gmail.com"
        Dim smtpPassword As String = "sizn uuso ojxn wtuo"


        ' Create the SMTP client
        Dim smtpClient As New SmtpClient("smtp.gmail.com")
        smtpClient.Port = 587
        smtpClient.Credentials = New NetworkCredential(smtpUsername, smtpPassword)
        smtpClient.EnableSsl = True

        Try

            ' Create the email message
            reloadTxt("SELECT * FROM tbl_students WHERE Student_ID='" & txtStudentID.Text & "'")
            Dim Eemail As String = dt.Rows(0)("Emergency_Email").ToString()
            Dim FN As String = dt.Rows(0)("Fullname").ToString()
            Dim TIn As String = TimeOfDay
            Dim Day As String = Ldate.Text
            Dim mail As New MailMessage()
            mail.From = New MailAddress("ricco0829@gmail.com")
            mail.[To].Add(Eemail) ' Change to the actual recipient email address
            mail.Subject = "Attendance Notification"
            mail.IsBodyHtml = True
            mail.Body = $"<p><strong>Student with ID:</strong> {studentID}</p><p>{FN} has successfully Timed In - {TIn} {Day}.</p>"

            ' Send the email
            Try
                smtpClient.Send(mail)
                MessageBox.Show("Attendance email sent successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show($"Failed to send email. Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Catch ex As Exception

        End Try

    End Sub
    Private Sub SendEmailOut(studentID As String)
        ' Set your Gmail credentials
        Dim smtpUsername As String = "ricco0829@gmail.com"
        Dim smtpPassword As String = "sizn uuso ojxn wtuo"


        ' Create the SMTP client
        Dim smtpClient As New SmtpClient("smtp.gmail.com")
        smtpClient.Port = 587
        smtpClient.Credentials = New NetworkCredential(smtpUsername, smtpPassword)
        smtpClient.EnableSsl = True

        Try

            ' Create the email message
            reloadTxt("SELECT * FROM tbl_students WHERE Student_ID='" & txtStudentID.Text & "'")
            Dim Eemail As String = dt.Rows(0)("Emergency_Email").ToString()
            Dim FN As String = dt.Rows(0)("Fullname").ToString()
            Dim TIn As String = TimeOfDay
            Dim Day As String = Ldate.Text
            Dim mail As New MailMessage()
            mail.From = New MailAddress("ricco0829@gmail.com")
            mail.[To].Add(Eemail) ' Change to the actual recipient email address
            mail.Subject = "Attendance Notification"
            mail.IsBodyHtml = True
            mail.Body = $"<p><strong>Student with ID:</strong> {studentID}</p><p>{FN} has successfully Timed Out - {TIn} {Day}.</p>"

            ' Send the email
            Try
                smtpClient.Send(mail)
                MessageBox.Show("Attendance email sent successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show($"Failed to send email. Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Catch ex As Exception

        End Try

    End Sub
End Class