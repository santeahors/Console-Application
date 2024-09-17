Public Class AfoGpCalc

    Private Property pass As String
    Private Property totalpointA As Double
    Private Property gradepointA As Double
    Private Property totalpointB As Double
    Private Property gradepointB As Double

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        EnableDisplayElements()

        Display.Text = "ENTER THE SCORE FOR FIRST SEMESTER"
        showlbl1.Text = "SDT101"
        showlbl2.Text = "MAD102"
        showLbl3.Text = "SDA103"
        showlbl4.Text = "WAD104"
        showlbl5.Text = "NS105"
        showlbl6.Text = "AGD106"
        InputA_txt.Text = "SOFTWARE PROJECT DEVELOPMENT TRAINING"
        InputB_txt.Text = "MOBILE APPLICATION DEVELOPMENT"
        InputC_txt.Text = "SYSTEM & DATA ANALYSIS"
        InputD_txt.Text = "WEBSITE & WEBSITE DEVELOPMENT"
        InputE_txt.Text = "NETWORKING AND SECURITY"
        InputF_txt.Text = "ADVANCE GRAPHICS DESIGN TRAINING"
        pl1.Text = "4"
        pl2.Text = "4"
        pl3.Text = "5"
        pl4.Text = "4"
        pl5.Text = "4"
        pl6.Text = "4"
        CU_txt.Text = "25"
        Button2.Enabled = False
        Button1.Enabled = True
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        EnableDisplayElements()

        Display.Text = "ENTER THE SCORE FOR SECOND SEMESTER"
        showlbl1.Text = "DBMS201"
        showlbl2.Text = "UX202"
        showLbl3.Text = "AI203"
        showlbl4.Text = "SQT204"
        showlbl5.Text = "AA205"
        showlbl6.Text = "DevOps"
        InputA_txt.Text = "DATABASE MANAGEMENT SYSTEM"
        InputB_txt.Text = "UI & UX DESIGN"
        InputC_txt.Text = "ARTIFICIAL INTELLIGENCE"
        InputD_txt.Text = "SOFTWARE QUALITY TESTING"
        InputE_txt.Text = "AUGMENTED ANALYTICS"
        InputF_txt.Text = "DEVOPS"
        pl1.Text = "5"
        pl2.Text = "3"
        pl3.Text = "5"
        pl4.Text = "3"
        pl5.Text = "4"
        pl6.Text = "4"
        CU2_txt.Text = "24"
        Button1.Enabled = False
    End Sub

    Private Sub calc_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles calc_btn.Click
        Try
            If Button1.Enabled Then

                Dim tp1 As Double = GetGradePoint(Val(scoreA_txt.Text), 4)
                Dim tp2 As Double = GetGradePoint(Val(scoreB_txt.Text), 4)
                Dim tp3 As Double = GetGradePoint(Val(scoreC_txt.Text), 5)
                Dim tp4 As Double = GetGradePoint(Val(scoreD_txt.Text), 4)
                Dim tp5 As Double = GetGradePoint(Val(scoreE_txt.Text), 4)
                Dim tp6 As Double = GetGradePoint(Val(scoreF_txt.Text), 4)

                totalpointA = tp1 + tp2 + tp3 + tp4 + tp5 + tp6
                gradepointA = totalpointA / 25
                totalpointA_txt.Text = totalpointA.ToString("F2")
                gradepointA_txt.Text = gradepointA.ToString("F2")

                Button2.Enabled = False
                Button1.Enabled = True


            End If

            If Button2.Enabled Then

                Dim tp7 As Double = GetGradePoint(Val(scoreA_txt.Text), 5)
                Dim tp8 As Double = GetGradePoint(Val(scoreB_txt.Text), 3)
                Dim tp9 As Double = GetGradePoint(Val(scoreC_txt.Text), 5)
                Dim tp10 As Double = GetGradePoint(Val(scoreD_txt.Text), 3)
                Dim tp11 As Double = GetGradePoint(Val(scoreE_txt.Text), 4)
                Dim tp12 As Double = GetGradePoint(Val(scoreF_txt.Text), 4)

                totalpointB = tp7 + tp8 + tp9 + tp10 + tp11 + tp12
                gradepointB = totalpointB / 24
                totalpoint_txt.Text = totalpointB.ToString("F2")
                gradepoint_txt.Text = gradepointB.ToString("F2")


                Dim finalGrade As Double = (gradepointA + gradepointB) / 2
                Select Case finalGrade
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

                Resultt_txt.Text = "Final Grade: " & finalGrade.ToString("F2") & " (" & pass & ")"
                Resultt_txt.Visible = True
                Button1.Enabled = False
                Button2.Enabled = True
            End If

        Catch ex As Exception
            ShowError("Please ensure all inputs are valid numbers.")
        End Try
    End Sub

    Private Sub clear_txt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clear_txt.Click
        Display.Text = ""
        showlbl1.Text = ""
        showlbl2.Text = ""
        showLbl3.Text = ""
        showlbl4.Text = ""
        showlbl5.Text = ""
        showlbl6.Text = ""
        InputA_txt.Text = ""
        InputB_txt.Text = ""
        InputC_txt.Text = ""
        InputD_txt.Text = ""
        InputE_txt.Text = ""
        InputF_txt.Text = ""
        pl1.Text = ""
        pl2.Text = ""
        pl3.Text = ""
        pl4.Text = ""
        pl5.Text = ""
        pl6.Text = ""
        scoreA_txt.Text = ""
        scoreB_txt.Text = ""
        scoreC_txt.Text = ""
        scoreD_txt.Text = ""
        scoreE_txt.Text = ""
        scoreF_txt.Text = ""

        Button1.Enabled = True
        Button2.Enabled = True
    End Sub

    Private Function GetGradePoint(ByVal score As Double, ByVal creditUnit As Integer) As Double
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

    Private Sub EnableDisplayElements()
        Display.Visible = True
        showlbl1.Visible = True
        showlbl2.Visible = True
        showLbl3.Visible = True
        showlbl4.Visible = True
        showlbl5.Visible = True
        showlbl6.Visible = True
        InputA_txt.Visible = True
        InputB_txt.Visible = True
        InputC_txt.Visible = True
        InputD_txt.Visible = True
        InputE_txt.Visible = True
        InputF_txt.Visible = True
    End Sub

    Private Sub ShowError(ByVal message As String)
        Resultt_txt.Text = message
        Resultt_txt.Visible = True
    End Sub
    Private Sub ClearScores()
        scoreA_txt.Text = ""
        scoreB_txt.Text = ""
        scoreC_txt.Text = ""
        scoreD_txt.Text = ""
        scoreE_txt.Text = ""
        scoreF_txt.Text = ""
    End Sub

    Private Sub score_txt_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles scoreA_txt.KeyPress, scoreB_txt.KeyPress, scoreC_txt.KeyPress, scoreD_txt.KeyPress, scoreE_txt.KeyPress, scoreF_txt.KeyPress
        Dim txtBox As TextBox = CType(sender, TextBox)


        If Not Char.IsDigit(e.KeyChar) AndAlso Not e.KeyChar = "." AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If

        If e.KeyChar = "." AndAlso txtBox.Text.Contains(".") Then
            e.Handled = True
        End If


        Dim parts As String() = txtBox.Text.Split("."c)
        If parts.Length > 0 AndAlso parts(0).Length >= 4 AndAlso Not e.KeyChar = "." AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
        If parts.Length = 2 AndAlso parts(1).Length >= 2 AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

End Class
