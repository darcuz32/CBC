Imports Oracle.DataAccess.Client
Public Class Colonia
    Public Sub New()

    End Sub
    Public Sub New(ByVal newIdColonia As String, ByVal newIdCiudad As String, ByVal newNombre As String, ByVal newidEstado As String)
        idColonia = newIdColonia
        idCiudad = newIdCiudad
        idEstado = newidEstado
        nombre = newNombre

    End Sub


    Public Sub buscarCiudades(ByVal objeto As ComboBox)
        Dim Lista As OracleDataReader
        Dim strSql As String
        Dim xCnx As New Oracle

        'strSql = "SELECT nombre FROM ciudades Order By nombre asc"

        strSql = "SELECT ciudades.nombre " &
                 " FROM estados, ciudades " &
                 "WHERE estados.id_estado = ciudades.id_estado and " &
                 "      estados.nombre = '" & formDeColonias.CB_estados.Text & "' Order By estados.nombre asc"

        Lista = xCnx.objetoDataReader(strSql)

        objeto.Items.Clear()

        While Lista.Read()
            objeto.Items.Add(Lista.GetValue(0))
        End While
        Lista.Close()
    End Sub

    Public Function buscarCiudad() As Integer
        Dim strSQL As String
        Dim xCnx As New Oracle
        Dim xDT As DataTable

        strSQL = "SELECT id_ciudad FROM colonias " &
                 "WHERE id_colonias='" & formDeColonias.TB_id_colonia.Text & "'"
        buscarCiudad = -1
        xDT = xCnx.objetoDataAdapter(strSQL)
        If xDT.Rows.Count = 1 Then
            If IsDBNull(xDT.Rows(0)("id_ciudad")) Then
                buscarCiudad = -1
            Else
                buscarCiudad = CStr(xDT.Rows(0)("id_ciudad"))
            End If

        End If
    End Function
    Public Function obtenerColonias() As Object
        Dim strSQL As String
        Dim xCnx As New Oracle

        strSQL = "SELECT id_colonia as ID, colonias.nombre as Colonia, ciudades.nombre " &
                 " FROM ciudades, colonias " &
                 " WHERE ciudades.id_ciudad = colonias.id_ciudad and " &
                 " ciudades.nombre = '" & formDeColonias.CB_ciudad.Text & "'" &
                 " ORDER BY colonias.id_colonia asc"

        obtenerColonias = xCnx.objetoDataAdapter(strSQL)
    End Function


    Public Sub buscarColonias(ByVal DGV_colonias As DataGridView)
        DGV_colonias.DataSource = obtenerColonias()


        DGV_colonias.Refresh()

        DGV_colonias.Columns.Item(0).Width = 93
        DGV_colonias.Columns.Item(1).Width = 155
        DGV_colonias.Columns.Item(2).Width = 155

    End Sub

    Public Function obtenerIdCiudad() As Boolean
        Dim strSQL As String
        Dim xCnx As New Oracle
        Dim xDT As DataTable

        strSQL = "SELECT id_ciudad FROM ciudades " &
                 "WHERE nombre='" & formDeColonias.CB_ciudad.Text & "'"
        obtenerIdCiudad = False
        xDT = xCnx.objetoDataAdapter(strSQL)
        If xDT.Rows.Count = 1 Then
            If IsDBNull(xDT.Rows(0)("id_ciudad")) Then
                idCiudad = ""
            Else
                idCiudad = CStr(xDT.Rows(0)("id_ciudad"))
            End If
            obtenerIdCiudad = True
        End If
    End Function
    Public Function obtenerIdColonia() As Boolean
        Dim strSQL As String
        Dim xCnx As New Oracle
        Dim xDT As DataTable

        strSQL = "SELECT colonias.id_ciudad, colonias.id_colonia, colonias.nombre " &
                " FROM ciudades, colonias " &
                " WHERE ciudades.id_ciudad=colonias.id_ciudad and " &
                " colonias.id_colonia =" & formDeColonias.TB_id_colonia.Text &
                " and ciudades.nombre ='" & formDeColonias.CB_ciudad.Text & "'"
        obtenerIdColonia = False
        xDT = xCnx.objetoDataAdapter(strSQL)
        If xDT.Rows.Count = 1 Then
            obtenerIdColonia = True
        End If
    End Function

    Public Sub agregarColonia()
        Dim strSql As String
        Dim xCnx As New Oracle


        If idColonia <> 0 And nombre <> "" And idCiudad <> "" And idEstado <> "" Then
            strSql = "INSERT INTO colonias VALUES(" & idColonia & ", " & idCiudad & ", '" & nombre & "')"
            xCnx.objetoCommand(strSql)
        Else
            MsgBox("Faltan datos ", MsgBoxStyle.Critical, "ATENCIÓN!!")
        End If
    End Sub

    Public Sub guardarColonia()
        Dim strSql As String
        Dim xCnx As New Oracle
        If idEstado <> "" And idCiudad <> "" And idColonia <> 0 And nombre <> "" Then

            ' strSql = " UPDATE colonias set nombre='" & nombre &
            '         "' WHERE  id_ciudad = (SELECT id_ciudad FROM ciudades WHERE ciudades.nombre = '" & idEstado & "')" &
            '        " And id_colonia = " & idColonia


            strSql = " UPDATE colonias set nombre='" & nombre &
                    "' WHERE  id_ciudad = (SELECT id_ciudad FROM ciudades WHERE ciudades.nombre ='" & formDeColonias.CB_ciudad.Text & "')" &
                    " And id_colonia= " & formDeColonias.TB_id_colonia.Text

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
        If formDeColonias.TB_id_colonia.Text <> "" Then

            strSQL = " Select * FROM participantes " &
                     " WHERE id_colonia = " & formDeColonias.TB_id_colonia.Text

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
        If formDeColonias.TB_id_colonia.Text <> "" Then

            strSQL = " Select * FROM colonias " &
                     " WHERE id_colonia = " & formDeColonias.TB_id_colonia.Text

            xDT = xCnx.objetoDataAdapter(strSQL)

            If xDT.Rows.Count >= 1 Then
                validarRegistro = True
            Else
                validarRegistro = False
            End If
        Else

        End If
    End Function

    Public Sub eliminarColonia()
        Dim strSql As String
        Dim xCnx As New Oracle
        If idEstado <> "" And idCiudad <> "" And nombre <> "" And idColonia <> 0 Then

            strSql = "DELETE FROM colonias " &
                     " WHERE id_colonia = " & idColonia
            xCnx.objetoCommand(strSql)
        Else
            MsgBox("Faltan datos", MsgBoxStyle.Critical, "ATENCIÓN!!")
        End If
    End Sub


    Public Function consultaUnaColonia() As Boolean
        Dim strSQL As String
        Dim xCnx As New Oracle
        Dim xDT As DataTable

        'Cuando realizamos un select ademas de traer los datos en el orden que necesitamos
        'es necesario crear el "Alias"  (as) <-- que es el nombre de la columna fictisia
        'que creamos al realizar un select y con ese alias puedes llamar la columna para poblar
        ' los textbox o combobox correspondientes. 

        strSQL = " Select colonias.id_colonia , colonias.nombre , estados.nombre As estado, ciudades.nombre As ciudad " &
                  " FROM estados, ciudades, colonias " &
                  " WHERE estados.id_estado = ciudades.id_estado " &
                  " And ciudades.id_ciudad = colonias.id_ciudad " &
                  " And colonias.id_colonia =" & formDeColonias.TB_id_colonia.Text
        consultaUnaColonia = False
        xDT = xCnx.objetoDataAdapter(strSQL)
        If xDT.Rows.Count = 1 Then
            If IsDBNull(xDT.Rows(0)("id_colonia")) Then
                idColonia = ""
            Else
                idColonia = CStr(xDT.Rows(0)("id_colonia"))
            End If
            If IsDBNull(xDT.Rows(0)("nombre")) Then
                nombre = ""
            Else
                nombre = CStr(xDT.Rows(0)("nombre"))
            End If
            If IsDBNull(xDT.Rows(0)("estado")) Then
                nomEdo = ""
            Else
                nomEdo = CStr(xDT.Rows(0)("estado"))
            End If

            If IsDBNull(xDT.Rows(0)("ciudad")) Then
                nomCd = ""
            Else
                nomCd = CStr(xDT.Rows(0)("ciudad"))
            End If

            consultaUnaColonia = True
        End If
    End Function
    'De aqui hacia abajo es lo agregado para llenar el combo de estado

    Public Function obtenerIdEstado() As Boolean
        Dim strSQL As String
        Dim xCnx As New Oracle
        Dim xDT As DataTable

        strSQL = "Select id_estado FROM estados " &
                 "WHERE nombre='" & formDeColonias.CB_estados.Text & "'"
        obtenerIdEstado = False
        xDT = xCnx.objetoDataAdapter(strSQL)
        If xDT.Rows.Count = 1 Then
            If IsDBNull(xDT.Rows(0)("id_estado")) Then
                idEstado = ""
            Else
                idEstado = CStr(xDT.Rows(0)("id_estado"))
            End If
            obtenerIdEstado = True
        End If
    End Function

    Public Sub buscarEstados(ByVal objeto As ComboBox)
        Dim Lista As OracleDataReader
        Dim strSql As String
        Dim xCnx As New Oracle

        strSql = "SELECT nombre FROM estados Order By nombre asc"
        Lista = xCnx.objetoDataReader(strSql)

        objeto.Items.Clear()

        While Lista.Read()
            objeto.Items.Add(Lista.GetValue(0))
        End While
        Lista.Close()
    End Sub
End Class
