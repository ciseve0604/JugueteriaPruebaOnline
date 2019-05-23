Imports System.Data


public class LOG_ESTADOEMPRESAENT

#REGION "ATRIBUTOS DE LA CLASE"

   Private _ID_ENCUESTA as Integer
   Private _RUT as Integer
   Private _ID_ESTADOEMPRESA as Integer
   Private _FECHA_ACTUALIZACION as String
   Private _USUARIO_ACTUALIZACION as String
   Private _COMENTARIO as String

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


   Public Property ID_ESTADOEMPRESA() As Integer
       Get
           return _ID_ESTADOEMPRESA
       End Get
       Set(ByVal value As Integer)
           _ID_ESTADOEMPRESA = value
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


   Public Property USUARIO_ACTUALIZACION() As String
       Get
           return _USUARIO_ACTUALIZACION
       End Get
       Set(ByVal value As String)
           _USUARIO_ACTUALIZACION = value
       End Set
   End Property


   Public Property COMENTARIO() As String
       Get
           return _COMENTARIO
       End Get
       Set(ByVal value As String)
           _COMENTARIO = value
       End Set
   End Property
#END REGION


#REGION "CONSTRUCTORES DE LA CLASE"
   Public Sub New()

   End Sub
#END REGION

end class
