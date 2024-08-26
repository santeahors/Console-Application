Module Module1

    Sub Main()
        Dim restart As String
       
        Do
            Dim inputNumber As Integer
            Dim total As Integer = 0
            Dim loopCount As Integer = 0
            Dim success As Boolean = False
            Dim isValidInput As Boolean = False

            Do
                Console.Clear()

                Console.WriteLine(" Loop of Numbers with Condition")
                Console.WriteLine("")
                Console.WriteLine("Enter a number:")
                Dim userInput As String = Console.ReadLine()

                If Integer.TryParse(userInput, inputNumber) Then
                    isValidInput = True
                Else
                    Console.WriteLine("Invalid input. Please enter a valid number.")
                End If
            Loop While Not isValidInput

            For i As Integer = 1 To 12
                total += inputNumber
                loopCount += 1

                If total >= 100 Then
                    Console.WriteLine("The loop was executed " & loopCount & " times.")
                    success = True
                    Exit For
                End If
            Next
            If success Then
                Console.WriteLine("The total reached/exceeded 100: " & total)
                Console.WriteLine("Result: False")
            ElseIf total <= 100 Then
                Console.WriteLine("The total is " & total & " after 12 loops.")
                Console.WriteLine("Result: True")
            End If


            Console.WriteLine("To restart Press Y and to End program use any other key")
            restart = Console.ReadLine().Trim().ToUpper()

        Loop While restart = "Y"

        Console.WriteLine("Thank you for using the program. Press any key to exit...")
        Console.ReadKey()
    End Sub

End Module