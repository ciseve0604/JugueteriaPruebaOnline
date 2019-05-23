Imports System.Data


public class GES_PRIVILEGIOSENT

#REGION "ATRIBUTOS DE LA CLASE"

    Private _ID_MENU As Integer
    Private _NOMBRE_MENU As String
   Private _ID_TIPOACCESO as Integer
   Private _ESTADO_PRIVILEGIO as Boolean

#END REGION

#REGION "METODOS DE LA CLASE"


   Public Property ID_MENU() As Integer
       Get
           return _ID_MENU
       End Get
       Set(ByVal value As Integer)
           _ID_MENU = value
       End Set
   End Property
    Public Property NOMBRE_MENU() As String
        Get
            Return _NOMBRE_MENU
        End Get
        Set(ByVal value As String)
            _NOMBRE_MENU = value
        End Set
    End Property

   Public Property ID_TIPOACCESO() As Integer
       Get
           return _ID_TIPOACCESO
       End Get
       Set(ByVal value As Integer)
           _ID_TIPOACCESO = value
       End Set
   End Property


   Public Property ESTADO_PRIVILEGIO() As Boolean
       Get
           return _ESTADO_PRIVILEGIO
       End Get
       Set(ByVal value As Boolean)
           _ESTADO_PRIVILEGIO = value
       End Set
   End Property
#END REGION


#REGION "CONSTRUCTORES DE LA CLASE"
   Public Sub New()

   End Sub
#END REGION

end class
