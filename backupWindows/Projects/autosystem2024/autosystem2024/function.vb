Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Text.RegularExpressions
Module functions

    Dim reader As MySqlDataReader
    Dim command As MySqlCommand
    Dim query As String
    Dim arrimage() As Byte
    Dim msstream As MemoryStream

    '
    Function connection() As MySqlConnection
        Return New MySqlConnection("server=localhost;userid=root;password=;database=auto_system2024")
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

    Public Sub clearFunction()
        Main.fullname.Text = Nothing
        Main.email.Text = Nothing
        Main.phone.Text = Nothing
        Main.passport.Image = Nothing
        Main.profile_id.SelectedIndex = 0
    End Sub

    Public Function GetImageArray(ByVal image As Image) As Byte()
        Dim msstream As New System.IO.MemoryStream()
        image.Save(msstream, System.Drawing.Imaging.ImageFormat.Jpeg)
        Dim arrimage As Byte() = msstream.GetBuffer()
        Dim filesize As UInt32 = msstream.Length
        msstream.Close()
        Return arrimage
    End Function
    Sub GetUserIds()
        Dim DT As New DataTable
        Dim connection = functions.connection

        connection.Open()
        command = New MySqlCommand("SELECT * FROM users_tab", connection)
        DT.Load(command.ExecuteReader)
        connection.Close()

        Dim defaultRow As DataRow = DT.NewRow()
        defaultRow("user_id") = ""
        defaultRow("full_name") = "SELECT USER"
        defaultRow("email_address") = ""
        defaultRow("phone_number") = ""
        defaultRow("created_time") = Date.Now
        defaultRow("updated_time") = Date.Now
        DT.Rows.InsertAt(defaultRow, 0)

        Main.profile_id.DataSource = DT
        Main.profile_id.DisplayMember = "full_name"
        Main.profile_id.ValueMember = "user_id"

    End Sub

    Public Sub Updated()
        Try
            'allow passport to save
            Dim arrimage As Byte() = GetImageArray(Main.passport.Image)

            Dim connection = functions.connection
            connection.Open()


            query = "UPDATE `users_tab` SET full_name=@full_name, email_address=@email_address, phone_number=@phone_number, passport=@passport WHERE user_id=@user_id"
            Dim Command As New MySqlCommand(query, connection)
            Command.Parameters.AddWithValue("@user_id", Main.profile_id.SelectedValue)
            command.Parameters.AddWithValue("@full_name", Main.fullname.Text.ToUpper())
            command.Parameters.AddWithValue("@email_address", Main.email.Text)
            command.Parameters.AddWithValue("@phone_number", Main.phone.Text)
            command.Parameters.AddWithValue("@Passport", arrimage)


            reader = command.ExecuteReader()
            connection.Close()
            MessageBox.Show("User Updated Successfully.", "Auto System Application", MessageBoxButtons.OK, MessageBoxIcon.Information)
            functions.GetUserIds()

        Catch ex As Exception

            MessageBox.Show("User Update Failed: " & ex.Message, "Auto System Application", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Function countUsers() As Integer
        Dim connection = functions.connection
        Dim userCount As Integer

        connection.Open()
        command = New MySqlCommand("SELECT COUNT(*) FROM users_tab", connection)
        userCount = Convert.ToInt32(command.ExecuteScalar())
        connection.Close()

        Return userCount
    End Function
    Public Sub delete()
        Try
            Dim connection = functions.connection
            connection.Open()
            query = "DELETE FROM users_tab WHERE user_id=@user_id"
            command = New MySqlCommand(query, connection)
            command.Parameters.AddWithValue("@user_id", Main.profile_id.SelectedValue)
            reader = command.ExecuteReader

            MessageBox.Show("User Deleted Successfully.", "Auto System Application", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Main.Label1.Text = countUsers()
            functions.clearFunction()
            functions.GetUserIds()

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
            command.Parameters.AddWithValue("@email_address", Main.email.Text)
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
    Function updateemailCheck(ByVal email As String)
        Dim connection = functions.connection

        connection.Open()
        command = New MySqlCommand("SELECT * FROM users_tab WHERE email_address=@email_address AND user_id!=@user_id", connection)
        command.Parameters.AddWithValue("@email_address", email)
        command.Parameters.AddWithValue("@user_id", Main.profile_id.SelectedValue)
        reader = command.ExecuteReader
        Dim validateEmails = reader.Read()
        connection.Close()
        Return validateEmails
    End Function
    Public Sub registration()
        Dim arrimage As Byte() = GetImageArray(Main.passport.Image)
        Dim user_id As String = "USER" & Now.ToString("yyyyMMddss") & functions.countId("USER")

        Try
            Dim connection = functions.connection
            connection.Open()

            query = "INSERT INTO users_tab (user_id, full_name, email_address, phone_number, passport, created_time) VALUES (@user_id, @full_name, @email_address, @phone_number, @passport, NOW())"
            Dim Command As New MySqlCommand(query, connection)
            Command.Parameters.AddWithValue("@user_id", user_id)
            Command.Parameters.AddWithValue("@full_name", Main.fullname.Text.ToUpper())
            Command.Parameters.AddWithValue("@email_address", Main.email.Text)
            Command.Parameters.AddWithValue("@phone_number", Main.phone.Text)
            Command.Parameters.AddWithValue("@passport", arrimage)

            reader = Command.ExecuteReader()
            connection.Close()

            MessageBox.Show("User Registration successful!", "Auto System Application", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Main.Label1.Text = countUsers()
            'user_count_label_txt.Text = user_count_label_txt.Text + 1
            functions.clearFunction()
            functions.GetUserIds()

        Catch ex As Exception

            MessageBox.Show("User Registration failed: " & ex.Message, "Auto System Application", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub
End Module