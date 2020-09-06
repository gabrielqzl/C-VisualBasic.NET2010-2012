Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim dt As DataTable = New DataTable("tabla")

        dt.Columns.Add("Codigo")
        dt.Columns.Add("Descripcion")

        Dim dr As DataRow

        dr = dt.NewRow()

        dr("Codigo") = 0
        dr("Descripcion") = "Masculino"
        dt.Rows.Add(dr)

        dr = dt.NewRow()

        dr("Codigo") = 1
        dr("Descripcion") = "Femenino"
        dt.Rows.Add(dr)

        cmbGenero.DataSource = dt
        cmbGenero.ValueMember = "Codigo"
        cmbGenero.DisplayMember = "Descripcion"

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox(cmbGenero.SelectedValue.ToString)
    End Sub
End Class
