Imports Microsoft.VisualBasic

Public Class OBJ_SETJUSTIFICACIONENT

#Region "ATRIBUTOS DE LA CLASE"
    '@ROL AS INT,
    '@PERIODO as int,
    '@ANO as int,
    '@ID as int,
    '@PROCESO AS INT,
    '@USUARIO as nvarchar(100),
    '@JUSTIFICACION as nvarchar(4000)
    Private _ROL As Integer
    Private _PERIODO As Integer
    Private _ANO As Integer
    Private _ID As Integer
    Private _USUARIO As String
    Private _JUSTIFICACION As String
    Private _CJ As Integer
#End Region

#Region "GET + SET"

    Public Property ROL() As Integer
        Get
            Return _ROL
        End Get
        Set(ByVal value As Integer)
            _ROL = value
        End Set
    End Property

    Public Property PERIODO() As Integer
        Get
            Return _PERIODO
        End Get
        Set(ByVal value As Integer)
            _PERIODO = value
        End Set
    End Property

    Public Property ANO() As Integer
        Get
            Return _ANO
        End Get
        Set(ByVal value As Integer)
            _ANO = value
        End Set
    End Property

    Public Property ID() As Integer
        Get
            Return _ID
        End Get
        Set(ByVal value As Integer)
            _ID = value
        End Set
    End Property

    Public Property USUARIO() As String
        Get
            Return _USUARIO
        End Get
        Set(ByVal value As String)
            _USUARIO = value
        End Set
    End Property

    Public Property JUSTIFICACION() As String
        Get
            Return _JUSTIFICACION
        End Get
        Set(ByVal value As String)
            _JUSTIFICACION = value
        End Set
    End Property

    Public Property CJ() As Integer
        Get
            Return _CJ
        End Get
        Set(ByVal value As Integer)
            _CJ = value
        End Set
    End Property

#End Region




End Class
