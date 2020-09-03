Public Class Form1
    Private Sub btnConvertir_Click(sender As Object, e As EventArgs) Handles btnConvertir.Click
        Dim refDolar As Integer
        Dim resultado, cantidad As Double
        Dim selectBs As Boolean

        refDolar = Val(txtReferenciaDolar.Text)
        cantidad = Val(txtCantidad.Text)
        'Dim resulConversion As String = lblResultadoConversion.Text

        'selectBs = rdBsDolar

        If rdDolarBs.Checked = True Then
            resultado = refDolar * cantidad
            lblResultadoConversion.Text = Format(resultado, "#,###.##")

        ElseIf rdBsDolar.Checked = True Then
            If cantidad >= refDolar Then
                resultado = cantidad / refDolar
                lblResultadoConversion.Text = Format(resultado, "#,###.##")
            Else
                MsgBox("Ingrese una cantidad mayor a " & refDolar)
            End If
        End If
    End Sub
End Class
