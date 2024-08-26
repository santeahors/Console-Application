Module Module1

    Sub Main()

        Dim SDT101, WAP102, MAD103, NS104, SDA105, AGD106, tp1, tp2, tp3, tp4, tp5, tp6, total_point, gp As Double
        Dim op As String
        Dim pass As String
        Dim input As String
        Dim isValid As Boolean

        Console.WriteLine("                                ------------AFOOTECH GP CALCULATOR-----------")
        Console.WriteLine(" ")

        Console.WriteLine("PRESS ANY KEY TO CALCULATE YOUR GP")
        Console.ReadKey(True)
        op = "1"
        Console.WriteLine("________________________________________________________________________________")


        If op = "1" Then


            Console.WriteLine("ENTER YOUR SCORE FOR SOFTWARE PROJECT DEVELOPMENT TRAINING (SDT101)")
            input = Console.ReadLine()
            isValid = Double.TryParse(input, SDT101)
            If Not isValid Or SDT101 > 100 Or SDT101 < 0 Then
                Console.WriteLine("Input Error! Please enter a valid numeric score between 0 and 100.")
                Console.ReadLine()
                End ' 
            End If


            Console.WriteLine("ENTER YOUR SCORE FOR WEBSITE/WEB APPS DEVELOPMENT (WAP102)")
            input = Console.ReadLine()
            isValid = Double.TryParse(input, WAP102)
            If Not isValid Or WAP102 > 100 Or WAP102 < 0 Then
                Console.WriteLine("Input Error! Please enter a valid numeric score between 0 and 100.")
                Console.ReadLine()
                End
            End If


            Console.WriteLine("ENTER YOUR SCORE FOR MOBILE APPLICATION DEVELOPMENT (MAD103)")
            input = Console.ReadLine()
            isValid = Double.TryParse(input, MAD103)
            If Not isValid Or MAD103 > 100 Or MAD103 < 0 Then
                Console.WriteLine("Input Error! Please enter a valid numeric score between 0 and 100.")
                Console.ReadLine()
                End
            End If

            Console.WriteLine("ENTER YOUR SCORE FOR NETWORKING AND SECURITY (NS104)")
            input = Console.ReadLine()
            isValid = Double.TryParse(input, NS104)
            If Not isValid Or NS104 > 100 Or NS104 < 0 Then
                Console.WriteLine("Input Error! Please enter a valid numeric score between 0 and 100.")
                Console.ReadLine()
                End
            End If

            Console.WriteLine("ENTER YOUR SCORE FOR SYSTEM AND DATA ANALYSIS (SDA105)")
            input = Console.ReadLine()
            isValid = Double.TryParse(input, SDA105)
            If Not isValid Or SDA105 > 100 Or SDA105 < 0 Then
                Console.WriteLine("Input Error! Please enter a valid numeric score between 0 and 100.")
                Console.ReadLine()
                End
            End If


            Console.WriteLine("ENTER YOUR SCORE FOR ADVANCED GRAPHICS DESIGN TRAINING (AGD106)")
            input = Console.ReadLine()
            isValid = Double.TryParse(input, AGD106)
            If Not isValid Or AGD106 > 100 Or AGD106 < 0 Then
                Console.WriteLine("Input Error! Please enter a valid numeric score between 0 and 100.")
                Console.ReadLine()
                End
            End If


            tp1 = GetGradePoint(SDT101, 4)
            tp2 = GetGradePoint(WAP102, 4)
            tp3 = GetGradePoint(MAD103, 5)
            tp4 = GetGradePoint(NS104, 4)
            tp5 = GetGradePoint(SDA105, 4)
            tp6 = GetGradePoint(AGD106, 4)


            total_point = tp1 + tp2 + tp3 + tp4 + tp5 + tp6
            gp = total_point / 25

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
            Console.WriteLine("Your Grade-Point(GP) is " + gp.ToString("N2"))

            Console.WriteLine("Your Grade-Point Remark is " + pass)
        End If

        Console.ReadLine()

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
