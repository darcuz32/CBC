Imports Oracle.DataAccess.Client
Public Class Carrera

    Public Sub New()

    End Sub
    Public Sub New(ByVal newDesc As String, ByVal newIdCarrera As String)
        descCarrera = newDesc
        idCarrera = newIdCarrera
    End Sub

    Public Function obtenerCarreras() As Object
        Dim strSQL As String
        Dim xCnx As New Oracle

        strSQL = "SELECT id_carrera as ID, descripcion" &
                 " FROM carreras "
        obtenerCarreras = xCnx.objetoDataAdapter(strSQL)
    End Function


    Public Sub buscarCarreras(ByVal DGV_carreras As DataGridView)
        DGV_carreras.DataSource = obtenerCarreras()


        DGV_carreras.Refresh()

        DGV_carreras.Columns.Item(0).Width = 50
        DGV_carreras.Columns.Item(1).Width = 423
    End Sub

    Public Function buscarCarrera() As Boolean
        Dim strSQL As String
        Dim xCnx As New Oracle
        Dim xDT As DataTable

        'Igual que en el insert, la parte fija de la sintaxis del UPDATE se escribe entre comillas,
        ' el simbolo & se usa para continuar la línea, y los valores en éste caso son las variables o las
        ' cajas de texto del formulario VARCHAR y DATE se esciben entre apostrofes

        strSQL = "SELECT id_carrera as ID, descripcion " &
                 " FROM carreras " &
                 " WHERE id_carrera =  '" & formDeCarreras.TB_id_carrera.Text & "'"

        buscarCarrera = False
        xDT = xCnx.objetoDataAdapter(strSQL)
        If xDT.Rows.Count = 1 Then
            If IsDBNull(xDT.Rows(0)("Id")) Then
                idCarrera = 0
            Else
                idCarrera = CStr(xDT.Rows(0)("ID"))
                formDeCarreras.TB_desc_carrera.Text = CStr(xDT.Rows(0)("descripcion"))
            End If


            buscarCarrera = True
        End If
    End Function

    Public Function obtenerIdCarrera() As Boolean
        Dim strSQL As String
        Dim xCnx As New Oracle
        Dim xDT As DataTable

        strSQL = "SELECT id_carrera as ID" &
                 " FROM carreras " &
                 " WHERE id_carrera = " & formDeCarreras.TB_id_carrera.Text
        obtenerIdCarrera = False
        xDT = xCnx.objetoDataAdapter(strSQL)
        If xDT.Rows.Count = 1 Then
            obtenerIdCarrera = True
        End If
    End Function


    Public Sub agregarCarrera()
        Dim strSql As String
        Dim xCnx As New Oracle

        If descCarrera <> "" And idCarrera <> "" Then
            strSql = "INSERT INTO carreras VALUES(" & idCarrera & ", '" & descCarrera & "')"
            xCnx.objetoCommand(strSql)
        Else
            MsgBox("Faltan datos ", MsgBoxStyle.Critical, "ATENCIÓN!!")
        End If
    End Sub

    Public Sub guardarCarrera()
        Dim strSql As String
        Dim xCnx As New Oracle
        If descCarrera <> "" And idCarrera <> "" Then
            strSql = "UPDATE carreras " &
                     " set descripcion='" & descCarrera & "'" &
                     " WHERE id_carrera =" & idCarrera
            xCnx.objetoCommand(strSql)
        Else
            MsgBox("Faltan datos", MsgBoxStyle.Critical, "ATENCIÓN!!")
        End If
    End Sub

    Public Function validarParticipante() As Boolean
        Dim strSQL As String
        Dim xCnx As New Oracle
        Dim xDT As DataTable
        validarParticipante = False
        If formDeCarreras.TB_id_carrera.Text <> "" Then
            strSQL = "SELECT * FROM participantes " &
                     " WHERE id_carrera = " & formDeCarreras.TB_id_carrera.Text

            xDT = xCnx.objetoDataAdapter(strSQL)

            If xDT.Rows.Count >= 1 Then
                validarParticipante = True
            Else
                validarParticipante = False
            End If
        Else

        End If
    End Function

    Public Function validarRegistro() As Boolean
        Dim strSQL As String
        Dim xCnx As New Oracle
        Dim xDT As DataTable
        validarRegistro = False
        If formDeCarreras.TB_id_carrera.Text <> "" Then
            strSQL = "SELECT * FROM carreras " &
                     " WHERE id_carrera = " & formDeCarreras.TB_id_carrera.Text

            xDT = xCnx.objetoDataAdapter(strSQL)

            If xDT.Rows.Count >= 1 Then
                validarRegistro = True
            Else
                validarRegistro = False
            End If
        Else

        End If
    End Function

    Public Sub eliminarCarrera()
        Dim strSql As String
        Dim xCnx As New Oracle
        If descCarrera <> "" And idCarrera <> "" Then
            strSql = "DELETE FROM carreras " &
                     " WHERE id_carrera = " & idCarrera
            xCnx.objetoCommand(strSql)
        Else
            MsgBox("Faltan datos", MsgBoxStyle.Critical, "ATENCIÓN!!")
        End If
    End Sub
End Class
