Public Class index

    Private Sub index_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AddHandler userlog.FormClosed, AddressOf Main_FormClosed
        AddHandler admin_login.FormClosed, AddressOf admin_FormClosed
    End Sub
    Private Sub Main_FormClosed(ByVal sender As Object, ByVal e As FormClosedEventArgs)
        Me.Close()
    End Sub
    Private Sub admin_FormClosed(ByVal sender As Object, ByVal e As FormClosedEventArgs)
        Me.Close()
    End Sub
End Class