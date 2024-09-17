Public Class Form1


    Private Sub close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles close.Click
        Dim response As Integer
        response = MessageBox.Show("Are you sure you want to exit ?", "Exit application",
                                   MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If response = vbYes Then
            Application.ExitThread()
        End If
    End Sub

    Private Sub Minimize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Minimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)
        age_calc_panel.Hide()
        loan_calc_panel.Hide()
        boyles_panel.Hide()
        gp_panel.Hide()
        unit_panel.Hide()
        sc_panel.Hide()
        land_panel.Show()




    End Sub
    Private Sub age_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        age_calc_panel.Show()
        loan_calc_panel.Hide()
        boyles_panel.Hide()
        gp_panel.Hide()
        unit_panel.Hide()
        sc_panel.Hide()
        land_panel.Hide()

    End Sub

    Private Sub loan_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        loan_calc_panel.Show()
        age_calc_panel.Hide()
        boyles_panel.Hide()
        gp_panel.Hide()
        unit_panel.Hide()
        sc_panel.Hide()
        land_panel.Hide()
    End Sub

    Private Sub boyle_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        boyles_panel.Show()
        loan_calc_panel.Hide()
        age_calc_panel.Hide()
        gp_panel.Hide()
        unit_panel.Hide()
        sc_panel.Hide()
        land_panel.Hide()
    End Sub

    Private Sub gp_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        gp_panel.Show()
        boyles_panel.Hide()
        loan_calc_panel.Hide()
        age_calc_panel.Hide()
        unit_panel.Hide()
        sc_panel.Hide()
        land_panel.Hide()
    End Sub

    Private Sub unit_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        unit_panel.Show()
        gp_panel.Hide()
        boyles_panel.Hide()
        loan_calc_panel.Hide()
        age_calc_panel.Hide()
        sc_panel.Hide()
        land_panel.Hide()
    End Sub

    Private Sub sc_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        sc_panel.Show()
        unit_panel.Hide()
        gp_panel.Hide()
        boyles_panel.Hide()
        loan_calc_panel.Hide()
        age_calc_panel.Hide()
        land_panel.Hide()
    End Sub
    '-----------------------------------------------------Boyles law------------------------------------------------------------
    Private Sub calc_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles calc_btn.Click
        Dim v1, v2, p1, p2, a, d, result As Double

        If ComboBox1.SelectedIndex = "4" Then
            v2_txt.Enabled = False
            v2_txt.Text = ""
            p1_txt.Enabled = True
            p2_txt.Enabled = True
            v1_txt.Enabled = True
            p1_txt.Text = ""
            p2_txt.Text = ""
            v1_txt.Text = ""
            MsgBox("Choose a field", vbInformation)

        ElseIf (p1_txt.Text = "") Or (p2_txt.Text = "") Or (v1_txt.Text = "") Or (v2_txt.Text = "") Then
            MsgBox("Field must not be empty,", vbInformation)

        ElseIf (p1_txt.Text = "") And (p2_txt.Text = "") And (v1_txt.Text = "") And (v2_txt.Text = "") Then
            MsgBox("Field cannot be empty", vbInformation)


        ElseIf (p1_txt.Enabled = False) Then

            p2 = p2_txt.Text
            v1 = v1_txt.Text
            v2 = v2_txt.Text

            a = p2 * v2
            p1 = a / v1
            result = p1

            result_txt.Text = result


        ElseIf (p2_txt.Enabled = False) Then
            p1 = p1_txt.Text
            v1 = v1_txt.Text
            v2 = v2_txt.Text

            d = p1 * v1
            p2 = d / v2
            result = p2

            result_txt.Text = result

        ElseIf (v1_txt.Enabled = False) Then
            p1 = p1_txt.Text
            p2 = p2_txt.Text
            v2 = v2_txt.Text


            a = p2 * v2
            v1 = a / p1
            result = v1
            result_txt.Text = result


        ElseIf (v2_txt.Enabled = False) Then
            p1 = p1_txt.Text
            p2 = p2_txt.Text
            v1 = v1_txt.Text

            d = p1 * v1
            v2 = d / p2
            result = v2
            result_txt.Text = result

            'security

            d()


        Else
            MsgBox("SELECT VALID FIELD!", vbInformation)

        End If



    End Sub



    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged

        If (ComboBox1.SelectedIndex = "0") Then
            p1_txt.Enabled = False
            p1_txt.Text = "?"
            p2_txt.Enabled = True
            v1_txt.Enabled = True
            v2_txt.Enabled = True
            p2_txt.Text = ""
            v1_txt.Text = ""
            v2_txt.Text = ""

        ElseIf ComboBox1.SelectedIndex = "1" Then
            p2_txt.Enabled = False
            p2_txt.Text = "?"
            p1_txt.Enabled = True
            v1_txt.Enabled = True
            v2_txt.Enabled = True
            p1_txt.Text = ""
            v1_txt.Text = ""
            v2_txt.Text = ""

        ElseIf ComboBox1.SelectedIndex = "2" Then
            v1_txt.Enabled = False
            v1_txt.Text = "?"
            p1_txt.Enabled = True
            p2_txt.Enabled = True
            v2_txt.Enabled = True
            p1_txt.Text = ""
            p2_txt.Text = ""
            v2_txt.Text = ""

        ElseIf ComboBox1.SelectedIndex = "3" Then
            v2_txt.Enabled = False
            v2_txt.Text = "?"
            p1_txt.Enabled = True
            p2_txt.Enabled = True
            v1_txt.Enabled = True
            p1_txt.Text = ""
            p2_txt.Text = ""
            v1_txt.Text = ""






            ' Else
            '    MsgBox("Field must Not be empty", vbInformation)

        End If



    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clear_btn.Click
        p1_txt.Text = ""
        p2_txt.Text = ""
        v1_txt.Text = ""
        v2_txt.Text = ""

        p1_txt.Enabled = True
        p2_txt.Enabled = True
        v1_txt.Enabled = True
        v2_txt.Enabled = True

        result_txt.Text = ""

        ComboBox1.SelectedIndex = "4"




    End Sub


    Private Sub beta(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)

    End Sub

    Private Sub p1_press(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles p1_txt.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MsgBox("This field accepts Only Numbers", vbInformation)
        End If

        If e.KeyChar = "." AndAlso p1_txt.Text.Contains(".") Then
            e.Handled = True
            MsgBox("cant accept multiple dots", vbInformation)

        ElseIf e.KeyChar = "." AndAlso (DirectCast(sender, TextBox).TextLength = 0) Then ' OrElse Not Char.IsDigit(DirectCast(sender, TextBox).Text.Last()) AndAlso Not Char.IsLetter(DirectCast(sender, TextBox).Text.Last())) Then
            e.Handled = True
            MsgBox("Digit must come before dot")

        ElseIf e.KeyChar = "." AndAlso (DirectCast(sender, TextBox).TextLength = 0) Then ' OrElse Not Char.IsDigit(DirectCast(sender, TextBox).Text.Last()) AndAlso Not Char.IsLetter(DirectCast(sender, TextBox).Text.Last())) Then
            e.Handled = True
            MsgBox("Digit must come before dot")

        End If
    End Sub

    Private Sub p2_press(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles p2_txt.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MsgBox("This field accepts Only Numbers", vbInformation)
        End If

        If e.KeyChar = "." AndAlso p2_txt.Text.Contains(".") Then
            e.Handled = True
            MsgBox("cant accept dots", vbInformation)

        ElseIf e.KeyChar = "." AndAlso (DirectCast(sender, TextBox).TextLength = 0) Then ' OrElse Not Char.IsDigit(DirectCast(sender, TextBox).Text.Last()) AndAlso Not Char.IsLetter(DirectCast(sender, TextBox).Text.Last())) Then
            e.Handled = True
            MsgBox("Digit must come before dot")

        ElseIf e.KeyChar = "." AndAlso (DirectCast(sender, TextBox).TextLength = 0) Then ' OrElse Not Char.IsDigit(DirectCast(sender, TextBox).Text.Last()) AndAlso Not Char.IsLetter(DirectCast(sender, TextBox).Text.Last())) Then
            e.Handled = True
            MsgBox("Digit must come before dot")
        End If
    End Sub

    Private Sub v1_press(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles v1_txt.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MsgBox("This field accepts Only Numbers", vbInformation)
        End If

        If e.KeyChar = "." AndAlso v1_txt.Text.Contains(".") Then
            e.Handled = True
            MsgBox("cant accept dot", vbInformation)

        ElseIf e.KeyChar = "." AndAlso (DirectCast(sender, TextBox).TextLength = 0) Then ' OrElse Not Char.IsDigit(DirectCast(sender, TextBox).Text.Last()) AndAlso Not Char.IsLetter(DirectCast(sender, TextBox).Text.Last())) Then
            e.Handled = True
            MsgBox("Digit must come before dot")

        ElseIf e.KeyChar = "." AndAlso (DirectCast(sender, TextBox).TextLength = 0) Then ' OrElse Not Char.IsDigit(DirectCast(sender, TextBox).Text.Last()) AndAlso Not Char.IsLetter(DirectCast(sender, TextBox).Text.Last())) Then
            e.Handled = True
            MsgBox("Digit must come before dot")
        End If
    End Sub

    Private Sub v2_press(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles v2_txt.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MsgBox("This field accepts Only Numbers", vbInformation)
        End If

        If e.KeyChar = "." AndAlso v2_txt.Text.Contains(".") Then
            e.Handled = True
            MsgBox("cant accept dot", vbInformation)

        ElseIf e.KeyChar = "." AndAlso (DirectCast(sender, TextBox).TextLength = 0) Then ' OrElse Not Char.IsDigit(DirectCast(sender, TextBox).Text.Last()) AndAlso Not Char.IsLetter(DirectCast(sender, TextBox).Text.Last())) Then
            e.Handled = True
            MsgBox("Digit must come before dot")

        ElseIf e.KeyChar = "." AndAlso (DirectCast(sender, TextBox).TextLength = 0) Then ' OrElse Not Char.IsDigit(DirectCast(sender, TextBox).Text.Last()) AndAlso Not Char.IsLetter(DirectCast(sender, TextBox).Text.Last())) Then
            e.Handled = True
            MsgBox("Digit must come before dot")
        End If
    End Sub

    Private Sub result_txt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles result_txt.TextChanged
        If result_txt.Text = "NaN" Then
            result_txt.Text = ""
            MsgBox("Invalid Operation!")


        End If
    End Sub

    Private Sub combo_press(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ComboBox1.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MsgBox("This field does not accept value", vbInformation)
        ElseIf Char.IsNumber(e.KeyChar) Then
            e.Handled = True
            MsgBox("This field does not accept value", vbInformation)
        ElseIf e.KeyChar = "." Then
            e.Handled = True
            MsgBox("This field does not accept value", vbInformation)
        End If
    End Sub
    '---------------------------------------------------End of Boyles law-------------------------------------------------------------------

    '---------------------------------------------------Beginning of Loan App---------------------------------------------------------------

    Private Sub solve_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles solve_btn.Click
        'If amount_txt.Text = "" Or duration_txt.Text = " " Or customer_txt.Text = "" Or name_txt.Text = "" Then
        ' MsgBox("Enter the empty field", vbInformation)s

        If (takein1_txt.Text = "") Or (takein2_txt.Text = "") Then
            MsgBox("Field must not be empty,", vbInformation)

        ElseIf (takein1_txt.Text = 0) Or (takein2_txt.Text = 0) Then 'And (rparesult_txt.Text = "0") Then
            rparesult_txt.Text = ""
            MsgBox("Invalid Operation!!")

        Else
            Dim loan, RPA, interest, rate, amount As Double
            Dim duration As Integer
            Dim i As Double
            Dim total_repayment As Double
            loan = takein1_txt.Text
            duration = takein2_txt.Text

            amount = loan / duration




            For i = 1 To duration

                rate = 0.015
                interest = loan * rate
                RPA = interest + amount
                loan = loan - amount

                total_repayment = total_repayment + RPA


                ListBox2.Items.Add("            " & i & "                " & amount & "                       " & interest & "                   " & RPA)

            Next
            rparesult_txt.Text = total_repayment

        End If

    End Sub
    Private Sub wipe_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles wipe_btn.Click
        ListBox2.Items.Clear()
        takein1_txt.Text = ""
        takein2_txt.Text = ""
        rparesult_txt.Text = ""

    End Sub


    Private Sub presskey1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles takein1_txt.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MsgBox("This field accepts Only Numbers", vbInformation)
        End If

        If e.KeyChar = "." AndAlso takein1_txt.Text.Contains(".") Then
            e.Handled = True
            MsgBox("cant accept multiple dots", vbInformation)

        ElseIf e.KeyChar = "." AndAlso (DirectCast(sender, TextBox).TextLength = 0) Then ' OrElse Not Char.IsDigit(DirectCast(sender, TextBox).Text.Last()) AndAlso Not Char.IsLetter(DirectCast(sender, TextBox).Text.Last())) Then
            e.Handled = True
            MsgBox("Digit must come before dot")

        ElseIf e.KeyChar = "." AndAlso (DirectCast(sender, TextBox).TextLength = 0) Then ' OrElse Not Char.IsDigit(DirectCast(sender, TextBox).Text.Last()) AndAlso Not Char.IsLetter(DirectCast(sender, TextBox).Text.Last())) Then
            e.Handled = True
            MsgBox("Digit must come before dot")

        End If
    End Sub

    Private Sub Presskey2(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles takein2_txt.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MsgBox("This field accepts Only Numbers", vbInformation)
        End If

        If e.KeyChar = "." AndAlso takein2_txt.Text.Contains(".") Then
            e.Handled = True
            MsgBox("cant accept multiple dots", vbInformation)

        ElseIf e.KeyChar = "." AndAlso (DirectCast(sender, TextBox).TextLength = 0) Then ' OrElse Not Char.IsDigit(DirectCast(sender, TextBox).Text.Last()) AndAlso Not Char.IsLetter(DirectCast(sender, TextBox).Text.Last())) Then
            e.Handled = True
            MsgBox("Digit must come before dot")

        ElseIf e.KeyChar = "." AndAlso (DirectCast(sender, TextBox).TextLength = 0) Then ' OrElse Not Char.IsDigit(DirectCast(sender, TextBox).Text.Last()) AndAlso Not Char.IsLetter(DirectCast(sender, TextBox).Text.Last())) Then
            e.Handled = True
            MsgBox("Digit must come before dot")

        End If
    End Sub
    ' ------------------------------------------------------------End of loan app-----------------------------------------------------------------

    ' ------------------------------------------------------------Beginning of GPCalc-----------------------------------------------------------------
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

    End Sub


    Private Sub clear_txt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clear_txt.Click

    End Sub



    Private Sub press1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles sdt101_txt.KeyPress

    End Sub

    Private Sub press2(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles mad102_txt.KeyPress

    End Sub

    Private Sub press3(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles sd103_txt.KeyPress

    End Sub

    Private Sub press4(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles wad104_txt.KeyPress

    End Sub

    Private Sub press5(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ns105_txt.KeyPress

    End Sub

    Private Sub press6(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles gdt106_txt.KeyPress

    End Sub

    '----------------------------------------------------The End of Gp==============================================================

    '=====================================================The Beginning of Converter ------------------------------------------------


    Dim op As String
    Private Sub convert_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles convert_btn.Click
        Dim celsius, fahrenheit As Double
        Dim kilo, liter, mililiter, gram As Double
        Dim kilometer, meter As Double


        If (input_txt.Text = "") Then
            MsgBox("Field must not empty", vbInformation)

        Else


            Select Case (op)
                Case "KM"
                    'kilometer to meter
                    kilometer = Double.Parse(input_txt.Text)
                    show_txt.Text = ((1000 * kilometer).ToString())

                Case "MK"
                    'meter to kilometer
                    meter = Double.Parse(input_txt.Text)
                    show_txt.Text = ((meter / 1000).ToString())

                Case "KG"
                    'kilogram to gram
                    kilo = Double.Parse(input_txt.Text)
                    show_txt.Text = ((1000 * kilo).ToString())

                Case "GK"
                    'gram to kilogram
                    gram = Double.Parse(input_txt.Text)
                    show_txt.Text = ((gram / 1000).ToString())

                Case "LM"
                    'liter to mililiter
                    liter = Double.Parse(input_txt.Text)
                    show_txt.Text = ((1000 * liter).ToString())

                Case "ML"
                    'mililiter to liter
                    mililiter = Double.Parse(input_txt.Text)
                    show_txt.Text = ((mililiter / 1000).ToString())

                Case "CF"
                    'celsius to fahrenheit
                    celsius = Double.Parse(input_txt.Text)
                    show_txt.Text = ((((9 * celsius) / 5) + 32).ToString())

                Case "FC"
                    'fahrenheit celsius
                    fahrenheit = Double.Parse(input_txt.Text)
                    show_txt.Text = ((((fahrenheit - 32) * 5) / 9).ToString())

            End Select

        End If

    End Sub

    Private Sub ce_to_fa_btn_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ce_to_fa_btn.CheckedChanged
        op = "CF"
    End Sub

    Private Sub fa_to_ce_btn_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fa_to_ce_btn.CheckedChanged
        op = "FC"
    End Sub

    Private Sub ki_to_gram_btn_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ki_to_gram_btn.CheckedChanged
        op = "KG"
    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter
        op = "GK"
    End Sub

    Private Sub li_to_mil_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles li_to_mil.CheckedChanged
        op = "LM"
    End Sub

    Private Sub mil_to_lit_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mil_to_lit.CheckedChanged
        op = "ML"
    End Sub

    Private Sub kil_to_met_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles kil_to_met.CheckedChanged
        op = "KM"
    End Sub

    Private Sub met_to_kil_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles met_to_kil.CheckedChanged
        op = "MK"
    End Sub

    Private Sub reset_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles reset_btn.Click

        input_txt.Clear()
        show_txt.Text = ""
        ki_to_gram_btn.Checked = False
        gr_to_ki_btn.Checked = False
        fa_to_ce_btn.Checked = False
        ce_to_fa_btn.Checked = False
        kil_to_met.Checked = False
        met_to_kil.Checked = False
        li_to_mil.Checked = False
        mil_to_lit.Checked = False



    End Sub

    Private Sub press(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles input_txt.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MsgBox("This field accepts Only Numbers", vbInformation)
        End If

        If e.KeyChar = "." AndAlso input_txt.Text.Contains(".") Then
            e.Handled = True
            MsgBox("cant accept multiple dots", vbInformation)

        ElseIf e.KeyChar = "." AndAlso (DirectCast(sender, TextBox).TextLength = 0) Then ' OrElse Not Char.IsDigit(DirectCast(sender, TextBox).Text.Last()) AndAlso Not Char.IsLetter(DirectCast(sender, TextBox).Text.Last())) Then
            e.Handled = True
            MsgBox("Digit must come before dot")

        End If
    End Sub
    '=================================================The end of converter________________________________________________
    '=================================================The beginning of age________________________________________________

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click

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

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        birthday_txt.Clear()
        birthmonth_txt.Clear()
        birthyear_txt.Clear()
        resultday_txt.Clear()
        resultmonth_txt.Clear()
        resultyear_txt.Clear()
    End Sub

    '------------------------------------------------SCientiFic CalcULator-----------------------------------

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles goback_btn.Click
        calc_panel.Width = 265
        scientific_btn.Show()
        goback_btn.Hide()
        TextBox1.Width = 240

    End Sub


    Private Sub scientific_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles scientific_btn.Click
        calc_panel.Width = 400
        goback_btn.Show()
        scientific_btn.Hide()
        TextBox1.Width = 340

    End Sub

    Private Sub btn_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click, Button7.Click, Button26.Click, Button24.Click, Button20.Click, Button16.Click, Button15.Click, Button13.Click, Button10.Click, Button5.Click
        'for 0-9 Numbers'
        Dim b As Button = sender
        If (TextBox1.Text = "0") Then
            TextBox1.Text = b.Text
        Else
            TextBox1.Text += b.Text
        End If
    End Sub


    Private Sub operators(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button27.Click, Button23.Click, Button19.Click, Button17.Click
        '+, -, *, / '
        Dim ops As Button = sender
        first_no = TextBox1.Text
        Label40.Text = TextBox1.Text
        TextBox1.Text = ""
        opr = ops.Text
        Label40.Text = Label40.Text + "" + opr
    End Sub

    Private Sub Button18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button18.Click
        '.'
        If InStr(TextBox1.Text, ".") = 0 Then
            TextBox1.Text = TextBox1.Text + "."
        End If
    End Sub

    Private Sub Button28_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button28.Click
        secon_no = TextBox1.Text
        Label40.Text = TextBox1.Text
        TextBox1.Text = ""
        Label40.Text = Label40.Text + "" + opr + "" + Label40.Text

        If opr = "+" Then
            result = first_no + secon_no
            TextBox1.Text = result

        ElseIf opr = "-" Then
            result = first_no - secon_no
            TextBox1.Text = result
        ElseIf opr = "*" Then
            result = first_no * secon_no
            TextBox1.Text = result
        ElseIf opr = "/" Then
            If secon_no = 0 Then
                TextBox1.Text = "synax error"
            Else
                result = first_no / secon_no
                TextBox1.Text = result
            End If
        ElseIf opr = "Mod" Then
            result = first_no Mod secon_no
            TextBox1.Text = result

        ElseIf opr = "Exp" Then
            result = first_no ^ secon_no
            TextBox1.Text = result
        End If
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        If TextBox1.Text.Length > 0 Then
            TextBox1.Text = TextBox1.Text.Remove(TextBox1.Text.Length - 1, 1)
            Label40.Text = ""
        End If
    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        'clear'
        TextBox1.Clear()
        TextBox1.Text = "0"
        Label40.Text = ""
    End Sub

    Private Sub Button30_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button30.Click
        a = Math.Sin(TextBox1.Text)
        TextBox1.Text = a
        Label40.Text = ""
    End Sub

    Private Sub Button31_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button31.Click
        a = Math.Log(TextBox1.Text)
        TextBox1.Text = a
        Label40.Text = ""
    End Sub

    Private Sub Button25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button25.Click
        a = Math.Cos(TextBox1.Text)
        TextBox1.Text = a
        Label40.Text = ""
    End Sub

    Private Sub Button29_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button29.Click
        a = Math.Tan(TextBox1.Text)
        TextBox1.Text = a
        Label40.Text = ""
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        a = Math.Tan(TextBox1.Text)
        TextBox1.Text = a
        Label40.Text = ""
    End Sub

    Private Sub mopress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("This field allows only numbers")

        End If
    End Sub

    Private Sub unit_panel_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles unit_panel.Paint

    End Sub



    '------------------------------------------------SCientiFic CalcULator-----------------------------------

    Private Sub Button34_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button34.Click
        sc_panel.Show()
        unit_panel.Hide()
        gp_panel.Hide()
        boyles_panel.Hide()
        loan_calc_panel.Hide()
        age_calc_panel.Hide()
        land_panel.Hide()
    End Sub

    Private Sub Button35_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button35.Click
        sc_panel.Hide()
        unit_panel.Hide()
        gp_panel.Hide()
        boyles_panel.Hide()
        loan_calc_panel.Hide()
        age_calc_panel.Show()
        land_panel.Hide()
    End Sub

    Private Sub Button22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button22.Click
        sc_panel.Hide()
        unit_panel.Hide()
        gp_panel.Hide()
        boyles_panel.Hide()
        loan_calc_panel.Show()
        age_calc_panel.Hide()
        land_panel.Hide()
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        sc_panel.Hide()
        unit_panel.Hide()
        gp_panel.Show()
        boyles_panel.Hide()
        loan_calc_panel.Hide()
        age_calc_panel.Hide()
        land_panel.Hide()
    End Sub

    Private Sub Button1_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        sc_panel.Hide()
        unit_panel.Show()
        gp_panel.Hide()
        boyles_panel.Hide()
        loan_calc_panel.Hide()
        age_calc_panel.Hide()
        land_panel.Hide()
    End Sub

    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        sc_panel.Hide()
        unit_panel.Hide()
        gp_panel.Hide()
        boyles_panel.Show()
        loan_calc_panel.Hide()
        age_calc_panel.Hide()
        land_panel.Hide()
    End Sub


    Private Sub home_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles homePAGE_btn.Click
        sc_panel.Hide()
        unit_panel.Hide()
        gp_panel.Hide()
        boyles_panel.Hide()
        loan_calc_panel.Hide()
        age_calc_panel.Hide()
        land_panel.Show()

    End Sub



    Private Sub loan_btn_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles loan_btn.Click

    End Sub

    Private Sub unit_btn_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles unit_btn.Click

    End Sub

    Private Sub age_btn_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles age_btn.Click

    End Sub

    Private Sub gp_btn_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gp_btn.Click

    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

    End Sub
End Class
