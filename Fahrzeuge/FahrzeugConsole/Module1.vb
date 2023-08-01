Imports Fahrzeuge

Public Module Module1

    Sub Main()
        Console.WriteLine("*** Fahrzeug Consolen APP v0.1 ***")

        Dim auto1 As New Fahrzeug()
        auto1.Farbe = "gelb"
        auto1.MaxGeschwindigkeit = 12

        Console.WriteLine($"{auto1.Farbe} {auto1.MaxGeschwindigkeit}km/h {auto1.GetMaxSpeedInMilesPerHour()}mph")
        auto1.Hupen()

        Console.WriteLine("Ende")
        Console.ReadLine()
    End Sub

End Module
