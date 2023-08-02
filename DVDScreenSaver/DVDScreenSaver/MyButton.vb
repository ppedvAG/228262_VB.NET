Imports System.Drawing.Drawing2D

Public Class MyButton
    Inherits Button

    Public Overrides Property BackColor As Color
        Get
            Return MyBase.BackColor
        End Get
        Set(value As Color)
            If value = Color.Black Then
                MyBase.BackColor = Color.HotPink
            Else
                MyBase.BackColor = value
            End If
        End Set
    End Property

    Dim paintCount = 0

    Protected Overrides Sub OnPaint(pevent As PaintEventArgs)
        'MyBase.OnPaint(pevent)

        pevent.Graphics.FillRectangle(New SolidBrush(Parent.BackColor), ClientRectangle)
        pevent.Graphics.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias

        Dim br = New LinearGradientBrush(ClientRectangle, Color.Blue, Color.LightCyan, 90.0F)
        pevent.Graphics.FillEllipse(br, ClientRectangle)

        If Me.ClientRectangle.Contains(Me.PointToClient(Control.MousePosition)) Then
            pevent.Graphics.DrawEllipse(Pens.Red, Me.ClientRectangle)
        End If

        Dim sf As New StringFormat()
        sf.LineAlignment = StringAlignment.Center
        sf.Alignment = StringAlignment.Center
        paintCount += 1
        pevent.Graphics.DrawString($"{Text}{vbNewLine}PaintCount:{paintCount}", SystemFonts.DefaultFont, Brushes.Beige, ClientRectangle, sf)
    End Sub

End Class
