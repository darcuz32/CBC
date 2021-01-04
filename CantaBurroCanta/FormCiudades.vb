Public Class FormCiudades


    Private Sub FormCiudades_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim ciudad As New Ciudad
        formDeCiudades = Me

        ciudad.buscarEstados(CB_estado)
        cnx.Close()

        Me.ToolTip1.SetToolTip(Me.BTN_nuevo, "Clic para limpiar cajas de texto ...")
        Me.ToolTip1.SetToolTip(Me.BTN_guardar, "Clic para Guardar información en el sistema...")
        Me.ToolTip1.SetToolTip(Me.BTN_eliminar, "Clic para Eliminar información en el sistema...")
    End Sub

    Private Sub BTN_guardar_Click(sender As System.Object, e As System.EventArgs) Handles BTN_guardar.Click

        If TB_id_ciudad.Text = "" Then
            MessageBox.Show("Capturar id de la ciudad")
        ElseIf CB_estado.Text = "" Then
            MessageBox.Show("Seleccionar el estado")
        ElseIf TB_nombre.Text = "" Then
            MessageBox.Show("Capturar el nombre de la ciudad")
        Else

            'ES IMPORTANTE QUE CONSTRUYAS TU NUEVA CIUDAD (OBJETO) EN EL MISMO ORDEN QUE VA RESIVIR LOS DATOS EN LA BD.

            Dim ciudad As New Ciudad(TB_id_ciudad.Text, idEstado, TB_nombre.Text)

            If ciudad.obtenerIdCiudad() = False Then
                ciudad.agregarCiudad()

                MessageBox.Show("Ciudad Registrada ...")
            Else
                ciudad.guardarCiudad()
                MsgBox("Ciudad modificada ...")
            End If

            ciudad.buscarCiudades(DGV_ciudades)
        End If

    End Sub
    Private Sub CB_estado_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles CB_estado.SelectedIndexChanged
        Dim ciudad As New Ciudad
        ciudad.obtenerIdEstado()
        ciudad.buscarCiudades(DGV_ciudades)
    End Sub
    Private Sub TB_id_ciudad_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TB_id_ciudad.KeyPress
        If Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub BTN_nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_nuevo.Click

        TB_nombre.Text = ""
        TB_id_ciudad.Text = ""

        CB_estado.SelectedIndex = -1
        TB_nombre.Focus()
    End Sub

    Private Sub DGV_ciudades_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGV_ciudades.CellContentClick


        Dim renglon As Integer
        Dim ciudad As New Ciudad


        renglon = DGV_ciudades.CurrentCellAddress.Y

        TB_nombre.Text = DGV_ciudades.Rows(renglon).Cells(1).Value
        TB_id_ciudad.Text = DGV_ciudades.Rows(renglon).Cells(0).Value

        CB_estado.SelectedItem = DGV_ciudades.Rows(renglon).Cells(2).Value

    End Sub

    Private Sub BTN_eliminar_Click(sender As System.Object, e As System.EventArgs) Handles BTN_eliminar.Click

        'ES IMPORTANTE QUE CONSTRUYAS TU NUEVA CIUDAD (OBJETO) EN EL MISMO ORDEN QUE VA RESIVIR LOS DATOS EN LA BD.

        Dim ciudad As New Ciudad(TB_id_ciudad.Text, idEstado, TB_nombre.Text)


        If ciudad.validarColonia() = True Then
            MsgBox("No se puede dar de baja la ciudad, tiene colonias registradas o faltan datos")
        Else
            If MessageBox.Show("¿Esta seguro?", "CONFIRMAR", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then

                ciudad.eliminarCiudad()
                MessageBox.Show("Registro Eliminado")
                ciudad.buscarCiudades(DGV_ciudades)
            End If
        End If
    End Sub


    Private Sub BTN_salir_Click(sender As System.Object, e As System.EventArgs) Handles BTN_salir.Click
        Dim openForm = New FormMenu()
        openForm.Show()
        Me.Close()
    End Sub

    Private Sub TB_id_ciudad_TextChanged(sender As Object, e As EventArgs) Handles TB_id_ciudad.TextChanged

        'Busca si la ciudad indicada tiene colonias, para deshabilitar el boton de eliminar.
        'por que si tiene colonias no se puede eliminar
        If Not IsNumeric(TB_id_ciudad.Text) Then
            ' MsgBox("Solo acepto Numeros...")
        Else
            Dim ciudad As New Ciudad(TB_id_ciudad.Text, CB_estado.Text, TB_nombre.Text)

            'Consulta el nombre de la ciudad, dado la clave
            If ciudad.consultaUnaCiudad() = True Then
                TB_nombre.Text = nombre
                CB_estado.Text = nomEdo
            Else
                TB_nombre.Text = ""
                CB_estado.Text = ""
            End If
                'Validamos si la ciudad tiene colonias, para saber si se puede borrar o no
                'deshabilitamos el boton de borrar
                If ciudad.validarColonia() = False Then
                BTN_eliminar.Enabled = True
            Else
                BTN_eliminar.Enabled = False
            End If
            cnx.Close()
        End If
    End Sub
End Class


