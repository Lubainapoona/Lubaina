Imports System

Module Program
    Sub Main()
        Dim string1, string2, string3, string4 As String
        Dim i, count As Integer
        Dim char1, char2, char3 As Char
        char1 = ""
        char2 = ""
        char3 = ""
        string1 = ""
        string2 = "ly"
        string3 = "ing"
        string4 = ""
        i = 0
        count = 0
        Console.Write("enter word: ")
        string1 = Console.ReadLine
        If Len(string1) > 2 And Right(string1, 3) = "ing" Then
            string4 = string1 & string2
        ElseIf Len(string1) > 2 Then
            string4 = string1 & string3
        Else
            string4 = string1
        End If
        Console.WriteLine(string4)
        Console.ReadKey()



    End Sub
End Module
