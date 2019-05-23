Imports System.Data


public class GES_PERIODO_APERTURACIERREENT

#REGION "ATRIBUTOS DE LA CLASE"

   Private _ID_ENCUESTA as Integer
   Private _ANO as Integer
   Private _MES as Integer
   Private _ABIERTO as Boolean
   Private _CERRADO as Boolean
   Private _FECHA_APERTURA as String
   Private _FECHA_CIERRE as String

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


   Public Property ANO() As Integer
       Get
           return _ANO
       End Get
       Set(ByVal value As Integer)
           _ANO = value
       End Set
   End Property


   Public Property MES() As Integer
       Get
           return _MES
       End Get
       Set(ByVal value As Integer)
           _MES = value
       End Set
   End Property


   Public Property ABIERTO() As Boolean
       Get
           return _ABIERTO
       End Get
       Set(ByVal value As Boolean)
           _ABIERTO = value
       End Set
   End Property


   Public Property CERRADO() As Boolean
       Get
           return _CERRADO
       End Get
       Set(ByVal value As Boolean)
           _CERRADO = value
       End Set
   End Property


   Public Property FECHA_APERTURA() As String
       Get
           return _FECHA_APERTURA
       End Get
       Set(ByVal value As String)
           _FECHA_APERTURA = value
       End Set
   End Property


   Public Property FECHA_CIERRE() As String
       Get
           return _FECHA_CIERRE
       End Get
       Set(ByVal value As String)
           _FECHA_CIERRE = value
       End Set
   End Property
#END REGION


#REGION "CONSTRUCTORES DE LA CLASE"
   Public Sub New()

   End Sub
#END REGION

end class
