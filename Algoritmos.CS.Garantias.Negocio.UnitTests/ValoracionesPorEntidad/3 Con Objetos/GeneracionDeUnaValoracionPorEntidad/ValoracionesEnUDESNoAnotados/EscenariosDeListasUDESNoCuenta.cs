using Algoritmos.CS.Garantias.Negocio.UnitTests.Valoraciones.ConPolimorfismo.ValoracionPorISIN_Tests;
using ConObjetos;
using Algoritmos.CS.Garantias.Negocio.ValoracionesPorISIN.ConPolimorfismo;
using System;
using System.Collections.Generic;

namespace ConObjetos.Tests
{
    public class EscenariosListasUDESNoCuenta : Escenarios
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

            return GeneracionDeUnaValoracionPorEntidad.GenereLaValoracion(
                listaDeISINEnColones,
                listaDeISINEnDolares,
                listaDeISINEnUDESAnotadosEnCuenta,
                listaDeISINEnUDESNoAnotadosEnCuenta,
                fechaActual,
                tipoDeCambioDeUDESDeAyer,
                tipoDeCambioDeUDESDeHoy);
        }

        protected List<ValoracionPorISIN> UnaValoracionEnUDESNoAnotadosEnCuenta()
        {
            ValoracionPorISIN laValoracion = UnaValoracionEnUDESYElSaldoNoEstaAnotadoEnCuenta();
            List<ValoracionPorISIN> laLista = new List<ValoracionPorISIN>();
            laLista.Add(laValoracion);

            return laLista;
        }

        protected ValoracionDeLosISINDeUnaEntidad UnaValoracionConUnISINEnUDESNoAnotadosEnCuenta()
        {
            List<ISIN> listaDeISINEnColones = new List<ISIN>();
            List<ISIN> listaDeISINEnDolares = new List<ISIN>();
            List<ISIN> listaDeISINEnUDESAnotadosEnCuenta = new List<ISIN>();
            List<ISIN> listaDeISINEnUDESNoAnotadosEnCuenta = new List<ISIN>();

            ISIN unISINEnUDESNoAnotadosEnCuenta = new ISIN();
            unISINEnUDESNoAnotadosEnCuenta.NumeroISIN = "HDA000000000001";
            unISINEnUDESNoAnotadosEnCuenta.fechaDeVencimientoDelValorOficial = new DateTime(2016, 6, 6);
            unISINEnUDESNoAnotadosEnCuenta.diasMinimosAlVencimientoDelEmisor = 7;
            unISINEnUDESNoAnotadosEnCuenta.porcentajeCobertura = 0.8M;
            unISINEnUDESNoAnotadosEnCuenta.precioLimpioDelVectorDePrecios = 80;
            unISINEnUDESNoAnotadosEnCuenta.montoNominalDelSaldo = 1000;
            listaDeISINEnUDESNoAnotadosEnCuenta.Add(unISINEnUDESNoAnotadosEnCuenta);

            DateTime fechaActual = new DateTime(2016, 1, 1);
            decimal tipoDeCambioDeUDESDeAyer = 745;
            decimal tipoDeCambioDeUDESDeHoy = 750;

            return GeneracionDeUnaValoracionPorEntidad.GenereLaValoracion(
                listaDeISINEnColones,
                listaDeISINEnDolares,
                listaDeISINEnUDESAnotadosEnCuenta,
                listaDeISINEnUDESNoAnotadosEnCuenta,
                fechaActual,
                tipoDeCambioDeUDESDeAyer,
                tipoDeCambioDeUDESDeHoy);
        }

        protected List<ValoracionPorISIN> DosValoracionesEnUDESNoAnotadosEnCuenta()
        {
            ValoracionPorISIN laValoracion = UnaValoracionEnUDESYElSaldoNoEstaAnotadoEnCuenta();
            List<ValoracionPorISIN> laLista = new List<ValoracionPorISIN>();
            laLista.Add(laValoracion);
            laLista.Add(laValoracion);

            return laLista;
        }

        protected ValoracionDeLosISINDeUnaEntidad UnaValoracionConDosISINEnUDESNoAnotadosEnCuenta ()
        {
            List<ISIN> listaDeISINEnColones = new List<ISIN>();
            List<ISIN> listaDeISINEnDolares = new List<ISIN>();
            List<ISIN> listaDeISINEnUDESAnotadosEnCuenta = new List<ISIN>();
            List<ISIN> listaDeISINEnUDESNoAnotadosEnCuenta = new List<ISIN>();

            ISIN unISINEnUDESNoAnotadosEnCuenta = new ISIN();
            unISINEnUDESNoAnotadosEnCuenta.NumeroISIN = "HDA000000000001";
            unISINEnUDESNoAnotadosEnCuenta.fechaDeVencimientoDelValorOficial = new DateTime(2016, 6, 6);
            unISINEnUDESNoAnotadosEnCuenta.diasMinimosAlVencimientoDelEmisor = 7;
            unISINEnUDESNoAnotadosEnCuenta.porcentajeCobertura = 0.8M;
            unISINEnUDESNoAnotadosEnCuenta.precioLimpioDelVectorDePrecios = 80;
            unISINEnUDESNoAnotadosEnCuenta.montoNominalDelSaldo = 1000;
            listaDeISINEnUDESNoAnotadosEnCuenta.Add(unISINEnUDESNoAnotadosEnCuenta);

            ISIN otroISINEnUDESNoAnotadosEnCuenta = new ISIN();
            otroISINEnUDESNoAnotadosEnCuenta.NumeroISIN = "HDA000000000001";
            otroISINEnUDESNoAnotadosEnCuenta.fechaDeVencimientoDelValorOficial = new DateTime(2016, 6, 6);
            otroISINEnUDESNoAnotadosEnCuenta.diasMinimosAlVencimientoDelEmisor = 7;
            otroISINEnUDESNoAnotadosEnCuenta.porcentajeCobertura = 0.8M;
            otroISINEnUDESNoAnotadosEnCuenta.precioLimpioDelVectorDePrecios = 80;
            otroISINEnUDESNoAnotadosEnCuenta.montoNominalDelSaldo = 1000;
            listaDeISINEnUDESNoAnotadosEnCuenta.Add(otroISINEnUDESNoAnotadosEnCuenta);

            DateTime fechaActual = new DateTime(2016, 1, 1);
            decimal tipoDeCambioDeUDESDeAyer = 745;
            decimal tipoDeCambioDeUDESDeHoy = 750;

            return GeneracionDeUnaValoracionPorEntidad.GenereLaValoracion(
                listaDeISINEnColones,
                listaDeISINEnDolares,
                listaDeISINEnUDESAnotadosEnCuenta,
                listaDeISINEnUDESNoAnotadosEnCuenta,
                fechaActual,
                tipoDeCambioDeUDESDeAyer,
                tipoDeCambioDeUDESDeHoy);
        }

    }
}
