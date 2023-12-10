Imports System

Module Program
    Sub Main()
        Dim string1 As String
        Dim char1, char2 As Char
        Dim i, countofA, countofE, countofI, countofU, countofO As Integer
        string1 = ""
        char1 = ""
        char2 = ""
        i = 0
        countofA = 0
        countofE = 0
        countofI = 0
        countofO = 0
        countofU = 0
        Console.Write("enter string: ")
        string1 = Console.ReadLine

        LCase(string1)
        For i = 1 To Len(string1)
            char2 = Mid(string1, i, 1)
            If Asc(char2) = 97 Then
                countofA = countofA + 1
            ElseIf Asc(char2) = 101 Then
                countofE = countofE + 1
            ElseIf Asc(char2) = 105 Then
                countofI = countofI + 1
            ElseIf Asc(char2) = 111 Then
                countofO = countofO + 1
            ElseIf Asc(char2) = 115 Then
                countofU = countofU + 1
            End If
        Next
        Console.WriteLine("a: " & countofA & " times")
        Console.WriteLine("e: " & countofE & " times")
        Console.WriteLine("i: " & countofI & " times")
        Console.WriteLine("o: " & countofO & " times")
        Console.WriteLine("u: " & countofU & " times")

        Console.ReadKey()







    End Sub
End Module
