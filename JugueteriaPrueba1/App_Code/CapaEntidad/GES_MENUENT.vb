Imports System.Data


public class GES_MENUENT

#REGION "ATRIBUTOS DE LA CLASE"

   Private _ID_MENU as Integer
   Private _NOMBRE_MENU as String
   Private _LINK_MENU as String
   Private _ORDEN as Integer
   Private _PADRE as Integer
   Private _ESTADO as Boolean

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
           return _NOMBRE_MENU
       End Get
       Set(ByVal value As String)
           _NOMBRE_MENU = value
       End Set
   End Property


   Public Property LINK_MENU() As String
       Get
           return _LINK_MENU
       End Get
       Set(ByVal value As String)
           _LINK_MENU = value
       End Set
   End Property


   Public Property ORDEN() As Integer
       Get
           return _ORDEN
       End Get
       Set(ByVal value As Integer)
           _ORDEN = value
       End Set
   End Property


   Public Property PADRE() As Integer
       Get
           return _PADRE
       End Get
       Set(ByVal value As Integer)
           _PADRE = value
       End Set
   End Property


   Public Property ESTADO() As Boolean
       Get
           return _ESTADO
       End Get
       Set(ByVal value As Boolean)
           _ESTADO = value
       End Set
   End Property
#END REGION


#REGION "CONSTRUCTORES DE LA CLASE"
   Public Sub New()

   End Sub
#END REGION

end class
