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
        Me.suma = New System.Windows.Forms.RadioButton()
        Me.resta = New System.Windows.Forms.RadioButton()
        Me.Multiplicacion = New System.Windows.Forms.RadioButton()
        Me.division = New System.Windows.Forms.RadioButton()
        Me.num1 = New System.Windows.Forms.TextBox()
        Me.num2 = New System.Windows.Forms.TextBox()
        Me.operacion = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.operacion)
        Me.GroupBox1.Controls.Add(Me.num2)
        Me.GroupBox1.Controls.Add(Me.num1)
        Me.GroupBox1.Controls.Add(Me.division)
        Me.GroupBox1.Controls.Add(Me.Multiplicacion)
        Me.GroupBox1.Controls.Add(Me.resta)
        Me.GroupBox1.Controls.Add(Me.suma)
        Me.GroupBox1.Location = New System.Drawing.Point(24, 24)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(275, 120)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'suma
        '
        Me.suma.AutoSize = True
        Me.suma.Location = New System.Drawing.Point(6, 19)
        Me.suma.Name = "suma"
        Me.suma.Size = New System.Drawing.Size(52, 17)
        Me.suma.TabIndex = 0
        Me.suma.TabStop = True
        Me.suma.Text = "Suma"
        Me.suma.UseVisualStyleBackColor = True
        '
        'resta
        '
        Me.resta.AutoSize = True
        Me.resta.Location = New System.Drawing.Point(7, 43)
        Me.resta.Name = "resta"
        Me.resta.Size = New System.Drawing.Size(53, 17)
        Me.resta.TabIndex = 1
        Me.resta.TabStop = True
        Me.resta.Text = "Resta"
        Me.resta.UseVisualStyleBackColor = True
        '
        'Multiplicacion
        '
        Me.Multiplicacion.AutoSize = True
        Me.Multiplicacion.Location = New System.Drawing.Point(6, 67)
        Me.Multiplicacion.Name = "Multiplicacion"
        Me.Multiplicacion.Size = New System.Drawing.Size(89, 17)
        Me.Multiplicacion.TabIndex = 2
        Me.Multiplicacion.TabStop = True
        Me.Multiplicacion.Text = "Multiplicación"
        Me.Multiplicacion.UseVisualStyleBackColor = True
        '
        'division
        '
        Me.division.AutoSize = True
        Me.division.Location = New System.Drawing.Point(6, 91)
        Me.division.Name = "division"
        Me.division.Size = New System.Drawing.Size(62, 17)
        Me.division.TabIndex = 3
        Me.division.TabStop = True
        Me.division.Text = "División"
        Me.division.UseVisualStyleBackColor = True
        '
        'num1
        '
        Me.num1.Location = New System.Drawing.Point(151, 19)
        Me.num1.Name = "num1"
        Me.num1.Size = New System.Drawing.Size(100, 20)
        Me.num1.TabIndex = 4
        '
        'num2
        '
        Me.num2.Location = New System.Drawing.Point(151, 45)
        Me.num2.Name = "num2"
        Me.num2.Size = New System.Drawing.Size(100, 20)
        Me.num2.TabIndex = 5
        '
        'operacion
        '
        Me.operacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.operacion.Location = New System.Drawing.Point(151, 85)
        Me.operacion.Name = "operacion"
        Me.operacion.Size = New System.Drawing.Size(100, 23)
        Me.operacion.TabIndex = 1
        Me.operacion.Text = "Ejecutar"
        Me.operacion.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(322, 163)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Radio Buttom"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents operacion As Button
    Friend WithEvents num2 As TextBox
    Friend WithEvents num1 As TextBox
    Friend WithEvents division As Windows.Forms.RadioButton
    Friend WithEvents Multiplicacion As Windows.Forms.RadioButton
    Friend WithEvents resta As Windows.Forms.RadioButton
    Friend WithEvents suma As Windows.Forms.RadioButton
End Class
