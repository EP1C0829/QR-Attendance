<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fmanualattendance
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Fmanualattendance))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtID = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtSection = New System.Windows.Forms.TextBox()
        Me.txtAdmin = New System.Windows.Forms.TextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Ldate = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-4, -13)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1130, 654)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.RadioButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.RadioButton1.ForeColor = System.Drawing.Color.DimGray
        Me.RadioButton1.Location = New System.Drawing.Point(83, 128)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(124, 35)
        Me.RadioButton1.TabIndex = 1
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Time-In"
        Me.RadioButton1.UseVisualStyleBackColor = False
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.RadioButton2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.RadioButton2.ForeColor = System.Drawing.Color.DimGray
        Me.RadioButton2.Location = New System.Drawing.Point(83, 163)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(145, 35)
        Me.RadioButton2.TabIndex = 2
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Time-Out"
        Me.RadioButton2.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.Label1.ForeColor = System.Drawing.Color.DimGray
        Me.Label1.Location = New System.Drawing.Point(54, 88)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 31)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Status"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.Label2.ForeColor = System.Drawing.Color.DimGray
        Me.Label2.Location = New System.Drawing.Point(74, 239)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(122, 31)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "ID Code:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.Label3.ForeColor = System.Drawing.Color.DimGray
        Me.Label3.Location = New System.Drawing.Point(63, 308)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(133, 31)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Fullname:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.Label4.ForeColor = System.Drawing.Color.DimGray
        Me.Label4.Location = New System.Drawing.Point(83, 379)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(113, 31)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Section:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.Label5.ForeColor = System.Drawing.Color.DimGray
        Me.Label5.Location = New System.Drawing.Point(38, 438)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(162, 31)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Head Admin"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.Label6.ForeColor = System.Drawing.Color.DimGray
        Me.Label6.Location = New System.Drawing.Point(54, 469)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(142, 31)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Password:"
        '
        'TxtID
        '
        Me.TxtID.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!)
        Me.TxtID.Location = New System.Drawing.Point(218, 231)
        Me.TxtID.Name = "TxtID"
        Me.TxtID.Size = New System.Drawing.Size(590, 45)
        Me.TxtID.TabIndex = 9
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!)
        Me.txtName.Location = New System.Drawing.Point(218, 300)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(590, 45)
        Me.txtName.TabIndex = 10
        '
        'txtSection
        '
        Me.txtSection.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!)
        Me.txtSection.Location = New System.Drawing.Point(218, 371)
        Me.txtSection.Name = "txtSection"
        Me.txtSection.Size = New System.Drawing.Size(590, 45)
        Me.txtSection.TabIndex = 11
        '
        'txtAdmin
        '
        Me.txtAdmin.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!)
        Me.txtAdmin.Location = New System.Drawing.Point(218, 449)
        Me.txtAdmin.Name = "txtAdmin"
        Me.txtAdmin.Size = New System.Drawing.Size(590, 45)
        Me.txtAdmin.TabIndex = 12
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.Brown
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(380, 530)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(165, 50)
        Me.btnSave.TabIndex = 32
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'Ldate
        '
        Me.Ldate.AutoSize = True
        Me.Ldate.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Ldate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Ldate.Location = New System.Drawing.Point(740, 175)
        Me.Ldate.Name = "Ldate"
        Me.Ldate.Size = New System.Drawing.Size(44, 20)
        Me.Ldate.TabIndex = 33
        Me.Ldate.Text = "Date"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Fmanualattendance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(939, 627)
        Me.Controls.Add(Me.Ldate)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.txtAdmin)
        Me.Controls.Add(Me.txtSection)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.TxtID)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Fmanualattendance"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Fmanualattendance"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtID As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtSection As TextBox
    Friend WithEvents txtAdmin As TextBox
    Friend WithEvents btnSave As Button
    Friend WithEvents Ldate As Label
    Friend WithEvents Timer1 As Timer
End Class
