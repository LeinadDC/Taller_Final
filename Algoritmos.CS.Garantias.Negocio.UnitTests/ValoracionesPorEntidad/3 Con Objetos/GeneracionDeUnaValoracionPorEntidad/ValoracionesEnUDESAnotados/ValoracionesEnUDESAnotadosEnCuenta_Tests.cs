using ConObjetos;
using Algoritmos.CS.Garantias.Negocio.ValoracionesPorISIN.ConPolimorfismo;
using Mapeable.ComparacionesParaPruebasUnitarias;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace ConObjetos.Tests
{
    [TestClass]
    public class ValoracionesEnUDESAnotadosEnCuenta_Tests : EscenariosListasUDESEnCuenta
    {
        private List<ValoracionPorISIN> elResultadoEsperado;
        private ValoracionDeLosISINDeUnaEntidad laValoracion;
        private List<ValoracionPorISIN> elResultadoObtenido;

        [TestMethod]
        public void ValoracionesDeLosISINEnColones_NingunISIN_Cero()
        {
            elResultadoEsperado = UnaListaSinValoraciones();

            laValoracion = UnaValoracionSinNingunISIN();
            elResultadoObtenido = laValoracion.ValoracionesDeLosISINEnUDESAnotadosEnCuenta;

            Verificacion.LasListasSonIguales(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod]
        public void ValoracionesDeLosISINEnUDESAnotadosEnCuenta_UnISINEnUDESAnotadosEnCuenta_UnaValoracion()
        {
            elResultadoEsperado = UnaValoracionEnUDESAnotadosEnCuenta();

            laValoracion = UnaValoracionConUnISINEnUDESAnotadosEnCuenta();
            elResultadoObtenido = laValoracion.ValoracionesDeLosISINEnUDESAnotadosEnCuenta;

            Verificacion.LasListasSonIguales(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod]
        public void ValoracionesDeLosISINEnUDESAnotadosEnCuenta_DosISINEnUDESAnotadosEnCuenta_DosValoraciones()
        {
            elResultadoEsperado = DosValoracionesEnUDESAnotadosEnCuenta();

            laValoracion = UnaValoracionConDosISINEnUDESAnotadosEnCuenta();
            elResultadoObtenido = laValoracion.ValoracionesDeLosISINEnUDESAnotadosEnCuenta;

            Verificacion.LasListasSonIguales(elResultadoEsperado, elResultadoObtenido);
        }
    }
}