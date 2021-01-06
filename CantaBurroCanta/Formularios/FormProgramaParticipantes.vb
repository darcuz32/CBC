Public Class FormProgramaParticipantes
    Private Sub FormParticipantes_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        idCategoria = 0
        idAuditorio = 0
        fecha = ""
        idParticipante = 0
        Dim programa As New ProgramaParticipantes
        formDeProgramaParticipantes = Me
        programa.buscarCategorias(CB_categoria)
        programa.buscarParticipantes(CB_participante)
        programa.buscarAuditorios(CB_auditorio)

        programa.buscarPrograma(DGV_programa)

        cnx.Close()

        Me.ToolTip1.SetToolTip(Me.BTN_nuevo, "Clic para limpiar cajas de texto ...")
        Me.ToolTip1.SetToolTip(Me.BTN_guardar, "Clic para Guardar información en el sistema...")
        Me.ToolTip1.SetToolTip(Me.BTN_eliminar, "Clic para Eliminar información en el sistema...")
    End Sub

    Private Sub BTN_guardar_Click(sender As System.Object, e As System.EventArgs) Handles BTN_guardar.Click

        If TB_fecha.Text = "" Then
            MessageBox.Show("Capturar la fecha")
        ElseIf CB_auditorio.Text = "" Then
            MessageBox.Show("Seleccionar el auditorio")
        ElseIf CB_categoria.Text = "" Then
            MessageBox.Show("Seleccionar la categoria")
        ElseIf CB_participante.Text = "" Then
            MessageBox.Show("Seleccionar al participante")
        Else

            Dim programa As New ProgramaParticipantes(idCategoria, idAuditorio, TB_fecha.Text, idParticipante)

            If programa.verificarFecha() = True Then

                MessageBox.Show("Ya existe una participación registrada para este participante en esta fecha")

            ElseIf programa.obtenerIdPrograma() = False Then

                programa.agregarPrograma()

                MessageBox.Show("Participación Registrada ...")

                If programa.validarCalificaciones() = False Then
                    BTN_eliminar.Enabled = True
                Else
                    BTN_eliminar.Enabled = False
                End If

            Else
                programa.guardarPrograma()

                MsgBox("Participación modificada ...")
            End If

            programa.buscarPrograma(DGV_programa)
        End If

    End Sub

    Private Sub BTN_nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_nuevo.Click
        TB_fecha.Text = ""

        CB_auditorio.SelectedIndex = -1
        CB_categoria.SelectedIndex = -1
        CB_participante.SelectedIndex = -1

        TB_fecha.Focus()
    End Sub

    Private Sub DGV_programa_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGV_programa.CellContentClick
        Dim renglon As Integer


        renglon = DGV_programa.CurrentCellAddress.Y

        TB_fecha.Text = DGV_programa.Rows(renglon).Cells(1).Value

        CB_participante.SelectedItem = DGV_programa.Rows(renglon).Cells(0).Value
        CB_auditorio.SelectedItem = DGV_programa.Rows(renglon).Cells(2).Value
        CB_categoria.SelectedItem = DGV_programa.Rows(renglon).Cells(3).Value

    End Sub

    Private Sub BTN_eliminar_Click(sender As System.Object, e As System.EventArgs) Handles BTN_eliminar.Click
        Dim programa As New ProgramaParticipantes(idCategoria, idAuditorio, TB_fecha.Text, idParticipante)


        If programa.validarCalificaciones() = True Then
            MsgBox("No se puede dar de baja la participación, tiene calificaciones registradas o faltan datos")
        Else
            If MessageBox.Show("¿Esta seguro?", "CONFIRMAR", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then

                programa.eliminarPrograma()
                MessageBox.Show("Registro Eliminado")

                If programa.validarCalificaciones() = False And programa.validarRegistro() = True Then
                    BTN_eliminar.Enabled = True
                Else
                    BTN_eliminar.Enabled = False
                End If

                programa.buscarPrograma(DGV_programa)
            End If
        End If
    End Sub

    Private Sub CB_participante_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles CB_participante.SelectedIndexChanged
        Dim programa As New ProgramaParticipantes
        programa.obtenerIdParticipante()
        programa.obtenerParticipacion()

        If programa.validarCalificaciones() = False And programa.validarRegistro() = True Then
            BTN_eliminar.Enabled = True
        Else
            BTN_eliminar.Enabled = False
        End If
    End Sub

    Private Sub CB_categoria_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles CB_categoria.SelectedIndexChanged
        Dim programa As New ProgramaParticipantes
        programa.obtenerIdCategoria()
        programa.obtenerParticipacion()

        If programa.validarCalificaciones() = False And programa.validarRegistro() Then
            BTN_eliminar.Enabled = True
        Else
            BTN_eliminar.Enabled = False
        End If
    End Sub

    Private Sub CB_auditorio_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles CB_auditorio.SelectedIndexChanged
        Dim programa As New ProgramaParticipantes
        programa.obtenerIdAuditorio()
    End Sub

    Private Sub BTN_salir_Click(sender As System.Object, e As System.EventArgs) Handles BTN_salir.Click
        Dim openForm = New FormMenu()
        openForm.Show()
        Me.Close()
    End Sub
End Class