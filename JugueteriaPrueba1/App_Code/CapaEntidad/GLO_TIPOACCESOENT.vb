Imports System.Data


public class GLO_TIPOACCESOENT

#REGION "ATRIBUTOS DE LA CLASE"

   Private _ID_TIPOACCESO as Integer
   Private _GLOSA_TIPOACCESO as String

#END REGION

#REGION "METODOS DE LA CLASE"


   Public Property ID_TIPOACCESO() As Integer
       Get
           return _ID_TIPOACCESO
       End Get
       Set(ByVal value As Integer)
           _ID_TIPOACCESO = value
       End Set
   End Property


   Public Property GLOSA_TIPOACCESO() As String
       Get
           return _GLOSA_TIPOACCESO
       End Get
       Set(ByVal value As String)
           _GLOSA_TIPOACCESO = value
       End Set
   End Property
#END REGION


#REGION "CONSTRUCTORES DE LA CLASE"
   Public Sub New()

   End Sub
#END REGION

end class
