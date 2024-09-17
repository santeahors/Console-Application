Imports System.Math

Public Class ScientificCalculator
    Private currentOperation As String = ""
    Private operand1 As Double = 0
    Private isOperationPending As Boolean = False

    Private Sub Display_Txt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtDisplay.TextChanged
    End Sub

    Private Sub btnClearbynumber_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClearbynumber.Click
        TxtDisplay.Text = ""
        operand1 = 0
        currentOperation = ""
        isOperationPending = False
    End Sub

    Private Sub BtnSec_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSec.Click
        Try
            TxtDisplay.Text = (1 / Cos(Val(TxtDisplay.Text))).ToString()
        Catch ex As Exception
            TxtDisplay.Text = "Error"
        End Try
    End Sub

    Private Sub BtnCosec_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCosec.Click
        Try
            TxtDisplay.Text = (1 / Sin(Val(TxtDisplay.Text))).ToString()
        Catch ex As Exception
            TxtDisplay.Text = "Error"
        End Try
    End Sub

    Private Sub Btncot_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btncot.Click
        Try
            TxtDisplay.Text = (1 / Tan(Val(TxtDisplay.Text))).ToString()
        Catch ex As Exception
            TxtDisplay.Text = "Error"
        End Try
    End Sub

    Private Sub Factorial_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Factorial.Click
        Try
            Dim number As Integer = Convert.ToInt32(Val(TxtDisplay.Text))
            If number < 0 Then Throw New ArgumentException("Negative numbers are not allowed.")
            TxtDisplay.Text = CalculateFactorial(number).ToString()
        Catch ex As Exception
            TxtDisplay.Text = "Error"
        End Try
    End Sub

    Private Sub BtnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClear.Click
        TxtDisplay.Text = ""
        operand1 = 0
        currentOperation = ""
        isOperationPending = False
    End Sub

    Private Sub BtnSin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSin.Click
        Try
            TxtDisplay.Text = Sin(Val(TxtDisplay.Text)).ToString()
        Catch ex As Exception
            TxtDisplay.Text = "Error"
        End Try
    End Sub

    Private Sub BtnCos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCos.Click
        Try
            TxtDisplay.Text = Cos(Val(TxtDisplay.Text)).ToString()
        Catch ex As Exception
            TxtDisplay.Text = "Error"
        End Try
    End Sub

    Private Sub BtnTan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnTan.Click
        Try
            TxtDisplay.Text = Tan(Val(TxtDisplay.Text)).ToString()
        Catch ex As Exception
            TxtDisplay.Text = "Error"
        End Try
    End Sub

    Private Sub btnDivide_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDivide.Click
        SetOperation("/")
    End Sub

    Private Sub BtnMultiply_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnMultiply.Click
        SetOperation("*")
    End Sub

    Private Sub BtnSubtraction_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSubtraction.Click
        SetOperation("-")
    End Sub

    Private Sub BtnAddition_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAddition.Click
        SetOperation("+")
    End Sub

    Private Sub BtnNumber9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNumber9.Click
        AppendNumber("9")
    End Sub

    Private Sub BtnNumber6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNumber6.Click
        AppendNumber("6")
    End Sub

    Private Sub BtnNumber3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNumber3.Click
        AppendNumber("3")
    End Sub

    Private Sub BtnPoint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPoint.Click
        If Not TxtDisplay.Text.Contains(".") Then
            TxtDisplay.Text &= "."
        End If
    End Sub

    Private Sub BtnNumber8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNumber8.Click
        AppendNumber("8")
    End Sub

    Private Sub BtnNumber5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNumber5.Click
        AppendNumber("5")
    End Sub

    Private Sub BtnNumber2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNumber2.Click
        AppendNumber("2")
    End Sub

    Private Sub BtnNumber0_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNumber0.Click
        AppendNumber("0")
    End Sub

    Private Sub BtnNumber7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNumber7.Click
        AppendNumber("7")
    End Sub

    Private Sub BtnNumber4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNumber4.Click
        AppendNumber("4")
    End Sub

    Private Sub BtnNumber1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNumber1.Click
        AppendNumber("1")
    End Sub

    Private Sub BtnPlus_or_minus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPlus_or_minus.Click
        TxtDisplay.Text = (-Val(TxtDisplay.Text)).ToString()
    End Sub

    Private Sub BtnLog_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnLog.Click
        Try
            TxtDisplay.Text = Log(Val(TxtDisplay.Text)).ToString()
        Catch ex As Exception
            TxtDisplay.Text = "Error"
        End Try
    End Sub

    Private Sub BtnLn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnLn.Click
        Try
            TxtDisplay.Text = Log(Val(TxtDisplay.Text)).ToString()
        Catch ex As Exception
            TxtDisplay.Text = "Error"
        End Try
    End Sub

    Private Sub BtnPercentage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPercentage.Click
        Try
            TxtDisplay.Text = (Val(TxtDisplay.Text) / 100).ToString()
        Catch ex As Exception
            TxtDisplay.Text = "Error"
        End Try
    End Sub

    Private Sub BtnExponetial_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExponetial.Click
        Try
            TxtDisplay.Text = Exp(Val(TxtDisplay.Text)).ToString()
        Catch ex As Exception
            TxtDisplay.Text = "Error"
        End Try
    End Sub

    Private Sub BtnSQRT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSQRT.Click
        Try
            TxtDisplay.Text = Sqrt(Val(TxtDisplay.Text)).ToString()
        Catch ex As Exception
            TxtDisplay.Text = "Error"
        End Try
    End Sub

    Private Sub BtnDEC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDEC.Click
    End Sub

    Private Sub BtnBin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBin.Click
        Try
            Dim number As Integer = Convert.ToInt32(TxtDisplay.Text, 10)
            TxtDisplay.Text = Convert.ToString(number, 2)
        Catch ex As Exception
            TxtDisplay.Text = "Error"
        End Try
    End Sub

    Private Sub BtnHEx_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnHEx.Click
        Try
            Dim number As Integer = Convert.ToInt32(TxtDisplay.Text, 10)
            TxtDisplay.Text = Convert.ToString(number, 16).ToUpper()
        Catch ex As Exception
            TxtDisplay.Text = "Error"
        End Try
    End Sub

    Private Sub BtnOct_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnOct.Click
        Try
            Dim number As Integer = Convert.ToInt32(TxtDisplay.Text, 10)
            TxtDisplay.Text = Convert.ToString(number, 8)
        Catch ex As Exception
            TxtDisplay.Text = "Error"
        End Try
    End Sub

    Private Sub BtnPi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPi.Click
        TxtDisplay.Text = PI.ToString()
    End Sub

    Private Sub AppendNumber(ByVal number As String)
        If isOperationPending Then
            TxtDisplay.Text = number
            isOperationPending = False
        Else
            TxtDisplay.Text &= number
        End If
    End Sub

    Private Sub SetOperation(ByVal op As String)
        If Not isOperationPending AndAlso Not String.IsNullOrEmpty(TxtDisplay.Text) Then
            Try
                operand1 = Val(TxtDisplay.Text)

                currentOperation = op

                TxtDisplay.Text = currentOperation
                isOperationPending = True
            Catch ex As Exception
                TxtDisplay.Text = "Error"
            End Try
        End If
    End Sub

    Private Sub BtnEquals_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEquals.Click
        Try
            Dim operand2 As Double = Val(TxtDisplay.Text)
            Dim result As Double

            Select Case currentOperation
                Case "+"
                    result = operand1 + operand2
                Case "-"
                    result = operand1 - operand2
                Case "*"
                    result = operand1 * operand2
                Case "/"
                    If operand2 = 0 Then Throw New DivideByZeroException()
                    result = operand1 / operand2
                Case Else
                    Throw New InvalidOperationException()
            End Select

            TxtDisplay.Text = result.ToString()
            currentOperation = ""
            isOperationPending = False
        Catch ex As Exception
            TxtDisplay.Text = "Error"
        End Try
    End Sub

    Private Function CalculateFactorial(ByVal number As Integer) As Integer
        If number <= 1 Then
            Return 1
        End If
        Return number * CalculateFactorial(number - 1)
    End Function
End Class