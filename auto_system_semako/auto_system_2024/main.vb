Imports MySql.Data.MySqlClient
Public Class main
    Dim connection = functions.connection
    Dim query As String
    Dim arrimage() As Byte
    Dim reader As MySqlDataReader
    Dim command As New MySqlCommand

    Private Sub main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        getUser_id()
        user_count_label_txt.Text = countUsers()
    End Sub

    Private Sub close_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles close_btn.Click
        Dim close_validation = MessageBox.Show("Are you sure you want to Exit", "Exit Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If close_validation = vbYes Then
            Me.Close()
            index.Close()
        End If
    End Sub

    Private Sub select_passport_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles select_passport_btn.Click
        'select passport
        Dim fd As New OpenFileDialog
        Dim response As DialogResult
        If full_name_txt.Text = "" Or email_txt.Text = "" Or phone_number_txt.Text = "" Then
            response = MessageBox.Show("Fill The Fields Before Selecting Passport To continue!", "Auto System Application", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            fd.Filter = "Choose image(*.gif;*.bmp;*.wmf;*.JPEG;*.PNG;*.GIF;*.JPG;)|*.jpeg;*.png;*.gif;*.jpg;*.gif;*.bmp;*.wmf;"
            If fd.ShowDialog = DialogResult.OK Then
                passport.Image = Image.FromFile(fd.FileName)
            End If
        End If
        fd = Nothing
    End Sub

    Private Sub clear_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clear_btn.Click
        functions.clearFunction()
    End Sub

    Private Sub save_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles save_btn.Click

        Dim response As DialogResult
        If full_name_txt.Text = "" Or email_txt.Text = "" Or phone_number_txt.Text = "" Then
            MessageBox.Show("All Fields are Required!", "Auto System Application", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf validateEmail(email_txt.Text) = False Then
            MessageBox.Show("Please Enter a valid Email Address to Continue!", "Auto System Application", MessageBoxButtons.OK, MessageBoxIcon.Error)
            email_txt.Text = ""
            email_txt.Focus()
            Exit Sub
        ElseIf phone_number_txt.TextLength < 10 Then
            MessageBox.Show("Please Enter a valid Phone Number to Continue!", "Auto System Application", MessageBoxButtons.OK, MessageBoxIcon.Error)
            phone_number_txt.Text = ""
            phone_number_txt.Focus()
            Exit Sub
        ElseIf passport.Image Is Nothing Then
            MessageBox.Show("Please Select a Passport to Continue!", "Auto System Application", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If (profile_id.Text = "SELECT USER...........") Then
                response = MessageBox.Show("Are You Sure You Want to Save?", "Auto System Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If response = vbYes Then
                    If Not functions.vetEmail() Then
                        functions.registration()

                    End If
                End If

            Else
                response = MessageBox.Show("Are You Sure You Want to update?", "Auto System Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If response = vbYes Then
                    If updateemailCheck(email_txt.Text) Then
                        MessageBox.Show("This Email Address Already Exists!", "Auto System Application", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If

                    functions.updateUser()
                End If
            End If
        End If
    End Sub

    Private Sub fetch_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fetch_btn.Click
        functions.fetchuser()
    End Sub

    Private Sub delete_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles delete_btn.Click
        Dim response As DialogResult
        If profile_id.Text = "SELECT USER..........." Then
            MessageBox.Show("Select User And Proceed!", "Auto System Application", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            response = MessageBox.Show("Are You Sure You Want to Delete?", "Auto System Application", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If response = vbYes Then
                functions.delete()

            End If
        End If
    End Sub

    Private Sub view_rec_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles view_rec_btn.Click
        Me.Hide()
        Dim recordsForm As New RecordsForm
        recordsForm.ShowDialog()
        recordsForm.ShowInTaskbar = True
    End Sub

    Private Sub full_name_txt_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles full_name_txt.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsWhiteSpace(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
            MessageBox.Show("This field allows only Letters!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub email_txt_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles email_txt.KeyPress
        If e.KeyChar = "."c AndAlso DirectCast(sender, TextBox).Text.IndexOf("."c) > -1 Then
            e.Handled = True
            MessageBox.Show("A Dot Only Allowed in this Field!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf e.KeyChar = "."c AndAlso (DirectCast(sender, TextBox).TextLength = 0 OrElse Not Char.IsDigit(DirectCast(sender, TextBox).Text.Last()) AndAlso Not Char.IsLetter(DirectCast(sender, TextBox).Text.Last())) Then
            e.Handled = True
            MessageBox.Show("A Dot before letters is not Allowed in this Field!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub phone_number_txt_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles phone_number_txt.KeyPress

        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> "+"c AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
            MessageBox.Show("This field allows only Numbers and '+'!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub
End Class