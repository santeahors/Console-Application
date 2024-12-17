Public Class userlogin_form

    Private Sub closeBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles closeBtn.Click
        Me.Close()
        overlay.Close()
    End Sub

    Private Sub loginUserBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles loginUserBtn.Click
        Me.Close()
        user_dashboard.Show()
        overlay.Close()
        index_form.Hide()
    End Sub

    Private Sub ForgotPass_Label_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ForgotPass_Label.Click
        Me.Hide()
        user_reset_pass_form.Show()
    End Sub

    Private Sub userlogin_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class