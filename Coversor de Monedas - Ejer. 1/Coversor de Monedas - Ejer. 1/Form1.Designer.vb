<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rdBsDolar = New System.Windows.Forms.RadioButton()
        Me.rdDolarBs = New System.Windows.Forms.RadioButton()
        Me.lblSeleccionConversion = New System.Windows.Forms.Label()
        Me.lblValorReferencia = New System.Windows.Forms.Label()
        Me.txtReferenciaDolar = New System.Windows.Forms.TextBox()
        Me.lblResultadoConversion = New System.Windows.Forms.Label()
        Me.lblCantidad = New System.Windows.Forms.Label()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.btnConvertir = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rdBsDolar)
        Me.GroupBox1.Controls.Add(Me.rdDolarBs)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 155)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(260, 89)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'rdBsDolar
        '
        Me.rdBsDolar.AutoSize = True
        Me.rdBsDolar.Location = New System.Drawing.Point(7, 55)
        Me.rdBsDolar.Name = "rdBsDolar"
        Me.rdBsDolar.Size = New System.Drawing.Size(96, 17)
        Me.rdBsDolar.TabIndex = 1
        Me.rdBsDolar.TabStop = True
        Me.rdBsDolar.Text = "Bolívar a Dolar"
        Me.rdBsDolar.UseVisualStyleBackColor = True
        '
        'rdDolarBs
        '
        Me.rdDolarBs.AutoSize = True
        Me.rdDolarBs.Location = New System.Drawing.Point(7, 20)
        Me.rdDolarBs.Name = "rdDolarBs"
        Me.rdDolarBs.Size = New System.Drawing.Size(96, 17)
        Me.rdDolarBs.TabIndex = 0
        Me.rdDolarBs.TabStop = True
        Me.rdDolarBs.Text = "Dolar a Bolívar"
        Me.rdDolarBs.UseVisualStyleBackColor = True
        '
        'lblSeleccionConversion
        '
        Me.lblSeleccionConversion.AutoSize = True
        Me.lblSeleccionConversion.Location = New System.Drawing.Point(9, 139)
        Me.lblSeleccionConversion.Name = "lblSeleccionConversion"
        Me.lblSeleccionConversion.Size = New System.Drawing.Size(165, 13)
        Me.lblSeleccionConversion.TabIndex = 1
        Me.lblSeleccionConversion.Text = "Selecciona la moneda a convertir"
        '
        'lblValorReferencia
        '
        Me.lblValorReferencia.AutoSize = True
        Me.lblValorReferencia.Location = New System.Drawing.Point(9, 21)
        Me.lblValorReferencia.Name = "lblValorReferencia"
        Me.lblValorReferencia.Size = New System.Drawing.Size(149, 13)
        Me.lblValorReferencia.TabIndex = 2
        Me.lblValorReferencia.Text = "Ingrese el valor de Referencia"
        '
        'txtReferenciaDolar
        '
        Me.txtReferenciaDolar.Location = New System.Drawing.Point(12, 46)
        Me.txtReferenciaDolar.Name = "txtReferenciaDolar"
        Me.txtReferenciaDolar.Size = New System.Drawing.Size(260, 20)
        Me.txtReferenciaDolar.TabIndex = 3
        '
        'lblResultadoConversion
        '
        Me.lblResultadoConversion.AutoSize = True
        Me.lblResultadoConversion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResultadoConversion.Location = New System.Drawing.Point(8, 309)
        Me.lblResultadoConversion.Name = "lblResultadoConversion"
        Me.lblResultadoConversion.Size = New System.Drawing.Size(91, 20)
        Me.lblResultadoConversion.TabIndex = 4
        Me.lblResultadoConversion.Text = "Resultado"
        '
        'lblCantidad
        '
        Me.lblCantidad.AutoSize = True
        Me.lblCantidad.Location = New System.Drawing.Point(9, 83)
        Me.lblCantidad.Name = "lblCantidad"
        Me.lblCantidad.Size = New System.Drawing.Size(101, 13)
        Me.lblCantidad.TabIndex = 5
        Me.lblCantidad.Text = "Ingrese la Cantidad "
        '
        'txtCantidad
        '
        Me.txtCantidad.Location = New System.Drawing.Point(12, 99)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(260, 20)
        Me.txtCantidad.TabIndex = 6
        '
        'btnConvertir
        '
        Me.btnConvertir.Location = New System.Drawing.Point(12, 251)
        Me.btnConvertir.Name = "btnConvertir"
        Me.btnConvertir.Size = New System.Drawing.Size(260, 41)
        Me.btnConvertir.TabIndex = 7
        Me.btnConvertir.Text = "Convertir"
        Me.btnConvertir.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 346)
        Me.Controls.Add(Me.btnConvertir)
        Me.Controls.Add(Me.txtCantidad)
        Me.Controls.Add(Me.lblCantidad)
        Me.Controls.Add(Me.lblResultadoConversion)
        Me.Controls.Add(Me.txtReferenciaDolar)
        Me.Controls.Add(Me.lblValorReferencia)
        Me.Controls.Add(Me.lblSeleccionConversion)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Conversor de Monedas"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rdBsDolar As RadioButton
    Friend WithEvents rdDolarBs As RadioButton
    Friend WithEvents lblSeleccionConversion As Label
    Friend WithEvents lblValorReferencia As Label
    Friend WithEvents txtReferenciaDolar As TextBox
    Friend WithEvents lblResultadoConversion As Label
    Friend WithEvents lblCantidad As Label
    Friend WithEvents txtCantidad As TextBox
    Friend WithEvents btnConvertir As Button
End Class
