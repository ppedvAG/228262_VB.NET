Public Class Form1

    Dim clickCount As Integer = 0

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        clickCount += 1
        MessageBox.Show($"Button wurde {clickCount}x geklickt")
    End Sub

    Dim xSpeed = 1
    Dim ySpeed = 1

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        If (Button1.Left + Button1.Width >= ClientSize.Width Or Button1.Left <= 0) Then
            xSpeed *= -1
        End If

        If (Button1.Top + Button1.Height >= ClientSize.Height Or Button1.Top <= 0) Then
            ySpeed *= -1
        End If

        Button1.Left += xSpeed
        Button1.Top += ySpeed

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Text = $"DVD Sceensaver {Date.Today.DayOfWeek} {CInt(Motor.Electro)}"

        Select Case Date.Today.DayOfWeek
            Case DayOfWeek.Sunday
            Case DayOfWeek.Tuesday
                BackColor = Color.Black

            Case DayOfWeek.Thursday
                BackColor = Color.Violet

            Case Else
                BackColor = Color.White


        End Select

    End Sub


    Enum Motor
        Benzin = 0
        Diesel = 1
        Electro = 244545
        Hybrid = 3
    End Enum

End Class
