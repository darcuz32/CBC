
Public Class FormParticipantes

    Private Sub FormParticipantes_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim participante As New Participante
        formDeParticipantes = Me

        participante.buscarCarreras(CB_carrera)
        participante.buscarGeneros(CB_genero)
        participante.buscarColonias(CB_colonia)

        participante.buscarParticipantes(DGV_participantes)
        cnx.Close()

        Me.ToolTip1.SetToolTip(Me.BTN_nuevo, "Clic para limpiar cajas de texto ...")
        Me.ToolTip1.SetToolTip(Me.BTN_guardar, "Clic para Guardar información en el sistema...")
        Me.ToolTip1.SetToolTip(Me.BTN_eliminar, "Clic para Eliminar información en el sistema...")
    End Sub

    Private Sub BTN_guardar_Click(sender As System.Object, e As System.EventArgs) Handles BTN_guardar.Click

        If TB_id_participante.Text = "" Then
            MessageBox.Show("Capturar id del participante")
        ElseIf TB_nombre.Text = "" Then
            MessageBox.Show("Capturar nombre del participante")
        ElseIf TB_paterno.Text = "" Then
            MessageBox.Show("Capturar apellido paterno")
        ElseIf TB_materno.Text = "" Then
            MessageBox.Show("Capturar apellido materno")
        ElseIf TB_edad.Text = "" Then
            MessageBox.Show("Capturar la edad del participante")
        ElseIf CB_carrera.Text = "" Then
            MessageBox.Show("Seleccionar la carrera")
        ElseIf CB_colonia.Text = "" Then
            MessageBox.Show("Seleccionar la colonia")
        ElseIf CB_genero.Text = "" Then
            MessageBox.Show("Seleccionar el genero")
        Else

            Dim participante As New Participante(idCarrera, idColonia, idGenero, TB_nombre.Text, TB_paterno.Text, TB_materno.Text, TB_edad.Text, TB_id_participante.Text)

            If participante.obtenerIdParticipante() = False Then
                participante.agregarParticipante()

                MessageBox.Show("Participante Registrado ...")
            Else
                participante.guardarParticipante()
                MsgBox("Participante modificado ...")
            End If

            participante.buscarParticipantes(DGV_participantes)
        End If

    End Sub


    Private Sub CB_carrera_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles CB_carrera.SelectedIndexChanged
        Dim participante As New Participante
        participante.obtenerIdCarrera()
    End Sub

    Private Sub CB_genero_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles CB_genero.SelectedIndexChanged
        Dim participante As New Participante
        participante.obtenerIdGenero()
    End Sub

    Private Sub CB_colonia_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles CB_colonia.SelectedIndexChanged
        Dim participante As New Participante
        participante.obtenerIdColonia()
    End Sub

    Private Sub TB_id_participante_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TB_id_participante.KeyPress
        If Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TB_edad_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TB_edad.KeyPress
        If Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub BTN_nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_nuevo.Click

        TB_nombre.Text = ""
        TB_edad.Text = ""
        TB_id_participante.Text = ""
        TB_materno.Text = ""
        TB_paterno.Text = ""

        CB_carrera.SelectedIndex = -1
        CB_colonia.SelectedIndex = -1
        CB_genero.SelectedIndex = -1
        TB_nombre.Focus()
    End Sub

    Private Sub DGV_participantes_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGV_participantes.CellContentClick


        Dim renglon As Integer
        Dim participante As New Participante


        renglon = DGV_participantes.CurrentCellAddress.Y

        TB_nombre.Text = DGV_participantes.Rows(renglon).Cells(1).Value
        TB_edad.Text = DGV_participantes.Rows(renglon).Cells(7).Value
        TB_id_participante.Text = DGV_participantes.Rows(renglon).Cells(0).Value
        TB_materno.Text = DGV_participantes.Rows(renglon).Cells(3).Value
        TB_paterno.Text = DGV_participantes.Rows(renglon).Cells(2).Value

        CB_carrera.SelectedItem = DGV_participantes.Rows(renglon).Cells(5).Value
        CB_colonia.SelectedItem = DGV_participantes.Rows(renglon).Cells(4).Value
        CB_genero.SelectedItem = DGV_participantes.Rows(renglon).Cells(6).Value

    End Sub

    Private Sub BTN_eliminar_Click(sender As System.Object, e As System.EventArgs) Handles BTN_eliminar.Click

        Dim participante As New Participante(idCarrera, idColonia, idGenero, TB_nombre.Text, TB_paterno.Text, TB_materno.Text, TB_edad.Text, TB_id_participante.Text)


        If participante.validarPrograma() = True Then
            MsgBox("No se puede dar de baja el participante, tiene presentaciones registradas o faltan datos")
        Else
            If MessageBox.Show("¿Esta seguro?", "CONFIRMAR", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then

                participante.eliminarParticipante()
                MessageBox.Show("Registro Eliminado")
                participante.buscarParticipantes(DGV_participantes)
            End If
        End If
    End Sub


    Private Sub BTN_salir_Click(sender As System.Object, e As System.EventArgs) Handles BTN_salir.Click
        Dim openForm = New FormMenu()
        openForm.Show()
        Me.Close()
    End Sub

    Private Sub TB_id_participante_TextChanged(sender As Object, e As EventArgs) Handles TB_id_participante.TextChanged

    End Sub
End Class
