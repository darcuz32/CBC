Imports Oracle.DataAccess.Client
Public Class ProgramaParticipantes

    Public Sub New()

    End Sub
    Public Sub New(ByVal newIdCategoria As String, ByVal newIdAuditorio As String, ByVal newFecha As String, ByVal newIdParticipante As String)
        idCategoria = newIdCategoria
        idAuditorio = newIdAuditorio
        fecha = newFecha
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

    Public Sub buscarAuditorios(ByVal objeto As ComboBox)
        Dim Lista As OracleDataReader
        Dim strSql As String
        Dim xCnx As New Oracle

        strSql = "SELECT descripcion FROM auditorios Order By descripcion asc"
        Lista = xCnx.objetoDataReader(strSql)

        objeto.Items.Clear()

        While Lista.Read()
            objeto.Items.Add(Lista.GetValue(0))
        End While
        Lista.Close()
    End Sub

    Public Function obtenerPrograma() As Object
        Dim strSQL As String
        Dim xCnx As New Oracle

        strSQL = "SELECT CONCAT(CONCAT(CONCAT(CONCAT(participantes.nombre, ' '), participantes.paterno), ' '), participantes.materno) as Participante, programaparticipantes.fecha_participacion as Fecha, auditorios.descripcion as Auditorio, categorias.descripcion as Categoria " &
                 " FROM programaparticipantes " &
                 " INNER JOIN participantes ON participantes.id_participante = programaparticipantes.id_participante " &
                 " INNER JOIN categorias ON categorias.id_categoria = programaparticipantes.id_categoria " &
                 " INNER JOIN auditorios ON auditorios.id_auditorio = programaparticipantes.id_auditorio " &
                  " ORDER BY participantes.paterno, participantes.materno asc"
        obtenerPrograma = xCnx.objetoDataAdapter(strSQL)
    End Function


    Public Sub buscarPrograma(ByVal DGV_participantes As DataGridView)
        DGV_participantes.DataSource = obtenerPrograma()

        DGV_participantes.Refresh()

        DGV_participantes.Columns.Item(0).Width = 150
        DGV_participantes.Columns.Item(1).Width = 100
        DGV_participantes.Columns.Item(2).Width = 130
        DGV_participantes.Columns.Item(3).Width = 100
    End Sub

    Public Function obtenerIdParticipante() As Boolean
        Dim strSQL As String
        Dim xCnx As New Oracle
        Dim xDT As DataTable

        strSQL = "SELECT id_participante FROM participantes " &
                 "WHERE CONCAT(CONCAT(CONCAT(CONCAT(participantes.nombre, ' '), participantes.paterno), ' '), participantes.materno)='" & formDeProgramaParticipantes.CB_participante.Text & "'"
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
                 "WHERE descripcion='" & formDeProgramaParticipantes.CB_categoria.Text & "'"
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

    Public Function obtenerIdAuditorio() As Boolean
        Dim strSQL As String
        Dim xCnx As New Oracle
        Dim xDT As DataTable
        strSQL = "SELECT id_auditorio FROM auditorios " &
                 "WHERE descripcion='" & formDeProgramaParticipantes.CB_auditorio.Text & "'"
        obtenerIdAuditorio = False
        xDT = xCnx.objetoDataAdapter(strSQL)
        If xDT.Rows.Count = 1 Then
            If IsDBNull(xDT.Rows(0)("id_auditorio")) Then
                idAuditorio = ""
            Else
                idAuditorio = CStr(xDT.Rows(0)("id_auditorio"))
            End If
            obtenerIdAuditorio = True
        End If
    End Function

    Public Function obtenerIdPrograma() As Boolean
        Dim strSQL As String
        Dim xCnx As New Oracle
        Dim xDT As DataTable
        strSQL = "SELECT programaparticipantes.id_participante as ID" &
                 " FROM programaparticipantes " &
                 " INNER JOIN participantes ON participantes.id_participante = programaparticipantes.id_participante " &
                 " WHERE programaparticipantes.id_participante = " & idParticipante &
                 " AND programaparticipantes.id_categoria = " & idCategoria &
                 " ORDER BY participantes.paterno, participantes.materno asc"
        obtenerIdPrograma = False
        xDT = xCnx.objetoDataAdapter(strSQL)
        If xDT.Rows.Count = 1 Then
            obtenerIdPrograma = True
        End If
    End Function


    Public Sub agregarPrograma()
        Dim strSql As String
        Dim xCnx As New Oracle

        If idCategoria <> 0 And idAuditorio <> 0 And idParticipante <> 0 And fecha <> "" Then
            strSql = "INSERT INTO programaparticipantes VALUES(" & idParticipante & ", " & idCategoria & ", '" & fecha & "', " & idAuditorio & ")"
            xCnx.objetoCommand(strSql)
        Else
            MsgBox("Faltan datos ", MsgBoxStyle.Critical, "ATENCIÓN!!")
        End If
    End Sub

    Public Sub guardarPrograma()
        Dim strSql As String
        Dim xCnx As New Oracle
        If idCategoria <> 0 And idAuditorio <> 0 And idParticipante <> 0 And fecha <> "" Then

            strSql = "UPDATE programaparticipantes " &
                     " set id_participante=" & idParticipante & ", id_categoria=" & idCategoria & ", id_auditorio=" & idAuditorio & ", " &
                     " fecha_participacion='" & fecha & "' " &
                     " WHERE id_participante =" & idParticipante &
                     " AND id_categoria =" & idCategoria
            xCnx.objetoCommand(strSql)
        Else
            MsgBox("Faltan datos", MsgBoxStyle.Critical, "ATENCIÓN!!")
        End If
    End Sub

    Public Function validarCalificaciones() As Boolean
        Dim strSQL As String
        Dim xCnx As New Oracle
        Dim xDT As DataTable
        validarCalificaciones = True

        If idCategoria <> 0 And idAuditorio <> 0 And idParticipante <> 0 And fecha <> "" Then
            strSQL = "SELECT * FROM calificaciones " &
                     " WHERE id_participante = " & idParticipante &
                     " AND id_categoria = " & idCategoria

            xDT = xCnx.objetoDataAdapter(strSQL)

            If xDT.Rows.Count >= 1 Then
                validarCalificaciones = True
            Else
                validarCalificaciones = False
            End If
        Else
            MsgBox("Faltan datos", MsgBoxStyle.Critical, "ATENCIÓN!!")
        End If
    End Function

    Public Sub eliminarPrograma()
        Dim strSql As String
        Dim xCnx As New Oracle

        If idCategoria <> 0 And idAuditorio <> 0 And idParticipante <> 0 And fecha <> "" Then
            strSql = "DELETE FROM programaparticipantes " &
                     " WHERE id_participante = " & idParticipante &
                     " AND id_categoria = " & idCategoria
            xCnx.objetoCommand(strSql)
        Else
            MsgBox("Faltan datos", MsgBoxStyle.Critical, "ATENCIÓN!!")
        End If
    End Sub
End Class

