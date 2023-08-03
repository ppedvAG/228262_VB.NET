Public Class PKW
    Inherits Fahrzeug
    Implements IElektroAntrieb

    Public Property Sitzplätze As Integer

    Public Property Leistung As Integer Implements IElektroAntrieb.Leistung

    Public Property Akku As Integer Implements IElektroAntrieb.Akku

    Public Sub Aufladen() Implements IElektroAntrieb.Aufladen
        Akku = 99
    End Sub
End Class

Public Class LKW
    Inherits Fahrzeug

    Public Property MaxZuladung As Double

End Class

Public Class Fahrrad
    Inherits Fahrzeug
    Implements IElektroAntrieb


    Public Property Klingel As Boolean

    Public Property Leistung As Integer Implements IElektroAntrieb.Leistung


    Public Property Akku As Integer Implements IElektroAntrieb.Akku


    Public Sub Aufladen() Implements IElektroAntrieb.Aufladen
        Akku = 100
    End Sub
End Class

Public Class Boot
    Inherits Fahrzeug

    Public Property Paddel As Boolean

End Class

Public Class Schiff
    Inherits Fahrzeug

    Public Property Anker As Boolean

End Class
