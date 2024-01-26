Imports System.Drawing.Printing

Public Class Fqr

    Private bitmap As Bitmap
    Private WithEvents ppd As New PrintPreviewDialog

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
        rad.AddLine(btnGenerate.Width, 20, btn.Width, btn.Height - 10)
        'right bottom corner
        rad.AddArc(New Rectangle(btn.Width - 55, btn.Height - 55, 55, 55), 0, 90)
        'left bottom corner
        rad.AddLine(btn.Width - 10, btn.Width, 20, btn.Height)

        rad.AddArc(New Rectangle(0, btn.Height - 50, 50, 50), 90, 90)
        rad.CloseFigure()
        btnGenerate.Region = New Region(rad)
        btnSave.Region = New Region(rad)
    End Sub
    Private Sub Fqr_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RCB(btnGenerate)
        RCB(btnSave)

    End Sub

    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        Dim generator As New MessagingToolkit.Barcode.BarcodeEncoder
        generator.BackColor = Color.White
        generator.LabelFont = New Font("Arial", 7, FontStyle.Regular)
        generator.IncludeLabel = True
        generator.CustomLabel = txtStudentID.Text

        Try
            PictureQR.Image = New Bitmap(generator.Encode(MessagingToolkit.Barcode.BarcodeFormat.QRCode, txtStudentID.Text))
        Catch ex As Exception
            PictureQR.Image = Nothing
        End Try
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim SD As New SaveFileDialog
        SD.FileName = txtStudentID.Text
        SD.Filter = "PNG Files only (*.png)|*.png"
        If SD.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Try
                PictureQR.Image.Save(SD.FileName, System.Drawing.Imaging.ImageFormat.Png)
                MessageBox.Show("Successfully Saved")
            Catch ex As Exception

            End Try
        End If

    End Sub

    Private Sub PictureQR_Click(sender As Object, e As EventArgs) Handles PictureQR.Click

    End Sub
End Class