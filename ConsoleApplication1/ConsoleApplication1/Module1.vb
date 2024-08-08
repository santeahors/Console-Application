

Module Module1

    Sub Main()
        Console.WriteLine("                THIS SOFTWARE TO COMPARE TWO NUMBERS       ")
        Console.WriteLine("=====================================================================")
        Console.WriteLine("")

        Dim first_no, second_no, third_no As Double
        Console.WriteLine("Enter the first number")
        If Integer.TryParse(Console.ReadLine(), first_no) Then
            Console.WriteLine("THE NUMBER YOU INPUTED IS " & first_no)
        Else
            Console.WriteLine()
        End If

        Console.WriteLine("Enter the second number")
        second_no = Console.ReadLine()
        Console.WriteLine()

        Console.WriteLine("Enter the third number")
        third_no = Console.ReadLine()
        Console.WriteLine()

        If (first_no > second_no) And (first_no > third_no) Then
            Console.WriteLine("THE GREATER NUMBER IS = " + first_no.ToString)

        ElseIf (first_no = second_no) And (first_no <> third_no) Then
            Console.WriteLine("FIRST NUMBER AND SECOND NUMBER ARE EQUAL")
        ElseIf (first_no <> second_no) And (first_no = third_no) Then
            Console.WriteLine("FIRST NUMBER AND THIRD NUMBER ARE EQUAL")

        ElseIf (second_no > first_no) And (second_no > third_no) Then
            Console.WriteLine("THE GREATER NUMBER IS = " + second_no.ToString)
        ElseIf (second_no = first_no) And (second_no <> third_no) Then
            Console.WriteLine("SECOND NUMBER AND FIRST NUMBER ARE EQUAL")
        ElseIf (second_no <> first_no) And (second_no = third_no) Then
            Console.WriteLine("SECOND NUMBER AND THIRD NUMBER ARE EQUAL")

        ElseIf (third_no > first_no) And (third_no > second_no) Then
            Console.WriteLine("THE GREATER NUMBER IS = " + third_no.ToString)

        ElseIf (third_no = first_no) And (third_no <> second_no) Then
            Console.WriteLine("THIRD NUMBER AND FIRST NUMBER ARE EQUAL")
        ElseIf (third_no <> first_no) And (third_no = second_no) Then
            Console.WriteLine("THIRD NUMBER AND SECOND NUMBER ARE EQUAL")
        Else
            Console.WriteLine("THE NUMBERS ARE EQUAL")
        End If




        Console.ReadLine()

    End Sub

End Module
