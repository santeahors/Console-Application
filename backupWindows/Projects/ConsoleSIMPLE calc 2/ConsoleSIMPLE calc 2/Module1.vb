
Imports System.Globalization
Module Module1
    Sub Main()
        Console.WriteLine("               A SIMPLE CALCULATOR SOFTWARE     ")
        Console.WriteLine("=====================================================================")
        Console.WriteLine("")
        Dim first_no, second_no As Double
        Dim result As Double
        Dim opn As String

        Console.WriteLine("ENTER FIRST NUMBER")
        first_no = Convert.ToDouble(Console.ReadLine())
        Console.WriteLine("--------------------------------------------")

        Console.WriteLine("press + for Addition")
        Console.WriteLine("press - for subtraction")
        Console.WriteLine("press * for Product")
        Console.WriteLine("press / for division")
        Console.WriteLine("__________________________________________________________")
        Console.WriteLine("")

        opn = Console.ReadLine()

        If opn <> "+" AndAlso opn <> "-" AndAlso opn <> "*" AndAlso opn <> "/" Then
            Console.WriteLine("Invalid input. ")
            Console.ReadLine()
            Return
        End If
        Console.WriteLine("ENTER SECOND NUMBER")
        second_no = Convert.ToDouble(Console.ReadLine())
        Console.WriteLine("--------------------------------------------")

        If (opn = "+") Then
            result = first_no + second_no
            Console.WriteLine("RESULT = " + result.ToString)

        ElseIf (opn = "-") Then
            result = first_no - second_no
            Console.WriteLine("RESULT = " + result.ToString)

        ElseIf (opn = "*") Then
            result = first_no * second_no
            Console.WriteLine("RESULT = " + result.ToString)

        ElseIf second_no <> 0 Then
            result = first_no / second_no
            Console.WriteLine("RESULT = " + result.ToString("N"))
        Else
            Console.WriteLine("Error: Division by zero is not allowed.")


        End If

        Console.ReadLine()
    End Sub

    Private Function NoNullAllowedException() As String
        Throw New NotImplementedException
    End Function

End Module

