<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCarreras
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
        Me.BTN_nuevo = New System.Windows.Forms.Button()
        Me.BTN_salir = New System.Windows.Forms.Button()
        Me.BTN_eliminar = New System.Windows.Forms.Button()
        Me.BTN_guardar = New System.Windows.Forms.Button()
        Me.TB_desc_carrera = New System.Windows.Forms.TextBox()
        Me.LBL_nombre = New System.Windows.Forms.Label()
        Me.TB_id_carrera = New System.Windows.Forms.TextBox()
        Me.LBL_id_participante = New System.Windows.Forms.Label()
        Me.DGV_carreras = New System.Windows.Forms.DataGridView()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.DGV_carreras, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BTN_nuevo
        '
        Me.BTN_nuevo.Location = New System.Drawing.Point(76, 363)
        Me.BTN_nuevo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BTN_nuevo.Name = "BTN_nuevo"
        Me.BTN_nuevo.Size = New System.Drawing.Size(91, 34)
        Me.BTN_nuevo.TabIndex = 50
        Me.BTN_nuevo.Text = "&Nuevo"
        Me.BTN_nuevo.UseVisualStyleBackColor = True
        '
        'BTN_salir
        '
        Me.BTN_salir.Location = New System.Drawing.Point(620, 363)
        Me.BTN_salir.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BTN_salir.Name = "BTN_salir"
        Me.BTN_salir.Size = New System.Drawing.Size(91, 34)
        Me.BTN_salir.TabIndex = 49
        Me.BTN_salir.Text = "&Salir"
        Me.BTN_salir.UseVisualStyleBackColor = True
        '
        'BTN_eliminar
        '
        Me.BTN_eliminar.Location = New System.Drawing.Point(453, 363)
        Me.BTN_eliminar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BTN_eliminar.Name = "BTN_eliminar"
        Me.BTN_eliminar.Size = New System.Drawing.Size(87, 34)
        Me.BTN_eliminar.TabIndex = 48
        Me.BTN_eliminar.Text = "&Eliminar"
        Me.BTN_eliminar.UseVisualStyleBackColor = True
        '
        'BTN_guardar
        '
        Me.BTN_guardar.Location = New System.Drawing.Point(273, 363)
        Me.BTN_guardar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BTN_guardar.Name = "BTN_guardar"
        Me.BTN_guardar.Size = New System.Drawing.Size(91, 34)
        Me.BTN_guardar.TabIndex = 47
        Me.BTN_guardar.Text = "&Guardar"
        Me.BTN_guardar.UseVisualStyleBackColor = True
        '
        'TB_desc_carrera
        '
        Me.TB_desc_carrera.Location = New System.Drawing.Point(515, 54)
        Me.TB_desc_carrera.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TB_desc_carrera.Name = "TB_desc_carrera"
        Me.TB_desc_carrera.Size = New System.Drawing.Size(153, 22)
        Me.TB_desc_carrera.TabIndex = 46
        '
        'LBL_nombre
        '
        Me.LBL_nombre.AutoSize = True
        Me.LBL_nombre.Location = New System.Drawing.Point(423, 54)
        Me.LBL_nombre.Name = "LBL_nombre"
        Me.LBL_nombre.Size = New System.Drawing.Size(86, 17)
        Me.LBL_nombre.TabIndex = 45
        Me.LBL_nombre.Text = "Descripción:"
        '
        'TB_id_carrera
        '
        Me.TB_id_carrera.Location = New System.Drawing.Point(223, 56)
        Me.TB_id_carrera.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TB_id_carrera.Name = "TB_id_carrera"
        Me.TB_id_carrera.Size = New System.Drawing.Size(153, 22)
        Me.TB_id_carrera.TabIndex = 44
        '
        'LBL_id_participante
        '
        Me.LBL_id_participante.AutoSize = True
        Me.LBL_id_participante.Location = New System.Drawing.Point(108, 56)
        Me.LBL_id_participante.Name = "LBL_id_participante"
        Me.LBL_id_participante.Size = New System.Drawing.Size(75, 17)
        Me.LBL_id_participante.TabIndex = 43
        Me.LBL_id_participante.Text = "Id Carrera:"
        '
        'DGV_carreras
        '
        Me.DGV_carreras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_carreras.Location = New System.Drawing.Point(49, 115)
        Me.DGV_carreras.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DGV_carreras.Name = "DGV_carreras"
        Me.DGV_carreras.RowHeadersWidth = 51
        Me.DGV_carreras.RowTemplate.Height = 24
        Me.DGV_carreras.Size = New System.Drawing.Size(702, 217)
        Me.DGV_carreras.TabIndex = 42
        '
        'FormCarreras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BTN_nuevo)
        Me.Controls.Add(Me.BTN_salir)
        Me.Controls.Add(Me.BTN_eliminar)
        Me.Controls.Add(Me.BTN_guardar)
        Me.Controls.Add(Me.TB_desc_carrera)
        Me.Controls.Add(Me.LBL_nombre)
        Me.Controls.Add(Me.TB_id_carrera)
        Me.Controls.Add(Me.LBL_id_participante)
        Me.Controls.Add(Me.DGV_carreras)
        Me.Name = "FormCarreras"
        Me.Text = "Agregar carrera"
        CType(Me.DGV_carreras, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BTN_nuevo As Button
    Friend WithEvents BTN_salir As Button
    Friend WithEvents BTN_eliminar As Button
    Friend WithEvents BTN_guardar As Button
    Friend WithEvents TB_desc_carrera As TextBox
    Friend WithEvents LBL_nombre As Label
    Friend WithEvents TB_id_carrera As TextBox
    Friend WithEvents LBL_id_participante As Label
    Friend WithEvents DGV_carreras As DataGridView
    Friend WithEvents ToolTip1 As ToolTip
End Class
