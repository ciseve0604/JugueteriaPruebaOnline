Imports Microsoft.VisualBasic

Public Class OBJ_GETJUSTIFICACIONENT

#Region "ATRIBUTOS DE LA CLASE"


    Private _id As Integer
    Private _usuario As String
    Private _campo As String
    Private _T As String
    Private _T1 As String
    Private _T12 As String
    Private _rol As String
    Private _dvrol As String
    Private _respuesta As String
    Private _justificacion As String
    Private _periodo As Integer
    Private _ano As Integer
    Private _justificadaCorregida As String

#End Region

#Region "GET + SET"

    Public Property id() As Integer
        Get
            Return _id
        End Get
        Set(ByVal value As Integer)
            _id = value
        End Set
    End Property

    Public Property usuario() As String
        Get
            Return _usuario
        End Get
        Set(ByVal value As String)
            _usuario = value
        End Set
    End Property

    Public Property campo() As String
        Get
            Return _campo
        End Get
        Set(ByVal value As String)
            _campo = value
        End Set
    End Property

    Public Property T() As String
        Get
            Return _T
        End Get
        Set(ByVal value As String)
            _T = value
        End Set
    End Property

    Public Property T1() As String
        Get
            Return _T1
        End Get
        Set(ByVal value As String)
            _T1 = value
        End Set
    End Property

    Public Property T12() As String
        Get
            Return _T12
        End Get
        Set(ByVal value As String)
            _T12 = value
        End Set
    End Property

    Public Property rol() As String
        Get
            Return _rol
        End Get
        Set(ByVal value As String)
            _rol = value
        End Set
    End Property

    Public Property dvrol() As String
        Get
            Return _dvrol
        End Get
        Set(ByVal value As String)
            _dvrol = value
        End Set
    End Property

    Public Property respuesta() As String
        Get
            Return _respuesta
        End Get
        Set(ByVal value As String)
            _respuesta = value
        End Set
    End Property

    Public Property justificacion() As String
        Get
            Return _justificacion
        End Get
        Set(ByVal value As String)
            _justificacion = value
        End Set
    End Property

    Public Property periodo() As Integer
        Get
            Return _periodo
        End Get
        Set(ByVal value As Integer)
            _periodo = value
        End Set
    End Property

    Public Property ano() As Integer
        Get
            Return _ano
        End Get
        Set(ByVal value As Integer)
            _ano = value
        End Set
    End Property

    Public Property justificadaCorregida() As String
        Get
            Return _justificadaCorregida
        End Get
        Set(ByVal value As String)
            _justificadaCorregida = value
        End Set
    End Property




#End Region

#Region "CONSTRUCTORES DE LA CLASE"
    Public Sub New()

    End Sub

#End Region

End Class
