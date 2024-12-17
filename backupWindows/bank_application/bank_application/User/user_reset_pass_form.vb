Public Class user_reset_pass_form

    Private Sub closeBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles closeBtn.Click
        Me.Close()
        overlay.Close()
    End Sub

    
    Private Sub backBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles backBtn.Click
        Me.Hide()
        userlogin_form.Show()
    End Sub
End Class