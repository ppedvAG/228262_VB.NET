Public Class Fahrzeug
    Public Property Modell As String
    Public Property Hersteller As String
    Public Property Farbe As String
    Public Property MaxGeschwindigkeit As Integer

    Public Property Baujahr As Date

    Public Function GetMaxSpeedInMilesPerHour() As Double
        ' Umrechnungsfaktor von km/h in mph
        Const kmToMiles As Double = 0.621371

        ' Berechne die MaxGeschwindigkeit in mph
        Dim maxSpeedInMph As Double = MaxGeschwindigkeit * kmToMiles
        Return maxSpeedInMph
    End Function

    Public Sub Hupen()
        Console.Beep()
        Console.Beep()
    End Sub

End Class
