Imports Oracle.DataAccess.Client
Public Class Categoria

    Public Sub New()

    End Sub
    Public Sub New(ByVal newDesc As String, ByVal newIdCategoria As String)
        descCategoria = newDesc
        idCategoria = newIdCategoria
    End Sub

    Public Function obtenerCategorias() As Object
        Dim strSQL As String
        Dim xCnx As New Oracle

        strSQL = "SELECT id_categoria as ID, descripcion" &
                 " FROM categorias "
        obtenerCategorias = xCnx.objetoDataAdapter(strSQL)
    End Function


    Public Sub buscarCategorias(ByVal DGV_categorias As DataGridView)
        DGV_categorias.DataSource = obtenerCategorias()


        DGV_categorias.Refresh()

        DGV_categorias.Columns.Item(0).Width = 50
        DGV_categorias.Columns.Item(1).Width = 423
    End Sub

    Public Function buscarCategoria() As Boolean
        Dim strSQL As String
        Dim xCnx As New Oracle
        Dim xDT As DataTable

        'Igual que en el insert, la parte fija de la sintaxis del UPDATE se escribe entre comillas,
        ' el simbolo & se usa para continuar la línea, y los valores en éste caso son las variables o las
        ' cajas de texto del formulario VARCHAR y DATE se esciben entre apostrofes

        strSQL = "SELECT id_categoria as ID, descripcion " &
                 " FROM categorias " &
                 " WHERE id_categoria =  '" & formDeCategorias.TB_id_categoria.Text & "'"

        buscarCategoria = False
        xDT = xCnx.objetoDataAdapter(strSQL)
        If xDT.Rows.Count = 1 Then
            If IsDBNull(xDT.Rows(0)("Id")) Then
                idCategoria = 0
            Else
                idCategoria = CStr(xDT.Rows(0)("ID"))
                formDeCategorias.TB_desc_categoria.Text = CStr(xDT.Rows(0)("descripcion"))
            End If


            buscarCategoria = True
        End If
    End Function

    Public Function obtenerIdCategoria() As Boolean
        Dim strSQL As String
        Dim xCnx As New Oracle
        Dim xDT As DataTable

        strSQL = "SELECT id_categoria as ID" &
                 " FROM categorias " &
                 " WHERE id_categoria = " & formDeCategorias.TB_id_categoria.Text
        obtenerIdCategoria = False
        xDT = xCnx.objetoDataAdapter(strSQL)
        If xDT.Rows.Count = 1 Then
            obtenerIdCategoria = True
        End If
    End Function


    Public Sub agregarCategoria()
        Dim strSql As String
        Dim xCnx As New Oracle

        If descCategoria <> "" And idCategoria <> "" Then
            strSql = "INSERT INTO categorias VALUES(" & idCategoria & ", '" & descCategoria & "')"
            xCnx.objetoCommand(strSql)
        Else
            MsgBox("Faltan datos ", MsgBoxStyle.Critical, "ATENCIÓN!!")
        End If
    End Sub

    Public Sub guardarCategoria()
        Dim strSql As String
        Dim xCnx As New Oracle
        If descCategoria <> "" And idCategoria <> "" Then
            strSql = "UPDATE categorias " &
                     " set descripcion='" & descCategoria & "'" &
                     " WHERE id_categoria =" & idCategoria
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
        If formDeCategorias.TB_id_categoria.Text <> "" Then
            strSQL = "SELECT * FROM programaparticipantes " &
                     " WHERE id_categoria = " & formDeCategorias.TB_id_categoria.Text

            xDT = xCnx.objetoDataAdapter(strSQL)

            If xDT.Rows.Count >= 1 Then
                validarParticipaciones = True
            Else
                validarParticipaciones = False
            End If
        Else

        End If
    End Function

    Public Function validarRegistro() As Boolean
        Dim strSQL As String
        Dim xCnx As New Oracle
        Dim xDT As DataTable
        validarRegistro = True
        If formDeCategorias.TB_id_categoria.Text <> "" Then
            strSQL = "SELECT * FROM categorias " &
                     " WHERE id_categoria = " & formDeCategorias.TB_id_categoria.Text

            xDT = xCnx.objetoDataAdapter(strSQL)

            If xDT.Rows.Count >= 1 Then
                validarRegistro = True
            Else
                validarRegistro = False
            End If
        Else

        End If
    End Function

    Public Sub eliminarCategoria()
        Dim strSql As String
        Dim xCnx As New Oracle
        If descCategoria <> "" And idCategoria <> "" Then
            strSql = "DELETE FROM categorias " &
                     " WHERE id_categoria = " & idCategoria
            xCnx.objetoCommand(strSql)
        Else
            MsgBox("Faltan datos", MsgBoxStyle.Critical, "ATENCIÓN!!")
        End If
    End Sub
End Class
