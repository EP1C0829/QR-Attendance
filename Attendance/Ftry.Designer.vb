<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ftry
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Ftry))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Ldate = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnScan = New System.Windows.Forms.Button()
        Me.btnCamera = New System.Windows.Forms.Button()
        Me.Dattendance = New System.Windows.Forms.DataGridView()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dattendance, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Button1.Location = New System.Drawing.Point(315, 23)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(119, 45)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "In/Out"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Ldate
        '
        Me.Ldate.AutoSize = True
        Me.Ldate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Ldate.Location = New System.Drawing.Point(704, 48)
        Me.Ldate.Name = "Ldate"
        Me.Ldate.Size = New System.Drawing.Size(44, 20)
        Me.Ldate.TabIndex = 11
        Me.Ldate.Text = "Date"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 74)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(281, 269)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'btnScan
        '
        Me.btnScan.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.btnScan.Location = New System.Drawing.Point(169, 358)
        Me.btnScan.Name = "btnScan"
        Me.btnScan.Size = New System.Drawing.Size(124, 43)
        Me.btnScan.TabIndex = 17
        Me.btnScan.Text = "Scan"
        Me.btnScan.UseVisualStyleBackColor = True
        '
        'btnCamera
        '
        Me.btnCamera.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.btnCamera.Location = New System.Drawing.Point(12, 358)
        Me.btnCamera.Name = "btnCamera"
        Me.btnCamera.Size = New System.Drawing.Size(119, 43)
        Me.btnCamera.TabIndex = 16
        Me.btnCamera.Text = "Camera"
        Me.btnCamera.UseVisualStyleBackColor = True
        '
        'Dattendance
        '
        Me.Dattendance.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Dattendance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dattendance.Location = New System.Drawing.Point(299, 74)
        Me.Dattendance.Name = "Dattendance"
        Me.Dattendance.Size = New System.Drawing.Size(489, 328)
        Me.Dattendance.TabIndex = 18
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!)
        Me.TextBox1.Location = New System.Drawing.Point(12, 23)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(281, 45)
        Me.TextBox1.TabIndex = 0
        '
        'Ftry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Dattendance)
        Me.Controls.Add(Me.btnScan)
        Me.Controls.Add(Me.btnCamera)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Ldate)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "Ftry"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Student Attendance"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dattendance, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As Button
    Friend WithEvents Ldate As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnScan As Button
    Friend WithEvents btnCamera As Button
    Friend WithEvents Dattendance As DataGridView
    Friend WithEvents TextBox1 As TextBox
End Class
