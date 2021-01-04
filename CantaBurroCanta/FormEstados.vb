Public Class FormEstados
    Private Sub FormEstados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim estado As New Estado
        formDeEstados = Me

        estado.buscarEstados(DGV_estados)
        cnx.Close()

        Me.ToolTip1.SetToolTip(Me.BTN_nuevo, "Clic para limpiar cajas de texto ...")
        Me.ToolTip1.SetToolTip(Me.BTN_guardar, "Clic para Guardar información en el sistema...")
        Me.ToolTip1.SetToolTip(Me.BTN_eliminar, "Clic para Eliminar información en el sistema...")
    End Sub

    Private Sub BTN_guardar_Click(sender As Object, e As EventArgs) Handles BTN_guardar.Click
        If TB_id_estado.Text = "" Then
            MessageBox.Show("Capturar id del estado")
        ElseIf TB_nombre_estado.Text = "" Then
            MessageBox.Show("Capturar nombre del estado")
        Else

            Dim estado As New Estado(TB_id_estado.Text, TB_nombre_estado.Text)

            If estado.obtenerIdEstado() = False Then
                estado.agregarEstado()

                MessageBox.Show("Estado Registrado ...")
            Else
                estado.guardarEstado()
                MsgBox("Estado modificado ...")
            End If

            estado.buscarEstados(DGV_estados)
        End If

    End Sub


    Private Sub TB_id_estado_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TB_id_estado.KeyPress
        If Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub BTN_nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_nuevo.Click

        TB_nombre_estado.Text = ""
        TB_id_estado.Text = ""

        TB_id_estado.Focus()
    End Sub

    Private Sub DGV_estados_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGV_estados.CellContentClick


        Dim renglon As Integer
        Dim estado As New Estado


        renglon = DGV_estados.CurrentCellAddress.Y
        TB_id_estado.Text = DGV_estados.Rows(renglon).Cells(0).Value
        TB_nombre_estado.Text = DGV_estados.Rows(renglon).Cells(1).Value

    End Sub

    Private Sub BTN_eliminar_Click(sender As System.Object, e As System.EventArgs) Handles BTN_eliminar.Click

        Dim estado As New Estado(TB_id_estado.Text, TB_nombre_estado.Text)


        If estado.validarCiudad() = True Then
            MsgBox("No se puede dar de baja el estado, tiene ciudades registradas o faltan datos")
        Else
            If MessageBox.Show("¿Esta seguro?", "CONFIRMAR", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then

                estado.eliminarEstado()
                MessageBox.Show("Registro Eliminado")
                estado.buscarEstados(DGV_estados)

            End If
        End If
    End Sub


    Private Sub BTN_salir_Click(sender As System.Object, e As System.EventArgs) Handles BTN_salir.Click
        Dim openForm = New FormMenu()
        openForm.Show()
        Me.Close()
    End Sub

    Private Sub TB_id_estado_TextChanged(sender As Object, e As EventArgs) Handles TB_id_estado.TextChanged
        'Busca si el estado indicado tiene ciudades, para deshabilitar el boton de eliminar.
        'por que si tiene ciudades no se puede eliminar
        If Not IsNumeric(TB_id_estado.Text) Then
            ' MsgBox("Solo acepto Numeros...")
        Else
            Dim estado As New Estado(TB_id_estado.Text, TB_nombre_estado.Text)
            'Consulta el nombre del estado, dado la clave
            If estado.consultaUnEstado() = True Then
                TB_nombre_estado.Text = nombre
            Else
                TB_nombre_estado.Text = ""
            End If
            'Validamos si el Estado tiene ciudades, para saber si se puede borrar o no
            'deshabilitamos el boton de borrar
            If estado.validarCiudad() = False Then
                BTN_eliminar.Enabled = True
            Else
                BTN_eliminar.Enabled = False
            End If
            cnx.Close()
        End If
    End Sub

    Private Sub TB_id_estado_LostFocus(sender As Object, e As EventArgs) Handles TB_id_estado.LostFocus

    End Sub
End Class