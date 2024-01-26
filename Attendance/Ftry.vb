Imports AForge
Imports AForge.Video
Imports AForge.Video.DirectShow
Imports Google.Protobuf.WellKnownTypes
Imports MessagingToolkit.QRCode.Codec
Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Windows

Public Class Ftry
    Dim Fname As String
    Dim message As String
    Dim Query As String
    Dim READERs As MySqlDataReader

    Dim cam As VideoCaptureDevice
    Dim bitmap As Bitmap
    Dim reader As QRCodeDecoder
    Private Sub Ftry_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadAttendance()
        Dattendance.Columns(3).Visible = False
        Dattendance.Columns(5).Visible = False
    End Sub
    Private Sub capture(ByVal sender As System.Object, ByVal eventArgs As NewFrameEventArgs)
        bitmap = DirectCast(eventArgs.Frame.Clone(), Bitmap)
        PictureBox1.Image = DirectCast(eventArgs.Frame.Clone(), Bitmap)
    End Sub
    Public Sub search()
        If TextBox1.Text = "" Then
            MessageBox.Show("Please scan QR code!", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Try
                reloadTxt("SELECT * FROM tbl_students WHERE Student_ID='" & TextBox1.Text & "'")
                If dt.Rows.Count > 0 Then
                    reloadTxt("SELECT * FROM tbl_attendance WHERE Student_ID='" & TextBox1.Text & "' AND Date='" & Ldate.Text & "' AND StatusIn='ENTER' AND StatusOut=''")
                    If dt.Rows.Count > 0 Then
                        updates("UPDATE tbl_attendance SET TimeOut='" & TimeOfDay & "',StatusOut='LEAVE' WHERE Student_ID = '" & TextBox1.Text & "' AND Date='" & Ldate.Text & "' AND TimeOut='' AND StatusOut=''")
                        MessageBox.Show("Time out")
                    Else
                        insert("INSERT INTO tbl_attendance(Student_ID,Date,TimeIn,StatusIn,TimeOut,StatusOut)VALUES('" & TextBox1.Text & "','" & Ldate.Text & "','" & TimeOfDay & "','ENTER','','')")
                        MessageBox.Show("Time in")

                    End If
                Else
                    MessageBox.Show("Not Registered")
                End If
            Catch ex As Exception

            End Try
        End If
    End Sub

    Public Sub smsTimein()
        Dim Fname As String
        Dim message As String

        Dim READERs As MySqlDataReader
        Try
            strcon.Open()
            Dim Query As String
            Query = "SELECT * FROM tbl_students WHERE Student_ID = '" & TextBox1.Text & "'"

            Dim Com = New MySqlCommand(Query, strcon)
            READERs = Com.ExecuteReader
            While READERs.Read
                Fname = READERs.GetString("Fullname")
                message = Fname + " arrived at EAC - Cavite on " + Ldate.Text + " " + TimeOfDay + " Verified by: EAC School Admin"
                MessageBox.Show(message)
            End While

        Catch ex As Exception

        End Try
    End Sub

    Public Sub smsTimeout()
        Dim Fname As String
        Dim message As String

        Dim READERs As MySqlDataReader
        Try
            strcon.Open()
            Dim Query As String
            Query = "SELECT * FROM tbl_students WHERE Student_ID = '" & TextBox1.Text & "'"

            Dim Com = New MySqlCommand(Query, strcon)
            READERs = Com.ExecuteReader
            While READERs.Read
                Fname = READERs.GetString("Fullname")
                message = Fname + " left at EAC - Cavite on " + Ldate.Text + " " + TimeOfDay + " Verified by: EAC School Admin"
                MessageBox.Show(message)
            End While

        Catch ex As Exception

        End Try
    End Sub
    Public Sub loadAttendance()
        Try
            reload("SELECT * FROM tbl_attendance", Dattendance)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Ldate.Text = DateTime.Now.ToString("dd/MM/yyyy")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Call search()
    End Sub

    Private Sub Ftry_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Hide()
            Flogin.Show()
        End If
    End Sub

    Private Sub btnScan_Click(sender As Object, e As EventArgs) Handles btnScan.Click
        Try
            reader = New QRCodeDecoder
            TextBox1.Text = reader.Decode(New Data.QRCodeBitmapImage(PictureBox1.Image))
            MessageBox.Show("Decoded")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnCamera_Click(sender As Object, e As EventArgs) Handles btnCamera.Click
        Dim camera As VideoCaptureDeviceForm = New VideoCaptureDeviceForm
        If camera.ShowDialog() = Windows.Forms.DialogResult.OK Then
            cam = camera.VideoDevice
            AddHandler cam.NewFrame, New NewFrameEventHandler(AddressOf Capture)
            cam.Start()
        End If
    End Sub
End Class