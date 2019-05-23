Imports System.Data


public class GES_ESTADOENCUESTAENT

#REGION "ATRIBUTOS DE LA CLASE"

   Private _ID_ENCUESTA as Integer
   Private _RUT as Integer
   Private _ROL as Integer
   Private _DVROL as String
   Private _ID_ESTADOENCUESTA as Integer
   Private _PERIODO as Integer
   Private _ANO as Integer
   Private _USUARIO_ACTUALIZACION as String
   Private _FECHA_ACTUALIZACION as String

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


   Public Property RUT() As Integer
       Get
           return _RUT
       End Get
       Set(ByVal value As Integer)
           _RUT = value
       End Set
   End Property


   Public Property ROL() As Integer
       Get
           return _ROL
       End Get
       Set(ByVal value As Integer)
           _ROL = value
       End Set
   End Property


   Public Property DVROL() As String
       Get
           return _DVROL
       End Get
       Set(ByVal value As String)
           _DVROL = value
       End Set
   End Property


   Public Property ID_ESTADOENCUESTA() As Integer
       Get
           return _ID_ESTADOENCUESTA
       End Get
       Set(ByVal value As Integer)
           _ID_ESTADOENCUESTA = value
       End Set
   End Property


   Public Property PERIODO() As Integer
       Get
           return _PERIODO
       End Get
       Set(ByVal value As Integer)
           _PERIODO = value
       End Set
   End Property


   Public Property ANO() As Integer
       Get
           return _ANO
       End Get
       Set(ByVal value As Integer)
           _ANO = value
       End Set
   End Property


   Public Property USUARIO_ACTUALIZACION() As String
       Get
           return _USUARIO_ACTUALIZACION
       End Get
       Set(ByVal value As String)
           _USUARIO_ACTUALIZACION = value
       End Set
   End Property


   Public Property FECHA_ACTUALIZACION() As String
       Get
           return _FECHA_ACTUALIZACION
       End Get
       Set(ByVal value As String)
           _FECHA_ACTUALIZACION = value
       End Set
   End Property
#END REGION


#REGION "CONSTRUCTORES DE LA CLASE"
   Public Sub New()

   End Sub
#END REGION

end class
