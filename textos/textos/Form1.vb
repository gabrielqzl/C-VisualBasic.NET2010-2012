Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dim cadena As String
        'cadena = "Hola Mundo "

        'Dim verifica As Boolean
        'verifica = cadena.Contains("facilito")

        'If verifica = True Then
        '    MsgBox("La cadena si contiene la palabra facilito")
        'Else
        '    MsgBox("La cadena no contiene la palabra facilito")
        'End If

        Dim comparacion As Integer

        comparacion = StrComp("codigo", "Codigo")
        MsgBox(comparacion.ToString)



    End Sub
End Class
