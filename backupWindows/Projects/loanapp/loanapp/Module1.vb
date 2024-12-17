Module Module1

    Sub Main()
        Dim input As String
        Dim restart As String

        Do
            Console.Clear()

            Dim loanAmount, LoanDuration, TotalInterest, TotalAmountPaid As Double
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

            Console.WriteLine("MONTH".PadRight(10) & "PrincipalPortion".PadRight(20) & "Interest Paid".PadRight(20) & "Remaining Balance".PadRight(20) & "Repayment".PadLeft(8))
            Console.WriteLine(New String("-"c, 90))

          

            Console.WriteLine()
            Dim result = functions.loandetails(input, loanAmount, LoanDuration)

            For Each item In result.item3
                Console.WriteLine(item)
            Next
            Console.WriteLine()
            Console.WriteLine("Total Interest Paid: " & Convert.ToDouble(result.item1).ToString("N2"))
            Console.WriteLine("Total Amount Repaid: " & Convert.ToDouble(result.item2).ToString("N2"))

            Console.WriteLine()
            Console.WriteLine("Would you like to restart the application? Press (Y) to restart, or any other key to quit.")

            restart = Console.ReadLine().Trim().ToUpper()

        Loop While restart = "Y"

        Console.Clear()
        Console.WriteLine("Thank you for using the loan application. Press any key to exit...")
        Console.ReadKey()

    End Sub

End Module
