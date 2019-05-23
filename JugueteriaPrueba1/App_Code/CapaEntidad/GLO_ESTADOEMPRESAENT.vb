Imports System.Data


public class GLO_ESTADOEMPRESAENT

#REGION "ATRIBUTOS DE LA CLASE"

   Private _ID_ESTADOEMPRESA as Integer
   Private _GLOSA_ESTADOEMPRESA as String

#END REGION

#REGION "METODOS DE LA CLASE"


   Public Property ID_ESTADOEMPRESA() As Integer
       Get
           return _ID_ESTADOEMPRESA
       End Get
       Set(ByVal value As Integer)
           _ID_ESTADOEMPRESA = value
       End Set
   End Property


   Public Property GLOSA_ESTADOEMPRESA() As String
       Get
           return _GLOSA_ESTADOEMPRESA
       End Get
       Set(ByVal value As String)
           _GLOSA_ESTADOEMPRESA = value
       End Set
   End Property
#END REGION


#REGION "CONSTRUCTORES DE LA CLASE"
   Public Sub New()

   End Sub
#END REGION

end class
