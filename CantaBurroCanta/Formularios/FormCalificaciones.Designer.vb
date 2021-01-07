<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCalificaciones
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
        Me.CB_juez = New System.Windows.Forms.ComboBox()
        Me.CB_categoria = New System.Windows.Forms.ComboBox()
        Me.CB_participante = New System.Windows.Forms.ComboBox()
        Me.BTN_salir = New System.Windows.Forms.Button()
        Me.BTN_eliminar = New System.Windows.Forms.Button()
        Me.BTN_guardar = New System.Windows.Forms.Button()
        Me.LBL_auditorio = New System.Windows.Forms.Label()
        Me.TB_calificacion = New System.Windows.Forms.TextBox()
        Me.LBL_paterno = New System.Windows.Forms.Label()
        Me.LBL_categoria = New System.Windows.Forms.Label()
        Me.LBL_participante = New System.Windows.Forms.Label()
        Me.DGV_calificaciones = New System.Windows.Forms.DataGridView()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.DGV_calificaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BTN_nuevo
        '
        Me.BTN_nuevo.Location = New System.Drawing.Point(119, 385)
        Me.BTN_nuevo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BTN_nuevo.Name = "BTN_nuevo"
        Me.BTN_nuevo.Size = New System.Drawing.Size(91, 34)
        Me.BTN_nuevo.TabIndex = 5
        Me.BTN_nuevo.Text = "&Nuevo"
        Me.BTN_nuevo.UseVisualStyleBackColor = True
        Me.BTN_nuevo.UseWaitCursor = True
        '
        'CB_juez
        '
        Me.CB_juez.FormattingEnabled = True
        Me.CB_juez.Location = New System.Drawing.Point(191, 91)
        Me.CB_juez.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CB_juez.Name = "CB_juez"
        Me.CB_juez.Size = New System.Drawing.Size(153, 24)
        Me.CB_juez.TabIndex = 3
        Me.CB_juez.UseWaitCursor = True
        '
        'CB_categoria
        '
        Me.CB_categoria.FormattingEnabled = True
        Me.CB_categoria.Location = New System.Drawing.Point(491, 31)
        Me.CB_categoria.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CB_categoria.Name = "CB_categoria"
        Me.CB_categoria.Size = New System.Drawing.Size(153, 24)
        Me.CB_categoria.TabIndex = 2
        Me.CB_categoria.UseWaitCursor = True
        '
        'CB_participante
        '
        Me.CB_participante.FormattingEnabled = True
        Me.CB_participante.Location = New System.Drawing.Point(191, 31)
        Me.CB_participante.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CB_participante.Name = "CB_participante"
        Me.CB_participante.Size = New System.Drawing.Size(153, 24)
        Me.CB_participante.TabIndex = 1
        Me.CB_participante.UseWaitCursor = True
        '
        'BTN_salir
        '
        Me.BTN_salir.Location = New System.Drawing.Point(555, 385)
        Me.BTN_salir.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BTN_salir.Name = "BTN_salir"
        Me.BTN_salir.Size = New System.Drawing.Size(91, 34)
        Me.BTN_salir.TabIndex = 8
        Me.BTN_salir.Text = "&Salir"
        Me.BTN_salir.UseVisualStyleBackColor = True
        Me.BTN_salir.UseWaitCursor = True
        '
        'BTN_eliminar
        '
        Me.BTN_eliminar.Location = New System.Drawing.Point(409, 385)
        Me.BTN_eliminar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BTN_eliminar.Name = "BTN_eliminar"
        Me.BTN_eliminar.Size = New System.Drawing.Size(87, 34)
        Me.BTN_eliminar.TabIndex = 7
        Me.BTN_eliminar.Text = "&Eliminar"
        Me.BTN_eliminar.UseVisualStyleBackColor = True
        Me.BTN_eliminar.UseWaitCursor = True
        '
        'BTN_guardar
        '
        Me.BTN_guardar.Location = New System.Drawing.Point(264, 385)
        Me.BTN_guardar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BTN_guardar.Name = "BTN_guardar"
        Me.BTN_guardar.Size = New System.Drawing.Size(91, 34)
        Me.BTN_guardar.TabIndex = 6
        Me.BTN_guardar.Text = "&Guardar"
        Me.BTN_guardar.UseVisualStyleBackColor = True
        Me.BTN_guardar.UseWaitCursor = True
        '
        'LBL_auditorio
        '
        Me.LBL_auditorio.AutoSize = True
        Me.LBL_auditorio.Location = New System.Drawing.Point(125, 94)
        Me.LBL_auditorio.Name = "LBL_auditorio"
        Me.LBL_auditorio.Size = New System.Drawing.Size(42, 17)
        Me.LBL_auditorio.TabIndex = 49
        Me.LBL_auditorio.Text = "Juez:"
        Me.LBL_auditorio.UseWaitCursor = True
        '
        'TB_calificacion
        '
        Me.TB_calificacion.Location = New System.Drawing.Point(491, 94)
        Me.TB_calificacion.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TB_calificacion.MaxLength = 2
        Me.TB_calificacion.Name = "TB_calificacion"
        Me.TB_calificacion.Size = New System.Drawing.Size(153, 22)
        Me.TB_calificacion.TabIndex = 4
        Me.TB_calificacion.UseWaitCursor = True
        '
        'LBL_paterno
        '
        Me.LBL_paterno.AutoSize = True
        Me.LBL_paterno.Location = New System.Drawing.Point(401, 94)
        Me.LBL_paterno.Name = "LBL_paterno"
        Me.LBL_paterno.Size = New System.Drawing.Size(83, 17)
        Me.LBL_paterno.TabIndex = 47
        Me.LBL_paterno.Text = "Calificación:"
        Me.LBL_paterno.UseWaitCursor = True
        '
        'LBL_categoria
        '
        Me.LBL_categoria.AutoSize = True
        Me.LBL_categoria.Location = New System.Drawing.Point(415, 34)
        Me.LBL_categoria.Name = "LBL_categoria"
        Me.LBL_categoria.Size = New System.Drawing.Size(73, 17)
        Me.LBL_categoria.TabIndex = 46
        Me.LBL_categoria.Text = "Categoria:"
        Me.LBL_categoria.UseWaitCursor = True
        '
        'LBL_participante
        '
        Me.LBL_participante.AutoSize = True
        Me.LBL_participante.Location = New System.Drawing.Point(96, 34)
        Me.LBL_participante.Name = "LBL_participante"
        Me.LBL_participante.Size = New System.Drawing.Size(87, 17)
        Me.LBL_participante.TabIndex = 45
        Me.LBL_participante.Text = "Participante:"
        Me.LBL_participante.UseWaitCursor = True
        '
        'DGV_calificaciones
        '
        Me.DGV_calificaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_calificaciones.Location = New System.Drawing.Point(51, 133)
        Me.DGV_calificaciones.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DGV_calificaciones.Name = "DGV_calificaciones"
        Me.DGV_calificaciones.RowHeadersWidth = 51
        Me.DGV_calificaciones.RowTemplate.Height = 24
        Me.DGV_calificaciones.Size = New System.Drawing.Size(699, 217)
        Me.DGV_calificaciones.TabIndex = 9
        Me.DGV_calificaciones.UseWaitCursor = True
        '
        'FormCalificaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BTN_nuevo)
        Me.Controls.Add(Me.CB_juez)
        Me.Controls.Add(Me.CB_categoria)
        Me.Controls.Add(Me.CB_participante)
        Me.Controls.Add(Me.BTN_salir)
        Me.Controls.Add(Me.BTN_eliminar)
        Me.Controls.Add(Me.BTN_guardar)
        Me.Controls.Add(Me.LBL_auditorio)
        Me.Controls.Add(Me.TB_calificacion)
        Me.Controls.Add(Me.LBL_paterno)
        Me.Controls.Add(Me.LBL_categoria)
        Me.Controls.Add(Me.LBL_participante)
        Me.Controls.Add(Me.DGV_calificaciones)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "FormCalificaciones"
        Me.Text = "Agregar calificación"
        CType(Me.DGV_calificaciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BTN_nuevo As Button
    Friend WithEvents CB_juez As ComboBox
    Friend WithEvents CB_categoria As ComboBox
    Friend WithEvents CB_participante As ComboBox
    Friend WithEvents BTN_salir As Button
    Friend WithEvents BTN_eliminar As Button
    Friend WithEvents BTN_guardar As Button
    Friend WithEvents LBL_auditorio As Label
    Friend WithEvents TB_calificacion As TextBox
    Friend WithEvents LBL_paterno As Label
    Friend WithEvents LBL_categoria As Label
    Friend WithEvents LBL_participante As Label
    Friend WithEvents DGV_calificaciones As DataGridView
    Friend WithEvents ToolTip1 As ToolTip
End Class
