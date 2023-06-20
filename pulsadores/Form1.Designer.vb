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
        Me.components = New System.ComponentModel.Container()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.btnGo = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btnVentanaResultados = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'SerialPort1
        '
        Me.SerialPort1.PortName = "COM5"
        Me.SerialPort1.ReadTimeout = 1000
        '
        'btnGo
        '
        Me.btnGo.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btnGo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGo.Font = New System.Drawing.Font("28 Days Later", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGo.Location = New System.Drawing.Point(12, 100)
        Me.btnGo.Name = "btnGo"
        Me.btnGo.Size = New System.Drawing.Size(259, 82)
        Me.btnGo.TabIndex = 0
        Me.btnGo.Text = "Go!"
        Me.btnGo.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        '
        'btnVentanaResultados
        '
        Me.btnVentanaResultados.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btnVentanaResultados.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVentanaResultados.Font = New System.Drawing.Font("28 Days Later", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVentanaResultados.Location = New System.Drawing.Point(12, 12)
        Me.btnVentanaResultados.Name = "btnVentanaResultados"
        Me.btnVentanaResultados.Size = New System.Drawing.Size(259, 82)
        Me.btnVentanaResultados.TabIndex = 1
        Me.btnVentanaResultados.Text = "Ventana resultados"
        Me.btnVentanaResultados.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("28 Days Later", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(12, 188)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(259, 89)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Reset"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1068, 610)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnVentanaResultados)
        Me.Controls.Add(Me.btnGo)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents btnGo As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents btnVentanaResultados As Button
    Friend WithEvents Button1 As Button
End Class
