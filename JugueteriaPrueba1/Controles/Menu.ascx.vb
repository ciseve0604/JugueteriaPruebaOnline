Public Class Menu
    Inherits System.Web.UI.UserControl

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        'If Session("sUsuario") Is Nothing Then
        '    Response.Redirect("~/index.aspx")
        'End If

        '''Sección que valida si el usuario es válido
        'Application.Lock()
        '''Generamos un listado con los usuarios conectados.
        'Dim listaUsuarios As System.Collections.Generic.List(Of GES_USUARIOENT)
        '''Cargamos los usuarios conectados
        'listaUsuarios = Application("sUsuarios")
        '''Recorremos el listado de usuarios conectados.
        'For Each usuarioActivo As GES_USUARIOENT In listaUsuarios
        '    If Session.SessionID = usuarioActivo.idSession And usuarioActivo.EliminarSessionActiva Then

        '        listaUsuarios.Remove(usuarioActivo)
        '        Application("sUsuarios") = listaUsuarios


        '        FormsAuthentication.SignOut()
        '        Session.Clear()
        '        Session.Abandon()
        '        Response.Clear()
        '        Response.Redirect("~/index.aspx")
        '    End If
        'Next
        'Application.UnLock()


        ''Sección que obtiene la URL.
        Dim path As String = "~"
        For i As Integer = 2 To HttpContext.Current.Request.Url.AbsolutePath.Split("/").Length - 1
            path &= "/" & HttpContext.Current.Request.Url.AbsolutePath.Split("/")(i)
        Next
        Dim temp() As String
        temp = path.Split("?")
        path = temp(0)



        ''Cargamos el Menú
        If Me.IsPostBack = False Then
            cargarMenu()
        End If

        ''Función que sirve para expandir el menú según la URL 
        For i As Integer = 0 To trv_menu.Nodes.Count - 1
            If trv_menu.Nodes(i).ChildNodes.Count > 0 Then
                If (buscarNodoColeccion(path, trv_menu.Nodes(i).ChildNodes) = True) Then
                    trv_menu.Nodes(i).Expand()
                End If
            End If
        Next

        ''Función que carga si es que aún no se carga los accesos del usuario.
        Dim menusUsuario As GES_MENUNEG = New GES_MENUNEG()
        Dim arrMenuUsuario() As GES_MENUENT = menusUsuario.ListarMenuUsuario("cacevedof")

        ''Recorremos el listado del árbol para limpiar el menú.
        While True
            If Not limpiarBuscarNodoColeccion(arrMenuUsuario, trv_menu.Nodes) Then
                Continue While
            Else
                Exit While
            End If
        End While
        Dim Menu As String
        Menu = "<div id='cssmenu'> <ul>" & vbNewLine & "<li><a href='#'><span>Menu</span></a></li>"
        Menu = RecorrerTreeView(trv_menu.Nodes, Menu)
        Menu = Menu & vbNewLine & "</ul></div>"
        myControl.InnerHtml = Menu
    End Sub



    Function RecorrerTreeView(ByRef Nodos As TreeNodeCollection, ByVal Menu As String) As String
        For Each Nodo As TreeNode In Nodos
            If Nodo.ChildNodes.Count = 0 Then
                Menu = Menu & "<li><a href='/EMAT/" & Nodo.NavigateUrl & "'>" & vbNewLine & "<span>" & Nodo.Value.ToString & "</span>" & vbNewLine & "</a>" & vbNewLine & "</li>"
            Else
                Menu = Menu & "<li class='active has-sub'><a href='#'>" & vbNewLine & "<span>" & Nodo.Value.ToString & "</span>" & vbNewLine & "</a>" & vbNewLine & " <ul>"
                Menu = RecorrerTreeView(Nodo.ChildNodes, Menu) & vbNewLine & "</ul>"
            End If
        Next
        Return Menu
    End Function


