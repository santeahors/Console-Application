Public Class AgeCalculator

    Private Sub clear_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clear_btn.Click
        ClearFields()
    End Sub

    Private Sub Input_txt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dBirth_txt.KeyPress, mBirth_txt.KeyPress, yBirth_txt.KeyPress
        ValidateInput(e)
    End Sub

    Private Sub Calc_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Calc_btn.Click
        Try
            Dim BirthDay, BirthMonth, BirthYear As Integer
            If Not ValidateBirthDate(BirthDay, BirthMonth, BirthYear) Then Exit Sub

            Dim ageYears As Integer = CalculateYears(BirthYear, BirthMonth, BirthDay)
            Dim ageMonths As Integer = CalculateMonths(BirthYear, BirthMonth, BirthDay, ageYears)
            Dim ageDays As Integer = CalculateDays(BirthYear, BirthMonth, BirthDay, ageYears, ageMonths)

            DisplayResults(ageYears, ageMonths, ageDays, BirthYear, BirthMonth, BirthDay)
        Catch ex As Exception
            ShowError("Please ensure all inputs are valid numbers.")
        End Try
    End Sub

    Private Sub ClearFields()
        Age_txt.Text = ""
        dBirth_txt.Text = ""
        yBirth_txt.Text = ""
        mBirth_txt.Text = ""

        mBirth_txt.Enabled = True
        yBirth_txt.Enabled = True
    End Sub

    Private Sub ValidateInput(ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
            ShowError("Invalid input. Please enter a valid number.")
        End If
    End Sub

    Private Function ValidateBirthDate(ByRef BirthDay As Integer, ByRef BirthMonth As Integer, ByRef BirthYear As Integer) As Boolean
        If Not Integer.TryParse(dBirth_txt.Text, BirthDay) OrElse BirthDay < 1 OrElse BirthDay > 31 Then
            ShowError("Invalid Day")
            Return False
        End If

        If Not Integer.TryParse(mBirth_txt.Text, BirthMonth) OrElse BirthMonth < 1 OrElse BirthMonth > 12 Then
            ShowError("Invalid Month")
            Return False
        End If

        If Not Integer.TryParse(yBirth_txt.Text, BirthYear) OrElse BirthYear < 1 Then
            ShowError("Invalid Year")
            Return False
        End If

        Dim DaysInMonth As Integer = DateTime.DaysInMonth(BirthYear, BirthMonth)
        If BirthDay > DaysInMonth Then
            ShowError("Invalid Day for the selected month.")
            Return False
        End If

        If New DateTime(BirthYear, BirthMonth, BirthDay) > DateTime.Now Then
            ShowError("Birthdate cannot be in the future.")
            Return False
        End If

        Return True
    End Function

    Private Function CalculateYears(ByVal BirthYear As Integer, ByVal BirthMonth As Integer, ByVal BirthDay As Integer) As Integer
        Dim currentDate As DateTime = DateTime.Now
        Dim ageYears As Integer = currentDate.Year - BirthYear

        If currentDate.Month < BirthMonth OrElse (currentDate.Month = BirthMonth AndAlso currentDate.Day < BirthDay) Then
            ageYears -= 1
        End If

        Return ageYears
    End Function

    Private Function CalculateMonths(ByVal BirthYear As Integer, ByVal BirthMonth As Integer, ByVal BirthDay As Integer, ByVal ageYears As Integer) As Integer
        Dim currentDate As DateTime = DateTime.Now
        Dim previousBirthday As DateTime = New DateTime(currentDate.Year, BirthMonth, BirthDay).AddYears(ageYears)

        Dim ageMonths As Integer = currentDate.Month - previousBirthday.Month

        If currentDate.Day < BirthDay Then
            ageMonths -= 1
        End If

        If ageMonths < 0 Then
            ageMonths += 12
        End If

        Return ageMonths
    End Function

    Private Function CalculateDays(ByVal BirthYear As Integer, ByVal BirthMonth As Integer, ByVal BirthDay As Integer, ByVal ageYears As Integer, ByVal ageMonths As Integer) As Integer
        Dim currentDate As DateTime = DateTime.Now
        Dim lastBirthday As DateTime = New DateTime(currentDate.Year, BirthMonth, BirthDay).AddYears(ageYears).AddMonths(ageMonths)

        Dim daysInCurrentMonth As Integer = DateTime.DaysInMonth(currentDate.Year, currentDate.Month)
        Dim daysRemainingInMonth As Integer = daysInCurrentMonth - currentDate.Day

        If BirthDay > currentDate.Day Then
            Dim lastBirthdayEndOfMonth As DateTime = New DateTime(currentDate.Year, currentDate.Month, BirthDay).AddMonths(-1)
            Dim daysPassedSinceLastBirthday As Integer = (currentDate - lastBirthdayEndOfMonth).Days
            Return daysInCurrentMonth - daysPassedSinceLastBirthday
        End If

        Return daysRemainingInMonth
    End Function

    Private Sub DisplayResults(ByVal ageYears As Integer, ByVal ageMonths As Integer, ByVal ageDays As Integer, ByVal BirthYear As Integer, ByVal BirthMonth As Integer, ByVal BirthDay As Integer)
        Dim currentDate As DateTime = DateTime.Now
        Dim birthDate As New DateTime(BirthYear, BirthMonth, BirthDay)
        Dim ageWeeks As Integer = (currentDate - birthDate).Days \ 7
        Dim ageMinutes As Integer = CInt((currentDate - birthDate).TotalMinutes)
        Dim ageSeconds As Integer = CInt((currentDate - birthDate).TotalSeconds)

        Age_txt.Text = "Your age is " & ageYears & " year(s), " & ageMonths & " month(s), and " & ageDays & " day(s)."
    End Sub

    Private Sub ShowError(ByVal message As String)
        Age_txt.Text = message
        Age_txt.Visible = True
    End Sub

End Class
