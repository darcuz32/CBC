<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCiudades
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TB_id_ciudad = New System.Windows.Forms.TextBox()
        Me.CB_estado = New System.Windows.Forms.ComboBox()
        Me.TB_nombre = New System.Windows.Forms.TextBox()
        Me.DGV_ciudades = New System.Windows.Forms.DataGridView()
        Me.BTN_nuevo = New System.Windows.Forms.Button()
        Me.BTN_guardar = New System.Windows.Forms.Button()
        Me.BTN_eliminar = New System.Windows.Forms.Button()
        Me.BTN_salir = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.DGV_ciudades, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "id_Ciudad:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(227, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Estado:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(63, 79)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nombre Ciudad:"
        '
        'TB_id_ciudad
        '
        Me.TB_id_ciudad.Location = New System.Drawing.Point(88, 38)
        Me.TB_id_ciudad.Name = "TB_id_ciudad"
        Me.TB_id_ciudad.Size = New System.Drawing.Size(100, 20)
        Me.TB_id_ciudad.TabIndex = 1
        '
        'CB_estado
        '
        Me.CB_estado.FormattingEnabled = True
        Me.CB_estado.Location = New System.Drawing.Point(276, 38)
        Me.CB_estado.Name = "CB_estado"
        Me.CB_estado.Size = New System.Drawing.Size(170, 21)
        Me.CB_estado.TabIndex = 2
        '
        'TB_nombre
        '
        Me.TB_nombre.Location = New System.Drawing.Point(152, 76)
        Me.TB_nombre.Name = "TB_nombre"
        Me.TB_nombre.Size = New System.Drawing.Size(192, 20)
        Me.TB_nombre.TabIndex = 3
        '
        'DGV_ciudades
        '
        Me.DGV_ciudades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_ciudades.Location = New System.Drawing.Point(12, 136)
        Me.DGV_ciudades.Name = "DGV_ciudades"
        Me.DGV_ciudades.Size = New System.Drawing.Size(448, 150)
        Me.DGV_ciudades.TabIndex = 6
        '
        'BTN_nuevo
        '
        Me.BTN_nuevo.Location = New System.Drawing.Point(24, 303)
        Me.BTN_nuevo.Name = "BTN_nuevo"
        Me.BTN_nuevo.Size = New System.Drawing.Size(75, 23)
        Me.BTN_nuevo.TabIndex = 7
        Me.BTN_nuevo.Text = "&Nuevo"
        Me.BTN_nuevo.UseVisualStyleBackColor = True
        '
        'BTN_guardar
        '
        Me.BTN_guardar.Location = New System.Drawing.Point(138, 303)
        Me.BTN_guardar.Name = "BTN_guardar"
        Me.BTN_guardar.Size = New System.Drawing.Size(75, 23)
        Me.BTN_guardar.TabIndex = 8
        Me.BTN_guardar.Text = "&Guardar"
        Me.BTN_guardar.UseVisualStyleBackColor = True
        '
        'BTN_eliminar
        '
        Me.BTN_eliminar.Location = New System.Drawing.Point(254, 303)
        Me.BTN_eliminar.Name = "BTN_eliminar"
        Me.BTN_eliminar.Size = New System.Drawing.Size(75, 23)
        Me.BTN_eliminar.TabIndex = 9
        Me.BTN_eliminar.Text = "&Eliminar"
        Me.BTN_eliminar.UseVisualStyleBackColor = True
        '
        'BTN_salir
        '
        Me.BTN_salir.Location = New System.Drawing.Point(371, 303)
        Me.BTN_salir.Name = "BTN_salir"
        Me.BTN_salir.Size = New System.Drawing.Size(75, 23)
        Me.BTN_salir.TabIndex = 10
        Me.BTN_salir.Text = "&Salir"
        Me.BTN_salir.UseVisualStyleBackColor = True
        '
        'FormCiudades
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(474, 338)
        Me.Controls.Add(Me.BTN_salir)
        Me.Controls.Add(Me.BTN_eliminar)
        Me.Controls.Add(Me.BTN_guardar)
        Me.Controls.Add(Me.BTN_nuevo)
        Me.Controls.Add(Me.DGV_ciudades)
        Me.Controls.Add(Me.TB_nombre)
        Me.Controls.Add(Me.CB_estado)
        Me.Controls.Add(Me.TB_id_ciudad)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormCiudades"
        Me.Text = "Ciudades"
        CType(Me.DGV_ciudades, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TB_id_ciudad As TextBox
    Friend WithEvents CB_estado As ComboBox
    Friend WithEvents TB_nombre As TextBox
    Friend WithEvents DGV_ciudades As DataGridView
    Friend WithEvents BTN_nuevo As Button
    Friend WithEvents BTN_guardar As Button
    Friend WithEvents BTN_eliminar As Button
    Friend WithEvents BTN_salir As Button
    Friend WithEvents ToolTip1 As ToolTip
End Class
