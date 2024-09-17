Public Class Form1
    Private Sub close_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles close_btn.Click
        Dim response As Integer
        response = MessageBox.Show("Are you sure you want to exit ?", "Exit application",
                                   MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If response = vbYes Then
            Application.ExitThread()
        End If
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        land_label.Parent = landpic
        Boyles_label.Hide()
        land_panel.Show()
        loan_panel.Hide()
        simple_calc_panel.Hide()
        GpCalc_panel.Hide()
        AgePanel.Hide()
        unitConvert.Hide()
        CurrentVisiblePanel = loan_panel
        loan_panel.Hide()
        simple_calc_panel.Hide()
        Boyles_label.Hide()
        GpCalc_panel.Hide()
        AgePanel.Hide()
        unitConvert.Hide()
        Timer1.Interval = 50
    End Sub
    Private Sub sc_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sc_btn.Click
        simple_calc_panel.Show()
        unitConvert.Hide()
        land_panel.Hide()
        loan_panel.Hide()
        Boyles_label.Hide()
        GpCalc_panel.Hide()
        AgePanel.Hide()
        calcsc.Width = 0
    End Sub
    Private Sub home_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles home_btn.Click
        land_panel.Show()
        loan_panel.Hide()
        simple_calc_panel.Hide()
        Boyles_label.Hide()
        GpCalc_panel.Hide()
        AgePanel.Hide()
        unitConvert.Hide()

    End Sub


    Private Sub unit_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles unit_btn.Click
        unitConvert.Show()
        simple_calc_panel.Hide()
        land_panel.Hide()
        loan_panel.Hide()
        Boyles_label.Hide()
        GpCalc_panel.Hide()
        AgePanel.Hide()
    End Sub

    Private Sub loan_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles loan_btn.Click
        loan_panel.Show()
        simple_calc_panel.Hide()
        land_panel.Hide()
        Boyles_label.Hide()
        GpCalc_panel.Hide()
        AgePanel.Hide()
        unitConvert.Hide()
    End Sub


    Private Sub boyle_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boyle_btn.Click
        Boyles_label.Show()
        loan_panel.Hide()
        simple_calc_panel.Hide()
        land_panel.Hide()
        GpCalc_panel.Hide()
        AgePanel.Hide()
        unitConvert.Hide()
    End Sub


    Private Sub gp_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gp_btn.Click
        GpCalc_panel.Show()
        Boyles_label.Hide()
        land_panel.Hide()
        loan_panel.Hide()
        simple_calc_panel.Hide()
        AgePanel.Hide()
        unitConvert.Hide()

    End Sub
    Private Sub age_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles age_btn.Click
        AgePanel.Show()
        GpCalc_panel.Hide()
        Boyles_label.Hide()
        land_panel.Hide()
        loan_panel.Hide()
        simple_calc_panel.Hide()
        unitConvert.Hide()
    End Sub

    ' gpcalculator

    Private Property pass As String
    Private Property totalpointA As Double
    Private Property gradepointA As Double
    Private Property totalpointB As Double
    Private Property gradepointB As Double


    Private Sub ButtonSemester_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Buttonsemester.Click
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
        'Buttonsemester2.Enabled = False
        'Buttonsemester.Enabled = True
    End Sub

    Private Sub Buttonsemester2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Buttonsemester2.Click
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
        Buttonsemester.Enabled = False
    End Sub

    Private Sub calc_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles calc_btn.Click
        Try
            If Not ValidateScores() Then
                MessageBox.Show("Please ensure all inputs are valid numbers and not greater than 100.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            If Buttonsemester.Enabled Then
                '
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

                Buttonsemester2.Enabled = False
                Buttonsemester.Enabled = True
            End If

            If Buttonsemester2.Enabled Then

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
                
          
            End If

            Dim finalGrade As Double = (gradepointA + gradepointB) / 2
            Dim pass As String
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

                resultt_txt.Text = "Final Grade: " & finalGrade.ToString("F2") & " (" & pass & ")"
                resultt_txt.Visible = True
            Buttonsemester2.Enabled = True
            Buttonsemester.Enabled = False

        Catch ex As Exception
            ShowError11("Please ensure all inputs are valid numbers.")
        End Try
    End Sub

    ' Function to validate input scores (should be numeric and <= 100)
    Private Function ValidateScores() As Boolean
        Return IsNumeric(scoreA_txt.Text) AndAlso Val(scoreA_txt.Text) <= 100 AndAlso
               IsNumeric(scoreB_txt.Text) AndAlso Val(scoreB_txt.Text) <= 100 AndAlso
               IsNumeric(scoreC_txt.Text) AndAlso Val(scoreC_txt.Text) <= 100 AndAlso
               IsNumeric(scoreD_txt.Text) AndAlso Val(scoreD_txt.Text) <= 100 AndAlso
               IsNumeric(scoreE_txt.Text) AndAlso Val(scoreE_txt.Text) <= 100 AndAlso
               IsNumeric(scoreF_txt.Text) AndAlso Val(scoreF_txt.Text) <= 100
    End Function

    Private Sub clearall_txt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Clearall_txt.Click
        ' Clear all input fields and labels
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
        totalpointA_txt.Text = ""
        gradepointA_txt.Text = ""
        totalpoint_txt.Text = ""
        gradepoint_txt.Text = ""
        resultt_txt.Text = "RESULT"
        resultt_txt.Visible = False

        ' Reset button states
        Buttonsemester2.Enabled = True
        Buttonsemester.Enabled = True

        CU_txt.Text = ""
        CU2_txt.Text = ""

        totalpointA = 0
        gradepointA = 0
        totalpointB = 0
        gradepointB = 0
        pass = ""

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

        Buttonsemester2.Enabled = True
        Buttonsemester.Enabled = True
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


    Private Sub ShowError11(ByVal message As String)
        resultt_txt.Text = message
        resultt_txt.Visible = True
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

        If e.KeyChar = "." AndAlso txtBox.Text.Length = 0 Then
            e.Handled = True
        End If

        If e.KeyChar = "." AndAlso txtBox.Text.Contains(".") Then
            e.Handled = True
        End If

        Dim parts As String() = txtBox.Text.Split("."c)

        If parts.Length > 0 AndAlso parts(0).Length >= 2 AndAlso Not e.KeyChar = "." AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If

        If parts.Length = 2 AndAlso parts(1).Length >= 2 AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    ' loan
    Private Sub LoanBTnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoanBTnCalculate.Click

        Dim loanAmount As Double
        Dim LoanDuration As Integer

        Do

            If Not GetValidInput(LoanAmount_txt.Text, loanAmount) Then
                Exit Do
            End If


            If Not GetValidInput(LoanDuration_txt.Text, LoanDuration, True) Then
                Exit Do
            End If

            Dim MonthlyInterest, MonthlyRepayment, RemainingBalance, PrincipalPortion, TotalInterest, TotalAmountPaid As Double
            TotalInterest = 0
            TotalAmountPaid = 0

            RemainingBalance = loanAmount
            PrincipalPortion = loanAmount / LoanDuration

            Payments_txt.Text = "MONTH".PadRight(10) & "Principal".PadRight(20) & "Interest".PadRight(20) & "Remaining Balance".PadRight(20) & "Repayment".PadRight(19)
            Payments_txt.AppendText(Environment.NewLine & New String("-"c, 99) & Environment.NewLine)

            For i As Integer = 1 To LoanDuration
                MonthlyInterest = (1.5 / 100) * RemainingBalance
                MonthlyRepayment = PrincipalPortion + MonthlyInterest
                RemainingBalance -= PrincipalPortion
                TotalInterest += MonthlyInterest
                TotalAmountPaid += MonthlyRepayment

                Payments_txt.AppendText(i.ToString().PadRight(20) & PrincipalPortion.ToString("N2").PadRight(20) & MonthlyInterest.ToString("N2").PadRight(20) & Math.Max(RemainingBalance, 0).ToString("N2").PadRight(23) & MonthlyRepayment.ToString("N2") & Environment.NewLine)
            Next

            TotalAmount_txt.Text = TotalAmountPaid.ToString("N2")
            TotalAmount_txt.Visible = True

        Loop While False
    End Sub

    Private Sub loanclear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Loanclear.Click
        LoanDuration_txt.Text = ""
        LoanAmount_txt.Text = ""
        TotalAmount_txt.Text = ""
        Payments_txt.Text = ""
        TotalAmount_txt.Visible = False
    End Sub

    Private Function GetValidInput(ByVal input As String, ByRef value As Double, Optional ByVal isInteger As Boolean = False) As Boolean
        If isInteger Then
            If Not Integer.TryParse(input, value) OrElse value <= 0 Then
                ShowError1("Please enter a valid positive integer for loan duration.")
                Return False
            End If
        Else
            If Not Double.TryParse(input, value) OrElse value <= 0 Then
                ShowError1("Please enter a valid positive number for loan amount.")
                Return False
            End If
        End If
        Return True
    End Function

    Private Sub ShowError1(ByVal message As String)
        TotalAmount_txt.Text = message
        TotalAmount_txt.Visible = True
    End Sub

    Private Sub loanamount_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles LoanAmount_txt.KeyPress, LoanDuration_txt.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) AndAlso (e.KeyChar <> "."c) Then
            e.Handled = True
            ShowError1("Invalid input. Please enter a valid number.")
        End If

        If (e.KeyChar = "."c) AndAlso (DirectCast(sender, TextBox).Text.Length = 0) Then
            e.Handled = True
            ShowError("Input cannot start with a decimal point.")
        End If

        If (e.KeyChar = "."c) AndAlso (DirectCast(sender, TextBox).Text.IndexOf("."c) > -1) Then
            e.Handled = True
            ShowError("Only one decimal point is allowed.")
        End If
    End Sub


    ' =====================================================The Beginning of Converter ------------------------------------------------


   Dim op As String = ""


    Private Sub Convert()
        Dim celsius, fahrenheit As Double
        Dim kilo, liter, mililiter, gram As Double
        Dim kilometer, meter As Double


        If String.IsNullOrWhiteSpace(input_txt.Text) Then
            MsgBox("Field must not be empty", vbInformation)
            Exit Sub
        End If


        Select Case op
            Case "KM"
                kilometer = Double.Parse(input_txt.Text)
                show_txt.Text = (1000 * kilometer).ToString("N2")
            Case "MK"
                meter = Double.Parse(input_txt.Text)
                show_txt.Text = (meter / 1000).ToString("N2")
            Case "KG"
                kilo = Double.Parse(input_txt.Text)
                show_txt.Text = (1000 * kilo).ToString("N2")
            Case "GK"
                gram = Double.Parse(input_txt.Text)
                show_txt.Text = (gram / 1000).ToString("N2")
            Case "LM"
                liter = Double.Parse(input_txt.Text)
                show_txt.Text = (1000 * liter).ToString("N2")
            Case "ML"
                mililiter = Double.Parse(input_txt.Text)
                show_txt.Text = (mililiter / 1000).ToString("N2")
            Case "CF"
                celsius = Double.Parse(input_txt.Text)
                show_txt.Text = (((9 * celsius) / 5) + 32).ToString("N2")
            Case "FC"
                fahrenheit = Double.Parse(input_txt.Text)
                show_txt.Text = (((fahrenheit - 32) * 5) / 9).ToString("N2")
            Case Else
                MsgBox("Please select a conversion option.", vbExclamation)
        End Select
    End Sub

    Private Sub ce_to_fa_btn_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ce_to_fa_btn.CheckedChanged
        If ce_to_fa_btn.Checked Then
            op = "CF"
            unittop.Text = "°C"
            unitbottom.Text = "°F"
            Convert()
        End If
    End Sub

    Private Sub fa_to_ce_btn_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fa_to_ce_btn.CheckedChanged
        If fa_to_ce_btn.Checked Then
            op = "FC"
            unittop.Text = "°F"
            unitbottom.Text = "°C"
            Convert()
        End If
    End Sub

    Private Sub ki_to_gram_btn_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ki_to_gram_btn.CheckedChanged
        If ki_to_gram_btn.Checked Then
            op = "KG"
            unittop.Text = "Kg"
            unitbottom.Text = "g"
            Convert()
        End If
    End Sub

    Private Sub gr_to_ki_btn_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gr_to_ki_btn.CheckedChanged
        If gr_to_ki_btn.Checked Then
            op = "GK"
            unittop.Text = "g"
            unitbottom.Text = "Kg"
            Convert()
        End If
    End Sub

    Private Sub kil_to_met_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles kil_to_met.CheckedChanged
        If kil_to_met.Checked Then
            op = "KM"
            unittop.Text = "Km"
            unitbottom.Text = "M"
            Convert()
        End If
    End Sub

    Private Sub met_to_kil_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles met_to_kil.CheckedChanged
        If met_to_kil.Checked Then
            op = "MK"
            unittop.Text = "M"
            unitbottom.Text = "Km"
            Convert()
        End If
    End Sub

    Private Sub li_to_mil_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles li_to_mil.CheckedChanged
        If li_to_mil.Checked Then
            op = "LM"
            unittop.Text = "L"
            unitbottom.Text = "Ml"
            Convert()
        End If
    End Sub

    Private Sub mil_to_lit_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mil_to_lit.CheckedChanged
        If mil_to_lit.Checked Then
            op = "ML"
            unittop.Text = "Ml"
            unitbottom.Text = "L"
            Convert()
        End If
    End Sub


    Private Sub convert_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles convert_btn.Click
        Convert()
    End Sub


    Private Sub reset_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles reset_btn.Click
        input_txt.Clear()
        show_txt.Text = ""
        unittop.Text = ""
        unitbottom.Text = ""

        ce_to_fa_btn.Checked = False
        fa_to_ce_btn.Checked = False
        ki_to_gram_btn.Checked = False
        gr_to_ki_btn.Checked = False
        kil_to_met.Checked = False
        met_to_kil.Checked = False
        li_to_mil.Checked = False
        mil_to_lit.Checked = False
    End Sub

    Private Sub press(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles input_txt.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MsgBox("This field accepts only numbers", vbInformation)
        End If

        If e.KeyChar = "." AndAlso input_txt.Text.Contains(".") Then
            e.Handled = True
            MsgBox("Cannot accept multiple dots", vbInformation)
        ElseIf e.KeyChar = "." AndAlso (DirectCast(sender, TextBox).TextLength = 0) Then
            e.Handled = True
            MsgBox("Digit must come before dot")
        End If
    End Sub

    '=================================================The beginning of age________________________________________________
    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ageCalculate.Click

        Dim today, tomonth, toyear As Integer
        Dim birthyear, birthmonth, birthday As Integer
        Dim resultday, resultmonth, resultyear As Integer

        If (birthyear_txt.Text = "") Or (birthmonth_txt.Text = "") Or (birthday_txt.Text = "") Then
            MsgBox("Field must not be empty!", vbInformation)

        ElseIf (birthmonth_txt.Text > 12) Or (birthmonth_txt.Text < 1) Or (birthyear_txt.Text < 1) Then

            MsgBox("Erro1!", vbInformation)

        Else

            birthday = birthday_txt.Text
            birthmonth = birthday_txt.Text
            birthyear = birthyear_txt.Text

            resultyear_txt.Text = resultyear
            resultmonth_txt.Text = resultmonth
            resultday_txt.Text = resultday



            today = Date.Now.Day
            tomonth = Date.Now.Month
            toyear = Date.Now.Year

            Dim DaysInMonth As Integer

            DaysInMonth = System.DateTime.DaysInMonth(birthyear_txt.Text, birthmonth_txt.Text)


            If (birthmonth_txt.Text > 12) Or (birthyear_txt.Text > toyear) Or (birthday_txt.Text > 31) Or (birthday_txt.Text < 1) Or (birthmonth_txt.Text < 1) Or (birthyear_txt.Text < 1) Then
                resultyear_txt.Text = ""
                resultmonth_txt.Text = ""
                resultday_txt.Text = ""
                MsgBox("Wrong Input", vbInformation)


            ElseIf (birthyear_txt.Text > toyear) Then
                resultyear_txt.Text = ""
                resultmonth_txt.Text = ""
                resultday_txt.Text = ""
                MsgBox("Impossible!", vbInformation)

            ElseIf (birthday_txt.Text > today) And (birthmonth_txt.Text = tomonth) And (toyear = birthyear_txt.Text) Then
                resultyear_txt.Text = ""
                resultmonth_txt.Text = ""
                resultday_txt.Text = ""
                MsgBox("Impossible!", vbInformation)

            ElseIf (birthmonth_txt.Text > tomonth) And (birthyear_txt.Text = toyear) Then
                resultyear_txt.Text = ""
                resultmonth_txt.Text = ""
                resultday_txt.Text = ""
                MsgBox("Impossible Entry!", vbInformation)

            ElseIf (birthmonth_txt.Text = 2) And (birthday_txt.Text > 28) Then
                resultyear_txt.Text = ""
                resultmonth_txt.Text = ""
                resultday_txt.Text = ""
                MsgBox("INVALID INPUT! ENTER A VALID BIRTH MONTH", vbInformation)


            ElseIf (birthmonth_txt.Text > 12) Or (birthyear_txt.Text > toyear) Or (birthday_txt.Text > 31) Or (birthday_txt.Text < 1) Or (birthmonth_txt.Text < 1) Or (birthyear_txt.Text < 1) Then
                resultyear_txt.Text = ""
                resultmonth_txt.Text = ""
                resultday_txt.Text = ""
                MsgBox("Days not up to that", vbInformation)




            ElseIf (birthmonth_txt.Text = 4 Or 9 Or 11 Or 6) And (birthday_txt.Text > 30) Then
                resultyear_txt.Text = ""
                resultmonth_txt.Text = ""
                resultday_txt.Text = ""
                MsgBox("Days Not up to that", vbInformation)


            Else

                If (tomonth = birthmonth_txt.Text) And (birthday_txt.Text > today) Then
                    resultyear_txt.Text = toyear - birthyear_txt.Text - 1
                ElseIf (birthmonth_txt.Text > tomonth) And (today > birthday_txt.Text) Then
                    resultyear_txt.Text = toyear - birthyear_txt.Text - 1
                ElseIf (birthmonth_txt.Text > tomonth) And (today = birthday_txt.Text) Then
                    resultyear_txt.Text = toyear - birthyear_txt.Text - 1
                ElseIf (birthmonth_txt.Text > tomonth) And (birthday_txt.Text > today) Then
                    resultyear_txt.Text = toyear - birthyear_txt.Text - 1


                Else : resultyear_txt.Text = toyear - birthyear_txt.Text
                End If



                If (tomonth > birthmonth_txt.Text) And (birthday_txt.Text > today) Then
                    resultmonth_txt.Text = tomonth - birthmonth_txt.Text - 1
                ElseIf (tomonth = birthmonth_txt.Text) And (birthday_txt.Text > today) Then
                    resultmonth_txt.Text = tomonth - birthmonth_txt.Text + 12 - 1
                ElseIf (birthmonth_txt.Text > tomonth) And (today > birthday_txt.Text) Then
                    resultmonth_txt.Text = tomonth - birthmonth_txt.Text + 12
                ElseIf (birthmonth_txt.Text > tomonth) And (today = birthday_txt.Text) Then
                    resultmonth_txt.Text = tomonth - birthmonth_txt.Text + 12
                ElseIf (birthmonth_txt.Text > tomonth) And (birthday_txt.Text > today) Then
                    resultmonth_txt.Text = tomonth - birthmonth_txt.Text + 12 - 1

                Else : resultmonth_txt.Text = tomonth - birthmonth_txt.Text
                End If




                If (today > birthday_txt.Text) Then
                    resultday_txt.Text = today - birthday_txt.Text
                ElseIf (birthday_txt.Text > today) Then
                    resultday_txt.Text = today + DaysInMonth - birthday_txt.Text
                ElseIf (birthday_txt.Text = today) Then
                    resultday_txt.Text = today - birthday_txt.Text
                End If


                'ElseIf
            End If

        End If
    End Sub

    Private Sub resultyear_txt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles resultyear_txt.TextChanged

    End Sub

    Private Sub ppress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles birthday_txt.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MsgBox("This field accepts Only Numbers", vbInformation)


        ElseIf e.KeyChar = "." Then
            e.Handled = True
            MsgBox("Dot cannot be accepted", vbInformation)


        ElseIf e.KeyChar = "." AndAlso (DirectCast(sender, TextBox).TextLength = 0) Then ' OrElse Not Char.IsDigit(DirectCast(sender, TextBox).Text.Last()) AndAlso Not Char.IsLetter(DirectCast(sender, TextBox).Text.Last())) Then
            e.Handled = True
            MsgBox("Digit must come before dot")

        End If
    End Sub

    Private Sub ppress1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles birthmonth_txt.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MsgBox("This field accepts Only Numbers", vbInformation)

        ElseIf e.KeyChar = "." Then
            e.Handled = True
            MsgBox("Dot cannot be accepted", vbInformation)



        End If
    End Sub

    Private Sub ppress2(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles birthyear_txt.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MsgBox("This field accepts Only Numbers", vbInformation)


        ElseIf e.KeyChar = "." Then
            e.Handled = True
            MsgBox("Dot cannot be accepted", vbInformation)


        End If
    End Sub

    Private Sub clearageClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clearage.Click
        birthday_txt.Clear()
        birthmonth_txt.Clear()
        birthyear_txt.Clear()
        resultday_txt.Clear()
        resultmonth_txt.Clear()
        resultyear_txt.Clear()
    End Sub

    'boyles
    Private Sub Button10p1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10p1.Click
        Display1.Text = "CALCULATE INITIAL PRESSURE"
        showlbl11.Text = "P2"
        showlbl21.Text = "V2"
        showlbl31.Text = "V1"
        qslblp1.Text = "?"
        qslblP2.Text = ""
        qslblV2.Text = ""
        qslblV1.Text = ""
    End Sub

    Private Sub Button9v1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9v1.Click
        Display1.Text = "CALCULATE INITIAL VOLUME"
        showlbl11.Text = "P2"
        showlbl21.Text = "V2"
        showlbl31.Text = "P1"
        qslblV1.Text = "?"
        qslblP2.Text = ""
        qslblV2.Text = ""
        qslblp1.Text = ""
    End Sub

    Private Sub Button8p2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8p2.Click
        Display1.Text = "CALCULATE FINAL PRESSURE"
        showlbl11.Text = "P1"
        showlbl21.Text = "V1"
        showlbl31.Text = "V2"
        qslblP2.Text = "?"
        qslblV1.Text = ""
        qslblV2.Text = ""
        qslblp1.Text = ""
    End Sub

    Private Sub Button1v2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1v2.Click
        Display1.Text = "CALCULATE FINAL VOLUME"
        showlbl11.Text = "P1"
        showlbl21.Text = "P2"
        showlbl31.Text = "V1"
        qslblV2.Text = "?"
        qslblP2.Text = ""
        qslblV1.Text = ""
        qslblp1.Text = ""
    End Sub

    Private Sub clear_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clear_btn.Click
        Display1.Text = ""
        showlbl11.Text = ""
        showlbl21.Text = ""
        showlbl31.Text = ""
        qslblV1.Text = ""
        qslblP2.Text = ""
        qslblV2.Text = ""
        qslblp1.Text = ""
        InputC1_txt.Text = ""
        InputB1_txt.Text = ""
        InputA1_txt.Text = ""
        resultt_txt.Visible = True
        resultt_txt.Text = "RESULT"
    End Sub

    Private Sub Input_txt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles InputA1_txt.KeyPress, InputB1_txt.KeyPress, InputC1_txt.KeyPress
        ' Restrict input to numbers and a single decimal point
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) AndAlso (e.KeyChar <> "."c) Then
            e.Handled = True
            ShowError("Invalid input. Please enter a valid number.")
        End If

        ' Prevent input from starting with a decimal point
        If (e.KeyChar = "."c) AndAlso (DirectCast(sender, TextBox).Text.Length = 0) Then
            e.Handled = True
            ShowError("Input cannot start with a decimal point.")
        End If

        ' Allow only one decimal point
        If (e.KeyChar = "."c) AndAlso (DirectCast(sender, TextBox).Text.IndexOf("."c) > -1) Then
            e.Handled = True
            ShowError("Only one decimal point is allowed.")
        End If
    End Sub

    Private Sub ShowError(ByVal message As String)
        resultt_txt.Text = message
        resultt_txt.Visible = True
    End Sub

    Dim resulttt As Double

    Private Sub Calclbl_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Calclbl.Click
        Dim P1, P2, V1, V2 As Double

        Try
            ' Validate input fields
            If Not Double.TryParse(InputA1_txt.Text, P1) Then
                Throw New Exception("Input A must be a valid number")
            End If
            If Not Double.TryParse(InputB1_txt.Text, V1) Then
                Throw New Exception("Input B must be a valid number")
            End If
            If Not Double.TryParse(InputC1_txt.Text, V1) Then
                Throw New Exception("Input C must be a valid number")
            End If

            ' Perform calculations based on the selected case
            Select Case Display1.Text
                Case "CALCULATE INITIAL PRESSURE"
                    P2 = Double.Parse(InputA1_txt.Text)
                    V2 = Double.Parse(InputB1_txt.Text)
                    V1 = Double.Parse(InputC1_txt.Text)
                    resulttt = (P2 * V2) / V1
                Case "CALCULATE INITIAL VOLUME"
                    P2 = Double.Parse(InputA1_txt.Text)
                    V2 = Double.Parse(InputB1_txt.Text)
                    P1 = Double.Parse(InputC1_txt.Text)
                    resulttt = (P2 * V2) / P1
                Case "CALCULATE FINAL PRESSURE"
                    P1 = Double.Parse(InputA1_txt.Text)
                    V1 = Double.Parse(InputB1_txt.Text)
                    V2 = Double.Parse(InputC1_txt.Text)
                    resulttt = (P1 * V1) / V2
                Case "CALCULATE FINAL VOLUME"
                    P1 = Double.Parse(InputA1_txt.Text)
                    P2 = Double.Parse(InputB1_txt.Text)
                    V1 = Double.Parse(InputC1_txt.Text)
                    resulttt = (P1 * V1) / P2
                Case Else
                    Throw New Exception("Invalid calculation selected.")
            End Select

            boylesDisplay.Visible = True
            boylesDisplay.Text = "Result = " & resulttt.ToString("N2")

        Catch ex As Exception
            ShowError("Error: " & ex.Message)
        End Try
    End Sub



    Private CurrentVisiblePanel As Panel
    Private fadeOutPanel As Panel
    Private fadeInPanel As Panel
    Private fadeStep As Double = 1.5

    Private WithEvents Timer1 As New Timer

    Private Sub FadeTransition(ByVal outPanel As Panel, ByVal inPanel As Panel)
        fadeOutPanel = outPanel
        fadeInPanel = inPanel
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles Timer1.Tick
        If fadeOutPanel IsNot Nothing AndAlso fadeInPanel IsNot Nothing Then
            ' Fade out
            Dim outAlpha As Integer = fadeOutPanel.BackColor.A - CInt(fadeStep * 255)
            If outAlpha <= 0 Then
                fadeOutPanel.Hide()
                outAlpha = 0
            End If
            fadeOutPanel.BackColor = Color.FromArgb(outAlpha, fadeOutPanel.BackColor.R, fadeOutPanel.BackColor.G, fadeOutPanel.BackColor.B)

            ' Fade in
            Dim inAlpha As Integer = fadeInPanel.BackColor.A + CInt(fadeStep * 255)
            If inAlpha >= 255 Then
                inAlpha = 255
                Timer1.Stop()
            End If
            fadeInPanel.BackColor = Color.FromArgb(inAlpha, fadeInPanel.BackColor.R, fadeInPanel.BackColor.G, fadeInPanel.BackColor.B)
        End If
    End Sub


    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        FadeTransition(CurrentVisiblePanel, simple_calc_panel)
        CurrentVisiblePanel = simple_calc_panel
        unitConvert.Hide()
        simple_calc_panel.Show()
        land_panel.Hide()
        loan_panel.Hide()
        Boyles_label.Hide()
        GpCalc_panel.Hide()
        AgePanel.Hide()
        calcsc.Width = 0
    End Sub

    Private Sub Button6_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        FadeTransition(CurrentVisiblePanel, GpCalc_panel)
        CurrentVisiblePanel = GpCalc_panel
        unitConvert.Hide()
        simple_calc_panel.Hide()
        land_panel.Hide()
        loan_panel.Hide()
        Boyles_label.Hide()
        GpCalc_panel.Show()
        AgePanel.Hide()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        FadeTransition(CurrentVisiblePanel, AgePanel)
        CurrentVisiblePanel = AgePanel
        unitConvert.Hide()
        simple_calc_panel.Hide()
        land_panel.Hide()
        loan_panel.Hide()
        Boyles_label.Hide()
        GpCalc_panel.Hide()
        AgePanel.Show()
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        FadeTransition(CurrentVisiblePanel, unitConvert)
        CurrentVisiblePanel = unitConvert
        unitConvert.Show()
        simple_calc_panel.Hide()
        land_panel.Hide()
        loan_panel.Hide()
        Boyles_label.Hide()
        GpCalc_panel.Hide()
        AgePanel.Hide()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        FadeTransition(CurrentVisiblePanel, loan_panel)
        CurrentVisiblePanel = loan_panel
        unitConvert.Hide()
        simple_calc_panel.Hide()
        land_panel.Hide()
        loan_panel.Show()
        Boyles_label.Hide()
        GpCalc_panel.Hide()
        AgePanel.Hide()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        FadeTransition(CurrentVisiblePanel, Boyles_label)
        CurrentVisiblePanel = Boyles_label
        Boyles_label.Show()
        loan_panel.Hide()
        simple_calc_panel.Hide()
        land_panel.Hide()
        GpCalc_panel.Hide()
        AgePanel.Hide()
        unitConvert.Hide()
    End Sub

    Private first_no As Double
    Private secon_no As Double
    Private result As Double
    Private opr As String
    Private a As Double
    
    Private Sub scientific_btn_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles scientific_btn.Click
        calcsc.Width = 400
        goback_btn.Show()
        scientific_btn.Hide()
        displaycalc.Width = 340
    End Sub

    Private Sub goback_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles goback_btn.Click
        calcsc.Width = 0
        scientific_btn.Show()
        goback_btn.Hide()
        displaycalc.Width = 240

    End Sub
    '
    Private Sub Button22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button22.Click
        If displaycalc.Text.Length > 0 Then
            displaycalc.Text = displaycalc.Text.Remove(displaycalc.Text.Length - 1, 1)
            Label40.Text = ""
        End If
    End Sub

    Private Sub Button36_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button36.Click
        displaycalc.Clear()
        displaycalc.Text = "0"
        Label40.Text = ""
    End Sub

    ' Event handler for operators (+, -, *, /, Mod, Exp)
    Private Sub operators(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button34.Click, Button19.Click, Button23.Click, Button27.Click
        Dim ops As Button = sender
        first_no = Double.Parse(displaycalc.Text)
        Label40.Text = displaycalc.Text
        displaycalc.Text = ""
        opr = ops.Text
        Label40.Text &= " " & opr
    End Sub

    ' Event handler for equals button to perform calculations
    Private Sub Button28_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button28.Click
        Dim secon_no As Double = Double.Parse(displaycalc.Text)
        Label40.Text &= " " & secon_no

        Select Case opr
            Case "+"
                result = first_no + secon_no
            Case "-"
                result = first_no - secon_no
            Case "*"
                result = first_no * secon_no
            Case "/"
                If secon_no = 0 Then
                    displaycalc.Text = "Syntax error"
                    Exit Sub
                Else
                    result = first_no / secon_no
                End If
            Case "Mod"
                result = first_no Mod secon_no
            Case "Exp"
                result = first_no ^ secon_no
            Case Else
                displaycalc.Text = "Error"
                Exit Sub
        End Select

        displaycalc.Text = result.ToString()
        Label40.Text = ""
    End Sub


    Private Sub btn_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click, Button35.Click, Button16.Click, Button26.Click, Button24.Click, Button15.Click, Button12.Click, Button20.Click, Button13.Click, Button17.Click
        Dim b As Button = sender
        If displaycalc.Text = "0" Then
            displaycalc.Text = b.Text
        Else
            displaycalc.Text &= b.Text
        End If
    End Sub

    ' Event handler to add a decimal point
    Private Sub Button18_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button18.Click
        If Not displaycalc.Text.Contains(".") Then
            displaycalc.Text &= "."
        End If
    End Sub

    Private Sub Button30_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button30.Click
        displaycalc.Text = Math.Sin(Double.Parse(displaycalc.Text)).ToString()
        Label40.Text = ""
    End Sub

    Private Sub Button31_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button31.Click
        displaycalc.Text = Math.Log(Double.Parse(displaycalc.Text)).ToString()
        Label40.Text = ""
    End Sub

    Private Sub Button25_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button25.Click
        displaycalc.Text = Math.Cos(Double.Parse(displaycalc.Text)).ToString()
        Label40.Text = ""
    End Sub

    Private Sub Button29_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button29.Click
        displaycalc.Text = Math.Tan(Double.Parse(displaycalc.Text)).ToString()
        Label40.Text = ""
    End Sub

    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        displaycalc.Text = Math.Tanh(Double.Parse(displaycalc.Text)).ToString()
        Label40.Text = ""
    End Sub

    Private Sub Button21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button21.Click

    End Sub

    Private Sub Button32_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button32.Click

    End Sub

    Private Sub Button33_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button33.Click

    End Sub


    Private Sub mopress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles displaycalc.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not e.KeyChar = Chr(Keys.Delete) AndAlso Not e.KeyChar = Chr(Keys.Back) AndAlso Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("This field allows only numbers")
        End If
    End Sub

    ' 
    Private Sub InputB_txt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InputB_txt.TextChanged

    End Sub
End Class