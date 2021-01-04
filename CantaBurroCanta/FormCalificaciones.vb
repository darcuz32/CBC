Public Class FormCalificaciones
    Private Sub FormCalificaciones_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim calificacion As New Calificacion
        formDeCalificaciones = Me
        calificacion.buscarCategorias(CB_categoria)
        calificacion.buscarParticipantes(CB_participante)
        calificacion.buscarJueces(CB_juez)

        calificacion.buscarCalificaciones(DGV_calificaciones)

        cnx.Close()

        Me.ToolTip1.SetToolTip(Me.BTN_nuevo, "Clic para limpiar cajas de texto ...")
        Me.ToolTip1.SetToolTip(Me.BTN_guardar, "Clic para Guardar información en el sistema...")
        Me.ToolTip1.SetToolTip(Me.BTN_eliminar, "Clic para Eliminar información en el sistema...")
    End Sub

    Private Sub BTN_guardar_Click(sender As System.Object, e As System.EventArgs) Handles BTN_guardar.Click

        If TB_calificacion.Text = "" Then
            MessageBox.Show("Capturar la calificación")
        ElseIf CB_juez.Text = "" Then
            MessageBox.Show("Seleccionar el juez")
        ElseIf CB_categoria.Text = "" Then
            MessageBox.Show("Seleccionar la categoria")
        ElseIf CB_participante.Text = "" Then
            MessageBox.Show("Seleccionar al participante")
        Else

            Dim calificacion As New Calificacion(idCategoria, idJuez, TB_calificacion.Text, idParticipante)

            If calificacion.verificarParticipacion() = False Then

                MessageBox.Show("Este participante no tiene registrada una participación en esta categoría.")
            ElseIf calificacion.obtenerIdCalificacion() = False Then

                calificacion.agregarCalificacion()

                MessageBox.Show("Calificación Registrada ...")
            Else
                calificacion.guardarCalificacion()

                MsgBox("Calificación modificada ...")
            End If

            Calificacion.buscarCalificaciones(DGV_calificaciones)
        End If

    End Sub

    Private Sub BTN_nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_nuevo.Click
        TB_calificacion.Text = ""

        CB_juez.SelectedIndex = -1
        CB_categoria.SelectedIndex = -1
        CB_participante.SelectedIndex = -1

        TB_calificacion.Focus()
    End Sub

    Private Sub TB_calificacion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TB_calificacion.KeyPress
        If Not IsNumeric(e.KeyChar) And e.KeyChar <> ChrW(Keys.Back) Then
            e.Handled = True
        End If
    End Sub

    Private Sub DGV_calificaciones_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGV_calificaciones.CellContentClick

        Dim renglon As Integer

        renglon = DGV_calificaciones.CurrentCellAddress.Y

        TB_calificacion.Text = DGV_calificaciones.Rows(renglon).Cells(1).Value

        CB_participante.SelectedItem = DGV_calificaciones.Rows(renglon).Cells(0).Value
        CB_juez.SelectedItem = DGV_calificaciones.Rows(renglon).Cells(2).Value
        CB_categoria.SelectedItem = DGV_calificaciones.Rows(renglon).Cells(3).Value

    End Sub

    Private Sub BTN_eliminar_Click(sender As System.Object, e As System.EventArgs) Handles BTN_eliminar.Click
        Dim calificacion As New Calificacion(idCategoria, idJuez, TB_calificacion.Text, idParticipante)



        If MessageBox.Show("¿Esta seguro?", "CONFIRMAR", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then

            calificacion.eliminarCalificacion()
            MessageBox.Show("Registro Eliminado")

            calificacion.buscarCalificaciones(DGV_calificaciones)
        End If
    End Sub

    Private Sub CB_participante_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles CB_participante.SelectedIndexChanged
        Dim calificacion As New Calificacion
        calificacion.obtenerIdParticipante()
    End Sub

    Private Sub CB_categoria_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles CB_categoria.SelectedIndexChanged
        Dim calificacion As New Calificacion
        calificacion.obtenerIdCategoria()
    End Sub

    Private Sub CB_juez_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles CB_juez.SelectedIndexChanged
        Dim calificacion As New Calificacion
        calificacion.obtenerIdJuez()
    End Sub

    Private Sub BTN_salir_Click(sender As System.Object, e As System.EventArgs) Handles BTN_salir.Click
        Dim openForm = New FormMenu()
        openForm.Show()
        Me.Close()
    End Sub
End Class