<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fqr
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Fqr))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnGenerate = New System.Windows.Forms.Button()
        Me.PictureQR = New System.Windows.Forms.PictureBox()
        Me.txtStudentID = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureQR, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-24, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(987, 628)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 27
        Me.PictureBox1.TabStop = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.Brown
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(528, 518)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(165, 50)
        Me.btnSave.TabIndex = 33
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnGenerate
        '
        Me.btnGenerate.BackColor = System.Drawing.Color.Brown
        Me.btnGenerate.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.btnGenerate.ForeColor = System.Drawing.Color.White
        Me.btnGenerate.Location = New System.Drawing.Point(250, 518)
        Me.btnGenerate.Name = "btnGenerate"
        Me.btnGenerate.Size = New System.Drawing.Size(165, 50)
        Me.btnGenerate.TabIndex = 32
        Me.btnGenerate.Text = "Generate New"
        Me.btnGenerate.UseVisualStyleBackColor = False
        '
        'PictureQR
        '
        Me.PictureQR.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.PictureQR.Location = New System.Drawing.Point(361, 165)
        Me.PictureQR.Name = "PictureQR"
        Me.PictureQR.Size = New System.Drawing.Size(221, 221)
        Me.PictureQR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureQR.TabIndex = 34
        Me.PictureQR.TabStop = False
        '
        'txtStudentID
        '
        Me.txtStudentID.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.txtStudentID.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtStudentID.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.txtStudentID.Location = New System.Drawing.Point(351, 402)
        Me.txtStudentID.Name = "txtStudentID"
        Me.txtStudentID.Size = New System.Drawing.Size(240, 31)
        Me.txtStudentID.TabIndex = 35
        Me.txtStudentID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Fqr
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(939, 627)
        Me.Controls.Add(Me.txtStudentID)
        Me.Controls.Add(Me.PictureQR)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnGenerate)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Fqr"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureQR, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnSave As Button
    Friend WithEvents btnGenerate As Button
    Friend WithEvents PictureQR As PictureBox
    Friend WithEvents txtStudentID As TextBox
End Class
