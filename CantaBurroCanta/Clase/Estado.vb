Imports Oracle.DataAccess.Client
Public Class Estado
    Public Sub New()

    End Sub
    Public Sub New(ByVal newIdEstado As String, ByVal newNombre As String)
        idEstado = newIdEstado
        nombre = newNombre
    End Sub

    Public Function obtenerEstados() As Object
        Dim strSQL As String
        Dim xCnx As New Oracle

        strSQL = "SELECT id_estado as ID, " &
                 " nombre as Nombre " &
                 " FROM estados " &
                 " ORDER BY estados.nombre asc"
        obtenerEstados = xCnx.objetoDataAdapter(strSQL)
    End Function

    Public Sub buscarEstados(ByVal DGV_estados As DataGridView)
        DGV_estados.DataSource = obtenerEstados()

        DGV_estados.Refresh()

        DGV_estados.Columns.Item(0).Width = 55
        DGV_estados.Columns.Item(1).Width = 270

    End Sub
    Public Function obtenerIdEstado() As Boolean
        Dim strSQL As String
        Dim xCnx As New Oracle
        Dim xDT As DataTable

        strSQL = "SELECT id_estado as ID, " &
                 " nombre as Nombre " &
                 " FROM estados " &
                 " WHERE estados.id_estado = " & formDeEstados.TB_id_estado.Text &
                 " ORDER BY estados.nombre asc"
        obtenerIdEstado = False
        xDT = xCnx.objetoDataAdapter(strSQL)
        If xDT.Rows.Count = 1 Then
            obtenerIdEstado = True
        End If
    End Function
    Public Sub agregarEstado()
        Dim strSql As String
        Dim xCnx As New Oracle

        If idEstado <> "" And nombre <> "" Then
            strSql = "INSERT INTO estados VALUES(" & idEstado & ",'" & nombre & "')"
            xCnx.objetoCommand(strSql)
        Else
            MsgBox("Faltan datos ", MsgBoxStyle.Critical, "ATENCIÓN!!")
        End If
    End Sub
    Public Sub guardarEstado()
        Dim strSql As String
        Dim xCnx As New Oracle
        If idEstado <> "" And nombre <> "" Then
            strSql = "UPDATE estados " &
                     " set nombre='" & nombre & "'
                       WHERE id_estado =" & idEstado
            xCnx.objetoCommand(strSql)
        Else
            MsgBox("Faltan datos", MsgBoxStyle.Critical, "ATENCIÓN!!")
        End If
    End Sub
    Public Function validarCiudad() As Boolean
        Dim strSQL As String
        Dim xCnx As New Oracle
        Dim xDT As DataTable
        validarCiudad = False
        If formDeEstados.TB_id_estado.Text <> "" Then
            strSQL = "SELECT * FROM ciudades " &
                     " WHERE id_estado = " & formDeEstados.TB_id_estado.Text

            xDT = xCnx.objetoDataAdapter(strSQL)

            If xDT.Rows.Count >= 1 Then
                validarCiudad = True
            Else
                validarCiudad = False
            End If
        Else

        End If
    End Function

    Public Function validarRegistro() As Boolean
        Dim strSQL As String
        Dim xCnx As New Oracle
        Dim xDT As DataTable
        validarRegistro = False
        If formDeEstados.TB_id_estado.Text <> "" Then
            strSQL = "SELECT * FROM estados " &
                     " WHERE id_estado = " & formDeEstados.TB_id_estado.Text

            xDT = xCnx.objetoDataAdapter(strSQL)

            If xDT.Rows.Count >= 1 Then
                validarRegistro = True
            Else
                validarRegistro = False
            End If
        Else

        End If
    End Function
    Public Sub eliminarEstado()
        Dim strSql As String
        Dim xCnx As New Oracle
        If idEstado <> "" And nombre <> "" Then
            strSql = "DELETE FROM estados " &
                     " WHERE id_estado = " & idEstado
            xCnx.objetoCommand(strSql)
        Else
            MsgBox("Faltan datos", MsgBoxStyle.Critical, "ATENCIÓN!!")
        End If
    End Sub

    Public Function consultaUnEstado() As Boolean
        Dim strSQL As String
        Dim xCnx As New Oracle
        Dim xDT As DataTable

        strSQL = "SELECT * FROM estados " &
            " WHERE id_estado =" & idEstado

        consultaUnEstado = False
        xDT = xCnx.objetoDataAdapter(strSQL)
        If xDT.Rows.Count = 1 Then
            If IsDBNull(xDT.Rows(0)("id_estado")) Then
                idEstado = ""
            Else
                idEstado = CStr(xDT.Rows(0)("id_estado"))
            End If
            If IsDBNull(xDT.Rows(0)("nombre")) Then
                nombre = ""
            Else
                nombre = CStr(xDT.Rows(0)("nombre"))
            End If
            consultaUnEstado = True
        End If
    End Function
End Class
