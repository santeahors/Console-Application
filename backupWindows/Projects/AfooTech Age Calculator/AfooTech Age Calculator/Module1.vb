Module Module1

    Sub Main()
        Dim Tomonth, Today, Toyear As Integer
        Dim BirthDay, BirthYear, BirthMonth As Integer
        Dim DaysInMonth As Integer
        Dim resultday, resultmonth, resultyear As Integer

        Console.WriteLine("AGE CALCULATOR")
        Console.WriteLine("-------------------------------")

        Today = Date.Now.Day
        Tomonth = Date.Now.Month
        Toyear = Date.Now.Year

        Console.WriteLine("TODAY'S DATE IS " + Today.ToString + "/" + Tomonth.ToString + "/" + Toyear.ToString)
        Console.WriteLine("________________________________")
        Console.WriteLine()

        Do
            Console.WriteLine("ENTER BIRTH DAY")
            If Not Integer.TryParse(Console.ReadLine(), BirthDay) OrElse BirthDay < 1 OrElse BirthDay > 31 Then
                Console.WriteLine("Error In Input: Invalid Day")
            Else
                Exit Do
            End If
        Loop

        Console.WriteLine("")

        Do
            Console.WriteLine("ENTER BIRTH MONTH")
            If Not Integer.TryParse(Console.ReadLine(), BirthMonth) OrElse BirthMonth < 1 OrElse BirthMonth > 12 Then
                Console.WriteLine("Error In Input: Invalid Month")
            Else
                Exit Do
            End If
        Loop

        Console.WriteLine("")

        Do
            Console.WriteLine("ENTER BIRTH YEAR")
            If Not Integer.TryParse(Console.ReadLine(), BirthYear) OrElse BirthYear < 1 OrElse (BirthMonth > Tomonth AndAlso BirthYear = Toyear) Then
                Console.WriteLine("Error In Input: Invalid Year or Month")
            Else
                Exit Do
            End If
        Loop

        DaysInMonth = System.DateTime.DaysInMonth(BirthYear, BirthMonth)

        Select Case True
            Case BirthMonth = 2 And BirthDay > DaysInMonth
                Console.WriteLine("INVALID INPUT! ENTER A VALID BIRTH MONTH")
            Case BirthMonth > 12 Or BirthYear > Toyear Or BirthDay > 31 Or BirthDay < 1 Or BirthMonth < 1 Or BirthYear < 1
                Console.WriteLine("INVALID INPUT! ENTER A VALID BIRTH DATE")
            Case BirthDay > Today And BirthMonth >= Tomonth And BirthYear >= Toyear
                Console.WriteLine("Error In Input")
            Case (BirthMonth = 4 Or BirthMonth = 9 Or BirthMonth = 11 Or BirthMonth = 6) And BirthDay > DaysInMonth
                Console.WriteLine("Days Not up to that")
            Case Else
                Select Case True
                    Case Tomonth = BirthMonth And BirthDay > Today
                        resultyear = Toyear - BirthYear - 1
                    Case BirthMonth > Tomonth And Today > BirthDay
                        resultyear = Toyear - BirthYear - 1
                    Case BirthMonth > Tomonth And Today = BirthDay
                        resultyear = Toyear - BirthYear - 1
                    Case BirthMonth > Tomonth And BirthDay > Today
                        resultyear = Toyear - BirthYear - 1
                    Case Else
                        resultyear = Toyear - BirthYear
                End Select

                Select Case True
                    Case Tomonth > BirthMonth And BirthDay > Today
                        resultmonth = Tomonth - BirthMonth - 1
                    Case Tomonth = BirthMonth And BirthDay > Today
                        resultmonth = Tomonth - BirthMonth + 12 - 1
                    Case BirthMonth > Tomonth And Today > BirthDay
                        resultmonth = Tomonth - BirthMonth + 12
                    Case BirthMonth > Tomonth And Today = BirthDay
                        resultmonth = Tomonth - BirthMonth + 12
                    Case BirthMonth > Tomonth And BirthDay > Today
                        resultmonth = Tomonth - BirthMonth + 12 - 1
                    Case Else
                        resultmonth = Tomonth - BirthMonth
                End Select

                Select Case True
                    Case Today > BirthDay
                        resultday = Today - BirthDay
                    Case BirthDay > Today
                        resultday = Today + DaysInMonth - BirthDay
                    Case BirthDay = Today
                        resultday = Today - BirthDay
                End Select

                Console.WriteLine("YOUR AGE IS = " + resultyear.ToString + " YEAR(S), " + resultmonth.ToString + " MONTH(S), " + resultday.ToString + " DAY(S)")
        End Select

        Console.ReadLine()
    End Sub

End Module