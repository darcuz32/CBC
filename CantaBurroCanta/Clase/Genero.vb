Imports Oracle.DataAccess.Client
Public Class Genero

    Public Sub New()

    End Sub
    Public Sub New(ByVal newDesc As String, ByVal newIdGenero As String)
        descGenero = newDesc
        idGenero = newIdGenero
    End Sub

    Public Function obtenerGeneros() As Object
        Dim strSQL As String
        Dim xCnx As New Oracle

        strSQL = "SELECT id_genero as ID, descripcion" &
                 " FROM generos "
        obtenerGeneros = xCnx.objetoDataAdapter(strSQL)
    End Function


    Public Sub buscarGeneros(ByVal DGV_generos As DataGridView)
        DGV_generos.DataSource = obtenerGeneros()


        DGV_generos.Refresh()

        DGV_generos.Columns.Item(0).Width = 50
        DGV_generos.Columns.Item(1).Width = 423
    End Sub

    Public Function buscarGenero() As Boolean
        Dim strSQL As String
        Dim xCnx As New Oracle
        Dim xDT As DataTable

        'Igual que en el insert, la parte fija de la sintaxis del UPDATE se escribe entre comillas,
        ' el simbolo & se usa para continuar la línea, y los valores en éste caso son las variables o las
        ' cajas de texto del formulario VARCHAR y DATE se esciben entre apostrofes

        strSQL = "SELECT id_genero as ID, descripcion " &
                 " FROM generos " &
                 " WHERE id_genero =  '" & formDeGeneros.TB_id_genero.Text & "'"

        buscarGenero = False
        xDT = xCnx.objetoDataAdapter(strSQL)
        If xDT.Rows.Count = 1 Then
            If IsDBNull(xDT.Rows(0)("Id")) Then
                idGenero = 0
            Else
                idGenero = CStr(xDT.Rows(0)("ID"))
                formDeGeneros.TB_desc_genero.Text = CStr(xDT.Rows(0)("descripcion"))
            End If


            buscarGenero = True
        End If
    End Function

    Public Function obtenerIdGenero() As Boolean
        Dim strSQL As String
        Dim xCnx As New Oracle
        Dim xDT As DataTable

        strSQL = "SELECT id_genero as ID" &
                 " FROM generos " &
                 " WHERE id_genero = " & formDeGeneros.TB_id_genero.Text
        obtenerIdGenero = False
        xDT = xCnx.objetoDataAdapter(strSQL)
        If xDT.Rows.Count = 1 Then
            obtenerIdGenero = True
        End If
    End Function


    Public Sub agregarGenero()
        Dim strSql As String
        Dim xCnx As New Oracle

        If descGenero <> "" And idGenero <> "" Then
            strSql = "INSERT INTO generos VALUES(" & idGenero & ", '" & descGenero & "')"
            xCnx.objetoCommand(strSql)
        Else
            MsgBox("Faltan datos ", MsgBoxStyle.Critical, "ATENCIÓN!!")
        End If
    End Sub

    Public Sub guardarGenero()
        Dim strSql As String
        Dim xCnx As New Oracle
        If descGenero <> "" And idGenero <> "" Then
            strSql = "UPDATE generos " &
                     " set descripcion='" & descGenero & "'" &
                     " WHERE id_genero =" & idGenero
            xCnx.objetoCommand(strSql)
        Else
            MsgBox("Faltan datos", MsgBoxStyle.Critical, "ATENCIÓN!!")
        End If
    End Sub

    Public Function validarParticipante() As Boolean
        Dim strSQL As String
        Dim xCnx As New Oracle
        Dim xDT As DataTable
        validarParticipante = True
        If formDeGeneros.TB_id_genero.Text <> "" Then
            strSQL = "SELECT * FROM participantes " &
                     " WHERE id_genero = " & formDeGeneros.TB_id_genero.Text

            xDT = xCnx.objetoDataAdapter(strSQL)

            If xDT.Rows.Count >= 1 Then
                validarParticipante = True
            Else
                validarParticipante = False
            End If
        Else
            MsgBox("Faltan datos", MsgBoxStyle.Critical, "ATENCIÓN!!")
        End If
    End Function

    Public Function validarRegistro() As Boolean
        Dim strSQL As String
        Dim xCnx As New Oracle
        Dim xDT As DataTable
        validarRegistro = True
        If formDeGeneros.TB_id_genero.Text <> "" Then
            strSQL = "SELECT * FROM generos " &
                     " WHERE id_genero = " & formDeGeneros.TB_id_genero.Text

            xDT = xCnx.objetoDataAdapter(strSQL)

            If xDT.Rows.Count >= 1 Then
                validarRegistro = True
            Else
                validarRegistro = False
            End If
        Else
            MsgBox("Faltan datos", MsgBoxStyle.Critical, "ATENCIÓN!!")
        End If
    End Function

    Public Sub eliminarGenero()
        Dim strSql As String
        Dim xCnx As New Oracle
        If descGenero <> "" And idGenero <> "" Then
            strSql = "DELETE FROM generos " &
                     " WHERE id_genero = " & idGenero
            xCnx.objetoCommand(strSql)
        Else
            MsgBox("Faltan datos", MsgBoxStyle.Critical, "ATENCIÓN!!")
        End If
    End Sub
End Class
