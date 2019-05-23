Imports System.Data


public class GES_PRIVILEGIOSNEG

#REGION "METODOS DE LOGICA"

   Public Sub Insertar(byval GES_PRIVILEGIOS as GES_PRIVILEGIOSENT)
       Try
           Dim GES_PRIVILEGIOSDatos as new GES_PRIVILEGIOSDAT
           GES_PRIVILEGIOSDatos.insertar(GES_PRIVILEGIOS)
       Catch ex As Exception
           Throw New Exception(ex.Message)
       End Try
   End Sub

    Public Sub Actualizar(ByVal GES_PRIVILEGIOS As GES_PRIVILEGIOSENT, ByVal user As String)
        Try
            Dim GES_PRIVILEGIOSDatos As New GES_PRIVILEGIOSDAT
            GES_PRIVILEGIOSDatos.Actualizar(GES_PRIVILEGIOS, user)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

   Public Sub Eliminar(byval GES_PRIVILEGIOS as GES_PRIVILEGIOSENT)
       Try
           Dim GES_PRIVILEGIOSDatos as new GES_PRIVILEGIOSDAT
           GES_PRIVILEGIOSDatos.eliminar(GES_PRIVILEGIOS)
       Catch ex As Exception
           Throw New Exception(ex.Message)
       End Try
   End Sub

    Public Function Listar(ByVal PRIVILEGIO As Integer) As GES_PRIVILEGIOSENT()
        Try
            Dim GES_PRIVILEGIOSDatos As New GES_PRIVILEGIOSDAT
            Return GES_PRIVILEGIOSDatos.Listar(PRIVILEGIO)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function


    Public Sub CargarPrivilegios(ByVal PRIVILEGIO As Integer)
        Try
            Dim GES_PRIVILEGIOSDatos As New GES_PRIVILEGIOSDAT
            GES_PRIVILEGIOSDatos.CargarPrivilegios(PRIVILEGIO)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

#END REGION
end class
