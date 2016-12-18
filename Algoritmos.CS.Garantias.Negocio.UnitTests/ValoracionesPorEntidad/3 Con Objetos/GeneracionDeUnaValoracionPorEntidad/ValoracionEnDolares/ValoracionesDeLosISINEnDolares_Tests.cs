using ConObjetos;
using Algoritmos.CS.Garantias.Negocio.ValoracionesPorISIN.ConPolimorfismo;
using Mapeable.ComparacionesParaPruebasUnitarias;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace ConObjetos.Tests
{
    [TestClass]
    public class ValoracionesDeLosISINEnColones_Tests : EscenariosDeListasEnDolares
    {
        private List<ValoracionPorISIN> elResultadoEsperado;
        private ValoracionDeLosISINDeUnaEntidad laValoracion;
        private List<ValoracionPorISIN> elResultadoObtenido;

        [TestMethod]
        public void ValoracionesDeLosISINEnDolares_NingunISIN_Cero()
        {
            elResultadoEsperado = UnaListaSinValoraciones();

            laValoracion = UnaValoracionSinNingunISIN();
            elResultadoObtenido = laValoracion.ValoracionesDeLosISINEnDolares;

            Verificacion.LasListasSonIguales(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod]
        public void ValoracionesDeLosISINEnDolares_UnISINEnDolares_UnaValoracion()
        {
            elResultadoEsperado = UnaValoracionEnDolares();

            laValoracion = UnaValoracionConUnISINEnDolares();
            elResultadoObtenido = laValoracion.ValoracionesDeLosISINEnDolares;

            Verificacion.LasListasSonIguales(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod]
        public void ValoracionesDeLosISINEnDolares_DosISINEnDolares_DosValoraciones()
        {
            elResultadoEsperado = DosValoracionesEnDolares();

            laValoracion = UnaValoracionConDosISINEnDolares();
            elResultadoObtenido = laValoracion.ValoracionesDeLosISINEnDolares;

            Verificacion.LasListasSonIguales(elResultadoEsperado, elResultadoObtenido);
        }
    }
}