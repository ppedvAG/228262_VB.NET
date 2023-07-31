Imports System.IO
Imports System.Reflection

Module Module1

    Sub Main()

        'Dim sw As New StreamWriter("text.txt")
        'For i = 1 To 20
        '    Console.WriteLine($"Text {i:00}")
        '    sw.WriteLine($"Text {i:00}")
        'Next
        'sw.Close()

        Dim sr = New StreamReader("text.txt")
        Dim lineCount = 0
        While Not sr.EndOfStream
            Dim line = sr.ReadLine()
            lineCount += 1

            Console.WriteLine($"{lineCount}: {line}")
        End While

        Dim einArray = New Integer() {4, 6, 12, 2, 65}
        Dim einArray2(12) As Integer

        For index = 0 To einArray.Length - 1
            Console.WriteLine(einArray(index))
        Next

        For Each zahl In einArray
            Console.WriteLine(zahl)
        Next

        For index = 0 To einArray2.Length - 1
            einArray2(index) = 9
        Next

        einArray2(4) = 5
        For Each zahl In einArray2
            Console.WriteLine(zahl)
        Next

        Console.WriteLine("--------- List(of Integer) ----------")

        Dim liste = New List(Of Integer)
        liste.Add(5)
        liste.Add(4387)
        liste.Remove(5)
        liste.Add(7)
        liste.Insert(0, 17)
        liste(2) = 6666

        For Each zahl In liste
            Console.WriteLine(zahl)
        Next


        Console.ReadLine()
    End Sub

End Module
