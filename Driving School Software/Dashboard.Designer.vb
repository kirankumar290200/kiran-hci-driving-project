<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dashboard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Dashboard))
        panel1 = New Panel()
        Label12 = New Label()
        Label13 = New Label()
        TrainerName = New Label()
        TrainerFullName = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        pictureBox2 = New PictureBox()
        Label14 = New Label()
        panel1.SuspendLayout()
        CType(pictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' panel1
        ' 
        panel1.BackColor = Color.Gainsboro
        panel1.Controls.Add(Label12)
        panel1.Controls.Add(Label13)
        panel1.Controls.Add(TrainerName)
        panel1.Controls.Add(TrainerFullName)
        panel1.Location = New Point(17, 75)
        panel1.Name = "panel1"
        panel1.Size = New Size(870, 408)
        panel1.TabIndex = 27
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label12.Location = New Point(292, 256)
        Label12.Name = "Label12"
        Label12.Size = New Size(231, 30)
        Label12.TabIndex = 25
        Label12.Text = "Birmingham Road, UK"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label13.Location = New Point(104, 61)
        Label13.Name = "Label13"
        Label13.Size = New Size(655, 172)
        Label13.TabIndex = 24
        Label13.Text = "     Welcome To" & vbCrLf & "Kiran Driving School"
        ' 
        ' TrainerName
        ' 
        TrainerName.AutoSize = True
        TrainerName.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TrainerName.Location = New Point(279, -113)
        TrainerName.Name = "TrainerName"
        TrainerName.Size = New Size(84, 19)
        TrainerName.TabIndex = 23
        TrainerName.Text = "Full Name *"
        ' 
        ' TrainerFullName
        ' 
        TrainerFullName.BorderStyle = BorderStyle.FixedSingle
        TrainerFullName.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TrainerFullName.Location = New Point(279, -94)
        TrainerFullName.Name = "TrainerFullName"
        TrainerFullName.Size = New Size(159, 26)
        TrainerFullName.TabIndex = 22
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Yellow
        Label1.ImageAlign = ContentAlignment.TopCenter
        Label1.Location = New Point(4, 34)
        Label1.Name = "Label1"
        Label1.Size = New Size(157, 37)
        Label1.TabIndex = 28
        Label1.Text = "Dashboard"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Black
        Label2.Location = New Point(172, 34)
        Label2.Name = "Label2"
        Label2.Size = New Size(144, 37)
        Label2.TabIndex = 29
        Label2.Text = "Instructor"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.Black
        Label3.Location = New Point(331, 34)
        Label3.Name = "Label3"
        Label3.Size = New Size(129, 37)
        Label3.TabIndex = 30
        Label3.Text = "Students"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.Black
        Label4.Location = New Point(476, 34)
        Label4.Name = "Label4"
        Label4.Size = New Size(117, 37)
        Label4.TabIndex = 31
        Label4.Text = "Courses"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.Black
        Label5.Location = New Point(610, 34)
        Label5.Name = "Label5"
        Label5.Size = New Size(124, 37)
        Label5.TabIndex = 32
        Label5.Text = "Booking"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.Black
        Label6.Location = New Point(749, 34)
        Label6.Name = "Label6"
        Label6.Size = New Size(127, 37)
        Label6.TabIndex = 33
        Label6.Text = "Sign Out"
        ' 
        ' pictureBox2
        ' 
        pictureBox2.BackColor = Color.Transparent
        pictureBox2.Image = CType(resources.GetObject("pictureBox2.Image"), Image)
        pictureBox2.Location = New Point(377, 0)
        pictureBox2.Name = "pictureBox2"
        pictureBox2.Size = New Size(136, 40)
        pictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        pictureBox2.TabIndex = 38
        pictureBox2.TabStop = False
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label14.Location = New Point(290, 494)
        Label14.Name = "Label14"
        Label14.Size = New Size(266, 25)
        Label14.TabIndex = 26
        Label14.Text = "© Copyright Reserved. Kiran"
        ' 
        ' Dashboard
        ' 
        AutoScaleDimensions = New SizeF(6F, 13F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.MediumVioletRed
        ClientSize = New Size(901, 531)
        Controls.Add(Label14)
        Controls.Add(pictureBox2)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(panel1)
        Font = New Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        FormBorderStyle = FormBorderStyle.None
        Name = "Dashboard"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Dashboard"
        panel1.ResumeLayout(False)
        panel1.PerformLayout()
        CType(pictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Private WithEvents panel1 As Panel
    Private WithEvents TrainerName As Label
    Private WithEvents TrainerFullName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label13 As Label
    Private WithEvents pictureBox2 As PictureBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label14 As Label
End Class
