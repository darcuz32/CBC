Public Class FormAuditorios
    Private Sub FormAuditorios_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        descAuditorio = ""
        idAuditorio = 0
        Dim auditorio As New Auditorio
        formDeAuditorios = Me

        auditorio.buscarAuditorios(DGV_auditorios)
        cnx.Close()

        Me.ToolTip1.SetToolTip(Me.BTN_nuevo, "Clic para limpiar cajas de texto ...")
        Me.ToolTip1.SetToolTip(Me.BTN_guardar, "Clic para Guardar información en el sistema...")
        Me.ToolTip1.SetToolTip(Me.BTN_eliminar, "Clic para Eliminar información en el sistema...")
    End Sub

    Private Sub BTN_guardar_Click(sender As System.Object, e As System.EventArgs) Handles BTN_guardar.Click

        If TB_id_auditorio.Text = "" Then
            MessageBox.Show("Capturar id del auditorio")
        ElseIf TB_desc_auditorio.Text = "" Then
            MessageBox.Show("Capturar la descripción")
        Else

            Dim auditorio As New Auditorio(TB_desc_auditorio.Text, TB_id_auditorio.Text)

            If auditorio.obtenerIdAuditorio() = False Then
                auditorio.agregarAuditorio()

                MessageBox.Show("Auditorio Registrado ...")

                If auditorio.validarParticipaciones() = False And auditorio.validarRegistro() = True Then
                    BTN_eliminar.Enabled = True
                Else
                    BTN_eliminar.Enabled = False
                End If

            Else
                auditorio.guardarAuditorio()
                MsgBox("Auditorio modificado ...")
            End If

            auditorio.buscarAuditorios(DGV_auditorios)
        End If

    End Sub

    Private Sub TB_id_auditorio_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TB_id_auditorio.KeyPress
        If Not IsNumeric(e.KeyChar) And e.KeyChar <> ChrW(Keys.Back) Then
            e.Handled = True
        End If
    End Sub

    Private Sub BTN_nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_nuevo.Click

        TB_desc_auditorio.Text = ""
        TB_id_auditorio.Text = ""

        TB_desc_auditorio.Focus()
    End Sub

    Private Sub DGV_auditorios_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGV_auditorios.CellContentClick


        Dim renglon As Integer
        Dim auditorio As New Participante


        renglon = DGV_auditorios.CurrentCellAddress.Y

        TB_desc_auditorio.Text = DGV_auditorios.Rows(renglon).Cells(1).Value
        TB_id_auditorio.Text = DGV_auditorios.Rows(renglon).Cells(0).Value

    End Sub

    Private Sub BTN_eliminar_Click(sender As System.Object, e As System.EventArgs) Handles BTN_eliminar.Click

        Dim auditorio As New Auditorio(TB_desc_auditorio.Text, TB_id_auditorio.Text)


        If auditorio.validarParticipaciones() = True Then
            MsgBox("No se puede dar de baja el auditorio, tiene participaciones registrados o faltan datos")
        Else
            If MessageBox.Show("¿Esta seguro?", "CONFIRMAR", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then

                auditorio.eliminarAuditorio()
                MessageBox.Show("Auditorio Eliminado")

                If auditorio.validarParticipaciones() = False And auditorio.validarRegistro() = True Then
                    BTN_eliminar.Enabled = True
                Else
                    BTN_eliminar.Enabled = False
                End If

                auditorio.buscarAuditorios(DGV_auditorios)
            End If
        End If
    End Sub


    Private Sub BTN_salir_Click(sender As System.Object, e As System.EventArgs) Handles BTN_salir.Click
        Dim openForm = New FormMenu()
        openForm.Show()
        Me.Close()
    End Sub

    Private Sub TB_id_participante_TextChanged(sender As Object, e As EventArgs) Handles TB_id_auditorio.TextChanged
        If TB_id_auditorio.Text <> "" Then
            'Busca  un país en particular
            Dim auditorio As New Auditorio
            'Llamamos al método que elimina el registro
            auditorio.buscarAuditorio()

            If auditorio.validarParticipaciones() = False And auditorio.validarRegistro() = True Then
                BTN_eliminar.Enabled = True
            Else
                BTN_eliminar.Enabled = False
            End If
        End If
    End Sub

    Private Sub TB_desc_auditorio_TextChanged(sender As Object, e As EventArgs) Handles TB_desc_auditorio.TextChanged

    End Sub

    Private Sub LBL_nombre_Click(sender As Object, e As EventArgs) Handles LBL_nombre.Click

    End Sub

    Private Sub LBL_id_participante_Click(sender As Object, e As EventArgs) Handles LBL_id_participante.Click

    End Sub
End Class