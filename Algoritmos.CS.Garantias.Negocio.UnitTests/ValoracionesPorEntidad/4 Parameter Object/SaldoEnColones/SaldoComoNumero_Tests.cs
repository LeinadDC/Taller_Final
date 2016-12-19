using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algoritmos.CS.Garantias.Negocio.ValoracionesPorISIN.ConPolimorfismo;
using ConObjetos;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace ConParameterObject.Tests
{
    [TestClass]
    public class SaldoComoNumero_Tests : EscenariosSaldo
    {
        private decimal elResultadoEsperado;
        private decimal elResultadoObtenido;
        private DatosSaldoColones losDatos;


        [TestMethod]
        public void SaldoEnColones_ComoNumero_SinISIN()
        {
            elResultadoEsperado = 0;

            losDatos = new DatosSaldoColones();
            losDatos.valoracionEnColones = UnaListaSinValoraciones();
            losDatos.valoracionUDESEnCuenta = UnaListaSinValoraciones();
            losDatos.valoracionUDESNoAnotadosEnCuenta = UnaListaSinValoraciones();
            elResultadoObtenido = new SaldoEnColones(losDatos).ComoNumero();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod]
        public void SaldoEnColones_ComoNumero_UnISIN()
        {
            elResultadoEsperado = 2289920;

            losDatos = new DatosSaldoColones();

            losDatos.valoracionEnColones = UnaValoracionEnColones();
            losDatos.valoracionUDESEnCuenta = UnaListaSinValoraciones();
            losDatos.valoracionUDESNoAnotadosEnCuenta = UnaListaSinValoraciones();
            elResultadoObtenido = new SaldoEnColones(losDatos).ComoNumero();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod]
        public void SaldoEnColones_ComoNumero_DosISIN()
        {
            elResultadoEsperado = 4579840;

            losDatos = new DatosSaldoColones();

            losDatos.valoracionEnColones = DosValoracionesEnColones();
            losDatos.valoracionUDESEnCuenta = UnaListaSinValoraciones();
            losDatos.valoracionUDESNoAnotadosEnCuenta = UnaListaSinValoraciones();
            elResultadoObtenido = new SaldoEnColones(losDatos).ComoNumero();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod]
        public void SaldoEnColones_UDESAnotados_ComoNumero_UnISIN()
        {
            elResultadoEsperado = 480000;

            losDatos = new DatosSaldoColones();

            losDatos.valoracionEnColones = UnaListaSinValoraciones();
            losDatos.valoracionUDESEnCuenta = UnaValoracionEnUDESAnotadosEnCuenta();
            losDatos.valoracionUDESNoAnotadosEnCuenta = UnaListaSinValoraciones();
            elResultadoObtenido = new SaldoEnColones(losDatos).ComoNumero();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod]
        public void SaldoEnColones_UDESAnotados_ComoNumero_DosISIN()
        {
            elResultadoEsperado = 960000;

            losDatos = new DatosSaldoColones();

            losDatos.valoracionEnColones = UnaListaSinValoraciones();
            losDatos.valoracionUDESEnCuenta = DosValoracionesEnUDESAnotadosEnCuenta();
            losDatos.valoracionUDESNoAnotadosEnCuenta = UnaListaSinValoraciones();
            elResultadoObtenido = new SaldoEnColones(losDatos).ComoNumero();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod]
        public void SaldoEnColones_UDESNoAnotados_ComoNumero_UnISIN()
        {
            elResultadoEsperado = 640;

            losDatos = new DatosSaldoColones();

            losDatos.valoracionEnColones = UnaListaSinValoraciones();
            losDatos.valoracionUDESEnCuenta = UnaListaSinValoraciones();
            losDatos.valoracionUDESNoAnotadosEnCuenta = UnaValoracionEnUDESNoAnotadosEnCuenta();
            elResultadoObtenido = new SaldoEnColones(losDatos).ComoNumero();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod]
        public void SaldoEnColones_UDESNoAnotados_ComoNumero_DosISIN()
        {
            elResultadoEsperado = 1280;

            losDatos = new DatosSaldoColones();

            losDatos.valoracionEnColones = UnaListaSinValoraciones();
            losDatos.valoracionUDESEnCuenta = UnaListaSinValoraciones();
            losDatos.valoracionUDESNoAnotadosEnCuenta = DosValoracionesEnUDESNoAnotadosEnCuenta();
            elResultadoObtenido = new SaldoEnColones(losDatos).ComoNumero();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }
    }
}
