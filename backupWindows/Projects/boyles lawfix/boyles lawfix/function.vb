Module functions

    Function GetDoubleInput(ByVal prompt As String) As Double
        Dim input As String
        Dim result As Double
        Console.Write(prompt)
        input = Console.ReadLine()

        If Double.TryParse(input, result) Then
            Return result
        Else
            Throw New FormatException("Invalid input. The input must be a numeric value.")
        End If
    End Function
End Module