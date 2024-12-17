Module functions
    Function loandetails(ByVal input As Double, ByVal loanAmount As Double, ByVal LoanDuration As Double)
        Dim MonthlyInterest, MonthlyRepayment, RemainingBalance, PrincipalPortion, TotalInterest, TotalAmountPaid As Double
        Dim result As New List(Of String)

        RemainingBalance = loanAmount
        PrincipalPortion = loanAmount / LoanDuration

        For i As Integer = 1 To LoanDuration

            MonthlyInterest = (1.5 / 100) * RemainingBalance
            MonthlyRepayment = PrincipalPortion + MonthlyInterest
            RemainingBalance -= PrincipalPortion
            TotalInterest += MonthlyInterest
            TotalAmountPaid += MonthlyRepayment

            result.Add(i.ToString().PadRight(10) & PrincipalPortion.ToString("N2").PadRight(20) & MonthlyInterest.ToString("N2").PadRight(20) & Math.Max(RemainingBalance, 0).ToString("N2").PadRight(20) & MonthlyRepayment.ToString("N2"))

        Next

        Return Tuple.Create(TotalInterest, TotalAmountPaid, result.ToArray)
    End Function

End Module
