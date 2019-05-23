Imports System.Data


public class GLO_ESTADOESTABLECIMIENTOENT

#REGION "ATRIBUTOS DE LA CLASE"

   Private _ID_ESTADOESTABLECIMIENTO as Integer
   Private _GLOSA_ESTADOESTABLECIMIENTO as String

#END REGION

#REGION "METODOS DE LA CLASE"


   Public Property ID_ESTADOESTABLECIMIENTO() As Integer
       Get
           return _ID_ESTADOESTABLECIMIENTO
       End Get
       Set(ByVal value As Integer)
           _ID_ESTADOESTABLECIMIENTO = value
       End Set
   End Property


   Public Property GLOSA_ESTADOESTABLECIMIENTO() As String
       Get
           return _GLOSA_ESTADOESTABLECIMIENTO
       End Get
       Set(ByVal value As String)
           _GLOSA_ESTADOESTABLECIMIENTO = value
       End Set
   End Property
#END REGION


#REGION "CONSTRUCTORES DE LA CLASE"
   Public Sub New()

   End Sub
#END REGION

end class
