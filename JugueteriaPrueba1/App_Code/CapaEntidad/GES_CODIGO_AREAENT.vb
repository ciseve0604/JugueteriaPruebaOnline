Imports System.Data


public class GES_CODIGO_AREAENT

#REGION "ATRIBUTOS DE LA CLASE"

   Private _ID as Integer
   Private _CODIGO as String

#END REGION

#REGION "METODOS DE LA CLASE"


   Public Property ID() As Integer
       Get
           return _ID
       End Get
       Set(ByVal value As Integer)
           _ID = value
       End Set
   End Property


   Public Property CODIGO() As String
       Get
           return _CODIGO
       End Get
       Set(ByVal value As String)
           _CODIGO = value
       End Set
   End Property
#END REGION


#REGION "CONSTRUCTORES DE LA CLASE"
   Public Sub New()

   End Sub
#END REGION

end class
