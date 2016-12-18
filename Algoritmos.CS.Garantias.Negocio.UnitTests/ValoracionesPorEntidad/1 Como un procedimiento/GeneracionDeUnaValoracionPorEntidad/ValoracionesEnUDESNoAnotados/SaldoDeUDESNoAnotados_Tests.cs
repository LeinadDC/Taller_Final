using ComoProcedimiento;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ComoUnProcedimiento.Tests
{
    [TestClass]
    public class SaldoEnUDESNoAnotados_Tests : EscenariosListasUDESNoCuenta
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
            elResultadoEsperado = 640;

            laValoracion = UnaValoracionConUnISINEnUDESNoAnotadosEnCuenta();
            elResultadoObtenido = laValoracion.SaldoEnColones;

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod]
        public void SaldoEnColones_DosISINEnColones_DosMontosSumados()
        {
            elResultadoEsperado = 1280;

            laValoracion = UnaValoracionConDosISINEnUDESNoAnotadosEnCuenta();
            elResultadoObtenido = laValoracion.SaldoEnColones;

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

    }
}