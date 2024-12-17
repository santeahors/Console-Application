Imports MySql.Data.MySqlClient
Public Class index_form


    Private Sub loginUserBtn_Click(sender As Object, e As EventArgs) Handles loginUserBtn.Click
        overlay.Show()
        userlogin_form.Show()
    End Sub

    Private Sub loginAdminBtn_Click(sender As Object, e As EventArgs) Handles loginAdminBtn.Click
        overlay.Show()
        adminlogin_form.Show()
    End Sub

    Private Sub index_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
         Guna2Panel1.BackColor = Color.FromArgb(140, 255, 255, 255)
    End Sub
End Class
