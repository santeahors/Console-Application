Public Class Loan

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim loanAmount As Double
        Dim LoanDuration As Integer

        Do
            ' Validate loan amount
            If Not GetValidInput(LoanAmount_txt.Text, loanAmount) Then
                Exit Do
            End If

            ' Validate loan duration
            If Not GetValidInput(LoanDuration_txt.Text, LoanDuration, True) Then
                Exit Do
            End If

            ' Calculation variables
            Dim MonthlyInterest, MonthlyRepayment, RemainingBalance, PrincipalPortion, TotalInterest, TotalAmountPaid As Double
            TotalInterest = 0
            TotalAmountPaid = 0

            RemainingBalance = loanAmount
            PrincipalPortion = loanAmount / LoanDuration

            ' Define column widths
            Const MonthWidth As Integer = 5
            Const PrincipalWidth As Integer = 12
            Const InterestWidth As Integer = 20
            Const RemBalanceWidth As Integer = 20
            Const RepaymentWidth As Integer = 20

            ' Setting up the header with formatted padding
            Payments_txt.Text = String.Format("{0,-" & MonthWidth & "}{1,-" & PrincipalWidth & "}{2,-" & InterestWidth & "}{3,-" & RemBalanceWidth & "}{4,-" & RepaymentWidth & "}", "MONTH", "Principal", "Interest", "Remaining Balance", "Repayment")
            Payments_txt.AppendText(Environment.NewLine & New String("-"c, MonthWidth + PrincipalWidth + InterestWidth + RemBalanceWidth + RepaymentWidth) & Environment.NewLine)

            For i As Integer = 1 To LoanDuration
                MonthlyInterest = (1.5 / 100) * RemainingBalance
                MonthlyRepayment = PrincipalPortion + MonthlyInterest
                RemainingBalance -= PrincipalPortion
                TotalInterest += MonthlyInterest
                TotalAmountPaid += MonthlyRepayment

                ' Formatting each row with proper alignment
                Payments_txt.AppendText(String.Format("{0,-" & MonthWidth & "}{1,-" & PrincipalWidth & ":N2}{2,-" & InterestWidth & ":N2}{3,-" & RemBalanceWidth & ":N2}{4,-" & RepaymentWidth & ":N2}", i, PrincipalPortion, MonthlyInterest, Math.Max(RemainingBalance, 0), MonthlyRepayment) & Environment.NewLine)
            Next

            TotalAmount_txt.Text = TotalAmountPaid.ToString("N2")
            TotalAmount_txt.Visible = True


        Loop While False
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        LoanDuration_txt.Text = ""
        LoanAmount_txt.Text = ""
        TotalAmount_txt.Text = ""
        Payments_txt.Text = ""
        TotalAmount_txt.Visible = False
    End Sub

    Private Function GetValidInput(ByVal input As String, ByRef value As Double, Optional ByVal isInteger As Boolean = False) As Boolean
        If isInteger Then
            If Not Integer.TryParse(input, value) OrElse value <= 0 Then
                ShowError("Please enter a valid positive integer for loan duration.")
                Return False
            End If
        Else
            If Not Double.TryParse(input, value) OrElse value <= 0 Then
                ShowError("Please enter a valid positive number for loan amount.")
                Return False
            End If
        End If
        Return True
    End Function

    Private Sub ShowError(ByVal message As String)
        TotalAmount_txt.Text = message
        TotalAmount_txt.Visible = True
    End Sub

    Private Sub Input_txt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles LoanAmount_txt.KeyPress, LoanDuration_txt.KeyPress
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
End Class
