Public Class FormMenu
    Private Sub BTN_paticipantes_Click(sender As Object, e As EventArgs) Handles BTN_participantes.Click
        Dim openForm = New FormParticipantes()
        openForm.Show()
        Me.Close()
    End Sub

    Private Sub BTN_participaciones_Click(sender As Object, e As EventArgs) Handles BTN_participaciones.Click
        Dim openForm = New FormProgramaParticipantes()
        openForm.Show()
        Me.Close()
    End Sub

    Private Sub BTN_ciudades_Click(sender As Object, e As EventArgs) Handles BTN_ciudades.Click
        Dim openForm = New FormCiudades()
        openForm.Show()
        Me.Close()
    End Sub

    Private Sub BTN_estados_Click(sender As Object, e As EventArgs) Handles BTN_estados.Click
        Dim openForm = New FormEstados()
        openForm.Show()
        Me.Close()
    End Sub


    Private Sub BTN_colonias_Click(sender As Object, e As EventArgs) Handles BTN_colonias.Click
        Dim openForm = New FormColonias()
        openForm.Show()
        Me.Close()
    End Sub

    Private Sub BTN_generos_Click(sender As Object, e As EventArgs) Handles BTN_generos.Click
        Dim openForm = New FormGeneros()
        openForm.Show()
        Me.Close()
    End Sub

    Private Sub BTN_carreras_Click(sender As Object, e As EventArgs) Handles BTN_carreras.Click
        Dim openForm = New FormCarreras()
        openForm.Show()
        Me.Close()
    End Sub

    Private Sub BTN_jueces_Click(sender As Object, e As EventArgs) Handles BTN_jueces.Click
        Dim openForm = New FormJueces()
        openForm.Show()
        Me.Close()
    End Sub

    Private Sub BTN_auditorios_Click(sender As Object, e As EventArgs) Handles BTN_auditorios.Click
        Dim openForm = New FormAuditorios()
        openForm.Show()
        Me.Close()
    End Sub

    Private Sub BTN_calificaciones_Click(sender As Object, e As EventArgs) Handles BTN_calificaciones.Click
        Dim openForm = New FormCalificaciones()
        openForm.Show()
        Me.Close()
    End Sub

    Private Sub BTN_categorias_Click(sender As Object, e As EventArgs) Handles BTN_categorias.Click
        Dim openForm = New FormCategorias()
        openForm.Show()
        Me.Close()
    End Sub

    Private Sub BTN_salir_Click(sender As Object, e As EventArgs) Handles BTN_salir.Click
        Me.Close()
    End Sub
End Class