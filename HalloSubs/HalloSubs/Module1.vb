Imports System.IO

Module Module1

    Sub Main(ParamArray args() As String)


        For Each arg In args
            Console.WriteLine(arg)
        Next

        'Process.Start("notepad.exe")
        'Dim ps = New ProcessStartInfo("notepad.exe")
        'ps.WorkingDirectory = ""
        'Process.Start(ps)

        Dim vorName = "Wilma"
        SagHallo()
        SagHallo("Fred")
        SagHallo(vorName)
        SagHallo()
        SagHallo()
        Dim five As Integer = GiveMeFive()
        IsWeekend()
        IsWeekend(New DateTime(2002, 3, 5))
        Console.WriteLine("Ende")
        Console.ReadLine()

    End Sub


    Function IsWeekend() As Boolean
        Return IsWeekend(DateTime.Now)
    End Function

    Function IsWeekend(day As DateTime) As Boolean
        Return day.DayOfWeek = DayOfWeek.Saturday Or
               day.DayOfWeek = DayOfWeek.Sunday
    End Function

    'Function IsWeekend() As Boolean
    '    Return Date.Now.DayOfWeek = DayOfWeek.Saturday Or
    '           Date.Now.DayOfWeek = DayOfWeek.Sunday
    'End Function

    Sub SagHallo()
        Console.WriteLine("Hallo")
    End Sub

    Sub SagHallo(name As String)
        Console.WriteLine($"Hallo {name}")
    End Sub

    Function GiveMeFive() As Integer
        LoadAllData()
        If Date.Now.DayOfWeek = DayOfWeek.Friday Then
            Return 2
        Else
            Return 5
        End If
    End Function

    Private Sub LoadAllData()
        GetMoreData()
    End Sub

    Private Sub GetMoreData()
        Console.WriteLine("More Data")
        Debug.WriteLine("MORE DATA")
        File.OpenRead("b:\text.txt")

    End Sub
End Module
