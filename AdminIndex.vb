Imports Microsoft.VisualBasic.ApplicationServices
Imports System.Collections.Specialized.BitVector32

Public Class AdminIndex
    Private side As Boolean = False
    Private ReadOnly placeholder As String = "Search here..."
    Private ReadOnly hamburgerImage As Image = My.Resources.hamburger
    Private ReadOnly crossburgerImage As Image = My.Resources.crossburger
    Private ReadOnly tooltip As New ToolTip()

    Private Sub AdminIndex_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitializeToolTip()
        InitializeSearchTextBox()
        Button1.Image = crossburgerImage
        ShowPanel(homePanel, My.Resources.home)
    End Sub

    ' Initialize tooltips for various controls
    Private Sub InitializeToolTip()
        With tooltip
            .SetToolTip(home, "Home page")
            .SetToolTip(auction, "Auction page")
            .SetToolTip(users, "User view")
            .SetToolTip(stats, "Statistics page")
            .SetToolTip(reports, "Report Analysis")
            .SetToolTip(profileUser, "User Profile")
            .SetToolTip(settings, "Settings")
            .InitialDelay = 0
            .AutoPopDelay = 5000
            .ReshowDelay = 0
            .ShowAlways = True
        End With
    End Sub

    ' Initialize search textbox with placeholder
    Private Sub InitializeSearchTextBox()
        txtSearch.Text = placeholder
        txtSearch.ForeColor = Color.Gray
    End Sub

    ' Toggle sidebar width and button icon on click
    Private Sub ToggleSidebar_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If side Then
            sidebar.Width = 50
            Button1.Image = hamburgerImage
        Else
            sidebar.Width = 237
            Button1.Image = crossburgerImage
        End If
        side = Not side
    End Sub

    ' Show specified panel and set currentPanel image
    Private Sub ShowPanel(panelToShow As Form, panelImage As Image)
        HideAllPanels()
        currentPanel.Image = panelImage
        ShowPanelInControl(panelToShow)
    End Sub

    ' Hide all panels to display only one at a time
    Private Sub HideAllPanels()
        For Each panel In New Control() {homePanel, auctionPanel, usersPanel, statsPanel, reportsPanel}
            panel.Hide()
        Next
    End Sub

    ' Add panel to display area and bring it to the front
    Private Sub ShowPanelInControl(panelToShow As Form)
        With panelToShow
            .TopLevel = False
            panelHome.Controls.Add(panelToShow)
            .BringToFront()
            .Show()
        End With
    End Sub

    ' Event handlers for navigation buttons to show respective panels
    Private Sub home_Click(sender As Object, e As EventArgs) Handles home.Click
        ShowPanel(homePanel, My.Resources.home)
    End Sub

    Private Sub auction_Click(sender As Object, e As EventArgs) Handles auction.Click
        ShowPanel(auctionPanel, My.Resources.auctions)
    End Sub

    Private Sub users_Click(sender As Object, e As EventArgs) Handles users.Click
        ShowPanel(usersPanel, My.Resources.users)
    End Sub

    Private Sub stats_Click(sender As Object, e As EventArgs) Handles stats.Click
        ShowPanel(statsPanel, My.Resources.stats)
    End Sub

    Private Sub reports_Click(sender As Object, e As EventArgs) Handles reports.Click
        ShowPanel(reportsPanel, My.Resources.reports)
    End Sub

    ' Logout button closes the current form
    Private Sub logout_Click(sender As Object, e As EventArgs) Handles logout.Click
        Me.Hide()
        LoginForm.Show()
    End Sub

    ' Search textbox gets focus and clears placeholder
    Private Sub txtSearch_GotFocus(sender As Object, e As EventArgs) Handles txtSearch.GotFocus
        If txtSearch.Text = placeholder Then
            txtSearch.Text = String.Empty
            txtSearch.ForeColor = Color.Black
        End If
    End Sub

    ' Search textbox loses focus and restores placeholder if empty
    Private Sub txtSearch_LostFocus(sender As Object, e As EventArgs) Handles txtSearch.LostFocus
        If String.IsNullOrEmpty(txtSearch.Text) Then
            txtSearch.Text = placeholder
            txtSearch.ForeColor = Color.Gray
        End If
    End Sub

    ' Search icon click triggers the search logic
    Private Sub pbSearchIcon_Click(sender As Object, e As EventArgs) Handles pbSearchIcon.Click
        Dim searchText As String = txtSearch.Text
        If Not String.IsNullOrEmpty(searchText) AndAlso searchText <> placeholder Then
            ' Implement actual search logic here (currently shows a message)
            MessageBox.Show("Searching for: " & searchText)
        Else
            MessageBox.Show("Please enter a valid search query.", "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub


End Class
