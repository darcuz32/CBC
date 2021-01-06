Imports Oracle.DataAccess.Client
Public Class Juez

    Public Sub New()

    End Sub
    Public Sub New(ByVal newMaterno As String, ByVal newPaterno As String, ByVal newNombre As String, ByVal newIdJuez As String)
        nombreJuez = newNombre
        paternoJuez = newPaterno
        maternoJuez = newMaterno
        idJuez = newIdJuez
    End Sub

    Public Function obtenerJueces() As Object
        Dim strSQL As String
        Dim xCnx As New Oracle

        strSQL = "SELECT id_juez as ID, nombre, paterno, materno" &
                 " FROM jueces "
        obtenerJueces = xCnx.objetoDataAdapter(strSQL)
    End Function


    Public Sub buscarJueces(ByVal DGV_jueces As DataGridView)
        DGV_jueces.DataSource = obtenerJueces()


        DGV_jueces.Refresh()

        DGV_jueces.Columns.Item(0).Width = 50
        DGV_jueces.Columns.Item(1).Width = 141
        DGV_jueces.Columns.Item(2).Width = 141
        DGV_jueces.Columns.Item(3).Width = 141
    End Sub

    Public Function buscarJuez() As Boolean
        Dim strSQL As String
        Dim xCnx As New Oracle
        Dim xDT As DataTable

        'Igual que en el insert, la parte fija de la sintaxis del UPDATE se escribe entre comillas,
        ' el simbolo & se usa para continuar la línea, y los valores en éste caso son las variables o las
        ' cajas de texto del formulario VARCHAR y DATE se esciben entre apostrofes

        strSQL = "SELECT id_juez as ID, nombre, paterno, materno " &
                 " FROM jueces " &
                 " WHERE id_juez =  '" & formDeJueces.TB_id_juez.Text & "'"

        buscarJuez = False
        xDT = xCnx.objetoDataAdapter(strSQL)
        If xDT.Rows.Count = 1 Then
            If IsDBNull(xDT.Rows(0)("Id")) Then
                idJuez = 0
            Else
                idJuez = CStr(xDT.Rows(0)("ID"))
                formDeJueces.TB_nombre_juez.Text = CStr(xDT.Rows(0)("nombre"))
                formDeJueces.TB_paterno_juez.Text = CStr(xDT.Rows(0)("paterno"))
                formDeJueces.TB_materno_juez.Text = CStr(xDT.Rows(0)("materno"))
            End If


            buscarJuez = True
        End If
    End Function

    Public Function obtenerIdJuez() As Boolean
        Dim strSQL As String
        Dim xCnx As New Oracle
        Dim xDT As DataTable

        strSQL = "SELECT id_juez as ID" &
                 " FROM jueces " &
                 " WHERE id_juez = " & formDeJueces.TB_id_juez.Text
        obtenerIdJuez = False
        xDT = xCnx.objetoDataAdapter(strSQL)
        If xDT.Rows.Count = 1 Then
            obtenerIdJuez = True
        End If
    End Function


    Public Sub agregarJuez()
        Dim strSql As String
        Dim xCnx As New Oracle

        If nombreJuez <> "" And paternoJuez <> "" And maternoJuez <> "" And idJuez <> "" Then
            strSql = "INSERT INTO jueces VALUES(" & idJuez & ", '" & nombreJuez & "', '" & paternoJuez & "', '" & maternoJuez & "')"
            xCnx.objetoCommand(strSql)
        Else
            MsgBox("Faltan datos ", MsgBoxStyle.Critical, "ATENCIÓN!!")
        End If
    End Sub

    Public Sub guardarJuez()
        Dim strSql As String
        Dim xCnx As New Oracle
        If nombreJuez <> "" And paternoJuez <> "" And maternoJuez <> "" And idJuez <> "" Then
            strSql = "UPDATE jueces " &
                     " set nombre='" & nombreJuez & "', paterno='" & paternoJuez & "', materno='" & maternoJuez & "'" &
                     " WHERE id_juez =" & idJuez
            xCnx.objetoCommand(strSql)
        Else
            MsgBox("Faltan datos", MsgBoxStyle.Critical, "ATENCIÓN!!")
        End If
    End Sub

    Public Function validarCalificaciones() As Boolean
        Dim strSQL As String
        Dim xCnx As New Oracle
        Dim xDT As DataTable
        validarCalificaciones = False
        If formDeJueces.TB_id_juez.Text <> "" Then
            strSQL = "SELECT * FROM calificaciones " &
                     " WHERE id_juez = " & formDeJueces.TB_id_juez.Text

            xDT = xCnx.objetoDataAdapter(strSQL)

            If xDT.Rows.Count >= 1 Then
                validarCalificaciones = True
            Else
                validarCalificaciones = False
            End If
        Else

        End If
    End Function

    Public Function validarRegistro() As Boolean
        Dim strSQL As String
        Dim xCnx As New Oracle
        Dim xDT As DataTable
        validarRegistro = False
        If formDeJueces.TB_id_juez.Text <> "" Then
            strSQL = "SELECT * FROM jueces " &
                     " WHERE id_juez = " & formDeJueces.TB_id_juez.Text

            xDT = xCnx.objetoDataAdapter(strSQL)

            If xDT.Rows.Count >= 1 Then
                validarRegistro = True
            Else
                validarRegistro = False
            End If
        Else

        End If
    End Function

    Public Sub eliminarJuez()
        Dim strSql As String
        Dim xCnx As New Oracle
        If nombreJuez <> "" And paternoJuez <> "" And maternoJuez <> "" And idJuez <> "" Then
            strSql = "DELETE FROM jueces " &
                     " WHERE id_juez = " & idJuez
            xCnx.objetoCommand(strSql)
        Else
            MsgBox("Faltan datos", MsgBoxStyle.Critical, "ATENCIÓN!!")
        End If
    End Sub
End Class
