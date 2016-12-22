Imports MySql.Data.MySqlClient

Public Class Register

    Private Sub btnChooseImage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChooseImage.Click
        If OFD_ChoosePicture.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
            PictureBox_AccountPicture.Image = Image.FromFile(OFD_ChoosePicture.FileName)
        End If
    End Sub

    Private Sub btnRegister_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegister.Click
        If txtfbFirstname.Text = "" Or txtfbLastname.Text = "" Or txtfbUniqueUserID.Text = "" Or txtUsername.Text = "" Or txtPassword.Text = "" Then
            MsgBox("Please Fill-up the necessary fields to continue registration.", MsgBoxStyle.Exclamation, "Registration")
        Else

            Dim mstream As New System.IO.MemoryStream()
            PictureBox_AccountPicture.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
            Dim arrImage() As Byte = mstream.GetBuffer
            mstream.Close()
            MySQLConn.ConnectionString = connstring

            Try
                MySQLConn.Open()
                comm = New MySqlCommand("INSERT INTO accountlist VALUES(sha2(@username, 512), sha2(@password, 512), @fbfirstname, @fbmiddlename, @fblastname, @fbuuid, @fbimage)", MySQLConn)
                comm.Parameters.AddWithValue("username", txtUsername.Text)
                comm.Parameters.AddWithValue("password", txtPassword.Text)
                comm.Parameters.AddWithValue("fbfirstname", txtfbFirstname.Text)
                comm.Parameters.AddWithValue("fbmiddlename", txtfbMiddlename.Text)
                comm.Parameters.AddWithValue("fblastname", txtfbLastname.Text)
                comm.Parameters.AddWithValue("fbuuid", txtfbUniqueUserID.Text)
                comm.Parameters.AddWithValue("fbimage", arrImage)
                reader = comm.ExecuteReader
                MsgBox("Successfully Registered")
                MySQLConn.Close()
            Catch ex As Exception
                If ex.Message.Contains("duplicate") Then
                    MsgBox("Duplicate data detected!")
                Else
                    MsgBox(ex.Message)
                End If

            Finally
                MySQLConn.Dispose()
            End Try
        End If
    End Sub
End Class