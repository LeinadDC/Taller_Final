using ConObjetos;
using Algoritmos.CS.Garantias.Negocio.ValoracionesPorISIN.ConPolimorfismo;
using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mapeable.ComparacionesParaPruebasUnitarias;

namespace ConObjetos.Tests
{
    [TestClass]
    public class ComoLista_NoAnotado_Tests:EscenariosListasUDESNoCuenta
    {
        private List<ValoracionPorISIN> elResultadoEsperado;
        private List<ValoracionPorISIN> elResultadoObtenido;
        private DateTime fechaActual;
        private List<ISIN> listaEnUDESNoAnotados;

        [TestMethod]
        public void ComoLista_UDESNoAnotados_SinISIN()
        {
            elResultadoEsperado = UnaListaSinValoraciones();


            listaEnUDESNoAnotados = new List<ISIN>();
            fechaActual = new DateTime(2016, 1, 1);

            elResultadoObtenido = new ValoracionISINNoAnotadoEnCuenta(listaEnUDESNoAnotados, fechaActual).ComoLista();

            Verificacion.LasListasSonIguales(elResultadoEsperado, elResultadoObtenido);

        }

        [TestMethod]
        public void ComoLista_UDESNoAnotados_UnISIN()
        {
            elResultadoEsperado = UnaValoracionEnUDESNoAnotadosEnCuenta();

            listaEnUDESNoAnotados = new List<ISIN>();

            ISIN unISINEnUDESNoAnotadosEnCuenta = new ISIN();
            unISINEnUDESNoAnotadosEnCuenta.NumeroISIN = "HDA000000000001";
            unISINEnUDESNoAnotadosEnCuenta.fechaDeVencimientoDelValorOficial = new DateTime(2016, 6, 6);
            unISINEnUDESNoAnotadosEnCuenta.diasMinimosAlVencimientoDelEmisor = 7;
            unISINEnUDESNoAnotadosEnCuenta.porcentajeCobertura = 0.8M;
            unISINEnUDESNoAnotadosEnCuenta.precioLimpioDelVectorDePrecios = 80;
            unISINEnUDESNoAnotadosEnCuenta.montoNominalDelSaldo = 1000;
            listaEnUDESNoAnotados.Add(unISINEnUDESNoAnotadosEnCuenta);
            DateTime fechaActual = new DateTime(2016, 1, 1);
            elResultadoObtenido = new ValoracionISINNoAnotadoEnCuenta(listaEnUDESNoAnotados, fechaActual).ComoLista();

            Verificacion.LasListasSonIguales(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod]
        public void ComoLista_UDESNoAnotados_DosISIN()
        {
            elResultadoEsperado = DosValoracionesEnUDESNoAnotadosEnCuenta();

            listaEnUDESNoAnotados = new List<ISIN>();

            ISIN unISINEnUDESNoAnotadosEnCuenta = new ISIN();
            unISINEnUDESNoAnotadosEnCuenta.NumeroISIN = "HDA000000000001";
            unISINEnUDESNoAnotadosEnCuenta.fechaDeVencimientoDelValorOficial = new DateTime(2016, 6, 6);
            unISINEnUDESNoAnotadosEnCuenta.diasMinimosAlVencimientoDelEmisor = 7;
            unISINEnUDESNoAnotadosEnCuenta.porcentajeCobertura = 0.8M;
            unISINEnUDESNoAnotadosEnCuenta.precioLimpioDelVectorDePrecios = 80;
            unISINEnUDESNoAnotadosEnCuenta.montoNominalDelSaldo = 1000;
            listaEnUDESNoAnotados.Add(unISINEnUDESNoAnotadosEnCuenta);

            ISIN otroISINEnUDESNoAnotadosEnCuenta = new ISIN();
            otroISINEnUDESNoAnotadosEnCuenta.NumeroISIN = "HDA000000000001";
            otroISINEnUDESNoAnotadosEnCuenta.fechaDeVencimientoDelValorOficial = new DateTime(2016, 6, 6);
            otroISINEnUDESNoAnotadosEnCuenta.diasMinimosAlVencimientoDelEmisor = 7;
            otroISINEnUDESNoAnotadosEnCuenta.porcentajeCobertura = 0.8M;
            otroISINEnUDESNoAnotadosEnCuenta.precioLimpioDelVectorDePrecios = 80;
            otroISINEnUDESNoAnotadosEnCuenta.montoNominalDelSaldo = 1000;
            listaEnUDESNoAnotados.Add(otroISINEnUDESNoAnotadosEnCuenta);

            DateTime fechaActual = new DateTime(2016, 1, 1);
            elResultadoObtenido = new ValoracionISINNoAnotadoEnCuenta(listaEnUDESNoAnotados, fechaActual).ComoLista();

            Verificacion.LasListasSonIguales(elResultadoEsperado, elResultadoObtenido);
        }


    }
}
