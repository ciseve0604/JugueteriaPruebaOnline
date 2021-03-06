Imports System.Data


public class DIR_EMPRESACREADOENT

#REGION "ATRIBUTOS DE LA CLASE"

   Private _ID_ENCUESTA as Integer
   Private _RUT as Integer
   Private _DVRUT as String
   Private _RAZONSOCIAL as String
   Private _REPRESENTANTELEGAL as String
   Private _RUTREPRESENTANTELEGAL as Integer
   Private _DVRUTREPRESENTANTELEGAL as String
   Private _REGION_G as Integer
   Private _PROVINCIA_G as Integer
   Private _COMUNA_G as Integer
   Private _GLOSA_COMUNA_G as String
   Private _DIRECCION_G as String
   Private _CODA_FONO_G as String
   Private _FONO_G as String
   Private _CODA_FAX_G as String
   Private _FAX_G as String
   Private _CELULAR_G as String
   Private _CASILLA as String
   Private _EMAIL_G as String
   Private _WEB_G as String
   Private _NRO_ESTABLECIMIENTOS as Integer
   Private _ACTIVIDADECONOMICA1 as String
   Private _FECHA_CREACION as String
   Private _USUARIO_CREACION as String

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


   Public Property DVRUT() As String
       Get
           return _DVRUT
       End Get
       Set(ByVal value As String)
           _DVRUT = value
       End Set
   End Property


   Public Property RAZONSOCIAL() As String
       Get
           return _RAZONSOCIAL
       End Get
       Set(ByVal value As String)
           _RAZONSOCIAL = value
       End Set
   End Property


   Public Property REPRESENTANTELEGAL() As String
       Get
           return _REPRESENTANTELEGAL
       End Get
       Set(ByVal value As String)
           _REPRESENTANTELEGAL = value
       End Set
   End Property


   Public Property RUTREPRESENTANTELEGAL() As Integer
       Get
           return _RUTREPRESENTANTELEGAL
       End Get
       Set(ByVal value As Integer)
           _RUTREPRESENTANTELEGAL = value
       End Set
   End Property


   Public Property DVRUTREPRESENTANTELEGAL() As String
       Get
           return _DVRUTREPRESENTANTELEGAL
       End Get
       Set(ByVal value As String)
           _DVRUTREPRESENTANTELEGAL = value
       End Set
   End Property


   Public Property REGION_G() As Integer
       Get
           return _REGION_G
       End Get
       Set(ByVal value As Integer)
           _REGION_G = value
       End Set
   End Property


   Public Property PROVINCIA_G() As Integer
       Get
           return _PROVINCIA_G
       End Get
       Set(ByVal value As Integer)
           _PROVINCIA_G = value
       End Set
   End Property


   Public Property COMUNA_G() As Integer
       Get
           return _COMUNA_G
       End Get
       Set(ByVal value As Integer)
           _COMUNA_G = value
       End Set
   End Property


   Public Property GLOSA_COMUNA_G() As String
       Get
           return _GLOSA_COMUNA_G
       End Get
       Set(ByVal value As String)
           _GLOSA_COMUNA_G = value
       End Set
   End Property


   Public Property DIRECCION_G() As String
       Get
           return _DIRECCION_G
       End Get
       Set(ByVal value As String)
           _DIRECCION_G = value
       End Set
   End Property


   Public Property CODA_FONO_G() As String
       Get
           return _CODA_FONO_G
       End Get
       Set(ByVal value As String)
           _CODA_FONO_G = value
       End Set
   End Property


   Public Property FONO_G() As String
       Get
           return _FONO_G
       End Get
       Set(ByVal value As String)
           _FONO_G = value
       End Set
   End Property


   Public Property CODA_FAX_G() As String
       Get
           return _CODA_FAX_G
       End Get
       Set(ByVal value As String)
           _CODA_FAX_G = value
       End Set
   End Property


   Public Property FAX_G() As String
       Get
           return _FAX_G
       End Get
       Set(ByVal value As String)
           _FAX_G = value
       End Set
   End Property


   Public Property CELULAR_G() As String
       Get
           return _CELULAR_G
       End Get
       Set(ByVal value As String)
           _CELULAR_G = value
       End Set
   End Property


   Public Property CASILLA() As String
       Get
           return _CASILLA
       End Get
       Set(ByVal value As String)
           _CASILLA = value
       End Set
   End Property


   Public Property EMAIL_G() As String
       Get
           return _EMAIL_G
       End Get
       Set(ByVal value As String)
           _EMAIL_G = value
       End Set
   End Property


   Public Property WEB_G() As String
       Get
           return _WEB_G
       End Get
       Set(ByVal value As String)
           _WEB_G = value
       End Set
   End Property


   Public Property NRO_ESTABLECIMIENTOS() As Integer
       Get
           return _NRO_ESTABLECIMIENTOS
       End Get
       Set(ByVal value As Integer)
           _NRO_ESTABLECIMIENTOS = value
       End Set
   End Property


   Public Property ACTIVIDADECONOMICA1() As String
       Get
           return _ACTIVIDADECONOMICA1
       End Get
       Set(ByVal value As String)
           _ACTIVIDADECONOMICA1 = value
       End Set
   End Property


   Public Property FECHA_CREACION() As String
       Get
           return _FECHA_CREACION
       End Get
       Set(ByVal value As String)
           _FECHA_CREACION = value
       End Set
   End Property


   Public Property USUARIO_CREACION() As String
       Get
           return _USUARIO_CREACION
       End Get
       Set(ByVal value As String)
           _USUARIO_CREACION = value
       End Set
   End Property
#END REGION


#REGION "CONSTRUCTORES DE LA CLASE"
   Public Sub New()

   End Sub
#END REGION

end class
