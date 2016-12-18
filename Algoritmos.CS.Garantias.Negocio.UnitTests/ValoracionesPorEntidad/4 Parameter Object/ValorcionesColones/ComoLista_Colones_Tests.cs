using ConParameterObject;
using Algoritmos.CS.Garantias.Negocio.ValoracionesPorISIN.ConPolimorfismo;
using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mapeable.ComparacionesParaPruebasUnitarias;

namespace ConParameterObject.Tests
{
    [TestClass]
    public class ComoLista_Colones_Tests : EscenariosDeListasEnColones
    {
        [TestClass]
        public class ComoLista_Tests : EscenariosDeListasEnColones
        {
            private List<ValoracionPorISIN> elResultadoEsperado;
            private List<ValoracionPorISIN> elResultadoObtenido;
            private DatosDeLaValoracionPorEntidad losDatos;

            [TestMethod]
            public void ComoLista_Colones_SinISIN()
            {
                elResultadoEsperado = UnaListaSinValoraciones();

                losDatos = new DatosDeLaValoracionPorEntidad();
                losDatos.listaDeISINEnColones = new List<ISIN>();
                losDatos.fechaActual = new DateTime(2016, 1, 1);

                elResultadoObtenido = new ValoracionISINColones(losDatos).ComoLista();

                Verificacion.LasListasSonIguales(elResultadoEsperado, elResultadoObtenido);

            }

            [TestMethod]
            public void ComoLista_Colones_ConISIN()
            {
                elResultadoEsperado = UnaValoracionEnColones();
                losDatos = new DatosDeLaValoracionPorEntidad();

                losDatos.listaDeISINEnColones = new List<ISIN>();

                ISIN unISINEnColones = new ISIN();
                unISINEnColones.NumeroISIN = "HDA000000000001";
                unISINEnColones.fechaDeVencimientoDelValorOficial = new DateTime(2016, 6, 6);
                unISINEnColones.diasMinimosAlVencimientoDelEmisor = 7;
                unISINEnColones.porcentajeCobertura = 0.8M;
                unISINEnColones.precioLimpioDelVectorDePrecios = 80;
                unISINEnColones.montoNominalDelSaldo = 3578000;
                losDatos.listaDeISINEnColones.Add(unISINEnColones);

                losDatos.fechaActual = new DateTime(2016, 1, 1);

                elResultadoObtenido = new ValoracionISINColones(losDatos).ComoLista();

                Verificacion.LasListasSonIguales(elResultadoEsperado, elResultadoObtenido);

            }

            [TestMethod]
            public void ComoLista_Colones_DosISIN()
            {
                elResultadoEsperado = DosValoracionesEnColones();
                losDatos = new DatosDeLaValoracionPorEntidad();


                losDatos.listaDeISINEnColones = new List<ISIN>();

                ISIN unISINEnColones = new ISIN();
                unISINEnColones.NumeroISIN = "HDA000000000001";
                unISINEnColones.fechaDeVencimientoDelValorOficial = new DateTime(2016, 6, 6);
                unISINEnColones.diasMinimosAlVencimientoDelEmisor = 7;
                unISINEnColones.porcentajeCobertura = 0.8M;
                unISINEnColones.precioLimpioDelVectorDePrecios = 80;
                unISINEnColones.montoNominalDelSaldo = 3578000;
                losDatos.listaDeISINEnColones.Add(unISINEnColones);

                ISIN otroISINEnColones = new ISIN();
                otroISINEnColones.NumeroISIN = "HDA000000000001";
                otroISINEnColones.fechaDeVencimientoDelValorOficial = new DateTime(2016, 6, 6);
                otroISINEnColones.diasMinimosAlVencimientoDelEmisor = 7;
                otroISINEnColones.porcentajeCobertura = 0.8M;
                otroISINEnColones.precioLimpioDelVectorDePrecios = 80;
                otroISINEnColones.montoNominalDelSaldo = 3578000;
                losDatos.listaDeISINEnColones.Add(otroISINEnColones);

                losDatos.fechaActual = new DateTime(2016, 1, 1);
                elResultadoObtenido = new ValoracionISINColones(losDatos).ComoLista();

                Verificacion.LasListasSonIguales(elResultadoEsperado, elResultadoObtenido);

            }
        }
    }
}
