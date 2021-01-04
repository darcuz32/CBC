<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormJueces
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
        Me.TB_nombre_juez = New System.Windows.Forms.TextBox()
        Me.LBL_nombre = New System.Windows.Forms.Label()
        Me.TB_id_juez = New System.Windows.Forms.TextBox()
        Me.LBL_id_participante = New System.Windows.Forms.Label()
        Me.DGV_jueces = New System.Windows.Forms.DataGridView()
        Me.TB_materno_juez = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TB_paterno_juez = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.DGV_jueces, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BTN_nuevo
        '
        Me.BTN_nuevo.Location = New System.Drawing.Point(76, 363)
        Me.BTN_nuevo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BTN_nuevo.Name = "BTN_nuevo"
        Me.BTN_nuevo.Size = New System.Drawing.Size(91, 34)
        Me.BTN_nuevo.TabIndex = 68
        Me.BTN_nuevo.Text = "&Nuevo"
        Me.BTN_nuevo.UseVisualStyleBackColor = True
        '
        'BTN_salir
        '
        Me.BTN_salir.Location = New System.Drawing.Point(620, 363)
        Me.BTN_salir.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BTN_salir.Name = "BTN_salir"
        Me.BTN_salir.Size = New System.Drawing.Size(91, 34)
        Me.BTN_salir.TabIndex = 67
        Me.BTN_salir.Text = "&Salir"
        Me.BTN_salir.UseVisualStyleBackColor = True
        '
        'BTN_eliminar
        '
        Me.BTN_eliminar.Location = New System.Drawing.Point(453, 363)
        Me.BTN_eliminar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BTN_eliminar.Name = "BTN_eliminar"
        Me.BTN_eliminar.Size = New System.Drawing.Size(87, 34)
        Me.BTN_eliminar.TabIndex = 66
        Me.BTN_eliminar.Text = "&Eliminar"
        Me.BTN_eliminar.UseVisualStyleBackColor = True
        '
        'BTN_guardar
        '
        Me.BTN_guardar.Location = New System.Drawing.Point(273, 363)
        Me.BTN_guardar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BTN_guardar.Name = "BTN_guardar"
        Me.BTN_guardar.Size = New System.Drawing.Size(91, 34)
        Me.BTN_guardar.TabIndex = 65
        Me.BTN_guardar.Text = "&Guardar"
        Me.BTN_guardar.UseVisualStyleBackColor = True
        '
        'TB_nombre_juez
        '
        Me.TB_nombre_juez.Location = New System.Drawing.Point(510, 37)
        Me.TB_nombre_juez.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TB_nombre_juez.Name = "TB_nombre_juez"
        Me.TB_nombre_juez.Size = New System.Drawing.Size(153, 22)
        Me.TB_nombre_juez.TabIndex = 64
        '
        'LBL_nombre
        '
        Me.LBL_nombre.AutoSize = True
        Me.LBL_nombre.Location = New System.Drawing.Point(418, 37)
        Me.LBL_nombre.Name = "LBL_nombre"
        Me.LBL_nombre.Size = New System.Drawing.Size(62, 17)
        Me.LBL_nombre.TabIndex = 63
        Me.LBL_nombre.Text = "Nombre:"
        '
        'TB_id_juez
        '
        Me.TB_id_juez.Location = New System.Drawing.Point(218, 39)
        Me.TB_id_juez.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TB_id_juez.Name = "TB_id_juez"
        Me.TB_id_juez.Size = New System.Drawing.Size(153, 22)
        Me.TB_id_juez.TabIndex = 62
        '
        'LBL_id_participante
        '
        Me.LBL_id_participante.AutoSize = True
        Me.LBL_id_participante.Location = New System.Drawing.Point(103, 39)
        Me.LBL_id_participante.Name = "LBL_id_participante"
        Me.LBL_id_participante.Size = New System.Drawing.Size(57, 17)
        Me.LBL_id_participante.TabIndex = 61
        Me.LBL_id_participante.Text = "Id Juez:"
        '
        'DGV_jueces
        '
        Me.DGV_jueces.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_jueces.Location = New System.Drawing.Point(50, 127)
        Me.DGV_jueces.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DGV_jueces.Name = "DGV_jueces"
        Me.DGV_jueces.RowHeadersWidth = 51
        Me.DGV_jueces.RowTemplate.Height = 24
        Me.DGV_jueces.Size = New System.Drawing.Size(702, 217)
        Me.DGV_jueces.TabIndex = 60
        '
        'TB_materno_juez
        '
        Me.TB_materno_juez.Location = New System.Drawing.Point(510, 78)
        Me.TB_materno_juez.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TB_materno_juez.Name = "TB_materno_juez"
        Me.TB_materno_juez.Size = New System.Drawing.Size(153, 22)
        Me.TB_materno_juez.TabIndex = 72
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(418, 78)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 17)
        Me.Label1.TabIndex = 71
        Me.Label1.Text = "Materno:"
        '
        'TB_paterno_juez
        '
        Me.TB_paterno_juez.Location = New System.Drawing.Point(218, 80)
        Me.TB_paterno_juez.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TB_paterno_juez.Name = "TB_paterno_juez"
        Me.TB_paterno_juez.Size = New System.Drawing.Size(153, 22)
        Me.TB_paterno_juez.TabIndex = 70
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(103, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 17)
        Me.Label2.TabIndex = 69
        Me.Label2.Text = "Paterno:"
        '
        'FormJueces
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TB_materno_juez)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TB_paterno_juez)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BTN_nuevo)
        Me.Controls.Add(Me.BTN_salir)
        Me.Controls.Add(Me.BTN_eliminar)
        Me.Controls.Add(Me.BTN_guardar)
        Me.Controls.Add(Me.TB_nombre_juez)
        Me.Controls.Add(Me.LBL_nombre)
        Me.Controls.Add(Me.TB_id_juez)
        Me.Controls.Add(Me.LBL_id_participante)
        Me.Controls.Add(Me.DGV_jueces)
        Me.Name = "FormJueces"
        Me.Text = "Agregar Juez"
        CType(Me.DGV_jueces, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BTN_nuevo As Button
    Friend WithEvents BTN_salir As Button
    Friend WithEvents BTN_eliminar As Button
    Friend WithEvents BTN_guardar As Button
    Friend WithEvents TB_nombre_juez As TextBox
    Friend WithEvents LBL_nombre As Label
    Friend WithEvents TB_id_juez As TextBox
    Friend WithEvents LBL_id_participante As Label
    Friend WithEvents DGV_jueces As DataGridView
    Friend WithEvents TB_materno_juez As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TB_paterno_juez As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ToolTip1 As ToolTip
End Class
