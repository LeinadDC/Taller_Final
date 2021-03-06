﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algoritmos.CS.Garantias.Negocio.ValoracionesPorISIN.ConPolimorfismo;
using ConParameterObject;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConParameterObject.Tests
{
    [TestClass]
    public class SaldoDolaresComoNumero_Tests : EscenariosDeListasEnDolares
    {
        private decimal elResultadoEsperado;
        private decimal elResultadoObtenido;
        private DatosSaldoDolares losDatos;


        [TestMethod]
        public void SaldoEnDolares_ComoNumero_SinISIN()
        {
            elResultadoEsperado = 0;

            losDatos = new DatosSaldoDolares();
            losDatos.valoracionEnDolares = UnaListaSinValoraciones();
            elResultadoObtenido = new SaldoEnDolares(losDatos).ComoNumero();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod]
        public void SaldoEnDolares_ComoNumero_UnISIN()
        {
            elResultadoEsperado = 0;

            losDatos = new DatosSaldoDolares();
            losDatos.valoracionEnDolares = UnaValoracionEnDolares();
            elResultadoObtenido = new SaldoEnDolares(losDatos).ComoNumero();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod]
        public void SaldoEnDolares_ComoNumero_DosISIN()
        {
            elResultadoEsperado = 1280;

            losDatos = new DatosSaldoDolares();
            losDatos.valoracionEnDolares = DosValoracionesEnDolares();
            elResultadoObtenido = new SaldoEnDolares(losDatos).ComoNumero();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }
    }
}
