Public Class Fmain

    Private Sub RCB(btn As Button)
        btn.FlatStyle = FlatStyle.Flat
        btn.FlatAppearance.BorderSize = 0
        btn.Cursor = Cursors.Hand

        Dim rad As New Drawing2D.GraphicsPath
        rad.StartFigure()
        'left top corner
        rad.AddArc(New Rectangle(0, 0, 30, 30), 180, 90)
        rad.AddLine(10, 0, btn.Width - 20, 0)
        'right top corner
        rad.AddArc(New Rectangle(btn.Width - 35, 0, 35, 35), -90, 90)
        rad.AddLine(btnHome.Width, 20, btn.Width, btn.Height - 10)
        'right bottom corner
        rad.AddArc(New Rectangle(btn.Width - 35, btn.Height - 35, 35, 35), 0, 90)
        'left bottom corner
        rad.AddLine(btn.Width - 10, btn.Width, 20, btn.Height)

        rad.AddArc(New Rectangle(0, btn.Height - 30, 30, 30), 90, 90)
        rad.CloseFigure()
        btnHome.Region = New Region(rad)
        btnQR.Region = New Region(rad)
        btnStudent.Region = New Region(rad)
        btnReport.Region = New Region(rad)
        btnQRattendance.Region = New Region(rad)
        btnMA.Region = New Region(rad)
        btnSMS.Region = New Region(rad)
    End Sub

    Private Sub Fmain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Flogin.Hide()
        RCB(btnHome)
        RCB(btnQR)
        RCB(btnStudent)
        RCB(btnReport)
        RCB(btnQRattendance)
        RCB(btnMA)
        RCB(btnSMS)
        With Fhome
            .MdiParent = Me
            .Show()
            .Focus()
        End With
    End Sub
    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click

    End Sub

    Private Sub LogOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogOutToolStripMenuItem.Click
        Dim oForm As New Flogin
        oForm.Show()
        Me.Hide()
    End Sub

    Private Sub SettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SettingsToolStripMenuItem.Click
        Dim oForm As New Faccountsettings
        oForm.Show()
    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        With Fhome
            .MdiParent = Me
            .Show()
            .Focus()
        End With
    End Sub
    Private Sub btnQR_Click(sender As Object, e As EventArgs) Handles btnQR.Click
        With Fqr
            .MdiParent = Me
            .Show()
            .Focus()
        End With
    End Sub

    Private Sub btnStudent_Click(sender As Object, e As EventArgs) Handles btnStudent.Click
        With Fstudents
            .MdiParent = Me
            .Show()
            .Focus()
        End With
    End Sub

    Private Sub btnReport_Click(sender As Object, e As EventArgs) Handles btnReport.Click
        With Freports
            .MdiParent = Me
            .Show()
            .Focus()
        End With
    End Sub

    Private Sub btnQRattendance_Click(sender As Object, e As EventArgs) Handles btnQRattendance.Click
        With Form2
            .MdiParent = Me
            .Show()
            .Focus()
        End With
    End Sub

    Private Sub btnMA_Click(sender As Object, e As EventArgs) Handles btnMA.Click
        With Fmanualattendance
            .MdiParent = Me
            .Show()
            .Focus()
        End With
    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub btnSMS_Click(sender As Object, e As EventArgs) Handles btnSMS.Click
        With Fsmsnotification
            .MdiParent = Me
            .Show()
            .Focus()
        End With
    End Sub
End Class