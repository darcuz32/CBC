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

    Private Sub BTN_salir_Click(sender As Object, e As EventArgs) Handles BTN_salir.Click
        Me.Close()
    End Sub

    Private Sub BTN_estados_Click(sender As Object, e As EventArgs) Handles BTN_estados.Click

    End Sub
End Class