#Region "Limpiar Árbol"
    Function limpiarBuscarNodoColeccion(ByVal arrMenuUsuario As GES_MENUENT(), ByVal nodo As TreeNodeCollection) As Boolean
        Dim bool As Boolean = True
        For i As Integer = 0 To nodo.Count - 1
            If nodo(i).ChildNodes.Count > 0 Then
                bool = limpiarBuscarNodoColeccion(arrMenuUsuario, nodo(i).ChildNodes)
                If bool Then
                    Continue For
                Else
                    Return False
                End If
            Else
                bool = limpiarBuscarNodoHoja(arrMenuUsuario, nodo(i))
                If bool Then
                    Continue For
                Else
                    nodo.Remove(nodo(i))
                    Return False
                End If
            End If
        Next
        Return True
    End Function

    Function limpiarBuscarNodoHoja(ByVal arrMenuUsuario As GES_MENUENT(), ByVal nodo As TreeNode) As Boolean
        For Each menu As GES_MENUENT In arrMenuUsuario
            If (nodo.NavigateUrl = menu.LINK_MENU And nodo.Text = menu.NOMBRE_MENU) Then
                Return True
            End If
        Next
        Return False
    End Function
#End Region

#Region "Buscar Nodo"
    Function buscarNodoColeccion(ByVal path As String, ByVal nodo As TreeNodeCollection) As Boolean
        Dim flag As Boolean = False
        For i As Integer = 0 To nodo.Count - 1
            If nodo(i).ChildNodes.Count > 0 Then
                If (buscarNodoColeccion(path, nodo(i).ChildNodes) = True) Then
                    nodo(i).Expand()
                    flag = True
                End If
            ElseIf buscarNodoHoja(path, nodo(i)) Then
                flag = True
            End If
        Next
        Return flag
    End Function

    Function buscarNodoHoja(ByVal path As String, ByVal nodo As TreeNode) As Boolean
        Dim flag As Boolean = False
        If nodo.NavigateUrl = path Then
            flag = True
        End If
        Return flag
    End Function
#End Region

#Region "Cargamos el Menu del Sistema"
    Sub cargarNodoHijo(ByVal nodoPadre As TreeNode, ByVal idNodoPadre As Integer, ByVal arrMnu As GES_MENUENT())

        Dim var_nodoHijo As TreeNode
        For Each var_menu As GES_MENUENT In arrMnu
            If idNodoPadre <> var_menu.ID_MENU And idNodoPadre = var_menu.PADRE And var_menu.ESTADO = True Then
                var_nodoHijo = New TreeNode(var_menu.NOMBRE_MENU)
                var_nodoHijo.NavigateUrl = var_menu.LINK_MENU
                var_nodoHijo.Collapse()
                cargarNodoHijo(var_nodoHijo, var_menu.ID_MENU, arrMnu)
                If var_nodoHijo.ChildNodes.Count > 0 Then
                    var_nodoHijo.SelectAction = TreeNodeSelectAction.Expand
                End If
                nodoPadre.ChildNodes.Add(var_nodoHijo)
            End If
        Next

    End Sub

    Sub cargarMenu()
        ''Creamos una variable para obtener el menu
        Dim mnuNeg As GES_MENUNEG = New GES_MENUNEG()
        Dim arrMnu() As GES_MENUENT
        arrMnu = mnuNeg.Listar()

        ''Declaramos una variable para guardar el menú
        Dim var_nodoPadre As TreeNode

        ''Recorremos el listado completo del menu obteniendo los nodos padre
        For Each var_menu As GES_MENUENT In arrMnu

            ''Consultamos si es un nodo padre
            If var_menu.ID_MENU = var_menu.PADRE And var_menu.ESTADO = True Then

                ''Creamos la variable TreeNode y creamos el nodo padre
                var_nodoPadre = New TreeNode(var_menu.NOMBRE_MENU)

                ''Asignamos los atributos al nodo padre
                var_nodoPadre.NavigateUrl = var_menu.LINK_MENU
                var_nodoPadre.SelectAction = TreeNodeSelectAction.Expand
                var_nodoPadre.Collapse()

                ''Cargamos los nodos hijos
                cargarNodoHijo(var_nodoPadre, var_menu.ID_MENU, arrMnu)

                ''Agregamos al arbol
                trv_menu.Nodes.Add(var_nodoPadre)

            End If
        Next
    End Sub
#End Region


End Class