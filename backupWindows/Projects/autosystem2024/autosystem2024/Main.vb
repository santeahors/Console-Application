Imports System.IO
Imports MySql.Data.MySqlClient
Public Class Main
    Dim connection = functions.connection
    Dim query As String
    Dim arrimage() As Byte
    Dim reader As MySqlDataReader
    Dim command As New MySqlCommand
    Dim msstream As MemoryStream


    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetUserIds()
        Label1.Text = countUsers()
    End Sub

    Private Sub close_btn_Click(sender As Object, e As EventArgs) Handles close_btn.Click

        Dim answer = MessageBox.Show("Are you sure you want to Exit", "Exit Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If answer = vbYes Then
            Me.Close()
        End If
    End Sub

    Private Sub selectpicture_btn_Click(sender As Object, e As EventArgs) Handles selectpicture_btn.Click
        Dim fd As New OpenFileDialog
        Dim response As DialogResult
        If fullname.Text = "" Or email.Text = "" Or phone.Text = "" Then
            response = MessageBox.Show("Fill The Fields Before Selecting Passport To continue!", "Auto System Application", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            fd.Filter = "Choose image(*.gif;*.bmp;*.wmf;*.JPEG;*.PNG;*.GIF;*.JPG;)|*.jpeg;*.png;*.gif;*.jpg;*.gif;*.bmp;*.wmf;"
            If fd.ShowDialog = DialogResult.OK Then
                passport.Image = Image.FromFile(fd.FileName)
            End If
        End If
        fd = Nothing
    End Sub

    Private Sub submit_btn_Click(sender As Object, e As EventArgs) Handles submit_btn.Click
        Dim response As DialogResult
        If fullname.Text = "" Or email.Text = "" Or phone.Text = "" Then
            MessageBox.Show("All Fields are Required!", "Auto System Application", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf validateEmail(email.Text) = False Then
            MessageBox.Show("Please Enter a valid Email Address to Continue!", "Auto System Application", MessageBoxButtons.OK, MessageBoxIcon.Error)
            email.Text = ""
            email.Focus()
            Exit Sub
        ElseIf phone.TextLength < 10 Then
            MessageBox.Show("Please Enter a valid Phone Number to Continue!", "Auto System Application", MessageBoxButtons.OK, MessageBoxIcon.Error)
            phone.Text = ""
            phone.Focus()
            Exit Sub
        ElseIf passport.Image Is Nothing Then
            MessageBox.Show("Please Select a Passport to Continue!", "Auto System Application", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If (profile_id.Text = "SELECT USER") Then
                response = MessageBox.Show("Are You Sure You Want to Save?", "Auto System Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If response = vbYes Then
                    If Not functions.vetEmail() Then
                        functions.registration()

                    End If
                End If

            Else
                response = MessageBox.Show("Are You Sure You Want to update?", "Auto System Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If response = vbYes Then
                    If updateemailCheck(email.Text) Then
                        MessageBox.Show("This Email Address Already Exists!", "Auto System Application", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If

                    functions.Updated()
                End If
            End If
        End If

    End Sub

    Private Sub clear_btn_Click(sender As Object, e As EventArgs) Handles clear_btn.Click
        clearFunction()
    End Sub

    Private Sub fetch_btn_Click(sender As Object, e As EventArgs) Handles fetch_btn.Click
        Dim response As DialogResult
        If profile_id.Text = "SELECT USER..........." Then
            response = MessageBox.Show("Select User Name To Continue!", "Auto System Application", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Try
                connection.Open()
                query = "SELECT * FROM users_tab WHERE user_id=@user_id"

                command = New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@user_id", profile_id.SelectedValue)

                reader = command.ExecuteReader()

                If reader.Read() Then
                    fullname.Text = reader("full_name")
                    email.Text = reader("email_address")
                    phone.Text = reader("phone_number")

                    arrimage = If(IsDBNull(reader("passport")), Nothing, CType(reader("passport"), Byte()))

                    If arrimage IsNot Nothing AndAlso arrimage.Length > 0 Then
                        '
                        Dim stream As New MemoryStream(arrimage)

                        passport.Image = Image.FromStream(stream)
                        stream.Close()
                    End If
                End If
            Catch ex As Exception
                MessageBox.Show("Error: " + ex.Message, "Auto System Application", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                'connection.Close()
            End Try
            connection.Close()
        End If
    End Sub
    Private Sub view_rec_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles record_btn.Click
        Me.Hide()
        Dim recordsForm As New Recordform
        Recordform.ShowDialog()
        Recordform.ShowInTaskbar = True
    End Sub


    Private Sub fullname_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles fullname.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsWhiteSpace(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
            MessageBox.Show("This field allows only Letters!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    '---------------------------------------Security for the phone numbers-------------------------------------------------------
    Private Sub phone_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles phone.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> "+"c AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
            MessageBox.Show("This field allows only Numbers and '+'!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    Private Sub email_txt_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles email.KeyPress
        If e.KeyChar = "."c AndAlso DirectCast(sender, TextBox).Text.IndexOf("."c) > -1 Then
            e.Handled = True
            MessageBox.Show("A Dot Only Allowed in this Field!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf e.KeyChar = "."c AndAlso (DirectCast(sender, TextBox).TextLength = 0 OrElse Not Char.IsDigit(DirectCast(sender, TextBox).Text.Last()) AndAlso Not Char.IsLetter(DirectCast(sender, TextBox).Text.Last())) Then
            e.Handled = True
            MessageBox.Show("A Dot before letters is not Allowed in this Field!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub


    Private Sub delete_btn_Click(sender As Object, e As EventArgs) Handles delete_btn.Click
        Dim response As DialogResult
        If profile_id.Text = "Select Profile" Then
            MessageBox.Show("Select User And Proceed!", "Auto System Application", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            response = MessageBox.Show("Are You Sure You Want to Delete?", "Auto System Application", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If response = vbYes Then
                functions.delete()

            End If
        End If
    End Sub


End Class