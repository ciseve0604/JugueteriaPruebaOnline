Imports System.Data


public class GLO_TIPOESTABLECIMIENTOENT

#REGION "ATRIBUTOS DE LA CLASE"

   Private _ID_TIPOESTABLECIMIENTO as Integer
   Private _GLOSA_TIPOESTABLECIMIENTO as String

#END REGION

#REGION "METODOS DE LA CLASE"


   Public Property ID_TIPOESTABLECIMIENTO() As Integer
       Get
           return _ID_TIPOESTABLECIMIENTO
       End Get
       Set(ByVal value As Integer)
           _ID_TIPOESTABLECIMIENTO = value
       End Set
   End Property


   Public Property GLOSA_TIPOESTABLECIMIENTO() As String
       Get
           return _GLOSA_TIPOESTABLECIMIENTO
       End Get
       Set(ByVal value As String)
           _GLOSA_TIPOESTABLECIMIENTO = value
       End Set
   End Property
#END REGION


#REGION "CONSTRUCTORES DE LA CLASE"
   Public Sub New()

   End Sub
#END REGION

end class
