Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        MsgBox(e.KeyChar.ToString)


        If e.KeyChar.ToString = "a" Then
            MsgBox("A presionado la tecla a")
        End If


    End Sub
End Class
