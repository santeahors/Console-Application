Public Class Admin_dashboard

    Private Sub time_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles time.Click

    End Sub

    Private Sub Admin_dashboard_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim currentDate As Date = Date.Today

        time.Text = DateTime.Now.ToString("h:mm:ss tt")
        date_txt.Text = currentDate.ToString("dddd, MMMM dd, yyyy")
    End Sub
End Class