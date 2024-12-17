Public Class Division

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim first_no, second_no As Double
        Dim result As Double

        If Double.TryParse(first_no_txt.Text, first_no) AndAlso Double.TryParse(second_n_txt.Text, second_no) Then
            If second_no <> 0 Then
                result = first_no / second_no
                result_txt.Text = "  " & result.ToString("N2")
                lblError.Text = ""
            Else
                lblError.Text = "Division by zero is not allowed."
                result_txt.Text = ""
            End If
        Else
            lblError.Text = "Please enter valid numbers."
            result_txt.Text = ""
        End If
    End Sub

    Private Sub first_no_txt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles first_no_txt.KeyPress
        Dim errorMsg As String = ""

        Select Case True
            Case Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) AndAlso (e.KeyChar <> "."c)
                e.Handled = True
                errorMsg = "Invalid input. Please enter a valid number."

            Case (e.KeyChar = "."c) AndAlso (DirectCast(sender, TextBox).Text.Length = 0)
                e.Handled = True
                errorMsg = "Input cannot start with a decimal point."

            Case (e.KeyChar = "."c) AndAlso (DirectCast(sender, TextBox).Text.IndexOf("."c) > -1)
                e.Handled = True
                errorMsg = "Only one decimal point is allowed."
        End Select

        If errorMsg <> "" Then
            lblError.Text = errorMsg
        Else
            lblError.Text = ""
        End If
    End Sub

    Private Sub second_no_txt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles second_n_txt.KeyPress
        Dim errorMsg As String = ""

        Select Case True
            Case Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) AndAlso (e.KeyChar <> "."c)
                e.Handled = True
                errorMsg = "Invalid input. Please enter a valid number."

            Case (e.KeyChar = "."c) AndAlso (DirectCast(sender, TextBox).Text.Length = 0)
                e.Handled = True
                errorMsg = "Input cannot start with a decimal point."

            Case (e.KeyChar = "."c) AndAlso (DirectCast(sender, TextBox).Text.IndexOf("."c) > -1)
                e.Handled = True
                errorMsg = "Only one decimal point is allowed."
        End Select

        If errorMsg <> "" Then
            lblError.Text = errorMsg
        Else
            lblError.Text = ""
        End If
    End Sub

    Private Sub lblError_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblError.Click

        InitializeComponent()
        lblError = New Label()
        lblError.Name = "lblError"
        lblError.Text = ""
        lblError.ForeColor = Color.Red
        lblError.AutoSize = True
        Me.Controls.Add(lblError)
    End Sub
End Class
