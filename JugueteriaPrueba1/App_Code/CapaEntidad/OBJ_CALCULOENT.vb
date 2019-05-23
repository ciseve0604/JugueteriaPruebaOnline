Imports Microsoft.VisualBasic

Public Class OBJ_CALCULOENT
    Private _RegionDAT As Integer
    Private _ClaseDAT As Integer
    Private _DTuristico As Integer
    Private _user As String
    Private _tipo As Integer
    Private _periodo As Integer
    Private _ano As Integer
    Private _Valor As String

#Region "GET + SET"
    Public Property RegionDAT() As Integer
        Get
            Return _RegionDAT
        End Get
        Set(ByVal value As Integer)
            _RegionDAT = value
        End Set
    End Property

    Public Property ClaseDAT() As Integer
        Get
            Return _ClaseDAT
        End Get
        Set(ByVal value As Integer)
            _ClaseDAT = value
        End Set
    End Property

    Public Property DTuristico() As Integer
        Get
            Return _DTuristico
        End Get
        Set(ByVal value As Integer)
            _DTuristico = value
        End Set
    End Property

    Public Property user() As String
        Get
            Return _user
        End Get
        Set(ByVal value As String)
            _user = value
        End Set
    End Property

    Public Property tipo() As Integer
        Get
            Return _tipo
        End Get
        Set(ByVal value As Integer)
            _tipo = value
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

    Public Property Valor() As String
        Get
            Return _Valor
        End Get
        Set(ByVal value As String)
            _Valor = value
        End Set
    End Property


#End Region
End Class
