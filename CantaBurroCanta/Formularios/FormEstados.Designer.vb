<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormEstados
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
        Me.TB_id_estado = New System.Windows.Forms.TextBox()
        Me.TB_nombre_estado = New System.Windows.Forms.TextBox()
        Me.DGV_estados = New System.Windows.Forms.DataGridView()
        Me.BTN_nuevo = New System.Windows.Forms.Button()
        Me.BTN_guardar = New System.Windows.Forms.Button()
        Me.BTN_eliminar = New System.Windows.Forms.Button()
        Me.BTN_salir = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.DGV_estados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(43, 47)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "id_estado:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(55, 92)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre:"
        '
        'TB_id_estado
        '
        Me.TB_id_estado.Location = New System.Drawing.Point(125, 43)
        Me.TB_id_estado.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TB_id_estado.Name = "TB_id_estado"
        Me.TB_id_estado.Size = New System.Drawing.Size(116, 22)
        Me.TB_id_estado.TabIndex = 1
        '
        'TB_nombre_estado
        '
        Me.TB_nombre_estado.Location = New System.Drawing.Point(125, 89)
        Me.TB_nombre_estado.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TB_nombre_estado.Name = "TB_nombre_estado"
        Me.TB_nombre_estado.Size = New System.Drawing.Size(193, 22)
        Me.TB_nombre_estado.TabIndex = 2
        '
        'DGV_estados
        '
        Me.DGV_estados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_estados.Location = New System.Drawing.Point(16, 167)
        Me.DGV_estados.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DGV_estados.Name = "DGV_estados"
        Me.DGV_estados.RowHeadersWidth = 51
        Me.DGV_estados.Size = New System.Drawing.Size(517, 185)
        Me.DGV_estados.TabIndex = 7
        '
        'BTN_nuevo
        '
        Me.BTN_nuevo.Location = New System.Drawing.Point(16, 367)
        Me.BTN_nuevo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BTN_nuevo.Name = "BTN_nuevo"
        Me.BTN_nuevo.Size = New System.Drawing.Size(100, 28)
        Me.BTN_nuevo.TabIndex = 3
        Me.BTN_nuevo.Text = "&Nuevo"
        Me.BTN_nuevo.UseVisualStyleBackColor = True
        '
        'BTN_guardar
        '
        Me.BTN_guardar.Location = New System.Drawing.Point(156, 367)
        Me.BTN_guardar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BTN_guardar.Name = "BTN_guardar"
        Me.BTN_guardar.Size = New System.Drawing.Size(100, 28)
        Me.BTN_guardar.TabIndex = 4
        Me.BTN_guardar.Text = "&Guardar"
        Me.BTN_guardar.UseVisualStyleBackColor = True
        '
        'BTN_eliminar
        '
        Me.BTN_eliminar.Location = New System.Drawing.Point(295, 367)
        Me.BTN_eliminar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BTN_eliminar.Name = "BTN_eliminar"
        Me.BTN_eliminar.Size = New System.Drawing.Size(100, 28)
        Me.BTN_eliminar.TabIndex = 5
        Me.BTN_eliminar.Text = "&Eliminar"
        Me.BTN_eliminar.UseVisualStyleBackColor = True
        '
        'BTN_salir
        '
        Me.BTN_salir.Location = New System.Drawing.Point(433, 367)
        Me.BTN_salir.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BTN_salir.Name = "BTN_salir"
        Me.BTN_salir.Size = New System.Drawing.Size(100, 28)
        Me.BTN_salir.TabIndex = 6
        Me.BTN_salir.Text = "&Salir"
        Me.BTN_salir.UseVisualStyleBackColor = True
        '
        'FormEstados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(552, 410)
        Me.Controls.Add(Me.BTN_salir)
        Me.Controls.Add(Me.BTN_eliminar)
        Me.Controls.Add(Me.BTN_guardar)
        Me.Controls.Add(Me.BTN_nuevo)
        Me.Controls.Add(Me.DGV_estados)
        Me.Controls.Add(Me.TB_nombre_estado)
        Me.Controls.Add(Me.TB_id_estado)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "FormEstados"
        Me.Text = "Estados"
        CType(Me.DGV_estados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TB_id_estado As TextBox
    Friend WithEvents TB_nombre_estado As TextBox
    Friend WithEvents DGV_estados As DataGridView
    Friend WithEvents BTN_nuevo As Button
    Friend WithEvents BTN_guardar As Button
    Friend WithEvents BTN_eliminar As Button
    Friend WithEvents BTN_salir As Button
    Friend WithEvents ToolTip1 As ToolTip
End Class
