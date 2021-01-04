Imports Oracle.DataAccess.Client
Public Class Auditorio

    Public Sub New()

    End Sub
    Public Sub New(ByVal newDesc As String, ByVal newIdAuditorio As String)
        descAuditorio = newDesc
        idAuditorio = newIdAuditorio
    End Sub

    Public Function obtenerAuditorios() As Object
        Dim strSQL As String
        Dim xCnx As New Oracle

        strSQL = "SELECT id_auditorio as ID, descripcion" &
                 " FROM auditorios "
        obtenerAuditorios = xCnx.objetoDataAdapter(strSQL)
    End Function


    Public Sub buscarAuditorios(ByVal DGV_auditorios As DataGridView)
        DGV_auditorios.DataSource = obtenerAuditorios()


        DGV_auditorios.Refresh()

        DGV_auditorios.Columns.Item(0).Width = 50
        DGV_auditorios.Columns.Item(1).Width = 423
    End Sub

    Public Function buscarAuditorio() As Boolean
        Dim strSQL As String
        Dim xCnx As New Oracle
        Dim xDT As DataTable

        'Igual que en el insert, la parte fija de la sintaxis del UPDATE se escribe entre comillas,
        ' el simbolo & se usa para continuar la línea, y los valores en éste caso son las variables o las
        ' cajas de texto del formulario VARCHAR y DATE se esciben entre apostrofes

        strSQL = "SELECT id_auditorio as ID, descripcion " &
                 " FROM auditorios " &
                 " WHERE id_auditorio =  '" & formDeAuditorios.TB_id_auditorio.Text & "'"

        buscarAuditorio = False
        xDT = xCnx.objetoDataAdapter(strSQL)
        If xDT.Rows.Count = 1 Then
            If IsDBNull(xDT.Rows(0)("Id")) Then
                idAuditorio = 0
            Else
                idAuditorio = CStr(xDT.Rows(0)("ID"))
                formDeAuditorios.TB_desc_auditorio.Text = CStr(xDT.Rows(0)("descripcion"))
            End If


            buscarAuditorio = True
        End If
    End Function

    Public Function obtenerIdAuditorio() As Boolean
        Dim strSQL As String
        Dim xCnx As New Oracle
        Dim xDT As DataTable

        strSQL = "SELECT id_auditorio as ID" &
                 " FROM auditorios " &
                 " WHERE id_auditorio = " & formDeAuditorios.TB_id_auditorio.Text
        obtenerIdAuditorio = False
        xDT = xCnx.objetoDataAdapter(strSQL)
        If xDT.Rows.Count = 1 Then
            obtenerIdAuditorio = True
        End If
    End Function


    Public Sub agregarAuditorio()
        Dim strSql As String
        Dim xCnx As New Oracle

        If descAuditorio <> "" And idAuditorio <> "" Then
            strSql = "INSERT INTO auditorios VALUES(" & idAuditorio & ", '" & descAuditorio & "')"
            xCnx.objetoCommand(strSql)
        Else
            MsgBox("Faltan datos ", MsgBoxStyle.Critical, "ATENCIÓN!!")
        End If
    End Sub

    Public Sub guardarAuditorio()
        Dim strSql As String
        Dim xCnx As New Oracle
        If descAuditorio <> "" And idAuditorio <> "" Then
            strSql = "UPDATE auditorios " &
                     " set descripcion='" & descAuditorio & "'" &
                     " WHERE id_auditorio =" & idAuditorio
            xCnx.objetoCommand(strSql)
        Else
            MsgBox("Faltan datos", MsgBoxStyle.Critical, "ATENCIÓN!!")
        End If
    End Sub

    Public Function validarParticipaciones() As Boolean
        Dim strSQL As String
        Dim xCnx As New Oracle
        Dim xDT As DataTable
        validarParticipaciones = True
        If descAuditorio <> "" And idAuditorio <> "" Then
            strSQL = "SELECT * FROM programaparticipantes " &
                     " WHERE id_auditorio = " & idAuditorio

            xDT = xCnx.objetoDataAdapter(strSQL)

            If xDT.Rows.Count >= 1 Then
                validarParticipaciones = True
            Else
                validarParticipaciones = False
            End If
        Else
            MsgBox("Faltan datos", MsgBoxStyle.Critical, "ATENCIÓN!!")
        End If
    End Function

    Public Sub eliminarAuditorio()
        Dim strSql As String
        Dim xCnx As New Oracle
        If descAuditorio <> "" And idAuditorio <> "" Then
            strSql = "DELETE FROM auditorios " &
                     " WHERE id_auditorio = " & idAuditorio
            xCnx.objetoCommand(strSql)
        Else
            MsgBox("Faltan datos", MsgBoxStyle.Critical, "ATENCIÓN!!")
        End If
    End Sub
End Class
