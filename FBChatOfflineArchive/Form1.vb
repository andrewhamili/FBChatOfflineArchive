Imports MySql.Data.MySqlClient
Public Class LoginForm

    Public AssumeWindowMove As Boolean = False
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

    Private Sub btnLogin_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.MouseEnter
        btnLogin.BackColor = Me.BackColor
    End Sub

    Private Sub btnLogin_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.MouseLeave
        btnLogin.BackColor = Color.FromArgb(66, 103, 178)
    End Sub

    Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        If MySQLConn.State = ConnectionState.Open Then
            MySQLConn.Close()
        End If

        MySQLConn.ConnectionString = connstring
        Try
            MySQLConn.Open()
            comm = New MySqlCommand("SELECT * FROM messages.accountlist WHERE username=sha2(@username, 512) and password=sha2(@password, 512);", MySQLConn)
            comm.Parameters.AddWithValue("username", txtUsername.Text)
            comm.Parameters.AddWithValue("password", txtPassword.Text)
            reader = comm.ExecuteReader
            Dim count As Integer
            While reader.Read
                count += 1
            End While
            MySQLConn.Close()
            If count > 0 Then
                Messages.Show()
            Else
                MsgBox("Incorrect credentials")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            MySQLConn.Dispose()
        End Try

    End Sub
End Class
