Public Class userlog

    Private Sub exit_home_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles exit_home.Click
        Dim answer As Integer
        answer = MessageBox.Show("Are you sure you want to Exit", "Exit Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If answer = vbYes Then
            Me.Close()
        End If
    End Sub


    Private Sub forgotpass_link_LinkClicked_2(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles forgotpass_link.LinkClicked
        resetpass_panel.Show()
        login_panel.Hide()
    End Sub

    Private Sub login_link_LinkClicked_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles login_link.LinkClicked
        login_panel.Show()
        resetpass_panel.Hide()
    End Sub

    Private Sub proceed_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles proceed_btn.Click
        index.Show()
        reset_password.Show()
    End Sub
End Class