using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algoritmos.CS.Garantias.Negocio.ValoracionesPorISIN.ConPolimorfismo;
using ConObjetos;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace ConObjetos.Tests
{
    [TestClass]
    public class SaldoComoNumero_Tests:EscenariosSaldo
    { 
            private decimal elResultadoEsperado;
            private decimal elResultadoObtenido;
            private List<ValoracionPorISIN> listaEnColones;
            private List<ValoracionPorISIN> listaEnUDESAnotados;
            private List<ValoracionPorISIN> listaEnUDESNoAnotados;


            [TestMethod]
            public void SaldoEnColones_ComoNumero_SinISIN()
            {
                elResultadoEsperado = 0;

                listaEnColones = UnaListaSinValoraciones();
                listaEnUDESAnotados = UnaListaSinValoraciones();
                listaEnUDESNoAnotados = UnaListaSinValoraciones();
                elResultadoObtenido = new SaldoEnColones(listaEnColones, listaEnUDESAnotados, listaEnUDESNoAnotados).ComoNumero();

                Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
            }

            [TestMethod]
            public void SaldoEnColones_ComoNumero_UnISIN()
            {
                elResultadoEsperado = 2289920;

                listaEnColones = UnaValoracionEnColones();
                listaEnUDESAnotados = UnaListaSinValoraciones();
                listaEnUDESNoAnotados = UnaListaSinValoraciones();
                elResultadoObtenido = new SaldoEnColones(listaEnColones, listaEnUDESAnotados, listaEnUDESNoAnotados).ComoNumero();

                Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
            }

            [TestMethod]
            public void SaldoEnColones_ComoNumero_DosISIN()
            {
                elResultadoEsperado = 4579840;

                listaEnColones = DosValoracionesEnColones();
                listaEnUDESAnotados = UnaListaSinValoraciones();
                listaEnUDESNoAnotados = UnaListaSinValoraciones();
                elResultadoObtenido = new SaldoEnColones(listaEnColones, listaEnUDESAnotados, listaEnUDESNoAnotados).ComoNumero();

                Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
            }

            [TestMethod]
            public void SaldoEnColones_UDESAnotados_ComoNumero_UnISIN()
            {
                elResultadoEsperado = 480000;

                listaEnColones = UnaListaSinValoraciones();
                listaEnUDESAnotados = UnaValoracionEnUDESAnotadosEnCuenta();
                listaEnUDESNoAnotados = UnaListaSinValoraciones();
                elResultadoObtenido = new SaldoEnColones(listaEnColones, listaEnUDESAnotados, listaEnUDESNoAnotados).ComoNumero();

                Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
            }

            [TestMethod]
            public void SaldoEnColones_UDESAnotados_ComoNumero_DosISIN()
            {
                elResultadoEsperado = 960000;

                listaEnColones = UnaListaSinValoraciones();
                listaEnUDESAnotados = DosValoracionesEnUDESAnotadosEnCuenta();
                listaEnUDESNoAnotados = UnaListaSinValoraciones();
                elResultadoObtenido = new SaldoEnColones(listaEnColones, listaEnUDESAnotados, listaEnUDESNoAnotados).ComoNumero();

                Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
            }

            [TestMethod]
            public void SaldoEnColones_UDESNoAnotados_ComoNumero_UnISIN()
            {
                elResultadoEsperado = 640;

                listaEnColones = UnaListaSinValoraciones();
                listaEnUDESAnotados = UnaListaSinValoraciones();
                listaEnUDESNoAnotados = UnaValoracionEnUDESNoAnotadosEnCuenta();
                elResultadoObtenido = new SaldoEnColones(listaEnColones, listaEnUDESAnotados, listaEnUDESNoAnotados).ComoNumero();

                Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
            }

            [TestMethod]
            public void SaldoEnColones_UDESNoAnotados_ComoNumero_DosISIN()
            {
                elResultadoEsperado = 1280;

                listaEnColones = UnaListaSinValoraciones();
                listaEnUDESAnotados = UnaListaSinValoraciones();
                listaEnUDESNoAnotados = DosValoracionesEnUDESNoAnotadosEnCuenta();
                elResultadoObtenido = new SaldoEnColones(listaEnColones, listaEnUDESAnotados, listaEnUDESNoAnotados).ComoNumero();

                Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
            }
        }
}
