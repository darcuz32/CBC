Imports Oracle.DataAccess.Client
Public Class Participante

    Public Sub New()

    End Sub
    Public Sub New(ByVal newIdCarrera As String, ByVal newIdColonia As String, ByVal newIdGenero As String, ByVal newNombre As String, ByVal newPaterno As String, ByVal newMaterno As String, ByVal newEdad As String, ByVal newIdParticipante As String)
        idCarrera = newIdCarrera
        idColonia = newIdColonia
        idGenero = newIdGenero
        nombre = newNombre
        paterno = newPaterno
        materno = newMaterno
        edad = newEdad
        idParticipante = newIdParticipante
    End Sub


    Public Sub buscarCarreras(ByVal objeto As ComboBox)
        Dim Lista As OracleDataReader
        Dim strSql As String
        Dim xCnx As New Oracle

        strSql = "SELECT descripcion FROM carreras Order By descripcion asc"
        Lista = xCnx.objetoDataReader(strSql)

        objeto.Items.Clear()

        While Lista.Read()
            objeto.Items.Add(Lista.GetValue(0))
        End While
        Lista.Close()
    End Sub


    Public Sub buscarGeneros(ByVal objeto As ComboBox)
        Dim Lista As OracleDataReader
        Dim strSql As String
        Dim xCnx As New Oracle


        strSql = "SELECT descripcion FROM generos Order By descripcion asc"
        Lista = xCnx.objetoDataReader(strSql)

        objeto.Items.Clear()

        While Lista.Read()
            objeto.Items.Add(Lista.GetValue(0))
        End While
        Lista.Close()
    End Sub

    Public Sub buscarColonias(ByVal objeto As ComboBox)
        Dim Lista As OracleDataReader
        Dim strSql As String
        Dim xCnx As New Oracle

        strSql = "SELECT nombre FROM colonias Order By nombre asc"
        Lista = xCnx.objetoDataReader(strSql)

        objeto.Items.Clear()

        While Lista.Read()
            objeto.Items.Add(Lista.GetValue(0))
        End While
        Lista.Close()
    End Sub

    Public Function buscarCarrera() As Integer
        Dim strSQL As String
        Dim xCnx As New Oracle
        Dim xDT As DataTable

        strSQL = "SELECT id_carrera FROM participantes " &
                 "WHERE id_participante='" & formDeParticipantes.TB_id_participante.Text & "'"
        buscarCarrera = -1
        xDT = xCnx.objetoDataAdapter(strSQL)
        If xDT.Rows.Count = 1 Then
            If IsDBNull(xDT.Rows(0)("id_carrera")) Then
                buscarCarrera = -1
            Else
                buscarCarrera = CStr(xDT.Rows(0)("id_carrera"))
            End If

        End If
    End Function

    Public Function buscarColonia() As Integer
        Dim strSQL As String
        Dim xCnx As New Oracle
        Dim xDT As DataTable

        strSQL = "SELECT id_colonia FROM participantes " &
                 "WHERE id_participante='" & formDeParticipantes.TB_id_participante.Text & "'"
        buscarColonia = -1
        xDT = xCnx.objetoDataAdapter(strSQL)
        If xDT.Rows.Count = 1 Then
            If IsDBNull(xDT.Rows(0)("id_colonia")) Then
                buscarColonia = -1
            Else
                buscarColonia = CStr(xDT.Rows(0)("id_colonia"))
            End If

        End If
    End Function


    Public Function buscarGenero() As Integer
        Dim strSQL As String
        Dim xCnx As New Oracle
        Dim xDT As DataTable

        strSQL = "SELECT id_genero FROM participantes " &
                 "WHERE id_participante='" & formDeParticipantes.TB_id_participante.Text & "'"
        buscarGenero = -1
        xDT = xCnx.objetoDataAdapter(strSQL)
        If xDT.Rows.Count = 1 Then
            If IsDBNull(xDT.Rows(0)("id_genero")) Then
                buscarGenero = -1
            Else
                buscarGenero = CStr(xDT.Rows(0)("id_genero"))
            End If

        End If
    End Function

    Public Function obtenerParticipantes() As Object
        Dim strSQL As String
        Dim xCnx As New Oracle

        strSQL = "SELECT id_participante as ID, participantes.nombre as Nombre, participantes.paterno as Paterno, participantes.materno as Materno, " &
                 " colonias.nombre as Colonia, carreras.descripcion as Carrera, generos.descripcion as Genero, participantes.edad as Edad " &
                 " FROM participantes " &
                 " INNER JOIN colonias ON colonias.id_colonia = participantes.id_colonia " &
                 " INNER JOIN carreras ON carreras.id_carrera = participantes.id_carrera " &
                 " INNER JOIN generos ON generos.id_genero = participantes.id_genero " &
                  " ORDER BY participantes.paterno, participantes.materno asc"
        obtenerParticipantes = xCnx.objetoDataAdapter(strSQL)
    End Function


    Public Sub buscarParticipantes(ByVal DGV_participantes As DataGridView)
        DGV_participantes.DataSource = obtenerParticipantes()


        DGV_participantes.Refresh()

        DGV_participantes.Columns.Item(0).Width = 25
        DGV_participantes.Columns.Item(1).Width = 90
        DGV_participantes.Columns.Item(2).Width = 90
        DGV_participantes.Columns.Item(3).Width = 90
        DGV_participantes.Columns.Item(4).Width = 90
        DGV_participantes.Columns.Item(5).Width = 150
        DGV_participantes.Columns.Item(6).Width = 90
        DGV_participantes.Columns.Item(7).Width = 90
    End Sub

    Public Function buscarParticipante() As Boolean
        Dim strSQL As String
        Dim xCnx As New Oracle
        Dim xDT As DataTable

        'Igual que en el insert, la parte fija de la sintaxis del UPDATE se escribe entre comillas,
        ' el simbolo & se usa para continuar la línea, y los valores en éste caso son las variables o las
        ' cajas de texto del formulario VARCHAR y DATE se esciben entre apostrofes

        strSQL = "SELECT id_participante as ID, participantes.nombre as Nombre, participantes.paterno as Paterno, participantes.materno as Materno, " &
                 " colonias.nombre as Colonia, carreras.descripcion as Carrera, generos.descripcion as Genero, participantes.edad as Edad " &
                 " FROM participantes " &
                 " INNER JOIN colonias ON colonias.id_colonia = participantes.id_colonia " &
                 " INNER JOIN carreras ON carreras.id_carrera = participantes.id_carrera " &
                 " INNER JOIN generos ON generos.id_genero = participantes.id_genero " &
                 " WHERE id_participante =  '" & formDeParticipantes.TB_id_participante.Text & "'" &
                  " ORDER BY participantes.paterno, participantes.materno asc"

        buscarParticipante = False
        xDT = xCnx.objetoDataAdapter(strSQL)
        If xDT.Rows.Count = 1 Then
            If IsDBNull(xDT.Rows(0)("Id")) Then
                idParticipante = 0
            Else
                idParticipante = CStr(xDT.Rows(0)("ID"))
                formDeParticipantes.TB_nombre.Text = CStr(xDT.Rows(0)("Nombre"))
                formDeParticipantes.TB_paterno.Text = CStr(xDT.Rows(0)("Paterno"))
                formDeParticipantes.TB_materno.Text = CStr(xDT.Rows(0)("Materno"))
                formDeParticipantes.TB_edad.Text = CStr(xDT.Rows(0)("Edad"))
                formDeParticipantes.CB_carrera.Text = CStr(xDT.Rows(0)("Carrera"))
                formDeParticipantes.CB_genero.Text = CStr(xDT.Rows(0)("Genero"))
                formDeParticipantes.CB_colonia.Text = CStr(xDT.Rows(0)("Colonia"))
            End If


            buscarParticipante = True
        End If
    End Function

    Public Function obtenerIdCarrera() As Boolean
        Dim strSQL As String
        Dim xCnx As New Oracle
        Dim xDT As DataTable

        strSQL = "SELECT id_carrera FROM carreras " &
                 "WHERE descripcion='" & formDeParticipantes.CB_carrera.Text & "'"
        obtenerIdCarrera = False
        xDT = xCnx.objetoDataAdapter(strSQL)
        If xDT.Rows.Count = 1 Then
            If IsDBNull(xDT.Rows(0)("id_carrera")) Then
                idCarrera = ""
            Else
                idCarrera = CStr(xDT.Rows(0)("id_carrera"))
            End If
            obtenerIdCarrera = True
        End If
    End Function

    Public Function obtenerIdGenero() As Boolean
        Dim strSQL As String
        Dim xCnx As New Oracle
        Dim xDT As DataTable

        strSQL = "SELECT id_genero FROM generos " &
                 "WHERE descripcion='" & formDeParticipantes.CB_genero.Text & "'"
        obtenerIdGenero = False
        xDT = xCnx.objetoDataAdapter(strSQL)
        If xDT.Rows.Count = 1 Then
            If IsDBNull(xDT.Rows(0)("id_genero")) Then
                idGenero = ""
            Else
                idGenero = CStr(xDT.Rows(0)("id_genero"))
            End If
            obtenerIdGenero = True
        End If
    End Function

    Public Function obtenerIdColonia() As Boolean
        Dim strSQL As String
        Dim xCnx As New Oracle
        Dim xDT As DataTable

        strSQL = "SELECT id_colonia FROM colonias " &
                 "WHERE nombre='" & formDeParticipantes.CB_colonia.Text & "'"
        obtenerIdColonia = False
        xDT = xCnx.objetoDataAdapter(strSQL)
        If xDT.Rows.Count = 1 Then
            If IsDBNull(xDT.Rows(0)("id_colonia")) Then
                idColonia = ""
            Else
                idColonia = CStr(xDT.Rows(0)("id_colonia"))
            End If
            obtenerIdColonia = True
        End If
    End Function

    Public Function obtenerIdParticipante() As Boolean
        Dim strSQL As String
        Dim xCnx As New Oracle
        Dim xDT As DataTable

        strSQL = "SELECT id_participante as ID, " &
                 " colonias.nombre as Colonia, carreras.descripcion as Carrera, generos.descripcion as Genero " &
                 " FROM participantes " &
                 " INNER JOIN colonias ON colonias.id_colonia = participantes.id_colonia " &
                 " INNER JOIN carreras ON carreras.id_carrera = participantes.id_carrera " &
                 " INNER JOIN generos ON generos.id_genero = participantes.id_genero " &
                 " WHERE participantes.id_participante = " & formDeParticipantes.TB_id_participante.Text &
                  " ORDER BY participantes.paterno, participantes.materno asc"
        obtenerIdParticipante = False
        xDT = xCnx.objetoDataAdapter(strSQL)
        If xDT.Rows.Count = 1 Then
            obtenerIdParticipante = True
        End If
    End Function


    Public Sub agregarParticipante()
        Dim strSql As String
        Dim xCnx As New Oracle

        If idCarrera <> 0 And idColonia <> 0 And idGenero <> 0 And nombre <> "" And paterno <> "" And materno <> "" And edad <> "" And idParticipante <> "" Then
            strSql = "INSERT INTO participantes VALUES(" & idParticipante & ", '" & nombre & "', '" & paterno & "', '" & materno & "', " & idCarrera & ", " & idGenero & ", " & edad & ", " & idColonia & ")"
            xCnx.objetoCommand(strSql)
        Else
            MsgBox("Faltan datos ", MsgBoxStyle.Critical, "ATENCIÓN!!")
        End If
    End Sub

    Public Sub guardarParticipante()
        Dim strSql As String
        Dim xCnx As New Oracle
        If idCarrera <> 0 And idColonia <> 0 And idGenero <> 0 And nombre <> "" And paterno <> "" And materno <> "" And edad <> "" And idParticipante <> "" Then
            strSql = "UPDATE participantes " &
                     " set nombre='" & nombre & "', paterno='" & paterno & "', materno='" & materno & "', " &
                     " id_carrera=" & idCarrera & ", id_genero=" & idGenero & ", id_colonia=" & idColonia & ", " &
                     " edad=" & edad &
                     " WHERE id_participante =" & idParticipante
            xCnx.objetoCommand(strSql)
        Else
            MsgBox("Faltan datos", MsgBoxStyle.Critical, "ATENCIÓN!!")
        End If
    End Sub

    Public Function validarPrograma() As Boolean
        Dim strSQL As String
        Dim xCnx As New Oracle
        Dim xDT As DataTable
        validarPrograma = True
        If idCarrera <> 0 And idColonia <> 0 And idGenero <> 0 And nombre <> "" And paterno <> "" And materno <> "" And edad <> "" And idParticipante <> "" Then
            strSQL = "SELECT * FROM programaparticipantes " &
                     " WHERE id_participante = " & idParticipante

            xDT = xCnx.objetoDataAdapter(strSQL)

            If xDT.Rows.Count >= 1 Then
                validarPrograma = True
            Else
                validarPrograma = False
            End If
        Else
            MsgBox("Faltan datos", MsgBoxStyle.Critical, "ATENCIÓN!!")
        End If
    End Function

    Public Sub eliminarParticipante()
        Dim strSql As String
        Dim xCnx As New Oracle
        If idCarrera <> 0 And idColonia <> 0 And idGenero <> 0 And nombre <> "" And paterno <> "" And materno <> "" And edad <> "" And idParticipante <> "" Then
            strSql = "DELETE FROM participantes " &
                     " WHERE id_participante = " & idParticipante
            xCnx.objetoCommand(strSql)
        Else
            MsgBox("Faltan datos", MsgBoxStyle.Critical, "ATENCIÓN!!")
        End If
    End Sub
End Class
