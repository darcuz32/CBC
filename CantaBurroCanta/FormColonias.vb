Public Class FormColonias

    Private Sub FormColonias_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim colonia As New Colonia
        formDeColonias = Me


        colonia.buscarEstados(CB_estados)
        ' colonia.buscarColonias(DGV_colonias)
        cnx.Close()

        Me.ToolTip1.SetToolTip(Me.BTN_nuevo, "Clic para limpiar cajas de texto ...")
        Me.ToolTip1.SetToolTip(Me.BTN_guardar, "Clic para Guardar información en el sistema...")
        Me.ToolTip1.SetToolTip(Me.BTN_eliminar, "Clic para Eliminar información en el sistema...")
    End Sub

    Private Sub BTN_guardar_Click(sender As System.Object, e As System.EventArgs) Handles BTN_guardar.Click

        If TB_id_colonia.Text = "" Then
            MessageBox.Show("Capturar id de la colonia")
        ElseIf TB_nombre.Text = "" Then
            MessageBox.Show("Capturar el nombre de la colonia")
        ElseIf CB_ciudad.Text = "" Then
            MessageBox.Show("Seleccionar la ciudad")
        ElseIf CB_estados.Text = "" Then
            MessageBox.Show("Seleccionar el estado")
        Else


            'ES IMPORTANTE QUE CONSTRUYAS TU NUEVA COLONIA (OBJETO) EN EL MISMO ORDEN QUE VA RESIVIR LOS DATOS EN LA BD.

            Dim colonia As New Colonia(TB_id_colonia.Text, idCiudad, TB_nombre.Text, idEstado)

            If colonia.obtenerIdColonia() = False Then
                colonia.agregarColonia()

                MessageBox.Show("Colonia Registrada ...")
            Else
                colonia.guardarColonia()
                MsgBox("Colonia modificada ...")
            End If

            colonia.buscarColonias(DGV_colonias)
        End If

    End Sub
    Private Sub CB_ciudad_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles CB_ciudad.SelectedIndexChanged
        Dim colonia As New Colonia
        colonia.obtenerIdCiudad()
        colonia.buscarColonias(DGV_colonias)
    End Sub
    Private Sub TB_id_colonia_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TB_id_colonia.KeyPress
        If Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub BTN_nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_nuevo.Click

        TB_nombre.Text = ""
        TB_id_colonia.Text = ""

        CB_ciudad.SelectedIndex = -1
        CB_estados.SelectedIndex = -1
        TB_id_colonia.Focus()
    End Sub

    Private Sub DGV_colonias_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGV_colonias.CellContentClick


        Dim renglon As Integer
        Dim colonia As New Colonia


        renglon = DGV_colonias.CurrentCellAddress.Y

        TB_nombre.Text = DGV_colonias.Rows(renglon).Cells(1).Value
        TB_id_colonia.Text = DGV_colonias.Rows(renglon).Cells(0).Value

        CB_ciudad.SelectedItem = DGV_colonias.Rows(renglon).Cells(2).Value

    End Sub

    Private Sub BTN_eliminar_Click(sender As System.Object, e As System.EventArgs) Handles BTN_eliminar.Click

        'ES IMPORTANTE QUE CONSTRUYAS TU NUEVA COLONIA (OBJETO) EN EL MISMO ORDEN QUE VA RESIVIR LOS DATOS EN LA BD.

        Dim colonia As New Colonia(TB_id_colonia.Text, idCiudad, TB_nombre.Text, idEstado)

        If colonia.validarParticipante() = True Then
            MsgBox("No se puede dar de baja la ciudad, tiene participantes registrad0s o faltan datos")
        Else
            If MessageBox.Show("¿Esta seguro?", "CONFIRMAR", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then

                colonia.eliminarColonia()
                MessageBox.Show("Registro Eliminado")
                colonia.buscarColonias(DGV_colonias)
            End If
        End If
    End Sub


    Private Sub BTN_salir_Click(sender As System.Object, e As System.EventArgs) Handles BTN_salir.Click
        Dim openForm = New FormMenu()
        openForm.Show()
        Me.Close()
    End Sub

    Private Sub TB_id_colonia_TextChanged(sender As Object, e As EventArgs) Handles TB_id_colonia.TextChanged
        'Busca si la ciudad indicada tiene colonias, para deshabilitar el boton de eliminar.
        'por que si tiene colonias no se puede eliminar
        If Not IsNumeric(TB_id_colonia.Text) Then
            ' MsgBox("Solo acepto Numeros...")
        Else
            Dim colonia As New Colonia(TB_id_colonia.Text, CB_estados.Text, TB_nombre.Text, CB_ciudad.Text)

            'Consulta el nombre de la colonia, dado la clave
            If colonia.consultaUnaColonia() = True Then
                TB_nombre.Text = nombre
                CB_estados.Text = nomEdo
                CB_ciudad.Text = nomCd
            Else
                TB_nombre.Text = ""
                CB_estados.Text = ""
                CB_ciudad.Text = ""
            End If
            'Validamos si la colonia tiene participantes, para saber si se puede borrar o no
            'deshabilitamos el boton de borrar
            If colonia.validarParticipante() = False Then
                BTN_eliminar.Enabled = True
            Else
                BTN_eliminar.Enabled = False
            End If
            cnx.Close()
        End If
    End Sub

    Private Sub CB_estados_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_estados.SelectedIndexChanged
        Dim colonia As New Colonia
        colonia.obtenerIdEstado()
        colonia.buscarCiudades(CB_ciudad)
    End Sub
End Class