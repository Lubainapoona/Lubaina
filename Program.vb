Imports System

Module Program
    Sub Main()
        Dim string1, afterbad, beforenot, string3 As String
        Dim char1, char2 As Char
        Dim notindex, badindex As Integer
        string3 = ""

        string1 = ""
        afterbad = ""
        beforenot = ""
        char1 = ""
        char2 = ""
        notindex = 0
        badindex = 0
        Console.Write("enter sentence: ")
        string1 = Console.ReadLine
        If InStr(string1, "Not") < InStr(string1, "bad") Then
            notindex = InStr(string1, "Not")
            badindex = InStr(string1, "bad")

            beforenot = Left(string1, notindex - 1)
            afterbad = Mid(string1, badindex + 3)

            string3 = beforenot & "good" & afterbad
        End If
        Console.WriteLine(string3)
            Console.ReadKey()


    End Sub
End Module
