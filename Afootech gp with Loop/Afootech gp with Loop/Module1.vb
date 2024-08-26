Module Module1

    Sub Main()
        Dim Restart As Boolean = True
        Do While Restart
            Dim SDT101, WAP102, MAD103, NS104, SDA105, AGD106, tp1, tp2, tp3, tp4, tp5, tp6, total_point, gp As Double
            Dim pass As String

            Console.WriteLine("                                ------------AFOOTECH GP CALCULATOR-----------")
            Console.WriteLine(" ")

            Console.WriteLine("PRESS ANY KEY TO CALCULATE YOUR GP")
            Console.ReadKey(True)
            Console.WriteLine("________________________________________________________________________________")


            Console.WriteLine("ENTER YOUR SCORE FOR SOFTWARE PROJECT DEVELOPMENT TRAINING (SDT101)")
            If Not Double.TryParse(Console.ReadLine(), SDT101) OrElse SDT101 > 100 OrElse SDT101 < 0 Then
                Console.WriteLine("Input Error! Please enter a valid number between 0 and 100.")
                Continue Do
            End If


            Console.WriteLine("ENTER YOUR SCORE FOR WEBSITE/WEB APPS DEVELOPMENT (WAP102)")
            If Not Double.TryParse(Console.ReadLine(), WAP102) OrElse WAP102 > 100 OrElse WAP102 < 0 Then
                Console.WriteLine("Input Error! Please enter a valid number between 0 and 100.")
                Continue Do
            End If

            Console.WriteLine("ENTER YOUR SCORE FOR MOBILE APPLICATION DEVELOPMENT (MAD103)")
            If Not Double.TryParse(Console.ReadLine(), MAD103) OrElse MAD103 > 100 OrElse MAD103 < 0 Then
                Console.WriteLine("Input Error! Please enter a valid number between 0 and 100.")
                Continue Do
            End If


            Console.WriteLine("ENTER YOUR SCORE FOR NETWORKING AND SECURITY (NS104)")
            If Not Double.TryParse(Console.ReadLine(), NS104) OrElse NS104 > 100 OrElse NS104 < 0 Then
                Console.WriteLine("Input Error! Please enter a valid number between 0 and 100.")
                Continue Do
            End If


            Console.WriteLine("ENTER YOUR SCORE FOR SYSTEM AND DATA ANALYSIS (SDA105)")
            If Not Double.TryParse(Console.ReadLine(), SDA105) OrElse SDA105 > 100 OrElse SDA105 < 0 Then
                Console.WriteLine("Input Error! Please enter a valid number between 0 and 100.")
                Continue Do
            End If


            Console.WriteLine("ENTER YOUR SCORE FOR ADVANCED GRAPHICS DESIGN TRAINING (AGD106)")
            If Not Double.TryParse(Console.ReadLine(), AGD106) OrElse AGD106 > 100 OrElse AGD106 < 0 Then
                Console.WriteLine("Input Error! Please enter a valid number between 0 and 100.")
                Continue Do
            End If


            tp1 = GetGradePoint(SDT101, 3)
            tp2 = GetGradePoint(WAP102, 4)
            tp3 = GetGradePoint(MAD103, 4)
            tp4 = GetGradePoint(NS104, 3)
            tp5 = GetGradePoint(SDA105, 3)
            tp6 = GetGradePoint(AGD106, 3)

            total_point = tp1 + tp2 + tp3 + tp4 + tp5 + tp6
            gp = total_point / 20


            Select Case gp
                Case Is >= 3.5
                    pass = "Distinction"
                Case Is >= 3.0
                    pass = "Upper Credit"
                Case Is >= 2.5
                    pass = "Lower Credit"
                Case Is >= 2.0
                    pass = "Pass"
                Case Else
                    pass = "Fail"
            End Select

            Console.WriteLine("=======================================")
            Console.WriteLine("Your Grade-Point(GP) is " + gp.ToString("N2") + " " + pass)

            Console.WriteLine("Do you want to calculate another GP? (y/n)")
            Dim response As String = Console.ReadLine().ToLower()

            If response <> "y" Then
                Restart = False
            End If
        Loop

        Console.WriteLine("Thank you for using the GP Calculator. Press any key to exit.")
        Console.ReadKey(True)

    End Sub

    Function GetGradePoint(ByVal score As Double, ByVal creditUnit As Integer) As Double
        Select Case score
            Case Is >= 80
                Return 4.0 * creditUnit
            Case Is >= 70
                Return 3.5 * creditUnit
            Case Is >= 60
                Return 3.0 * creditUnit
            Case Is >= 50
                Return 2.5 * creditUnit
            Case Is >= 40
                Return 2.0 * creditUnit
            Case Else
                Return 0 * creditUnit
        End Select
    End Function

End Module
