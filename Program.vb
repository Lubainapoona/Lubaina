Imports System

Module Program
    Sub Main()
        Dim string1, string2 As String
        Dim char1, char2, char3 As Char
        Dim i As Integer
        string2 = ""
        string1 = ""
        char1 = ""
        char2 = ""
        char3 = ""
        i = 0
        Console.Write("enter string to be processed: ")
        string1 = Console.ReadLine
        Console.Write("enter character to select in the string: ")
        char1 = Console.ReadLine
        Console.Write("enter character to replace in the string: ")
        char2 = Console.ReadLine
        For i = 1 To Len(string1)
            char3 = Mid(string1, i, 1)
            If char3 = char1 Then
                string2 = string2 + char2
            Else
                string2 = string2 + char3
            End If
        Next
        Console.WriteLine("processed string after replacement is: " & string2)
        Console.ReadKey()



    End Sub
End Module
