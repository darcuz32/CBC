
Imports Oracle.DataAccess.Client

Public Class Login

    'Variables de instancia de la Clase
    Private nombreCuenta As String
    Private claveCuenta As String

    'Método constructor inicializa variables
    Public Sub New()
        nombreCuenta = ""
        claveCuenta = ""
    End Sub


    'Metodo constructor con valores proporcionados al instanciar el objeto
    Public Sub New(ByVal cuenta As String, ByVal clave As String)
        'Aquí recibimos los datos
        nombreCuenta = cuenta
        claveCuenta = clave
    End Sub

    'Metodos get y set
    Public Property getSetnombreCuenta() As String
        Get
            Return nombreCuenta
        End Get
        Set(ByVal Value As String)
            nombreCuenta = Value
        End Set
    End Property

    Public Property getSetclaveCuenta() As String
        Get
            Return claveCuenta
        End Get
        Set(ByVal Value As String)
            claveCuenta = Value
        End Set
    End Property


    'Consulta un usuario específico
    Public Function consultaUsuario() As Boolean
        Dim strSQL As String
        Dim xCnx As New Oracle
        Dim xDT As DataTable

        strSQL = "SELECT * FROM usuarios " &
                 "WHERE cuenta='" & nombreCuenta & "' and clave ='" & claveCuenta & "'"
        consultaUsuario = False
        xDT = xCnx.objetoDataAdapter(strSQL)
        If xDT.Rows.Count = 1 Then

            If IsDBNull(xDT.Rows(0)("nombre")) Then
                UsuarioConectado = ""
            Else
                UsuarioConectado = CStr(xDT.Rows(0)("nombre")) & " " & CStr(xDT.Rows(0)("paterno")) '& " " & CStr(xDT.Rows(0)("materno"))
            End If
            consultaUsuario = True
        End If
    End Function

End Class

