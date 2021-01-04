Public Class FormGeneros
    Private Sub FormGeneros_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim genero As New Genero
        formDeGeneros = Me

        genero.buscarGeneros(DGV_generos)
        cnx.Close()

        Me.ToolTip1.SetToolTip(Me.BTN_nuevo, "Clic para limpiar cajas de texto ...")
        Me.ToolTip1.SetToolTip(Me.BTN_guardar, "Clic para Guardar información en el sistema...")
        Me.ToolTip1.SetToolTip(Me.BTN_eliminar, "Clic para Eliminar información en el sistema...")
    End Sub

    Private Sub BTN_guardar_Click(sender As System.Object, e As System.EventArgs) Handles BTN_guardar.Click

        If TB_id_genero.Text = "" Then
            MessageBox.Show("Capturar id del género")
        ElseIf TB_desc_genero.Text = "" Then
            MessageBox.Show("Capturar la descripción")
        Else

            Dim genero As New Genero(TB_desc_genero.Text, TB_id_genero.Text)

            If genero.obtenerIdGenero() = False Then
                genero.agregarGenero()

                MessageBox.Show("Género Registrado ...")
            Else
                genero.guardarGenero()
                MsgBox("Género modificado ...")
            End If

            genero.buscarGeneros(DGV_generos)
        End If

    End Sub

    Private Sub TB_id_genero_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TB_id_genero.KeyPress
        If Not IsNumeric(e.KeyChar) And e.KeyChar <> ChrW(Keys.Back) Then
            e.Handled = True
        End If
    End Sub

    Private Sub BTN_nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_nuevo.Click

        TB_desc_genero.Text = ""
        TB_id_genero.Text = ""

        TB_desc_genero.Focus()
    End Sub

    Private Sub DGV_generos_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGV_generos.CellContentClick


        Dim renglon As Integer
        Dim genero As New Participante


        renglon = DGV_generos.CurrentCellAddress.Y

        TB_desc_genero.Text = DGV_generos.Rows(renglon).Cells(1).Value
        TB_id_genero.Text = DGV_generos.Rows(renglon).Cells(0).Value

    End Sub

    Private Sub BTN_eliminar_Click(sender As System.Object, e As System.EventArgs) Handles BTN_eliminar.Click

        Dim genero As New Genero(TB_desc_genero.Text, TB_id_genero.Text)


        If genero.validarParticipante() = True Then
            MsgBox("No se puede dar de baja el género, tiene participantes registrados o faltan datos")
        Else
            If MessageBox.Show("¿Esta seguro?", "CONFIRMAR", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then

                genero.eliminarGenero()
                MessageBox.Show("Género Eliminado")
                genero.buscarGeneros(DGV_generos)
            End If
        End If
    End Sub


    Private Sub BTN_salir_Click(sender As System.Object, e As System.EventArgs) Handles BTN_salir.Click
        Dim openForm = New FormMenu()
        openForm.Show()
        Me.Close()
    End Sub

    Private Sub TB_id_participante_TextChanged(sender As Object, e As EventArgs) Handles TB_id_genero.TextChanged
        If TB_id_genero.Text <> "" Then
            'Busca  un país en particular
            Dim genero As New Genero
            'Llamamos al método que elimina el registro
            genero.buscarGenero()
        End If
    End Sub

    Private Sub TB_desc_genero_TextChanged(sender As Object, e As EventArgs) Handles TB_desc_genero.TextChanged

    End Sub

    Private Sub LBL_nombre_Click(sender As Object, e As EventArgs) Handles LBL_nombre.Click

    End Sub

    Private Sub LBL_id_participante_Click(sender As Object, e As EventArgs) Handles LBL_id_participante.Click

    End Sub
End Class