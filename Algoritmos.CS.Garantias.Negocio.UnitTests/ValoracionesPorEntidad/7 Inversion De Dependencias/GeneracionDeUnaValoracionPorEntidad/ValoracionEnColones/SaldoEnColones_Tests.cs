using ConInversionDeDependencias;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConInversionDeDependencias.Tests
{
    [TestClass]
    public class SaldoEnColones_Tests : EscenariosDeListasEnColones
    {
        private decimal elResultadoEsperado;
        private ValoracionDeLosISINDeUnaEntidad laValoracion;
        private decimal elResultadoObtenido;

        [TestMethod]
        public void SaldoEnColones_NingunISIN_Cero()
        {
            elResultadoEsperado = 0;

            laValoracion = UnaValoracionSinNingunISIN();
            elResultadoObtenido = laValoracion.SaldoEnColones;

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod]
        public void SaldoEnColones_UnISINEnColones_SuAporteDeGarantia()
        {
            elResultadoEsperado = 2289920;

            laValoracion = UnaValoracionConUnISINEnColones();
            elResultadoObtenido = laValoracion.SaldoEnColones;

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod]
        public void SaldoEnColones_DosISINEnColones_DosMontosSumados()
        {
            elResultadoEsperado = 4579840;

            laValoracion = UnaValoracionConDosISINEnColones();
            elResultadoObtenido = laValoracion.SaldoEnColones;

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

    }
}