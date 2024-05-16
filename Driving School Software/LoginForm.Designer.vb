<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginForm))
        Label1 = New Label()
        pictureBox2 = New PictureBox()
        panel1 = New Panel()
        Button1 = New Button()
        label5 = New Label()
        label16 = New Label()
        label4 = New Label()
        Password = New TextBox()
        label3 = New Label()
        label2 = New Label()
        Username = New TextBox()
        loginButton = New Button()
        TrainerName = New Label()
        TrainerFullName = New TextBox()
        CType(pictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(8, 86)
        Label1.Name = "Label1"
        Label1.Size = New Size(241, 90)
        Label1.TabIndex = 0
        Label1.Text = "      Kiran " & vbCrLf & "Driving School"
        ' 
        ' pictureBox2
        ' 
        pictureBox2.BackColor = Color.Transparent
        pictureBox2.Image = CType(resources.GetObject("pictureBox2.Image"), Image)
        pictureBox2.Location = New Point(29, -1)
        pictureBox2.Name = "pictureBox2"
        pictureBox2.Size = New Size(155, 82)
        pictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        pictureBox2.TabIndex = 25
        pictureBox2.TabStop = False
        ' 
        ' panel1
        ' 
        panel1.BackColor = Color.White
        panel1.Controls.Add(Button1)
        panel1.Controls.Add(pictureBox2)
        panel1.Controls.Add(Label1)
        panel1.Controls.Add(label5)
        panel1.Controls.Add(label16)
        panel1.Controls.Add(label4)
        panel1.Controls.Add(Password)
        panel1.Controls.Add(label3)
        panel1.Controls.Add(label2)
        panel1.Controls.Add(Username)
        panel1.Controls.Add(loginButton)
        panel1.Controls.Add(TrainerName)
        panel1.Controls.Add(TrainerFullName)
        panel1.Location = New Point(-2, 28)
        panel1.Name = "panel1"
        panel1.Size = New Size(544, 250)
        panel1.TabIndex = 26
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Transparent
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.Black
        Button1.Location = New Point(388, 184)
        Button1.Name = "Button1"
        Button1.Size = New Size(96, 39)
        Button1.TabIndex = 5
        Button1.Text = "Clear"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' label5
        ' 
        label5.AutoSize = True
        label5.BackColor = Color.Transparent
        label5.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        label5.ForeColor = Color.Red
        label5.Location = New Point(342, 120)
        label5.Name = "label5"
        label5.Size = New Size(17, 19)
        label5.TabIndex = 38
        label5.Text = "*"
        ' 
        ' label16
        ' 
        label16.AutoSize = True
        label16.BackColor = Color.Transparent
        label16.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        label16.ForeColor = Color.Red
        label16.Location = New Point(342, 63)
        label16.Name = "label16"
        label16.Size = New Size(17, 19)
        label16.TabIndex = 37
        label16.Text = "*"
        ' 
        ' label4
        ' 
        label4.AutoSize = True
        label4.Font = New Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        label4.Location = New Point(275, 17)
        label4.Name = "label4"
        label4.Size = New Size(215, 40)
        label4.TabIndex = 29
        label4.Text = "ADMIN LOGIN"
        ' 
        ' Password
        ' 
        Password.BorderStyle = BorderStyle.FixedSingle
        Password.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Password.Location = New Point(274, 141)
        Password.Name = "Password"
        Password.PasswordChar = "*"c
        Password.Size = New Size(210, 26)
        Password.TabIndex = 3
        Password.UseSystemPasswordChar = True
        ' 
        ' label3
        ' 
        label3.AutoSize = True
        label3.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        label3.Location = New Point(274, 119)
        label3.Name = "label3"
        label3.Size = New Size(69, 19)
        label3.TabIndex = 2
        label3.Text = "Password"
        ' 
        ' label2
        ' 
        label2.AutoSize = True
        label2.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        label2.Location = New Point(274, 62)
        label2.Name = "label2"
        label2.Size = New Size(70, 19)
        label2.TabIndex = 0
        label2.Text = "Username"
        ' 
        ' Username
        ' 
        Username.BorderStyle = BorderStyle.FixedSingle
        Username.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Username.Location = New Point(274, 84)
        Username.Name = "Username"
        Username.Size = New Size(210, 26)
        Username.TabIndex = 1
        ' 
        ' loginButton
        ' 
        loginButton.BackColor = Color.Transparent
        loginButton.FlatStyle = FlatStyle.Flat
        loginButton.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        loginButton.ForeColor = Color.LimeGreen
        loginButton.Location = New Point(274, 184)
        loginButton.Name = "loginButton"
        loginButton.Size = New Size(96, 39)
        loginButton.TabIndex = 4
        loginButton.Text = "Login"
        loginButton.UseVisualStyleBackColor = False
        ' 
        ' TrainerName
        ' 
        TrainerName.AutoSize = True
        TrainerName.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TrainerName.Location = New Point(326, -136)
        TrainerName.Name = "TrainerName"
        TrainerName.Size = New Size(84, 19)
        TrainerName.TabIndex = 23
        TrainerName.Text = "Full Name *"
        ' 
        ' TrainerFullName
        ' 
        TrainerFullName.BorderStyle = BorderStyle.FixedSingle
        TrainerFullName.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TrainerFullName.Location = New Point(326, -114)
        TrainerFullName.Name = "TrainerFullName"
        TrainerFullName.Size = New Size(185, 26)
        TrainerFullName.TabIndex = 22
        ' 
        ' LoginForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.MediumVioletRed
        ClientSize = New Size(548, 294)
        Controls.Add(panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "LoginForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "LoginForm"
        CType(pictureBox2, ComponentModel.ISupportInitialize).EndInit()
        panel1.ResumeLayout(False)
        panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Label1 As Label
    Private WithEvents pictureBox2 As PictureBox
    Private WithEvents panel1 As Panel
    Private WithEvents label5 As Label
    Private WithEvents label16 As Label
    Private WithEvents label4 As Label
    Private WithEvents Password As TextBox
    Private WithEvents label3 As Label
    Private WithEvents label2 As Label
    Private WithEvents Username As TextBox
    Private WithEvents loginButton As Button
    Private WithEvents TrainerName As Label
    Private WithEvents TrainerFullName As TextBox
    Private WithEvents Button1 As Button
End Class
