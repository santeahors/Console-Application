Imports MySql.Data.MySqlClient

Public Class index
    Private Sub index_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim connection = functions.connection
        Try
            connection.Open()
            If connection.State = ConnectionState.Open Then
                MsgBox("AUTO SYSTEM Connection successful.")
            End If
        Catch ex As MySqlException
            MsgBox("Connection failed: " & ex.Message)
            Me.Close()
        Finally
            connection.Close()
        End Try

        Main.Show()
        AddHandler Main.FormClosed, AddressOf Main_FormClosed
    End Sub

    Private Sub Main_FormClosed(ByVal sender As Object, ByVal e As FormClosedEventArgs)
        Me.Close()
    End Sub

    Private Function GetDebuggerDisplay() As String
        Return ToString()
    End Function
End Class