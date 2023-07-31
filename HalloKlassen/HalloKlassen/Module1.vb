Module Module1

    Sub Main()
        Dim ran As New Random(7)
        Console.WriteLine(ran.Next(100))

        Dim mitz As New Katze()
        mitz.Name = "Luna"
        mitz.MachLaut()

        Dim kadse As Katze 'deklaration
        kadse = New Katze() 'instanzierung
        kadse.Name = "Puma"
        kadse.MachLaut()
        MachKatzeÄlter(kadse)
        kadse.MachLaut()

        Dim zahl = 12
        Console.WriteLine(zahl)
        MachEinsMehr(zahl)
        Console.WriteLine(zahl)

        Dim katzen As New List(Of Katze)
        While True
            katzen.Add(New Katze())

        End While

        Console.WriteLine("Ende")
        Console.ReadLine()

    End Sub

    Sub MachKatzeÄlter(ByRef katze As Katze)
        katze.Alter += 1
    End Sub

    Sub MachEinsMehr(ByVal zahl As Integer)
        zahl += 1
    End Sub

End Module

Class Katze

    Public Name As String 'Feld
    Public Alter As Integer

    Public Sub MachLaut()
        Console.WriteLine($"{Name} mit {Alter} Jahren macht miauuuuu")
    End Sub

End Class
