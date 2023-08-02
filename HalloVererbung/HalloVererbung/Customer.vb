Public Class Customer
    Inherits Person

    Public Property CustomerNumber As String

    Public Overrides Function WasBistDu() As String
        Return "Customer"
    End Function
End Class
