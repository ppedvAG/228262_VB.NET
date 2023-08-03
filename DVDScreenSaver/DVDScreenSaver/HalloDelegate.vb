

Public Delegate Sub EinfachDelete()


Public Class HalloDelegate

    Sub New()

        Dim mySub As EinfachDelete = AddressOf SagHallo
        mySub.Invoke()
        mySub.Invoke()
        mySub.Invoke()
        mySub.Invoke()

    End Sub

    Sub SagHallo()
        Console.Write("Hallo")
    End Sub


    Sub SagHalloMitName(name As String)
        Console.Write("Hallo")
    End Sub


End Class


