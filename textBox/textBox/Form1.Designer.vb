<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Programa
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.etiqueta = New System.Windows.Forms.Label()
        Me.texto = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'etiqueta
        '
        Me.etiqueta.AutoSize = True
        Me.etiqueta.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiqueta.Location = New System.Drawing.Point(12, 23)
        Me.etiqueta.Name = "etiqueta"
        Me.etiqueta.Size = New System.Drawing.Size(150, 20)
        Me.etiqueta.TabIndex = 0
        Me.etiqueta.Text = "Ingrese su nombre: "
        '
        'texto
        '
        Me.texto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.texto.Location = New System.Drawing.Point(168, 20)
        Me.texto.Name = "texto"
        Me.texto.Size = New System.Drawing.Size(320, 26)
        Me.texto.TabIndex = 1
        Me.texto.Text = "Nombre"
        Me.texto.WordWrap = False
        '
        'Programa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Honeydew
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(500, 211)
        Me.Controls.Add(Me.texto)
        Me.Controls.Add(Me.etiqueta)
        Me.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "Programa"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text = "Cuadro de Texto"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents etiqueta As Label
    Friend WithEvents texto As Windows.Forms.TextBox
End Class
