Public Class admin_login

    Private Sub exit_home_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles exit_home.Click
        Dim answer As Integer
        answer = MessageBox.Show("Are you sure you want to Exit", "Exit Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If answer = vbYes Then
            Me.Close()
        End If
    End Sub

    Private Sub login_link_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles login_link.LinkClicked
        admin_log_panel.Show()
        admin_reset_panel.Hide()
    End Sub

    Private Sub forgotpass_link_LinkClicked_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles forgotpass_link.LinkClicked
        admin_reset_panel.Show()
        admin_log_panel.Hide()
    End Sub

    Private Sub proceed_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles proceed_btn.Click
        index.Show()
        admin_reset_password.Show()
    End Sub

    Private Sub admin_login_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles admin_login_btn.Click
        Admin_dashboard.Show()
    End Sub
End Class