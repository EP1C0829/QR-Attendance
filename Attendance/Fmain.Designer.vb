<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fmain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Fmain))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.Pleft = New System.Windows.Forms.Panel()
        Me.btnQRattendance = New System.Windows.Forms.Button()
        Me.btnMA = New System.Windows.Forms.Button()
        Me.btnHome = New System.Windows.Forms.Button()
        Me.btnQR = New System.Windows.Forms.Button()
        Me.btnSMS = New System.Windows.Forms.Button()
        Me.btnStudent = New System.Windows.Forms.Button()
        Me.btnReport = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.Pleft.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.White
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.SettingsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1176, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LogOutToolStripMenuItem})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(64, 20)
        Me.ToolStripMenuItem1.Text = "Account"
        '
        'LogOutToolStripMenuItem
        '
        Me.LogOutToolStripMenuItem.Name = "LogOutToolStripMenuItem"
        Me.LogOutToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.LogOutToolStripMenuItem.Text = "Log Out"
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.SettingsToolStripMenuItem.Text = "Settings"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'Pleft
        '
        Me.Pleft.BackColor = System.Drawing.Color.Tomato
        Me.Pleft.BackgroundImage = CType(resources.GetObject("Pleft.BackgroundImage"), System.Drawing.Image)
        Me.Pleft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Pleft.Controls.Add(Me.btnQRattendance)
        Me.Pleft.Controls.Add(Me.btnMA)
        Me.Pleft.Controls.Add(Me.btnHome)
        Me.Pleft.Controls.Add(Me.btnQR)
        Me.Pleft.Controls.Add(Me.btnSMS)
        Me.Pleft.Controls.Add(Me.btnStudent)
        Me.Pleft.Controls.Add(Me.btnReport)
        Me.Pleft.Dock = System.Windows.Forms.DockStyle.Left
        Me.Pleft.Location = New System.Drawing.Point(0, 24)
        Me.Pleft.Name = "Pleft"
        Me.Pleft.Size = New System.Drawing.Size(233, 631)
        Me.Pleft.TabIndex = 18
        '
        'btnQRattendance
        '
        Me.btnQRattendance.BackColor = System.Drawing.Color.LightGray
        Me.btnQRattendance.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.btnQRattendance.ForeColor = System.Drawing.Color.Black
        Me.btnQRattendance.Location = New System.Drawing.Point(17, 467)
        Me.btnQRattendance.Name = "btnQRattendance"
        Me.btnQRattendance.Size = New System.Drawing.Size(198, 36)
        Me.btnQRattendance.TabIndex = 17
        Me.btnQRattendance.Text = "QR Attendance"
        Me.btnQRattendance.UseVisualStyleBackColor = False
        '
        'btnMA
        '
        Me.btnMA.BackColor = System.Drawing.Color.LightGray
        Me.btnMA.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.btnMA.ForeColor = System.Drawing.Color.Black
        Me.btnMA.Location = New System.Drawing.Point(17, 522)
        Me.btnMA.Name = "btnMA"
        Me.btnMA.Size = New System.Drawing.Size(198, 36)
        Me.btnMA.TabIndex = 13
        Me.btnMA.Text = "Manual Attendance"
        Me.btnMA.UseVisualStyleBackColor = False
        '
        'btnHome
        '
        Me.btnHome.BackColor = System.Drawing.Color.LightGray
        Me.btnHome.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.btnHome.ForeColor = System.Drawing.Color.Black
        Me.btnHome.Location = New System.Drawing.Point(17, 247)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(198, 36)
        Me.btnHome.TabIndex = 11
        Me.btnHome.Text = "Home"
        Me.btnHome.UseVisualStyleBackColor = False
        '
        'btnQR
        '
        Me.btnQR.BackColor = System.Drawing.Color.LightGray
        Me.btnQR.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.btnQR.ForeColor = System.Drawing.Color.Black
        Me.btnQR.Location = New System.Drawing.Point(17, 302)
        Me.btnQR.Name = "btnQR"
        Me.btnQR.Size = New System.Drawing.Size(198, 36)
        Me.btnQR.TabIndex = 16
        Me.btnQR.Text = "QR Generator"
        Me.btnQR.UseVisualStyleBackColor = False
        '
        'btnSMS
        '
        Me.btnSMS.BackColor = System.Drawing.Color.LightGray
        Me.btnSMS.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.btnSMS.ForeColor = System.Drawing.Color.Black
        Me.btnSMS.Location = New System.Drawing.Point(17, 577)
        Me.btnSMS.Name = "btnSMS"
        Me.btnSMS.Size = New System.Drawing.Size(198, 36)
        Me.btnSMS.TabIndex = 12
        Me.btnSMS.Text = "SMS Notification"
        Me.btnSMS.UseVisualStyleBackColor = False
        '
        'btnStudent
        '
        Me.btnStudent.BackColor = System.Drawing.Color.LightGray
        Me.btnStudent.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.btnStudent.ForeColor = System.Drawing.Color.Black
        Me.btnStudent.Location = New System.Drawing.Point(17, 357)
        Me.btnStudent.Name = "btnStudent"
        Me.btnStudent.Size = New System.Drawing.Size(198, 36)
        Me.btnStudent.TabIndex = 15
        Me.btnStudent.Text = "Students"
        Me.btnStudent.UseVisualStyleBackColor = False
        '
        'btnReport
        '
        Me.btnReport.BackColor = System.Drawing.Color.LightGray
        Me.btnReport.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.btnReport.ForeColor = System.Drawing.Color.Black
        Me.btnReport.Location = New System.Drawing.Point(17, 412)
        Me.btnReport.Name = "btnReport"
        Me.btnReport.Size = New System.Drawing.Size(198, 36)
        Me.btnReport.TabIndex = 14
        Me.btnReport.Text = "Reports"
        Me.btnReport.UseVisualStyleBackColor = False
        '
        'Fmain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(1176, 655)
        Me.Controls.Add(Me.Pleft)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "Fmain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Student Attendance Monitoring System - EAC Cavite"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Pleft.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents LogOutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SettingsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents btnHome As Button
    Friend WithEvents btnSMS As Button
    Friend WithEvents btnMA As Button
    Friend WithEvents btnReport As Button
    Friend WithEvents btnStudent As Button
    Friend WithEvents btnQR As Button
    Friend WithEvents Pleft As Panel
    Friend WithEvents btnQRattendance As Button
End Class
