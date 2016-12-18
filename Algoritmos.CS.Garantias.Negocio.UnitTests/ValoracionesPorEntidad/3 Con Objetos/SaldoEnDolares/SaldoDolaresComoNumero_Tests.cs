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
    public class SaldoDolaresComoNumero_Tests:EscenariosSaldo
    {
        private decimal elResultadoEsperado;
        private decimal elResultadoObtenido;
        private List<ValoracionPorISIN> listaEnDolares;

        [TestMethod]
        public void SaldoEnDolares_ComoNumero_SinISIN()
        {
            elResultadoEsperado = 0;

            listaEnDolares = UnaListaSinValoraciones();

            elResultadoObtenido = new SaldoEnDolares(listaEnDolares).ComoNumero();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod]
        public void SaldoEnDolares_ComoNumero_UnISIN()
        {
            elResultadoEsperado = 0;

            listaEnDolares = UnaValoracionEnDolares();

            elResultadoObtenido = new SaldoEnDolares(listaEnDolares).ComoNumero();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod]
        public void SaldoEnDolares_ComoNumero_DosISIN()
        {
            elResultadoEsperado = 1280;

            listaEnDolares = DosValoracionesEnDolares();

            elResultadoObtenido = new SaldoEnDolares(listaEnDolares).ComoNumero();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }
    }
}
