' Euler Project #3 in Visual Basic
' What is the largest prime factor of the number 600851475143?

Module euler003

    Sub Main()
        Dim Number As Long = 600851475143L
        Dim CurrentPrime As Integer = 2

        While CurrentPrime < Number
            If Not (Number Mod CurrentPrime = 0) Then
                CurrentPrime = CurrentPrime + 1
                Continue While
            End If
            Number = Number / CurrentPrime
        End While
        Console.WriteLine(Number)
    End Sub

End Module
