Imports MySql.Data.MySqlClient
Public Class index
    Private Sub index_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim connection = functions.connection
        Try
            connection.Open()
            If connection.State = ConnectionState.Open Then
                MessageBox.Show("Connection successful.", "Auto System Application", MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If
        Catch ex As MySqlException
            MsgBox("Connection failed: " & ex.Message)
            Me.Close()
        Finally
            connection.Close()
        End Try

        main.Show()


    End Sub



End Class
