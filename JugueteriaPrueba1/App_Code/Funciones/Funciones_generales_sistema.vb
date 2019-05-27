Public Class Funciones_generales_sistema

#Region "Manipulación de Claves (Generación de claves aleatorias y encriptación de clave MD5)"
    ''' <sumary>
    ''' Función que cambia un texto a MD5
    ''' <param name="texto">Valor que tiene la clave original del usuario.</param>
    ''' </sumary>
    Function cambiarClaveMD5(ByVal texto As String) As String
        Dim md5 As New System.Security.Cryptography.MD5CryptoServiceProvider()
        Dim bytesToHash() As Byte = System.Text.Encoding.ASCII.GetBytes(texto)
        bytesToHash = md5.ComputeHash(bytesToHash)
        Dim strResult As String = ""
        For Each b As Byte In bytesToHash
            strResult += b.ToString("x2")
        Next
        Return strResult
    End Function


    ''' <summary>
    ''' Funcion Genera una Clave aleatoria de letras y Numeros
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function ClaveAleatoriaLetraNumero() As String
        Dim letras As String = "AaCcDdEeFfHKMmNnPpQqRrTtUuVvWwXxYy"
        Dim numeros As String = "2345789"
        Dim largo As New Random
        Dim passrandom As String = ""
        Dim pos As Integer
        Dim bool As Boolean = True
        If largo.Next(0, 2) = 0 Then
            pos = largo.Next(0, 6)
            passrandom = passrandom + numeros.Substring(pos, 1)
            bool = True
        Else
            pos = largo.Next(0, 33)
            passrandom = passrandom + letras.Substring(pos, 1)
            bool = False
        End If
        For i As Integer = 2 To 6
            If Not bool Then
                pos = largo.Next(0, 6)
                passrandom = passrandom + numeros.Substring(pos, 1)
                bool = True
            Else
                pos = largo.Next(0, 33)
                passrandom = passrandom + letras.Substring(pos, 1)
                bool = False
            End If
        Next
        Return passrandom
    End Function

#End Region
End Class
