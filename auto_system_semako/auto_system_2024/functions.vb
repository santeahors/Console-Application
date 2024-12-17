Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Text.RegularExpressions
Module functions
    Dim reader As MySqlDataReader
    Dim command As MySqlCommand
    Dim msstream As New MemoryStream
    Dim arrimage() As Byte
    Dim query As String
    Function connection()
        Dim conn As New MySqlConnection("server=localhost;userid=root;password=;database=auto_system_new_db")
        Return conn
    End Function
    Function countId(ByVal counter_id As String)
        Dim connection = functions.connection

        connection.Open()
        command = New MySqlCommand("UPDATE counters_tab SET counter_value=counter_value+1 WHERE counter_id=@counter_id", connection)
        command.Parameters.AddWithValue("@counter_id", counter_id)
        reader = command.ExecuteReader
        connection.Close()

        connection.Open()
        command = New MySqlCommand("SELECT counter_value FROM counters_tab WHERE counter_id=@counter_id", connection)
        command.Parameters.AddWithValue("@counter_id", counter_id)
        reader = command.ExecuteReader
        reader.Read()
        Dim counter_value = reader("counter_value")
        connection.Close()
        Return counter_value
    End Function

    Function countUsers() As Integer
        Dim connection = functions.connection
        Dim userCount As Integer

        connection.Open()
        command = New MySqlCommand("SELECT COUNT(*) FROM users_tab", connection)
        userCount = Convert.ToInt32(command.ExecuteScalar())
        connection.Close()

        Return userCount
    End Function

    Public Sub clearFunction()
        main.full_name_txt.Text = Nothing
        main.email_txt.Text = Nothing
        main.phone_number_txt.Text = Nothing
        main.passport.Image = Nothing
        main.profile_id.SelectedIndex = 0
    End Sub

    Public Sub getUser_id()
        Dim DT As New DataTable
        Dim connection = functions.connection

        connection.Open()
        command = New MySqlCommand("SELECT * FROM users_tab", connection)
        DT.Load(command.ExecuteReader)
        connection.Close()

        Dim defaultRow As DataRow = DT.NewRow()
        defaultRow("user_id") = ""
        defaultRow("full_name") = "SELECT USER..........."
        defaultRow("email_address") = ""
        defaultRow("phone_number") = ""
        defaultRow("created_time") = Date.Now
        defaultRow("updated_time") = Date.Now
        DT.Rows.InsertAt(defaultRow, 0)

        main.profile_id.DataSource = DT
        main.profile_id.DisplayMember = "full_name"
        main.profile_id.ValueMember = "user_id"

    End Sub

    Public Function GetImageArray(ByVal image As Image) As Byte()
        Dim msstream As New System.IO.MemoryStream()
        image.Save(msstream, System.Drawing.Imaging.ImageFormat.Jpeg)
        Dim arrimage As Byte() = msstream.GetBuffer()
        Dim filesize As UInt32 = msstream.Length
        msstream.Close()
        Return arrimage
    End Function

    Public Sub registration()
        Dim arrimage As Byte() = GetImageArray(main.passport.Image)
        Dim user_id As String = "USER" & Now.ToString("yyyyMMddss") & functions.countId("USER")

        Try
            Dim connection = functions.connection
            connection.Open()

            query = "INSERT INTO users_tab (user_id, full_name, email_address, phone_number, passport, created_time) VALUES (@user_id, @full_name, @email_address, @phone_number, @passport, NOW())"
            Dim Command As New MySqlCommand(query, connection)
            Command.Parameters.AddWithValue("@user_id", user_id)
            Command.Parameters.AddWithValue("@full_name", main.full_name_txt.Text.ToUpper())
            Command.Parameters.AddWithValue("@email_address", main.email_txt.Text)
            Command.Parameters.AddWithValue("@phone_number", main.phone_number_txt.Text)
            Command.Parameters.AddWithValue("@passport", arrimage)

            reader = Command.ExecuteReader()
            connection.Close()

            MessageBox.Show("User Registration successful!", "Auto System Application", MessageBoxButtons.OK, MessageBoxIcon.Information)
            main.user_count_label_txt.Text = countUsers()
            'user_count_label_txt.Text = user_count_label_txt.Text + 1
            functions.clearFunction()
            functions.getUser_id()

        Catch ex As Exception

            MessageBox.Show("User Registration failed: " & ex.Message, "Auto System Application", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

    End Sub

    Public Sub fetchuser()
            Dim response As DialogResult
        If main.profile_id.Text = "SELECT USER..........." Then
            response = MessageBox.Show("Select User Name To Continue!", "Auto System Application", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Try
                Dim connection = functions.connection
                connection.Open()
                query = "SELECT* FROM users_tab WHERE user_id=@user_id"
                command = New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@user_id", main.profile_id.SelectedValue)
                reader = command.ExecuteReader
                reader.Read()
                main.full_name_txt.Text = reader("full_name")
                main.email_txt.Text = reader("email_address")
                main.phone_number_txt.Text = reader("phone_number")
                arrimage = reader("passport")

                Dim msstream As New MemoryStream(arrimage)
                main.passport.Image = Image.FromStream(msstream)
            Catch ex As Exception

                MessageBox.Show("Error: " + ex.Message, "Auto System Application", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                'connection.Close()
            End Try
            connection.Close()
        End If
    End Sub
    Public Sub updateUser()
        Try
            Dim arrimage As Byte() = GetImageArray(main.passport.Image)

            Dim connection = functions.connection
            connection.Open()

            query = "UPDATE `users_tab` SET full_name=@full_name, email_address=@email_address, phone_number=@phone_number, passport=@passport WHERE user_id=@user_id"
            Dim Command As New MySqlCommand(query, connection)
            Command.Parameters.AddWithValue("@user_id", main.profile_id.SelectedValue)
            Command.Parameters.AddWithValue("@full_name", main.full_name_txt.Text.ToUpper())
            Command.Parameters.AddWithValue("@email_address", main.email_txt.Text)
            Command.Parameters.AddWithValue("@phone_number", main.phone_number_txt.Text)
            Command.Parameters.AddWithValue("@passport", arrimage)

            reader = Command.ExecuteReader()
            connection.Close()
            MessageBox.Show("User Updated Successfully.", "Auto System Application", MessageBoxButtons.OK, MessageBoxIcon.Information)
            functions.getUser_id()

        Catch ex As Exception

            MessageBox.Show("User Update Failed: " & ex.Message, "Auto System Application", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Function updateemailCheck(ByVal email As String)
        Dim connection = functions.connection

        connection.Open()
        command = New MySqlCommand("SELECT * FROM users_tab WHERE email_address=@email_address AND user_id!=@user_id", connection)
        command.Parameters.AddWithValue("@email_address", email)
        command.Parameters.AddWithValue("@user_id", main.profile_id.SelectedValue)
        reader = command.ExecuteReader
        Dim validateEmails = reader.Read()
        connection.Close()
        Return validateEmails
    End Function

    Public Sub delete()
        Try
             Dim connection = functions.connection
            connection.Open()
            query = "DELETE FROM users_tab WHERE user_id=@user_id"
            command = New MySqlCommand(query, connection)
            command.Parameters.AddWithValue("@user_id", main.profile_id.SelectedValue)
            reader = command.ExecuteReader

            MessageBox.Show("User Deleted Successfully.", "Auto System Application", MessageBoxButtons.OK, MessageBoxIcon.Information)
            main.user_count_label_txt.Text = countUsers()
            functions.clearFunction()
            functions.getUser_id()

        Catch ex As Exception
            MessageBox.Show("Error: " + ex.Message)
        Finally
            'connection.Close()
        End Try
        connection.Close()

    End Sub

    Public Function vetEmail() As Boolean

        Try
            Dim connection = functions.connection
            Dim userCount As Integer

            connection.Open()
            command = New MySqlCommand("SELECT * FROM users_tab WHERE email_address=@email_address", connection)
            command.Parameters.AddWithValue("@email_address", main.email_txt.Text)
            userCount = Convert.ToInt32(command.ExecuteScalar())
            connection.Close()

            If (userCount > 0) Then
                MessageBox.Show("Email Address already exists. Please enter a new one.", "Auto System Application", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return True
            End If

            connection.Close()

        Catch ex As Exception
            MessageBox.Show("Check Email Failed: " & ex.Message, "Auto System Application", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return False
    End Function

    Public Function validateEmail(ByVal emailAddress As String) As Boolean
        Dim email As New Regex("^([0-9a-zA-Z]([-\.\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,9})$")
        If email.IsMatch(emailAddress) Then
            Return True
        Else
            Return False
        End If
    End Function

End Module
