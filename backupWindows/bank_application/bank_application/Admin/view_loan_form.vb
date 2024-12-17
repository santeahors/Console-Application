Public Class view_loan_form

    Private Sub closeBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles closeBtn.Click
        Me.Close()
        overlay.Close()
    End Sub

    Private Sub CloseButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseButton.Click
        Me.Close()
        overlay.Close()
    End Sub

    Private Sub loan_schedule_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles loan_schedule_btn.Click
        Me.Hide()
        loan_schedule_form.Show()
    End Sub
End Class