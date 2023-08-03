Public Class Employee
    Inherits Person

    Public Property Job As String
    Public Property Department As String

    Public Overrides Function GetAge() As Integer
        Return MyBase.GetAge() - 5
    End Function


End Class
