Imports System.Globalization

Module Module1

    Sub Main()
        Console.WriteLine("                THIS SOFTWARE TO CALCULATE STAFF SALARY")
        Console.WriteLine("=====================================================================")
        Console.WriteLine("")

        Dim salary, tax_rate As Decimal
        Dim tax, totalBalance As Decimal



        Console.WriteLine("ENTER SALARY AMOUNT")
        salary = Console.ReadLine()
        Console.WriteLine("")

        Console.WriteLine("ENTER TAX RATE")
        tax_rate = Console.ReadLine()
        Console.WriteLine("")
        tax = (tax_rate / 100) * salary
        totalBalance = salary - tax

        Console.WriteLine("TAX DEDUCTED @" + " " + tax_rate.ToString + "%" + "=" + " " + "#" + tax.ToString("N"))
        Console.WriteLine("SALARY BALANCE = " + " #" + totalBalance.ToString("N"))


        Console.ReadLine()

    End Sub

End Module
