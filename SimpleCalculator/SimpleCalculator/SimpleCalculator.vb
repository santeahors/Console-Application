Public Class SimpleCalculator
  

    Dim firstNumber, secondNumber, result As Double
    Dim operators As String

    Private Sub Calculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Calculate.Click
        errorLabel.Visible = False
        Showoperator_txt.Visible = True

        If Not Double.TryParse(First_no_txt.Text, firstNumber) Then
            ShowError("Please enter a valid number for the first number.")
            Exit Sub
        End If

        If Not Double.TryParse(Second_no_txt.Text, secondNumber) Then
            ShowError("Please enter a valid number for the second number.")
            Exit Sub
        End If
        Select Case operators
            Case "+"
                result = firstNumber + secondNumber

            Case "-"
                result = firstNumber - secondNumber
            Case "*"
                result = firstNumber * secondNumber

            Case "/"
                If secondNumber <> 0 Then
                    result = firstNumber / secondNumber

                Else
                    ShowError("Division by zero is not allowed.")
                    Exit Sub
                End If
            Case Else
                ShowError("Invalid operator.")
                Exit Sub
        End Select

        result_txt.Text = result.ToString("N2")
    End Sub

    Private Sub Sum_btn_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Sum_btn.Click
        operators = "+"
        Sum_btn.Text = "+"
        ShowOperator("+")
        Sum_btn.Visible = True
    End Sub

    Private Sub Minus_btn_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Minus_btn.Click
        operators = "-"
        Minus_btn.Text = "-"
        ShowOperator("-")
        Minus_btn.Visible = True
    End Sub

    Private Sub Multiply_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Multiply_btn.Click
        operators = "*"
        Multiply_btn.Text = "*"
        ShowOperator("*")
        Multiply_btn.Visible = True
    End Sub

    Private Sub Division_btn_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Division_btn.Click
        operators = "/"
        Division_btn.Text = "/"
        ShowOperator("/")
        Division_btn.Visible = True
    End Sub

    Private Sub Clear_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Clear_btn.Click
        First_no_txt.Text = ""
        Second_no_txt.Text = ""
        result_txt.Text = ""
        operators = ""
        ShowOperator("")
        errorLabel.Visible = False
    End Sub

    Private Sub first_no_txt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles First_no_txt.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) AndAlso (e.KeyChar <> "."c) Then
            e.Handled = True
            ShowError("Invalid input. Please enter a valid number.")
        End If

        If (e.KeyChar = "."c) AndAlso (DirectCast(sender, TextBox).Text.Length = 0) Then
            e.Handled = True
            ShowError("Input cannot start with a decimal point.")
        End If

        If (e.KeyChar = "."c) AndAlso (DirectCast(sender, TextBox).Text.IndexOf("."c) > -1) Then
            e.Handled = True
            ShowError("Only one decimal point is allowed.")
        End If
    End Sub

    Private Sub second_no_txt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Second_no_txt.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) AndAlso (e.KeyChar <> "."c) Then
            e.Handled = True
            ShowError("Invalid input. Please enter a valid number.")
        End If

        If (e.KeyChar = "."c) AndAlso (DirectCast(sender, TextBox).Text.Length = 0) Then
            e.Handled = True
            ShowError("Input cannot start with a decimal point.")
        End If

        If (e.KeyChar = "."c) AndAlso (DirectCast(sender, TextBox).Text.IndexOf("."c) > -1) Then
            e.Handled = True
            ShowError("Only one decimal point is allowed.")
        End If
    End Sub
    Private Sub ShowError(ByVal message As String)
        errorLabel.Text = message
        errorLabel.Visible = True
    End Sub
    Private Sub ShowOperator(ByRef message As String)
        Showoperator_txt.Text = message
        Showoperator_txt.Visible = True
    End Sub
End Class