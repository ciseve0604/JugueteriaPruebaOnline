Imports System.Data


Public Class GES_USUARIOENT
    Private cacod As Integer

#Region "ATRIBUTOS DE LA CLASE"

    Private _ID_USUARIO As Integer
    Private _NOMBRE_USUARIO As String
    Private _DV_USUARIO As String
    Private _PASSWORD As String
    Private _NOMBRE As String
    Private _APELLIDO As String
    Private _ESTADO_INICIO As Boolean
    Private _EMAIL As String
    Private _RUT As Integer
    Private _DV_RUT As String
    Private _TELEFONO As String
    Private _CAMBIO_CLAVE As Boolean
    Private _ESTADO_USUARIO As Boolean
    Private _idSession As String
    Private _eliminarSessionActiva As Boolean

#End Region

#Region "METODOS DE LA CLASE"

    Public Property EliminarSessionActiva() As Boolean
        Get
            Return _eliminarSessionActiva
        End Get
        Set(ByVal value As Boolean)
            _eliminarSessionActiva = value
        End Set
    End Property


    Public Property idSession() As String
        Get
            Return _idSession
        End Get
        Set(ByVal value As String)
            _idSession = value
        End Set
    End Property

    Public Property ID_USUARIO() As Integer
        Get
            Return _ID_USUARIO
        End Get
        Set(ByVal value As Integer)
            _ID_USUARIO = value
        End Set
    End Property


    Public Property NOMBRE_USUARIO() As String
        Get
            Return _NOMBRE_USUARIO
        End Get
        Set(ByVal value As String)
            _NOMBRE_USUARIO = value
        End Set
    End Property


    Public Property DV_USUARIO() As String
        Get
            Return _DV_USUARIO
        End Get
        Set(ByVal value As String)
            _DV_USUARIO = value
        End Set
    End Property


    Public Property PASSWORD() As String
        Get
            Return _PASSWORD
        End Get
        Set(ByVal value As String)
            _PASSWORD = value
        End Set
    End Property


    Public Property NOMBRE() As String
        Get
            Return _NOMBRE
        End Get
        Set(ByVal value As String)
            _NOMBRE = value
        End Set
    End Property


    Public Property APELLIDO() As String
        Get
            Return _APELLIDO
        End Get
        Set(ByVal value As String)
            _APELLIDO = value
        End Set
    End Property


    Public Property ESTADO_INICIO() As Boolean
        Get
            Return _ESTADO_INICIO
        End Get
        Set(ByVal value As Boolean)
            _ESTADO_INICIO = value
        End Set
    End Property


    Public Property EMAIL() As String
        Get
            Return _EMAIL
        End Get
        Set(ByVal value As String)
            _EMAIL = value
        End Set
    End Property


    Public Property RUT() As Integer
        Get
            Return _RUT
        End Get
        Set(ByVal value As Integer)
            _RUT = value
        End Set
    End Property


    Public Property DV_RUT() As String
        Get
            Return _DV_RUT
        End Get
        Set(ByVal value As String)
            _DV_RUT = value
        End Set
    End Property


    Public Property TELEFONO() As String
        Get
            Return _TELEFONO
        End Get
        Set(ByVal value As String)
            _TELEFONO = value
        End Set
    End Property


    Public Property CAMBIO_CLAVE() As Boolean
        Get
            Return _CAMBIO_CLAVE
        End Get
        Set(ByVal value As Boolean)
            _CAMBIO_CLAVE = value
        End Set
    End Property


    Public Property ESTADO_USUARIO() As Boolean
        Get
            Return _ESTADO_USUARIO
        End Get
        Set(ByVal value As Boolean)
            _ESTADO_USUARIO = value
        End Set
    End Property
#End Region


    '#Region "CONSTRUCTORES DE LA CLASE"
    '    Public Sub New()

    '    End Sub
    '#End Region

End Class
