Public Class Fahrzeug
    Public Property Modell As String
    Public Property Hersteller As String
    Public Property Farbe As System.String
    Public Property MaxGeschwindigkeit As Integer

    Public Property Baujahr As Date

    Public Function GetMaxSpeedInMilesPerHour() As System.Double
        ' Umrechnungsfaktor von km/h in mph
        Const kmToMiles As Double = 0.621371

        ' Berechne die MaxGeschwindigkeit in mph
        Dim maxSpeedInMph As Double = MaxGeschwindigkeit * kmToMiles
        Return maxSpeedInMph
    End Function

    ''' <summary>
    ''' Läßt das Fahrzeug hupen
    ''' </summary>
    ''' <remarks>
    ''' *hup,hup*
    ''' </remarks>
    ''' <exception cref="YellowHupenException"/>
    Public Sub Hupen()

        If Farbe = "yellow" Then
            Dim ex = New YellowHupenException()
            ex.FarbeInfo = "Gelbe Autos habe kaputte hupen"
            Throw ex
        End If
        Console.Beep()
        Console.Beep()

    End Sub

End Class

Public Class YellowHupenException
    Inherits Exception

    Public Property FarbeInfo As String

End Class
