Module functions
    Function get_loop(ByVal inputNumber As Integer) As Tuple(Of Integer, Boolean, Integer, Integer())
        Dim total As Integer
        Dim loopCount As Integer
        Dim success As Boolean
        Dim totalList As New List(Of Integer)

        For i As Integer = 1 To 12
            total += inputNumber
            loopCount += 1
            totalList.Add(total)

            If total <= 100 Then
                success = True

            Else
                total -= inputNumber
                loopCount -= 1
                totalList.RemoveAt(totalList.Count - 1)
                success = False
                Exit For
            End If

        Next
        Return Tuple.Create(total, success, loopCount, totalList.ToArray())

    End Function
End Module
