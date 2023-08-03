Imports System.IO
Imports System.Threading
Imports System.Xml.Serialization
Imports Bogus
Imports Fahrzeuge

Public Class Form1

    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        BindingSource1.DataSource = New List(Of Fahrzeug)
        fahrzeugeDataGridView.DataSource = BindingSource1
        herstellerTextBox.DataBindings.Add("Text", BindingSource1, NameOf(Fahrzeug.Hersteller), True, DataSourceUpdateMode.OnPropertyChanged)
        modellTextBox.DataBindings.Add("Text", BindingSource1, NameOf(Fahrzeug.Modell), True, DataSourceUpdateMode.OnPropertyChanged)
        farbeTextBox.DataBindings.Add("Text", BindingSource1, NameOf(Fahrzeug.Farbe), True, DataSourceUpdateMode.OnPropertyChanged)
        maxGeschwindigkeitNumericUpDown.DataBindings.Add("Value", BindingSource1, NameOf(Fahrzeug.MaxGeschwindigkeit), True, DataSourceUpdateMode.OnPropertyChanged)
        baujahrDateTimePicker.DataBindings.Add("Value", BindingSource1, NameOf(Fahrzeug.Baujahr), True, DataSourceUpdateMode.OnPropertyChanged)


    End Sub

    Private Sub newButton_Click(sender As Object, e As EventArgs) Handles newButton.Click

        'Dim faker = CreateFahrzeugFaker()
        'Dim newFahrZeug = faker.Generate(1).First()
        '        BindingSource1.Add(newFahrZeug)
        BindingSource1.Add(CreatePKWFaker().Generate(1).First())
        BindingSource1.Add(CreateBikeFaker().Generate(1).First())

    End Sub

    Public Shared Function CreateFahrzeugFaker() As Faker(Of Fahrzeug)
        Dim faker = New Faker(Of Fahrzeug)()

        ' Konfiguriere das Erstellen gefälschter Daten für die Eigenschaften des Fahrzeugs
        faker.RuleFor(Function(v) v.Modell, Function(f) f.Vehicle.Model())
        faker.RuleFor(Function(v) v.Hersteller, Function(f) f.Vehicle.Manufacturer())
        faker.RuleFor(Function(v) v.Farbe, Function(f) f.Commerce.Color())
        faker.RuleFor(Function(v) v.MaxGeschwindigkeit, Function(f) f.Random.Number(80, 250))
        faker.RuleFor(Function(v) v.Baujahr, Function(f) f.Date.Past(10, DateTime.Now.AddYears(-1)))

        Return faker
    End Function


    Public Shared Function CreatePKWFaker() As Faker(Of PKW)
        Dim pkwFaker As New Faker(Of PKW)()
        pkwFaker.RuleFor(Function(f) f.Modell, Function(f) f.Vehicle.Model)
        pkwFaker.RuleFor(Function(f) f.Hersteller, Function(f) f.Vehicle.Manufacturer)
        pkwFaker.RuleFor(Function(f) f.Farbe, Function(f) f.Commerce.Color)
        pkwFaker.RuleFor(Function(f) f.MaxGeschwindigkeit, Function(f) f.Random.Number(80, 250))
        pkwFaker.RuleFor(Function(f) f.Baujahr, Function(f) f.Date.Past(5, DateTime.Now.AddYears(-1)))

        ' PKW-spezifische Faker-Regeln
        pkwFaker.RuleFor(Function(f) f.Sitzplätze, Function(f) f.Random.Number(2, 7))
        pkwFaker.RuleFor(Function(f) f.Leistung, Function(f) f.Random.Number(100, 500))
        pkwFaker.RuleFor(Function(f) f.Akku, Function(f) f.Random.Number(0, 100))

        Return pkwFaker
    End Function

    Public Shared Function CreateBikeFaker() As Faker(Of Fahrrad)
        Dim pkwFaker As New Faker(Of Fahrrad)()
        pkwFaker.RuleFor(Function(f) f.Modell, Function(f) f.Vehicle.Model)
        pkwFaker.RuleFor(Function(f) f.Hersteller, Function(f) f.Vehicle.Manufacturer)
        pkwFaker.RuleFor(Function(f) f.Farbe, Function(f) f.Commerce.Color)
        pkwFaker.RuleFor(Function(f) f.MaxGeschwindigkeit, Function(f) f.Random.Number(80, 250))
        pkwFaker.RuleFor(Function(f) f.Baujahr, Function(f) f.Date.Past(5, DateTime.Now.AddYears(-1)))

        ' PKW-spezifische Faker-Regeln
        pkwFaker.RuleFor(Function(f) f.Klingel, Function(f) f.Random.Bool())
        pkwFaker.RuleFor(Function(f) f.Leistung, Function(f) f.Random.Number(10, 50))
        pkwFaker.RuleFor(Function(f) f.Akku, Function(f) f.Random.Number(0, 100))

        Return pkwFaker
    End Function

    Private Sub showSelectedButton_Click(sender As Object, e As EventArgs) Handles showSelectedButton.Click
        If BindingSource1.Current IsNot Nothing Then

            Dim selectedFahrzeug = CType(BindingSource1.Current, Fahrzeug)

            Try
                selectedFahrzeug.Hupen()
            Catch ex As YellowHupenException
                MessageBox.Show($"{ex.Message} - {ex.FarbeInfo}")
            End Try


            MessageBox.Show($"{selectedFahrzeug.Modell} {selectedFahrzeug.Hersteller}")
        End If

    End Sub

    Private Sub deleteButton_Click(sender As Object, e As EventArgs) Handles deleteButton.Click

        If BindingSource1.Current IsNot Nothing Then

            Dim selectedFahrzeug = CType(BindingSource1.Current, Fahrzeug)

            Dim msgText = $"Soll das Fahrzeug '{selectedFahrzeug.Hersteller} {selectedFahrzeug.Modell}' wirklich gelöscht werden?"

            If MessageBox.Show(msgText, "Löschen?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then
                BindingSource1.Remove(BindingSource1.Current)
            End If

        End If

    End Sub

    Private Sub saveButton_Click(sender As Object, e As EventArgs) Handles saveButton.Click

        Dim saveDlg As New SaveFileDialog
        saveDlg.Title = "Tolle Textdatei speichern"
        saveDlg.Filter = "Textdatei|*.txt|Alle Dateien|*.*"
        saveDlg.FileName = "TollesAutos.txt"
        'saveDlg.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Cookies)

        If saveDlg.ShowDialog() = DialogResult.OK Then

            Dim data = CType(BindingSource1.DataSource, List(Of Fahrzeug))

            Dim sw As New StreamWriter(saveDlg.FileName)
            sw.WriteLine("Meine Autos")
            For Each car In data
                Dim line = String.Join("|", car.Hersteller, car.Modell, car.Farbe, car.Baujahr, car.MaxGeschwindigkeit)
                sw.WriteLine(line)
            Next
            sw.Close()

        End If

    End Sub

    Private Sub loadButton_Click(sender As Object, e As EventArgs) Handles loadButton.Click

        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            Dim data As New List(Of Fahrzeug)

            Dim sr As New StreamReader(OpenFileDialog1.FileName)
            sr.ReadLine() 'header line
            While Not sr.EndOfStream
                Dim line = sr.ReadLine()
                Dim chunks = line.Split("|")
                Dim car As New Fahrzeug()
                car.Hersteller = chunks(0)
                car.Modell = chunks(1)
                car.Farbe = chunks(2)
                car.Baujahr = Date.Parse(chunks(3))
                car.MaxGeschwindigkeit = Integer.Parse(chunks(4))
                data.Add(car)
            End While
            sr.Close()

            BindingSource1.DataSource = data
        End If
    End Sub

    Private Sub saveXMLButton_Click(sender As Object, e As EventArgs) Handles saveXMLButton.Click

        Dim sw As New StreamWriter("autos.xml")
        Dim serializer As New XmlSerializer(GetType(List(Of Fahrzeug)))
        serializer.Serialize(sw, BindingSource1.DataSource)
        sw.Close()

    End Sub

    Private Sub loadXMLButton_Click(sender As Object, e As EventArgs) Handles loadXMLButton.Click

        Try

            Dim sr As New StreamReader("c:\wÖÜ'ÄÜ*Ö'ÄÖ'ÜÖ'ÄÖ*Ü#+##ekjnbkwej.ddd")
            Dim serializer As New XmlSerializer(GetType(List(Of Fahrzeug)))
            BindingSource1.DataSource = serializer.Deserialize(sr)
            sr.Close()

        Catch ex As FileNotFoundException

            MessageBox.Show($"Die Datei {ex.FileName} ist nicht da {ex.Message} ")

        Catch ex As ArgumentException

            MessageBox.Show($"Der Dateiname ist dumm!!! {ex.Message}  {ex.ParamName} {ex.StackTrace}")

        Catch ex As Exception

            MessageBox.Show($"Es ist ein Fehler aufgetreten: {ex.Message}")

        End Try

    End Sub

    Private Async Sub longLoadButton_Click(sender As Object, e As EventArgs) Handles longLoadButton.Click


        Dim sr As New StreamReader("Autos.txt")
        Await Task.Delay(5000)
        Dim line = Await sr.ReadLineAsync()
        Text = line

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        Dim selectedFahrzeug = TryCast(BindingSource1.Current, IElektroAntrieb)

        If Not selectedFahrzeug Is Nothing Then
            'MessageBox.Show(selectedFahrzeug.Akku)
            selectedFahrzeug.Aufladen()
            'MessageBox.Show(selectedFahrzeug.Akku)
            BindingSource1.ResetBindings(False)
        End If

    End Sub

    Private Sub fahrzeugeDataGridView_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles fahrzeugeDataGridView.CellFormatting

        If e.ColumnIndex = akkuColumn.Index Then

            Dim akkuDings = TryCast(fahrzeugeDataGridView.Rows(e.RowIndex).DataBoundItem, IElektroAntrieb)

            If Not akkuDings Is Nothing Then
                e.Value = akkuDings.Akku
            End If

        End If
    End Sub
End Class
