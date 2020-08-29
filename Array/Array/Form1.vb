Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Dim arreglo(3) As String
        'arreglo(0) = "Hola"
        'arreglo(1) = "Codigo"
        'arreglo(2) = "Facilito"
        'MsgBox(arreglo(0) + " " + arreglo(1) + " " + arreglo(2))

        'Dim arreglo() As Integer
        'arreglo = New Integer() {1, 2, 3}

        'MsgBox(arreglo(0).ToString + " " + arreglo(1).ToString + " " + arreglo(2).ToString)

        'Preserve se utiliza para preservar los datos del array cuando se redimensiona
        'ReDim Preserve arreglo(2)
        'MsgBox(arreglo(0).ToString + " " + arreglo(1).ToString)

        'ReDim arreglo(3)
        'MsgBox(arreglo(0).ToString + " " + arreglo(1).ToString + " " + arreglo(2).ToString)

        Dim matriz(,) As Integer = {{1, 2, 3}, {4, 5, 6}}
        MsgBox(matriz(1, 1).ToString)
    End Sub
End Class
