Imports System.Data


public class GES_DATOENCUESTAENT

#REGION "ATRIBUTOS DE LA CLASE"

   Private _ID_ENCUESTA as Integer
   Private _COLOR_ENCUESTA as String
   Private _TITULO_ENCUESTA as String
   Private _BANNER_ENCUESTA as String
   Private _INSTRUCTIVO_ENCUESTA as String
   Private _FORMULARIO_ENCUESTA as String
   Private _ESTADO_DATOENCUESTA as Boolean
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


   Public Property COLOR_ENCUESTA() As String
       Get
           return _COLOR_ENCUESTA
       End Get
       Set(ByVal value As String)
           _COLOR_ENCUESTA = value
       End Set
   End Property


   Public Property TITULO_ENCUESTA() As String
       Get
           return _TITULO_ENCUESTA
       End Get
       Set(ByVal value As String)
           _TITULO_ENCUESTA = value
       End Set
   End Property


   Public Property BANNER_ENCUESTA() As String
       Get
           return _BANNER_ENCUESTA
       End Get
       Set(ByVal value As String)
           _BANNER_ENCUESTA = value
       End Set
   End Property


   Public Property INSTRUCTIVO_ENCUESTA() As String
       Get
           return _INSTRUCTIVO_ENCUESTA
       End Get
       Set(ByVal value As String)
           _INSTRUCTIVO_ENCUESTA = value
       End Set
   End Property


   Public Property FORMULARIO_ENCUESTA() As String
       Get
           return _FORMULARIO_ENCUESTA
       End Get
       Set(ByVal value As String)
           _FORMULARIO_ENCUESTA = value
       End Set
   End Property


   Public Property ESTADO_DATOENCUESTA() As Boolean
       Get
           return _ESTADO_DATOENCUESTA
       End Get
       Set(ByVal value As Boolean)
           _ESTADO_DATOENCUESTA = value
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
