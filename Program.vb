Imports System
Imports System.Transactions

Module Program
    Sub Main()
        Dim a, b, result As String
        a = ""
        b = ""
        result = ""
        Console.Write(" enter the first string (a) :")
        a = Console.ReadLine
        Console.Write(" enter the first string (b) :")
        b = Console.ReadLine
        result = Mid(b, 1, 2) & Mid(a, 3) & " " & Mid(a, 1, 2) & Mid(b, 3)
        Console.WriteLine("Result: " & result)
        Console.ReadKey()


    End Sub
End Module
