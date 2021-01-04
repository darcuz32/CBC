Public Class FormLogin

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Dim usuario As New Login(UsernameTextBox.Text, PasswordTextBox.Text)
        'Validamos si el usuario que intenta acceder al sistema está registrado
        'éste usuario es un registro de la tabla de usuarios, NO ES el usuario
        'de ORACLE, el el usuario final
        If usuario.consultaUsuario() = False Then
            MsgBox("Usuario no registrado, favor de llamar al ADMINISTRADOR del sistema", MsgBoxStyle.Exclamation)
            cnx.Close()
        Else
            ' si está registrado el usuario, cerramos la conexión a la BD
            cnx.Close()
            ' presentamos la pantalla del Menú del sistema
            FormMenu.Show()
            ' descargamos la pantalla actual LOGIN
            Me.Hide()
        End If
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        End
    End Sub

    Private Sub FormLogin_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Label1.Text = "Hoy es " & Today
        Me.ToolTip1.SetToolTip(Me.OK, "Clic para ingresar al sistema...")
        Me.ToolTip1.SetToolTip(Me.Cancel, "Clic para salir del sistema...")
        Me.ToolTip1.SetToolTip(Me.UsernameTextBox, "Ingrese su nombre de usuario ...")
        Me.ToolTip1.SetToolTip(Me.PasswordTextBox, "Ingrese su contraseña ...")
    End Sub

    Private Sub UsernameTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles UsernameTextBox.KeyPress
        If e.KeyChar = "'" Or e.KeyChar = "''" Or e.KeyChar = "#" Then
            e.KeyChar = ""
        End If
    End Sub

End Class











