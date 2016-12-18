using ComoProcedimiento;
using Algoritmos.CS.Garantias.Negocio.ValoracionesPorISIN.ConPolimorfismo;
using Mapeable.ComparacionesParaPruebasUnitarias;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace ComoUnProcedimiento.Tests
{
    [TestClass]
    public class ValoracionesEnUDESNoAnotadosEnCuenta_Tests : EscenariosListasUDESNoCuenta
    {
        private List<ValoracionPorISIN> elResultadoEsperado;
        private ValoracionDeLosISINDeUnaEntidad laValoracion;
        private List<ValoracionPorISIN> elResultadoObtenido;

        [TestMethod]
        public void ValoracionesDeLosISINEnUDESNoAnotadosEnCuenta_NingunISIN_Cero()
        {
            elResultadoEsperado = UnaListaSinValoraciones();

            laValoracion = UnaValoracionSinNingunISIN();
            elResultadoObtenido = laValoracion.ValoracionesDeLosISINEnUDESNoAnotadosEnCuenta;

            Verificacion.LasListasSonIguales(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod]
        public void ValoracionesDeLosISINEnUDESNoAnotadosEnCuenta_UnISINEnUDESNoAnotadosEnCuenta_UnaValoracion()
        {
            elResultadoEsperado = UnaValoracionEnUDESNoAnotadosEnCuenta();

            laValoracion = UnaValoracionConUnISINEnUDESNoAnotadosEnCuenta();
            elResultadoObtenido = laValoracion.ValoracionesDeLosISINEnUDESNoAnotadosEnCuenta;

            Verificacion.LasListasSonIguales(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod]
        public void ValoracionesDeLosISINEnUDESNoAnotadosEnCuenta_DosISINEnUDESNoAnotadosEnCuenta_DosValoraciones()
        {
            elResultadoEsperado = DosValoracionesEnUDESNoAnotadosEnCuenta();

            laValoracion = UnaValoracionConDosISINEnUDESNoAnotadosEnCuenta();
            elResultadoObtenido = laValoracion.ValoracionesDeLosISINEnUDESNoAnotadosEnCuenta;

            Verificacion.LasListasSonIguales(elResultadoEsperado, elResultadoObtenido);
        }
    }
}