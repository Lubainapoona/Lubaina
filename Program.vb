Imports System

Module Program
    Sub Main()
        Dim numberofdonuts As Integer
        numberofdonuts = 0
        Console.Write(" enter the number of dounts:")
        numberofdonuts = Console.ReadLine
        If numberofdonuts >= 10 Then
            Console.WriteLine("number of donuts: many")
        Else
            Console.WriteLine("number of donuts: numberofdonuts")
        End If
        Console.ReadKey()
    End Sub
End Module
