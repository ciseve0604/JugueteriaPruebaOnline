Imports System.Data


public class GLO_CLASEENT

#REGION "ATRIBUTOS DE LA CLASE"

   Private _ID_CLASE as Integer
   Private _GLOSA_CLASE as String

#END REGION

#REGION "METODOS DE LA CLASE"


   Public Property ID_CLASE() As Integer
       Get
           return _ID_CLASE
       End Get
       Set(ByVal value As Integer)
           _ID_CLASE = value
       End Set
   End Property


   Public Property GLOSA_CLASE() As String
       Get
           return _GLOSA_CLASE
       End Get
       Set(ByVal value As String)
           _GLOSA_CLASE = value
       End Set
   End Property
#END REGION


#REGION "CONSTRUCTORES DE LA CLASE"
   Public Sub New()

   End Sub
#END REGION

end class
