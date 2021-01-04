Public Class FormCarreras
    Private Sub FormCarreras_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim carrera As New Carrera
        formDeCarreras = Me

        carrera.buscarCarreras(DGV_carreras)
        cnx.Close()

        Me.ToolTip1.SetToolTip(Me.BTN_nuevo, "Clic para limpiar cajas de texto ...")
        Me.ToolTip1.SetToolTip(Me.BTN_guardar, "Clic para Guardar información en el sistema...")
        Me.ToolTip1.SetToolTip(Me.BTN_eliminar, "Clic para Eliminar información en el sistema...")
    End Sub

    Private Sub BTN_guardar_Click(sender As System.Object, e As System.EventArgs) Handles BTN_guardar.Click

        If TB_id_carrera.Text = "" Then
            MessageBox.Show("Capturar id de la carrera")
        ElseIf TB_desc_carrera.Text = "" Then
            MessageBox.Show("Capturar la descripción")
        Else

            Dim carrera As New Carrera(TB_desc_carrera.Text, TB_id_carrera.Text)

            If carrera.obtenerIdCarrera() = False Then
                carrera.agregarCarrera()

                MessageBox.Show("Carrera Registrada ...")
            Else
                carrera.guardarCarrera()
                MsgBox("Carrera modificada ...")
            End If

            carrera.buscarCarreras(DGV_carreras)
        End If

    End Sub

    Private Sub TB_id_carrera_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TB_id_carrera.KeyPress
        If Not IsNumeric(e.KeyChar) And e.KeyChar <> ChrW(Keys.Back) Then
            e.Handled = True
        End If
    End Sub

    Private Sub BTN_nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_nuevo.Click

        TB_desc_carrera.Text = ""
        TB_id_carrera.Text = ""

        TB_desc_carrera.Focus()
    End Sub

    Private Sub DGV_carreras_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGV_carreras.CellContentClick


        Dim renglon As Integer
        Dim carrera As New Participante


        renglon = DGV_carreras.CurrentCellAddress.Y

        TB_desc_carrera.Text = DGV_carreras.Rows(renglon).Cells(1).Value
        TB_id_carrera.Text = DGV_carreras.Rows(renglon).Cells(0).Value

    End Sub

    Private Sub BTN_eliminar_Click(sender As System.Object, e As System.EventArgs) Handles BTN_eliminar.Click

        Dim carrera As New Carrera(TB_desc_carrera.Text, TB_id_carrera.Text)


        If carrera.validarParticipante() = True Then
            MsgBox("No se puede dar de baja la carrera, tiene participantes registrados o faltan datos")
        Else
            If MessageBox.Show("¿Esta seguro?", "CONFIRMAR", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then

                carrera.eliminarCarrera()
                MessageBox.Show("Carrera Eliminado")
                carrera.buscarCarreras(DGV_carreras)
            End If
        End If
    End Sub


    Private Sub BTN_salir_Click(sender As System.Object, e As System.EventArgs) Handles BTN_salir.Click
        Dim openForm = New FormMenu()
        openForm.Show()
        Me.Close()
    End Sub

    Private Sub TB_id_participante_TextChanged(sender As Object, e As EventArgs) Handles TB_id_carrera.TextChanged
        If TB_id_carrera.Text <> "" Then
            'Busca  un país en particular
            Dim carrera As New Carrera
            'Llamamos al método que elimina el registro
            carrera.buscarCarrera()
        End If
    End Sub

    Private Sub TB_desc_carrera_TextChanged(sender As Object, e As EventArgs) Handles TB_desc_carrera.TextChanged

    End Sub

    Private Sub LBL_nombre_Click(sender As Object, e As EventArgs) Handles LBL_nombre.Click

    End Sub

    Private Sub LBL_id_participante_Click(sender As Object, e As EventArgs) Handles LBL_id_participante.Click

    End Sub
End Class