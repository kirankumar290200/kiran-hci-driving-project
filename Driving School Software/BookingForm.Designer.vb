<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BookingForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BookingForm))
        Label6 = New Label()
        Label4 = New Label()
        Label29 = New Label()
        Label32 = New Label()
        PaymentStudentName = New TextBox()
        Label22 = New Label()
        TrainerName = New Label()
        TrainerFullName = New TextBox()
        Label5 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        panel1 = New Panel()
        PaymentCourse = New ComboBox()
        PaymentAmount = New TextBox()
        PaymentGridView = New DataGridView()
        label20 = New Label()
        label18 = New Label()
        label17 = New Label()
        Label21 = New Label()
        PaymentCancel = New Button()
        PaymentSaveBtn = New Button()
        Label25 = New Label()
        PaymentDate = New DateTimePicker()
        Label26 = New Label()
        PaymentSearchTxt = New TextBox()
        Label1 = New Label()
        Label12 = New Label()
        pictureBox2 = New PictureBox()
        panel1.SuspendLayout()
        CType(PaymentGridView, ComponentModel.ISupportInitialize).BeginInit()
        CType(pictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.Black
        Label6.Location = New Point(750, 37)
        Label6.Name = "Label6"
        Label6.Size = New Size(127, 37)
        Label6.TabIndex = 84
        Label6.Text = "Sign Out"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.Black
        Label4.Location = New Point(477, 37)
        Label4.Name = "Label4"
        Label4.Size = New Size(117, 37)
        Label4.TabIndex = 82
        Label4.Text = "Courses"
        ' 
        ' Label29
        ' 
        Label29.AutoSize = True
        Label29.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label29.ForeColor = SystemColors.ControlText
        Label29.Location = New Point(26, 88)
        Label29.Name = "Label29"
        Label29.Size = New Size(66, 21)
        Label29.TabIndex = 2
        Label29.Text = "Courses"
        ' 
        ' Label32
        ' 
        Label32.AutoSize = True
        Label32.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label32.ForeColor = SystemColors.ControlText
        Label32.Location = New Point(29, 30)
        Label32.Name = "Label32"
        Label32.Size = New Size(109, 21)
        Label32.TabIndex = 0
        Label32.Text = "Student Name"
        ' 
        ' PaymentStudentName
        ' 
        PaymentStudentName.BorderStyle = BorderStyle.FixedSingle
        PaymentStudentName.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        PaymentStudentName.Location = New Point(29, 52)
        PaymentStudentName.Name = "PaymentStudentName"
        PaymentStudentName.Size = New Size(179, 26)
        PaymentStudentName.TabIndex = 1
        ' 
        ' Label22
        ' 
        Label22.AutoSize = True
        Label22.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label22.ForeColor = SystemColors.ControlText
        Label22.Location = New Point(248, 25)
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
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.Yellow
        Label5.Location = New Point(611, 37)
        Label5.Name = "Label5"
        Label5.Size = New Size(124, 37)
        Label5.TabIndex = 83
        Label5.Text = "Booking"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Black
        Label2.Location = New Point(173, 37)
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
        Label3.Location = New Point(332, 37)
        Label3.Name = "Label3"
        Label3.Size = New Size(129, 37)
        Label3.TabIndex = 81
        Label3.Text = "Students"
        ' 
        ' panel1
        ' 
        panel1.BackColor = Color.White
        panel1.Controls.Add(PaymentCourse)
        panel1.Controls.Add(PaymentAmount)
        panel1.Controls.Add(PaymentGridView)
        panel1.Controls.Add(label20)
        panel1.Controls.Add(label18)
        panel1.Controls.Add(label17)
        panel1.Controls.Add(Label21)
        panel1.Controls.Add(PaymentCancel)
        panel1.Controls.Add(PaymentSaveBtn)
        panel1.Controls.Add(Label25)
        panel1.Controls.Add(PaymentDate)
        panel1.Controls.Add(Label26)
        panel1.Controls.Add(Label29)
        panel1.Controls.Add(Label32)
        panel1.Controls.Add(PaymentStudentName)
        panel1.Controls.Add(PaymentSearchTxt)
        panel1.Controls.Add(Label22)
        panel1.Controls.Add(TrainerName)
        panel1.Controls.Add(TrainerFullName)
        panel1.Location = New Point(12, 78)
        panel1.Name = "panel1"
        panel1.Size = New Size(865, 413)
        panel1.TabIndex = 77
        ' 
        ' PaymentCourse
        ' 
        PaymentCourse.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        PaymentCourse.FormattingEnabled = True
        PaymentCourse.Items.AddRange(New Object() {"Introductory", "Standard", "Pass Plus", "Driving Test"})
        PaymentCourse.Location = New Point(29, 115)
        PaymentCourse.Name = "PaymentCourse"
        PaymentCourse.Size = New Size(182, 27)
        PaymentCourse.TabIndex = 3
        ' 
        ' PaymentAmount
        ' 
        PaymentAmount.BorderStyle = BorderStyle.FixedSingle
        PaymentAmount.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        PaymentAmount.Location = New Point(26, 170)
        PaymentAmount.Name = "PaymentAmount"
        PaymentAmount.Size = New Size(179, 26)
        PaymentAmount.TabIndex = 5
        ' 
        ' PaymentGridView
        ' 
        PaymentGridView.BackgroundColor = Color.Gainsboro
        PaymentGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        PaymentGridView.Location = New Point(247, 52)
        PaymentGridView.Name = "PaymentGridView"
        PaymentGridView.Size = New Size(623, 340)
        PaymentGridView.TabIndex = 62
        ' 
        ' label20
        ' 
        label20.AutoSize = True
        label20.BackColor = Color.Transparent
        label20.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        label20.ForeColor = Color.Red
        label20.Location = New Point(127, 216)
        label20.Name = "label20"
        label20.Size = New Size(17, 19)
        label20.TabIndex = 61
        label20.Text = "*"
        ' 
        ' label18
        ' 
        label18.AutoSize = True
        label18.BackColor = Color.Transparent
        label18.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        label18.ForeColor = Color.Red
        label18.Location = New Point(90, 145)
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
        label17.Location = New Point(91, 90)
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
        Label21.Location = New Point(135, 29)
        Label21.Name = "Label21"
        Label21.Size = New Size(17, 19)
        Label21.TabIndex = 57
        Label21.Text = "*"
        ' 
        ' PaymentCancel
        ' 
        PaymentCancel.BackColor = Color.Transparent
        PaymentCancel.FlatStyle = FlatStyle.Flat
        PaymentCancel.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        PaymentCancel.ForeColor = Color.Black
        PaymentCancel.Location = New Point(137, 281)
        PaymentCancel.Name = "PaymentCancel"
        PaymentCancel.Size = New Size(90, 39)
        PaymentCancel.TabIndex = 9
        PaymentCancel.Text = "Clear"
        PaymentCancel.UseVisualStyleBackColor = False
        ' 
        ' PaymentSaveBtn
        ' 
        PaymentSaveBtn.BackColor = Color.Transparent
        PaymentSaveBtn.FlatStyle = FlatStyle.Flat
        PaymentSaveBtn.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        PaymentSaveBtn.ForeColor = Color.LimeGreen
        PaymentSaveBtn.Location = New Point(28, 281)
        PaymentSaveBtn.Name = "PaymentSaveBtn"
        PaymentSaveBtn.Size = New Size(90, 39)
        PaymentSaveBtn.TabIndex = 8
        PaymentSaveBtn.Text = "Payment"
        PaymentSaveBtn.UseVisualStyleBackColor = False
        ' 
        ' Label25
        ' 
        Label25.AutoSize = True
        Label25.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label25.ForeColor = SystemColors.ControlText
        Label25.Location = New Point(24, 217)
        Label25.Name = "Label25"
        Label25.Size = New Size(106, 21)
        Label25.TabIndex = 6
        Label25.Text = "Payment Date"
        ' 
        ' PaymentDate
        ' 
        PaymentDate.CalendarFont = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        PaymentDate.Location = New Point(28, 239)
        PaymentDate.Name = "PaymentDate"
        PaymentDate.Size = New Size(181, 23)
        PaymentDate.TabIndex = 7
        ' 
        ' Label26
        ' 
        Label26.AutoSize = True
        Label26.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label26.ForeColor = SystemColors.ControlText
        Label26.Location = New Point(25, 146)
        Label26.Name = "Label26"
        Label26.Size = New Size(66, 21)
        Label26.TabIndex = 4
        Label26.Text = "Amount"
        ' 
        ' PaymentSearchTxt
        ' 
        PaymentSearchTxt.BorderStyle = BorderStyle.FixedSingle
        PaymentSearchTxt.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        PaymentSearchTxt.Location = New Point(315, 20)
        PaymentSearchTxt.Name = "PaymentSearchTxt"
        PaymentSearchTxt.Size = New Size(144, 26)
        PaymentSearchTxt.TabIndex = 10
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Black
        Label1.ImageAlign = ContentAlignment.TopCenter
        Label1.Location = New Point(5, 37)
        Label1.Name = "Label1"
        Label1.Size = New Size(157, 37)
        Label1.TabIndex = 78
        Label1.Text = "Dashboard"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label12.Location = New Point(290, 494)
        Label12.Name = "Label12"
        Label12.Size = New Size(266, 25)
        Label12.TabIndex = 65
        Label12.Text = "© Copyright Reserved. Kiran"
        ' 
        ' pictureBox2
        ' 
        pictureBox2.BackColor = Color.Transparent
        pictureBox2.Image = CType(resources.GetObject("pictureBox2.Image"), Image)
        pictureBox2.Location = New Point(377, 0)
        pictureBox2.Name = "pictureBox2"
        pictureBox2.Size = New Size(136, 40)
        pictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        pictureBox2.TabIndex = 85
        pictureBox2.TabStop = False
        ' 
        ' BookingForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.MediumVioletRed
        ClientSize = New Size(901, 531)
        Controls.Add(pictureBox2)
        Controls.Add(Label12)
        Controls.Add(Label6)
        Controls.Add(Label4)
        Controls.Add(Label5)
        Controls.Add(Label2)
        Controls.Add(Label3)
        Controls.Add(panel1)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        Name = "BookingForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "BookingForm"
        panel1.ResumeLayout(False)
        panel1.PerformLayout()
        CType(PaymentGridView, ComponentModel.ISupportInitialize).EndInit()
        CType(pictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Private WithEvents Label29 As Label
    Private WithEvents Label32 As Label
    Private WithEvents PaymentStudentName As TextBox
    Private WithEvents Label22 As Label
    Private WithEvents TrainerName As Label
    Private WithEvents TrainerFullName As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Private WithEvents panel1 As Panel
    Private WithEvents PaymentGridView As DataGridView
    Private WithEvents label20 As Label
    Private WithEvents label18 As Label
    Private WithEvents label17 As Label
    Private WithEvents Label21 As Label
    Private WithEvents PaymentCancel As Button
    Private WithEvents PaymentSaveBtn As Button
    Private WithEvents Label25 As Label
    Private WithEvents PaymentDate As DateTimePicker
    Private WithEvents Label26 As Label
    Private WithEvents PaymentSearchTxt As TextBox
    Friend WithEvents Label1 As Label
    Private WithEvents PaymentAmount As TextBox
    Private WithEvents PaymentCourse As ComboBox
    Friend WithEvents Label12 As Label
    Private WithEvents pictureBox2 As PictureBox
End Class
