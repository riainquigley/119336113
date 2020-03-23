Public Class FrmLogin
    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Creating a password and login


    End Sub

    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        'Creating a password and login
        If TxtEmail.Text = "Employee@gmail.com" And TxtPassword.Text = "groupproject" Then
            MsgBox("You Are Now Logged In", MsgBoxStyle.Information, "login")
            Me.Show()
            Me.Hide()
            FrmNewOrders.Show()
        Else
            MsgBox("Invalid Log In")
        End If
    End Sub
End Class
