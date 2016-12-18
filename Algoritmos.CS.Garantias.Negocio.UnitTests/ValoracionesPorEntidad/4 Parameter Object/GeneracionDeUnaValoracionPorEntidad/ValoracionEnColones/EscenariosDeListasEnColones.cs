using Algoritmos.CS.Garantias.Negocio.UnitTests.Valoraciones.ConPolimorfismo.ValoracionPorISIN_Tests;
using ConParameterObject;
using Algoritmos.CS.Garantias.Negocio.ValoracionesPorISIN.ConPolimorfismo;
using System;
using System.Collections.Generic;

namespace ConParameterObject.Tests
{
    public class EscenariosDeListasEnColones : Escenarios
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

        protected List<ValoracionPorISIN> UnaValoracionEnColones()
        {
            ValoracionPorISIN laValoracion = UnaValoracionEnColonesYCumpleLosDiasMinimos();
            List<ValoracionPorISIN> laLista = new List<ValoracionPorISIN>();
            laLista.Add(laValoracion);

            return laLista;
        }

        protected ValoracionDeLosISINDeUnaEntidad UnaValoracionConUnISINEnColones()
        {
            losDatos = new DatosDeLaValoracionPorEntidad();

            losDatos.listaDeISINEnColones = new List<ISIN>();

            ISIN unISINEnDolares = new ISIN();
            unISINEnDolares.NumeroISIN = "HDA000000000001";
            unISINEnDolares.fechaDeVencimientoDelValorOficial = new DateTime(2016, 6, 6);
            unISINEnDolares.diasMinimosAlVencimientoDelEmisor = 7;
            unISINEnDolares.porcentajeCobertura = 0.8M;
            unISINEnDolares.precioLimpioDelVectorDePrecios = 80;
            unISINEnDolares.montoNominalDelSaldo = 3578000;
            losDatos.listaDeISINEnColones.Add(unISINEnDolares);

            losDatos.listaDeISINEnUDESAnotadosEnCuenta = new List<ISIN>();
            losDatos.listaDeISINEnUDESNoAnotadosEnCuenta = new List<ISIN>();
            losDatos.fechaActual = new DateTime(2016, 1, 1);
            losDatos.tipoDeCambioDeUDESDeAyer = 745;
            losDatos.tipoDeCambioDeUDESDeHoy = 750;

            return new ValoracionPorEntidad().GenereLaValoracion(losDatos);
        }

        protected List<ValoracionPorISIN> DosValoracionesEnColones()
        {
            ValoracionPorISIN laValoracion = UnaValoracionEnColonesYCumpleLosDiasMinimos();
            List<ValoracionPorISIN> laLista = new List<ValoracionPorISIN>();
            laLista.Add(laValoracion);
            laLista.Add(laValoracion);

            return laLista;
        }

        protected ValoracionDeLosISINDeUnaEntidad UnaValoracionConDosISINEnColones()
        {
            losDatos = new DatosDeLaValoracionPorEntidad();

            losDatos.listaDeISINEnColones = new List<ISIN>();

            ISIN unISINEnDolares = new ISIN();
            unISINEnDolares.NumeroISIN = "HDA000000000001";
            unISINEnDolares.fechaDeVencimientoDelValorOficial = new DateTime(2016, 6, 6);
            unISINEnDolares.diasMinimosAlVencimientoDelEmisor = 7;
            unISINEnDolares.porcentajeCobertura = 0.8M;
            unISINEnDolares.precioLimpioDelVectorDePrecios = 80;
            unISINEnDolares.montoNominalDelSaldo = 3578000;
            losDatos.listaDeISINEnColones.Add(unISINEnDolares);

            ISIN otroISINEnDolares = new ISIN();
            otroISINEnDolares.NumeroISIN = "HDA000000000001";
            otroISINEnDolares.fechaDeVencimientoDelValorOficial = new DateTime(2016, 6, 6);
            otroISINEnDolares.diasMinimosAlVencimientoDelEmisor = 7;
            otroISINEnDolares.porcentajeCobertura = 0.8M;
            otroISINEnDolares.precioLimpioDelVectorDePrecios = 80;
            otroISINEnDolares.montoNominalDelSaldo = 3578000;
            losDatos.listaDeISINEnColones.Add(otroISINEnDolares);

            List<ISIN> listaDeISINEnUDESAnotadosEnCuenta = new List<ISIN>();
            List<ISIN> listaDeISINEnUDESNoAnotadosEnCuenta = new List<ISIN>();
            losDatos.fechaActual = new DateTime(2016, 1, 1);
            losDatos.tipoDeCambioDeUDESDeAyer = 745;
            losDatos.tipoDeCambioDeUDESDeHoy = 750;

            return new ValoracionPorEntidad().GenereLaValoracion(losDatos);
        }

    }
}
