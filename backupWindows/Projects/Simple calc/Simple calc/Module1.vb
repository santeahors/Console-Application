Imports System.Globalization
Module Module1
    Sub Main()
        Console.WriteLine("               A SIMPLE CALCULATOR SOFTWARE     ")
        Console.WriteLine("=====================================================================")
        Console.WriteLine("")
        Dim first_no, second_no As Double
        Dim result As Double
        Dim opn As String

        Console.WriteLine("press 1 for Addition")
        Console.WriteLine("press 2 for subtraction")
        Console.WriteLine("press 3 for Product")
        Console.WriteLine("press 4 for division")
        Console.WriteLine("__________________________________________________________")
        Console.WriteLine("")

        opn = Console.ReadLine()

        If opn <> "1" AndAlso opn <> "2" AndAlso opn <> "3" AndAlso opn <> "4" Then
            Console.WriteLine("Invalid input. ")
            Console.ReadLine()
            Return
        End If

        Console.WriteLine("ENTER FIRST NUMBER")
        first_no = Convert.ToDouble(Console.ReadLine())
        Console.WriteLine("--------------------------------------------")

        Console.WriteLine("ENTER SECOND NUMBER")
        second_no = Convert.ToDouble(Console.ReadLine())
        Console.WriteLine("--------------------------------------------")

        If (opn = "1") Then
            result = first_no + second_no
            Console.WriteLine("RESULT = " + result.ToString)

        ElseIf (opn = "2") Then
            result = first_no - second_no
            Console.WriteLine("RESULT = " + result.ToString)

        ElseIf (opn = "3") Then
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

