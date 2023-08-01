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

        Dim faker = CreateFaker()
        Dim newFahrZeug = faker.Generate(1).First()

        BindingSource1.Add(newFahrZeug)

    End Sub

    Public Shared Function CreateFaker() As Faker(Of Fahrzeug)
        Dim faker = New Faker(Of Fahrzeug)()

        ' Konfiguriere das Erstellen gefälschter Daten für die Eigenschaften des Fahrzeugs
        faker.RuleFor(Function(v) v.Modell, Function(f) f.Vehicle.Model())
        faker.RuleFor(Function(v) v.Hersteller, Function(f) f.Vehicle.Manufacturer())
        faker.RuleFor(Function(v) v.Farbe, Function(f) f.Commerce.Color())
        faker.RuleFor(Function(v) v.MaxGeschwindigkeit, Function(f) f.Random.Number(80, 250))
        faker.RuleFor(Function(v) v.Baujahr, Function(f) f.Date.Past(10, DateTime.Now.AddYears(-1)))

        Return faker
    End Function

    Private Sub showSelectedButton_Click(sender As Object, e As EventArgs) Handles showSelectedButton.Click
        If BindingSource1.Current IsNot Nothing Then

            Dim selectedFahrzeug = CType(BindingSource1.Current, Fahrzeug)

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
End Class
