using Algoritmos.CS.Garantias.Negocio.UnitTests.Valoraciones.ConPolimorfismo.ValoracionPorISIN_Tests;
using ComoProcedimiento;
using Algoritmos.CS.Garantias.Negocio.ValoracionesPorISIN.ConPolimorfismo;
using System;
using System.Collections.Generic;

namespace ComoUnProcedimiento.Tests
{
    public class EscenariosListasUDESEnCuenta : Escenarios
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

        protected List<ValoracionPorISIN> UnaValoracionEnUDESAnotadosEnCuenta()
        {
            ValoracionPorISIN laValoracion = UnaValoracionEnUDESYElSaldoEstaAnotadoEnCuenta();
            List<ValoracionPorISIN> laLista = new List<ValoracionPorISIN>();
            laLista.Add(laValoracion);

            return laLista;
        }

        protected ValoracionDeLosISINDeUnaEntidad UnaValoracionConUnISINEnUDESAnotadosEnCuenta()
        {
            List<ISIN> listaDeISINEnColones = new List<ISIN>();
            List<ISIN> listaDeISINEnDolares = new List<ISIN>();
            List<ISIN> listaDeISINEnUDESAnotadosEnCuenta = new List<ISIN>();

            ISIN unISINEnUDESAnotadosEnCuenta = new ISIN();
            unISINEnUDESAnotadosEnCuenta.NumeroISIN = "HDA000000000001";
            unISINEnUDESAnotadosEnCuenta.fechaDeVencimientoDelValorOficial = new DateTime(2016, 6, 6);
            unISINEnUDESAnotadosEnCuenta.diasMinimosAlVencimientoDelEmisor = 7;
            unISINEnUDESAnotadosEnCuenta.porcentajeCobertura = 0.8M;
            unISINEnUDESAnotadosEnCuenta.precioLimpioDelVectorDePrecios = 80;
            unISINEnUDESAnotadosEnCuenta.montoNominalDelSaldo = 1000;
            listaDeISINEnUDESAnotadosEnCuenta.Add(unISINEnUDESAnotadosEnCuenta);

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

        protected List<ValoracionPorISIN> DosValoracionesEnUDESAnotadosEnCuenta()
        {
            ValoracionPorISIN laValoracion = UnaValoracionEnUDESYElSaldoEstaAnotadoEnCuenta();
            List<ValoracionPorISIN> laLista = new List<ValoracionPorISIN>();
            laLista.Add(laValoracion);
            laLista.Add(laValoracion);

            return laLista;
        }

        protected ValoracionDeLosISINDeUnaEntidad UnaValoracionConDosISINEnUDESAnotadosEnCuenta ()
        {
            List<ISIN> listaDeISINEnColones = new List<ISIN>();
            List<ISIN> listaDeISINEnDolares = new List<ISIN>();
            List<ISIN> listaDeISINEnUDESAnotadosEnCuenta = new List<ISIN>();

            ISIN unISINEnUDESAnotadosEnCuenta = new ISIN();
            unISINEnUDESAnotadosEnCuenta.NumeroISIN = "HDA000000000001";
            unISINEnUDESAnotadosEnCuenta.fechaDeVencimientoDelValorOficial = new DateTime(2016, 6, 6);
            unISINEnUDESAnotadosEnCuenta.diasMinimosAlVencimientoDelEmisor = 7;
            unISINEnUDESAnotadosEnCuenta.porcentajeCobertura = 0.8M;
            unISINEnUDESAnotadosEnCuenta.precioLimpioDelVectorDePrecios = 80;
            unISINEnUDESAnotadosEnCuenta.montoNominalDelSaldo = 1000;
            listaDeISINEnUDESAnotadosEnCuenta.Add(unISINEnUDESAnotadosEnCuenta);

            ISIN otroISINEnUDESAnotadosEnCuenta = new ISIN();
            otroISINEnUDESAnotadosEnCuenta.NumeroISIN = "HDA000000000001";
            otroISINEnUDESAnotadosEnCuenta.fechaDeVencimientoDelValorOficial = new DateTime(2016, 6, 6);
            otroISINEnUDESAnotadosEnCuenta.diasMinimosAlVencimientoDelEmisor = 7;
            otroISINEnUDESAnotadosEnCuenta.porcentajeCobertura = 0.8M;
            otroISINEnUDESAnotadosEnCuenta.precioLimpioDelVectorDePrecios = 80;
            otroISINEnUDESAnotadosEnCuenta.montoNominalDelSaldo = 1000;
            listaDeISINEnUDESAnotadosEnCuenta.Add(otroISINEnUDESAnotadosEnCuenta);
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

    }
}
