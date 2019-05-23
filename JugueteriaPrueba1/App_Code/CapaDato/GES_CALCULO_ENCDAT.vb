Imports Microsoft.VisualBasic

Public Class GES_CALCULO_ENCDAT
#Region "METODO INGRESO"

    'Este método permite cargar las imputaciones directamente en la Base de cálculo (considerar que ya trabaja con las 16 regiones)
    Public Sub Insertar_Actualizada16reg(ByVal dr As Data.DataRow, ByVal sp As StoredProcedure_class, ByVal sqlCmd As Data.SqlClient.SqlCommand, ByVal usuario_actualizacion As String, ByVal periodo As Integer, ByVal ano As Integer, ByVal procesoCargaImputacon As Integer)
        Try
            sp.AgregarParametro("Nui", dr("Nui").ToString)
            sp.AgregarParametro("DiasFuncionamiento", dr("DiasFuncionamiento").ToString)
            sp.AgregarParametro("Habitaciones", dr("Habitaciones").ToString)
            sp.AgregarParametro("Cabanas", dr("Cabanas").ToString)
            sp.AgregarParametro("Departamentos", dr("Departamentos").ToString)
            sp.AgregarParametro("SitiosCamping", dr("SitiosCamping").ToString)
            sp.AgregarParametro("TotalUnidadesAlojamiento", dr("TotalUnidadesAlojamiento").ToString)
            sp.AgregarParametro("PlazasHabitaciones", dr("PlazasHabitaciones").ToString)
            sp.AgregarParametro("PlazasCabanas", dr("PlazasCabanas").ToString)
            sp.AgregarParametro("PlazasDepartamentos", dr("PlazasDepartamentos").ToString)
            sp.AgregarParametro("PlazasSitiosCamping", dr("PlazasSitiosCamping").ToString)
            sp.AgregarParametro("TotalPlazas", dr("TotalPlazas").ToString)
            sp.AgregarParametro("PersonalPermanenteHombre", dr("PersonalPermanenteHombre").ToString)
            sp.AgregarParametro("PersonalPermanenteMujer", dr("PersonalPermanenteMujer").ToString)
            sp.AgregarParametro("PersonalEventualHombre", dr("PersonalEventualHombre").ToString)
            sp.AgregarParametro("PersonalEventualMujer", dr("PersonalEventualMujer").ToString)
            sp.AgregarParametro("TotalPersonalHombre", dr("TotalPersonalHombre").ToString)
            sp.AgregarParametro("TotalPersonalMujer", dr("TotalPersonalMujer").ToString)
            sp.AgregarParametro("TotalPersonalOcupado", dr("TotalPersonalOcupado").ToString)
            sp.AgregarParametro("LlegadasDeAricaParinacota", dr("LlegadasDeAricaParinacota").ToString)
            sp.AgregarParametro("PernoctacionesDeAricaParinacota", dr("PernoctacionesDeAricaParinacota").ToString)
            sp.AgregarParametro("LlegadasTarapaca", dr("LlegadasTarapaca").ToString)
            sp.AgregarParametro("PernoctacionesTarapaca", dr("PernoctacionesTarapaca").ToString)
            sp.AgregarParametro("LlegadasAntofagasta", dr("LlegadasAntofagasta").ToString)
            sp.AgregarParametro("PernoctacionesAntofagasta", dr("PernoctacionesAntofagasta").ToString)
            sp.AgregarParametro("LlegadasAtacama", dr("LlegadasAtacama").ToString)
            sp.AgregarParametro("PernoctacionesAtacama", dr("PernoctacionesAtacama").ToString)
            sp.AgregarParametro("LlegadasCoquimbo", dr("LlegadasCoquimbo").ToString)
            sp.AgregarParametro("PernoctacionesCoquimbo", dr("PernoctacionesCoquimbo").ToString)
            sp.AgregarParametro("LlegadasValparaiso", dr("LlegadasValparaiso").ToString)
            sp.AgregarParametro("PernoctacionesValparaiso", dr("PernoctacionesValparaiso").ToString)
            sp.AgregarParametro("LlegadasMetropolitana", dr("LlegadasMetropolitana").ToString)
            sp.AgregarParametro("PernoctacionesMetropolitana", dr("PernoctacionesMetropolitana").ToString)
            sp.AgregarParametro("LlegadasOHiggins", dr("LlegadasOHiggins").ToString)
            sp.AgregarParametro("PernoctacionesOHiggins", dr("PernoctacionesOHiggins").ToString)
            sp.AgregarParametro("LlegadasMaule", dr("LlegadasMaule").ToString)
            sp.AgregarParametro("PernoctacionesMaule", dr("PernoctacionesMaule").ToString)
            sp.AgregarParametro("LlegadasNuble", dr("LlegadasNuble").ToString)
            sp.AgregarParametro("PernoctacionesNuble", dr("PernoctacionesNuble").ToString)
            sp.AgregarParametro("LlegadasBiobio", dr("LlegadasBiobio").ToString)
            sp.AgregarParametro("PernoctacionesBiobio", dr("PernoctacionesBiobio").ToString)
            sp.AgregarParametro("LlegadasAraucania", dr("LlegadasAraucania").ToString)
            sp.AgregarParametro("PernoctacionesAraucania", dr("PernoctacionesAraucania").ToString)
            sp.AgregarParametro("LlegadasLosRios", dr("LlegadasLosRios").ToString)
            sp.AgregarParametro("PernoctacionesLosRios", dr("PernoctacionesLosRios").ToString)
            sp.AgregarParametro("LlegadasLosLagos", dr("LlegadasLosLagos").ToString)
            sp.AgregarParametro("PernoctacionesLosLagos", dr("PernoctacionesLosLagos").ToString)
            sp.AgregarParametro("LlegadasAysen", dr("LlegadasAysen").ToString)
            sp.AgregarParametro("PernoctacionesAysen", dr("PernoctacionesAysen").ToString)
            sp.AgregarParametro("LlegadasMagallanesLaAntartica", dr("LlegadasMagallanesLaAntartica").ToString)
            sp.AgregarParametro("PernoctacionesMagallanesLaAntartica", dr("PernoctacionesMagallanesLaAntartica").ToString)
            sp.AgregarParametro("TotalLlegadasChilenos", dr("TotalLlegadasChilenos").ToString)
            sp.AgregarParametro("TotalPernoctacionesChilenos", dr("TotalPernoctacionesChilenos").ToString)
            sp.AgregarParametro("LlegadasArgentina", dr("LlegadasArgentina").ToString)
            sp.AgregarParametro("PernoctacionesArgentina", dr("PernoctacionesArgentina").ToString)
            sp.AgregarParametro("LlegadasPeru", dr("LlegadasPeru").ToString)
            sp.AgregarParametro("PernoctacionesPeru", dr("PernoctacionesPeru").ToString)
            sp.AgregarParametro("LlegadasBolivia", dr("LlegadasBolivia").ToString)
            sp.AgregarParametro("PernoctacionesBolivia", dr("PernoctacionesBolivia").ToString)
            sp.AgregarParametro("LlegadasBrasil", dr("LlegadasBrasil").ToString)
            sp.AgregarParametro("PernoctacionesBrasil", dr("PernoctacionesBrasil").ToString)
            sp.AgregarParametro("LlegadasColombia", dr("LlegadasColombia").ToString)
            sp.AgregarParametro("PernoctacionesColombia", dr("PernoctacionesColombia").ToString)
            sp.AgregarParametro("LlegadasMexico", dr("LlegadasMexico").ToString)
            sp.AgregarParametro("PernoctacionesMexico", dr("PernoctacionesMexico").ToString)
            sp.AgregarParametro("LlegadasEstadosUnidos", dr("LlegadasEstadosUnidos").ToString)
            sp.AgregarParametro("PernoctacionesEstadosUnidos", dr("PernoctacionesEstadosUnidos").ToString)
            sp.AgregarParametro("LlegadasRestoAmerica", dr("LlegadasRestoAmerica").ToString)
            sp.AgregarParametro("PernoctacionesRestoAmerica", dr("PernoctacionesRestoAmerica").ToString)
            sp.AgregarParametro("LlegadasEspana", dr("LlegadasEspana").ToString)
            sp.AgregarParametro("PernoctacionesEspana", dr("PernoctacionesEspana").ToString)
            sp.AgregarParametro("LlegadasAlemania", dr("LlegadasAlemania").ToString)
            sp.AgregarParametro("PernoctacionesAlemania", dr("PernoctacionesAlemania").ToString)
            sp.AgregarParametro("LlegadasFrancia", dr("LlegadasFrancia").ToString)
            sp.AgregarParametro("PernoctacionesFrancia", dr("PernoctacionesFrancia").ToString)
            sp.AgregarParametro("LlegadasInglaterra", dr("LlegadasInglaterra").ToString)
            sp.AgregarParametro("PernoctacionesInglaterra", dr("PernoctacionesInglaterra").ToString)
            sp.AgregarParametro("LlegadasRestoEuropa", dr("LlegadasRestoEuropa").ToString)
            sp.AgregarParametro("PernoctacionesRestoEuropa", dr("PernoctacionesRestoEuropa").ToString)
            sp.AgregarParametro("LlegadasAustralia", dr("LlegadasAustralia").ToString)
            sp.AgregarParametro("PernoctacionesAustralia", dr("PernoctacionesAustralia").ToString)
            sp.AgregarParametro("LlegadasAsia", dr("LlegadasAsia").ToString)
            sp.AgregarParametro("PernoctacionesAsia", dr("PernoctacionesAsia").ToString)
            sp.AgregarParametro("LlegadasRestoMundo", dr("LlegadasRestoMundo").ToString)
            sp.AgregarParametro("PernoctacionesRestomundo", dr("PernoctacionesRestomundo").ToString)
            sp.AgregarParametro("TotalLlegadasExtranjeros", dr("TotalLlegadasExtranjeros").ToString)
            sp.AgregarParametro("TotalPernoctacionesExtranjeros", dr("TotalPernoctacionesExtranjeros").ToString)
            sp.AgregarParametro("TotalLlegadas", dr("TotalLlegadas").ToString)
            sp.AgregarParametro("TotalPernoctacion", dr("TotalPernoctacion").ToString)
            sp.AgregarParametro("UnidadAlojamientoOcupada", dr("UnidadAlojamientoOcupada").ToString)
            sp.AgregarParametro("PlazasAdicionalesInstaladas", dr("PlazasAdicionalesInstaladas").ToString)
            sp.AgregarParametro("IngresoNetoAlojamiento", dr("IngresoNetoAlojamiento").ToString)
            sp.AgregarParametro("IngresoNetoOtrosServicios", dr("IngresoNetoOtrosServicios").ToString)
            sp.AgregarParametro("TotalIngresoNetoNperacional", dr("TotalIngresoNetoNperacional").ToString)
            sp.AgregarParametro("Observaciones", dr("Observaciones").ToString)
            sp.AgregarParametro("ObservacionImputacion", dr("ObservacionImputacion").ToString)

            sp.AgregarParametro("USUARIO", usuario_actualizacion)
            sp.AgregarParametro("PERIODO", periodo)
            sp.AgregarParametro("ANO", ano)
            sp.AgregarParametro("PROCESO_CARGAIMPUTACION", procesoCargaImputacon)

            sp.EjecutarProcedimiento(sqlCmd)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    'Este método permite cargar las imputaciones directamente en la Base de cálculo (TRABAJA CON LAS 15 REGIONES)
    Public Sub Insertar(ByVal dr As Data.DataRow, ByVal sp As StoredProcedure_class, ByVal sqlCmd As Data.SqlClient.SqlCommand, ByVal usuario_actualizacion As String, ByVal periodo As Integer, ByVal ano As Integer)
        Try
            sp.AgregarParametro("Nui", dr("Nui").ToString)
            sp.AgregarParametro("DiasFuncionamiento", dr("DiasFuncionamiento").ToString)
            sp.AgregarParametro("Habitaciones", dr("Habitaciones").ToString)
            sp.AgregarParametro("Cabanas", dr("Cabanas").ToString)
            sp.AgregarParametro("Departamentos", dr("Departamentos").ToString)
            sp.AgregarParametro("SitiosCamping", dr("SitiosCamping").ToString)
            sp.AgregarParametro("TotalUnidadesAlojamiento", dr("TotalUnidadesAlojamiento").ToString)
            sp.AgregarParametro("PlazasHabitaciones", dr("PlazasHabitaciones").ToString)
            sp.AgregarParametro("PlazasCabanas", dr("PlazasCabanas").ToString)
            sp.AgregarParametro("PlazasDepartamentos", dr("PlazasDepartamentos").ToString)
            sp.AgregarParametro("PlazasSitiosCamping", dr("PlazasSitiosCamping").ToString)
            sp.AgregarParametro("TotalPlazas", dr("TotalPlazas").ToString)
            sp.AgregarParametro("PersonalPermanenteHombre", dr("PersonalPermanenteHombre").ToString)
            sp.AgregarParametro("PersonalPermanenteMujer", dr("PersonalPermanenteMujer").ToString)
            sp.AgregarParametro("PersonalEventualHombre", dr("PersonalEventualHombre").ToString)
            sp.AgregarParametro("PersonalEventualMujer", dr("PersonalEventualMujer").ToString)
            sp.AgregarParametro("TotalPersonalHombre", dr("TotalPersonalHombre").ToString)
            sp.AgregarParametro("TotalPersonalMujer", dr("TotalPersonalMujer").ToString)
            sp.AgregarParametro("TotalPersonalOcupado", dr("TotalPersonalOcupado").ToString)
            sp.AgregarParametro("LlegadasDeAricaParinacota", dr("LlegadasDeAricaParinacota").ToString)
            sp.AgregarParametro("PernoctacionesDeAricaParinacota", dr("PernoctacionesDeAricaParinacota").ToString)
            sp.AgregarParametro("LlegadasTarapaca", dr("LlegadasTarapaca").ToString)
            sp.AgregarParametro("PernoctacionesTarapaca", dr("PernoctacionesTarapaca").ToString)
            sp.AgregarParametro("LlegadasAntofagasta", dr("LlegadasAntofagasta").ToString)
            sp.AgregarParametro("PernoctacionesAntofagasta", dr("PernoctacionesAntofagasta").ToString)
            sp.AgregarParametro("LlegadasAtacama", dr("LlegadasAtacama").ToString)
            sp.AgregarParametro("PernoctacionesAtacama", dr("PernoctacionesAtacama").ToString)
            sp.AgregarParametro("LlegadasCoquimbo", dr("LlegadasCoquimbo").ToString)
            sp.AgregarParametro("PernoctacionesCoquimbo", dr("PernoctacionesCoquimbo").ToString)
            sp.AgregarParametro("LlegadasValparaiso", dr("LlegadasValparaiso").ToString)
            sp.AgregarParametro("PernoctacionesValparaiso", dr("PernoctacionesValparaiso").ToString)
            sp.AgregarParametro("LlegadasMetropolitana", dr("LlegadasMetropolitana").ToString)
            sp.AgregarParametro("PernoctacionesMetropolitana", dr("PernoctacionesMetropolitana").ToString)
            sp.AgregarParametro("LlegadasOHiggins", dr("LlegadasOHiggins").ToString)
            sp.AgregarParametro("PernoctacionesOHiggins", dr("PernoctacionesOHiggins").ToString)
            sp.AgregarParametro("LlegadasMaule", dr("LlegadasMaule").ToString)
            sp.AgregarParametro("PernoctacionesMaule", dr("PernoctacionesMaule").ToString)
            sp.AgregarParametro("LlegadasBiobio", dr("LlegadasBiobio").ToString)
            sp.AgregarParametro("PernoctacionesBiobio", dr("PernoctacionesBiobio").ToString)
            sp.AgregarParametro("LlegadasNuble", dr("LlegadasNuble").ToString)
            sp.AgregarParametro("PernoctacionesNuble", dr("PernoctacionesNuble").ToString)
            sp.AgregarParametro("LlegadasAraucania", dr("LlegadasAraucania").ToString)
            sp.AgregarParametro("PernoctacionesAraucania", dr("PernoctacionesAraucania").ToString)
            sp.AgregarParametro("LlegadasLosRios", dr("LlegadasLosRios").ToString)
            sp.AgregarParametro("PernoctacionesRios", dr("PernoctacionesRios").ToString)
            sp.AgregarParametro("LlegadasLosLagos", dr("LlegadasLosLagos").ToString)
            sp.AgregarParametro("PernoctacionesLosLagos", dr("PernoctacionesLosLagos").ToString)
            sp.AgregarParametro("LlegadasAysen", dr("LlegadasAysen").ToString)
            sp.AgregarParametro("PernoctacionesAysen", dr("PernoctacionesAysen").ToString)
            sp.AgregarParametro("LlegadasMagallanesLaAntartica", dr("LlegadasMagallanesLaAntartica").ToString)
            sp.AgregarParametro("PernoctacionesMagallanesLaAntartica", dr("PernoctacionesMagallanesLaAntartica").ToString)
            sp.AgregarParametro("TotalLlegadasChilenos", dr("TotalLlegadasChilenos").ToString)
            sp.AgregarParametro("TotalPernoctacionesChilenos", dr("TotalPernoctacionesChilenos").ToString)
            sp.AgregarParametro("LlegadasArgentina", dr("LlegadasArgentina").ToString)
            sp.AgregarParametro("PernoctacionesArgentina", dr("PernoctacionesArgentina").ToString)
            sp.AgregarParametro("LlegadasPeru", dr("LlegadasPeru").ToString)
            sp.AgregarParametro("PernoctacionesPeru", dr("PernoctacionesPeru").ToString)
            sp.AgregarParametro("LlegadasBolivia", dr("LlegadasBolivia").ToString)
            sp.AgregarParametro("PernoctacionesBolivia", dr("PernoctacionesBolivia").ToString)
            sp.AgregarParametro("LlegadasBrasil", dr("LlegadasBrasil").ToString)
            sp.AgregarParametro("PernoctacionesBrasil", dr("PernoctacionesBrasil").ToString)
            sp.AgregarParametro("LlegadasColombia", dr("LlegadasColombia").ToString)
            sp.AgregarParametro("PernoctacionesColombia", dr("PernoctacionesColombia").ToString)
            sp.AgregarParametro("LlegadasMexico", dr("LlegadasMexico").ToString)
            sp.AgregarParametro("PernoctacionesMexico", dr("PernoctacionesMexico").ToString)
            sp.AgregarParametro("LlegadasEstadosUnidos", dr("LlegadasEstadosUnidos").ToString)
            sp.AgregarParametro("PernoctacionesEstadosUnidos", dr("PernoctacionesEstadosUnidos").ToString)
            sp.AgregarParametro("LlegadasRestoAmerica", dr("LlegadasRestoAmerica").ToString)
            sp.AgregarParametro("PernoctacionesRestoAmerica", dr("PernoctacionesRestoAmerica").ToString)
            sp.AgregarParametro("LlegadasEspana", dr("LlegadasEspana").ToString)
            sp.AgregarParametro("PernoctacionesEspana", dr("PernoctacionesEspana").ToString)
            sp.AgregarParametro("LlegadasAlemania", dr("LlegadasAlemania").ToString)
            sp.AgregarParametro("PernoctacionesAlemania", dr("PernoctacionesAlemania").ToString)
            sp.AgregarParametro("LlegadasFrancia", dr("LlegadasFrancia").ToString)
            sp.AgregarParametro("PernoctacionesFrancia", dr("PernoctacionesFrancia").ToString)
            sp.AgregarParametro("LlegadasInglaterra", dr("LlegadasInglaterra").ToString)
            sp.AgregarParametro("PernoctacionesInglaterra", dr("PernoctacionesInglaterra").ToString)
            sp.AgregarParametro("LlegadasRestoEuropa", dr("LlegadasRestoEuropa").ToString)
            sp.AgregarParametro("PernoctacionesRestoEuropa", dr("PernoctacionesRestoEuropa").ToString)
            sp.AgregarParametro("LlegadasAustralia", dr("LlegadasAustralia").ToString)
            sp.AgregarParametro("PernoctacionesAustralia", dr("PernoctacionesAustralia").ToString)
            sp.AgregarParametro("LlegadasAsia", dr("LlegadasAsia").ToString)
            sp.AgregarParametro("PernoctacionesAsia", dr("PernoctacionesAsia").ToString)
            sp.AgregarParametro("LlegadasRestoMundo", dr("LlegadasRestoMundo").ToString)
            sp.AgregarParametro("PernoctacionesRestomundo", dr("PernoctacionesRestomundo").ToString)
            sp.AgregarParametro("TotalLlegadasExtranjeros", dr("TotalLlegadasExtranjeros").ToString)
            sp.AgregarParametro("TotalPernoctacionesExtranjeros", dr("TotalPernoctacionesExtranjeros").ToString)
            sp.AgregarParametro("TotalLlegadas", dr("TotalLlegadas").ToString)
            sp.AgregarParametro("TotalPernoctacion", dr("TotalPernoctacion").ToString)
            sp.AgregarParametro("UnidadAlojamientoOcupada", dr("UnidadAlojamientoOcupada").ToString)
            sp.AgregarParametro("PlazasAdicionalesInstaladas", dr("PlazasAdicionalesInstaladas").ToString)
            sp.AgregarParametro("IngresoNetoAlojamiento", dr("IngresoNetoAlojamiento").ToString)
            sp.AgregarParametro("IngresoNetoOtrosServicios", dr("IngresoNetoOtrosServicios").ToString)
            sp.AgregarParametro("TotalIngresoNetoNperacional", dr("TotalIngresoNetoNperacional").ToString)
            sp.AgregarParametro("Observaciones", dr("Observaciones").ToString)
            sp.AgregarParametro("ObservacionImputacion", dr("ObservacionImputacion").ToString)

            sp.AgregarParametro("USUARIO", usuario_actualizacion)
            sp.AgregarParametro("PERIODO", periodo)
            sp.AgregarParametro("ANO", ano)

            sp.EjecutarProcedimiento(sqlCmd)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    'Este método permite cargar las imputaciones directamente en la Base de cálculo (CONSIDERA LA ANTIGUA EMAT (2014-2015)
    Public Sub Insertar_aemat(ByVal dr As Data.DataRow, ByVal sp As StoredProcedure_class, ByVal sqlCmd As Data.SqlClient.SqlCommand, ByVal usuario_actualizacion As String, ByVal periodo As Integer, ByVal ano As Integer)
        Try
            sp.AgregarParametro("Rol", dr("Rol").ToString)
            sp.AgregarParametro("DiasFuncionamiento", dr("DiasFuncionamiento").ToString)
            sp.AgregarParametro("Habitaciones", dr("Habitaciones").ToString)
            sp.AgregarParametro("Cabanas", dr("Cabanas").ToString)
            sp.AgregarParametro("Departamentos", dr("Departamentos").ToString)
            sp.AgregarParametro("SitiosCamping", dr("SitiosCamping").ToString)
            sp.AgregarParametro("TotalUnidadesAlojamiento", dr("TotalUnidadesAlojamiento").ToString)
            sp.AgregarParametro("PlazasHabitaciones", dr("PlazasHabitaciones").ToString)
            sp.AgregarParametro("PlazasCabanas", dr("PlazasCabanas").ToString)
            sp.AgregarParametro("PlazasDepartamentos", dr("PlazasDepartamentos").ToString)
            sp.AgregarParametro("PlazasSitiosCamping", dr("PlazasSitiosCamping").ToString)
            sp.AgregarParametro("TotalPlazas", dr("TotalPlazas").ToString)
            sp.AgregarParametro("PersonalPermanenteHombre", dr("PersonalPermanenteHombre").ToString)
            sp.AgregarParametro("PersonalPermanenteMujer", dr("PersonalPermanenteMujer").ToString)
            sp.AgregarParametro("PersonalEventualHombre", dr("PersonalEventualHombre").ToString)
            sp.AgregarParametro("PersonalEventualMujer", dr("PersonalEventualMujer").ToString)
            sp.AgregarParametro("TotalPersonalHombre", dr("TotalPersonalHombre").ToString)
            sp.AgregarParametro("TotalPersonalMujer", dr("TotalPersonalMujer").ToString)
            sp.AgregarParametro("TotalPersonalOcupado", dr("TotalPersonalOcupado").ToString)
            sp.AgregarParametro("LlegadasDeAricaParinacota", dr("LlegadasDeAricaParinacota").ToString)
            sp.AgregarParametro("PernoctacionesDeAricaParinacota", dr("PernoctacionesDeAricaParinacota").ToString)
            sp.AgregarParametro("LlegadasTarapaca", dr("LlegadasTarapaca").ToString)
            sp.AgregarParametro("PernoctacionesTarapaca", dr("PernoctacionesTarapaca").ToString)
            sp.AgregarParametro("LlegadasAntofagasta", dr("LlegadasAntofagasta").ToString)
            sp.AgregarParametro("PernoctacionesAntofagasta", dr("PernoctacionesAntofagasta").ToString)
            sp.AgregarParametro("LlegadasAtacama", dr("LlegadasAtacama").ToString)
            sp.AgregarParametro("PernoctacionesAtacama", dr("PernoctacionesAtacama").ToString)
            sp.AgregarParametro("LlegadasCoquimbo", dr("LlegadasCoquimbo").ToString)
            sp.AgregarParametro("PernoctacionesCoquimbo", dr("PernoctacionesCoquimbo").ToString)
            sp.AgregarParametro("LlegadasValparaiso", dr("LlegadasValparaiso").ToString)
            sp.AgregarParametro("PernoctacionesValparaiso", dr("PernoctacionesValparaiso").ToString)
            sp.AgregarParametro("LlegadasMetropolitana", dr("LlegadasMetropolitana").ToString)
            sp.AgregarParametro("PernoctacionesMetropolitana", dr("PernoctacionesMetropolitana").ToString)
            sp.AgregarParametro("LlegadasOHiggins", dr("LlegadasOHiggins").ToString)
            sp.AgregarParametro("PernoctacionesOHiggins", dr("PernoctacionesOHiggins").ToString)
            sp.AgregarParametro("LlegadasMaule", dr("LlegadasMaule").ToString)
            sp.AgregarParametro("PernoctacionesMaule", dr("PernoctacionesMaule").ToString)
            sp.AgregarParametro("LlegadasBiobio", dr("LlegadasBiobio").ToString)
            sp.AgregarParametro("PernoctacionesBiobio", dr("PernoctacionesBiobio").ToString)
            sp.AgregarParametro("LlegadasAraucania", dr("LlegadasAraucania").ToString)
            sp.AgregarParametro("PernoctacionesAraucania", dr("PernoctacionesAraucania").ToString)
            sp.AgregarParametro("LlegadasLosRios", dr("LlegadasLosRios").ToString)
            sp.AgregarParametro("PernoctacionesRios", dr("PernoctacionesRios").ToString)
            sp.AgregarParametro("LlegadasLosLagos", dr("LlegadasLosLagos").ToString)
            sp.AgregarParametro("PernoctacionesLosLagos", dr("PernoctacionesLosLagos").ToString)
            sp.AgregarParametro("LlegadasAysen", dr("LlegadasAysen").ToString)
            sp.AgregarParametro("PernoctacionesAysen", dr("PernoctacionesAysen").ToString)
            sp.AgregarParametro("LlegadasMagallanesLaAntartica", dr("LlegadasMagallanesLaAntartica").ToString)
            sp.AgregarParametro("PernoctacionesMagallanesLaAntartica", dr("PernoctacionesMagallanesLaAntartica").ToString)
            sp.AgregarParametro("TotalLlegadasChilenos", dr("TotalLlegadasChilenos").ToString)
            sp.AgregarParametro("TotalPernoctacionesChilenos", dr("TotalPernoctacionesChilenos").ToString)
            sp.AgregarParametro("LlegadasArgentina", dr("LlegadasArgentina").ToString)
            sp.AgregarParametro("PernoctacionesArgentina", dr("PernoctacionesArgentina").ToString)
            sp.AgregarParametro("LlegadasPeru", dr("LlegadasPeru").ToString)
            sp.AgregarParametro("PernoctacionesPeru", dr("PernoctacionesPeru").ToString)
            sp.AgregarParametro("LlegadasBolivia", dr("LlegadasBolivia").ToString)
            sp.AgregarParametro("PernoctacionesBolivia", dr("PernoctacionesBolivia").ToString)
            sp.AgregarParametro("LlegadasBrasil", dr("LlegadasBrasil").ToString)
            sp.AgregarParametro("PernoctacionesBrasil", dr("PernoctacionesBrasil").ToString)
            sp.AgregarParametro("LlegadasColombia", dr("LlegadasColombia").ToString)
            sp.AgregarParametro("PernoctacionesColombia", dr("PernoctacionesColombia").ToString)
            sp.AgregarParametro("LlegadasMexico", dr("LlegadasMexico").ToString)
            sp.AgregarParametro("PernoctacionesMexico", dr("PernoctacionesMexico").ToString)
            sp.AgregarParametro("LlegadasEstadosUnidos", dr("LlegadasEstadosUnidos").ToString)
            sp.AgregarParametro("PernoctacionesEstadosUnidos", dr("PernoctacionesEstadosUnidos").ToString)
            sp.AgregarParametro("LlegadasRestoAmerica", dr("LlegadasRestoAmerica").ToString)
            sp.AgregarParametro("PernoctacionesRestoAmerica", dr("PernoctacionesRestoAmerica").ToString)
            sp.AgregarParametro("LlegadasEspana", dr("LlegadasEspana").ToString)
            sp.AgregarParametro("PernoctacionesEspana", dr("PernoctacionesEspana").ToString)
            sp.AgregarParametro("LlegadasAlemania", dr("LlegadasAlemania").ToString)
            sp.AgregarParametro("PernoctacionesAlemania", dr("PernoctacionesAlemania").ToString)
            sp.AgregarParametro("LlegadasFrancia", dr("LlegadasFrancia").ToString)
            sp.AgregarParametro("PernoctacionesFrancia", dr("PernoctacionesFrancia").ToString)
            sp.AgregarParametro("LlegadasInglaterra", dr("LlegadasInglaterra").ToString)
            sp.AgregarParametro("PernoctacionesInglaterra", dr("PernoctacionesInglaterra").ToString)
            sp.AgregarParametro("LlegadasRestoEuropa", dr("LlegadasRestoEuropa").ToString)
            sp.AgregarParametro("PernoctacionesRestoEuropa", dr("PernoctacionesRestoEuropa").ToString)
            sp.AgregarParametro("LlegadasAustralia", dr("LlegadasAustralia").ToString)
            sp.AgregarParametro("PernoctacionesAustralia", dr("PernoctacionesAustralia").ToString)
            sp.AgregarParametro("LlegadasAsia", dr("LlegadasAsia").ToString)
            sp.AgregarParametro("PernoctacionesAsia", dr("PernoctacionesAsia").ToString)
            sp.AgregarParametro("LlegadasRestoMundo", dr("LlegadasRestoMundo").ToString)
            sp.AgregarParametro("PernoctacionesRestomundo", dr("PernoctacionesRestomundo").ToString)
            sp.AgregarParametro("TotalLlegadasExtranjeros", dr("TotalLlegadasExtranjeros").ToString)
            sp.AgregarParametro("TotalPernoctacionesExtranjeros", dr("TotalPernoctacionesExtranjeros").ToString)
            sp.AgregarParametro("TotalLlegadas", dr("TotalLlegadas").ToString)
            sp.AgregarParametro("TotalPernoctacion", dr("TotalPernoctacion").ToString)
            sp.AgregarParametro("UnidadAlojamientoOcupada", dr("UnidadAlojamientoOcupada").ToString)
            sp.AgregarParametro("PlazasAdicionalesInstaladas", dr("PlazasAdicionalesInstaladas").ToString)
            sp.AgregarParametro("IngresoNetoAlojamiento", dr("IngresoNetoAlojamiento").ToString)
            sp.AgregarParametro("IngresoNetoOtrosServicios", dr("IngresoNetoOtrosServicios").ToString)
            sp.AgregarParametro("TotalIngresoNetoNperacional", dr("TotalIngresoNetoNperacional").ToString)
            sp.AgregarParametro("Observacion", dr("Observacion").ToString)

            sp.AgregarParametro("USUARIO", usuario_actualizacion)
            sp.AgregarParametro("PERIODO", periodo)
            sp.AgregarParametro("ANO", ano)

            sp.EjecutarProcedimiento(sqlCmd)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    'Este método permite realizar el proceso de noches ocupadas.
    Public Sub Insertar_Rectificar_noches_ocupadas(ByVal dr As Data.DataRow, ByVal sp As StoredProcedure_class, ByVal sqlCmd As Data.SqlClient.SqlCommand, ByVal usuario_actualizacion As String, ByVal periodo As Integer, ByVal ano As Integer)
        Try
            sp.AgregarParametro("ROL", dr("Rol").ToString)
            sp.AgregarParametro("DVROL", dr("Dvrol").ToString)
            sp.AgregarParametro("NUI", dr("Nui").ToString)
            sp.AgregarParametro("DVNUI", dr("Dvnui").ToString)
            sp.AgregarParametro("PERIODO", periodo)
            sp.AgregarParametro("ANO", ano)
            sp.AgregarParametro("E102_ACT", dr("E102_act").ToString)

            sp.EjecutarProcedimiento(sqlCmd)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

    End Sub

    'Este método permite realizar el proceso de rectificación de ingresos.
    Public Sub Insertar_Rectificar_Ingresos(ByVal dr As Data.DataRow, ByVal sp As StoredProcedure_class, ByVal sqlCmd As Data.SqlClient.SqlCommand, ByVal usuario_actualizacion As String, ByVal periodo As Integer, ByVal ano As Integer)
        Try
            sp.AgregarParametro("ROL", dr("Rol").ToString)
            sp.AgregarParametro("DVROL", dr("Dvrol").ToString)
            sp.AgregarParametro("NUI", dr("Nui").ToString)
            sp.AgregarParametro("DVNUI", dr("Dvnui").ToString)
            sp.AgregarParametro("PERIODO", periodo)
            sp.AgregarParametro("ANO", ano)
            sp.AgregarParametro("F104_ACT", dr("F104_Act").ToString)
            sp.AgregarParametro("F105_ACT", dr("F105_Act").ToString)
            sp.AgregarParametro("F106_ACT", dr("F106_Act").ToString)

            sp.EjecutarProcedimiento(sqlCmd)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

    End Sub

    'Este método permite trasladar los datos de un NUI determinado desde la base de terminadas a la base de calculo.Es solo para realizar el proceso de incoporar las rectificadas y recepcionadas en T-1.
    'Pero se debe considerar que primero debe eliminar el Nui de la base de calculo, ya que se encontraba desde el periodo anterior producto de que se incoporaro o imputo. 
    Public Sub Insertar_Rectificadas_Recepcionadas(ByVal dr As Data.DataRow, ByVal sp As StoredProcedure_class, ByVal sqlCmd As Data.SqlClient.SqlCommand, ByVal usuario_actualizacion As String, ByVal periodo As Integer, ByVal ano As Integer)
        Try
            sp.AgregarParametro("NUI", dr("Nui").ToString)
            sp.AgregarParametro("DVNUI", dr("Dvnui").ToString)
            sp.AgregarParametro("PERIODO", periodo)
            sp.AgregarParametro("ANO", ano)
            sp.AgregarParametro("ROL", dr("Rol").ToString)
            sp.AgregarParametro("DVROL", dr("Ano").ToString)


            sp.EjecutarProcedimiento(sqlCmd)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

    End Sub

    'Este método permite realizar el proceso de noches ocupadas.
    Public Sub Realizar_cambio_estado_masivos(ByVal dr As Data.DataRow, ByVal sp As StoredProcedure_class, ByVal sqlCmd As Data.SqlClient.SqlCommand, ByVal usuario_actualizacion As String)

        Dim estadoFinal As Integer

        If dr("Estado_Final").ToString = "Analisis" Then
            estadoFinal = 4
        ElseIf dr("Estado_Final").ToString = "Recepcionada" Then
            estadoFinal = 3
        ElseIf dr("Estado_Final").ToString = "Digitada" Then
            estadoFinal = 2
        ElseIf dr("Estado_Final").ToString = "Enviada" Then
            estadoFinal = 1
        ElseIf dr("Estado_Final").ToString = "Terminada" Then
            estadoFinal = 6
        End If

        Try
            sp.AgregarParametro("ROL", dr("Rol").ToString)
            sp.AgregarParametro("PERIODO", dr("Periodo").ToString)
            sp.AgregarParametro("ANO", dr("Ano").ToString)
            sp.AgregarParametro("ESTADO_FINAL_ENCUESTA", estadoFinal)
            sp.AgregarParametro("USUARIO_ACTUALIZACION", usuario_actualizacion)

            sp.EjecutarProcedimiento(sqlCmd)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

    End Sub

    'Este método permite realizar el proceso de noches ocupadas.
    Public Sub Insertar_Rectificar_ua_plazas(ByVal dr As Data.DataRow, ByVal sp As StoredProcedure_class, ByVal sqlCmd As Data.SqlClient.SqlCommand, ByVal usuario_actualizacion As String, ByVal periodo As Integer, ByVal ano As Integer)
        Try
            sp.AgregarParametro("ROL", dr("Rol").ToString)
            sp.AgregarParametro("DVROL", dr("Dvrol").ToString)
            sp.AgregarParametro("PERIODO", periodo)
            sp.AgregarParametro("ANO", ano)
            sp.AgregarParametro("B020", dr("B020").ToString)
            sp.AgregarParametro("B021", dr("B021").ToString)
            sp.AgregarParametro("B022", dr("B022").ToString)
            sp.AgregarParametro("B023", dr("B023").ToString)
            sp.AgregarParametro("B024", dr("B024").ToString)
            sp.AgregarParametro("B025", dr("B025").ToString)
            sp.AgregarParametro("B026", dr("B026").ToString)
            sp.AgregarParametro("B027", dr("B027").ToString)
            sp.AgregarParametro("B028", dr("B028").ToString)
            sp.AgregarParametro("B029", dr("B029").ToString)

            sp.EjecutarProcedimiento(sqlCmd)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

    End Sub

    'Este método permite realizar el proceso de ingresos
    Public Sub Insertar_Rectificar_personal(ByVal dr As Data.DataRow, ByVal sp As StoredProcedure_class, ByVal sqlCmd As Data.SqlClient.SqlCommand, ByVal usuario_actualizacion As String, ByVal periodo As Integer, ByVal ano As Integer, ByVal opcionSeleccionada As Integer)
        Try
            sp.AgregarParametro("ROL", dr("Rol").ToString)
            sp.AgregarParametro("DVROL", dr("Dvrol").ToString)
            sp.AgregarParametro("PERIODO", periodo)
            sp.AgregarParametro("ANO", ano)
            sp.AgregarParametro("C030", dr("C030").ToString)
            sp.AgregarParametro("C031", dr("C031").ToString)
            sp.AgregarParametro("C032", dr("C032").ToString)
            sp.AgregarParametro("C033", dr("C033").ToString)
            sp.AgregarParametro("C034", dr("C034").ToString)
            sp.AgregarParametro("C035", dr("C035").ToString)
            sp.AgregarParametro("OPCION", opcionSeleccionada)

            sp.EjecutarProcedimiento(sqlCmd)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

    End Sub

    'Este método permite realizar el proceso de noches ocupadas.
    Public Sub Insertar_imputacion_esperada(ByVal dr As Data.DataRow, ByVal sp As StoredProcedure_class, ByVal sqlCmd As Data.SqlClient.SqlCommand, ByVal usuario_actualizacion As String, ByVal periodo As Integer, ByVal ano As Integer)
        Try
            sp.AgregarParametro("NUI", dr("NUI").ToString)
            sp.AgregarParametro("ROL", dr("ROL").ToString)
            sp.AgregarParametro("DVROL", dr("DVROL").ToString)
            sp.AgregarParametro("PERIODO", dr("PERIODO").ToString)
            sp.AgregarParametro("ANO", dr("ANO").ToString)

            sp.EjecutarProcedimiento(sqlCmd)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

    End Sub

    'Este método permite realizar la eliminación de Nui.
    Public Sub eliminar_nui_bdc(ByVal dr As Data.DataRow, ByVal sp As StoredProcedure_class, ByVal sqlCmd As Data.SqlClient.SqlCommand, ByVal usuario_actualizacion As String, ByVal periodo As Integer, ByVal ano As Integer)
        Try
            sp.AgregarParametro("NUI", dr("NUI").ToString)
            sp.AgregarParametro("PERIODO", dr("PERIODO").ToString)
            sp.AgregarParametro("ANO", dr("ANO").ToString)

            sp.EjecutarProcedimiento(sqlCmd)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

    End Sub


#End Region
End Class
