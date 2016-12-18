using ConObjetos;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConObjetos.Tests
{
    [TestClass]
    public class SaldoEnDolares_Tests : EscenariosDeListasEnDolares
    {
        private decimal elResultadoEsperado;
        private ValoracionDeLosISINDeUnaEntidad laValoracion;
        private decimal elResultadoObtenido;

        [TestMethod]
        public void SaldoEnDolares_NingunISIN_Cero()
        {
            elResultadoEsperado = 0;

            laValoracion = UnaValoracionSinNingunISIN();
            elResultadoObtenido = laValoracion.SaldoEnDolares;

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod]
        public void SaldoEnDolares_UnISINEnDolares_SuAporteDeGarantia()
        {
            elResultadoEsperado = 0;

            laValoracion = UnaValoracionConUnISINEnDolares();
            elResultadoObtenido = laValoracion.SaldoEnDolares;

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod]
        public void SaldoEnDolares_DosISINEnDolares_DosMontosSumados()
        {
            elResultadoEsperado = 1280;

            laValoracion = UnaValoracionConDosISINEnDolares();
            elResultadoObtenido = laValoracion.SaldoEnDolares;

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

    }
}