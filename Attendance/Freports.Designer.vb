<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Freports
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Freports))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnFilter = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.DTPto = New System.Windows.Forms.DateTimePicker()
        Me.DTPfrom = New System.Windows.Forms.DateTimePicker()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnExport = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, -10)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1007, 649)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 20
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Brown
        Me.Label1.Location = New System.Drawing.Point(82, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(222, 55)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Students"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 132)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(680, 483)
        Me.DataGridView1.TabIndex = 30
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.Label2.Location = New System.Drawing.Point(699, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(230, 31)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "Student Timed-In:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.Label3.Location = New System.Drawing.Point(695, 135)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(251, 31)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "Student Timed-Out:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(792, 97)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 31)
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "Total"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(792, 185)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 31)
        Me.Label5.TabIndex = 34
        Me.Label5.Text = "Total"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.Label6.Location = New System.Drawing.Point(750, 229)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(139, 31)
        Me.Label6.TabIndex = 35
        Me.Label6.Text = "Time now:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(752, 275)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 31)
        Me.Label7.TabIndex = 36
        Me.Label7.Text = "Total"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox1.Controls.Add(Me.btnFilter)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.DTPto)
        Me.GroupBox1.Controls.Add(Me.DTPfrom)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.GroupBox1.Location = New System.Drawing.Point(705, 317)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(0)
        Me.GroupBox1.Size = New System.Drawing.Size(224, 172)
        Me.GroupBox1.TabIndex = 37
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filter By Date"
        '
        'btnFilter
        '
        Me.btnFilter.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.btnFilter.Location = New System.Drawing.Point(70, 131)
        Me.btnFilter.Name = "btnFilter"
        Me.btnFilter.Size = New System.Drawing.Size(86, 29)
        Me.btnFilter.TabIndex = 4
        Me.btnFilter.Text = "Filter"
        Me.btnFilter.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(8, 79)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(63, 17)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "Date To:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(8, 20)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(78, 17)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Date From:"
        '
        'DTPto
        '
        Me.DTPto.CustomFormat = "dd/MM/yyyy"
        Me.DTPto.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.DTPto.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTPto.Location = New System.Drawing.Point(57, 102)
        Me.DTPto.Name = "DTPto"
        Me.DTPto.Size = New System.Drawing.Size(110, 23)
        Me.DTPto.TabIndex = 1
        '
        'DTPfrom
        '
        Me.DTPfrom.CustomFormat = "dd/MM/yyyy"
        Me.DTPfrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.DTPfrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTPfrom.Location = New System.Drawing.Point(57, 47)
        Me.DTPfrom.Name = "DTPfrom"
        Me.DTPfrom.Size = New System.Drawing.Size(110, 23)
        Me.DTPfrom.TabIndex = 0
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.TextBox1.Location = New System.Drawing.Point(214, 88)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(231, 38)
        Me.TextBox1.TabIndex = 38
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.Label10.Location = New System.Drawing.Point(563, 95)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(110, 31)
        Me.Label10.TabIndex = 40
        Me.Label10.Text = "Refresh"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.Label11.ForeColor = System.Drawing.Color.DimGray
        Me.Label11.Location = New System.Drawing.Point(12, 91)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(193, 31)
        Me.Label11.TabIndex = 41
        Me.Label11.Text = "Student ID No."
        '
        'btnExport
        '
        Me.btnExport.BackColor = System.Drawing.Color.Brown
        Me.btnExport.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.btnExport.ForeColor = System.Drawing.Color.White
        Me.btnExport.Location = New System.Drawing.Point(736, 533)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(165, 50)
        Me.btnExport.TabIndex = 42
        Me.btnExport.Text = "Export to Excel"
        Me.btnExport.UseVisualStyleBackColor = False
        '
        'Freports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(939, 627)
        Me.Controls.Add(Me.btnExport)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Freports"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnFilter As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents DTPto As DateTimePicker
    Friend WithEvents DTPfrom As DateTimePicker
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents btnExport As Button
End Class
