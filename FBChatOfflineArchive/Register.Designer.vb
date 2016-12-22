<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Register
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtfbFirstname = New System.Windows.Forms.TextBox()
        Me.txtfbMiddlename = New System.Windows.Forms.TextBox()
        Me.txtfbLastname = New System.Windows.Forms.TextBox()
        Me.txtfbUniqueUserID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBoxFacebookAccount = New System.Windows.Forms.GroupBox()
        Me.GroupBox_SystemCredentials = New System.Windows.Forms.GroupBox()
        Me.btnChooseImage = New System.Windows.Forms.Button()
        Me.OFD_ChoosePicture = New System.Windows.Forms.OpenFileDialog()
        Me.PictureBox_AccountPicture = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnRegister = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.GroupBoxFacebookAccount.SuspendLayout()
        Me.GroupBox_SystemCredentials.SuspendLayout()
        CType(Me.PictureBox_AccountPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(118, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(0, -1)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(427, 39)
        Me.Panel1.TabIndex = 0
        '
        'txtfbFirstname
        '
        Me.txtfbFirstname.Location = New System.Drawing.Point(206, 163)
        Me.txtfbFirstname.MaxLength = 255
        Me.txtfbFirstname.Name = "txtfbFirstname"
        Me.txtfbFirstname.Size = New System.Drawing.Size(157, 26)
        Me.txtfbFirstname.TabIndex = 2
        '
        'txtfbMiddlename
        '
        Me.txtfbMiddlename.Location = New System.Drawing.Point(206, 202)
        Me.txtfbMiddlename.MaxLength = 255
        Me.txtfbMiddlename.Name = "txtfbMiddlename"
        Me.txtfbMiddlename.Size = New System.Drawing.Size(157, 26)
        Me.txtfbMiddlename.TabIndex = 3
        '
        'txtfbLastname
        '
        Me.txtfbLastname.Location = New System.Drawing.Point(206, 237)
        Me.txtfbLastname.MaxLength = 255
        Me.txtfbLastname.Name = "txtfbLastname"
        Me.txtfbLastname.Size = New System.Drawing.Size(157, 26)
        Me.txtfbLastname.TabIndex = 4
        '
        'txtfbUniqueUserID
        '
        Me.txtfbUniqueUserID.Location = New System.Drawing.Point(206, 273)
        Me.txtfbUniqueUserID.MaxLength = 255
        Me.txtfbUniqueUserID.Name = "txtfbUniqueUserID"
        Me.txtfbUniqueUserID.Size = New System.Drawing.Size(157, 26)
        Me.txtfbUniqueUserID.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 166)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(160, 18)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Facebook First Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(12, 205)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(176, 18)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Facebook Middle Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(13, 240)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(159, 18)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Facebook Last Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(12, 276)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(188, 18)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Facebook Unique User ID"
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(99, 33)
        Me.txtUsername.MaxLength = 255
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(157, 26)
        Me.txtUsername.TabIndex = 10
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(99, 66)
        Me.txtPassword.MaxLength = 255
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(157, 26)
        Me.txtPassword.TabIndex = 11
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(6, 36)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 18)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Username"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(6, 69)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 18)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Password"
        '
        'GroupBoxFacebookAccount
        '
        Me.GroupBoxFacebookAccount.Controls.Add(Me.btnChooseImage)
        Me.GroupBoxFacebookAccount.Controls.Add(Me.PictureBox_AccountPicture)
        Me.GroupBoxFacebookAccount.Controls.Add(Me.Label1)
        Me.GroupBoxFacebookAccount.Controls.Add(Me.txtfbFirstname)
        Me.GroupBoxFacebookAccount.Controls.Add(Me.txtfbMiddlename)
        Me.GroupBoxFacebookAccount.Controls.Add(Me.txtfbLastname)
        Me.GroupBoxFacebookAccount.Controls.Add(Me.txtfbUniqueUserID)
        Me.GroupBoxFacebookAccount.Controls.Add(Me.Label4)
        Me.GroupBoxFacebookAccount.Controls.Add(Me.Label2)
        Me.GroupBoxFacebookAccount.Controls.Add(Me.Label3)
        Me.GroupBoxFacebookAccount.ForeColor = System.Drawing.Color.White
        Me.GroupBoxFacebookAccount.Location = New System.Drawing.Point(12, 150)
        Me.GroupBoxFacebookAccount.Name = "GroupBoxFacebookAccount"
        Me.GroupBoxFacebookAccount.Size = New System.Drawing.Size(383, 328)
        Me.GroupBoxFacebookAccount.TabIndex = 14
        Me.GroupBoxFacebookAccount.TabStop = False
        Me.GroupBoxFacebookAccount.Text = "Facebook Account Information"
        '
        'GroupBox_SystemCredentials
        '
        Me.GroupBox_SystemCredentials.Controls.Add(Me.Label5)
        Me.GroupBox_SystemCredentials.Controls.Add(Me.txtUsername)
        Me.GroupBox_SystemCredentials.Controls.Add(Me.Label6)
        Me.GroupBox_SystemCredentials.Controls.Add(Me.txtPassword)
        Me.GroupBox_SystemCredentials.ForeColor = System.Drawing.Color.White
        Me.GroupBox_SystemCredentials.Location = New System.Drawing.Point(12, 501)
        Me.GroupBox_SystemCredentials.Name = "GroupBox_SystemCredentials"
        Me.GroupBox_SystemCredentials.Size = New System.Drawing.Size(383, 127)
        Me.GroupBox_SystemCredentials.TabIndex = 15
        Me.GroupBox_SystemCredentials.TabStop = False
        Me.GroupBox_SystemCredentials.Text = "System Credentials"
        '
        'btnChooseImage
        '
        Me.btnChooseImage.ForeColor = System.Drawing.Color.Black
        Me.btnChooseImage.Location = New System.Drawing.Point(206, 61)
        Me.btnChooseImage.Name = "btnChooseImage"
        Me.btnChooseImage.Size = New System.Drawing.Size(141, 39)
        Me.btnChooseImage.TabIndex = 11
        Me.btnChooseImage.Text = "Choose Image..."
        Me.btnChooseImage.UseVisualStyleBackColor = True
        '
        'OFD_ChoosePicture
        '
        Me.OFD_ChoosePicture.Filter = "Picture Formats(JPG, PNG, BMP, JPEG, TIFF)|*.jpg;*.png; *.jpeg;*.bmp"
        '
        'PictureBox_AccountPicture
        '
        Me.PictureBox_AccountPicture.Image = Global.FBChatOfflineArchive.My.Resources.Resources.male_image
        Me.PictureBox_AccountPicture.Location = New System.Drawing.Point(27, 25)
        Me.PictureBox_AccountPicture.Name = "PictureBox_AccountPicture"
        Me.PictureBox_AccountPicture.Size = New System.Drawing.Size(118, 138)
        Me.PictureBox_AccountPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox_AccountPicture.TabIndex = 10
        Me.PictureBox_AccountPicture.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.FBChatOfflineArchive.My.Resources.Resources.fb2016
        Me.PictureBox2.Location = New System.Drawing.Point(0, -1)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(32, 39)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.FBChatOfflineArchive.My.Resources.Resources.fb2016
        Me.PictureBox1.Location = New System.Drawing.Point(159, 45)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(75, 90)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'btnRegister
        '
        Me.btnRegister.Location = New System.Drawing.Point(268, 635)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(91, 29)
        Me.btnRegister.TabIndex = 16
        Me.btnRegister.Text = "Register"
        Me.btnRegister.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(39, 635)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(91, 29)
        Me.btnCancel.TabIndex = 17
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'Register
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(426, 676)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnRegister)
        Me.Controls.Add(Me.GroupBox_SystemCredentials)
        Me.Controls.Add(Me.GroupBoxFacebookAccount)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Register"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Register"
        Me.GroupBoxFacebookAccount.ResumeLayout(False)
        Me.GroupBoxFacebookAccount.PerformLayout()
        Me.GroupBox_SystemCredentials.ResumeLayout(False)
        Me.GroupBox_SystemCredentials.PerformLayout()
        CType(Me.PictureBox_AccountPicture, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents txtfbFirstname As System.Windows.Forms.TextBox
    Friend WithEvents txtfbMiddlename As System.Windows.Forms.TextBox
    Friend WithEvents txtfbLastname As System.Windows.Forms.TextBox
    Friend WithEvents txtfbUniqueUserID As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupBoxFacebookAccount As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox_AccountPicture As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox_SystemCredentials As System.Windows.Forms.GroupBox
    Friend WithEvents btnChooseImage As System.Windows.Forms.Button
    Friend WithEvents OFD_ChoosePicture As System.Windows.Forms.OpenFileDialog
    Friend WithEvents btnRegister As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
End Class
