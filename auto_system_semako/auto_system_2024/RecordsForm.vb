Imports MySql.Data.MySqlClient
Public Class RecordsForm
    Private Sub LoadUserRecords(ByVal connection As MySqlConnection)
        Try
            Dim query As String = "SELECT * FROM auto_system_new_db.users_tab"

            Dim adapter As New MySqlDataAdapter(query, connection)
            Dim table As New DataTable()

            adapter.Fill(table)
            DataGridView1.DataSource = table

            If DataGridView1.Columns.Contains("Passport") Then
                DataGridView1.Columns("Passport").Width = 100
            End If
        Catch ex As MySqlException
            MessageBox.Show("An error occurred while fetching user records: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show("An unexpected error occurred while loading records: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub RecordsForm_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Try
            'getUser_id()
            user_count_label_txt.Text = countUsers()

            Using connection As MySqlConnection = functions.connection()
                connection.Open()
                LoadUserRecords(connection)
            End Using

        Catch ex As MySqlException
            MessageBox.Show("Error connecting to the database: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show("An unexpected error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub closed_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles closed_btn.Click
        Dim closeValidation = MessageBox.Show("Are you sure you want to exit the application?", "Exit Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If closeValidation = vbYes Then
            Application.Exit()
        End If
    End Sub

    Private Sub home_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles home_btn.Click
        Me.Hide()
        main.Show()
        main.ShowInTaskbar = True

    End Sub
End Class
