using Algoritmos.CS.Garantias.Negocio.UnitTests.Valoraciones.ConPolimorfismo.ValoracionPorISIN_Tests;
using ConParameterObject;
using Algoritmos.CS.Garantias.Negocio.ValoracionesPorISIN.ConPolimorfismo;
using System;
using System.Collections.Generic;

namespace ConParameterObject.Tests
{
    public class EscenariosDeListasEnDolares : Escenarios
    {
        DatosDeLaValoracionPorEntidad losDatos;

        protected List<ValoracionPorISIN> UnaListaSinValoraciones()
        {
            return new List<ValoracionPorISIN>();
        }

        protected ValoracionDeLosISINDeUnaEntidad UnaValoracionSinNingunISIN()
        {
            losDatos = new DatosDeLaValoracionPorEntidad();

            losDatos.listaDeISINEnColones = new List<ISIN>();
            losDatos.listaDeISINEnDolares = new List<ISIN>();
            losDatos.listaDeISINEnUDESAnotadosEnCuenta = new List<ISIN>();
            losDatos.listaDeISINEnUDESNoAnotadosEnCuenta = new List<ISIN>();
            losDatos.fechaActual = new DateTime(2016, 1, 1);
            losDatos.tipoDeCambioDeUDESDeAyer = 745;
            losDatos.tipoDeCambioDeUDESDeHoy = 750;

            return new ValoracionPorEntidad().GenereLaValoracion(losDatos);
        }

        protected List<ValoracionPorISIN> UnaValoracionEnDolares()
        {
            ValoracionPorISIN laValoracion = InicialiceUnaValoracionEnDolaresYNoCumpleLosDiasMinimos();
            List<ValoracionPorISIN> laLista = new List<ValoracionPorISIN>();
            laLista.Add(laValoracion);

            return laLista;
        }

        protected ValoracionDeLosISINDeUnaEntidad UnaValoracionConUnISINEnDolares()
        {
            losDatos = new DatosDeLaValoracionPorEntidad();
            losDatos.listaDeISINEnColones = new List<ISIN>();
            losDatos.listaDeISINEnDolares = new List<ISIN>();

            ISIN unISINEnDolares = new ISIN();
            unISINEnDolares.NumeroISIN = "HDA000000000001";
            unISINEnDolares.fechaDeVencimientoDelValorOficial = new DateTime(2016, 1, 7);
            unISINEnDolares.diasMinimosAlVencimientoDelEmisor = 7;
            unISINEnDolares.porcentajeCobertura = 0.8M;
            unISINEnDolares.precioLimpioDelVectorDePrecios = 80;
            unISINEnDolares.montoNominalDelSaldo = 1000;
            losDatos.listaDeISINEnDolares.Add(unISINEnDolares);

            losDatos.listaDeISINEnUDESAnotadosEnCuenta = new List<ISIN>();
            losDatos.listaDeISINEnUDESNoAnotadosEnCuenta = new List<ISIN>();
            losDatos.fechaActual = new DateTime(2016, 1, 1);
            losDatos.tipoDeCambioDeUDESDeAyer = 745;
            losDatos.tipoDeCambioDeUDESDeHoy = 750;

            return new ValoracionPorEntidad().GenereLaValoracion(losDatos);
        }

        protected List<ValoracionPorISIN> DosValoracionesEnDolares()
        {
            ValoracionPorISIN laValoracion = UnaValoracionEnDolaresYCumpleLosDiasMinimos();
            List<ValoracionPorISIN> laLista = new List<ValoracionPorISIN>();
            laLista.Add(laValoracion);
            laLista.Add(laValoracion);

            return laLista;
        }

        protected ValoracionDeLosISINDeUnaEntidad UnaValoracionConDosISINEnDolares()
        {
            List<ISIN> listaDeISINEnColones = new List<ISIN>();
            List<ISIN> listaDeISINEnDolares = new List<ISIN>();

            ISIN unISINEnDolares = new ISIN();
            unISINEnDolares.NumeroISIN = "HDA000000000001";
            unISINEnDolares.fechaDeVencimientoDelValorOficial = new DateTime(2016, 6, 6);
            unISINEnDolares.diasMinimosAlVencimientoDelEmisor = 7;
            unISINEnDolares.porcentajeCobertura = 0.8M;
            unISINEnDolares.precioLimpioDelVectorDePrecios = 80;
            unISINEnDolares.montoNominalDelSaldo = 1000;
            listaDeISINEnDolares.Add(unISINEnDolares);

            ISIN otroISINEnDolares = new ISIN();
            otroISINEnDolares.NumeroISIN = "HDA000000000001";
            otroISINEnDolares.fechaDeVencimientoDelValorOficial = new DateTime(2016, 6, 6);
            otroISINEnDolares.diasMinimosAlVencimientoDelEmisor = 7;
            otroISINEnDolares.porcentajeCobertura = 0.8M;
            otroISINEnDolares.precioLimpioDelVectorDePrecios = 80;
            otroISINEnDolares.montoNominalDelSaldo = 1000;
            listaDeISINEnDolares.Add(otroISINEnDolares);

            losDatos.listaDeISINEnUDESAnotadosEnCuenta = new List<ISIN>();
            losDatos.listaDeISINEnUDESNoAnotadosEnCuenta = new List<ISIN>();
            losDatos.fechaActual = new DateTime(2016, 1, 1);
            losDatos.tipoDeCambioDeUDESDeAyer = 745;
            losDatos.tipoDeCambioDeUDESDeHoy = 750;

            return new ValoracionPorEntidad().GenereLaValoracion(losDatos);
        }

    }
}
