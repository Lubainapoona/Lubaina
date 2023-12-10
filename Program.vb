Imports System

Module Program
    Sub Main()
        Dim str1, str2 As String
        Dim chr1, chr2, chr3 As Char
        Dim i, counteralphabets, countentered, countdigits, countother As Integer
        Dim alphabets As String
        Dim alphabet As Boolean
        alphabet = True
        str1 = ""
        str2 = ""
        chr1 = ""
        chr2 = ""
        chr3 = ""
        i = 0
        counteralphabets = 0
        countentered = 0
        countdigits = 0
        countother = 0
        alphabets = "abcdefghijklmnopqrstuvwxyz"
        Console.Write("enter string to be processed: ")
        str1 = Console.ReadLine
        Console.Write("enter character to be counted:")
        chr1 = Console.ReadLine
        LCase(str1)
        For i = 1 To Len(str1)
            chr2 = Mid(str1, i, 1)
            If Asc(chr2) > 47 And Asc(chr2) < 59 Then
                countdigits = countdigits + 1
            ElseIf asc(chr2) > 96 And Asc(chr2) < 123 Then
                counteralphabets = counteralphabets + 1
            Else
                countother = countother + 1
            End If
            If chr2 = chr1 Then
                countentered = countentered + 1
            End If
        Next
        Console.WriteLine("character was entered: " & countentered & "times")
        Console.WriteLine("alphabets are:" & counteralphabets)
        Console.WriteLine("digits are:" & countdigits)
        Console.WriteLine("other keys are: " & countother)
        Console.ReadKey()



    End Sub
End Module
