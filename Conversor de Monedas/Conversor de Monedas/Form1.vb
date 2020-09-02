Public Class conversorMonedas
    Private Sub convertir_Click(sender As Object, e As EventArgs) Handles convertir.Click

        Dim importe, dolar As Double
        Dim resultado As Double

        importe = importeMoneda.Text
        dolar = 334000

        If (dolarBolivar.Checked = True) Then
            resultado = dolar * importe
            lblResultado.Text = Convert.ToString(resultado & " $")
        ElseIf (bolivarDolar.Checked = True) Then
            resultado = importe / dolar
            lblResultado.Text = Convert.ToString(resultado & " Bs")
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
