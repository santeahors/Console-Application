
Imports Guna.UI2.WinForms
Imports System.Drawing
Imports System.Drawing.Drawing2D
Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Guna2Panel1.BackColor = Color.FromArgb(140, 255, 255, 255)
    End Sub

    Private Sub user_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles user_btn.Click
        index.Show()
        userlog.Show()
    End Sub
   
    Private Sub admin_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles admin_btn.Click
        index.Show()
        admin_login.Show()
    End Sub

    Private Sub Guna2Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Guna2Panel1.Paint

    End Sub
End Class
