Imports System.Data


public class GES_ASIGNACIONCARGAENT

#REGION "ATRIBUTOS DE LA CLASE"

   Private _ID_ENCUESTA as Integer
   Private _RUT as Integer
   Private _ROL as Integer
   Private _DIGITADOR as String
   Private _ANALISTA_REGIONAL as String
   Private _ANALISTA as String
   Private _ANO as Integer
   Private _PERIODO as Integer

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


   Public Property RUT() As Integer
       Get
           return _RUT
       End Get
       Set(ByVal value As Integer)
           _RUT = value
       End Set
   End Property


   Public Property ROL() As Integer
       Get
           return _ROL
       End Get
       Set(ByVal value As Integer)
           _ROL = value
       End Set
   End Property


   Public Property DIGITADOR() As String
       Get
           return _DIGITADOR
       End Get
       Set(ByVal value As String)
           _DIGITADOR = value
       End Set
   End Property


   Public Property ANALISTA_REGIONAL() As String
       Get
           return _ANALISTA_REGIONAL
       End Get
       Set(ByVal value As String)
           _ANALISTA_REGIONAL = value
       End Set
   End Property


   Public Property ANALISTA() As String
       Get
           return _ANALISTA
       End Get
       Set(ByVal value As String)
           _ANALISTA = value
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


   Public Property PERIODO() As Integer
       Get
           return _PERIODO
       End Get
       Set(ByVal value As Integer)
           _PERIODO = value
       End Set
   End Property
#END REGION


#REGION "CONSTRUCTORES DE LA CLASE"
   Public Sub New()

   End Sub
#END REGION

end class
