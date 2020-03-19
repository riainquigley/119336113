Public Class frmlogin
    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        'Creating a password and login

        If TxtUserName.Text = "employees@gmail.com" And TxtPassword.Text = "Groupproject" Then
            MsgBox("You Are Now Logged In", MsgBoxStyle.Information, "login")
            Me.Show()
            Me.Hide()
            FrmCustomerDetails.Show()
        Else
            MsgBox("Invalid Log In")
        End If
    End Sub
End Class
