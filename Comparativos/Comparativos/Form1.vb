Public Class Comparativos
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim igual As Boolean
        igual = numero1.Text = numero2.Text
        MsgBox(igual)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim mayor As Boolean
        mayor = numero1.Text > numero2.Text
        MsgBox(mayor)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim menor As Boolean
        menor = numero1.Text < numero2.Text
        MsgBox(menor)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim mayorIgual As Boolean
        mayorIgual = numero1.Text >= numero2.Text
        MsgBox(mayorIgual)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim menorIgual As Boolean
        menorIgual = numero1.Text <= numero2.Text
        MsgBox(menorIgual)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim diferente As Boolean
        diferente = numero1.Text <> numero2.Text
        MsgBox(diferente)
    End Sub
End Class
