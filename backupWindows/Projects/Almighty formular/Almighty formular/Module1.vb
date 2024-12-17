Module Module1

    Sub Main()
        Console.WriteLine("                THIS SOFTWARE CALCULATE QUADRATIC EQUATIONS")
        Console.WriteLine("=====================================================================")
        Console.WriteLine("")

        Dim a, b, c, d, e, f, g, h, x1, x2 As Double

        Console.WriteLine("THE VALUE OF A")
        a = Console.ReadLine()
        Console.WriteLine("")

        Console.WriteLine("THE VALUE OF B")
        b = Console.ReadLine()
        Console.WriteLine("")

        Console.WriteLine("THE VALUE OF C")
        c = Console.ReadLine()
        Console.WriteLine("")
        d = b * b
        e = 4 * a * c
        f = d - e
        g = Math.Sqrt(f)
        h = 2 * a
        x1 = (-b + g) / h
        x2 = (-b - g) / h


        Console.WriteLine("YOUR RESULT OF X1 = " + x1.ToString)

        Console.WriteLine("YOUR RESULT OF X2 = " + x2.ToString)


        Console.ReadLine()

    End Sub

End Module
