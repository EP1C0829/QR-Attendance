Imports AForge
Imports AForge.Video
Imports AForge.Video.DirectShow
Imports Google.Protobuf.WellKnownTypes
Imports MessagingToolkit.QRCode.Codec
Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Net.Mail
Imports System.Net



Public Class Fqrattendance

    Dim cam As VideoCaptureDevice
    Dim bitmap As Bitmap
    Dim reader As QRCodeDecoder

    Private Sub capture(ByVal sender As System.Object, ByVal eventArgs As NewFrameEventArgs)
        bitmap = DirectCast(eventArgs.Frame.Clone(), Bitmap)
        PictureBox1.Image = DirectCast(eventArgs.Frame.Clone(), Bitmap)
    End Sub

    Private Sub Fqrattendance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadAttendance()
    End Sub

    Private Sub Camera_Click(sender As Object, e As EventArgs) Handles Camera.Click
        Dim camera As VideoCaptureDeviceForm = New VideoCaptureDeviceForm
        If camera.ShowDialog() = Windows.Forms.DialogResult.OK Then
            cam = camera.VideoDevice
            AddHandler cam.NewFrame, New NewFrameEventHandler(AddressOf capture)
            cam.Start()
        End If
    End Sub

    Private Sub ScanButton_Click(sender As Object, e As EventArgs) Handles ScanButton.Click
        'PictureBox2.Image = PictureBox1.Image
        Try

            reader = New QRCodeDecoder
            txtStudentID.Text = reader.Decode(New Data.QRCodeBitmapImage(PictureBox1.Image))
            MessageBox.Show("decoded")

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Ldate.Text = DateTime.Now.ToString("dd/MM/yyyy")
    End Sub

    Private Sub SendEmail(ByVal subject As String, ByVal body As String)
        Dim senderEmail As String = "ricco0829@gmail.com"
        Dim senderPassword As String = "611-Dav1darc3"
        Dim recipientEmail As String = "skydoesminecraft0829@gmail.com"

        Dim mail As New MailMessage()
        mail.From = New MailAddress(senderEmail)
        mail.To.Add(recipientEmail)
        mail.Subject = subject
        mail.Body = body

        Dim smtpClient As New SmtpClient("smtp.gmail.com")
        smtpClient.Port = 587
        smtpClient.Credentials = New NetworkCredential(senderEmail, senderPassword)
        smtpClient.EnableSsl = True

        Try
            smtpClient.Send(mail)
            Console.WriteLine("Email sent successfully.")
        Catch ex As Exception
            Console.WriteLine("Error sending email: " & ex.Message)
        End Try
    End Sub

    ' Function to send attendance email
    Private Sub SendAttendanceEmail(ByVal studentID As String, ByVal ldate As String, ByVal timeIn As String, ByVal timeOut As String)
        Dim subject As String = "Attendance Recorded"
        Dim body As String = $"Student ID: {studentID}" & vbCrLf &
                            $"Date: {ldate}" & vbCrLf &
                            $"Time In: {timeIn}" & vbCrLf &
                            $"Time Out: {timeOut}"

        SendEmail(subject, body)
    End Sub

    Private Sub InOutButton_Click(sender As Object, e As EventArgs) Handles InOutButton.Click
        If txtStudentID.Text = "" Then
            MessageBox.Show("Please scan QR code!", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Try
                reloadTxt("SELECT * FROM tbl_students WHERE Student_ID='" & txtStudentID.Text & "'")
                If dt.Rows.Count > 0 Then
                    timeout()
                    loadAttendance()

                    reloadTxt("SELECT * FROM tbl_attendance WHERE Student_ID='" & txtStudentID.Text & "' AND Date='" & Ldate.Text & "' ORDER BY TimeIn DESC LIMIT 1")
                    If dt.Rows.Count > 0 Then
                        Dim timeIn As String = dt.Rows(0)("TimeIn").ToString()
                        Dim timeOut As String = dt.Rows(0)("TimeOut").ToString()
                        SendAttendanceEmail(txtStudentID.Text, Ldate.Text, timeIn, timeOut)
                    End If
                Else
                    MessageBox.Show("Student ID not Registered", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    loadAttendance()
                    loadAttendance()
                End If
            Catch ex As Exception
                MsgBox("something went wrong")
            End Try
        End If
    End Sub
    Public Sub timein()
        insert("INSERT INTO tbl_attendance(Student_ID,[Date],TimeIn,StatusIn,TimeOut,StatusOut)VALUES('" & txtStudentID.Text & "','" & Ldate.Text & "','" & TimeOfDay & "','ENTER','','')")
        'smsTimein()
        loadAttendance()
    End Sub
    Public Sub TI()
        reloadTxt("SELECT * FROM tbl_attendance WHERE Student_ID='" & txtStudentID.Text & "' AND [Date]='" & Ldate.Text & "' AND StatusIn='ENTER' AND StatusOut='LEAVE'")
        If dt.Rows.Count > 0 Then
            timein()
            'smsTimein()
            loadAttendance()
        End If
    End Sub
    Public Sub timeout()
        reloadTxt("SELECT * FROM tbl_attendance WHERE Student_ID='" & txtStudentID.Text & "' AND [Date]='" & Ldate.Text & "' AND StatusIn='ENTER'")
        If dt.Rows.Count > 0 Then
            updates("UPDATE tbl_attendance SET TimeOut='" & TimeOfDay & "',StatusOut='LEAVE' WHERE Student_ID = '" & txtStudentID.Text & "' AND [Date]='" & Ldate.Text & "' AND TimeOut='' AND StatusOut=''")
            'smsTimeout()
            loadAttendance()
            Try
                TI()
                loadAttendance()
            Catch ex As Exception

            End Try
        Else
            timein()
            loadAttendance()
        End If
    End Sub

    Public Sub loadAttendance()
        Try
            reload("SELECT * FROM tbl_attendance", Dattendance)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs)
        loadAttendance()
    End Sub


    'Public Sub smsTimein()
    '    Dim Fname As String
    '    Dim message As String

    '    Dim READER As MySqlDataReader
    '    Try
    '        strcon.Open()
    '        Dim Query As String
    '        Query = "SELECT * FROM tbl_students WHERE Student_ID = '" & txtStudentID.Text & "'"

    '        Dim Com = New MySqlCommand(Query, strcon)
    '        READER = Com.ExecuteReader
    '        While READER.Read
    '            Fname = READER.GetString("Fullname")
    '            message = Fname + "arrived at EAC - Cavite on " + Ldate.Text + TimeOfDay + "Verified by: EAC School Admin"
    '            MessageBox.Show(message)
    '        End While

    '    Catch ex As Exception

    '    End Try

    'End Sub

    'Public Sub smsTimeout()
    '    Dim Fname As String
    '    Dim message As String

    '    Dim READER As MySqlDataReader
    '    Try
    '        strcon.Open()
    '        Dim Query As String
    '        Query = "SELECT * FROM tbl_students WHERE Student_ID = '" & txtStudentID.Text & "'"

    '        Dim Com = New MySqlCommand(Query, strcon)
    '        READER = Com.ExecuteReader
    '        While READER.Read
    '            Fname = READER.GetString("Fullname")
    '            message = Fname + "left at EAC - Cavite on " + Ldate.Text + TimeOfDay + "Verified by: EAC School Admin"
    '            MessageBox.Show(message)
    '        End While

    '    Catch ex As Exception

    '    End Try
    'End Sub


End Class