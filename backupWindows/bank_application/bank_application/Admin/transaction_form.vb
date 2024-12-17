Public Class transaction_form

    Private Sub closeBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles closeBtn.Click
        Me.Close()
        overlay.Close()
    End Sub

    Private Sub backBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles backBtn.Click
        Me.Close()
        deposit_form.Show()
    End Sub
End Class