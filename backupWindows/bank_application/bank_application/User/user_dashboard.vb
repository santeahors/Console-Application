Public Class user_dashboard

    Private Sub user_dashboard_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        index_form.Close()
    End Sub

   
    Private Sub requestForLoanBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles requestForLoanBtn.Click
        overlay.Show()
        loan_request_form.Show()
    End Sub

    Private Sub loginUserBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles loginUserBtn.Click
        Dim closeValidation = MessageBox.Show("Are you sure you want to Logout?", "Logout Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If closeValidation = vbYes Then
            Me.Hide()
            index_form.Show()
        End If
    End Sub
End Class