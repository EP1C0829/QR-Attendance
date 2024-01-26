<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.txtStudentID = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Ldate = New System.Windows.Forms.Label()
        Me.btnAttendance = New System.Windows.Forms.Button()
        Me.Dattendance = New System.Windows.Forms.DataGridView()
        Me.btnCamera = New System.Windows.Forms.Button()
        Me.btnScan = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dattendance, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtStudentID
        '
        Me.txtStudentID.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.txtStudentID.Location = New System.Drawing.Point(11, 145)
        Me.txtStudentID.Name = "txtStudentID"
        Me.txtStudentID.Size = New System.Drawing.Size(281, 38)
        Me.txtStudentID.TabIndex = 13
        Me.txtStudentID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.Label2.Location = New System.Drawing.Point(5, 101)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(272, 31)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Scanned Student No."
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(11, 197)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(281, 269)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Ldate
        '
        Me.Ldate.AutoSize = True
        Me.Ldate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Ldate.Location = New System.Drawing.Point(850, 174)
        Me.Ldate.Name = "Ldate"
        Me.Ldate.Size = New System.Drawing.Size(44, 20)
        Me.Ldate.TabIndex = 18
        Me.Ldate.Text = "Date"
        '
        'btnAttendance
        '
        Me.btnAttendance.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.btnAttendance.Location = New System.Drawing.Point(310, 145)
        Me.btnAttendance.Name = "btnAttendance"
        Me.btnAttendance.Size = New System.Drawing.Size(109, 38)
        Me.btnAttendance.TabIndex = 17
        Me.btnAttendance.Text = "In/Out"
        Me.btnAttendance.UseVisualStyleBackColor = True
        '
        'Dattendance
        '
        Me.Dattendance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dattendance.Location = New System.Drawing.Point(298, 197)
        Me.Dattendance.Name = "Dattendance"
        Me.Dattendance.Size = New System.Drawing.Size(636, 328)
        Me.Dattendance.TabIndex = 16
        '
        'btnCamera
        '
        Me.btnCamera.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.btnCamera.Location = New System.Drawing.Point(11, 482)
        Me.btnCamera.Name = "btnCamera"
        Me.btnCamera.Size = New System.Drawing.Size(119, 43)
        Me.btnCamera.TabIndex = 14
        Me.btnCamera.Text = "Camera"
        Me.btnCamera.UseVisualStyleBackColor = True
        '
        'btnScan
        '
        Me.btnScan.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.btnScan.Location = New System.Drawing.Point(168, 482)
        Me.btnScan.Name = "btnScan"
        Me.btnScan.Size = New System.Drawing.Size(124, 43)
        Me.btnScan.TabIndex = 15
        Me.btnScan.Text = "Scan"
        Me.btnScan.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(939, 627)
        Me.Controls.Add(Me.btnScan)
        Me.Controls.Add(Me.btnCamera)
        Me.Controls.Add(Me.txtStudentID)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Ldate)
        Me.Controls.Add(Me.btnAttendance)
        Me.Controls.Add(Me.Dattendance)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form2"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dattendance, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtStudentID As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Ldate As Label
    Friend WithEvents btnAttendance As Button
    Friend WithEvents Dattendance As DataGridView
    Friend WithEvents btnCamera As Button
    Friend WithEvents btnScan As Button
End Class
