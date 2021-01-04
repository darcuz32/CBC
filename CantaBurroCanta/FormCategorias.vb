Public Class FormCategorias
    Private Sub FormCategorias_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim categoria As New Categoria
        formDeCategorias = Me

        categoria.buscarCategorias(DGV_categorias)
        cnx.Close()

        Me.ToolTip1.SetToolTip(Me.BTN_nuevo, "Clic para limpiar cajas de texto ...")
        Me.ToolTip1.SetToolTip(Me.BTN_guardar, "Clic para Guardar información en el sistema...")
        Me.ToolTip1.SetToolTip(Me.BTN_eliminar, "Clic para Eliminar información en el sistema...")
    End Sub

    Private Sub BTN_guardar_Click(sender As System.Object, e As System.EventArgs) Handles BTN_guardar.Click

        If TB_id_categoria.Text = "" Then
            MessageBox.Show("Capturar id de la categoria")
        ElseIf TB_desc_categoria.Text = "" Then
            MessageBox.Show("Capturar la descripción")
        Else

            Dim categoria As New Categoria(TB_desc_categoria.Text, TB_id_categoria.Text)

            If categoria.obtenerIdCategoria() = False Then
                categoria.agregarCategoria()

                MessageBox.Show("Categoría Registrada ...")
            Else
                categoria.guardarCategoria()
                MsgBox("Categoría modificada ...")
            End If

            categoria.buscarCategorias(DGV_categorias)
        End If

    End Sub

    Private Sub TB_id_categoria_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TB_id_categoria.KeyPress
        If Not IsNumeric(e.KeyChar) And e.KeyChar <> ChrW(Keys.Back) Then
            e.Handled = True
        End If
    End Sub

    Private Sub BTN_nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_nuevo.Click

        TB_desc_categoria.Text = ""
        TB_id_categoria.Text = ""

        TB_desc_categoria.Focus()
    End Sub

    Private Sub DGV_categorias_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGV_categorias.CellContentClick


        Dim renglon As Integer


        renglon = DGV_categorias.CurrentCellAddress.Y

        TB_desc_categoria.Text = DGV_categorias.Rows(renglon).Cells(1).Value
        TB_id_categoria.Text = DGV_categorias.Rows(renglon).Cells(0).Value

    End Sub

    Private Sub BTN_eliminar_Click(sender As System.Object, e As System.EventArgs) Handles BTN_eliminar.Click

        Dim categoria As New Categoria(TB_desc_categoria.Text, TB_id_categoria.Text)


        If categoria.validarParticipaciones() = True Then
            MsgBox("No se puede dar de baja la categoría, tiene participaciones registrados o faltan datos")
        Else
            If MessageBox.Show("¿Esta seguro?", "CONFIRMAR", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then

                categoria.eliminarCategoria()
                MessageBox.Show("Categoría Eliminado")
                categoria.buscarCategorias(DGV_categorias)
            End If
        End If
    End Sub


    Private Sub BTN_salir_Click(sender As System.Object, e As System.EventArgs) Handles BTN_salir.Click
        Dim openForm = New FormMenu()
        openForm.Show()
        Me.Close()
    End Sub

    Private Sub TB_id_participante_TextChanged(sender As Object, e As EventArgs) Handles TB_id_categoria.TextChanged
        If TB_id_categoria.Text <> "" Then
            'Busca  un país en particular
            Dim categoria As New Categoria
            'Llamamos al método que elimina el registro
            categoria.buscarCategoria()
        End If
    End Sub

    Private Sub TB_desc_categoria_TextChanged(sender As Object, e As EventArgs) Handles TB_desc_categoria.TextChanged

    End Sub

    Private Sub LBL_nombre_Click(sender As Object, e As EventArgs) Handles LBL_nombre.Click

    End Sub

    Private Sub LBL_id_participante_Click(sender As Object, e As EventArgs) Handles LBL_id_participante.Click

    End Sub
End Class