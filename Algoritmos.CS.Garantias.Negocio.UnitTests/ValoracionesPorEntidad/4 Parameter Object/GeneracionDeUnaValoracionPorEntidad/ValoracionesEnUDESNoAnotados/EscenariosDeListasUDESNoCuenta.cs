using Algoritmos.CS.Garantias.Negocio.UnitTests.Valoraciones.ConPolimorfismo.ValoracionPorISIN_Tests;
using ConParameterObject;
using Algoritmos.CS.Garantias.Negocio.ValoracionesPorISIN.ConPolimorfismo;
using System;
using System.Collections.Generic;

namespace ConParameterObject.Tests
{
    public class EscenariosListasUDESNoCuenta : Escenarios
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

        protected List<ValoracionPorISIN> UnaValoracionEnUDESNoAnotadosEnCuenta()
        {
            ValoracionPorISIN laValoracion = UnaValoracionEnUDESYElSaldoNoEstaAnotadoEnCuenta();
            List<ValoracionPorISIN> laLista = new List<ValoracionPorISIN>();
            laLista.Add(laValoracion);

            return laLista;
        }

        protected ValoracionDeLosISINDeUnaEntidad UnaValoracionConUnISINEnUDESNoAnotadosEnCuenta()
        {
            losDatos.listaDeISINEnColones = new List<ISIN>();
            losDatos.listaDeISINEnDolares = new List<ISIN>();
            losDatos.listaDeISINEnUDESAnotadosEnCuenta = new List<ISIN>();
            losDatos.listaDeISINEnUDESNoAnotadosEnCuenta = new List<ISIN>();

            ISIN unISINEnUDESNoAnotadosEnCuenta = new ISIN();
            unISINEnUDESNoAnotadosEnCuenta.NumeroISIN = "HDA000000000001";
            unISINEnUDESNoAnotadosEnCuenta.fechaDeVencimientoDelValorOficial = new DateTime(2016, 6, 6);
            unISINEnUDESNoAnotadosEnCuenta.diasMinimosAlVencimientoDelEmisor = 7;
            unISINEnUDESNoAnotadosEnCuenta.porcentajeCobertura = 0.8M;
            unISINEnUDESNoAnotadosEnCuenta.precioLimpioDelVectorDePrecios = 80;
            unISINEnUDESNoAnotadosEnCuenta.montoNominalDelSaldo = 1000;
            losDatos.listaDeISINEnUDESNoAnotadosEnCuenta.Add(unISINEnUDESNoAnotadosEnCuenta);

            losDatos.fechaActual = new DateTime(2016, 1, 1);
            losDatos.tipoDeCambioDeUDESDeAyer = 745;
            losDatos.tipoDeCambioDeUDESDeHoy = 750;

            return new ValoracionPorEntidad().GenereLaValoracion(losDatos);
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

            losDatos.listaDeISINEnColones = new List<ISIN>();
            losDatos.listaDeISINEnDolares = new List<ISIN>();
            losDatos.listaDeISINEnUDESAnotadosEnCuenta = new List<ISIN>();
            losDatos.listaDeISINEnUDESNoAnotadosEnCuenta = new List<ISIN>();

            ISIN unISINEnUDESNoAnotadosEnCuenta = new ISIN();
            unISINEnUDESNoAnotadosEnCuenta.NumeroISIN = "HDA000000000001";
            unISINEnUDESNoAnotadosEnCuenta.fechaDeVencimientoDelValorOficial = new DateTime(2016, 6, 6);
            unISINEnUDESNoAnotadosEnCuenta.diasMinimosAlVencimientoDelEmisor = 7;
            unISINEnUDESNoAnotadosEnCuenta.porcentajeCobertura = 0.8M;
            unISINEnUDESNoAnotadosEnCuenta.precioLimpioDelVectorDePrecios = 80;
            unISINEnUDESNoAnotadosEnCuenta.montoNominalDelSaldo = 1000;
            losDatos.listaDeISINEnUDESNoAnotadosEnCuenta.Add(unISINEnUDESNoAnotadosEnCuenta);

            ISIN otroISINEnUDESNoAnotadosEnCuenta = new ISIN();
            otroISINEnUDESNoAnotadosEnCuenta.NumeroISIN = "HDA000000000001";
            otroISINEnUDESNoAnotadosEnCuenta.fechaDeVencimientoDelValorOficial = new DateTime(2016, 6, 6);
            otroISINEnUDESNoAnotadosEnCuenta.diasMinimosAlVencimientoDelEmisor = 7;
            otroISINEnUDESNoAnotadosEnCuenta.porcentajeCobertura = 0.8M;
            otroISINEnUDESNoAnotadosEnCuenta.precioLimpioDelVectorDePrecios = 80;
            otroISINEnUDESNoAnotadosEnCuenta.montoNominalDelSaldo = 1000;
            losDatos.listaDeISINEnUDESNoAnotadosEnCuenta.Add(otroISINEnUDESNoAnotadosEnCuenta);

            losDatos.fechaActual = new DateTime(2016, 1, 1);
            losDatos.tipoDeCambioDeUDESDeAyer = 745;
            losDatos.tipoDeCambioDeUDESDeHoy = 750;

            return new ValoracionPorEntidad().GenereLaValoracion(losDatos);
        }

    }
}
