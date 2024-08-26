Module Boyles

    Sub Main()
        Dim P1 As Double
        Dim V1 As Double
        Dim P2 As Double
        Dim V2 As Double
        Dim choice As String
        Dim continueProgram As String

        Do
            Console.WriteLine("----------------SOFTWARE TO CALCULATE BOYLE'S LAW---------------")
            Console.WriteLine()
            Console.WriteLine("Which variable would you like to calculate?")
            Console.WriteLine("1. Initial Pressure (P1)")
            Console.WriteLine("2. Initial Volume (V1)")
            Console.WriteLine("3. Final Pressure (P2)")
            Console.WriteLine("4. Final Volume (V2)")
            Console.Write("Enter the number corresponding to your choice (1-4): ")
            choice = Console.ReadKey(True).KeyChar.ToString()
            Console.WriteLine()

            Console.WriteLine("________________________________________________________________________________")

            Select Case choice
                Case "1"
                    P2 = GetDoubleInput("Enter the final pressure (P2): ")
                    V2 = GetDoubleInput("Enter the final volume (V2): ")
                    V1 = GetDoubleInput("Enter the initial volume (V1): ")

                    P1 = (P2 * V2) / V1
                    Console.WriteLine("The initial pressure (P1) is: " & P1 & " atm")

                Case "2"
                    P2 = GetDoubleInput("Enter the final pressure (P2): ")
                    V2 = GetDoubleInput("Enter the final volume (V2): ")
                    P1 = GetDoubleInput("Enter the initial pressure (P1): ")

                    V1 = (P2 * V2) / P1
                    Console.WriteLine("The initial volume (V1) is: " & V1 & " L")

                Case "3"
                    P1 = GetDoubleInput("Enter the initial pressure (P1): ")
                    V1 = GetDoubleInput("Enter the initial volume (V1): ")
                    V2 = GetDoubleInput("Enter the final volume (V2): ")

                    P2 = (P1 * V1) / V2
                    Console.WriteLine("The final pressure (P2) is: " & P2 & " atm")

                Case "4"
                    P1 = GetDoubleInput("Enter the initial pressure (P1): ")
                    V1 = GetDoubleInput("Enter the initial volume (V1): ")
                    P2 = GetDoubleInput("Enter the final pressure (P2): ")

                    V2 = (P1 * V1) / P2
                    Console.WriteLine("The final volume (V2) is: " & V2 & " L")

                Case Else
                    Console.WriteLine("Invalid choice.")
            End Select

            Console.WriteLine("Do you want to calculate again? (y/n)")
            continueProgram = Console.ReadLine().ToLower()
        Loop While continueProgram = "y"

    End Sub

    Function GetDoubleInput(ByVal prompt As String) As Double
        Dim result As Double
        Console.Write(prompt)
        While Not Double.TryParse(Console.ReadLine(), result)
            Console.WriteLine("Invalid input. Please enter a numeric value.")
            Console.Write(prompt)
        End While
        Return result
    End Function

End Module
