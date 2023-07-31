Public Class Form1

    Dim clickCount As Integer = 0

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
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
End Class
