Imports Oracle.DataAccess.Client
Public Class Ciudad
    Public Sub New()

    End Sub
    Public Sub New(ByVal newIdCiudad As String, ByVal newIdEstado As String, ByVal newNombre As String)
        idCiudad = newIdCiudad
        idEstado = newIdEstado
        nombre = newNombre

    End Sub


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

    Public Function buscarEstado() As Integer
        Dim strSQL As String
        Dim xCnx As New Oracle
        Dim xDT As DataTable

        strSQL = "SELECT id_estado FROM ciudades " &
                 "WHERE id_ciudades='" & formDeCiudades.TB_id_ciudad.Text & "'"
        buscarEstado = -1
        xDT = xCnx.objetoDataAdapter(strSQL)
        If xDT.Rows.Count = 1 Then
            If IsDBNull(xDT.Rows(0)("id_estado")) Then
                buscarEstado = -1
            Else
                buscarEstado = CStr(xDT.Rows(0)("id_estado"))
            End If

        End If
    End Function
    Public Function obtenerCiudades() As Object
        Dim strSQL As String
        Dim xCnx As New Oracle

        'Es importante al igual que en el insert, tener presente que el select hay que llamarlo 
        'en el mismo orden que se encuentra la estructura de la tabla en la BD y en el DGV

        strSQL = "SELECT id_ciudad as ID, ciudades.nombre as Ciudad, estados.nombre " &
                 " FROM estados, ciudades " &
                 " WHERE estados.id_estado = ciudades.id_estado and " &
                 " estados.nombre = '" & formDeCiudades.CB_estado.Text & "'" &
                 " ORDER BY ciudades.nombre asc"

        obtenerCiudades = xCnx.objetoDataAdapter(strSQL)
    End Function


    Public Sub buscarCiudades(ByVal DGV_ciudades As DataGridView)
        DGV_ciudades.DataSource = obtenerCiudades()


        DGV_ciudades.Refresh()

        DGV_ciudades.Columns.Item(0).Width = 90
        DGV_ciudades.Columns.Item(1).Width = 152
        DGV_ciudades.Columns.Item(2).Width = 152

    End Sub

    Public Function obtenerIdEstado() As Boolean
        Dim strSQL As String
        Dim xCnx As New Oracle
        Dim xDT As DataTable

        strSQL = "SELECT id_estado FROM estados " &
                 "WHERE nombre='" & formDeCiudades.CB_estado.Text & "'"
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
    Public Function obtenerIdCiudad() As Boolean
        Dim strSQL As String
        Dim xCnx As New Oracle
        Dim xDT As DataTable

        strSQL = "SELECT ciudades.id_estado, ciudades.id_ciudad, ciudades.nombre " &
                " FROM estados, ciudades " &
                " WHERE estados.id_estado=ciudades.id_estado and " &
                " ciudades.id_ciudad =" & formDeCiudades.TB_id_ciudad.Text &
                " and estados.nombre ='" & formDeCiudades.CB_estado.Text & "'"
        obtenerIdCiudad = False
        xDT = xCnx.objetoDataAdapter(strSQL)
        If xDT.Rows.Count = 1 Then
            obtenerIdCiudad = True
        End If
    End Function

    Public Sub agregarCiudad()
        Dim strSql As String
        Dim xCnx As New Oracle

        If idEstado <> 0 And idCiudad <> 0 And nombre <> "" Then
            strSql = "INSERT INTO ciudades VALUES(" & idCiudad & ", " & idEstado & ", '" & nombre & "')"
            xCnx.objetoCommand(strSql)
        Else
            MsgBox("Faltan datos ", MsgBoxStyle.Critical, "ATENCIÓN!!")
        End If
    End Sub

    Public Sub guardarCiudad()
        Dim strSql As String
        Dim xCnx As New Oracle
        If idEstado <> 0 And idCiudad <> 0 And nombre <> "" Then

            strSql = "UPDATE ciudades set nombre='" & nombre &
                     "' WHERE  id_estado =" & idEstado &
                     " and id_ciudad=" & idCiudad

            xCnx.objetoCommand(strSql)
        Else
            MsgBox("Faltan datos", MsgBoxStyle.Critical, "ATENCIÓN!!")
        End If
    End Sub

    Public Function validarColonia() As Boolean
        Dim strSQL As String
        Dim xCnx As New Oracle
        Dim xDT As DataTable
        validarColonia = False
        If formDeCiudades.TB_id_ciudad.Text <> "" Then

            strSQL = "SELECT * FROM colonias " &
                     " WHERE id_ciudad = " & formDeCiudades.TB_id_ciudad.Text
            xDT = xCnx.objetoDataAdapter(strSQL)

            If xDT.Rows.Count >= 1 Then
                validarColonia = True
            Else
                validarColonia = False
            End If
        Else

        End If
    End Function

    Public Function validarRegistro() As Boolean
        Dim strSQL As String
        Dim xCnx As New Oracle
        Dim xDT As DataTable
        validarRegistro = False
        If formDeCiudades.TB_id_ciudad.Text <> "" Then

            strSQL = "SELECT * FROM ciudades " &
                     " WHERE id_ciudad = " & formDeCiudades.TB_id_ciudad.Text
            xDT = xCnx.objetoDataAdapter(strSQL)

            If xDT.Rows.Count >= 1 Then
                validarRegistro = True
            Else
                validarRegistro = False
            End If
        Else

        End If
    End Function

    Public Sub eliminarCiudad()
        Dim strSql As String
        Dim xCnx As New Oracle
        If idEstado <> 0 And nombre <> "" And idCiudad <> "" Then

            strSql = "DELETE FROM ciudades " &
                     " WHERE id_ciudad = " & idCiudad
            xCnx.objetoCommand(strSql)
        Else
            MsgBox("Faltan datos", MsgBoxStyle.Critical, "ATENCIÓN!!")
        End If
    End Sub

    Public Function consultaUnaCiudad() As Boolean
        Dim strSQL As String
        Dim xCnx As New Oracle
        Dim xDT As DataTable

        'Cuando realizamos un select ademas de traer los datos en el orden que necesitamos
        'es necesario crear el "alias"  (as) <-- que es el nombre de la columna fictisia
        'que creamos al realizar un select y con ese alias puedes llamar la columna para poblar
        ' los textbox o combobox correspondientes. 
        strSQL = " SELECT ciudades.id_ciudad , ciudades.nombre , estados.nombre as estados" &
                 " FROM estados, ciudades " &
                 " WHERE estados.id_estado=ciudades.id_estado " &
                 " And ciudades.id_ciudad = " & formDeCiudades.TB_id_ciudad.Text

        consultaUnaCiudad = False
        xDT = xCnx.objetoDataAdapter(strSQL)
        If xDT.Rows.Count = 1 Then
            If IsDBNull(xDT.Rows(0)("id_ciudad")) Then
                idCiudad = ""
            Else
                idCiudad = CStr(xDT.Rows(0)("id_ciudad"))
            End If
            If IsDBNull(xDT.Rows(0)("nombre")) Then
                nombre = ""
            Else
                nombre = CStr(xDT.Rows(0)("nombre"))
            End If
            If IsDBNull(xDT.Rows(0)("estados")) Then
                nomEdo = ""
            Else
                nomEdo = CStr(xDT.Rows(0)("estados"))
            End If
            consultaUnaCiudad = True
            End If
    End Function
End Class
