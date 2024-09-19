<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserIndex
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
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Usercross = New System.Windows.Forms.Button()
        Me.SignOut = New System.Windows.Forms.Button()
        Me.Auction = New System.Windows.Forms.Button()
        Me.Settings = New System.Windows.Forms.Button()
        Me.MyActivity = New System.Windows.Forms.Button()
        Me.Home = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.Control
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Font = New System.Drawing.Font("Bahnschrift Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel3.Location = New System.Drawing.Point(200, 34)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(744, 542)
        Me.Panel3.TabIndex = 11
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(200, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(744, 34)
        Me.Panel2.TabIndex = 10
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.Panel4.Location = New System.Drawing.Point(-1, 142)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(5, 36)
        Me.Panel4.TabIndex = 4
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.Panel1.Controls.Add(Me.SignOut)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.Auction)
        Me.Panel1.Controls.Add(Me.Settings)
        Me.Panel1.Controls.Add(Me.MyActivity)
        Me.Panel1.Controls.Add(Me.Home)
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 576)
        Me.Panel1.TabIndex = 9
        '
        'Usercross
        '
        Me.Usercross.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Usercross.FlatAppearance.BorderSize = 0
        Me.Usercross.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Usercross.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Usercross.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Usercross.Image = Global.kps_auction.My.Resources.Resources.ucross
        Me.Usercross.Location = New System.Drawing.Point(128, -13)
        Me.Usercross.Name = "Usercross"
        Me.Usercross.Size = New System.Drawing.Size(69, 64)
        Me.Usercross.TabIndex = 8
        Me.Usercross.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Usercross.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Usercross.UseVisualStyleBackColor = True
        '
        'SignOut
        '
        Me.SignOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.SignOut.FlatAppearance.BorderSize = 0
        Me.SignOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SignOut.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SignOut.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.SignOut.Image = Global.kps_auction.My.Resources.Resources.usignout
        Me.SignOut.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.SignOut.Location = New System.Drawing.Point(56, 475)
        Me.SignOut.Name = "SignOut"
        Me.SignOut.Size = New System.Drawing.Size(69, 64)
        Me.SignOut.TabIndex = 7
        Me.SignOut.Text = "Sign out"
        Me.SignOut.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.SignOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.SignOut.UseVisualStyleBackColor = True
        '
        'Auction
        '
        Me.Auction.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Auction.FlatAppearance.BorderSize = 0
        Me.Auction.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Auction.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Auction.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Auction.Image = Global.kps_auction.My.Resources.Resources.uauc
        Me.Auction.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Auction.Location = New System.Drawing.Point(-1, 204)
        Me.Auction.Name = "Auction"
        Me.Auction.Size = New System.Drawing.Size(193, 53)
        Me.Auction.TabIndex = 6
        Me.Auction.Text = "Auction"
        Me.Auction.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Auction.UseVisualStyleBackColor = True
        '
        'Settings
        '
        Me.Settings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Settings.FlatAppearance.BorderSize = 0
        Me.Settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Settings.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Settings.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Settings.Image = Global.kps_auction.My.Resources.Resources.usetting
        Me.Settings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Settings.Location = New System.Drawing.Point(1, 324)
        Me.Settings.Name = "Settings"
        Me.Settings.Size = New System.Drawing.Size(191, 62)
        Me.Settings.TabIndex = 5
        Me.Settings.Text = "  Settings"
        Me.Settings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Settings.UseVisualStyleBackColor = True
        '
        'MyActivity
        '
        Me.MyActivity.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.MyActivity.FlatAppearance.BorderSize = 0
        Me.MyActivity.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MyActivity.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MyActivity.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.MyActivity.Image = Global.kps_auction.My.Resources.Resources.uactive
        Me.MyActivity.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.MyActivity.Location = New System.Drawing.Point(-2, 263)
        Me.MyActivity.Name = "MyActivity"
        Me.MyActivity.Size = New System.Drawing.Size(194, 55)
        Me.MyActivity.TabIndex = 1
        Me.MyActivity.Text = " My Activity"
        Me.MyActivity.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.MyActivity.UseVisualStyleBackColor = True
        '
        'Home
        '
        Me.Home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Home.FlatAppearance.BorderSize = 0
        Me.Home.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Home.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Home.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Home.Image = Global.kps_auction.My.Resources.Resources.uhome
        Me.Home.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Home.Location = New System.Drawing.Point(3, 142)
        Me.Home.Name = "Home"
        Me.Home.Size = New System.Drawing.Size(194, 56)
        Me.Home.TabIndex = 0
        Me.Home.Text = " Home"
        Me.Home.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Home.UseVisualStyleBackColor = True
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.Usercross)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel5.Location = New System.Drawing.Point(3, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(197, 576)
        Me.Panel5.TabIndex = 9
        '
        'UserIndex
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(944, 576)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "UserIndex"
        Me.Text = "UserIndex"
        Me.Panel1.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel3 As Panel
    Friend WithEvents SignOut As Button
    Friend WithEvents Settings As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents MyActivity As Button
    Friend WithEvents Home As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Usercross As Button
    Friend WithEvents Auction As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Panel5 As Panel
End Class
