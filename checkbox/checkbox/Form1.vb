Public Class t
    Private Sub btnEnviar_Click(sender As Object, e As EventArgs) Handles btnEnviar.Click

        Dim rock, pop, clasica, llanera, otros As Boolean

        If Me.rock.Checked = True Then
            rock = True
        Else
            rock = False
        End If

        If Me.pop.Checked = True Then
            pop = True
        Else
            pop = False
        End If

        If Me.Clásica.Checked = True Then
            clasica = True
        Else
            clasica = False
        End If

        If Me.llanera.Checked = True Then
            llanera = True
        Else
            llanera = False
        End If

        If Me.otros.Checked = True Then
            otros = True
        Else
            otros = False
        End If

        MsgBox("Generos seleccionados: ")
        If rock = True Then
            MsgBox("Rock")
        End If

        If pop = True Then
            MsgBox("Pop")
        End If

        If clasica = True Then
            MsgBox("Clásica")
        End If

        If llanera = True Then
            MsgBox("Llanera")
        End If

        If otros = True Then
            MsgBox("Otros")
        End If

    End Sub
End Class
