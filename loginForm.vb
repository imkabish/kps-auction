Imports System.Data.SqlClient

Public Class LoginForm

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitializePlaceholder()
        Timer1.Interval = 1000
        Timer1.Start()
    End Sub

    ' Initialize placeholder text for username and password fields
    Private Sub InitializePlaceholder()
        SetPlaceholder(usernametextbox, "Enter username")
        SetPlaceholder(passwordtextbox, "Enter password", False)
        Me.ActiveControl = wallpaper
    End Sub

    ' Generic method to set placeholder
    Private Sub SetPlaceholder(textbox As TextBox, placeholder As String, Optional isPassword As Boolean = True)
        textbox.Text = placeholder
        textbox.ForeColor = Color.Gray
        If isPassword Then textbox.PasswordChar = "" ' Empty password char if placeholder is shown
    End Sub

    ' Handle focus events for placeholders
    Private Sub Textbox_Enter(sender As Object, e As EventArgs) Handles usernametextbox.Enter, passwordtextbox.Enter
        Dim textbox = DirectCast(sender, TextBox)
        If textbox.ForeColor = Color.Gray Then
            textbox.Text = ""
            textbox.ForeColor = Color.Black
            If textbox Is passwordtextbox Then textbox.PasswordChar = "*"c
        End If
    End Sub

    Private Sub Textbox_Leave(sender As Object, e As EventArgs) Handles usernametextbox.Leave, passwordtextbox.Leave
        Dim textbox = DirectCast(sender, TextBox)
        If String.IsNullOrWhiteSpace(textbox.Text) Then
            If textbox Is usernametextbox Then
                SetPlaceholder(textbox, "Enter username")
            Else
                SetPlaceholder(textbox, "Enter password", False)
            End If
        End If
    End Sub

    ' Toggle password visibility
    Private Sub TogglePasswordVisibility()
        If passwordtextbox.PasswordChar = "*"c Then
            passwordtextbox.PasswordChar = ""
            showpasslogo.Visible = True
            hidepasslogo.Visible = False
        Else
            passwordtextbox.PasswordChar = "*"c
            showpasslogo.Visible = False
            hidepasslogo.Visible = True
        End If
    End Sub

    Private Sub showpasslogo_Click(sender As Object, e As EventArgs) Handles showpasslogo.Click
        TogglePasswordVisibility()
    End Sub

    Private Sub hidepasslogo_Click(sender As Object, e As EventArgs) Handles hidepasslogo.Click
        TogglePasswordVisibility()
    End Sub

    ' Timer tick event to update the current time on the label
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label1.Text = DateTime.Now.ToString("hh:mm:ss tt")
    End Sub

    ' Validate login button click event
    ' Validate login button click event
    Private Sub loginbtn_Click(sender As Object, e As EventArgs) Handles loginbtn.Click
        If IsPlaceholderText(usernametextbox.Text, passwordtextbox.Text) Then
            MessageBox.Show("Please enter both username and password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim role As String = ValidateLoginCredentials(usernametextbox.Text, passwordtextbox.Text)
        If Not String.IsNullOrEmpty(role) Then
            If role = "admin" Then
                Dim adminIndex As New AdminIndex()
                adminIndex.Show()
            ElseIf role = "user" Then
                Dim userIndex As New UserIndex()
                userIndex.Show()
            End If
            Me.Hide()  ' Hide the current form (LoginForm)
        Else
            MessageBox.Show("Incorrect username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            InitializePlaceholder()
        End If
    End Sub


    ' Helper function to check placeholder text
    Private Function IsPlaceholderText(username As String, password As String) As Boolean
        Return username = "Enter username" OrElse password = "Enter password"
    End Function

    ' Validate login credentials against the database
    ' Validate login credentials and return role
    Private Function ValidateLoginCredentials(username As String, password As String) As String
        Dim connectionString As String = "Server=_SABER_X\SQLEXPRESS;Database=KPS;Integrated Security=True;"
        Dim query As String = "SELECT role FROM userdetails WHERE username = @username AND password = @password"

        Try
            Using connection As New SqlConnection(connectionString)
                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@username", username)
                    command.Parameters.AddWithValue("@password", password)

                    connection.Open()
                    Dim role As String = Convert.ToString(command.ExecuteScalar())
                    Return role
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Failed to connect to the database: " & ex.Message)
            Return Nothing
        End Try
    End Function


    ' Change label color on hover events
    Private Sub Label_MouseHover(sender As Object, e As EventArgs) Handles forgetpasslabel.MouseHover, signuplabel.MouseHover
        DirectCast(sender, Label).ForeColor = Color.FromArgb(16, 40, 161)
    End Sub

    Private Sub Label_MouseLeave(sender As Object, e As EventArgs) Handles forgetpasslabel.MouseLeave, signuplabel.MouseLeave
        DirectCast(sender, Label).ForeColor = Color.FromArgb(69, 128, 230)
    End Sub

    ' Handle form click to clear focus from any control
    Private Sub LoginForm_Click(sender As Object, e As EventArgs) Handles MyBase.Click
        Me.ActiveControl = Nothing
    End Sub

    ' Open signup form
    Private Sub signuplabel_Click(sender As Object, e As EventArgs) Handles signuplabel.Click
        Me.Hide()  ' Hide the current form (LoginForm)
        signupForm.Show()  ' Show the signup form
    End Sub

    ' Toggle password visibility via hideit button click
    Private Sub hideit_Click(sender As Object, e As EventArgs) Handles hideit.Click
        If passwordtextbox.PasswordChar = "*"c Then
            passwordtextbox.PasswordChar = "" ' Show password
            hideit.Text = "Hide Password"
        Else
            passwordtextbox.PasswordChar = "*"c ' Hide password
            hideit.Text = "Show Password"
        End If
    End Sub


End Class
