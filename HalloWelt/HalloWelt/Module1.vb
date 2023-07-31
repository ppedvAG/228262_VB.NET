Imports System.Runtime.InteropServices
Imports System.Text

Module Module1

    Sub Main()
        Console.WriteLine("Hallo Welt")
        Console.OutputEncoding = Encoding.UTF8

        Dim zahl As Integer
        zahl = 4
        Console.WriteLine("Zahl: 👌💾🔷" & zahl)
        Console.WriteLine("Zahl: {0}", zahl)
        Console.WriteLine("Zahl: {0:000.00}", zahl)
        Console.WriteLine($"Zahl: {zahl * 2}")
        Console.WriteLine($"Zahl: {zahl:000.000}")

        Dim geld As Decimal = CDec(34.83443786)
        Console.WriteLine(geld)
        Console.WriteLine($"{geld:0.000} €")
        Console.WriteLine($"{geld:C}")

        Dim text As String = "Was geht ab?"
        'text = 6
        Console.WriteLine(text)

        Dim istPause = True
        Console.WriteLine(istPause)

        'explizit
        Dim intFromDec As Integer = CInt(geld)
        Console.WriteLine(intFromDec)

        'implizit
        Dim decFromInt As Decimal = zahl

        Console.WriteLine("Gib eine Zahl ein:")
        Dim eingabe As String = Console.ReadLine()

        Dim eingabeAlsInt2 As Integer
        If Integer.TryParse(eingabe, eingabeAlsInt2) Then
            Console.WriteLine($"Dein Text war eine Zahl: {eingabeAlsInt2}")
        Else
            Console.WriteLine("Das war keine Zahl")
        End If

        Dim eingabeAsInt = Integer.Parse(eingabe)
        Console.WriteLine($"Das doppelte ist: {eingabeAsInt * 2}")


        Console.ReadLine()
    End Sub

End Module
