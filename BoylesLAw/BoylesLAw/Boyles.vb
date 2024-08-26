Module Boyles
    Sub Main()

        Dim P1 As Double
        Dim V1 As Double
        Dim P2 As Double
        Dim V2 As Double
        Dim choice As String

        Console.WriteLine("----------------SOFTWARE TO CALCULATE BOYLES LAW---------------")
        Console.WriteLine("")
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

                Console.Write("Enter the final pressure (P2): ")
                If Not Double.TryParse(Console.ReadLine, P2) Then

                    Console.WriteLine("Invalid input. Please enter a numeric value.")
                    Exit Sub
                End If

                Console.Write("Enter the final volume (V2): ")
                If Not Double.TryParse(Console.ReadLine, V2) Then
                    Console.WriteLine("Invalid input. Please enter a numeric value.")
                    Exit Sub
                End If

                Console.Write("Enter the initial volume (V1): ")
                If Not Double.TryParse(Console.ReadLine, V1) Then
                    Console.WriteLine("Invalid input. Please enter a numeric value.")
                    Exit Sub
                End If
                Console.WriteLine("")
                P1 = (P2 * V2) / V1
                Console.WriteLine("The initial pressure (P1) is: " & P1 & " atm")

            Case "2"

                Console.Write("Enter the final pressure (P2): ")
                If Not Double.TryParse(Console.ReadLine, P2) Then
                    Console.WriteLine("Invalid input. Please enter a numeric value.")
                    Exit Sub
                End If

                Console.Write("Enter the final volume (V2): ")
                If Not Double.TryParse(Console.ReadLine, V2) Then
                    Console.WriteLine("Invalid input. Please enter a numeric value.")
                    Exit Sub
                End If

                Console.Write("Enter the initial pressure (P1): ")
                If Not Double.TryParse(Console.ReadLine, P1) Then
                    Console.WriteLine("Invalid input. Please enter a numeric value.")
                    Exit Sub
                End If
                Console.WriteLine("")
                V1 = (P2 * V2) / P1
                Console.WriteLine("The initial volume (V1) is: " & V1 & " L")

            Case "3"

                Console.Write("Enter the initial pressure (P1): ")
                If Not Double.TryParse(Console.ReadLine(), P1) Then
                    Console.WriteLine("Invalid input. Please enter a numeric value.")
                    Exit Sub
                End If

                Console.Write("Enter the initial volume (V1): ")
                If Not Double.TryParse(Console.ReadLine, V1) Then
                    Console.WriteLine("Invalid input. Please enter a numeric value.")
                    Exit Sub
                End If

                Console.Write("Enter the final volume (V2): ")
                If Not Double.TryParse(Console.ReadLine(), V2) Then
                    Console.WriteLine("Invalid input. Please enter a numeric value.")
                    Exit Sub
                End If
                Console.WriteLine("")
                P2 = (P1 * V1) / V2
                Console.WriteLine("The final pressure (P2) is: " & P2 & " atm")

            Case "4"

                Console.Write("Enter the initial pressure (P1): ")
                If Not Double.TryParse(Console.ReadLine, P1) Then
                    Console.WriteLine("Invalid input. Please enter a numeric value.")
                    Exit Sub
                End If

                Console.Write("Enter the initial volume (V1): ")
                If Not Double.TryParse(Console.ReadLine(), V1) Then
                    Console.WriteLine("Invalid input. Please enter a numeric value.")
                    Exit Sub
                End If

                Console.Write("Enter the final pressure (P2): ")
                If Not Double.TryParse(Console.ReadLine, P2) Then
                    Console.WriteLine("Invalid input. Please enter a numeric value.")
                    Exit Sub
                End If
                Console.WriteLine("")
                V2 = (P1 * V1) / P2
                Console.WriteLine("The final volume (V2) is: " & V2 & " L")

            Case Else
                Console.WriteLine("Invalid choice.")
                Console.WriteLine("")
        End Select

            Console.ReadLine()
    End Sub

End Module
