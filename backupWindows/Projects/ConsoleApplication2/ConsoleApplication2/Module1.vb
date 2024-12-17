Module Module1
    Dim continueProgramm, continueProgram As String
    Sub Main()
        Dim continueProgram As Boolean = True

        While continueProgram
            Console.Clear()
            Console.WriteLine("=========================MULTIFUNCTIONAL APPLICATION===========================")
            Console.WriteLine("Input an option:")
            Console.WriteLine("1. Age Calculator")
            Console.WriteLine("2. Boyle's Law Calculator")
            Console.WriteLine("3. Salary Calculator")
            Console.WriteLine("4. Grade-Point (GP) Calculator")
            Console.WriteLine("5. LoanCalculator")
            Console.WriteLine("6. SimpleCalculator")
            Console.WriteLine("7. Exit Program")
            Dim optionSelected As String = Console.ReadKey(True).KeyChar.ToString()
            Console.WriteLine("________________________________________________________________________________")

            Select Case optionSelected
                Case "1"
                    AgeCalculator()
                Case "2"
                    BoylesLawCalculator()
                Case "3"
                    SalaryCalculator()
                Case "4"
                    GPCalculator()
                Case "5"
                    LoanCalculator()

                Case "6"
                    SimpleCalculator()
                    continueProgram = True
                Case "7"
                    continueProgram = False
                Case Else
                    Console.WriteLine("Invalid option. Please Input a valid option.")
            End Select

            If continueProgram Then
                Console.WriteLine("________________________________________________________________________________")
                Console.WriteLine("Press R to return to the main menu, or any other key to exit.")
                Dim choice As ConsoleKeyInfo = Console.ReadKey(True)
                If choice.Key <> ConsoleKey.R Then
                    continueProgram = False
                End If
            End If
        End While

        Console.WriteLine("Exiting the program...")
    End Sub

    Private Sub AgeCalculator()
        Do
            Console.Clear()
            Dim Tomonth, Today, Toyear As Integer
            Dim BirthDay, BirthYear, BirthMonth As Integer
            Dim DaysInMonth As Integer
            Dim resultday, resultmonth, resultyear As Integer

            Console.WriteLine("AGE CALCULATOR")
            Console.WriteLine("-------------------------------")

            Today = Date.Now.Day
            Tomonth = Date.Now.Month
            Toyear = Date.Now.Year

            Console.WriteLine("TODAY'S DATE IS " + Date.Now)
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
                If Not Integer.TryParse(Console.ReadLine(), BirthYear) OrElse BirthYear < 1 OrElse (BirthMonth > Tomonth AndAlso BirthYear = Toyear) AndAlso BirthYear > DaysInMonth Then
                    Console.WriteLine("Error In Input: Invalid Year or Month")
                Else
                    Exit Do
                End If
            Loop

            DaysInMonth = System.DateTime.DaysInMonth(BirthYear, BirthMonth)

            Select Case True
                Case BirthMonth = 2 And BirthDay > DaysInMonth
                    Console.WriteLine("INVALID  ! ENTER A VALID SELECTION FOR BIRTHDAY/BIRTH MONTH")
                Case BirthMonth > 12 Or BirthYear > Toyear Or BirthDay > 31 Or BirthDay < 1 Or BirthMonth < 1 Or BirthYear < 1
                    Console.WriteLine("INVALID INPUT! ENTER A VALID BIRTH DATE")
                Case BirthDay > Today And BirthMonth >= Tomonth And BirthYear >= Toyear
                    Console.WriteLine("WAIT! You are not yet in FUTURE")
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

                    If resultday < 1 Then
                        Console.WriteLine("YOUR ARE WELCOME TO THIS WORLD")
                    ElseIf resultmonth < 1 Then
                        Console.WriteLine("YOUR AGE IS = " + resultday.ToString + " DAY(S) OLD")
                    ElseIf resultyear < 1 Then
                        Console.WriteLine("YOUR AGE IS = " + resultmonth.ToString + " MONTH(S), " + resultday.ToString + " DAY(S) OLD")
                    Else
                        Console.WriteLine("YOUR AGE IS = " + resultyear.ToString + " YEAR(S), " + resultmonth.ToString + " MONTH(S), " + resultday.ToString + " DAY(S) OLD")
                    End If

            End Select

            Console.WriteLine("Do you want to calculate again? (y/n)")
        Loop While Console.ReadLine().ToLower() = "y"

    End Sub

    Private Sub BoylesLawCalculator()


        Do
            Console.Clear()
            Dim P1 As Double
            Dim V1 As Double
            Dim P2 As Double
            Dim V2 As Double
            Dim choice As String

            Console.WriteLine("----------------SOFTWARE TO CALCULATE BOYLE'S LAW---------------")
            Console.WriteLine()
            Console.WriteLine("Which variable would you like to calculate?")
            Console.WriteLine("1. Initial Pressure (P1)")
            Console.WriteLine("2. Initial Volume (V1)")
            Console.WriteLine("3. Final Pressure (P2)")
            Console.WriteLine("4. Final Volume (V2)")
            Console.Write("Enter the number corresponding to your choice (1-4): ")
            choice = Console.ReadKey(True).KeyChar.ToString()
            Console.WriteLine()

            Console.WriteLine("________________________________________________________________________________")

            Select Case choice
                Case "1"
                    P2 = GetDoubleInput("Enter the final pressure (P2): ")
                    V2 = GetDoubleInput("Enter the final volume (V2): ")
                    V1 = GetDoubleInput("Enter the initial volume (V1): ")

                    P1 = (P2 * V2) / V1
                    Console.WriteLine("The initial pressure (P1) is: " & P1 & " atm")

                Case "2"
                    P2 = GetDoubleInput("Enter the final pressure (P2): ")
                    V2 = GetDoubleInput("Enter the final volume (V2): ")
                    P1 = GetDoubleInput("Enter the initial pressure (P1): ")

                    V1 = (P2 * V2) / P1
                    Console.WriteLine("The initial volume (V1) is: " & V1 & " L")

                Case "3"
                    P1 = GetDoubleInput("Enter the initial pressure (P1): ")
                    V1 = GetDoubleInput("Enter the initial volume (V1): ")
                    V2 = GetDoubleInput("Enter the final volume (V2): ")

                    P2 = (P1 * V1) / V2
                    Console.WriteLine("The final pressure (P2) is: " & P2 & " atm")

                Case "4"
                    P1 = GetDoubleInput("Enter the initial pressure (P1): ")
                    V1 = GetDoubleInput("Enter the initial volume (V1): ")
                    P2 = GetDoubleInput("Enter the final pressure (P2): ")

                    V2 = (P1 * V1) / P2
                    Console.WriteLine("The final volume (V2) is: " & V2 & " L")

                Case Else
                    Console.WriteLine("Invalid choice.")
            End Select

            Console.WriteLine("Do you want to calculate again? (y/n)")
            continueProgram = Console.ReadLine().ToLower()
        Loop While continueProgram = "y"

    End Sub

    Function GetDoubleInput(ByVal prompt As String) As Double
        Dim result As Double
        Console.Write(prompt)
        While Not Double.TryParse(Console.ReadLine(), result)
            Console.WriteLine("Invalid input. Please enter a numeric value.")
            Console.Write(prompt)
        End While
        Return result
    End Function

    Private Sub SalaryCalculator()


        Do
            Console.Clear()
            Console.WriteLine("                THIS SOFTWARE  IS TO CALCULATE STAFF SALARY")
            Console.WriteLine("=====================================================================")
            Console.WriteLine("")

            Dim salary As Decimal
            Dim tax, totalBalance As Decimal

            Console.WriteLine("ENTER SALARY AMOUNT")
            While Not Decimal.TryParse(Console.ReadLine(), salary)
                Console.WriteLine("Invalid input. Please enter a numeric value.")
                Console.WriteLine("ENTER SALARY AMOUNT")
            End While
            Console.WriteLine("")

            tax = (5 / 100) * salary
            totalBalance = salary - tax

            Console.WriteLine("YOUR TAX FOR THE AMOUNT OF " & salary & " IS " & tax)
            Console.WriteLine("YOUR NET BALANCE IS " & totalBalance)

            Console.WriteLine("Do you want to calculate again? (y/n)")
            continueProgram = Console.ReadLine().ToLower()
        Loop While continueProgram = "y"

    End Sub

    Private Sub GPCalculator()

        Do Until continueProgram = "y"

            Dim SDT101, MAD102, SDA103, WAD104, NS105, AGD106 As Double
            Dim DBMS201, UIUX202, AI203, AA205, SQT204, DevOps206, tp1, tp2, tp3, tp4, tp5, tp6, tp7, tp8, tp9, tp10, tp11, tp12, total_point As Double
            Dim op As String
            Dim gp As Double
            Dim pass As String

            Console.Clear()
            Console.WriteLine(" ------------AFOOTECH GP CALCULATOR-----------")
            Console.WriteLine(" ")
            Console.WriteLine("PRESS 1 TO CALCULATE YOUR FIRST SEMESTER GP")
            Console.WriteLine("PRESS 2 TO CALCULATE YOUR SECOND SEMESTER GP")

            op = Console.ReadKey(True).KeyChar.ToString()
            Console.WriteLine("________________________________________________________________________________")

            If op <> "1" And op <> "2" Then
                Console.WriteLine("Invalid input. Please press 1 or 2 to calculate your GP.")
                Console.WriteLine("________________________________________________________________________________")
                Continue Do
            End If

            If op = "1" Then
                Do

                    SDT101 = GetValidScore("SOFTWARE PROJECT DEVELOPMENT TRAINING (SDT101)")
                    MAD102 = GetValidScore("MOBILE APPLICATION DEVELOPMENT (MAD102)")
                    SDA103 = GetValidScore("SYSTEM & DATA ANALYSIS (SDA103)")
                    WAD104 = GetValidScore("WEBSITE & WEBSITE DEVELOPMENT (WAD104)")
                    NS105 = GetValidScore("NETWORKING AND SECURITY (NS105)")
                    AGD106 = GetValidScore("ADVANCE GRAPHICS DESIGN TRAINING (AGD106)")


                    tp1 = GetGradePoint(SDT101, 4)
                    tp2 = GetGradePoint(MAD102, 4)
                    tp3 = GetGradePoint(SDA103, 5)
                    tp4 = GetGradePoint(WAD104, 4)
                    tp5 = GetGradePoint(NS105, 4)
                    tp6 = GetGradePoint(AGD106, 4)

                    total_point = tp1 + tp2 + tp3 + tp4 + tp5 + tp6
                    gp = total_point / 25
                    pass = GradePoint(gp)

                    Console.WriteLine("=======================================")
                    Console.WriteLine("Your Grade-Point(GP) is " + gp.ToString("N2"))
                    Console.WriteLine("Your Grade-Point Remark is " + pass)

                    Console.WriteLine("Do you want to calculate your GP for the first semester again? (y/n)")
                    continueProgram = Console.ReadLine().ToLower()
                Loop While continueProgram = "y"
            End If

            If op = "2" Then
                Do
                    DBMS201 = GetValidScore("DATABASE MANAGEMENT SYSTEM (DBMS201)")
                    UIUX202 = GetValidScore("UI & UX DESIGN (UIUX202)")
                    AI203 = GetValidScore("ARTIFICIAL INTELLIGENCE (AI203)")
                    SQT204 = GetValidScore("SOFTWARE QUALITY TESTING (SQT204)")
                    AA205 = GetValidScore("AUGMENTED ANALYTICS (AA205)")
                    DevOps206 = GetValidScore("DEVOPS (DevOps206)")


                    tp7 = GetGradePoint(DBMS201, 5)
                    tp8 = GetGradePoint(UIUX202, 3)
                    tp9 = GetGradePoint(AI203, 5)
                    tp10 = GetGradePoint(SQT204, 3)
                    tp11 = GetGradePoint(AA205, 4)
                    tp12 = GetGradePoint(DevOps206, 4)

                    total_point = tp7 + tp8 + tp9 + tp10 + tp11 + tp12
                    gp = total_point / 24
                    pass = GradePoint(gp)

                    Console.WriteLine("=======================================")
                    Console.WriteLine("Your Grade-Point(GP) is " + gp.ToString("N2"))
                    Console.WriteLine("Your Grade-Point Remark is " + pass)

                    Console.WriteLine("Do you want to calculate your GP for the second semester again? (y/n)")
                    continueProgram = Console.ReadLine().ToLower()
                Loop While continueProgram = "y"
            End If

            Console.WriteLine("Do you want to calculate G-P again? (y/n)")
            continueProgram = Console.ReadLine().ToLower()
            continueProgram = "y"
        Loop
    End Sub

    Function GetValidScore(ByVal subject As String) As Double
        Dim score As Double
        Dim input As String
        Dim isValid As Boolean

        Do
            Console.WriteLine("ENTER YOUR SCORE FOR " + subject)
            input = Console.ReadLine()

            isValid = Double.TryParse(input, score)
            If Not isValid OrElse score > 100 OrElse score < 0 Then
                Console.WriteLine("Input Error! Please enter a valid numeric score between 0 and 100.")
            End If
        Loop While Not isValid OrElse score > 100 OrElse score < 0

        Return score
    End Function

    Function GetGradePoint(ByVal score As Double, ByVal units As Double) As Double
        Dim gradePoint As Double


        Select Case score
            Case Is >= 70
                gradePoint = 4.0
            Case Is >= 60
                gradePoint = 3.5
            Case Is >= 50
                gradePoint = 3.0
            Case Is >= 40
                gradePoint = 2.0
            Case Else
                gradePoint = 0.0
        End Select

        Return gradePoint * units
    End Function

    Function GradePoint(ByVal gp As Double) As String
        Select Case gp
            Case Is >= 3.5
                Return "Distinction"
            Case Is >= 3.0
                Return "Upper Credit"
            Case Is >= 2.5
                Return "Lower Credit"
            Case Is >= 2.0
                Return "Pass"
            Case Else
                Return "Fail"
        End Select
    End Function

    Private Sub LoanCalculator()
        Dim input As String
        Dim restart As String

        Do
            Console.Clear()

            Dim loanAmount, LoanDuration, MonthlyInterest, MonthlyRepayment, RemainingBalance, PrincipalPortion, TotalInterest, TotalAmountPaid As Double
            TotalInterest = 0
            TotalAmountPaid = 0

            Console.WriteLine("====== AfooTECH Loan Application ========")
            Console.WriteLine()


            Do
                Console.WriteLine("Enter the loan amount:")
                input = Console.ReadLine()

                If Double.TryParse(input, loanAmount) AndAlso loanAmount > 0 Then
                    Exit Do
                Else
                    Console.WriteLine("Invalid input. Please enter a positive numeric value.")
                End If
            Loop While True

            Console.WriteLine()


            Do
                Console.WriteLine("Enter Loan Duration (in months):")
                input = Console.ReadLine()

                If Double.TryParse(input, LoanDuration) AndAlso LoanDuration > 0 Then
                    Exit Do
                Else
                    Console.WriteLine("Invalid input. Please enter a positive numeric value.")
                End If
            Loop While True

            Console.WriteLine()

            RemainingBalance = loanAmount
            PrincipalPortion = loanAmount / LoanDuration

            Console.WriteLine("MONTH".PadRight(10) & "PrincipalPortion".PadRight(20) & "Interest Paid".PadRight(20) & "Remaining Balance".PadRight(20) & "Repayment".PadLeft(8))
            Console.WriteLine(New String("-"c, 90))

            For i As Integer = 1 To LoanDuration

                MonthlyInterest = (1.5 / 100) * RemainingBalance
                MonthlyRepayment = PrincipalPortion + MonthlyInterest
                RemainingBalance -= PrincipalPortion
                TotalInterest += MonthlyInterest
                TotalAmountPaid += MonthlyRepayment

                Console.WriteLine(i.ToString().PadRight(10) & PrincipalPortion.ToString("N2").PadRight(20) & MonthlyInterest.ToString("N2").PadRight(20) & Math.Max(RemainingBalance, 0).ToString("N2").PadRight(20) & MonthlyRepayment.ToString("N2"))
            Next

            Console.WriteLine()
            Console.WriteLine("Total Interest Paid: " & TotalInterest.ToString("N2"))
            Console.WriteLine("Total Amount Repaid: " & TotalAmountPaid.ToString("N2"))

            Console.WriteLine()
            Console.WriteLine("To restart the application? Press (Y) to restart, or any other key to quit.")

            restart = Console.ReadLine().Trim().ToUpper()

        Loop While restart = "Y"
        Console.WriteLine("Thank you for using the loan application. Press any key to exit...")
        Console.ReadKey()

    End Sub

    Private Sub SimpleCalculator()

        Console.WriteLine("               A SIMPLE CALCULATOR SOFTWARE     ")
        Console.WriteLine("==================================================")
        Console.WriteLine("")
        Do
            Console.Clear()
            Dim first_no, second_no As Double
            Dim result As Double
            Dim op As Integer

            Console.WriteLine("press 1 for Addition")
            Console.WriteLine("press 2 for Difference")
            Console.WriteLine("press 3 for Product")
            Console.WriteLine("press 4 for Fraction")

            op = Console.ReadLine
            Do
                If op <> 1 AndAlso op <> 2 AndAlso op <> 3 AndAlso op <> 4 Then
                    Console.WriteLine("invalid input")

                End If

                If op = (1) Then
                    Console.WriteLine("      SUM OF NUMBERS")
                    Console.WriteLine(" ")
                    Console.WriteLine("Enter First Sum")
                    first_no = Console.ReadLine
                    Console.WriteLine("Enter Second Sum")
                    second_no = Console.ReadLine
                    result = first_no + second_no
                    Console.WriteLine("result= " & result.ToString)

                ElseIf op = (2) Then
                    Console.WriteLine("      DIFFERENCE OF NUMBERS")
                    Console.WriteLine(" ")
                    Console.WriteLine("Enter First Difference")
                    first_no = Console.ReadLine
                    Console.WriteLine("Enter Second Difference")
                    second_no = Console.ReadLine
                    result = first_no - second_no
                    Console.WriteLine("The Difference = " & result.ToString)
                ElseIf op = (3) Then
                    Console.WriteLine("      PRODUCT OF NUMBERS")
                    Console.WriteLine(" ")
                    Console.WriteLine("Enter First Product")
                    first_no = Console.ReadLine
                    Console.WriteLine("Enter Second Product")
                    second_no = Console.ReadLine
                    result = first_no * second_no
                    Console.WriteLine("The Product = " & result.ToString)

                ElseIf op = (4) Then
                    Console.WriteLine("      FRACTION OF NUMBERS")
                    Console.WriteLine(" ")
                    Console.WriteLine(" Enter the Numerator")
                    first_no = Console.ReadLine
                    Console.WriteLine(" Enter the Denominator")
                    second_no = Console.ReadLine
                    If second_no > 1 Then
                        Console.WriteLine("Invalid denominator")
                        result = first_no / second_no
                    End If
                    Console.WriteLine("The Quotient = " & result.ToString)

                End If
                Console.WriteLine("Do you want to calculate again? (y/n)")
                continueProgram = Console.ReadLine().ToLower()
            Loop While continueProgram = "y"

            Console.WriteLine("To restart Press Y and to End program use any other key")
            continueProgramm = Console.ReadLine().Trim().ToUpper()

        Loop While continueProgramm = "Y"

        Console.WriteLine("Thank you for using the program. Press any key to exit...")
        Console.ReadKey()
    End Sub
End Module