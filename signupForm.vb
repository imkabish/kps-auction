Public Class signupForm

    Dim switchstate As Boolean = False
    Private Sub signupForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Initializeplaceholder()
        'Me.IsMdiContainer = True
        recqueinitializer()
    End Sub

    Private Sub Initializeplaceholder()
        nametxt.Text = "Enter name"
        contacttxt.Text = "Contact no"
        emailtxt.Text = "Enter email"
        usernametxt.Text = "Enter username"
        passwordtxt.Text = "Enter password"
        nametxt.ForeColor = Color.Gray
        contacttxt.ForeColor = Color.Gray
        emailtxt.ForeColor = Color.Gray
        usernametxt.ForeColor = Color.Gray
        passwordtxt.ForeColor = Color.Gray
        Me.ActiveControl = withlight
    End Sub

    Private Sub switch_Click(sender As Object, e As EventArgs) Handles switch.Click
        If switchstate = False Then
            switch.BackgroundImage = My.Resources.switch_on
            withlight.BringToFront()
            switch.BringToFront()
            switchstate = True
        ElseIf switchstate = True Then
            switch.BackgroundImage = My.Resources.switch_off
            nolight.BringToFront()
            switch.BringToFront()
            switchstate = False
        End If
        switch.BackgroundImageLayout = ImageLayout.Stretch
        nametxt.BringToFront()
        contacttxt.BringToFront()
        emailtxt.BringToFront()
        usernametxt.BringToFront()
        passwordtxt.BringToFront()
        termsandconditions.BringToFront()
        recoveryqueriespanel.BringToFront()
    End Sub

    Private Sub termsandconditions_MouseHover(sender As Object, e As EventArgs) Handles termsandconditions.MouseHover
        termsandconditions.Font = New Font(termsandconditions.Font, FontStyle.Underline)
        termsandconditions.ForeColor = Color.Blue
    End Sub

    Private Sub termsandconditions_MouseLeave(sender As Object, e As EventArgs) Handles termsandconditions.MouseLeave
        termsandconditions.Font = New Font(termsandconditions.Font, FontStyle.Regular)
        termsandconditions.ForeColor = Color.RoyalBlue
    End Sub

    Private Sub login_MouseHover(sender As Object, e As EventArgs) Handles login.MouseHover
        login.Font = New Font("sansserif", 11.25, FontStyle.Underline)
        login.ForeColor = Color.Blue
    End Sub

    Private Sub login_MouseLeave(sender As Object, e As EventArgs) Handles login.MouseLeave
        login.ForeColor = Color.RoyalBlue
        login.Font = New Font("sansserif", 11.25, FontStyle.Regular)
    End Sub

    Private Sub Form1_Click(sender As Object, e As EventArgs) Handles MyBase.Click
        Me.ActiveControl = Nothing
    End Sub

    Private Sub nametxt_Enter(sender As Object, e As EventArgs) Handles nametxt.Enter
        If nametxt.Text = "Enter name" Then
            nametxt.Text = ""
            nametxt.ForeColor = Color.Black
        End If
    End Sub

    Private Sub nametxt_Leave(sender As Object, e As EventArgs) Handles nametxt.Leave
        If nametxt.Text = String.Empty Then
            nametxt.Text = "Enter name"
            nametxt.ForeColor = Color.Gray
        End If
    End Sub

    Private Sub contacttxt_Enter(sender As Object, e As EventArgs) Handles contacttxt.Enter
        If contacttxt.Text = "Contact no" Then
            contacttxt.Text = ""
            contacttxt.ForeColor = Color.Black
        End If
    End Sub

    Private Sub contacttxt_Leave(sender As Object, e As EventArgs) Handles contacttxt.Leave
        If contacttxt.Text = String.Empty Then
            contacttxt.Text = "Contact no"
            contacttxt.ForeColor = Color.Gray
        End If
    End Sub

    Private Sub emailtxt_Enter(sender As Object, e As EventArgs) Handles emailtxt.Enter
        If emailtxt.Text = "Enter email" Then
            emailtxt.Text = ""
            emailtxt.ForeColor = Color.Black
        End If
    End Sub

    Private Sub emailtxt_Leave(sender As Object, e As EventArgs) Handles emailtxt.Leave
        If emailtxt.Text = String.Empty Then
            emailtxt.Text = "Enter email"
            emailtxt.ForeColor = Color.Gray
        End If
    End Sub

    Private Sub usernametxt_Enter(sender As Object, e As EventArgs) Handles usernametxt.Enter
        If usernametxt.Text = "Enter username" Then
            usernametxt.Text = ""
            usernametxt.ForeColor = Color.Black
        End If
    End Sub

    Private Sub usernametxt_Leave(sender As Object, e As EventArgs) Handles usernametxt.Leave
        If usernametxt.Text = String.Empty Then
            usernametxt.Text = "Enter username"
            usernameerror.Visible = False
            userasterick.Visible = False
            usernametxt.ForeColor = Color.Gray
        ElseIf usernametxt.Text.Contains(" ") Then
            usernameerror.Visible = True
            userasterick.Visible = True
            usernameerror.Text = "Username cannot contain spaces"
        Else
            userasterick.Visible = False
            usernameerror.Visible = False
        End If
    End Sub

    Private Sub passwordtxt_Enter(sender As Object, e As EventArgs) Handles passwordtxt.Enter
        If passwordtxt.Text = "Enter password" Then
            passwordtxt.PasswordChar = "*"
            passwordtxt.Text = ""
            passwordtxt.ForeColor = Color.Black
        End If
    End Sub

    Private Sub passwordtxt_Leave(sender As Object, e As EventArgs) Handles passwordtxt.Leave
        If passwordtxt.Text = String.Empty Then
            passwordtxt.Text = "Enter password"
            passworderror.Visible = False
            passasterick.Visible = False
            'passworderror.Text = "Password cannot be empty"
            passwordtxt.PasswordChar = ""
            passwordtxt.ForeColor = Color.Gray
        ElseIf passwordtxt.Text.Contains(" ") Then
            passworderror.Visible = True
            passasterick.Visible = True
            passworderror.Text = "Password cannot contain spaces"
        Else
            passworderror.Visible = False
            passasterick.Visible = False
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        recoveryqueriespanel.Visible = True
    End Sub

    Private Sub recqueinitializer()
        Q1.Text = "Your answer"
        Q2.Text = "Your answer"
        Q3.Text = "Your answer"
        Q1.ForeColor = Color.Gray
        Q2.ForeColor = Color.Gray
        Q3.ForeColor = Color.Gray
    End Sub

    Private Sub backbtn_Click(sender As Object, e As EventArgs) Handles backbtn.Click
        recoveryqueriespanel.Hide()
    End Sub

    Private Sub Q1_Enter(sender As Object, e As EventArgs) Handles Q1.Enter
        If Q1.Text = "Your answer" Then
            Q1.Text = ""
            Q1.ForeColor = Color.Black
        End If
    End Sub

    Private Sub Q1_Leave(sender As Object, e As EventArgs) Handles Q1.Leave
        If Q1.Text = String.Empty Then
            Q1.Text = "Your answer"
            Q1.ForeColor = Color.Gray
        End If
    End Sub
    Private Sub Q2_Enter(sender As Object, e As EventArgs) Handles Q2.Enter
        If Q2.Text = "Your answer" Then
            Q2.Text = ""
            Q2.ForeColor = Color.Black
        End If
    End Sub

    Private Sub Q2_Leave(sender As Object, e As EventArgs) Handles Q2.Leave
        If Q2.Text = String.Empty Then
            Q2.Text = "Your answer"
            Q2.ForeColor = Color.Gray
        End If
    End Sub
    Private Sub Q3_Enter(sender As Object, e As EventArgs) Handles Q3.Enter
        If Q3.Text = "Your answer" Then
            Q3.Text = ""
            Q3.ForeColor = Color.Black
        End If
    End Sub

    Private Sub Q3_Leave(sender As Object, e As EventArgs) Handles Q3.Leave
        If Q3.Text = String.Empty Then
            Q3.Text = "Your answer"
            Q3.ForeColor = Color.Gray
        End If
    End Sub

    Private Sub recoveryqueriespanel_Click(sender As Object, e As EventArgs) Handles recoveryqueriespanel.Click
        Me.ActiveControl = Nothing
    End Sub

    Private Sub nolight_Click(sender As Object, e As EventArgs) Handles nolight.Click

    End Sub

    Private Sub nametxt_TextChanged(sender As Object, e As EventArgs) Handles nametxt.TextChanged

    End Sub

    Private Sub usernametxt_TextChanged(sender As Object, e As EventArgs) Handles usernametxt.TextChanged

    End Sub

    Private Sub contacttxt_TextChanged(sender As Object, e As EventArgs) Handles contacttxt.TextChanged

    End Sub

    Private Sub usernameerror_Click(sender As Object, e As EventArgs) Handles usernameerror.Click

    End Sub

    Private Sub emailtxt_TextChanged(sender As Object, e As EventArgs) Handles emailtxt.TextChanged

    End Sub

    Private Sub withlight_Click(sender As Object, e As EventArgs) Handles withlight.Click

    End Sub

    Private Sub passasterick_Click(sender As Object, e As EventArgs) Handles passasterick.Click

    End Sub

    Private Sub login_Click(sender As Object, e As EventArgs) Handles login.Click
        Me.Hide()
        LoginForm.Show()

    End Sub

    Private Sub userasterick_Click(sender As Object, e As EventArgs) Handles userasterick.Click

    End Sub

    Private Sub recoveryqueriespanel_Paint(sender As Object, e As PaintEventArgs) Handles recoveryqueriespanel.Paint

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub termsandconditions_Click(sender As Object, e As EventArgs) Handles termsandconditions.Click

    End Sub

    Private Sub recquesubmitbtn_Click(sender As Object, e As EventArgs) Handles recquesubmitbtn.Click

    End Sub

    Private Sub Q1_TextChanged(sender As Object, e As EventArgs) Handles Q1.TextChanged

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub checkbox1_CheckedChanged(sender As Object, e As EventArgs) Handles checkbox1.CheckedChanged

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub passwordtxt_TextChanged(sender As Object, e As EventArgs) Handles passwordtxt.TextChanged

    End Sub

    Private Sub Q2_TextChanged(sender As Object, e As EventArgs) Handles Q2.TextChanged

    End Sub

    Private Sub Q3_TextChanged(sender As Object, e As EventArgs) Handles Q3.TextChanged

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub alreadyhacc_Click(sender As Object, e As EventArgs) Handles alreadyhacc.Click

    End Sub

    Private Sub passworderror_Click(sender As Object, e As EventArgs) Handles passworderror.Click

    End Sub
End Class
