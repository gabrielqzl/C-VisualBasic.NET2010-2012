Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim num1, num2, operacion As Double
        num1 = 2
        num2 = 5
        operacion = 5 Mod num2

        num1 -= 5

        MsgBox(num1.ToString)
    End Sub
End Class
