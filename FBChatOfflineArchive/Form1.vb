Public Class LoginForm

    Private Sub LoginForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None

    End Sub

    Private Sub txtUsername_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtUsername.GotFocus
        txtUsername.ForeColor = System.Drawing.SystemColors.WindowText
        If txtUsername.Text = "Email or Phone" Then
            txtUsername.Text = ""
        End If

    End Sub

    Private Sub txtUsername_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtUsername.LostFocus
        txtUsername.ForeColor = System.Drawing.SystemColors.ControlDark
        If txtUsername.Text = "" Then
            txtUsername.Text = "Email or Phone"
        End If
    End Sub

    Private Sub txtPassword_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPassword.GotFocus
        txtPassword.ForeColor = System.Drawing.SystemColors.WindowText
        If txtPassword.Text = "Password" Then
            txtPassword.Text = ""
        End If
    End Sub

    Private Sub txtPassword_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPassword.LostFocus
        txtPassword.ForeColor = System.Drawing.SystemColors.ControlDark
        If txtPassword.Text = "" Then
            txtPassword.Text = "Password"
        End If
    End Sub
End Class
