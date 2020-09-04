Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dim i As Integer = 0

        'Do
        '    MsgBox("Ciclo Do = " + i.ToString)
        '    i += 1
        'Loop While i < 3

        'i = 0

        'Do While i < 3
        '    MsgBox("Ciclo Do While = " + i.ToString)
        '    i = i + 1
        'Loop


        'i = 0

        'While i < 3
        '    MsgBox("Ciclo While = " + i.ToString)
        '    i += 1
        'End While

        Dim i As Integer = 0
        Dim arreglo(5) As Integer

        Do While i < 5
            arreglo(i) = i
            i += 1
        Loop

        i = 0

        While i < 5
            MsgBox("Arreglo(" + i.ToString + ")= " + arreglo(i).ToString)
            i += 1
        End While



    End Sub

End Class
