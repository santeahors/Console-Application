Imports System.Globalization

Module Module1

    Sub Main()
        Console.WriteLine("                THIS SOFTWARE TO CALCULATE STAFF SALARY")
        Console.WriteLine("=====================================================================")
        Console.WriteLine("")

        Dim salary As Decimal
        Dim tax, totalBalance As Decimal

        Console.WriteLine("ENTER SALARY AMOUNT")
        salary = Console.ReadLine()
        Console.WriteLine("")

        tax = (5 / 100) * salary
        totalBalance = salary - tax

        Console.WriteLine("TAX DEDUCTED @ 5% = " + "#" + tax.ToString("N2"))
        Console.WriteLine("TOTAL BALANCE = " + " #" + totalBalance.ToString("N2"))



        Console.ReadLine()

    End Sub

End Module
