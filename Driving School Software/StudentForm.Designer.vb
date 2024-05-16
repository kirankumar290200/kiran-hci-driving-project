<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StudentForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StudentForm))
        Label6 = New Label()
        Label4 = New Label()
        StudentGridView = New DataGridView()
        label20 = New Label()
        label19 = New Label()
        label18 = New Label()
        label17 = New Label()
        Label21 = New Label()
        StudentCancel = New Button()
        StudentSaveBtn = New Button()
        StudentDateOfBirth = New DateTimePicker()
        Label5 = New Label()
        Label25 = New Label()
        Label26 = New Label()
        StudentGender = New ComboBox()
        Label27 = New Label()
        StudentAddress = New TextBox()
        Label2 = New Label()
        Label29 = New Label()
        StudentNumber = New TextBox()
        Label32 = New Label()
        StudentName = New TextBox()
        StudentSearchTxt = New TextBox()
        Label22 = New Label()
        TrainerName = New Label()
        TrainerFullName = New TextBox()
        Label3 = New Label()
        panel1 = New Panel()
        Label1 = New Label()
        pictureBox2 = New PictureBox()
        Label12 = New Label()
        CType(StudentGridView, ComponentModel.ISupportInitialize).BeginInit()
        panel1.SuspendLayout()
        CType(pictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.Black
        Label6.Location = New Point(750, 36)
        Label6.Name = "Label6"
        Label6.Size = New Size(127, 37)
        Label6.TabIndex = 70
        Label6.Text = "Sign Out"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.Black
        Label4.Location = New Point(477, 36)
        Label4.Name = "Label4"
        Label4.Size = New Size(117, 37)
        Label4.TabIndex = 68
        Label4.Text = "Courses"
        ' 
        ' StudentGridView
        ' 
        StudentGridView.BackgroundColor = Color.Gainsboro
        StudentGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        StudentGridView.Location = New Point(247, 52)
        StudentGridView.Name = "StudentGridView"
        StudentGridView.Size = New Size(623, 340)
        StudentGridView.TabIndex = 62
        ' 
        ' label20
        ' 
        label20.AutoSize = True
        label20.BackColor = Color.Transparent
        label20.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        label20.ForeColor = Color.Red
        label20.Location = New Point(120, 279)
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
        Label21.Location = New Point(79, 29)
        Label21.Name = "Label21"
        Label21.Size = New Size(17, 19)
        Label21.TabIndex = 57
        Label21.Text = "*"
        ' 
        ' StudentCancel
        ' 
        StudentCancel.BackColor = Color.Transparent
        StudentCancel.FlatStyle = FlatStyle.Flat
        StudentCancel.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        StudentCancel.ForeColor = Color.Black
        StudentCancel.Location = New Point(138, 335)
        StudentCancel.Name = "StudentCancel"
        StudentCancel.Size = New Size(90, 39)
        StudentCancel.TabIndex = 56
        StudentCancel.Text = "Cancel"
        StudentCancel.UseVisualStyleBackColor = False
        ' 
        ' StudentSaveBtn
        ' 
        StudentSaveBtn.BackColor = Color.Transparent
        StudentSaveBtn.FlatStyle = FlatStyle.Flat
        StudentSaveBtn.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        StudentSaveBtn.ForeColor = Color.LimeGreen
        StudentSaveBtn.Location = New Point(29, 335)
        StudentSaveBtn.Name = "StudentSaveBtn"
        StudentSaveBtn.Size = New Size(90, 39)
        StudentSaveBtn.TabIndex = 55
        StudentSaveBtn.Text = "Save"
        StudentSaveBtn.UseVisualStyleBackColor = False
        ' 
        ' StudentDateOfBirth
        ' 
        StudentDateOfBirth.CalendarFont = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        StudentDateOfBirth.Location = New Point(29, 302)
        StudentDateOfBirth.Name = "StudentDateOfBirth"
        StudentDateOfBirth.Size = New Size(181, 23)
        StudentDateOfBirth.TabIndex = 54
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.Black
        Label5.Location = New Point(611, 36)
        Label5.Name = "Label5"
        Label5.Size = New Size(124, 37)
        Label5.TabIndex = 69
        Label5.Text = "Booking"
        ' 
        ' Label25
        ' 
        Label25.AutoSize = True
        Label25.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label25.ForeColor = SystemColors.ControlText
        Label25.Location = New Point(25, 280)
        Label25.Name = "Label25"
        Label25.Size = New Size(100, 21)
        Label25.TabIndex = 53
        Label25.Text = "Date Of Birth"
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
        ' StudentGender
        ' 
        StudentGender.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        StudentGender.FormattingEnabled = True
        StudentGender.Items.AddRange(New Object() {"Male", "Female", "Others"})
        StudentGender.Location = New Point(29, 168)
        StudentGender.Name = "StudentGender"
        StudentGender.Size = New Size(179, 27)
        StudentGender.TabIndex = 50
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
        ' StudentAddress
        ' 
        StudentAddress.BorderStyle = BorderStyle.FixedSingle
        StudentAddress.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        StudentAddress.Location = New Point(29, 229)
        StudentAddress.Multiline = True
        StudentAddress.Name = "StudentAddress"
        StudentAddress.Size = New Size(179, 39)
        StudentAddress.TabIndex = 52
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Black
        Label2.Location = New Point(173, 36)
        Label2.Name = "Label2"
        Label2.Size = New Size(144, 37)
        Label2.TabIndex = 66
        Label2.Text = "Instructor"
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
        ' StudentNumber
        ' 
        StudentNumber.BorderStyle = BorderStyle.FixedSingle
        StudentNumber.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        StudentNumber.Location = New Point(29, 110)
        StudentNumber.Name = "StudentNumber"
        StudentNumber.Size = New Size(179, 26)
        StudentNumber.TabIndex = 48
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
        ' StudentName
        ' 
        StudentName.BorderStyle = BorderStyle.FixedSingle
        StudentName.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        StudentName.Location = New Point(29, 52)
        StudentName.Name = "StudentName"
        StudentName.Size = New Size(179, 26)
        StudentName.TabIndex = 46
        ' 
        ' StudentSearchTxt
        ' 
        StudentSearchTxt.BorderStyle = BorderStyle.FixedSingle
        StudentSearchTxt.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        StudentSearchTxt.Location = New Point(313, 21)
        StudentSearchTxt.Name = "StudentSearchTxt"
        StudentSearchTxt.Size = New Size(144, 26)
        StudentSearchTxt.TabIndex = 44
        ' 
        ' Label22
        ' 
        Label22.AutoSize = True
        Label22.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label22.ForeColor = SystemColors.ControlText
        Label22.Location = New Point(246, 26)
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
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.Yellow
        Label3.Location = New Point(332, 36)
        Label3.Name = "Label3"
        Label3.Size = New Size(129, 37)
        Label3.TabIndex = 67
        Label3.Text = "Students"
        ' 
        ' panel1
        ' 
        panel1.BackColor = Color.White
        panel1.Controls.Add(StudentGridView)
        panel1.Controls.Add(label20)
        panel1.Controls.Add(label19)
        panel1.Controls.Add(label18)
        panel1.Controls.Add(label17)
        panel1.Controls.Add(Label21)
        panel1.Controls.Add(StudentCancel)
        panel1.Controls.Add(StudentSaveBtn)
        panel1.Controls.Add(Label25)
        panel1.Controls.Add(StudentDateOfBirth)
        panel1.Controls.Add(Label26)
        panel1.Controls.Add(StudentGender)
        panel1.Controls.Add(Label27)
        panel1.Controls.Add(StudentAddress)
        panel1.Controls.Add(Label29)
        panel1.Controls.Add(StudentNumber)
        panel1.Controls.Add(Label32)
        panel1.Controls.Add(StudentName)
        panel1.Controls.Add(StudentSearchTxt)
        panel1.Controls.Add(Label22)
        panel1.Controls.Add(TrainerName)
        panel1.Controls.Add(TrainerFullName)
        panel1.Location = New Point(12, 78)
        panel1.Name = "panel1"
        panel1.Size = New Size(865, 413)
        panel1.TabIndex = 63
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
        Label1.TabIndex = 64
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
        pictureBox2.TabIndex = 77
        pictureBox2.TabStop = False
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label12.Location = New Point(290, 494)
        Label12.Name = "Label12"
        Label12.Size = New Size(266, 25)
        Label12.TabIndex = 79
        Label12.Text = "© Copyright Reserved. Kiran"
        ' 
        ' StudentForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.MediumVioletRed
        ClientSize = New Size(901, 531)
        Controls.Add(Label12)
        Controls.Add(pictureBox2)
        Controls.Add(Label6)
        Controls.Add(Label4)
        Controls.Add(Label5)
        Controls.Add(Label2)
        Controls.Add(Label3)
        Controls.Add(panel1)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        Name = "StudentForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "StudentForm"
        CType(StudentGridView, ComponentModel.ISupportInitialize).EndInit()
        panel1.ResumeLayout(False)
        panel1.PerformLayout()
        CType(pictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Private WithEvents StudentGridView As DataGridView
    Private WithEvents label20 As Label
    Private WithEvents label19 As Label
    Private WithEvents label18 As Label
    Private WithEvents label17 As Label
    Private WithEvents Label21 As Label
    Private WithEvents StudentCancel As Button
    Private WithEvents StudentSaveBtn As Button
    Private WithEvents StudentDateOfBirth As DateTimePicker
    Friend WithEvents Label5 As Label
    Private WithEvents Label25 As Label
    Private WithEvents Label26 As Label
    Private WithEvents StudentGender As ComboBox
    Private WithEvents Label27 As Label
    Private WithEvents StudentAddress As TextBox
    Friend WithEvents Label2 As Label
    Private WithEvents Label29 As Label
    Private WithEvents StudentNumber As TextBox
    Private WithEvents Label32 As Label
    Private WithEvents StudentName As TextBox
    Private WithEvents StudentSearchTxt As TextBox
    Private WithEvents Label22 As Label
    Private WithEvents TrainerName As Label
    Private WithEvents TrainerFullName As TextBox
    Friend WithEvents Label3 As Label
    Private WithEvents panel1 As Panel
    Friend WithEvents Label1 As Label
    Private WithEvents pictureBox2 As PictureBox
    Friend WithEvents Label12 As Label
End Class
