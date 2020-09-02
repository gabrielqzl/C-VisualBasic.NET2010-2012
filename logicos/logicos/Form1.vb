Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim resultado As Boolean

        'resultado = (1 = 1) And (2 = 2)
        'MsgBox(resultado)

        'resultado = (1 = 1) And (2 = 1)
        'MsgBox(resultado)

        'resultado = (1 = 2) And (2 = 2)
        'MsgBox(resultado)

        'resultado = (1 = 2) And (2 = 1)
        'MsgBox(resultado)

        'resultado = (1 = 1) Or (2 = 2)
        'MsgBox(resultado)

        'resultado = (1 = 1) Or (2 = 1)
        'MsgBox(resultado)

        'resultado = (1 = 2) Or (2 = 2)
        'MsgBox(resultado)

        'resultado = (1 = 2) Or (2 = 1)
        'MsgBox(resultado)

        'resultado = Not (1 = 1)
        'MsgBox(resultado)

        'resultado = Not (1 <> 1)
        'MsgBox(resultado)

        resultado = ((1 = 1) And (2 = 1)) Or (3 = 3)
        MsgBox(resultado)






    End Sub
End Class
