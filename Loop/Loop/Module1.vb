Module Module1
    Sub Main()
        Dim continueProgram As Boolean = True
        Dim i As String
        Dim num As Integer
        Console.WriteLine("=============================================================")
        Console.WriteLine("======Software to show Multiplication Table and Factorial====")
        Console.WriteLine("")

        While continueProgram

            Console.WriteLine("Select an option:")
            Console.WriteLine("1. Multiplication Table")
            Console.WriteLine("2. Factorial")
            Console.WriteLine("0. Exit Program")
            Dim optionSelected As String = Console.ReadKey(True).KeyChar.ToString()
            Console.WriteLine("________________________________________________________________________________")

            Select Case optionSelected
                Case "1"
                    Console.WriteLine("Enter a digit for Multiplication Table:")

                    If Integer.TryParse(Console.ReadLine(), num) Then
                        MultiplicationTable(num)
                    Else
                        Console.WriteLine("Invalid input. Press R to restart.")
                    End If

                Case "2"
                    Console.WriteLine("Enter a digit to calculate its factorial:")

                    If Integer.TryParse(Console.ReadLine(), num) Then
                        Dim result As Integer = Factorial(num)
                        Console.WriteLine("RESULT OF FACTORIAL = " + result.ToString())
                        Console.WriteLine(num & " x " & i & " = " & result)
                    Else
                        Console.WriteLine("Error In Input: USE A DIGIT")
                    End If

                Case "0"
                    continueProgram = False

                Case Else
                    Console.WriteLine("Invalid option.")
            End Select

            If continueProgram Then
                Console.WriteLine("________________________________________________________________________________")
                Console.WriteLine("Press R to return to the main menu, or any other key to exit.")
                Dim choice As ConsoleKeyInfo = Console.ReadKey(True)
                If choice.Key <> ConsoleKey.R Then
                    continueProgram = False
                End If
            End If
        End While

        Console.WriteLine("Exiting the program...")
    End Sub

    Sub MultiplicationTable(ByVal num As Integer)
        Console.WriteLine("Multiplication Table for " & num)
        Console.WriteLine("-------------------------------")

        For i As Integer = 1 To 12

            Dim result As Integer = num * i
            Console.WriteLine(num & " x " & i & " = " & result)
        Next

        Console.WriteLine("Press any key to exit...")
        Console.ReadKey()
    End Sub

    Function Factorial(ByVal num As Integer) As Integer
        Dim result As Integer = Not 0

        For i As Integer = 2 To num
            result *= i
            Console.WriteLine(num & " x " & i & " = " & result)
        Next
        Return result
    End Function
End Module
