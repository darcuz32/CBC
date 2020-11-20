<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormParticipantes
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.DGV_participantes = New System.Windows.Forms.DataGridView()
        Me.LBL_id_participante = New System.Windows.Forms.Label()
        Me.TB_id_participante = New System.Windows.Forms.TextBox()
        Me.TB_nombre = New System.Windows.Forms.TextBox()
        Me.LBL_nombre = New System.Windows.Forms.Label()
        Me.TB_paterno = New System.Windows.Forms.TextBox()
        Me.LBL_paterno = New System.Windows.Forms.Label()
        Me.LBL_carrera = New System.Windows.Forms.Label()
        Me.TB_edad = New System.Windows.Forms.TextBox()
        Me.LBL_edad = New System.Windows.Forms.Label()
        Me.TB_materno = New System.Windows.Forms.TextBox()
        Me.LBL_materno = New System.Windows.Forms.Label()
        Me.CB_carrera = New System.Windows.Forms.ComboBox()
        Me.CB_genero = New System.Windows.Forms.ComboBox()
        Me.LBL_genero = New System.Windows.Forms.Label()
        Me.CB_colonia = New System.Windows.Forms.ComboBox()
        Me.LBL_colonia = New System.Windows.Forms.Label()
        Me.BTN_guardar = New System.Windows.Forms.Button()
        Me.BTN_eliminar = New System.Windows.Forms.Button()
        Me.BTN_salir = New System.Windows.Forms.Button()
        Me.BTN_nuevo = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.DGV_participantes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGV_participantes
        '
        Me.DGV_participantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_participantes.Location = New System.Drawing.Point(44, 216)
        Me.DGV_participantes.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DGV_participantes.Name = "DGV_participantes"
        Me.DGV_participantes.RowHeadersWidth = 51
        Me.DGV_participantes.RowTemplate.Height = 24
        Me.DGV_participantes.Size = New System.Drawing.Size(933, 217)
        Me.DGV_participantes.TabIndex = 0
        '
        'LBL_id_participante
        '
        Me.LBL_id_participante.AutoSize = True
        Me.LBL_id_participante.Location = New System.Drawing.Point(65, 45)
        Me.LBL_id_participante.Name = "LBL_id_participante"
        Me.LBL_id_participante.Size = New System.Drawing.Size(102, 17)
        Me.LBL_id_participante.TabIndex = 1
        Me.LBL_id_participante.Text = "Id Participante:"
        '
        'TB_id_participante
        '
        Me.TB_id_participante.Location = New System.Drawing.Point(180, 45)
        Me.TB_id_participante.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TB_id_participante.Name = "TB_id_participante"
        Me.TB_id_participante.Size = New System.Drawing.Size(153, 22)
        Me.TB_id_participante.TabIndex = 2
        '
        'TB_nombre
        '
        Me.TB_nombre.Location = New System.Drawing.Point(472, 43)
        Me.TB_nombre.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TB_nombre.Name = "TB_nombre"
        Me.TB_nombre.Size = New System.Drawing.Size(153, 22)
        Me.TB_nombre.TabIndex = 4
        '
        'LBL_nombre
        '
        Me.LBL_nombre.AutoSize = True
        Me.LBL_nombre.Location = New System.Drawing.Point(393, 43)
        Me.LBL_nombre.Name = "LBL_nombre"
        Me.LBL_nombre.Size = New System.Drawing.Size(62, 17)
        Me.LBL_nombre.TabIndex = 3
        Me.LBL_nombre.Text = "Nombre:"
        '
        'TB_paterno
        '
        Me.TB_paterno.Location = New System.Drawing.Point(756, 43)
        Me.TB_paterno.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TB_paterno.Name = "TB_paterno"
        Me.TB_paterno.Size = New System.Drawing.Size(153, 22)
        Me.TB_paterno.TabIndex = 6
        '
        'LBL_paterno
        '
        Me.LBL_paterno.AutoSize = True
        Me.LBL_paterno.Location = New System.Drawing.Point(679, 43)
        Me.LBL_paterno.Name = "LBL_paterno"
        Me.LBL_paterno.Size = New System.Drawing.Size(62, 17)
        Me.LBL_paterno.TabIndex = 5
        Me.LBL_paterno.Text = "Paterno:"
        '
        'LBL_carrera
        '
        Me.LBL_carrera.AutoSize = True
        Me.LBL_carrera.Location = New System.Drawing.Point(687, 102)
        Me.LBL_carrera.Name = "LBL_carrera"
        Me.LBL_carrera.Size = New System.Drawing.Size(60, 17)
        Me.LBL_carrera.TabIndex = 11
        Me.LBL_carrera.Text = "Carrera:"
        '
        'TB_edad
        '
        Me.TB_edad.Location = New System.Drawing.Point(472, 102)
        Me.TB_edad.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TB_edad.Name = "TB_edad"
        Me.TB_edad.Size = New System.Drawing.Size(153, 22)
        Me.TB_edad.TabIndex = 10
        '
        'LBL_edad
        '
        Me.LBL_edad.AutoSize = True
        Me.LBL_edad.Location = New System.Drawing.Point(404, 102)
        Me.LBL_edad.Name = "LBL_edad"
        Me.LBL_edad.Size = New System.Drawing.Size(45, 17)
        Me.LBL_edad.TabIndex = 9
        Me.LBL_edad.Text = "Edad:"
        '
        'TB_materno
        '
        Me.TB_materno.Location = New System.Drawing.Point(180, 102)
        Me.TB_materno.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TB_materno.Name = "TB_materno"
        Me.TB_materno.Size = New System.Drawing.Size(153, 22)
        Me.TB_materno.TabIndex = 8
        '
        'LBL_materno
        '
        Me.LBL_materno.AutoSize = True
        Me.LBL_materno.Location = New System.Drawing.Point(112, 102)
        Me.LBL_materno.Name = "LBL_materno"
        Me.LBL_materno.Size = New System.Drawing.Size(60, 17)
        Me.LBL_materno.TabIndex = 7
        Me.LBL_materno.Text = "Materno"
        '
        'CB_carrera
        '
        Me.CB_carrera.FormattingEnabled = True
        Me.CB_carrera.Location = New System.Drawing.Point(756, 99)
        Me.CB_carrera.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CB_carrera.Name = "CB_carrera"
        Me.CB_carrera.Size = New System.Drawing.Size(153, 24)
        Me.CB_carrera.TabIndex = 12
        '
        'CB_genero
        '
        Me.CB_genero.FormattingEnabled = True
        Me.CB_genero.Location = New System.Drawing.Point(180, 170)
        Me.CB_genero.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CB_genero.Name = "CB_genero"
        Me.CB_genero.Size = New System.Drawing.Size(153, 24)
        Me.CB_genero.TabIndex = 14
        '
        'LBL_genero
        '
        Me.LBL_genero.AutoSize = True
        Me.LBL_genero.Location = New System.Drawing.Point(112, 174)
        Me.LBL_genero.Name = "LBL_genero"
        Me.LBL_genero.Size = New System.Drawing.Size(64, 17)
        Me.LBL_genero.TabIndex = 13
        Me.LBL_genero.Text = "Genero: "
        '
        'CB_colonia
        '
        Me.CB_colonia.FormattingEnabled = True
        Me.CB_colonia.Location = New System.Drawing.Point(472, 171)
        Me.CB_colonia.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CB_colonia.Name = "CB_colonia"
        Me.CB_colonia.Size = New System.Drawing.Size(153, 24)
        Me.CB_colonia.TabIndex = 16
        '
        'LBL_colonia
        '
        Me.LBL_colonia.AutoSize = True
        Me.LBL_colonia.Location = New System.Drawing.Point(404, 175)
        Me.LBL_colonia.Name = "LBL_colonia"
        Me.LBL_colonia.Size = New System.Drawing.Size(59, 17)
        Me.LBL_colonia.TabIndex = 15
        Me.LBL_colonia.Text = "Colonia:"
        '
        'BTN_guardar
        '
        Me.BTN_guardar.Location = New System.Drawing.Point(336, 447)
        Me.BTN_guardar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BTN_guardar.Name = "BTN_guardar"
        Me.BTN_guardar.Size = New System.Drawing.Size(91, 34)
        Me.BTN_guardar.TabIndex = 17
        Me.BTN_guardar.Text = "&Guardar"
        Me.BTN_guardar.UseVisualStyleBackColor = True
        '
        'BTN_eliminar
        '
        Me.BTN_eliminar.Location = New System.Drawing.Point(516, 447)
        Me.BTN_eliminar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BTN_eliminar.Name = "BTN_eliminar"
        Me.BTN_eliminar.Size = New System.Drawing.Size(87, 34)
        Me.BTN_eliminar.TabIndex = 18
        Me.BTN_eliminar.Text = "&Eliminar"
        Me.BTN_eliminar.UseVisualStyleBackColor = True
        '
        'BTN_salir
        '
        Me.BTN_salir.Location = New System.Drawing.Point(683, 447)
        Me.BTN_salir.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BTN_salir.Name = "BTN_salir"
        Me.BTN_salir.Size = New System.Drawing.Size(91, 34)
        Me.BTN_salir.TabIndex = 19
        Me.BTN_salir.Text = "&Salir"
        Me.BTN_salir.UseVisualStyleBackColor = True
        '
        'BTN_nuevo
        '
        Me.BTN_nuevo.Location = New System.Drawing.Point(139, 447)
        Me.BTN_nuevo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BTN_nuevo.Name = "BTN_nuevo"
        Me.BTN_nuevo.Size = New System.Drawing.Size(91, 34)
        Me.BTN_nuevo.TabIndex = 20
        Me.BTN_nuevo.Text = "&Nuevo"
        Me.BTN_nuevo.UseVisualStyleBackColor = True
        '
        'FormParticipantes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(995, 504)
        Me.Controls.Add(Me.BTN_nuevo)
        Me.Controls.Add(Me.BTN_salir)
        Me.Controls.Add(Me.BTN_eliminar)
        Me.Controls.Add(Me.BTN_guardar)
        Me.Controls.Add(Me.CB_colonia)
        Me.Controls.Add(Me.LBL_colonia)
        Me.Controls.Add(Me.CB_genero)
        Me.Controls.Add(Me.LBL_genero)
        Me.Controls.Add(Me.CB_carrera)
        Me.Controls.Add(Me.LBL_carrera)
        Me.Controls.Add(Me.TB_edad)
        Me.Controls.Add(Me.LBL_edad)
        Me.Controls.Add(Me.TB_materno)
        Me.Controls.Add(Me.LBL_materno)
        Me.Controls.Add(Me.TB_paterno)
        Me.Controls.Add(Me.LBL_paterno)
        Me.Controls.Add(Me.TB_nombre)
        Me.Controls.Add(Me.LBL_nombre)
        Me.Controls.Add(Me.TB_id_participante)
        Me.Controls.Add(Me.LBL_id_participante)
        Me.Controls.Add(Me.DGV_participantes)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "FormParticipantes"
        Me.Text = "Agregar Participante"
        CType(Me.DGV_participantes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DGV_participantes As DataGridView
    Friend WithEvents LBL_id_participante As Label
    Friend WithEvents TB_id_participante As TextBox
    Friend WithEvents TB_nombre As TextBox
    Friend WithEvents LBL_nombre As Label
    Friend WithEvents TB_paterno As TextBox
    Friend WithEvents LBL_paterno As Label
    Friend WithEvents LBL_carrera As Label
    Friend WithEvents TB_edad As TextBox
    Friend WithEvents LBL_edad As Label
    Friend WithEvents TB_materno As TextBox
    Friend WithEvents LBL_materno As Label
    Friend WithEvents CB_carrera As ComboBox
    Friend WithEvents CB_genero As ComboBox
    Friend WithEvents LBL_genero As Label
    Friend WithEvents CB_colonia As ComboBox
    Friend WithEvents LBL_colonia As Label
    Friend WithEvents BTN_guardar As Button
    Friend WithEvents BTN_eliminar As Button
    Friend WithEvents BTN_salir As Button
    Friend WithEvents BTN_nuevo As Button
    Friend WithEvents ToolTip1 As ToolTip
End Class
