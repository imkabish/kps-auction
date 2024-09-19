<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class signupForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Q1 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Q3 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Q2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.backbtn = New System.Windows.Forms.Button()
        Me.recoveryqueriespanel = New System.Windows.Forms.Panel()
        Me.recquesubmitbtn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.passworderror = New System.Windows.Forms.Label()
        Me.usernameerror = New System.Windows.Forms.Label()
        Me.passasterick = New System.Windows.Forms.Label()
        Me.userasterick = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.login = New System.Windows.Forms.Label()
        Me.alreadyhacc = New System.Windows.Forms.Label()
        Me.termsandconditions = New System.Windows.Forms.Label()
        Me.checkbox1 = New System.Windows.Forms.CheckBox()
        Me.passwordtxt = New System.Windows.Forms.TextBox()
        Me.usernametxt = New System.Windows.Forms.TextBox()
        Me.emailtxt = New System.Windows.Forms.TextBox()
        Me.contacttxt = New System.Windows.Forms.TextBox()
        Me.nametxt = New System.Windows.Forms.TextBox()
        Me.switch = New System.Windows.Forms.Button()
        Me.nolight = New System.Windows.Forms.PictureBox()
        Me.withlight = New System.Windows.Forms.PictureBox()
        Me.recoveryqueriespanel.SuspendLayout()
        CType(Me.nolight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.withlight, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Q1
        '
        Me.Q1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Q1.Location = New System.Drawing.Point(98, 125)
        Me.Q1.Multiline = True
        Me.Q1.Name = "Q1"
        Me.Q1.Size = New System.Drawing.Size(246, 27)
        Me.Q1.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(95, 246)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(203, 18)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Who is your favourite athlete?"
        '
        'Q3
        '
        Me.Q3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Q3.Location = New System.Drawing.Point(98, 267)
        Me.Q3.Multiline = True
        Me.Q3.Name = "Q3"
        Me.Q3.Size = New System.Drawing.Size(246, 27)
        Me.Q3.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(95, 177)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(251, 18)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "What was your childhood nickname?"
        '
        'Q2
        '
        Me.Q2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Q2.Location = New System.Drawing.Point(98, 198)
        Me.Q2.Multiline = True
        Me.Q2.Name = "Q2"
        Me.Q2.Size = New System.Drawing.Size(246, 27)
        Me.Q2.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(95, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(249, 18)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "What was the name of your first pet?"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(24, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(211, 25)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Security Questions"
        '
        'backbtn
        '
        Me.backbtn.BackColor = System.Drawing.Color.Black
        Me.backbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.backbtn.FlatAppearance.BorderSize = 0
        Me.backbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.backbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.backbtn.ForeColor = System.Drawing.Color.White
        Me.backbtn.Location = New System.Drawing.Point(405, 14)
        Me.backbtn.Name = "backbtn"
        Me.backbtn.Size = New System.Drawing.Size(68, 27)
        Me.backbtn.TabIndex = 0
        Me.backbtn.Text = "Back"
        Me.backbtn.UseVisualStyleBackColor = False
        '
        'recoveryqueriespanel
        '
        Me.recoveryqueriespanel.BackColor = System.Drawing.Color.White
        Me.recoveryqueriespanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.recoveryqueriespanel.Controls.Add(Me.Q1)
        Me.recoveryqueriespanel.Controls.Add(Me.recquesubmitbtn)
        Me.recoveryqueriespanel.Controls.Add(Me.Label5)
        Me.recoveryqueriespanel.Controls.Add(Me.Q3)
        Me.recoveryqueriespanel.Controls.Add(Me.Label4)
        Me.recoveryqueriespanel.Controls.Add(Me.Q2)
        Me.recoveryqueriespanel.Controls.Add(Me.Label3)
        Me.recoveryqueriespanel.Controls.Add(Me.Label2)
        Me.recoveryqueriespanel.Controls.Add(Me.Label1)
        Me.recoveryqueriespanel.Controls.Add(Me.backbtn)
        Me.recoveryqueriespanel.Location = New System.Drawing.Point(219, 166)
        Me.recoveryqueriespanel.Name = "recoveryqueriespanel"
        Me.recoveryqueriespanel.Size = New System.Drawing.Size(489, 342)
        Me.recoveryqueriespanel.TabIndex = 92
        Me.recoveryqueriespanel.Visible = False
        '
        'recquesubmitbtn
        '
        Me.recquesubmitbtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.recquesubmitbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.recquesubmitbtn.FlatAppearance.BorderSize = 0
        Me.recquesubmitbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.recquesubmitbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.recquesubmitbtn.ForeColor = System.Drawing.Color.White
        Me.recquesubmitbtn.Location = New System.Drawing.Point(386, 295)
        Me.recquesubmitbtn.Name = "recquesubmitbtn"
        Me.recquesubmitbtn.Size = New System.Drawing.Size(84, 27)
        Me.recquesubmitbtn.TabIndex = 9
        Me.recquesubmitbtn.Text = "Submit"
        Me.recquesubmitbtn.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(65, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(223, 18)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Incase you forget your password"
        '
        'passworderror
        '
        Me.passworderror.AutoSize = True
        Me.passworderror.ForeColor = System.Drawing.Color.LightCoral
        Me.passworderror.Location = New System.Drawing.Point(85, 433)
        Me.passworderror.Name = "passworderror"
        Me.passworderror.Size = New System.Drawing.Size(164, 13)
        Me.passworderror.TabIndex = 91
        Me.passworderror.Text = "Password cannot contain spaces"
        Me.passworderror.Visible = False
        '
        'usernameerror
        '
        Me.usernameerror.AutoSize = True
        Me.usernameerror.ForeColor = System.Drawing.Color.LightCoral
        Me.usernameerror.Location = New System.Drawing.Point(85, 364)
        Me.usernameerror.Name = "usernameerror"
        Me.usernameerror.Size = New System.Drawing.Size(122, 13)
        Me.usernameerror.TabIndex = 90
        Me.usernameerror.Text = "Username already taken"
        Me.usernameerror.Visible = False
        '
        'passasterick
        '
        Me.passasterick.AutoSize = True
        Me.passasterick.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.passasterick.ForeColor = System.Drawing.Color.Red
        Me.passasterick.Location = New System.Drawing.Point(57, 406)
        Me.passasterick.Name = "passasterick"
        Me.passasterick.Size = New System.Drawing.Size(20, 25)
        Me.passasterick.TabIndex = 89
        Me.passasterick.Text = "*"
        Me.passasterick.Visible = False
        '
        'userasterick
        '
        Me.userasterick.AutoSize = True
        Me.userasterick.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.userasterick.ForeColor = System.Drawing.Color.Red
        Me.userasterick.Location = New System.Drawing.Point(57, 337)
        Me.userasterick.Name = "userasterick"
        Me.userasterick.Size = New System.Drawing.Size(20, 25)
        Me.userasterick.TabIndex = 88
        Me.userasterick.Text = "*"
        Me.userasterick.Visible = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(121, 495)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(143, 30)
        Me.Button1.TabIndex = 87
        Me.Button1.Text = "Submit"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'login
        '
        Me.login.AutoSize = True
        Me.login.BackColor = System.Drawing.Color.Transparent
        Me.login.Cursor = System.Windows.Forms.Cursors.Hand
        Me.login.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.login.ForeColor = System.Drawing.Color.RoyalBlue
        Me.login.Location = New System.Drawing.Point(244, 537)
        Me.login.Name = "login"
        Me.login.Size = New System.Drawing.Size(44, 18)
        Me.login.TabIndex = 86
        Me.login.Text = "Login"
        '
        'alreadyhacc
        '
        Me.alreadyhacc.AutoSize = True
        Me.alreadyhacc.BackColor = System.Drawing.Color.Transparent
        Me.alreadyhacc.Cursor = System.Windows.Forms.Cursors.Default
        Me.alreadyhacc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.alreadyhacc.ForeColor = System.Drawing.SystemColors.ControlText
        Me.alreadyhacc.Location = New System.Drawing.Point(101, 539)
        Me.alreadyhacc.Name = "alreadyhacc"
        Me.alreadyhacc.Size = New System.Drawing.Size(146, 15)
        Me.alreadyhacc.TabIndex = 85
        Me.alreadyhacc.Text = "Already have an account?"
        '
        'termsandconditions
        '
        Me.termsandconditions.AutoSize = True
        Me.termsandconditions.BackColor = System.Drawing.Color.Transparent
        Me.termsandconditions.Cursor = System.Windows.Forms.Cursors.Hand
        Me.termsandconditions.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.termsandconditions.ForeColor = System.Drawing.Color.RoyalBlue
        Me.termsandconditions.Location = New System.Drawing.Point(178, 461)
        Me.termsandconditions.Name = "termsandconditions"
        Me.termsandconditions.Size = New System.Drawing.Size(121, 15)
        Me.termsandconditions.TabIndex = 84
        Me.termsandconditions.Text = "terms and conditions"
        '
        'checkbox1
        '
        Me.checkbox1.AutoSize = True
        Me.checkbox1.BackColor = System.Drawing.Color.Transparent
        Me.checkbox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.checkbox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checkbox1.Location = New System.Drawing.Point(88, 460)
        Me.checkbox1.Name = "checkbox1"
        Me.checkbox1.Size = New System.Drawing.Size(97, 19)
        Me.checkbox1.TabIndex = 83
        Me.checkbox1.Text = "I agree to the"
        Me.checkbox1.UseVisualStyleBackColor = False
        '
        'passwordtxt
        '
        Me.passwordtxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.passwordtxt.Location = New System.Drawing.Point(82, 403)
        Me.passwordtxt.Margin = New System.Windows.Forms.Padding(2)
        Me.passwordtxt.Multiline = True
        Me.passwordtxt.Name = "passwordtxt"
        Me.passwordtxt.Size = New System.Drawing.Size(195, 28)
        Me.passwordtxt.TabIndex = 82
        Me.passwordtxt.WordWrap = False
        '
        'usernametxt
        '
        Me.usernametxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.usernametxt.Location = New System.Drawing.Point(82, 334)
        Me.usernametxt.Margin = New System.Windows.Forms.Padding(2)
        Me.usernametxt.Multiline = True
        Me.usernametxt.Name = "usernametxt"
        Me.usernametxt.Size = New System.Drawing.Size(195, 28)
        Me.usernametxt.TabIndex = 81
        Me.usernametxt.WordWrap = False
        '
        'emailtxt
        '
        Me.emailtxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.emailtxt.Location = New System.Drawing.Point(82, 258)
        Me.emailtxt.Margin = New System.Windows.Forms.Padding(2)
        Me.emailtxt.Multiline = True
        Me.emailtxt.Name = "emailtxt"
        Me.emailtxt.Size = New System.Drawing.Size(195, 28)
        Me.emailtxt.TabIndex = 80
        Me.emailtxt.WordWrap = False
        '
        'contacttxt
        '
        Me.contacttxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.contacttxt.Location = New System.Drawing.Point(82, 185)
        Me.contacttxt.Margin = New System.Windows.Forms.Padding(2)
        Me.contacttxt.Multiline = True
        Me.contacttxt.Name = "contacttxt"
        Me.contacttxt.Size = New System.Drawing.Size(195, 28)
        Me.contacttxt.TabIndex = 79
        Me.contacttxt.WordWrap = False
        '
        'nametxt
        '
        Me.nametxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nametxt.Location = New System.Drawing.Point(82, 115)
        Me.nametxt.Margin = New System.Windows.Forms.Padding(2)
        Me.nametxt.Multiline = True
        Me.nametxt.Name = "nametxt"
        Me.nametxt.Size = New System.Drawing.Size(195, 28)
        Me.nametxt.TabIndex = 78
        Me.nametxt.WordWrap = False
        '
        'switch
        '
        Me.switch.BackColor = System.Drawing.Color.Transparent
        Me.switch.BackgroundImage = Global.kps_auction.My.Resources.Resources.switch_off
        Me.switch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.switch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.switch.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.switch.FlatAppearance.BorderSize = 0
        Me.switch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.switch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.switch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.switch.Location = New System.Drawing.Point(816, 36)
        Me.switch.Name = "switch"
        Me.switch.Size = New System.Drawing.Size(46, 36)
        Me.switch.TabIndex = 75
        Me.switch.TabStop = False
        Me.switch.UseVisualStyleBackColor = False
        '
        'nolight
        '
        Me.nolight.BackColor = System.Drawing.Color.Transparent
        Me.nolight.Image = Global.kps_auction.My.Resources.Resources.nolight
        Me.nolight.Location = New System.Drawing.Point(288, 35)
        Me.nolight.Margin = New System.Windows.Forms.Padding(2)
        Me.nolight.Name = "nolight"
        Me.nolight.Size = New System.Drawing.Size(575, 526)
        Me.nolight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.nolight.TabIndex = 76
        Me.nolight.TabStop = False
        '
        'withlight
        '
        Me.withlight.BackColor = System.Drawing.Color.Transparent
        Me.withlight.Image = Global.kps_auction.My.Resources.Resources.withlight
        Me.withlight.Location = New System.Drawing.Point(288, 35)
        Me.withlight.Margin = New System.Windows.Forms.Padding(2)
        Me.withlight.Name = "withlight"
        Me.withlight.Size = New System.Drawing.Size(575, 526)
        Me.withlight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.withlight.TabIndex = 77
        Me.withlight.TabStop = False
        '
        'signupForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.kps_auction.My.Resources.Resources.LF3
        Me.ClientSize = New System.Drawing.Size(921, 597)
        Me.Controls.Add(Me.recoveryqueriespanel)
        Me.Controls.Add(Me.passworderror)
        Me.Controls.Add(Me.usernameerror)
        Me.Controls.Add(Me.passasterick)
        Me.Controls.Add(Me.userasterick)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.login)
        Me.Controls.Add(Me.alreadyhacc)
        Me.Controls.Add(Me.termsandconditions)
        Me.Controls.Add(Me.checkbox1)
        Me.Controls.Add(Me.passwordtxt)
        Me.Controls.Add(Me.usernametxt)
        Me.Controls.Add(Me.emailtxt)
        Me.Controls.Add(Me.contacttxt)
        Me.Controls.Add(Me.nametxt)
        Me.Controls.Add(Me.switch)
        Me.Controls.Add(Me.nolight)
        Me.Controls.Add(Me.withlight)
        Me.Name = "signupForm"
        Me.Text = "signupForm"
        Me.recoveryqueriespanel.ResumeLayout(False)
        Me.recoveryqueriespanel.PerformLayout()
        CType(Me.nolight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.withlight, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Q1 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Q3 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Q2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents backbtn As Button
    Friend WithEvents recoveryqueriespanel As Panel
    Friend WithEvents recquesubmitbtn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents passworderror As Label
    Friend WithEvents usernameerror As Label
    Friend WithEvents passasterick As Label
    Friend WithEvents userasterick As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents login As Label
    Friend WithEvents alreadyhacc As Label
    Friend WithEvents termsandconditions As Label
    Friend WithEvents checkbox1 As CheckBox
    Friend WithEvents passwordtxt As TextBox
    Friend WithEvents usernametxt As TextBox
    Friend WithEvents emailtxt As TextBox
    Friend WithEvents contacttxt As TextBox
    Friend WithEvents nametxt As TextBox
    Friend WithEvents switch As Button
    Friend WithEvents nolight As PictureBox
    Friend WithEvents withlight As PictureBox


End Class
