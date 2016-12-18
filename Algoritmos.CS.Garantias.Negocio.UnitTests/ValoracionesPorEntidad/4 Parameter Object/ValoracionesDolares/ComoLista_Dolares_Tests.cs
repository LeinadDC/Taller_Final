using ConParameterObject;
using Algoritmos.CS.Garantias.Negocio.ValoracionesPorISIN.ConPolimorfismo;
using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mapeable.ComparacionesParaPruebasUnitarias;


namespace ConParameterObject.Tests
{
    [TestClass]
    public class ComoLista_Dolares_Tests : EscenariosDeListasEnDolares
    {
        private List<ValoracionPorISIN> elResultadoEsperado;
        private List<ValoracionPorISIN> elResultadoObtenido;
        private DatosDeLaValoracionPorEntidad losDatos;


        [TestMethod]
        public void ComoLista_Dolares_SinISIN()
        {
            elResultadoEsperado = UnaListaSinValoraciones();

            losDatos = new DatosDeLaValoracionPorEntidad();
            losDatos.listaDeISINEnDolares = new List<ISIN>();
            losDatos.fechaActual = new DateTime(2016, 1, 1);


            elResultadoObtenido = new ValoracionISINDolares(losDatos).ComoLista();

            Verificacion.LasListasSonIguales(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod]
        public void ComoLista_Dolares_UnISIN()
        {
            elResultadoEsperado = UnaValoracionEnDolares();

            losDatos = new DatosDeLaValoracionPorEntidad();
            losDatos.listaDeISINEnDolares = new List<ISIN>();

            ISIN unISINEnDolares = new ISIN();
            unISINEnDolares.NumeroISIN = "HDA000000000001";
            unISINEnDolares.fechaDeVencimientoDelValorOficial = new DateTime(2016, 1, 7);
            unISINEnDolares.diasMinimosAlVencimientoDelEmisor = 7;
            unISINEnDolares.porcentajeCobertura = 0.8M;
            unISINEnDolares.precioLimpioDelVectorDePrecios = 80;
            unISINEnDolares.montoNominalDelSaldo = 1000;
            losDatos.listaDeISINEnDolares.Add(unISINEnDolares);

            losDatos.fechaActual = new DateTime(2016, 1, 1);

            elResultadoObtenido = new ValoracionISINDolares(losDatos).ComoLista();

            Verificacion.LasListasSonIguales(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod]
        public void ComoLista_Dolares_DosISIN()
        {
            elResultadoEsperado = DosValoracionesEnDolares();

            losDatos = new DatosDeLaValoracionPorEntidad();
            losDatos.listaDeISINEnDolares = new List<ISIN>();

            ISIN unISINEnDolares = new ISIN();
            unISINEnDolares.NumeroISIN = "HDA000000000001";
            unISINEnDolares.fechaDeVencimientoDelValorOficial = new DateTime(2016, 6, 6);
            unISINEnDolares.diasMinimosAlVencimientoDelEmisor = 7;
            unISINEnDolares.porcentajeCobertura = 0.8M;
            unISINEnDolares.precioLimpioDelVectorDePrecios = 80;
            unISINEnDolares.montoNominalDelSaldo = 1000;
            losDatos.listaDeISINEnDolares.Add(unISINEnDolares);

            ISIN otroISINEnDolares = new ISIN();
            otroISINEnDolares.NumeroISIN = "HDA000000000001";
            otroISINEnDolares.fechaDeVencimientoDelValorOficial = new DateTime(2016, 6, 6);
            otroISINEnDolares.diasMinimosAlVencimientoDelEmisor = 7;
            otroISINEnDolares.porcentajeCobertura = 0.8M;
            otroISINEnDolares.precioLimpioDelVectorDePrecios = 80;
            otroISINEnDolares.montoNominalDelSaldo = 1000;
            losDatos.listaDeISINEnDolares.Add(otroISINEnDolares);

            losDatos.fechaActual = new DateTime(2016, 1, 1);

            elResultadoObtenido = new ValoracionISINDolares(losDatos).ComoLista();

            Verificacion.LasListasSonIguales(elResultadoEsperado, elResultadoObtenido);
        }
    }
}