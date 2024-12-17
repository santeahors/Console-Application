Public Class BoylesCalc

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Display.Text = "CALCULATE INITIAL PRESSURE"
        showlbl1.Text = "P2"
        showlbl2.Text = "V2"
        showLbl3.Text = "V1"
        qslblp1.Text = "?"
        qslblP2.Text = ""
        qslblV2.Text = ""
        qslblV1.Text = ""
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Display.Text = "CALCULATE INITIAL VOLUME"
        showlbl1.Text = "P2"
        showlbl2.Text = "V2"
        showLbl3.Text = "P1"
        qslblV1.Text = "?"
        qslblP2.Text = ""
        qslblV2.Text = ""
        qslblp1.Text = ""
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Display.Text = "CALCULATE FINAL PRESSURE"
        showlbl1.Text = "P1"
        showlbl2.Text = "V1"
        showLbl3.Text = "V2"
        qslblP2.Text = "?"
        qslblV1.Text = ""
        qslblV2.Text = ""
        qslblp1.Text = ""
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Display.Text = "CALCULATE FINAL VOLUME"
        showlbl1.Text = "P1"
        showlbl2.Text = "P2"
        showLbl3.Text = "V1"
        qslblV2.Text = "?"
        qslblP2.Text = ""
        qslblV1.Text = ""
        qslblp1.Text = ""
    End Sub

    Private Sub clear_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clear_btn.Click
        Display.Text = ""
        showlbl1.Text = ""
        showlbl2.Text = ""
        showLbl3.Text = ""
        qslblV1.Text = ""
        qslblP2.Text = ""
        qslblV2.Text = ""
        qslblp1.Text = ""
        InputC_txt.Text = ""
        InputB_txt.Text = ""
        InputA_txt.Text = ""
        Resultt_txt.Visible = False
        Resultt_txt.Text = "RESULT"
    End Sub

    Private Sub Input_txt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles InputA_txt.KeyPress, InputB_txt.KeyPress, InputC_txt.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) AndAlso (e.KeyChar <> "."c) Then
            e.Handled = True
            ShowError("Invalid input. Please enter a valid number.")
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

    Private Sub ShowError(ByVal message As String)
        Resultt_txt.Text = message
        Resultt_txt.Visible = True
    End Sub

    Dim result As Double

    Private Sub Calclbl_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Calclbl.Click
        Dim P1, P2, V1, V2 As Double

        Try
            Select Case Display.Text
                Case "CALCULATE INITIAL PRESSURE"
                    P2 = Double.Parse(InputA_txt.Text)
                    V2 = Double.Parse(InputB_txt.Text)
                    V1 = Double.Parse(InputC_txt.Text)
                    result = (P2 * V2) / V1
                Case "CALCULATE INITIAL VOLUME"
                    P2 = Double.Parse(InputA_txt.Text)
                    V2 = Double.Parse(InputB_txt.Text)
                    P1 = Double.Parse(InputC_txt.Text)
                    result = (P2 * V2) / P1
                Case "CALCULATE FINAL PRESSURE"
                    P1 = Double.Parse(InputA_txt.Text)
                    V1 = Double.Parse(InputB_txt.Text)
                    V2 = Double.Parse(InputC_txt.Text)
                    result = (P1 * V1) / V2
                Case "CALCULATE FINAL VOLUME"
                    P1 = Double.Parse(InputA_txt.Text)
                    P2 = Double.Parse(InputB_txt.Text)
                    V1 = Double.Parse(InputC_txt.Text)
                    result = (P1 * V1) / P2
            End Select

            Resultt_txt.Visible = True
            Resultt_txt.Text = "Result = " & result.ToString("N2")
        Catch ex As Exception
            ShowError("Please ensure all inputs are valid numbers.")
        End Try

    End Sub

End Class

