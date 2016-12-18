using ConParameterObject;
using Algoritmos.CS.Garantias.Negocio.ValoracionesPorISIN.ConPolimorfismo;
using Mapeable.ComparacionesParaPruebasUnitarias;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace ConParameterObject.Tests
{
    [TestClass]
    public class ValoracionesDeLosISINEnDolares_Tests : EscenariosDeListasEnColones
    {
        private List<ValoracionPorISIN> elResultadoEsperado;
        private ValoracionDeLosISINDeUnaEntidad laValoracion;
        private List<ValoracionPorISIN> elResultadoObtenido;

        [TestMethod]
        public void ValoracionesDeLosISINEnColones_NingunISIN_Cero()
        {
            elResultadoEsperado = UnaListaSinValoraciones();

            laValoracion = UnaValoracionSinNingunISIN();
            elResultadoObtenido = laValoracion.ValoracionesDeLosISINEnColones;

            Verificacion.LasListasSonIguales(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod]
        public void ValoracionesDeLosISINEnColones_UnISINEnColones_UnaValoracion()
        {
            elResultadoEsperado = UnaValoracionEnColones();

            laValoracion = UnaValoracionConUnISINEnColones();
            elResultadoObtenido = laValoracion.ValoracionesDeLosISINEnColones;

            Verificacion.LasListasSonIguales(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod]
        public void ValoracionesDeLosISINEnColones_DosISINEnColones_DosValoraciones()
        {
            elResultadoEsperado = DosValoracionesEnColones();

            laValoracion = UnaValoracionConDosISINEnColones();
            elResultadoObtenido = laValoracion.ValoracionesDeLosISINEnColones;

            Verificacion.LasListasSonIguales(elResultadoEsperado, elResultadoObtenido);
        }
    }
}