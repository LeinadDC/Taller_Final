using ConObjetos;
using Algoritmos.CS.Garantias.Negocio.ValoracionesPorISIN.ConPolimorfismo;
using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mapeable.ComparacionesParaPruebasUnitarias;

namespace ConObjetos.Tests
{
    [TestClass]
    public class ComoLista_UDESAnotados_Tests:EscenariosListasUDESEnCuenta
    {
        private List<ValoracionPorISIN> elResultadoEsperado;
        private List<ValoracionPorISIN> elResultadoObtenido;
        private DateTime fechaActual;
        private List<ISIN> listaDeISINEnUDESAnotadosEnCuenta;
        private int tipoDeCambioDeUDESDeAyer;
        private int tipoDeCambioDeUDESDeHoy;

        [TestMethod]
        public void ComoLista_UDESNoAnotados_SinISIN()
        {
            elResultadoEsperado = UnaListaSinValoraciones();

            listaDeISINEnUDESAnotadosEnCuenta = new List<ISIN>();
            fechaActual = new DateTime(2016, 1, 1);
            tipoDeCambioDeUDESDeAyer = 745;
            tipoDeCambioDeUDESDeHoy = 750;
           elResultadoObtenido = new ValoracionISINAnotadoEnCuenta(listaDeISINEnUDESAnotadosEnCuenta, fechaActual, tipoDeCambioDeUDESDeAyer, tipoDeCambioDeUDESDeHoy).ComoLista();

            Verificacion.LasListasSonIguales(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod]
        public void ComoLista_UDESAnotados_UnISIN()
        {
            elResultadoEsperado = UnaValoracionEnUDESAnotadosEnCuenta();

            listaDeISINEnUDESAnotadosEnCuenta = new List<ISIN>();
            ISIN unISINEnUDESAnotadosEnCuenta = new ISIN();
            unISINEnUDESAnotadosEnCuenta.NumeroISIN = "HDA000000000001";
            unISINEnUDESAnotadosEnCuenta.fechaDeVencimientoDelValorOficial = new DateTime(2016, 6, 6);
            unISINEnUDESAnotadosEnCuenta.diasMinimosAlVencimientoDelEmisor = 7;
            unISINEnUDESAnotadosEnCuenta.porcentajeCobertura = 0.8M;
            unISINEnUDESAnotadosEnCuenta.precioLimpioDelVectorDePrecios = 80;
            unISINEnUDESAnotadosEnCuenta.montoNominalDelSaldo = 1000;
            listaDeISINEnUDESAnotadosEnCuenta.Add(unISINEnUDESAnotadosEnCuenta);
            DateTime fechaActual = new DateTime(2016, 1, 1);
            decimal tipoDeCambioDeUDESDeAyer = 745;
            decimal tipoDeCambioDeUDESDeHoy = 750;

           elResultadoObtenido = new ValoracionISINAnotadoEnCuenta(listaDeISINEnUDESAnotadosEnCuenta, fechaActual, tipoDeCambioDeUDESDeAyer, tipoDeCambioDeUDESDeHoy).ComoLista();

            Verificacion.LasListasSonIguales(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod]
        public void ComoLista_UDESAnotados_DosISIN()
        {
            elResultadoEsperado = DosValoracionesEnUDESAnotadosEnCuenta();

            listaDeISINEnUDESAnotadosEnCuenta = new List<ISIN>();
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


           elResultadoObtenido = new ValoracionISINAnotadoEnCuenta(listaDeISINEnUDESAnotadosEnCuenta, fechaActual, tipoDeCambioDeUDESDeAyer, tipoDeCambioDeUDESDeHoy).ComoLista();

            Verificacion.LasListasSonIguales(elResultadoEsperado, elResultadoObtenido);
        }
    }
}
