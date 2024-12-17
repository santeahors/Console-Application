Public Class deposit_form

    Private Sub closeBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles closeBtn.Click
        overlay.Close()
        Me.Close()
    End Sub

    Private Sub transBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles transBtn.Click
        Me.Hide()
        transaction_form.Show()
    End Sub

    Private Sub ClearButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearButton.Click
        deposit_txt.Text = ""
    End Sub
End Class