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
        Me.num1 = New System.Windows.Forms.Label()
        Me.num2 = New System.Windows.Forms.Label()
        Me.txtnum1 = New System.Windows.Forms.TextBox()
        Me.txtNum2 = New System.Windows.Forms.TextBox()
        Me.sumar = New System.Windows.Forms.RadioButton()
        Me.restar = New System.Windows.Forms.RadioButton()
        Me.multiplicar = New System.Windows.Forms.RadioButton()
        Me.Dividir = New System.Windows.Forms.RadioButton()
        Me.btnEjecutar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'num1
        '
        Me.num1.AutoSize = True
        Me.num1.Location = New System.Drawing.Point(12, 18)
        Me.num1.Name = "num1"
        Me.num1.Size = New System.Drawing.Size(38, 13)
        Me.num1.TabIndex = 0
        Me.num1.Text = "Num 1"
        '
        'num2
        '
        Me.num2.AutoSize = True
        Me.num2.Location = New System.Drawing.Point(78, 18)
        Me.num2.Name = "num2"
        Me.num2.Size = New System.Drawing.Size(38, 13)
        Me.num2.TabIndex = 1
        Me.num2.Text = "Num 2"
        '
        'txtnum1
        '
        Me.txtnum1.Location = New System.Drawing.Point(15, 35)
        Me.txtnum1.Name = "txtnum1"
        Me.txtnum1.Size = New System.Drawing.Size(57, 20)
        Me.txtnum1.TabIndex = 2
        '
        'txtNum2
        '
        Me.txtNum2.Location = New System.Drawing.Point(81, 35)
        Me.txtNum2.Name = "txtNum2"
        Me.txtNum2.Size = New System.Drawing.Size(57, 20)
        Me.txtNum2.TabIndex = 3
        '
        'sumar
        '
        Me.sumar.AutoSize = True
        Me.sumar.Location = New System.Drawing.Point(15, 62)
        Me.sumar.Name = "sumar"
        Me.sumar.Size = New System.Drawing.Size(55, 17)
        Me.sumar.TabIndex = 4
        Me.sumar.TabStop = True
        Me.sumar.Text = "Sumar"
        Me.sumar.UseVisualStyleBackColor = True
        '
        'restar
        '
        Me.restar.AutoSize = True
        Me.restar.Location = New System.Drawing.Point(15, 85)
        Me.restar.Name = "restar"
        Me.restar.Size = New System.Drawing.Size(56, 17)
        Me.restar.TabIndex = 5
        Me.restar.TabStop = True
        Me.restar.Text = "Restar"
        Me.restar.UseVisualStyleBackColor = True
        '
        'multiplicar
        '
        Me.multiplicar.AutoSize = True
        Me.multiplicar.Location = New System.Drawing.Point(15, 108)
        Me.multiplicar.Name = "multiplicar"
        Me.multiplicar.Size = New System.Drawing.Size(72, 17)
        Me.multiplicar.TabIndex = 6
        Me.multiplicar.TabStop = True
        Me.multiplicar.Text = "Multiplicar"
        Me.multiplicar.UseVisualStyleBackColor = True
        '
        'Dividir
        '
        Me.Dividir.AutoSize = True
        Me.Dividir.Location = New System.Drawing.Point(15, 131)
        Me.Dividir.Name = "Dividir"
        Me.Dividir.Size = New System.Drawing.Size(54, 17)
        Me.Dividir.TabIndex = 7
        Me.Dividir.TabStop = True
        Me.Dividir.Text = "Dividir"
        Me.Dividir.UseVisualStyleBackColor = True
        '
        'btnEjecutar
        '
        Me.btnEjecutar.Location = New System.Drawing.Point(15, 155)
        Me.btnEjecutar.Name = "btnEjecutar"
        Me.btnEjecutar.Size = New System.Drawing.Size(75, 23)
        Me.btnEjecutar.TabIndex = 8
        Me.btnEjecutar.Text = "Ejecutar"
        Me.btnEjecutar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(206, 196)
        Me.Controls.Add(Me.btnEjecutar)
        Me.Controls.Add(Me.Dividir)
        Me.Controls.Add(Me.multiplicar)
        Me.Controls.Add(Me.restar)
        Me.Controls.Add(Me.sumar)
        Me.Controls.Add(Me.txtNum2)
        Me.Controls.Add(Me.txtnum1)
        Me.Controls.Add(Me.num2)
        Me.Controls.Add(Me.num1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Select Case"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents num1 As Label
    Friend WithEvents num2 As Label
    Friend WithEvents txtnum1 As TextBox
    Friend WithEvents txtNum2 As TextBox
    Friend WithEvents sumar As RadioButton
    Friend WithEvents restar As RadioButton
    Friend WithEvents multiplicar As RadioButton
    Friend WithEvents Dividir As RadioButton
    Friend WithEvents btnEjecutar As Button
End Class
