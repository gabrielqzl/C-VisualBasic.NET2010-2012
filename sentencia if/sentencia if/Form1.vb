Public Class Form1
    Private Sub consultar_Click(sender As Object, e As EventArgs) Handles consultar.Click
        'Dim num1, num2 As Integer

        'num1 = txtNum1.Text
        'num2 = txtNum2.Text

        'If (num1 < num2) Then
        '    MsgBox("Numero 1 menor que numero 2")
        'ElseIf (num1 = num2) Then
        '    MsgBox("Numero 1 es igual que numero 2")
        'Else
        '    MsgBox("Numero 1 es mayor que numero 2")
        'End If

        If (txtNum1.Text.Contains("facilito")) Then
            MsgBox("La frase contiene la palabra facilito")
        Else
            MsgBox("No contiene la palabra facilito")
        End If

    End Sub
End Class
