Imports System.Data


public class GLO_ACTIVIDADECONOMICAENT

#REGION "ATRIBUTOS DE LA CLASE"

   Private _ID_ACTIVIDADECONOMICA as Integer
   Private _GLOSA_ACTIVIDADECONOMICA as String

#END REGION

#REGION "METODOS DE LA CLASE"


   Public Property ID_ACTIVIDADECONOMICA() As Integer
       Get
           return _ID_ACTIVIDADECONOMICA
       End Get
       Set(ByVal value As Integer)
           _ID_ACTIVIDADECONOMICA = value
       End Set
   End Property


   Public Property GLOSA_ACTIVIDADECONOMICA() As String
       Get
           return _GLOSA_ACTIVIDADECONOMICA
       End Get
       Set(ByVal value As String)
           _GLOSA_ACTIVIDADECONOMICA = value
       End Set
   End Property
#END REGION


#REGION "CONSTRUCTORES DE LA CLASE"
   Public Sub New()

   End Sub
#END REGION

end class
