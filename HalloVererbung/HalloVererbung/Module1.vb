Imports System.Threading

Module Module1

    Sub Main()
        Thread.CurrentThread.CurrentCulture = New Globalization.CultureInfo("DE-de") 'app auf deutsch

        Console.WriteLine("*** Hallo Veerbung ***")

        Dim fred As New Customer()
        fred.Name = "Fred"
        fred.BirthDate = New Date(2000, 1, 1)


        ShowPerson(fred)

        Dim wilma As New Employee()
        wilma.Name = "Wilma"
        wilma.BirthDate = New Date(2005, 5, 5)
        wilma.Job = "Boss"
        wilma.Department = "Stuff"

        ShowPerson(wilma)


        Console.WriteLine("Ende")
        Console.ReadLine()
    End Sub

    Private Sub ShowPerson(p As Person)

        Console.WriteLine($"[{p.WasBistDu()}] Name: {p.Name} BDate: {p.BirthDate:d}({p.GetAge()}) Adr: {p.Address}")

        If TypeOf p Is Employee Then 'typprüfung
            Dim personAsEmployee = CType(p, Employee) 'casting
            Console.WriteLine($"{vbTab}Job: {personAsEmployee.Job} Department: {personAsEmployee.Department} Alter:{personAsEmployee.GetAge()}")
        End If

        Dim pAsEmployee = TryCast(p, Employee) 'boxing
        If Not pAsEmployee Is Nothing Then
            Console.WriteLine($"{vbTab}Job: {pAsEmployee.Job} Department: {pAsEmployee.Department}  Alter:{pAsEmployee.GetAge()}")
        End If


    End Sub

End Module
