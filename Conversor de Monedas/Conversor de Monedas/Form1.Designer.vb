<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class conversorMonedas
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.importeMoneda = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.bolivarDolar = New System.Windows.Forms.RadioButton()
        Me.dolarBolivar = New System.Windows.Forms.RadioButton()
        Me.convertir = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblResultado = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ingrese la cantidad"
        '
        'importeMoneda
        '
        Me.importeMoneda.Location = New System.Drawing.Point(12, 49)
        Me.importeMoneda.Name = "importeMoneda"
        Me.importeMoneda.Size = New System.Drawing.Size(306, 20)
        Me.importeMoneda.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.bolivarDolar)
        Me.GroupBox1.Controls.Add(Me.dolarBolivar)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 93)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(306, 114)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Monedas"
        '
        'bolivarDolar
        '
        Me.bolivarDolar.AutoSize = True
        Me.bolivarDolar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bolivarDolar.Location = New System.Drawing.Point(22, 68)
        Me.bolivarDolar.Name = "bolivarDolar"
        Me.bolivarDolar.Size = New System.Drawing.Size(148, 28)
        Me.bolivarDolar.TabIndex = 1
        Me.bolivarDolar.TabStop = True
        Me.bolivarDolar.Text = "Bolívar a Dolar"
        Me.bolivarDolar.UseVisualStyleBackColor = True
        '
        'dolarBolivar
        '
        Me.dolarBolivar.AutoSize = True
        Me.dolarBolivar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dolarBolivar.Location = New System.Drawing.Point(22, 20)
        Me.dolarBolivar.Name = "dolarBolivar"
        Me.dolarBolivar.Size = New System.Drawing.Size(148, 28)
        Me.dolarBolivar.TabIndex = 0
        Me.dolarBolivar.TabStop = True
        Me.dolarBolivar.Text = "Dolar a Bolivar"
        Me.dolarBolivar.UseVisualStyleBackColor = True
        '
        'convertir
        '
        Me.convertir.Location = New System.Drawing.Point(61, 213)
        Me.convertir.Name = "convertir"
        Me.convertir.Size = New System.Drawing.Size(207, 39)
        Me.convertir.TabIndex = 3
        Me.convertir.Text = "Convertir"
        Me.convertir.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(56, 322)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 25)
        Me.Label2.TabIndex = 4
        '
        'lblResultado
        '
        Me.lblResultado.AutoSize = True
        Me.lblResultado.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResultado.Location = New System.Drawing.Point(7, 269)
        Me.lblResultado.Name = "lblResultado"
        Me.lblResultado.Size = New System.Drawing.Size(0, 25)
        Me.lblResultado.TabIndex = 5
        Me.lblResultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(61, 311)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(207, 36)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "Salir"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'conversorMonedas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(330, 359)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblResultado)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.convertir)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.importeMoneda)
        Me.Controls.Add(Me.Label1)
        Me.Name = "conversorMonedas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Conversor de Monedas"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents importeMoneda As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents bolivarDolar As RadioButton
    Friend WithEvents dolarBolivar As RadioButton
    Friend WithEvents convertir As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents lblResultado As Label
    Friend WithEvents btnExit As Button
End Class
