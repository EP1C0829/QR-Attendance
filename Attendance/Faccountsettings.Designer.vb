<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Faccountsettings
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Faccountsettings))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCurrentpass = New System.Windows.Forms.TextBox()
        Me.txtNewpass = New System.Windows.Forms.TextBox()
        Me.txtConfirmpass = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnSavepass = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Spassword = New System.Windows.Forms.CheckBox()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DimGray
        Me.Label1.Location = New System.Drawing.Point(12, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(235, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Account Settings"
        '
        'txtCurrentpass
        '
        Me.txtCurrentpass.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCurrentpass.ForeColor = System.Drawing.Color.Silver
        Me.txtCurrentpass.Location = New System.Drawing.Point(33, 117)
        Me.txtCurrentpass.Name = "txtCurrentpass"
        Me.txtCurrentpass.Size = New System.Drawing.Size(208, 30)
        Me.txtCurrentpass.TabIndex = 6
        Me.txtCurrentpass.Text = "Current Password"
        '
        'txtNewpass
        '
        Me.txtNewpass.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNewpass.ForeColor = System.Drawing.Color.Silver
        Me.txtNewpass.Location = New System.Drawing.Point(333, 117)
        Me.txtNewpass.Name = "txtNewpass"
        Me.txtNewpass.Size = New System.Drawing.Size(240, 30)
        Me.txtNewpass.TabIndex = 9
        Me.txtNewpass.Text = "New Password"
        '
        'txtConfirmpass
        '
        Me.txtConfirmpass.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConfirmpass.ForeColor = System.Drawing.Color.Silver
        Me.txtConfirmpass.Location = New System.Drawing.Point(333, 174)
        Me.txtConfirmpass.Name = "txtConfirmpass"
        Me.txtConfirmpass.Size = New System.Drawing.Size(240, 30)
        Me.txtConfirmpass.TabIndex = 10
        Me.txtConfirmpass.Text = "Confirm Password"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DimGray
        Me.Label3.Location = New System.Drawing.Point(29, 94)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(145, 20)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Change Password"
        '
        'btnSavepass
        '
        Me.btnSavepass.BackColor = System.Drawing.Color.Brown
        Me.btnSavepass.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.btnSavepass.ForeColor = System.Drawing.Color.White
        Me.btnSavepass.Location = New System.Drawing.Point(333, 247)
        Me.btnSavepass.Name = "btnSavepass"
        Me.btnSavepass.Size = New System.Drawing.Size(253, 50)
        Me.btnSavepass.TabIndex = 22
        Me.btnSavepass.Text = "Save Changes"
        Me.btnSavepass.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(200, 62)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(415, 10)
        Me.PictureBox2.TabIndex = 4
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 62)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(415, 10)
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'Spassword
        '
        Me.Spassword.AutoSize = True
        Me.Spassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Spassword.Location = New System.Drawing.Point(333, 217)
        Me.Spassword.Name = "Spassword"
        Me.Spassword.Size = New System.Drawing.Size(154, 24)
        Me.Spassword.TabIndex = 23
        Me.Spassword.Text = "Show Password"
        Me.Spassword.UseVisualStyleBackColor = True
        '
        'Faccountsettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(632, 334)
        Me.Controls.Add(Me.Spassword)
        Me.Controls.Add(Me.btnSavepass)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtConfirmpass)
        Me.Controls.Add(Me.txtNewpass)
        Me.Controls.Add(Me.txtCurrentpass)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "Faccountsettings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtCurrentpass As TextBox
    Friend WithEvents txtNewpass As TextBox
    Friend WithEvents txtConfirmpass As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnSavepass As Button
    Friend WithEvents Spassword As CheckBox
End Class
