Module Module1

    Sub Main()
        Console.WriteLine("                THIS SOFTWARE CALCULATE SUBTRACTION OF TWO NUMBERS")
        Console.WriteLine("=====================================================================")
        Console.WriteLine("")

        Dim first_no, second_no, result As Integer

        Console.WriteLine("ENTER FIRST NUMBER")
        first_no = Console.ReadLine()
        Console.WriteLine("")

        Console.WriteLine("ENTER SECOND NUMBER")
        second_no = Console.ReadLine()
        Console.WriteLine("")

        result = first_no - second_no

        Console.WriteLine("YOUR RESULT = " + result.ToString)


        Console.ReadLine()

    End Sub

End Module
