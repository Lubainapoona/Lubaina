Imports System

Module Program
    Sub Main()
        Dim string1, string2 As String
        Dim char1, char2, char3 As Char
        Dim i As Integer
        i = 0
        string1 = ""
        string2 = ""
        char1 = ""
        char2 = ""
        char3 = ""

        Console.Write("enter string: ")
        string1 = Console.ReadLine

        char1 = Left(string1, 1)
        string2 = string2 & char1

        For i = 2 To Len(string1)
            char2 = Mid(string1, i, 1)
            If char2 = char1 Then
                char2 = "*"
                string2 = string2 & char2
            Else : char3 = char2
                string2 = string2 & char3
            End If
        Next

        Console.WriteLine(string2)
        Console.ReadKey()


    End Sub
End Module
