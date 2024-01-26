<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Fqrattendance
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Fqrattendance))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtStudentID = New System.Windows.Forms.TextBox()
        Me.Camera = New System.Windows.Forms.Button()
        Me.ScanButton = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Dattendance = New System.Windows.Forms.DataGridView()
        Me.InOutButton = New System.Windows.Forms.Button()
        Me.Ldate = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dattendance, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 162)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(281, 269)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.Label2.Location = New System.Drawing.Point(6, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(272, 31)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Scanned Student No."
        '
        'txtStudentID
        '
        Me.txtStudentID.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.txtStudentID.Location = New System.Drawing.Point(12, 110)
        Me.txtStudentID.Name = "txtStudentID"
        Me.txtStudentID.Size = New System.Drawing.Size(281, 38)
        Me.txtStudentID.TabIndex = 4
        Me.txtStudentID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Camera
        '
        Me.Camera.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.Camera.Location = New System.Drawing.Point(12, 447)
        Me.Camera.Name = "Camera"
        Me.Camera.Size = New System.Drawing.Size(119, 43)
        Me.Camera.TabIndex = 5
        Me.Camera.Text = "Camera"
        Me.Camera.UseVisualStyleBackColor = True
        '
        'ScanButton
        '
        Me.ScanButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.ScanButton.Location = New System.Drawing.Point(169, 447)
        Me.ScanButton.Name = "ScanButton"
        Me.ScanButton.Size = New System.Drawing.Size(124, 43)
        Me.ScanButton.TabIndex = 6
        Me.ScanButton.Text = "Scan"
        Me.ScanButton.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Dattendance
        '
        Me.Dattendance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dattendance.Location = New System.Drawing.Point(299, 162)
        Me.Dattendance.Name = "Dattendance"
        Me.Dattendance.Size = New System.Drawing.Size(636, 328)
        Me.Dattendance.TabIndex = 7
        '
        'InOutButton
        '
        Me.InOutButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.InOutButton.Location = New System.Drawing.Point(311, 110)
        Me.InOutButton.Name = "InOutButton"
        Me.InOutButton.Size = New System.Drawing.Size(109, 38)
        Me.InOutButton.TabIndex = 9
        Me.InOutButton.Text = "In/Out"
        Me.InOutButton.UseVisualStyleBackColor = True
        '
        'Ldate
        '
        Me.Ldate.AutoSize = True
        Me.Ldate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Ldate.Location = New System.Drawing.Point(851, 139)
        Me.Ldate.Name = "Ldate"
        Me.Ldate.Size = New System.Drawing.Size(44, 20)
        Me.Ldate.TabIndex = 10
        Me.Ldate.Text = "Date"
        '
        'Fqrattendance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(939, 627)
        Me.Controls.Add(Me.Ldate)
        Me.Controls.Add(Me.InOutButton)
        Me.Controls.Add(Me.Dattendance)
        Me.Controls.Add(Me.ScanButton)
        Me.Controls.Add(Me.Camera)
        Me.Controls.Add(Me.txtStudentID)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Fqrattendance"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Fqrattendance"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dattendance, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtStudentID As TextBox
    Friend WithEvents Camera As Button
    Friend WithEvents ScanButton As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Dattendance As DataGridView
    Friend WithEvents InOutButton As Button
    Friend WithEvents Ldate As Label
End Class
