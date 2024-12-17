
Imports System.IO
Imports System.Text.RegularExpressions
Public Class Auto_System

    '------------------------------------------------------ON LOAD -------------------------------------------------------------------------------
    Private Sub Auto_System_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        registration_panel.Show()
        success_reg_panel.Hide()
        profile_del_panel.Hide()
        record_panel.Hide()


    End Sub
    '-------------------------  FUNCTION FOR THE MASTER COUNT ---------------------------------------------------------

    '------------------------------------------FUNCTION FOR COUNTER USER -------------------------------------


    '----------------------------------------FUNCTION FOR REGISTRATION/INSERTION -------------------------------------


    '----------------------------------FUNCTION TO PERFOM SAVE AND UPDATE OPERATIONS -------------------------------------
    Private Sub Submit()

        If fullname_txt.Text = "Enter your full name..." Or email_txt.Text = "Enter your email..." Or phone_no_txt.Text = "Enter your phone..." Then
            MessageBox.Show("This field cannot be empty, Kindly fill the space", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        ElseIf (Profile_pic.Image Is Nothing) Then
            MessageBox.Show("This field cannot be empty, Kindly insert your picture", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        ElseIf Not IsValidEmail(email_txt.Text.Trim()) Then
            MessageBox.Show("Please enter a valid email address.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        Else
            If profile_details_box.SelectedValue = "" Then
                Dim answer As Integer
                answer = MessageBox.Show("Are you sure you want to save", "submited", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If answer = vbYes Then
                    registration_panel.Hide()
                    success_reg_panel.Show()
                    profile_del_panel.Hide()
                    record_panel.Hide()


                End If
            Else
                Dim answer As Integer
                answer = MessageBox.Show("Are you sure you want to Update", "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If answer = vbYes Then

                    registration_panel.Hide()
                    success_reg_panel.Show()
                    profile_del_panel.Hide()
                    record_panel.Hide()

                End If
            End If
        End If
    End Sub

    '-------------------------------- FUNCTION FOR CLEAR -----------------------------------------------

    '--------------------------------------------FUNCTION FOR SETUP DATA GRID VIEW ----------------------------------------
    Private Sub SetupDataGridView()
        record_dataGridView.Columns.Clear()
        record_dataGridView.Rows.Clear()
        record_dataGridView.Columns.Add("sn", "S/N")
        record_dataGridView.Columns.Add("user_id", "USER_ID")
        record_dataGridView.Columns.Add("fullname", "FULL NAME")
        record_dataGridView.Columns.Add("email", "EMAIL")
        record_dataGridView.Columns.Add("phone_no", "PHONE NUMBER")
        Dim imgColumn As New DataGridViewImageColumn()
        imgColumn.Name = "profile_image"
        imgColumn.HeaderText = "PASSPORT"
        imgColumn.ImageLayout = DataGridViewImageCellLayout.Zoom
        record_dataGridView.Columns.Add(imgColumn)
    End Sub
    '--------------------------------------------FUNCTION FOR FETCHING USER DATA ----------------------------------------

    '------------------------------------------BUTTON TO PERFOM SUBMIT OPERATIONS -------------------------------------
    Private Sub submit_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Submit()
    End Sub
    '------------------------------------------BUTTON FOR OKAY OPERATIONS -------------------------------------
    Private Sub okay_reg_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        registration_panel.Show()
        success_reg_panel.Hide()
        profile_del_panel.Hide()
        record_panel.Hide()
    End Sub
    Private Sub okay_profile_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles okay_profile_btn.Click
        registration_panel.Show()
        success_reg_panel.Hide()
        profile_del_panel.Hide()
        record_panel.Hide()
    End Sub
    '------------------------------------------BUTTON TO PERFOM DELETE OPERATIONS -------------------------------------

    '------------------------------------------------- CLEAR BUTTON -----------------------------------------

    '--------------------------------------------- SAVE MENUSTRIP BUTTON -----------------------------------------
    Private Sub SAVEToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SAVEToolStripMenuItem.Click
        Submit()
    End Sub
    '---------------------------------------------- EXIT MENUSTRIP BUTTON -----------------------------------------
    Private Sub EXITToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EXITToolStripMenuItem.Click
        Dim answer As Integer
        answer = MessageBox.Show("Are you sure you want to Exit", "Exit Apllication", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If answer = vbYes Then
            Me.Close()
        End If
    End Sub
    '------------------------------------------------ LISTBOX_OKAY_BUTTON -----------------------------------------
    Private Sub listbox_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles listbox_btn.Click
        registration_panel.Show()
        success_reg_panel.Hide()
        profile_del_panel.Hide()
        record_panel.Hide()
    End Sub
    '------------------------------------------------- RECORD_PANEL_BUTTON -----------------------------------------
    Private Sub RECORDToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RECORDToolStripMenuItem.Click
        registration_panel.Hide()
        success_reg_panel.Hide()
        profile_del_panel.Hide()
        record_panel.Show()

    End Sub
    '---------------------------------------BUTTON FOR FETCHING PROFILE-------------------------------------------------------
    Private Sub profile_details_box_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles profile_details_box.Click

    End Sub
    '-------------------------  BUTTON FOR SELECTING PICTURE  ---------------------------------------------------------
    Private Sub select_pic_button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim fd As New OpenFileDialog
        fd.Filter = "image|*.jpeg;*.png;*.gif;*.jpg;*.gif;*.bmp;*.wmf;*"
        If fd.ShowDialog = DialogResult.OK Then
            Profile_pic.Image = Image.FromFile(fd.FileName)
        End If
        fd.Dispose()
    End Sub
    '------------------------------------------------------ FETCH BUTTON --------------------------------




    '---------------------------------------SECURITY FOR ALL THE INPUTS-------------------------------------------------------
    Public Function IsValidEmail(ByVal email As String) As Boolean
        ' Updated regex to prevent consecutive dots in the domain part and handle valid email formats
        Dim regex As New Regex("^[a-zA-Z0-9.!#$%&'*+/=?^_`{|}~-]+@[a-zA-Z0-9-]+\.[a-zA-Z]{2,}$")
        If String.IsNullOrEmpty(email) Then
            Return False
        End If
        Dim match As Match = regex.Match(email)
        Return match.Success
    End Function


    Private Sub Profile_pic_Click(sender As Object, e As EventArgs) Handles Profile_pic.Click

    End Sub

End Class

