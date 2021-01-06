Public Class FormJueces
    Private Sub FormJueces_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        nombreJuez = ""
        paternoJuez = ""
        maternoJuez = ""
        idJuez = 0
        Dim juez As New Juez
        formDeJueces = Me

        juez.buscarJueces(DGV_jueces)
        cnx.Close()

        Me.ToolTip1.SetToolTip(Me.BTN_nuevo, "Clic para limpiar cajas de texto ...")
        Me.ToolTip1.SetToolTip(Me.BTN_guardar, "Clic para Guardar información en el sistema...")
        Me.ToolTip1.SetToolTip(Me.BTN_eliminar, "Clic para Eliminar información en el sistema...")
    End Sub

    Private Sub BTN_guardar_Click(sender As System.Object, e As System.EventArgs) Handles BTN_guardar.Click

        If TB_id_juez.Text = "" Then
            MessageBox.Show("Capturar id del juez")
        ElseIf TB_nombre_juez.Text = "" Then
            MessageBox.Show("Capturar el nombre")
        ElseIf TB_paterno_juez.Text = "" Then
            MessageBox.Show("Capturar el apellido paterno")
        ElseIf TB_materno_juez.Text = "" Then
            MessageBox.Show("Capturar el apellido materno")
        Else

            Dim juez As New Juez(TB_materno_juez.Text, TB_paterno_juez.Text, TB_nombre_juez.Text, TB_id_juez.Text)

            If juez.obtenerIdJuez() = False Then
                juez.agregarJuez()

                MessageBox.Show("Juez Registrado ...")

                If juez.validarCalificaciones() = False And juez.validarRegistro() = True Then
                    BTN_eliminar.Enabled = True
                Else
                    BTN_eliminar.Enabled = False
                End If
            Else
                juez.guardarJuez()
                MsgBox("Juez modificado ...")
            End If

            juez.buscarJueces(DGV_jueces)
        End If

    End Sub

    Private Sub TB_id_juez_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TB_id_juez.KeyPress
        If Not IsNumeric(e.KeyChar) And e.KeyChar <> ChrW(Keys.Back) Then
            e.Handled = True
        End If
    End Sub

    Private Sub BTN_nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_nuevo.Click

        TB_materno_juez.Text = ""
        TB_paterno_juez.Text = ""
        TB_nombre_juez.Text = ""
        TB_id_juez.Text = ""

        TB_id_juez.Focus()
    End Sub

    Private Sub DGV_jueces_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGV_jueces.CellContentClick


        Dim renglon As Integer


        renglon = DGV_jueces.CurrentCellAddress.Y

        TB_materno_juez.Text = DGV_jueces.Rows(renglon).Cells(3).Value
        TB_paterno_juez.Text = DGV_jueces.Rows(renglon).Cells(2).Value
        TB_nombre_juez.Text = DGV_jueces.Rows(renglon).Cells(1).Value
        TB_id_juez.Text = DGV_jueces.Rows(renglon).Cells(0).Value

    End Sub

    Private Sub BTN_eliminar_Click(sender As System.Object, e As System.EventArgs) Handles BTN_eliminar.Click

        Dim juez As New Juez(TB_materno_juez.Text, TB_paterno_juez.Text, TB_nombre_juez.Text, TB_id_juez.Text)


        If juez.validarCalificaciones() = True Then
            MsgBox("No se puede dar de baja el juez, tiene calificaciones registrados o faltan datos")
        Else
            If MessageBox.Show("¿Esta seguro?", "CONFIRMAR", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then

                juez.eliminarJuez()
                MessageBox.Show("Juez Eliminado")

                If juez.validarCalificaciones() = False And juez.validarRegistro() = True Then
                    BTN_eliminar.Enabled = True
                Else
                    BTN_eliminar.Enabled = False
                End If

                juez.buscarJueces(DGV_jueces)
            End If
        End If
    End Sub


    Private Sub BTN_salir_Click(sender As System.Object, e As System.EventArgs) Handles BTN_salir.Click
        Dim openForm = New FormMenu()
        openForm.Show()
        Me.Close()
    End Sub

    Private Sub TB_id_participante_TextChanged(sender As Object, e As EventArgs) Handles TB_id_juez.TextChanged
        If TB_id_juez.Text <> "" Then
            'Busca  un país en particular
            Dim juez As New Juez
            'Llamamos al método que elimina el registro
            juez.buscarJuez()

            If juez.validarCalificaciones() = False And juez.validarRegistro() = True Then
                BTN_eliminar.Enabled = True
            Else
                BTN_eliminar.Enabled = False
            End If
        End If
    End Sub

End Class