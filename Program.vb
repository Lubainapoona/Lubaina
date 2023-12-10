Imports System

Module Program
    Sub Main()
        Dim string1 As String
        Dim letter1 As Char
        Dim i, j As Integer
        Dim count As Integer
        Dim maxCount As Integer
        Dim mostFrequentChar As Char

        count = 0
        maxCount = 0
        string1 = ""
        Console.Write("Enter string: ")
        string1 = Console.ReadLine
        For i = 1 To Len(string1)
            letter1 = Mid(string1, i, 1)
            count = 0
            For j = 1 To Len(string1)
                If Mid(string1, j, 1) = letter1 Then
                    count = count + 1
                End If
                If count > maxCount Then
                    maxCount = count
                End If
            Next j
            If count > maxCount Then
                maxCount = count
                mostFrequentChar = letter1
            End If
        Next i
        Console.WriteLine("The character that appears most frequently is: " & mostFrequentChar)
        Console.ReadKey()


    End Sub
End Module
