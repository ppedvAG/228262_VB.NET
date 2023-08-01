Public Class Form1


    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        TextBox2.DataBindings.Add("Text", TextBox1, "Text", True, DataSourceUpdateMode.OnPropertyChanged)
        TextBox2.DataBindings.Add("BackColor", TextBox1, "Text", True, DataSourceUpdateMode.OnPropertyChanged)


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox2.BackColor = Color.Coral
    End Sub
End Class
