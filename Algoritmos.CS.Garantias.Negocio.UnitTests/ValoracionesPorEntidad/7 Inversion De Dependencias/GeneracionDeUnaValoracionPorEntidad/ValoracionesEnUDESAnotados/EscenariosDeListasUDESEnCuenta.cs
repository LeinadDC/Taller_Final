using Algoritmos.CS.Garantias.Negocio.UnitTests.Valoraciones.ConPolimorfismo.ValoracionPorISIN_Tests;
using ConInversionDeDependencias;
using Algoritmos.CS.Garantias.Negocio.ValoracionesPorISIN.ConPolimorfismo;
using System;
using System.Collections.Generic;
using NSubstitute;

namespace ConInversionDeDependencias.Tests
{
    public class EscenariosListasUDESEnCuenta : Escenarios
    {
        DatosDeLaValoracionPorEntidad losDatos;

        protected List<ValoracionPorISIN> UnaListaSinValoraciones()
        {
            return new List<ValoracionPorISIN>();
        }

        protected ValoracionDeLosISINDeUnaEntidad UnaValoracionSinNingunISIN()
        {
            losDatos = Substitute.For<DatosDeLaValoracionPorEntidad>();

            losDatos.listaDeISINEnColones = new List<ISIN>();
            losDatos.listaDeISINEnDolares = new List<ISIN>();
            losDatos.listaDeISINEnUDESAnotadosEnCuenta = new List<ISIN>();
            losDatos.listaDeISINEnUDESNoAnotadosEnCuenta = new List<ISIN>();
            losDatos.fechaActual.Returns(new DateTime(2016, 1, 1));
            losDatos.tipoDeCambioDeUDESDeAyer.Returns(745);
            losDatos.tipoDeCambioDeUDESDeHoy.Returns(750);

            return new ValoracionPorEntidad().GenereLaValoracion(losDatos);
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
            losDatos = Substitute.For<DatosDeLaValoracionPorEntidad>();

            losDatos.listaDeISINEnColones = new List<ISIN>();
            losDatos.listaDeISINEnDolares = new List<ISIN>();
            losDatos.listaDeISINEnUDESAnotadosEnCuenta = new List<ISIN>();

            ISIN unISINEnUDESAnotadosEnCuenta = new ISIN();
            unISINEnUDESAnotadosEnCuenta.NumeroISIN = "HDA000000000001";
            unISINEnUDESAnotadosEnCuenta.fechaDeVencimientoDelValorOficial = new DateTime(2016, 6, 6);
            unISINEnUDESAnotadosEnCuenta.diasMinimosAlVencimientoDelEmisor = 7;
            unISINEnUDESAnotadosEnCuenta.porcentajeCobertura = 0.8M;
            unISINEnUDESAnotadosEnCuenta.precioLimpioDelVectorDePrecios = 80;
            unISINEnUDESAnotadosEnCuenta.montoNominalDelSaldo = 1000;
            losDatos.listaDeISINEnUDESAnotadosEnCuenta.Add(unISINEnUDESAnotadosEnCuenta);

            losDatos.listaDeISINEnUDESNoAnotadosEnCuenta = new List<ISIN>();
            losDatos.fechaActual.Returns(new DateTime(2016, 1, 1));
            losDatos.tipoDeCambioDeUDESDeAyer.Returns(745);
            losDatos.tipoDeCambioDeUDESDeHoy.Returns(750);

            return new ValoracionPorEntidad().GenereLaValoracion(losDatos);
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
            losDatos = Substitute.For<DatosDeLaValoracionPorEntidad>();

            losDatos.listaDeISINEnColones = new List<ISIN>();
            losDatos.listaDeISINEnDolares = new List<ISIN>();
            losDatos.listaDeISINEnUDESAnotadosEnCuenta = new List<ISIN>();

            ISIN unISINEnUDESAnotadosEnCuenta = new ISIN();
            unISINEnUDESAnotadosEnCuenta.NumeroISIN = "HDA000000000001";
            unISINEnUDESAnotadosEnCuenta.fechaDeVencimientoDelValorOficial = new DateTime(2016, 6, 6);
            unISINEnUDESAnotadosEnCuenta.diasMinimosAlVencimientoDelEmisor = 7;
            unISINEnUDESAnotadosEnCuenta.porcentajeCobertura = 0.8M;
            unISINEnUDESAnotadosEnCuenta.precioLimpioDelVectorDePrecios = 80;
            unISINEnUDESAnotadosEnCuenta.montoNominalDelSaldo = 1000;
            losDatos.listaDeISINEnUDESAnotadosEnCuenta.Add(unISINEnUDESAnotadosEnCuenta);

            ISIN otroISINEnUDESAnotadosEnCuenta = new ISIN();
            otroISINEnUDESAnotadosEnCuenta.NumeroISIN = "HDA000000000001";
            otroISINEnUDESAnotadosEnCuenta.fechaDeVencimientoDelValorOficial = new DateTime(2016, 6, 6);
            otroISINEnUDESAnotadosEnCuenta.diasMinimosAlVencimientoDelEmisor = 7;
            otroISINEnUDESAnotadosEnCuenta.porcentajeCobertura = 0.8M;
            otroISINEnUDESAnotadosEnCuenta.precioLimpioDelVectorDePrecios = 80;
            otroISINEnUDESAnotadosEnCuenta.montoNominalDelSaldo = 1000;
            losDatos.listaDeISINEnUDESAnotadosEnCuenta.Add(otroISINEnUDESAnotadosEnCuenta);
            losDatos.listaDeISINEnUDESNoAnotadosEnCuenta = new List<ISIN>();
            losDatos.fechaActual.Returns(new DateTime(2016, 1, 1));
            losDatos.tipoDeCambioDeUDESDeAyer.Returns(745);
            losDatos.tipoDeCambioDeUDESDeHoy.Returns(750);

            return new ValoracionPorEntidad().GenereLaValoracion(losDatos);
        }

    }
}
