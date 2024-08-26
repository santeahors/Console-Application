Module Module1
    Sub Main()
        Dim continueProgram As String

        Do
            Dim SDT101, MAD102, SDA103, WAD104, NS105, AGD106, tp1, tp2, tp3, tp4, tp5, tp6, tp7, tp8, tp9, tp10, tp11, tp12, total_point, DBMS201, UIUX202, AI203, AA205, SQT204, DevOps206, gp As Double
            Dim op As String
            Dim pass As String
            Dim input As String
            Dim isValid As Boolean

            Console.WriteLine("                                ------------AFOOTECH GP CALCULATOR-----------")
            Console.WriteLine(" ")

            Console.WriteLine("PRESS 1 TO CALCULATE YOUR FIRST SEMESTER GP")
            Console.WriteLine("PRESS 2 TO CALCULATE YOUR SECOND SEMESTER GP")
            op = Console.ReadKey(True).KeyChar.ToString()
            Console.WriteLine("________________________________________________________________________________")

            If op <> "1" And op <> "2" Then
                Console.WriteLine("Invalid input. Please press 1 or 2 to calculate your GP.")
                Console.WriteLine("________________________________________________________________________________")
                Continue Do ' Restart the loop
            End If

            If op = "1" Then
                Do
                    Console.WriteLine("ENTER YOUR SCORE FOR SOFTWARE PROJECT DEVELOPMENT TRAINING (SDT101)")
                    input = Console.ReadLine()
                    isValid = Double.TryParse(input, SDT101)
                    If Not isValid Or SDT101 > 100 Or SDT101 < 0 Then
                        Console.WriteLine("Input Error! Please enter a valid numeric score between 0 and 100.")
                        Continue Do
                    End If

                    Console.WriteLine("ENTER YOUR SCORE FOR MOBILE APPLICATION DEVELOPMENT (MAD102)")
                    input = Console.ReadLine()
                    isValid = Double.TryParse(input, MAD102)
                    If Not isValid Or MAD102 > 100 Or MAD102 < 0 Then
                        Console.WriteLine("Input Error! Please enter a valid numeric score between 0 and 100.")
                        Continue Do
                    End If

                    Console.WriteLine("ENTER YOUR SCORE FOR SYSTEM & DATA ANALYSIS (SDA103)")
                    input = Console.ReadLine()
                    isValid = Double.TryParse(input, SDA103)
                    If Not isValid Or SDA103 > 100 Or SDA103 < 0 Then
                        Console.WriteLine("Input Error! Please enter a valid numeric score between 0 and 100.")
                        Continue Do
                    End If

                    Console.WriteLine("ENTER YOUR SCORE FOR WEBSITE & WEBSITE DEVELOPMENT (WAD104)")
                    input = Console.ReadLine()
                    isValid = Double.TryParse(input, WAD104)
                    If Not isValid Or WAD104 > 100 Or WAD104 < 0 Then
                        Console.WriteLine("Input Error! Please enter a valid numeric score between 0 and 100.")
                        Continue Do
                    End If

                    Console.WriteLine("ENTER YOUR SCORE FOR NETWORKING AND SECURITY (NS105)")
                    input = Console.ReadLine()
                    isValid = Double.TryParse(input, NS105)
                    If Not isValid Or NS105 > 100 Or NS105 < 0 Then
                        Console.WriteLine("Input Error! Please enter a valid numeric score between 0 and 100.")
                        Continue Do
                    End If

                    Console.WriteLine("ENTER YOUR SCORE FOR ADVANCE GRAPHICS DESIGN TRAINING (AGD106)")
                    input = Console.ReadLine()
                    isValid = Double.TryParse(input, AGD106)
                    If Not isValid Or AGD106 > 100 Or AGD106 < 0 Then
                        Console.WriteLine("Input Error! Please enter a valid numeric score between 0 and 100.")
                        Continue Do
                    End If

                    tp1 = GetGradePoint(SDT101, 4)
                    tp2 = GetGradePoint(MAD102, 4)
                    tp3 = GetGradePoint(SDA103, 5)
                    tp4 = GetGradePoint(WAD104, 4)
                    tp5 = GetGradePoint(NS105, 4)
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

                    Console.WriteLine("Do you want to calculate your GP for the first semester again? (y/n)")
                    continueProgram = Console.ReadLine().ToLower()
                Loop While continueProgram = "y"
            End If

            If op = "2" Then
                Do
                    Console.WriteLine("ENTER YOUR SCORE FOR DATABASE MANAGEMENT SYSTEM (DBMS201)")
                    input = Console.ReadLine()
                    isValid = Double.TryParse(input, DBMS201)
                    If Not isValid Or DBMS201 > 100 Or DBMS201 < 0 Then
                        Console.WriteLine("Input Error! Please enter a valid numeric score between 0 and 100.")
                        Continue Do
                    End If

                    Console.WriteLine("ENTER YOUR SCORE FOR UI & UX DESIGN (UIUX202)")
                    input = Console.ReadLine()
                    isValid = Double.TryParse(input, UIUX202)
                    If Not isValid Or UIUX202 > 100 Or UIUX202 < 0 Then
                        Console.WriteLine("Input Error! Please enter a valid numeric score between 0 and 100.")
                        Continue Do
                    End If

                    Console.WriteLine("ENTER YOUR SCORE FOR ARTIFICIAL INTELLIGENCE (AI203)")
                    input = Console.ReadLine()
                    isValid = Double.TryParse(input, AI203)
                    If Not isValid Or AI203 > 100 Or AI203 < 0 Then
                        Console.WriteLine("Input Error! Please enter a valid numeric score between 0 and 100.")
                        Continue Do
                    End If

                    Console.WriteLine("ENTER YOUR SCORE FOR SOFTWARE QUALITY TESTING (SQT204)")
                    input = Console.ReadLine()
                    isValid = Double.TryParse(input, SQT204)
                    If Not isValid Or SQT204 > 100 Or SQT204 < 0 Then
                        Console.WriteLine("Input Error! Please enter a valid numeric score between 0 and 100.")
                        Continue Do
                    End If

                    Console.WriteLine("ENTER YOUR SCORE FOR AUGMENTED ANALYTICS (AA205)")
                    input = Console.ReadLine()
                    isValid = Double.TryParse(input, AA205)
                    If Not isValid Or AA205 > 100 Or AA205 < 0 Then
                        Console.WriteLine("Input Error! Please enter a valid numeric score between 0 and 100.")
                        Continue Do
                    End If

                    Console.WriteLine("ENTER YOUR SCORE FOR DEVOPS (DevOps206)")
                    input = Console.ReadLine()
                    isValid = Double.TryParse(input, DevOps206)
                    If Not isValid Or DevOps206 > 100 Or DevOps206 < 0 Then
                        Console.WriteLine("Input Error! Please enter a valid numeric score between 0 and 100.")
                        Continue Do
                    End If

                    tp7 = GetGradePoint(DBMS201, 5)
                    tp8 = GetGradePoint(UIUX202, 3)
                    tp9 = GetGradePoint(AI203, 5)
                    tp10 = GetGradePoint(SQT204, 3)
                    tp11 = GetGradePoint(AA205, 4)
                    tp12 = GetGradePoint(DevOps206, 4)

                    total_point = tp7 + tp8 + tp9 + tp10 + tp11 + tp12
                    gp = total_point / 24

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

                    Console.WriteLine("Do you want to calculate your GP for the second semester again? (y/n)")
                    continueProgram = Console.ReadLine().ToLower()
                Loop While continueProgram = "y"
            End If

            Console.WriteLine("Do you want to start the program over? (y/n)")
            continueProgram = Console.ReadLine().ToLower()
        Loop While continueProgram = "y"
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
