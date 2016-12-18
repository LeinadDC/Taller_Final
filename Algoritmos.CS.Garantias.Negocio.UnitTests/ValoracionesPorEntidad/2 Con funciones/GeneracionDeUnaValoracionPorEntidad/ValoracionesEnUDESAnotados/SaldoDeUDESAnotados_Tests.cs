using ConFunciones;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConFunciones.Tests
{
    [TestClass]
    public class SaldoEnUDESAnotados_Tests : EscenariosListasUDESEnCuenta
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
            elResultadoEsperado = 480000;

            laValoracion = UnaValoracionConUnISINEnUDESAnotadosEnCuenta();
            elResultadoObtenido = laValoracion.SaldoEnColones;

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod]
        public void SaldoEnColones_DosISINEnColones_DosMontosSumados()
        {
            elResultadoEsperado = 960000;

            laValoracion = UnaValoracionConDosISINEnUDESAnotadosEnCuenta();
            elResultadoObtenido = laValoracion.SaldoEnColones;

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

    }
}