<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.txtStudentID = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Dattendance = New System.Windows.Forms.DataGridView()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Ldate = New System.Windows.Forms.Label()
        CType(Me.Dattendance, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtStudentID
        '
        Me.txtStudentID.Location = New System.Drawing.Point(220, 110)
        Me.txtStudentID.Name = "txtStudentID"
        Me.txtStudentID.Size = New System.Drawing.Size(100, 20)
        Me.txtStudentID.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(624, 110)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Dattendance
        '
        Me.Dattendance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dattendance.Location = New System.Drawing.Point(220, 169)
        Me.Dattendance.Name = "Dattendance"
        Me.Dattendance.Size = New System.Drawing.Size(479, 252)
        Me.Dattendance.TabIndex = 2
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Ldate
        '
        Me.Ldate.AutoSize = True
        Me.Ldate.Location = New System.Drawing.Point(624, 140)
        Me.Ldate.Name = "Ldate"
        Me.Ldate.Size = New System.Drawing.Size(30, 13)
        Me.Ldate.TabIndex = 3
        Me.Ldate.Text = "Date"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Ldate)
        Me.Controls.Add(Me.Dattendance)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtStudentID)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.Dattendance, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtStudentID As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Dattendance As DataGridView
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Ldate As Label
End Class
