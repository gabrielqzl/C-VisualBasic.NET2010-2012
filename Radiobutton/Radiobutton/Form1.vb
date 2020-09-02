Public Class Form1
    Private Sub operacion_Click(sender As Object, e As EventArgs) Handles operacion.Click
        Dim n1, n2 As Integer
        Dim resultado As Double

        n1 = num1.Text
        n2 = num2.Text

        If (suma.Checked = True) Then
            resultado = n1 + n2
        ElseIf (resta.Checked = True) Then
            resultado = n1 - n2
        ElseIf (multiplicacion.Checked = True) Then
            resultado = n1 * n2
        Else
            resultado = n1 / n2
        End If

        MsgBox("El resultado de la operación es: " + resultado.ToString)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        division.Checked = True
    End Sub
End Class
