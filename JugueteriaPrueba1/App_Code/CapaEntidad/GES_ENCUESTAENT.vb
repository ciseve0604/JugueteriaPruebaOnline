Imports System.Data


public class GES_ENCUESTAENT

#REGION "ATRIBUTOS DE LA CLASE"

   Private _ID_ENCUESTA as Integer
   Private _NOMBRE_ENCUESTA as String
   Private _USUARIODB as String
   Private _CLAVEDB as String
   Private _NOMBREDB as String
    'Private _PERIODO as String
   Private _PERIOCIDAD as String
   Private _ESTADO_ENCUESTA as String
   Private _FECHA_CREACION as String
   Private _USUARIO_CREACION as String

#END REGION

#REGION "METODOS DE LA CLASE"


   Public Property ID_ENCUESTA() As Integer
       Get
           return _ID_ENCUESTA
       End Get
       Set(ByVal value As Integer)
           _ID_ENCUESTA = value
       End Set
   End Property


   Public Property NOMBRE_ENCUESTA() As String
       Get
           return _NOMBRE_ENCUESTA
       End Get
       Set(ByVal value As String)
           _NOMBRE_ENCUESTA = value
       End Set
   End Property


   Public Property USUARIODB() As String
       Get
           return _USUARIODB
       End Get
       Set(ByVal value As String)
           _USUARIODB = value
       End Set
   End Property


   Public Property CLAVEDB() As String
       Get
           return _CLAVEDB
       End Get
       Set(ByVal value As String)
           _CLAVEDB = value
       End Set
   End Property


   Public Property NOMBREDB() As String
       Get
           return _NOMBREDB
       End Get
       Set(ByVal value As String)
           _NOMBREDB = value
       End Set
   End Property


    'Public Property PERIODO() As String
    '    Get
    '        return _PERIODO
    '    End Get
    '    Set(ByVal value As String)
    '        _PERIODO = value
    '    End Set
    'End Property


   Public Property PERIOCIDAD() As String
       Get
           return _PERIOCIDAD
       End Get
       Set(ByVal value As String)
           _PERIOCIDAD = value
       End Set
   End Property


   Public Property ESTADO_ENCUESTA() As String
       Get
           return _ESTADO_ENCUESTA
       End Get
       Set(ByVal value As String)
           _ESTADO_ENCUESTA = value
       End Set
   End Property


   Public Property FECHA_CREACION() As String
       Get
           return _FECHA_CREACION
       End Get
       Set(ByVal value As String)
           _FECHA_CREACION = value
       End Set
   End Property


   Public Property USUARIO_CREACION() As String
       Get
           return _USUARIO_CREACION
       End Get
       Set(ByVal value As String)
           _USUARIO_CREACION = value
       End Set
   End Property
#END REGION


#REGION "CONSTRUCTORES DE LA CLASE"
   Public Sub New()

   End Sub
#END REGION

end class
