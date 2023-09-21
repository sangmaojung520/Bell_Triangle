Imports System
Public Class belltriangle

    ' Recursive function to print the
    ' Bell Triangle.
    Private Shared Function Rec(ByVal NumberOfRowsLeft As Integer) As Integer()
        ' Base case
        ' 1st row will contain only 1
        ' So based on tail recursion,
        ' last recursion will be the 1st row
        If (NumberOfRowsLeft = 1) Then
            Dim array() As Integer = New Integer() {1}
            Console.WriteLine(String.Join(", ", array))
            Return array
        End If

        ' Store array from previous recursion call
        Dim LastCall() As Integer = belltriangle.Rec((NumberOfRowsLeft - 1))
        ' Create array to store the current row
        Dim CurrentCall() As Integer = New Integer((NumberOfRowsLeft) - 1) {}
        ' Store last element from previous call array to
        ' 1st index of current call array
        CurrentCall(0) = LastCall((LastCall.Length - 1))
        ' Create the current call Bell Triangle
        Dim currentRow As Integer = 0
        Do While (currentRow _
                    < (NumberOfRowsLeft - 1))
            CurrentCall((currentRow + 1)) = (CurrentCall(currentRow) + LastCall(currentRow))
            currentRow = (currentRow + 1)
        Loop

        ' Print the current call Bell Triangle
        ' as the next row
        Console.WriteLine(String.Join(", ", CurrentCall))
        ' Return the new formed array as latest row
        Return CurrentCall
    End Function


    Public Shared Sub Main()
        Dim numberOfRows As Integer = 7
        belltriangle.Rec(numberOfRows)
        Console.Read()
    End Sub
End Class