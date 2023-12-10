Imports System

Module Program
    Sub Main()
        Dim char1, char2, char3 As Char
        Dim string1 As String
        Dim i As Integer
        i = 0
        char1 = ""
        char2 = ""
        char3 = ""
        string1 = ""

        Console.Write("enter string: ")
        string1 = Console.ReadLine

        If Len(string1) > 1 Then
            Console.WriteLine(Left(string1, 2) & Right(string1, 2))
        Else
            Console.WriteLine(string1)
        End If
        Console.ReadKey()



    End Sub
End Module
