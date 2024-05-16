<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CourseForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CourseForm))
        Label2 = New Label()
        Label3 = New Label()
        panel1 = New Panel()
        CourseGridView = New DataGridView()
        CourseSearchTxt = New TextBox()
        Label22 = New Label()
        TrainerName = New Label()
        TrainerFullName = New TextBox()
        Label1 = New Label()
        Label6 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        pictureBox2 = New PictureBox()
        Label12 = New Label()
        panel1.SuspendLayout()
        CType(CourseGridView, ComponentModel.ISupportInitialize).BeginInit()
        CType(pictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Black
        Label2.Location = New Point(173, 36)
        Label2.Name = "Label2"
        Label2.Size = New Size(144, 37)
        Label2.TabIndex = 80
        Label2.Text = "Instructor"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.Black
        Label3.Location = New Point(332, 36)
        Label3.Name = "Label3"
        Label3.Size = New Size(129, 37)
        Label3.TabIndex = 81
        Label3.Text = "Students"
        ' 
        ' panel1
        ' 
        panel1.BackColor = Color.White
        panel1.Controls.Add(CourseGridView)
        panel1.Controls.Add(CourseSearchTxt)
        panel1.Controls.Add(Label22)
        panel1.Controls.Add(TrainerName)
        panel1.Controls.Add(TrainerFullName)
        panel1.Location = New Point(12, 78)
        panel1.Name = "panel1"
        panel1.Size = New Size(865, 413)
        panel1.TabIndex = 77
        ' 
        ' CourseGridView
        ' 
        CourseGridView.BackgroundColor = Color.Gainsboro
        CourseGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        CourseGridView.Location = New Point(7, 52)
        CourseGridView.Name = "CourseGridView"
        CourseGridView.Size = New Size(870, 358)
        CourseGridView.TabIndex = 62
        ' 
        ' CourseSearchTxt
        ' 
        CourseSearchTxt.BorderStyle = BorderStyle.FixedSingle
        CourseSearchTxt.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        CourseSearchTxt.Location = New Point(75, 20)
        CourseSearchTxt.Name = "CourseSearchTxt"
        CourseSearchTxt.Size = New Size(144, 26)
        CourseSearchTxt.TabIndex = 44
        ' 
        ' Label22
        ' 
        Label22.AutoSize = True
        Label22.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label22.ForeColor = SystemColors.ControlText
        Label22.Location = New Point(8, 25)
        Label22.Name = "Label22"
        Label22.Size = New Size(61, 21)
        Label22.TabIndex = 43
        Label22.Text = "Search"
        ' 
        ' TrainerName
        ' 
        TrainerName.AutoSize = True
        TrainerName.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TrainerName.Location = New Point(279, -118)
        TrainerName.Name = "TrainerName"
        TrainerName.Size = New Size(84, 19)
        TrainerName.TabIndex = 23
        TrainerName.Text = "Full Name *"
        ' 
        ' TrainerFullName
        ' 
        TrainerFullName.BorderStyle = BorderStyle.FixedSingle
        TrainerFullName.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TrainerFullName.Location = New Point(279, -99)
        TrainerFullName.Name = "TrainerFullName"
        TrainerFullName.Size = New Size(159, 26)
        TrainerFullName.TabIndex = 22
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Black
        Label1.ImageAlign = ContentAlignment.TopCenter
        Label1.Location = New Point(5, 36)
        Label1.Name = "Label1"
        Label1.Size = New Size(157, 37)
        Label1.TabIndex = 78
        Label1.Text = "Dashboard"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.Black
        Label6.Location = New Point(750, 36)
        Label6.Name = "Label6"
        Label6.Size = New Size(127, 37)
        Label6.TabIndex = 84
        Label6.Text = "Sign Out"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.Yellow
        Label4.Location = New Point(477, 36)
        Label4.Name = "Label4"
        Label4.Size = New Size(117, 37)
        Label4.TabIndex = 82
        Label4.Text = "Courses"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.Black
        Label5.Location = New Point(611, 36)
        Label5.Name = "Label5"
        Label5.Size = New Size(124, 37)
        Label5.TabIndex = 83
        Label5.Text = "Booking"
        ' 
        ' pictureBox2
        ' 
        pictureBox2.BackColor = Color.Transparent
        pictureBox2.Image = CType(resources.GetObject("pictureBox2.Image"), Image)
        pictureBox2.Location = New Point(377, 0)
        pictureBox2.Name = "pictureBox2"
        pictureBox2.Size = New Size(136, 40)
        pictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        pictureBox2.TabIndex = 91
        pictureBox2.TabStop = False
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label12.Location = New Point(290, 494)
        Label12.Name = "Label12"
        Label12.Size = New Size(266, 25)
        Label12.TabIndex = 92
        Label12.Text = "© Copyright Reserved. Kiran"
        ' 
        ' CourseForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.MediumVioletRed
        ClientSize = New Size(901, 531)
        Controls.Add(Label12)
        Controls.Add(pictureBox2)
        Controls.Add(Label2)
        Controls.Add(Label3)
        Controls.Add(panel1)
        Controls.Add(Label1)
        Controls.Add(Label6)
        Controls.Add(Label4)
        Controls.Add(Label5)
        FormBorderStyle = FormBorderStyle.None
        Name = "CourseForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "CourseForm"
        panel1.ResumeLayout(False)
        panel1.PerformLayout()
        CType(CourseGridView, ComponentModel.ISupportInitialize).EndInit()
        CType(pictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Private WithEvents panel1 As Panel
    Private WithEvents CourseGridView As DataGridView
    Private WithEvents CourseSearchTxt As TextBox
    Private WithEvents Label22 As Label
    Private WithEvents TrainerName As Label
    Private WithEvents TrainerFullName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Private WithEvents pictureBox2 As PictureBox
    Friend WithEvents Label12 As Label
End Class
