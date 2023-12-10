Imports System

Module Program
    Sub Main()
        Dim str1, alphabets As String
        Dim alpha As Boolean
        Dim i As Integer
        Dim chr1 As Char
        alphabets = "abcdefghijklmnopqrstuvwxyz"
        i = 0
        alpha = True
        chr1 = ""
        str1 = ""
        Console.Write("enter string to process: ")
        str1 = Console.ReadLine
        str1 = LCase(str1)
        For i = 1 To Len(alphabets)
            chr1 = Mid(alphabets, i, 1)
            If InStr(str1, chr1) = 0 Then alpha = False
            If alpha = False Then Exit For
        Next i
        If alpha = True Then
            Console.WriteLine(" entered string is alpha ")
        Else
            Console.WriteLine("entered string is not alpha")
        End If
        Console.ReadKey()

    End Sub
End Module
