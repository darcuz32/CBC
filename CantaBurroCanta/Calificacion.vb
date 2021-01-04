Imports Oracle.DataAccess.Client
Public Class Calificacion

    Public Sub New()

    End Sub
    Public Sub New(ByVal newIdCategoria As String, ByVal newIdJuez As String, ByVal newCalificacion As String, ByVal newIdParticipante As String)
        idCategoria = newIdCategoria
        idJuez = newIdJuez
        calif = newCalificacion
        idParticipante = newIdParticipante
    End Sub


    Public Sub buscarParticipantes(ByVal objeto As ComboBox)
        Dim Lista As OracleDataReader
        Dim strSql As String
        Dim xCnx As New Oracle

        strSql = "SELECT CONCAT(CONCAT(CONCAT(CONCAT(nombre, ' '), paterno), ' '), materno) FROM participantes Order By paterno,materno asc"
        Lista = xCnx.objetoDataReader(strSql)

        objeto.Items.Clear()

        While Lista.Read()
            objeto.Items.Add(Lista.GetValue(0))
        End While
        Lista.Close()
    End Sub


    Public Sub buscarCategorias(ByVal objeto As ComboBox)
        Dim Lista As OracleDataReader
        Dim strSql As String
        Dim xCnx As New Oracle

        strSql = "SELECT descripcion FROM categorias Order By descripcion asc"
        Lista = xCnx.objetoDataReader(strSql)

        objeto.Items.Clear()

        While Lista.Read()
            objeto.Items.Add(Lista.GetValue(0))
        End While
        Lista.Close()
    End Sub

    Public Sub buscarJueces(ByVal objeto As ComboBox)
        Dim Lista As OracleDataReader
        Dim strSql As String
        Dim xCnx As New Oracle

        strSql = "SELECT CONCAT(CONCAT(CONCAT(CONCAT(jueces.nombre, ' '), jueces.paterno), ' '), jueces.materno) FROM jueces Order By jueces.paterno,jueces.materno asc"
        Lista = xCnx.objetoDataReader(strSql)

        objeto.Items.Clear()

        While Lista.Read()
            objeto.Items.Add(Lista.GetValue(0))
        End While
        Lista.Close()
    End Sub

    Public Function obtenerCalificaciones() As Object
        Dim strSQL As String
        Dim xCnx As New Oracle

        strSQL = "SELECT CONCAT(CONCAT(CONCAT(CONCAT(participantes.nombre, ' '), participantes.paterno), ' '), participantes.materno) as Participante, calificaciones.calif as Calificacion, CONCAT(CONCAT(CONCAT(CONCAT(jueces.nombre, ' '), jueces.paterno), ' '), jueces.materno) as Juez, categorias.descripcion as Categoria " &
                 " FROM calificaciones " &
                 " INNER JOIN participantes ON participantes.id_participante = calificaciones.id_participante " &
                 " INNER JOIN categorias ON categorias.id_categoria = calificaciones.id_categoria " &
                 " INNER JOIN jueces ON jueces.id_juez = calificaciones.id_juez " &
                  " ORDER BY participantes.paterno, participantes.materno asc"
        obtenerCalificaciones = xCnx.objetoDataAdapter(strSQL)
    End Function


    Public Sub buscarCalificaciones(ByVal DGV_calificaciones As DataGridView)
        DGV_calificaciones.DataSource = obtenerCalificaciones()

        DGV_calificaciones.Refresh()

        DGV_calificaciones.Columns.Item(0).Width = 150
        DGV_calificaciones.Columns.Item(1).Width = 100
        DGV_calificaciones.Columns.Item(2).Width = 130
        DGV_calificaciones.Columns.Item(3).Width = 100
    End Sub

    Public Function obtenerIdParticipante() As Boolean
        Dim strSQL As String
        Dim xCnx As New Oracle
        Dim xDT As DataTable

        strSQL = "SELECT id_participante FROM participantes " &
                 "WHERE CONCAT(CONCAT(CONCAT(CONCAT(participantes.nombre, ' '), participantes.paterno), ' '), participantes.materno)='" & formDeCalificaciones.CB_participante.Text & "'"
        obtenerIdParticipante = False
        xDT = xCnx.objetoDataAdapter(strSQL)
        If xDT.Rows.Count = 1 Then
            If IsDBNull(xDT.Rows(0)("id_participante")) Then
                idParticipante = ""
            Else
                idParticipante = CStr(xDT.Rows(0)("id_participante"))
            End If
            obtenerIdParticipante = True
        End If
    End Function

    Public Function obtenerIdCategoria() As Boolean
        Dim strSQL As String
        Dim xCnx As New Oracle
        Dim xDT As DataTable

        strSQL = "SELECT id_categoria FROM categorias " &
                 "WHERE descripcion='" & formDeCalificaciones.CB_categoria.Text & "'"
        obtenerIdCategoria = False
        xDT = xCnx.objetoDataAdapter(strSQL)
        If xDT.Rows.Count = 1 Then
            If IsDBNull(xDT.Rows(0)("id_categoria")) Then
                idCategoria = ""
            Else
                idCategoria = CStr(xDT.Rows(0)("id_categoria"))
            End If
            obtenerIdCategoria = True
        End If
    End Function

    Public Function obtenerIdJuez() As Boolean
        Dim strSQL As String
        Dim xCnx As New Oracle
        Dim xDT As DataTable
        strSQL = "SELECT id_juez FROM jueces " &
                 "WHERE CONCAT(CONCAT(CONCAT(CONCAT(jueces.nombre, ' '), jueces.paterno), ' '), jueces.materno)='" & formDeCalificaciones.CB_juez.Text & "'"
        obtenerIdJuez = False
        xDT = xCnx.objetoDataAdapter(strSQL)
        If xDT.Rows.Count = 1 Then
            If IsDBNull(xDT.Rows(0)("id_juez")) Then
                idJuez = ""
            Else
                idJuez = CStr(xDT.Rows(0)("id_juez"))
            End If
            obtenerIdJuez = True
        End If
    End Function

    Public Function obtenerIdCalificacion() As Boolean
        Dim strSQL As String
        Dim xCnx As New Oracle
        Dim xDT As DataTable
        strSQL = "SELECT calificaciones.id_participante as ID" &
                 " FROM calificaciones " &
                 " INNER JOIN participantes ON participantes.id_participante = calificaciones.id_participante " &
                 " WHERE calificaciones.id_participante = " & idParticipante &
                 " AND calificaciones.id_categoria = " & idCategoria &
                 " AND calificaciones.id_juez = " & idJuez &
                 " ORDER BY participantes.paterno, participantes.materno asc"
        obtenerIdCalificacion = False
        xDT = xCnx.objetoDataAdapter(strSQL)
        If xDT.Rows.Count = 1 Then
            obtenerIdCalificacion = True
        End If
    End Function

    Public Function verificarParticipacion() As Boolean
        Dim strSQL As String
        Dim xCnx As New Oracle
        Dim xDT As DataTable
        verificarParticipacion = False
        If idCategoria <> 0 And idParticipante <> 0 Then
            strSQL = "SELECT * FROM programaparticipantes " &
                     " WHERE id_participante = " & idParticipante &
                     " AND  id_categoria = " & idCategoria

            xDT = xCnx.objetoDataAdapter(strSQL)

            If xDT.Rows.Count >= 1 Then
                verificarParticipacion = True
            Else
                verificarParticipacion = False
            End If
        Else

        End If
    End Function

    Public Sub agregarCalificacion()
        Dim strSql As String
        Dim xCnx As New Oracle

        If idCategoria <> 0 And idJuez <> 0 And idParticipante <> 0 And calif <> "" Then
            strSql = "INSERT INTO calificaciones VALUES(" & idParticipante & ", " & idCategoria & ", " & idJuez & ", " & calif & ")"
            xCnx.objetoCommand(strSql)
        Else
            MsgBox("Faltan datos ", MsgBoxStyle.Critical, "ATENCIÓN!!")
        End If
    End Sub

    Public Sub guardarCalificacion()
        Dim strSql As String
        Dim xCnx As New Oracle
        If idCategoria <> 0 And idJuez <> 0 And idParticipante <> 0 And calif <> "" Then

            strSql = "UPDATE calificaciones " &
                     " set id_participante=" & idParticipante & ", id_categoria=" & idCategoria & ", id_juez=" & idJuez & ", " &
                     " calif='" & calif & "' " &
                     " WHERE id_participante =" & idParticipante &
                     " AND id_categoria =" & idCategoria &
                     " AND id_juez =" & idJuez
            xCnx.objetoCommand(strSql)
        Else
            MsgBox("Faltan datos", MsgBoxStyle.Critical, "ATENCIÓN!!")
        End If
    End Sub

    Public Sub eliminarCalificacion()
        Dim strSql As String
        Dim xCnx As New Oracle

        If idCategoria <> 0 And idJuez <> 0 And idParticipante <> 0 And calif <> "" Then
            strSql = "DELETE FROM calificaciones " &
                     " WHERE id_participante = " & idParticipante &
                     " AND id_categoria = " & idCategoria &
                     " AND id_juez = " & idJuez
            xCnx.objetoCommand(strSql)
        Else
            MsgBox("Faltan datos", MsgBoxStyle.Critical, "ATENCIÓN!!")
        End If
    End Sub
End Class

