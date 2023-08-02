Public MustInherit Class Person

    Public Property Name As String
    Public Property Address As String
    Public Property BirthDate As Date

    Public MustOverride Function WasBistDu() As String

    Public Overridable Function GetAge() As Integer
        ' Berechne das Alter basierend auf dem Geburtsdatum
        Dim today As Date = Date.Today
        Dim age As Integer = today.Year - BirthDate.Year

        ' Berücksichtige, ob der Geburtstag in diesem Jahr bereits stattgefunden hat
        If today < BirthDate.AddYears(age) Then
            age -= 1
        End If

        Return age
    End Function

End Class
