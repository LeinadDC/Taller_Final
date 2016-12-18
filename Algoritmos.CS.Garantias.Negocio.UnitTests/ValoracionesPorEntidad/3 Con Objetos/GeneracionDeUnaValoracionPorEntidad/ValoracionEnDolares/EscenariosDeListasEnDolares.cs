using Algoritmos.CS.Garantias.Negocio.UnitTests.Valoraciones.ConPolimorfismo.ValoracionPorISIN_Tests;
using ConObjetos;
using Algoritmos.CS.Garantias.Negocio.ValoracionesPorISIN.ConPolimorfismo;
using System;
using System.Collections.Generic;

namespace ConObjetos.Tests
{
    public class EscenariosDeListasEnDolares : Escenarios
    {
        protected List<ValoracionPorISIN> UnaListaSinValoraciones()
        {
            return new List<ValoracionPorISIN>();
        }

        protected ValoracionDeLosISINDeUnaEntidad UnaValoracionSinNingunISIN()
        {
            List<ISIN> listaDeISINEnColones = new List<ISIN>();
            List<ISIN> listaDeISINEnDolares = new List<ISIN>();
            List<ISIN> listaDeISINEnUDESAnotadosEnCuenta = new List<ISIN>();
            List<ISIN> listaDeISINEnUDESNoAnotadosEnCuenta = new List<ISIN>();
            DateTime fechaActual = new DateTime(2016, 1, 1);
            decimal tipoDeCambioDeUDESDeAyer = 745;
            decimal tipoDeCambioDeUDESDeHoy = 750;

            return new ValoracionPorEntidad(
                listaDeISINEnColones,
                listaDeISINEnDolares,
                listaDeISINEnUDESAnotadosEnCuenta,
                listaDeISINEnUDESNoAnotadosEnCuenta,
                fechaActual,
                tipoDeCambioDeUDESDeAyer,
                tipoDeCambioDeUDESDeHoy).GenereLaValoracion();
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
            List<ISIN> listaDeISINEnColones = new List<ISIN>();
            List<ISIN> listaDeISINEnDolares = new List<ISIN>();

            ISIN unISINEnDolares = new ISIN();
            unISINEnDolares.NumeroISIN = "HDA000000000001";
            unISINEnDolares.fechaDeVencimientoDelValorOficial = new DateTime(2016, 1, 7);
            unISINEnDolares.diasMinimosAlVencimientoDelEmisor = 7;
            unISINEnDolares.porcentajeCobertura = 0.8M;
            unISINEnDolares.precioLimpioDelVectorDePrecios = 80;
            unISINEnDolares.montoNominalDelSaldo = 1000;
            listaDeISINEnDolares.Add(unISINEnDolares);

            List<ISIN> listaDeISINEnUDESAnotadosEnCuenta = new List<ISIN>();
            List<ISIN> listaDeISINEnUDESNoAnotadosEnCuenta = new List<ISIN>();
            DateTime fechaActual = new DateTime(2016, 1, 1);
            decimal tipoDeCambioDeUDESDeAyer = 745;
            decimal tipoDeCambioDeUDESDeHoy = 750;

            return new ValoracionPorEntidad(
                    listaDeISINEnColones,
                    listaDeISINEnDolares,
                    listaDeISINEnUDESAnotadosEnCuenta,
                    listaDeISINEnUDESNoAnotadosEnCuenta,
                    fechaActual,
                    tipoDeCambioDeUDESDeAyer,
                    tipoDeCambioDeUDESDeHoy).GenereLaValoracion();
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

            List<ISIN> listaDeISINEnUDESAnotadosEnCuenta = new List<ISIN>();
            List<ISIN> listaDeISINEnUDESNoAnotadosEnCuenta = new List<ISIN>();
            DateTime fechaActual = new DateTime(2016, 1, 1);
            decimal tipoDeCambioDeUDESDeAyer = 745;
            decimal tipoDeCambioDeUDESDeHoy = 750;

            return new ValoracionPorEntidad(
                    listaDeISINEnColones,
                    listaDeISINEnDolares,
                    listaDeISINEnUDESAnotadosEnCuenta,
                    listaDeISINEnUDESNoAnotadosEnCuenta,
                    fechaActual,
                    tipoDeCambioDeUDESDeAyer,
                    tipoDeCambioDeUDESDeHoy).GenereLaValoracion();
        }

    }
}
