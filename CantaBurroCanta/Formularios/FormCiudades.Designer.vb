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
        Me.Label1.Location = New System.Drawing.Point(33, 50)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "id_Ciudad:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(303, 50)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Estado:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(84, 97)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nombre Ciudad:"
        '
        'TB_id_ciudad
        '
        Me.TB_id_ciudad.Location = New System.Drawing.Point(117, 47)
        Me.TB_id_ciudad.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TB_id_ciudad.Name = "TB_id_ciudad"
        Me.TB_id_ciudad.Size = New System.Drawing.Size(132, 22)
        Me.TB_id_ciudad.TabIndex = 1
        '
        'CB_estado
        '
        Me.CB_estado.FormattingEnabled = True
        Me.CB_estado.Location = New System.Drawing.Point(368, 47)
        Me.CB_estado.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CB_estado.Name = "CB_estado"
        Me.CB_estado.Size = New System.Drawing.Size(225, 24)
        Me.CB_estado.TabIndex = 2
        '
        'TB_nombre
        '
        Me.TB_nombre.Location = New System.Drawing.Point(203, 94)
        Me.TB_nombre.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TB_nombre.Name = "TB_nombre"
        Me.TB_nombre.Size = New System.Drawing.Size(255, 22)
        Me.TB_nombre.TabIndex = 3
        '
        'DGV_ciudades
        '
        Me.DGV_ciudades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_ciudades.Location = New System.Drawing.Point(16, 167)
        Me.DGV_ciudades.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DGV_ciudades.Name = "DGV_ciudades"
        Me.DGV_ciudades.RowHeadersWidth = 51
        Me.DGV_ciudades.Size = New System.Drawing.Size(597, 185)
        Me.DGV_ciudades.TabIndex = 8
        '
        'BTN_nuevo
        '
        Me.BTN_nuevo.Location = New System.Drawing.Point(32, 373)
        Me.BTN_nuevo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BTN_nuevo.Name = "BTN_nuevo"
        Me.BTN_nuevo.Size = New System.Drawing.Size(100, 28)
        Me.BTN_nuevo.TabIndex = 4
        Me.BTN_nuevo.Text = "&Nuevo"
        Me.BTN_nuevo.UseVisualStyleBackColor = True
        '
        'BTN_guardar
        '
        Me.BTN_guardar.Location = New System.Drawing.Point(184, 373)
        Me.BTN_guardar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BTN_guardar.Name = "BTN_guardar"
        Me.BTN_guardar.Size = New System.Drawing.Size(100, 28)
        Me.BTN_guardar.TabIndex = 5
        Me.BTN_guardar.Text = "&Guardar"
        Me.BTN_guardar.UseVisualStyleBackColor = True
        '
        'BTN_eliminar
        '
        Me.BTN_eliminar.Location = New System.Drawing.Point(339, 373)
        Me.BTN_eliminar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BTN_eliminar.Name = "BTN_eliminar"
        Me.BTN_eliminar.Size = New System.Drawing.Size(100, 28)
        Me.BTN_eliminar.TabIndex = 6
        Me.BTN_eliminar.Text = "&Eliminar"
        Me.BTN_eliminar.UseVisualStyleBackColor = True
        '
        'BTN_salir
        '
        Me.BTN_salir.Location = New System.Drawing.Point(495, 373)
        Me.BTN_salir.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BTN_salir.Name = "BTN_salir"
        Me.BTN_salir.Size = New System.Drawing.Size(100, 28)
        Me.BTN_salir.TabIndex = 7
        Me.BTN_salir.Text = "&Salir"
        Me.BTN_salir.UseVisualStyleBackColor = True
        '
        'FormCiudades
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(632, 416)
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
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
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
