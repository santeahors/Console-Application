Module Module1

    Sub Main()
        Console.WriteLine("               A SIMPLE CALCULATOR SOFTWARE     ")
        Console.WriteLine("==================================================")
        Console.WriteLine("")
        Dim first_no, second_no As Double
        Dim result As Double
        Dim op As Integer

        Console.WriteLine("press 1 for Addition")
        Console.WriteLine("press 2 for Difference")
        Console.WriteLine("press 3 for Product")
        Console.WriteLine("press 4 for Fraction")

        op = Console.ReadLine

        If op <> 1 AndAlso op <> 2 AndAlso op <> 3 AndAlso op <> 4 Then
            Console.WriteLine("invalid input")

        End If

        If op = (1) Then
            Console.WriteLine("Enter First Number")
            first_no = Console.ReadLine
            Console.WriteLine("Enter Second Number")
            second_no = Console.ReadLine
            result = first_no + second_no
            Console.WriteLine("result= " & result.ToString)

        ElseIf op = (2) Then
            Console.WriteLine("Enter First Number")
            first_no = Console.ReadLine
            Console.WriteLine("Enter Second Number")
            second_no = Console.ReadLine
            result = first_no - second_no
            Console.WriteLine("result= " & result.ToString)
        ElseIf op = (3) Then
            Console.WriteLine("Enter First Number")
            first_no = Console.ReadLine
            Console.WriteLine("Enter Second Number")
            second_no = Console.ReadLine
            result = first_no * second_no
            Console.WriteLine("result= " & result.ToString)

        ElseIf op = (4) Then
            Console.WriteLine(" Enter the Numerator")
            first_no = Console.ReadLine
            Console.WriteLine(" Enter the Denominator")
            second_no = Console.ReadLine
            If second_no > 1 Then
                Console.WriteLine("Invalid denominator")
                result = first_no / second_no
            End If
            Console.WriteLine("result= " & result.ToString)
           
            End If
            Console.ReadLine()
    End Sub

End Module
