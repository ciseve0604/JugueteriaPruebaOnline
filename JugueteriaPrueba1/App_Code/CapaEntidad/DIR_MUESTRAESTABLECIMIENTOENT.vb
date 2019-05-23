Imports System.Data


public class DIR_MUESTRAESTABLECIMIENTOENT

#REGION "ATRIBUTOS DE LA CLASE"

   Private _ID_ENCUESTA as Integer
   Private _ROL as Integer
   Private _DVROL as String
   Private _PERIODO_INICIO as Integer
   Private _PERIODO_FIN as Integer
   Private _ANO_INICIO as Integer
   Private _ANO_FIN as Integer
   Private _RUT as Integer
   Private _NUI as Integer
   Private _DVNUI as Integer
   Private _CIIU as String
   Private _REGION_E as Integer
   Private _PROVINCIA_E as Integer
   Private _COMUNA_E as Integer
   Private _GLOSA_COMUNA_E as String
   Private _CALLE_E as String
   Private _NRO_E as String
   Private _NRO_LOCAL_E as String
   Private _CODA_FONO_E as String
   Private _FONO_E as String
   Private _CODA_FAX_E as String
   Private _FAX_E as String
   Private _EMAIL_E as String
   Private _WEB_E as String
   Private _CASILLA_COMERCIAL as String
   Private _NOMBREESTABLECIMIENTO as String
   Private _TIPO_ESTABLECIMIENTO as String
    Private _TIPO_FUNCIONAMIENTO As String
    Private _CLASE As String
   Private _EXROL as Integer
   Private _HABITACIONES_UNIDADES_HABITACIONALES as Integer
   Private _HABITACIONES_CAPACIDAD_MAXIMA as Integer
   Private _CABANAS_UNIDADES_HABITACIONALES as Integer
   Private _CABANAS_CAPACIDAD_MAXIMA as Integer
   Private _DEPARTAMENTOS_UNIDADES_HABITACIONALES as Integer
   Private _DEPARTAMENTOS_CAPACIDAD_MAXIMA as Integer
   Private _SITIOSDECAMPING_UNIDADES_HABITACIONALES as Integer
   Private _SITIOSDECAMPING_CAPACIDAD_MAXIMA as Integer
   Private _TOTAL_UNIDADES_HABITACIONALES as Integer
   Private _TOTAL_CAPACIDAD_MAXIMA as Integer
   Private _PERSONAL_OCUPADO_PERMANENTE_HOMBRE as Integer
   Private _PERSONAL_OCUPADO_PERMANENTE_MUJER as Integer
   Private _PERSONAL_OCUPADO_EVENTUAL_HOMBRE as Integer
   Private _PERSONAL_OCUPADO_EVENTUAL_MUJER as Integer
   Private _TOTAL_PERSONAL_OCUPADO_HOMBRE as Integer
   Private _TOTAL_PERSONAL_OCUPADO_MUJER as Integer
   Private _TOTAL_PERSONAL_OCUPADO as Integer
   Private _FECHA_CREACION_MUESTRA_E as String

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


   Public Property ROL() As Integer
       Get
           return _ROL
       End Get
       Set(ByVal value As Integer)
           _ROL = value
       End Set
   End Property


   Public Property DVROL() As String
       Get
           return _DVROL
       End Get
       Set(ByVal value As String)
           _DVROL = value
       End Set
   End Property


   Public Property PERIODO_INICIO() As Integer
       Get
           return _PERIODO_INICIO
       End Get
       Set(ByVal value As Integer)
           _PERIODO_INICIO = value
       End Set
   End Property


   Public Property PERIODO_FIN() As Integer
       Get
           return _PERIODO_FIN
       End Get
       Set(ByVal value As Integer)
           _PERIODO_FIN = value
       End Set
   End Property


   Public Property ANO_INICIO() As Integer
       Get
           return _ANO_INICIO
       End Get
       Set(ByVal value As Integer)
           _ANO_INICIO = value
       End Set
   End Property


   Public Property ANO_FIN() As Integer
       Get
           return _ANO_FIN
       End Get
       Set(ByVal value As Integer)
           _ANO_FIN = value
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


   Public Property NUI() As Integer
       Get
           return _NUI
       End Get
       Set(ByVal value As Integer)
           _NUI = value
       End Set
   End Property


   Public Property DVNUI() As Integer
       Get
           return _DVNUI
       End Get
       Set(ByVal value As Integer)
           _DVNUI = value
       End Set
   End Property


   Public Property CIIU() As String
       Get
           return _CIIU
       End Get
       Set(ByVal value As String)
           _CIIU = value
       End Set
   End Property


   Public Property REGION_E() As Integer
       Get
           return _REGION_E
       End Get
       Set(ByVal value As Integer)
           _REGION_E = value
       End Set
   End Property


   Public Property PROVINCIA_E() As Integer
       Get
           return _PROVINCIA_E
       End Get
       Set(ByVal value As Integer)
           _PROVINCIA_E = value
       End Set
   End Property


   Public Property COMUNA_E() As Integer
       Get
           return _COMUNA_E
       End Get
       Set(ByVal value As Integer)
           _COMUNA_E = value
       End Set
   End Property


   Public Property GLOSA_COMUNA_E() As String
       Get
           return _GLOSA_COMUNA_E
       End Get
       Set(ByVal value As String)
           _GLOSA_COMUNA_E = value
       End Set
   End Property


   Public Property CALLE_E() As String
       Get
           return _CALLE_E
       End Get
       Set(ByVal value As String)
           _CALLE_E = value
       End Set
   End Property


   Public Property NRO_E() As String
       Get
           return _NRO_E
       End Get
       Set(ByVal value As String)
           _NRO_E = value
       End Set
   End Property


   Public Property NRO_LOCAL_E() As String
       Get
           return _NRO_LOCAL_E
       End Get
       Set(ByVal value As String)
           _NRO_LOCAL_E = value
       End Set
   End Property


   Public Property CODA_FONO_E() As String
       Get
           return _CODA_FONO_E
       End Get
       Set(ByVal value As String)
           _CODA_FONO_E = value
       End Set
   End Property


   Public Property FONO_E() As String
       Get
           return _FONO_E
       End Get
       Set(ByVal value As String)
           _FONO_E = value
       End Set
   End Property


   Public Property CODA_FAX_E() As String
       Get
           return _CODA_FAX_E
       End Get
       Set(ByVal value As String)
           _CODA_FAX_E = value
       End Set
   End Property


   Public Property FAX_E() As String
       Get
           return _FAX_E
       End Get
       Set(ByVal value As String)
           _FAX_E = value
       End Set
   End Property


   Public Property EMAIL_E() As String
       Get
           return _EMAIL_E
       End Get
       Set(ByVal value As String)
           _EMAIL_E = value
       End Set
   End Property


   Public Property WEB_E() As String
       Get
           return _WEB_E
       End Get
       Set(ByVal value As String)
           _WEB_E = value
       End Set
   End Property


   Public Property CASILLA_COMERCIAL() As String
       Get
           return _CASILLA_COMERCIAL
       End Get
       Set(ByVal value As String)
           _CASILLA_COMERCIAL = value
       End Set
   End Property


   Public Property NOMBREESTABLECIMIENTO() As String
       Get
           return _NOMBREESTABLECIMIENTO
       End Get
       Set(ByVal value As String)
           _NOMBREESTABLECIMIENTO = value
       End Set
   End Property


   Public Property TIPO_ESTABLECIMIENTO() As String
       Get
           return _TIPO_ESTABLECIMIENTO
       End Get
       Set(ByVal value As String)
           _TIPO_ESTABLECIMIENTO = value
       End Set
   End Property


   Public Property TIPO_FUNCIONAMIENTO() As String
       Get
           return _TIPO_FUNCIONAMIENTO
       End Get
       Set(ByVal value As String)
           _TIPO_FUNCIONAMIENTO = value
       End Set
   End Property


    Public Property CLASE() As String
        Get
            Return _CLASE
        End Get
        Set(ByVal value As String)
            _CLASE = value
        End Set
    End Property


   Public Property EXROL() As Integer
       Get
           return _EXROL
       End Get
       Set(ByVal value As Integer)
           _EXROL = value
       End Set
   End Property


   Public Property HABITACIONES_UNIDADES_HABITACIONALES() As Integer
       Get
           return _HABITACIONES_UNIDADES_HABITACIONALES
       End Get
       Set(ByVal value As Integer)
           _HABITACIONES_UNIDADES_HABITACIONALES = value
       End Set
   End Property


   Public Property HABITACIONES_CAPACIDAD_MAXIMA() As Integer
       Get
           return _HABITACIONES_CAPACIDAD_MAXIMA
       End Get
       Set(ByVal value As Integer)
           _HABITACIONES_CAPACIDAD_MAXIMA = value
       End Set
   End Property


   Public Property CABANAS_UNIDADES_HABITACIONALES() As Integer
       Get
           return _CABANAS_UNIDADES_HABITACIONALES
       End Get
       Set(ByVal value As Integer)
           _CABANAS_UNIDADES_HABITACIONALES = value
       End Set
   End Property


   Public Property CABANAS_CAPACIDAD_MAXIMA() As Integer
       Get
           return _CABANAS_CAPACIDAD_MAXIMA
       End Get
       Set(ByVal value As Integer)
           _CABANAS_CAPACIDAD_MAXIMA = value
       End Set
   End Property


   Public Property DEPARTAMENTOS_UNIDADES_HABITACIONALES() As Integer
       Get
           return _DEPARTAMENTOS_UNIDADES_HABITACIONALES
       End Get
       Set(ByVal value As Integer)
           _DEPARTAMENTOS_UNIDADES_HABITACIONALES = value
       End Set
   End Property


   Public Property DEPARTAMENTOS_CAPACIDAD_MAXIMA() As Integer
       Get
           return _DEPARTAMENTOS_CAPACIDAD_MAXIMA
       End Get
       Set(ByVal value As Integer)
           _DEPARTAMENTOS_CAPACIDAD_MAXIMA = value
       End Set
   End Property


   Public Property SITIOSDECAMPING_UNIDADES_HABITACIONALES() As Integer
       Get
           return _SITIOSDECAMPING_UNIDADES_HABITACIONALES
       End Get
       Set(ByVal value As Integer)
           _SITIOSDECAMPING_UNIDADES_HABITACIONALES = value
       End Set
   End Property


   Public Property SITIOSDECAMPING_CAPACIDAD_MAXIMA() As Integer
       Get
           return _SITIOSDECAMPING_CAPACIDAD_MAXIMA
       End Get
       Set(ByVal value As Integer)
           _SITIOSDECAMPING_CAPACIDAD_MAXIMA = value
       End Set
   End Property


   Public Property TOTAL_UNIDADES_HABITACIONALES() As Integer
       Get
           return _TOTAL_UNIDADES_HABITACIONALES
       End Get
       Set(ByVal value As Integer)
           _TOTAL_UNIDADES_HABITACIONALES = value
       End Set
   End Property


   Public Property TOTAL_CAPACIDAD_MAXIMA() As Integer
       Get
           return _TOTAL_CAPACIDAD_MAXIMA
       End Get
       Set(ByVal value As Integer)
           _TOTAL_CAPACIDAD_MAXIMA = value
       End Set
   End Property


   Public Property PERSONAL_OCUPADO_PERMANENTE_HOMBRE() As Integer
       Get
           return _PERSONAL_OCUPADO_PERMANENTE_HOMBRE
       End Get
       Set(ByVal value As Integer)
           _PERSONAL_OCUPADO_PERMANENTE_HOMBRE = value
       End Set
   End Property


   Public Property PERSONAL_OCUPADO_PERMANENTE_MUJER() As Integer
       Get
           return _PERSONAL_OCUPADO_PERMANENTE_MUJER
       End Get
       Set(ByVal value As Integer)
           _PERSONAL_OCUPADO_PERMANENTE_MUJER = value
       End Set
   End Property


   Public Property PERSONAL_OCUPADO_EVENTUAL_HOMBRE() As Integer
       Get
           return _PERSONAL_OCUPADO_EVENTUAL_HOMBRE
       End Get
       Set(ByVal value As Integer)
           _PERSONAL_OCUPADO_EVENTUAL_HOMBRE = value
       End Set
   End Property


   Public Property PERSONAL_OCUPADO_EVENTUAL_MUJER() As Integer
       Get
           return _PERSONAL_OCUPADO_EVENTUAL_MUJER
       End Get
       Set(ByVal value As Integer)
           _PERSONAL_OCUPADO_EVENTUAL_MUJER = value
       End Set
   End Property


   Public Property TOTAL_PERSONAL_OCUPADO_HOMBRE() As Integer
       Get
           return _TOTAL_PERSONAL_OCUPADO_HOMBRE
       End Get
       Set(ByVal value As Integer)
           _TOTAL_PERSONAL_OCUPADO_HOMBRE = value
       End Set
   End Property


   Public Property TOTAL_PERSONAL_OCUPADO_MUJER() As Integer
       Get
           return _TOTAL_PERSONAL_OCUPADO_MUJER
       End Get
       Set(ByVal value As Integer)
           _TOTAL_PERSONAL_OCUPADO_MUJER = value
       End Set
   End Property


   Public Property TOTAL_PERSONAL_OCUPADO() As Integer
       Get
           return _TOTAL_PERSONAL_OCUPADO
       End Get
       Set(ByVal value As Integer)
           _TOTAL_PERSONAL_OCUPADO = value
       End Set
   End Property


   Public Property FECHA_CREACION_MUESTRA_E() As String
       Get
           return _FECHA_CREACION_MUESTRA_E
       End Get
       Set(ByVal value As String)
           _FECHA_CREACION_MUESTRA_E = value
       End Set
   End Property
#END REGION


#REGION "CONSTRUCTORES DE LA CLASE"
   Public Sub New()

   End Sub
#END REGION

end class
