<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormColonias
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
        Me.TB_id_colonia = New System.Windows.Forms.TextBox()
        Me.CB_ciudad = New System.Windows.Forms.ComboBox()
        Me.TB_nombre = New System.Windows.Forms.TextBox()
        Me.DGV_colonias = New System.Windows.Forms.DataGridView()
        Me.BTN_nuevo = New System.Windows.Forms.Button()
        Me.BTN_guardar = New System.Windows.Forms.Button()
        Me.BTN_eliminar = New System.Windows.Forms.Button()
        Me.BTN_salir = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.CB_estados = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.DGV_colonias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 90)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID Colonia:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(325, 47)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Ciudad:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(243, 90)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(113, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nombre Colonia:"
        '
        'TB_id_colonia
        '
        Me.TB_id_colonia.Location = New System.Drawing.Point(101, 86)
        Me.TB_id_colonia.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TB_id_colonia.Name = "TB_id_colonia"
        Me.TB_id_colonia.Size = New System.Drawing.Size(132, 22)
        Me.TB_id_colonia.TabIndex = 3
        '
        'CB_ciudad
        '
        Me.CB_ciudad.FormattingEnabled = True
        Me.CB_ciudad.Location = New System.Drawing.Point(391, 37)
        Me.CB_ciudad.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CB_ciudad.Name = "CB_ciudad"
        Me.CB_ciudad.Size = New System.Drawing.Size(224, 24)
        Me.CB_ciudad.TabIndex = 2
        '
        'TB_nombre
        '
        Me.TB_nombre.Location = New System.Drawing.Point(359, 86)
        Me.TB_nombre.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TB_nombre.Name = "TB_nombre"
        Me.TB_nombre.Size = New System.Drawing.Size(256, 22)
        Me.TB_nombre.TabIndex = 4
        '
        'DGV_colonias
        '
        Me.DGV_colonias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_colonias.Location = New System.Drawing.Point(16, 167)
        Me.DGV_colonias.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DGV_colonias.Name = "DGV_colonias"
        Me.DGV_colonias.RowHeadersWidth = 51
        Me.DGV_colonias.Size = New System.Drawing.Size(600, 186)
        Me.DGV_colonias.TabIndex = 9
        '
        'BTN_nuevo
        '
        Me.BTN_nuevo.Location = New System.Drawing.Point(32, 374)
        Me.BTN_nuevo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BTN_nuevo.Name = "BTN_nuevo"
        Me.BTN_nuevo.Size = New System.Drawing.Size(100, 28)
        Me.BTN_nuevo.TabIndex = 5
        Me.BTN_nuevo.Text = "&Nuevo"
        Me.BTN_nuevo.UseVisualStyleBackColor = True
        '
        'BTN_guardar
        '
        Me.BTN_guardar.Location = New System.Drawing.Point(184, 374)
        Me.BTN_guardar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BTN_guardar.Name = "BTN_guardar"
        Me.BTN_guardar.Size = New System.Drawing.Size(100, 28)
        Me.BTN_guardar.TabIndex = 6
        Me.BTN_guardar.Text = "&Guardar"
        Me.BTN_guardar.UseVisualStyleBackColor = True
        '
        'BTN_eliminar
        '
        Me.BTN_eliminar.Location = New System.Drawing.Point(339, 374)
        Me.BTN_eliminar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BTN_eliminar.Name = "BTN_eliminar"
        Me.BTN_eliminar.Size = New System.Drawing.Size(100, 28)
        Me.BTN_eliminar.TabIndex = 7
        Me.BTN_eliminar.Text = "&Eliminar"
        Me.BTN_eliminar.UseVisualStyleBackColor = True
        '
        'BTN_salir
        '
        Me.BTN_salir.Location = New System.Drawing.Point(495, 374)
        Me.BTN_salir.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BTN_salir.Name = "BTN_salir"
        Me.BTN_salir.Size = New System.Drawing.Size(100, 28)
        Me.BTN_salir.TabIndex = 8
        Me.BTN_salir.Text = "&Salir"
        Me.BTN_salir.UseVisualStyleBackColor = True
        '
        'CB_estados
        '
        Me.CB_estados.FormattingEnabled = True
        Me.CB_estados.Location = New System.Drawing.Point(88, 37)
        Me.CB_estados.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CB_estados.Name = "CB_estados"
        Me.CB_estados.Size = New System.Drawing.Size(224, 24)
        Me.CB_estados.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(28, 44)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 17)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Estado:"
        '
        'FormColonias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(632, 417)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.CB_estados)
        Me.Controls.Add(Me.BTN_salir)
        Me.Controls.Add(Me.BTN_eliminar)
        Me.Controls.Add(Me.BTN_guardar)
        Me.Controls.Add(Me.BTN_nuevo)
        Me.Controls.Add(Me.DGV_colonias)
        Me.Controls.Add(Me.TB_nombre)
        Me.Controls.Add(Me.CB_ciudad)
        Me.Controls.Add(Me.TB_id_colonia)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "FormColonias"
        Me.Text = "Colonias"
        CType(Me.DGV_colonias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TB_id_colonia As TextBox
    Friend WithEvents CB_ciudad As ComboBox
    Friend WithEvents TB_nombre As TextBox
    Friend WithEvents DGV_colonias As DataGridView
    Friend WithEvents BTN_nuevo As Button
    Friend WithEvents BTN_guardar As Button
    Friend WithEvents BTN_eliminar As Button
    Friend WithEvents BTN_salir As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents CB_estados As ComboBox
    Friend WithEvents Label4 As Label
End Class
