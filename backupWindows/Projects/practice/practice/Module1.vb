Module Module1

    Sub Main()
        Dim a, b, c, d, x As Integer
        Console.WriteLine("INPUT VALUE FOR A")
        a = Console.ReadLine
        Console.WriteLine("INPUT VALUE FOR B")
        b = Console.ReadLine
      
        x = (a * a * a) + (b * b) - (a * a) + (b - a)
        Console.WriteLine(x.ToString)
        Console.ReadLine()
    End Sub
End Module
