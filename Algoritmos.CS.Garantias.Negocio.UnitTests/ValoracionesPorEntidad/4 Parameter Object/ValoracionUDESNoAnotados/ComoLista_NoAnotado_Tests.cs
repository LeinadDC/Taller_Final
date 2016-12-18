using ConObjetos;
using Algoritmos.CS.Garantias.Negocio.ValoracionesPorISIN.ConPolimorfismo;
using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mapeable.ComparacionesParaPruebasUnitarias;

namespace ConParameterObject.Tests
{
    [TestClass]
    public class ComoLista_NoAnotado_Tests : EscenariosListasUDESNoCuenta
    {
        private List<ValoracionPorISIN> elResultadoEsperado;
        private List<ValoracionPorISIN> elResultadoObtenido;
        private DatosDeLaValoracionPorEntidad losDatos;


        [TestMethod]
        public void ComoLista_UDESNoAnotados_SinISIN()
        {
            elResultadoEsperado = UnaListaSinValoraciones();

            losDatos = new DatosDeLaValoracionPorEntidad();
            losDatos.listaDeISINEnUDESNoAnotadosEnCuenta= new List<ISIN>();
            losDatos.fechaActual = new DateTime(2016, 1, 1);

            elResultadoObtenido = new ValoracionISINNoAnotadoEnCuenta(losDatos).ComoLista();

            Verificacion.LasListasSonIguales(elResultadoEsperado, elResultadoObtenido);

        }

        [TestMethod]
        public void ComoLista_UDESNoAnotados_UnISIN()
        {
            elResultadoEsperado = UnaValoracionEnUDESNoAnotadosEnCuenta();

            losDatos = new DatosDeLaValoracionPorEntidad();
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
            elResultadoObtenido = new ValoracionISINNoAnotadoEnCuenta(losDatos).ComoLista();

            Verificacion.LasListasSonIguales(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod]
        public void ComoLista_UDESNoAnotados_DosISIN()
        {
            elResultadoEsperado = DosValoracionesEnUDESNoAnotadosEnCuenta();

            losDatos = new DatosDeLaValoracionPorEntidad();
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
            elResultadoObtenido = new ValoracionISINNoAnotadoEnCuenta(losDatos).ComoLista();

            Verificacion.LasListasSonIguales(elResultadoEsperado, elResultadoObtenido);
        }


    }
}
