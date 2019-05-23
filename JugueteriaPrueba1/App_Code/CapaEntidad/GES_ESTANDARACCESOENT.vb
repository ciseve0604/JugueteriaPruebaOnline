Imports System.Data


public class GES_ESTANDARACCESOENT

#REGION "ATRIBUTOS DE LA CLASE"

   Private _ID_ENCUESTA as Integer
   Private _NOMBRE_USUARIO as String
   Private _ID_TIPOACCESO as Integer

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


   Public Property NOMBRE_USUARIO() As String
       Get
           return _NOMBRE_USUARIO
       End Get
       Set(ByVal value As String)
           _NOMBRE_USUARIO = value
       End Set
   End Property


   Public Property ID_TIPOACCESO() As Integer
       Get
           return _ID_TIPOACCESO
       End Get
       Set(ByVal value As Integer)
           _ID_TIPOACCESO = value
       End Set
   End Property
#END REGION


#REGION "CONSTRUCTORES DE LA CLASE"
   Public Sub New()

   End Sub
#END REGION

end class
