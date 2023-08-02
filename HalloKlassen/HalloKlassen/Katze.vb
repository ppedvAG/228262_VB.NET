Class Katze

    Sub New() 'default ctor

    End Sub

    Sub New(name As String)
        '_name = name

        Me.Name = name
    End Sub

    Public Property Farbe As String 'Auto-Property

    Private _name As String 'backing field
    Public Property Name As String ' Full-Property
        Get
            Return _name
        End Get
        Friend Set
            If Value = "Puma" Then
                _name = "Pumba"
            Else
                _name = Value
            End If
        End Set
    End Property

    Private _alter As Integer

    Public Function GetAlter() As Integer
        Return _alter
    End Function

    Friend Sub SetAlter(alter As Integer)
        If (alter < 0) Then
            Throw New ArgumentException("Alter kann nicht unter 0 sein")
        End If
        _alter = alter
    End Sub

    Public Sub MachLaut()
        Console.WriteLine($"{_name} mit {_alter} Jahren macht miauuuuu")
    End Sub

End Class


