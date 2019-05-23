Imports System.Data


public class GES_RPCENT

#REGION "ATRIBUTOS DE LA CLASE"

   Private _REGION as String
   Private _PROVINCIA as String
   Private _COMUNA as String
   Private _GLOSA as String
   Private _TIPO as Integer
   Private _GLOSA_TIPO as String

#END REGION

#REGION "METODOS DE LA CLASE"


   Public Property REGION() As String
       Get
           return _REGION
       End Get
       Set(ByVal value As String)
           _REGION = value
       End Set
   End Property


   Public Property PROVINCIA() As String
       Get
           return _PROVINCIA
       End Get
       Set(ByVal value As String)
           _PROVINCIA = value
       End Set
   End Property


   Public Property COMUNA() As String
       Get
           return _COMUNA
       End Get
       Set(ByVal value As String)
           _COMUNA = value
       End Set
   End Property


   Public Property GLOSA() As String
       Get
           return _GLOSA
       End Get
       Set(ByVal value As String)
           _GLOSA = value
       End Set
   End Property


   Public Property TIPO() As Integer
       Get
           return _TIPO
       End Get
       Set(ByVal value As Integer)
           _TIPO = value
       End Set
   End Property


   Public Property GLOSA_TIPO() As String
       Get
           return _GLOSA_TIPO
       End Get
       Set(ByVal value As String)
           _GLOSA_TIPO = value
       End Set
   End Property
#END REGION


#REGION "CONSTRUCTORES DE LA CLASE"
   Public Sub New()

   End Sub
#END REGION

end class
