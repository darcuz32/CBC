<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormProgramaParticipantes
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
        Me.BTN_salir = New System.Windows.Forms.Button()
        Me.BTN_eliminar = New System.Windows.Forms.Button()
        Me.BTN_guardar = New System.Windows.Forms.Button()
        Me.LBL_auditorio = New System.Windows.Forms.Label()
        Me.TB_fecha = New System.Windows.Forms.TextBox()
        Me.LBL_paterno = New System.Windows.Forms.Label()
        Me.LBL_categoria = New System.Windows.Forms.Label()
        Me.LBL_participante = New System.Windows.Forms.Label()
        Me.DGV_programa = New System.Windows.Forms.DataGridView()
        Me.CB_participante = New System.Windows.Forms.ComboBox()
        Me.CB_categoria = New System.Windows.Forms.ComboBox()
        Me.CB_auditorio = New System.Windows.Forms.ComboBox()
        Me.BTN_nuevo = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.DGV_programa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BTN_salir
        '
        Me.BTN_salir.Location = New System.Drawing.Point(541, 384)
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
        Me.BTN_eliminar.Location = New System.Drawing.Point(396, 384)
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
        Me.BTN_guardar.Location = New System.Drawing.Point(251, 384)
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
        Me.LBL_auditorio.Location = New System.Drawing.Point(112, 94)
        Me.LBL_auditorio.Name = "LBL_auditorio"
        Me.LBL_auditorio.Size = New System.Drawing.Size(68, 17)
        Me.LBL_auditorio.TabIndex = 27
        Me.LBL_auditorio.Text = "Auditorio:"
        Me.LBL_auditorio.UseWaitCursor = True
        '
        'TB_fecha
        '
        Me.TB_fecha.Location = New System.Drawing.Point(477, 92)
        Me.TB_fecha.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TB_fecha.Name = "TB_fecha"
        Me.TB_fecha.Size = New System.Drawing.Size(153, 22)
        Me.TB_fecha.TabIndex = 4
        Me.TB_fecha.UseWaitCursor = True
        '
        'LBL_paterno
        '
        Me.LBL_paterno.AutoSize = True
        Me.LBL_paterno.Location = New System.Drawing.Point(403, 90)
        Me.LBL_paterno.Name = "LBL_paterno"
        Me.LBL_paterno.Size = New System.Drawing.Size(51, 17)
        Me.LBL_paterno.TabIndex = 25
        Me.LBL_paterno.Text = "Fecha:"
        Me.LBL_paterno.UseWaitCursor = True
        '
        'LBL_categoria
        '
        Me.LBL_categoria.AutoSize = True
        Me.LBL_categoria.Location = New System.Drawing.Point(403, 33)
        Me.LBL_categoria.Name = "LBL_categoria"
        Me.LBL_categoria.Size = New System.Drawing.Size(73, 17)
        Me.LBL_categoria.TabIndex = 23
        Me.LBL_categoria.Text = "Categoria:"
        Me.LBL_categoria.UseWaitCursor = True
        '
        'LBL_participante
        '
        Me.LBL_participante.AutoSize = True
        Me.LBL_participante.Location = New System.Drawing.Point(83, 33)
        Me.LBL_participante.Name = "LBL_participante"
        Me.LBL_participante.Size = New System.Drawing.Size(87, 17)
        Me.LBL_participante.TabIndex = 21
        Me.LBL_participante.Text = "Participante:"
        Me.LBL_participante.UseWaitCursor = True
        '
        'DGV_programa
        '
        Me.DGV_programa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_programa.Location = New System.Drawing.Point(37, 132)
        Me.DGV_programa.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DGV_programa.Name = "DGV_programa"
        Me.DGV_programa.RowHeadersWidth = 51
        Me.DGV_programa.RowTemplate.Height = 24
        Me.DGV_programa.Size = New System.Drawing.Size(699, 217)
        Me.DGV_programa.TabIndex = 9
        Me.DGV_programa.UseWaitCursor = True
        '
        'CB_participante
        '
        Me.CB_participante.FormattingEnabled = True
        Me.CB_participante.Location = New System.Drawing.Point(179, 30)
        Me.CB_participante.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CB_participante.Name = "CB_participante"
        Me.CB_participante.Size = New System.Drawing.Size(153, 24)
        Me.CB_participante.TabIndex = 1
        Me.CB_participante.UseWaitCursor = True
        '
        'CB_categoria
        '
        Me.CB_categoria.FormattingEnabled = True
        Me.CB_categoria.Location = New System.Drawing.Point(477, 30)
        Me.CB_categoria.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CB_categoria.Name = "CB_categoria"
        Me.CB_categoria.Size = New System.Drawing.Size(153, 24)
        Me.CB_categoria.TabIndex = 2
        Me.CB_categoria.UseWaitCursor = True
        '
        'CB_auditorio
        '
        Me.CB_auditorio.FormattingEnabled = True
        Me.CB_auditorio.Location = New System.Drawing.Point(179, 90)
        Me.CB_auditorio.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CB_auditorio.Name = "CB_auditorio"
        Me.CB_auditorio.Size = New System.Drawing.Size(153, 24)
        Me.CB_auditorio.TabIndex = 3
        Me.CB_auditorio.UseWaitCursor = True
        '
        'BTN_nuevo
        '
        Me.BTN_nuevo.Location = New System.Drawing.Point(107, 384)
        Me.BTN_nuevo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BTN_nuevo.Name = "BTN_nuevo"
        Me.BTN_nuevo.Size = New System.Drawing.Size(91, 34)
        Me.BTN_nuevo.TabIndex = 5
        Me.BTN_nuevo.Text = "&Nuevo"
        Me.BTN_nuevo.UseVisualStyleBackColor = True
        Me.BTN_nuevo.UseWaitCursor = True
        '
        'FormProgramaParticipantes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(779, 439)
        Me.Controls.Add(Me.BTN_nuevo)
        Me.Controls.Add(Me.CB_auditorio)
        Me.Controls.Add(Me.CB_categoria)
        Me.Controls.Add(Me.CB_participante)
        Me.Controls.Add(Me.BTN_salir)
        Me.Controls.Add(Me.BTN_eliminar)
        Me.Controls.Add(Me.BTN_guardar)
        Me.Controls.Add(Me.LBL_auditorio)
        Me.Controls.Add(Me.TB_fecha)
        Me.Controls.Add(Me.LBL_paterno)
        Me.Controls.Add(Me.LBL_categoria)
        Me.Controls.Add(Me.LBL_participante)
        Me.Controls.Add(Me.DGV_programa)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "FormProgramaParticipantes"
        Me.Text = "Agregar Participante al Programa"
        Me.UseWaitCursor = True
        CType(Me.DGV_programa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BTN_salir As Button
    Friend WithEvents BTN_eliminar As Button
    Friend WithEvents BTN_guardar As Button
    Friend WithEvents LBL_auditorio As Label
    Friend WithEvents TB_fecha As TextBox
    Friend WithEvents LBL_paterno As Label
    Friend WithEvents LBL_categoria As Label
    Friend WithEvents LBL_participante As Label
    Friend WithEvents DGV_programa As DataGridView
    Friend WithEvents CB_participante As ComboBox
    Friend WithEvents CB_categoria As ComboBox
    Friend WithEvents CB_auditorio As ComboBox
    Friend WithEvents BTN_nuevo As Button
    Friend WithEvents ToolTip1 As ToolTip
End Class
