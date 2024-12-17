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

            Dim result = get_loop(inputNumber)

            Console.WriteLine("Total = " & result.Item1)
            Console.WriteLine("Loop count = " & result.Item3)
            Console.WriteLine("Success = " & result.Item2)
            Console.WriteLine("Loop Results: " & String.Join(", ", result.Item4))

            Console.WriteLine(" End program use any other key")
            restart = Console.ReadKey(True).KeyChar.ToString()

        Loop While restart = "Y"

        Console.WriteLine("Thank you for using the program. Press any key to exit...")
        Console.ReadKey()
    End Sub

End Module