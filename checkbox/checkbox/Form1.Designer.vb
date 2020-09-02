<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
<<<<<<< Updated upstream
Partial Class t
=======
Partial Class Form1
>>>>>>> Stashed changes
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
<<<<<<< Updated upstream
        Me.lblPregunta = New System.Windows.Forms.Label()
        Me.rock = New System.Windows.Forms.CheckBox()
        Me.pop = New System.Windows.Forms.CheckBox()
        Me.Clásica = New System.Windows.Forms.CheckBox()
        Me.llanera = New System.Windows.Forms.CheckBox()
        Me.otros = New System.Windows.Forms.CheckBox()
        Me.btnEnviar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblPregunta
        '
        Me.lblPregunta.AutoSize = True
        Me.lblPregunta.Location = New System.Drawing.Point(23, 31)
        Me.lblPregunta.Name = "lblPregunta"
        Me.lblPregunta.Size = New System.Drawing.Size(116, 13)
        Me.lblPregunta.TabIndex = 0
        Me.lblPregunta.Text = "¿Qué música te gusta?"
        '
        'rock
        '
        Me.rock.AutoSize = True
        Me.rock.Location = New System.Drawing.Point(26, 66)
        Me.rock.Name = "rock"
        Me.rock.Size = New System.Drawing.Size(52, 17)
        Me.rock.TabIndex = 1
        Me.rock.Text = "Rock"
        Me.rock.UseVisualStyleBackColor = True
        '
        'pop
        '
        Me.pop.AutoSize = True
        Me.pop.Location = New System.Drawing.Point(26, 89)
        Me.pop.Name = "pop"
        Me.pop.Size = New System.Drawing.Size(45, 17)
        Me.pop.TabIndex = 2
        Me.pop.Text = "Pop"
        Me.pop.UseVisualStyleBackColor = True
        '
        'Clásica
        '
        Me.Clásica.AutoSize = True
        Me.Clásica.Location = New System.Drawing.Point(26, 112)
        Me.Clásica.Name = "Clásica"
        Me.Clásica.Size = New System.Drawing.Size(60, 17)
        Me.Clásica.TabIndex = 3
        Me.Clásica.Text = "Clásica"
        Me.Clásica.UseVisualStyleBackColor = True
        '
        'llanera
        '
        Me.llanera.AutoSize = True
        Me.llanera.Location = New System.Drawing.Point(26, 135)
        Me.llanera.Name = "llanera"
        Me.llanera.Size = New System.Drawing.Size(61, 17)
        Me.llanera.TabIndex = 4
        Me.llanera.Text = "Llanera"
        Me.llanera.UseVisualStyleBackColor = True
        '
        'otros
        '
        Me.otros.AutoSize = True
        Me.otros.Location = New System.Drawing.Point(26, 159)
        Me.otros.Name = "otros"
        Me.otros.Size = New System.Drawing.Size(51, 17)
        Me.otros.TabIndex = 5
        Me.otros.Text = "Otros"
        Me.otros.UseVisualStyleBackColor = True
        '
        'btnEnviar
        '
        Me.btnEnviar.Location = New System.Drawing.Point(85, 194)
        Me.btnEnviar.Name = "btnEnviar"
        Me.btnEnviar.Size = New System.Drawing.Size(75, 23)
        Me.btnEnviar.TabIndex = 6
        Me.btnEnviar.Text = "Enviar"
        Me.btnEnviar.UseVisualStyleBackColor = True
        '
        't
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(251, 247)
        Me.Controls.Add(Me.btnEnviar)
        Me.Controls.Add(Me.otros)
        Me.Controls.Add(Me.llanera)
        Me.Controls.Add(Me.Clásica)
        Me.Controls.Add(Me.pop)
        Me.Controls.Add(Me.rock)
        Me.Controls.Add(Me.lblPregunta)
        Me.Name = "t"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Generos Musicales"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblPregunta As Label
    Friend WithEvents rock As Windows.Forms.CheckBox
    Friend WithEvents pop As Windows.Forms.CheckBox
    Friend WithEvents Clásica As Windows.Forms.CheckBox
    Friend WithEvents llanera As Windows.Forms.CheckBox
    Friend WithEvents otros As Windows.Forms.CheckBox
    Friend WithEvents btnEnviar As Button
=======
        Me.SuspendLayout()
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(477, 450)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

>>>>>>> Stashed changes
End Class
