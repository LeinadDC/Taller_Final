using ConObjetos;
using Algoritmos.CS.Garantias.Negocio.ValoracionesPorISIN.ConPolimorfismo;
using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mapeable.ComparacionesParaPruebasUnitarias;

namespace ConParameterObject.Tests
{
    [TestClass]
    public class ComoLista_UDESAnotados_Tests : EscenariosListasUDESEnCuenta
    {
        private List<ValoracionPorISIN> elResultadoEsperado;
        private List<ValoracionPorISIN> elResultadoObtenido;
        private DatosDeLaValoracionPorEntidad losDatos;

        [TestMethod]
        public void ComoLista_UDESNoAnotados_SinISIN()
        {
            elResultadoEsperado = UnaListaSinValoraciones();

            losDatos = new DatosDeLaValoracionPorEntidad();
            losDatos.listaDeISINEnUDESAnotadosEnCuenta = new List<ISIN>();
            losDatos.fechaActual = new DateTime(2016, 1, 1);
            losDatos.tipoDeCambioDeUDESDeAyer = 745;
            losDatos.tipoDeCambioDeUDESDeHoy = 750;
            elResultadoObtenido = new ValoracionISINAnotadoEnCuenta(losDatos).ComoLista();

            Verificacion.LasListasSonIguales(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod]
        public void ComoLista_UDESAnotados_UnISIN()
        {
            elResultadoEsperado = UnaValoracionEnUDESAnotadosEnCuenta();

            losDatos = new DatosDeLaValoracionPorEntidad();
            losDatos.listaDeISINEnUDESAnotadosEnCuenta = new List<ISIN>();
            ISIN unISINEnUDESAnotadosEnCuenta = new ISIN();
            unISINEnUDESAnotadosEnCuenta.NumeroISIN = "HDA000000000001";
            unISINEnUDESAnotadosEnCuenta.fechaDeVencimientoDelValorOficial = new DateTime(2016, 6, 6);
            unISINEnUDESAnotadosEnCuenta.diasMinimosAlVencimientoDelEmisor = 7;
            unISINEnUDESAnotadosEnCuenta.porcentajeCobertura = 0.8M;
            unISINEnUDESAnotadosEnCuenta.precioLimpioDelVectorDePrecios = 80;
            unISINEnUDESAnotadosEnCuenta.montoNominalDelSaldo = 1000;
            losDatos.listaDeISINEnUDESAnotadosEnCuenta.Add(unISINEnUDESAnotadosEnCuenta);
            losDatos.fechaActual = new DateTime(2016, 1, 1);
            losDatos.tipoDeCambioDeUDESDeAyer = 745;
            losDatos.tipoDeCambioDeUDESDeHoy = 750;

            elResultadoObtenido = new ValoracionISINAnotadoEnCuenta(losDatos).ComoLista();

            Verificacion.LasListasSonIguales(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod]
        public void ComoLista_UDESAnotados_DosISIN()
        {
            elResultadoEsperado = DosValoracionesEnUDESAnotadosEnCuenta();

            losDatos = new DatosDeLaValoracionPorEntidad();
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
            losDatos.fechaActual = new DateTime(2016, 1, 1);
            losDatos.tipoDeCambioDeUDESDeAyer = 745;
            losDatos.tipoDeCambioDeUDESDeHoy = 750;


            elResultadoObtenido = new ValoracionISINAnotadoEnCuenta(losDatos).ComoLista();

            Verificacion.LasListasSonIguales(elResultadoEsperado, elResultadoObtenido);
        }
    }
}
