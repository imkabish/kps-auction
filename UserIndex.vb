Imports System.Collections.Specialized.BitVector32
Imports System.Security.Policy

Public Class UserIndex
    Private side As Boolean = False

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Home_Click(sender As Object, e As EventArgs) Handles Home.Click
        Panel4.Height = Home.Height
        Panel4.Top = Home.Top
    End Sub

    Private Sub Auction_Click(sender As Object, e As EventArgs) Handles Auction.Click
        Panel4.Height = Auction.Height
        Panel4.Top = Auction.Top
    End Sub

    Private Sub MyActivity_Click(sender As Object, e As EventArgs) Handles MyActivity.Click
        Panel4.Height = MyActivity.Height
        Panel4.Top = MyActivity.Top
    End Sub

    Private Sub Settings_Click(sender As Object, e As EventArgs) Handles Settings.Click
        Panel4.Height = Settings.Height
        Panel4.Top = Settings.Top
    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Panel4_Paint(sender As Object, e As PaintEventArgs) Handles Panel4.Paint

    End Sub


    Private Sub ToggleSidebar_Click(sender As Object, e As EventArgs) Handles Usercross.Click
        If side Then
            Panel1.Width = 50
            Usercross.Image = My.Resources.uham
        Else
            Panel1.Width = 237
            Usercross.Image = My.Resources.ucross
        End If
        side = Not side
    End Sub
    Private Sub SignOut_Click(sender As Object, e As EventArgs) Handles SignOut.Click
        Me.Hide()
        LoginForm.Show()
    End Sub
End Class
