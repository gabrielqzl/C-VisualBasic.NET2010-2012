Public Class Form1
    Private Sub btnEjecutar_Click(sender As Object, e As EventArgs) Handles btnEjecutar.Click
        Dim opc As String = ""
        Dim num1, num2 As Integer
        Dim operacion As Double

        If sumar.Checked = True Then
            opc = "Sumar"
        End If

        If restar.Checked = True Then
            opc = "Restar"
        End If

        If multiplicar.Checked = True Then
            opc = "Multiplicar"
        End If

        If Dividir.Checked = True Then
            opc = "Dividir"
        End If

        num1 = txtnum1.Text
        num2 = txtNum2.Text

        Select Case opc
            Case "Sumar"
                operacion = num1 + num2
            Case "Restar"
                operacion = num1 - num2
            Case "Multiplicar"
                operacion = num1 * num2
            Case "Dividir"
                operacion = num1 / num2
            Case Else
                MsgBox("No ha seleccinado ninguna operación")
                Exit Sub
        End Select

        MsgBox("La operación tiene un resultado = " + operacion.ToString)

    End Sub
End Class
