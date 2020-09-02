Public Class Form1
    Private num1, num2, suma As Integer

    Private Sub BtnUno_Click(sender As Object, e As EventArgs) Handles BtnSuma.Click
        num1 = TxtNum1.Text
        num2 = TxtNum2.Text
        suma = num1 + num2
        MsgBox(suma, MsgBoxStyle.Information, "Resultado de Suma")

    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub
End Class
