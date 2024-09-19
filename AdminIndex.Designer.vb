<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminIndex
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdminIndex))
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.pbSearchIcon = New System.Windows.Forms.PictureBox()
        Me.panelHome = New System.Windows.Forms.Panel()
        Me.sidebar = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.home = New System.Windows.Forms.Button()
        Me.currentPanel = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.logout = New System.Windows.Forms.Button()
        Me.settings = New System.Windows.Forms.Button()
        Me.auction = New System.Windows.Forms.Button()
        Me.users = New System.Windows.Forms.Button()
        Me.stats = New System.Windows.Forms.Button()
        Me.reports = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.profileUser = New System.Windows.Forms.PictureBox()
        Me.Panel2.SuspendLayout()
        CType(Me.pbSearchIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.sidebar.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.currentPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.profileUser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer2
        '
        Me.Timer2.Interval = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Poppins", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(349, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 26)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "ADMIN PANEL"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.Window
        Me.Panel2.Controls.Add(Me.txtSearch)
        Me.Panel2.Controls.Add(Me.pbSearchIcon)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(237, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(728, 50)
        Me.Panel2.TabIndex = 19
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(43, 14)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(86, 20)
        Me.txtSearch.TabIndex = 1
        '
        'pbSearchIcon
        '
        Me.pbSearchIcon.Image = CType(resources.GetObject("pbSearchIcon.Image"), System.Drawing.Image)
        Me.pbSearchIcon.Location = New System.Drawing.Point(23, 14)
        Me.pbSearchIcon.Name = "pbSearchIcon"
        Me.pbSearchIcon.Size = New System.Drawing.Size(106, 20)
        Me.pbSearchIcon.TabIndex = 2
        Me.pbSearchIcon.TabStop = False
        '
        'panelHome
        '
        Me.panelHome.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.panelHome.BackColor = System.Drawing.SystemColors.Window
        Me.panelHome.Location = New System.Drawing.Point(237, 50)
        Me.panelHome.Name = "panelHome"
        Me.panelHome.Size = New System.Drawing.Size(730, 548)
        Me.panelHome.TabIndex = 20
        '
        'sidebar
        '
        Me.sidebar.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.sidebar.Controls.Add(Me.Panel1)
        Me.sidebar.Dock = System.Windows.Forms.DockStyle.Left
        Me.sidebar.Location = New System.Drawing.Point(0, 0)
        Me.sidebar.Name = "sidebar"
        Me.sidebar.Size = New System.Drawing.Size(237, 702)
        Me.sidebar.TabIndex = 17
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightGreen
        Me.Panel1.BackgroundImage = Global.kps_auction.My.Resources.Resources.gogreen__1_
        Me.Panel1.Controls.Add(Me.home)
        Me.Panel1.Controls.Add(Me.currentPanel)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.logout)
        Me.Panel1.Controls.Add(Me.settings)
        Me.Panel1.Controls.Add(Me.auction)
        Me.Panel1.Controls.Add(Me.users)
        Me.Panel1.Controls.Add(Me.stats)
        Me.Panel1.Controls.Add(Me.reports)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(237, 702)
        Me.Panel1.TabIndex = 0
        '
        'home
        '
        Me.home.BackColor = System.Drawing.Color.Transparent
        Me.home.Cursor = System.Windows.Forms.Cursors.Hand
        Me.home.FlatAppearance.BorderSize = 0
        Me.home.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.home.Image = Global.kps_auction.My.Resources.Resources.home
        Me.home.Location = New System.Drawing.Point(192, 75)
        Me.home.Name = "home"
        Me.home.Size = New System.Drawing.Size(45, 47)
        Me.home.TabIndex = 14
        Me.home.UseVisualStyleBackColor = False
        '
        'currentPanel
        '
        Me.currentPanel.BackColor = System.Drawing.Color.Transparent
        Me.currentPanel.Location = New System.Drawing.Point(12, 492)
        Me.currentPanel.Name = "currentPanel"
        Me.currentPanel.Size = New System.Drawing.Size(100, 83)
        Me.currentPanel.TabIndex = 13
        Me.currentPanel.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Poppins", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label6.Location = New System.Drawing.Point(0, 151)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(90, 26)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "AUCTIONS"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Poppins", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Location = New System.Drawing.Point(0, 361)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 26)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "REPORTS"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Poppins", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(3, 221)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 26)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "USERS"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Poppins", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(0, 291)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 26)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "STATISTICS"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Poppins", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(0, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 26)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "HOME"
        '
        'logout
        '
        Me.logout.BackColor = System.Drawing.Color.Transparent
        Me.logout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.logout.FlatAppearance.BorderSize = 0
        Me.logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.logout.Image = Global.kps_auction.My.Resources.Resources.logout
        Me.logout.Location = New System.Drawing.Point(195, 504)
        Me.logout.Name = "logout"
        Me.logout.Size = New System.Drawing.Size(45, 47)
        Me.logout.TabIndex = 7
        Me.logout.UseVisualStyleBackColor = False
        '
        'settings
        '
        Me.settings.BackColor = System.Drawing.Color.Transparent
        Me.settings.Cursor = System.Windows.Forms.Cursors.Hand
        Me.settings.FlatAppearance.BorderSize = 0
        Me.settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.settings.Image = Global.kps_auction.My.Resources.Resources.settings
        Me.settings.Location = New System.Drawing.Point(195, 455)
        Me.settings.Name = "settings"
        Me.settings.Size = New System.Drawing.Size(42, 43)
        Me.settings.TabIndex = 6
        Me.settings.UseVisualStyleBackColor = False
        '
        'auction
        '
        Me.auction.BackColor = System.Drawing.Color.Transparent
        Me.auction.Cursor = System.Windows.Forms.Cursors.Hand
        Me.auction.FlatAppearance.BorderSize = 0
        Me.auction.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.auction.Image = Global.kps_auction.My.Resources.Resources.auctions
        Me.auction.Location = New System.Drawing.Point(192, 140)
        Me.auction.Name = "auction"
        Me.auction.Size = New System.Drawing.Size(45, 47)
        Me.auction.TabIndex = 5
        Me.auction.UseVisualStyleBackColor = False
        '
        'users
        '
        Me.users.BackColor = System.Drawing.Color.Transparent
        Me.users.Cursor = System.Windows.Forms.Cursors.Hand
        Me.users.FlatAppearance.BorderSize = 0
        Me.users.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.users.Image = Global.kps_auction.My.Resources.Resources.users
        Me.users.Location = New System.Drawing.Point(192, 210)
        Me.users.Name = "users"
        Me.users.Size = New System.Drawing.Size(45, 47)
        Me.users.TabIndex = 4
        Me.users.UseVisualStyleBackColor = False
        '
        'stats
        '
        Me.stats.BackColor = System.Drawing.Color.Transparent
        Me.stats.Cursor = System.Windows.Forms.Cursors.Hand
        Me.stats.FlatAppearance.BorderSize = 0
        Me.stats.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.stats.Image = Global.kps_auction.My.Resources.Resources.stats
        Me.stats.Location = New System.Drawing.Point(192, 280)
        Me.stats.Name = "stats"
        Me.stats.Size = New System.Drawing.Size(45, 47)
        Me.stats.TabIndex = 3
        Me.stats.UseVisualStyleBackColor = False
        '
        'reports
        '
        Me.reports.BackColor = System.Drawing.Color.Transparent
        Me.reports.Cursor = System.Windows.Forms.Cursors.Hand
        Me.reports.FlatAppearance.BorderSize = 0
        Me.reports.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.reports.Image = Global.kps_auction.My.Resources.Resources.reports
        Me.reports.Location = New System.Drawing.Point(189, 350)
        Me.reports.Name = "reports"
        Me.reports.Size = New System.Drawing.Size(45, 47)
        Me.reports.TabIndex = 2
        Me.reports.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Image = Global.kps_auction.My.Resources.Resources.crossburger
        Me.Button1.Location = New System.Drawing.Point(192, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(45, 47)
        Me.Button1.TabIndex = 0
        Me.Button1.UseVisualStyleBackColor = False
        '
        'profileUser
        '
        Me.profileUser.BackColor = System.Drawing.SystemColors.Window
        Me.profileUser.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.profileUser.Cursor = System.Windows.Forms.Cursors.Hand
        Me.profileUser.Dock = System.Windows.Forms.DockStyle.Right
        Me.profileUser.Image = Global.kps_auction.My.Resources.Resources.profile
        Me.profileUser.Location = New System.Drawing.Point(965, 0)
        Me.profileUser.Name = "profileUser"
        Me.profileUser.Size = New System.Drawing.Size(61, 702)
        Me.profileUser.TabIndex = 18
        Me.profileUser.TabStop = False
        '
        'AdminIndex
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1026, 702)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.panelHome)
        Me.Controls.Add(Me.sidebar)
        Me.Controls.Add(Me.profileUser)
        Me.Name = "AdminIndex"
        Me.Text = "AdminIndex"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.pbSearchIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.sidebar.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.currentPanel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.profileUser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Timer2 As Timer
    Friend WithEvents pbSearchIcon As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents currentPanel As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents settings As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents auction As Button
    Friend WithEvents users As Button
    Friend WithEvents reports As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents panelHome As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents home As Button
    Friend WithEvents stats As Button
    Friend WithEvents sidebar As Panel
    Friend WithEvents profileUser As PictureBox
    Friend WithEvents logout As Button
End Class
