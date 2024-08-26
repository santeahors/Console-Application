Module Module1

    Sub Main()
        Dim input As String
        Dim restart As String

        Do
            Console.Clear()

            Dim loanAmount, LoanDuration, MonthlyInterest, MonthlyRepayment, RemainingBalance, PrincipalPortion, TotalInterest, TotalAmountPaid As Double
            TotalInterest = 0
            TotalAmountPaid = 0

            Console.WriteLine("====== Loan Application ========")
            Console.WriteLine()


            Do
                Console.WriteLine("Enter the loan amount:")
                input = Console.ReadLine()

                If Double.TryParse(input, loanAmount) AndAlso loanAmount > 0 Then
                    Exit Do
                Else
                    Console.WriteLine("Invalid input. Please enter a positive numeric value.")
                End If
            Loop While True

            Console.WriteLine()


            Do
                Console.WriteLine("Enter Loan Duration (in months):")
                input = Console.ReadLine()

                If Double.TryParse(input, LoanDuration) AndAlso LoanDuration > 0 Then
                    Exit Do
                Else
                    Console.WriteLine("Invalid input. Please enter a positive numeric value.")
                End If
            Loop While True

            Console.WriteLine()

            RemainingBalance = loanAmount
            PrincipalPortion = loanAmount / LoanDuration

            Console.WriteLine("MONTH".PadRight(10) & "PrincipalPortion".PadRight(20) & "Interest Paid".PadRight(20) & "Remaining Balance".PadRight(20) & "Repayment".PadLeft(8))
            Console.WriteLine(New String("-"c, 90))

            For i As Integer = 1 To LoanDuration

                MonthlyInterest = (1.5 / 100) * RemainingBalance
                MonthlyRepayment = PrincipalPortion + MonthlyInterest
                RemainingBalance -= PrincipalPortion
                TotalInterest += MonthlyInterest
                TotalAmountPaid += MonthlyRepayment

                Console.WriteLine(i.ToString().PadRight(10) & PrincipalPortion.ToString("N2").PadRight(20) & MonthlyInterest.ToString("N2").PadRight(20) & Math.Max(RemainingBalance, 0).ToString("N2").PadRight(20) & MonthlyRepayment.ToString("N2"))
            Next

            Console.WriteLine()
            Console.WriteLine("Total Interest Paid: " & TotalInterest.ToString("N2"))
            Console.WriteLine("Total Amount Repaid: " & TotalAmountPaid.ToString("N2"))

            Console.WriteLine()
            Console.WriteLine("Would you like to restart the application? Press (Y) to restart, or any other key to quit.")

            restart = Console.ReadLine().Trim().ToUpper()

        Loop While restart = "Y"

        Console.Clear()
        Console.WriteLine("Thank you for using the loan application. Press any key to exit...")
        Console.ReadKey()

    End Sub

End Module
