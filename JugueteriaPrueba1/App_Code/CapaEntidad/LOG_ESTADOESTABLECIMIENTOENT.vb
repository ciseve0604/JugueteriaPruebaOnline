Imports System.Data


public class LOG_ESTADOESTABLECIMIENTOENT

#REGION "ATRIBUTOS DE LA CLASE"

   Private _ID_ENCUESTA as Integer
   Private _ROL as Integer
   Private _ID_ESTADOESTABLECIMIENTO as Integer
   Private _USUARIO_ACTUALIZACION as String
   Private _FECHA_ACTUALIZACION as String
   Private _OBSERVACION as String

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


   Public Property ROL() As Integer
       Get
           return _ROL
       End Get
       Set(ByVal value As Integer)
           _ROL = value
       End Set
   End Property


   Public Property ID_ESTADOESTABLECIMIENTO() As Integer
       Get
           return _ID_ESTADOESTABLECIMIENTO
       End Get
       Set(ByVal value As Integer)
           _ID_ESTADOESTABLECIMIENTO = value
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


   Public Property OBSERVACION() As String
       Get
           return _OBSERVACION
       End Get
       Set(ByVal value As String)
           _OBSERVACION = value
       End Set
   End Property
#END REGION


#REGION "CONSTRUCTORES DE LA CLASE"
   Public Sub New()

   End Sub
#END REGION

end class
