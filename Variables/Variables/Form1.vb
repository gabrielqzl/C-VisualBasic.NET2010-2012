Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Variables y Tipos de Datos

        Dim entero As Integer = 1
        MsgBox(entero)
        entero = 2
        MsgBox(entero)

        Dim numero As Double = 123.456
        MsgBox(numero)
        numero = 12.5
        MsgBox(numero)

        Dim texto As String = "Gabriel"
        MsgBox(texto)
        Dim texto2 As String = " Quiroz"
        MsgBox(texto + texto2)

        Dim fecha As Date = "29-08-20"
        MsgBox(fecha)

        Dim fecha2 As Date = "29-JAN-2020"
        MsgBox(fecha2)
    End Sub
End Class
