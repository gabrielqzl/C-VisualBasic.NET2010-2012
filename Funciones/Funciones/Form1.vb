Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Sub saludar()
        MsgBox("Soy la funcion para saludar")
    End Sub

    Function retornaSaludo()
        Dim saludo As String
        saludo = "Hola soy un procedimiento para saludar"
        Return saludo
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        saludar()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim hola As String
        hola = retornaSaludo()
        MsgBox(hola)
    End Sub
End Class
