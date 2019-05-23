Imports System.Data


public class GLO_TIPOFUNCIONAMIENTOENT

#REGION "ATRIBUTOS DE LA CLASE"

   Private _ID_TIPOFUNCIONAMIENTO as Integer
   Private _GLOSA_TIPOFUNCIONAMIENTO as String

#END REGION

#REGION "METODOS DE LA CLASE"


   Public Property ID_TIPOFUNCIONAMIENTO() As Integer
       Get
           return _ID_TIPOFUNCIONAMIENTO
       End Get
       Set(ByVal value As Integer)
           _ID_TIPOFUNCIONAMIENTO = value
       End Set
   End Property


   Public Property GLOSA_TIPOFUNCIONAMIENTO() As String
       Get
           return _GLOSA_TIPOFUNCIONAMIENTO
       End Get
       Set(ByVal value As String)
           _GLOSA_TIPOFUNCIONAMIENTO = value
       End Set
   End Property
#END REGION


#REGION "CONSTRUCTORES DE LA CLASE"
   Public Sub New()

   End Sub
#END REGION

end class
