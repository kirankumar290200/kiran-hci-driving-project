<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InstructorForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(InstructorForm))
        Label3 = New Label()
        panel1 = New Panel()
        Label14 = New Label()
        InstructorGridView = New DataGridView()
        label20 = New Label()
        label19 = New Label()
        label18 = New Label()
        label17 = New Label()
        Label21 = New Label()
        InstructorCancel = New Button()
        InstructorSaveBtn = New Button()
        Label25 = New Label()
        InstructorDateOfBirth = New DateTimePicker()
        Label26 = New Label()
        InstructorGender = New ComboBox()
        Label27 = New Label()
        InstructorAddress = New TextBox()
        Label29 = New Label()
        InstructorNumber = New TextBox()
        Label32 = New Label()
        InstructorName = New TextBox()
        InstructorSearchTxt = New TextBox()
        Label22 = New Label()
        TrainerName = New Label()
        TrainerFullName = New TextBox()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        pictureBox2 = New PictureBox()
        Label12 = New Label()
        panel1.SuspendLayout()
        CType(InstructorGridView, ComponentModel.ISupportInitialize).BeginInit()
        CType(pictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.Black
        Label3.Location = New Point(332, 35)
        Label3.Name = "Label3"
        Label3.Size = New Size(129, 37)
        Label3.TabIndex = 43
        Label3.Text = "Students"
        ' 
        ' panel1
        ' 
        panel1.BackColor = Color.White
        panel1.Controls.Add(Label14)
        panel1.Controls.Add(InstructorGridView)
        panel1.Controls.Add(label20)
        panel1.Controls.Add(label19)
        panel1.Controls.Add(label18)
        panel1.Controls.Add(label17)
        panel1.Controls.Add(Label21)
        panel1.Controls.Add(InstructorCancel)
        panel1.Controls.Add(InstructorSaveBtn)
        panel1.Controls.Add(Label25)
        panel1.Controls.Add(InstructorDateOfBirth)
        panel1.Controls.Add(Label26)
        panel1.Controls.Add(InstructorGender)
        panel1.Controls.Add(Label27)
        panel1.Controls.Add(InstructorAddress)
        panel1.Controls.Add(Label29)
        panel1.Controls.Add(InstructorNumber)
        panel1.Controls.Add(Label32)
        panel1.Controls.Add(InstructorName)
        panel1.Controls.Add(InstructorSearchTxt)
        panel1.Controls.Add(Label22)
        panel1.Controls.Add(TrainerName)
        panel1.Controls.Add(TrainerFullName)
        panel1.Location = New Point(12, 78)
        panel1.Name = "panel1"
        panel1.Size = New Size(865, 413)
        panel1.TabIndex = 39
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label14.Location = New Point(290, 494)
        Label14.Name = "Label14"
        Label14.Size = New Size(266, 25)
        Label14.TabIndex = 63
        Label14.Text = "© Copyright Reserved. Kiran"
        ' 
        ' InstructorGridView
        ' 
        InstructorGridView.BackgroundColor = Color.Gainsboro
        InstructorGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        InstructorGridView.Location = New Point(247, 52)
        InstructorGridView.Name = "InstructorGridView"
        InstructorGridView.Size = New Size(623, 340)
        InstructorGridView.TabIndex = 62
        ' 
        ' label20
        ' 
        label20.AutoSize = True
        label20.BackColor = Color.Transparent
        label20.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        label20.ForeColor = Color.Red
        label20.Location = New Point(120, 273)
        label20.Name = "label20"
        label20.Size = New Size(17, 19)
        label20.TabIndex = 61
        label20.Text = "*"
        ' 
        ' label19
        ' 
        label19.AutoSize = True
        label19.BackColor = Color.Transparent
        label19.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        label19.ForeColor = Color.Red
        label19.Location = New Point(88, 207)
        label19.Name = "label19"
        label19.Size = New Size(17, 19)
        label19.TabIndex = 60
        label19.Text = "*"
        ' 
        ' label18
        ' 
        label18.AutoSize = True
        label18.BackColor = Color.Transparent
        label18.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        label18.ForeColor = Color.Red
        label18.Location = New Point(80, 145)
        label18.Name = "label18"
        label18.Size = New Size(17, 19)
        label18.TabIndex = 59
        label18.Text = "*"
        ' 
        ' label17
        ' 
        label17.AutoSize = True
        label17.BackColor = Color.Transparent
        label17.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        label17.ForeColor = Color.Red
        label17.Location = New Point(80, 90)
        label17.Name = "label17"
        label17.Size = New Size(17, 19)
        label17.TabIndex = 58
        label17.Text = "*"
        ' 
        ' Label21
        ' 
        Label21.AutoSize = True
        Label21.BackColor = Color.Transparent
        Label21.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label21.ForeColor = Color.Red
        Label21.Location = New Point(78, 29)
        Label21.Name = "Label21"
        Label21.Size = New Size(17, 19)
        Label21.TabIndex = 57
        Label21.Text = "*"
        ' 
        ' InstructorCancel
        ' 
        InstructorCancel.BackColor = Color.Transparent
        InstructorCancel.FlatStyle = FlatStyle.Flat
        InstructorCancel.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        InstructorCancel.ForeColor = Color.Black
        InstructorCancel.Location = New Point(138, 328)
        InstructorCancel.Name = "InstructorCancel"
        InstructorCancel.Size = New Size(90, 39)
        InstructorCancel.TabIndex = 56
        InstructorCancel.Text = "Clear"
        InstructorCancel.UseVisualStyleBackColor = False
        ' 
        ' InstructorSaveBtn
        ' 
        InstructorSaveBtn.BackColor = Color.Transparent
        InstructorSaveBtn.FlatStyle = FlatStyle.Flat
        InstructorSaveBtn.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        InstructorSaveBtn.ForeColor = Color.LimeGreen
        InstructorSaveBtn.Location = New Point(29, 328)
        InstructorSaveBtn.Name = "InstructorSaveBtn"
        InstructorSaveBtn.Size = New Size(90, 39)
        InstructorSaveBtn.TabIndex = 55
        InstructorSaveBtn.Text = "Save"
        InstructorSaveBtn.UseVisualStyleBackColor = False
        ' 
        ' Label25
        ' 
        Label25.AutoSize = True
        Label25.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label25.ForeColor = SystemColors.ControlText
        Label25.Location = New Point(25, 274)
        Label25.Name = "Label25"
        Label25.Size = New Size(100, 21)
        Label25.TabIndex = 53
        Label25.Text = "Date Of Birth"
        ' 
        ' InstructorDateOfBirth
        ' 
        InstructorDateOfBirth.CalendarFont = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        InstructorDateOfBirth.Location = New Point(29, 296)
        InstructorDateOfBirth.Name = "InstructorDateOfBirth"
        InstructorDateOfBirth.Size = New Size(181, 23)
        InstructorDateOfBirth.TabIndex = 54
        ' 
        ' Label26
        ' 
        Label26.AutoSize = True
        Label26.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label26.ForeColor = SystemColors.ControlText
        Label26.Location = New Point(25, 146)
        Label26.Name = "Label26"
        Label26.Size = New Size(61, 21)
        Label26.TabIndex = 49
        Label26.Text = "Gender"
        ' 
        ' InstructorGender
        ' 
        InstructorGender.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        InstructorGender.FormattingEnabled = True
        InstructorGender.Items.AddRange(New Object() {"Male", "Female", "Others"})
        InstructorGender.Location = New Point(29, 168)
        InstructorGender.Name = "InstructorGender"
        InstructorGender.Size = New Size(179, 27)
        InstructorGender.TabIndex = 50
        ' 
        ' Label27
        ' 
        Label27.AutoSize = True
        Label27.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label27.ForeColor = SystemColors.ControlText
        Label27.Location = New Point(26, 207)
        Label27.Name = "Label27"
        Label27.Size = New Size(66, 21)
        Label27.TabIndex = 51
        Label27.Text = "Address"
        ' 
        ' InstructorAddress
        ' 
        InstructorAddress.BorderStyle = BorderStyle.FixedSingle
        InstructorAddress.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        InstructorAddress.Location = New Point(29, 229)
        InstructorAddress.Multiline = True
        InstructorAddress.Name = "InstructorAddress"
        InstructorAddress.Size = New Size(179, 35)
        InstructorAddress.TabIndex = 52
        ' 
        ' Label29
        ' 
        Label29.AutoSize = True
        Label29.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label29.ForeColor = SystemColors.ControlText
        Label29.Location = New Point(26, 88)
        Label29.Name = "Label29"
        Label29.Size = New Size(54, 21)
        Label29.TabIndex = 47
        Label29.Text = "Phone"
        ' 
        ' InstructorNumber
        ' 
        InstructorNumber.BorderStyle = BorderStyle.FixedSingle
        InstructorNumber.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        InstructorNumber.Location = New Point(29, 110)
        InstructorNumber.Name = "InstructorNumber"
        InstructorNumber.Size = New Size(179, 26)
        InstructorNumber.TabIndex = 48
        ' 
        ' Label32
        ' 
        Label32.AutoSize = True
        Label32.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label32.ForeColor = SystemColors.ControlText
        Label32.Location = New Point(29, 30)
        Label32.Name = "Label32"
        Label32.Size = New Size(52, 21)
        Label32.TabIndex = 45
        Label32.Text = "Name"
        ' 
        ' InstructorName
        ' 
        InstructorName.BorderStyle = BorderStyle.FixedSingle
        InstructorName.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        InstructorName.Location = New Point(29, 52)
        InstructorName.Name = "InstructorName"
        InstructorName.Size = New Size(179, 26)
        InstructorName.TabIndex = 46
        ' 
        ' InstructorSearchTxt
        ' 
        InstructorSearchTxt.BorderStyle = BorderStyle.FixedSingle
        InstructorSearchTxt.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        InstructorSearchTxt.Location = New Point(314, 22)
        InstructorSearchTxt.Name = "InstructorSearchTxt"
        InstructorSearchTxt.Size = New Size(144, 26)
        InstructorSearchTxt.TabIndex = 44
        ' 
        ' Label22
        ' 
        Label22.AutoSize = True
        Label22.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label22.ForeColor = SystemColors.ControlText
        Label22.Location = New Point(247, 27)
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
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.Black
        Label6.Location = New Point(750, 35)
        Label6.Name = "Label6"
        Label6.Size = New Size(127, 37)
        Label6.TabIndex = 46
        Label6.Text = "Sign Out"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.Black
        Label5.Location = New Point(611, 35)
        Label5.Name = "Label5"
        Label5.Size = New Size(124, 37)
        Label5.TabIndex = 45
        Label5.Text = "Booking"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.Black
        Label4.Location = New Point(477, 35)
        Label4.Name = "Label4"
        Label4.Size = New Size(117, 37)
        Label4.TabIndex = 44
        Label4.Text = "Courses"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Yellow
        Label2.Location = New Point(173, 35)
        Label2.Name = "Label2"
        Label2.Size = New Size(144, 37)
        Label2.TabIndex = 42
        Label2.Text = "Instructor"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Black
        Label1.ImageAlign = ContentAlignment.TopCenter
        Label1.Location = New Point(5, 35)
        Label1.Name = "Label1"
        Label1.Size = New Size(157, 37)
        Label1.TabIndex = 40
        Label1.Text = "Dashboard"
        ' 
        ' pictureBox2
        ' 
        pictureBox2.BackColor = Color.Transparent
        pictureBox2.Image = CType(resources.GetObject("pictureBox2.Image"), Image)
        pictureBox2.Location = New Point(377, 0)
        pictureBox2.Name = "pictureBox2"
        pictureBox2.Size = New Size(136, 40)
        pictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        pictureBox2.TabIndex = 63
        pictureBox2.TabStop = False
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label12.Location = New Point(290, 494)
        Label12.Name = "Label12"
        Label12.Size = New Size(266, 25)
        Label12.TabIndex = 64
        Label12.Text = "© Copyright Reserved. Kiran"
        ' 
        ' InstructorForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.MediumVioletRed
        ClientSize = New Size(901, 531)
        Controls.Add(Label12)
        Controls.Add(pictureBox2)
        Controls.Add(Label3)
        Controls.Add(panel1)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label2)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        Name = "InstructorForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "InstructorForm"
        panel1.ResumeLayout(False)
        panel1.PerformLayout()
        CType(InstructorGridView, ComponentModel.ISupportInitialize).EndInit()
        CType(pictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label3 As Label
    Private WithEvents panel1 As Panel
    Private WithEvents TrainerName As Label
    Private WithEvents TrainerFullName As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Private WithEvents InstructorSearchTxt As TextBox
    Private WithEvents Label22 As Label
    Private WithEvents label20 As Label
    Private WithEvents label19 As Label
    Private WithEvents label18 As Label
    Private WithEvents label17 As Label
    Private WithEvents Label21 As Label
    Private WithEvents InstructorCancel As Button
    Private WithEvents InstructorSaveBtn As Button
    Private WithEvents Label25 As Label
    Private WithEvents InstructorDateOfBirth As DateTimePicker
    Private WithEvents Label26 As Label
    Private WithEvents InstructorGender As ComboBox
    Private WithEvents Label27 As Label
    Private WithEvents InstructorAddress As TextBox
    Private WithEvents Label29 As Label
    Private WithEvents InstructorNumber As TextBox
    Private WithEvents Label32 As Label
    Private WithEvents InstructorName As TextBox
    Private WithEvents InstructorGridView As DataGridView
    Private WithEvents pictureBox2 As PictureBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label12 As Label
End Class
