using Algoritmos.CS.Garantias.Negocio.ValoracionesPorISIN.ConPolimorfismo;
using System;
using System.Collections.Generic;

namespace ConParameterObject
{
    public class ValoracionPorEntidad
    {
        DatosSaldoColones datosSaldoEnColones;
        DatosSaldoDolares datosSaldoDolares;

        public ValoracionPorEntidad()
        {
            datosSaldoEnColones = new DatosSaldoColones();
            datosSaldoDolares = new DatosSaldoDolares();
        }

        public ValoracionDeLosISINDeUnaEntidad GenereLaValoracion(DatosDeLaValoracionPorEntidad losDatos)
        {
            List<ValoracionPorISIN> valoracionEnColones = new ValoracionISINColones(losDatos).ComoLista();
            ValoracionDeLosISINDeUnaEntidad laValoracion = new ValoracionDeLosISINDeUnaEntidad();
            laValoracion.ValoracionesDeLosISINEnColones = valoracionEnColones;
            datosSaldoEnColones.valoracionEnColones = valoracionEnColones;


            List<ValoracionPorISIN> valoracionEnDolares = new ValoracionISINDolares(losDatos).ComoLista();
            laValoracion.ValoracionesDeLosISINEnDolares = valoracionEnDolares;
            datosSaldoDolares.valoracionEnDolares = valoracionEnDolares;


            List<ValoracionPorISIN> valoracionISINAnotadoCuenta = new ValoracionISINAnotadoEnCuenta(losDatos).ComoLista();
            laValoracion.ValoracionesDeLosISINEnUDESAnotadosEnCuenta = valoracionISINAnotadoCuenta;
            datosSaldoEnColones.valoracionEnColones = valoracionEnColones;


            List<ValoracionPorISIN> valoracionISINNoAnotadoCuenta = new ValoracionISINNoAnotadoEnCuenta(losDatos).ComoLista();
            laValoracion.ValoracionesDeLosISINEnUDESNoAnotadosEnCuenta = valoracionISINNoAnotadoCuenta;
            datosSaldoEnColones.valoracionEnColones = valoracionEnColones;

            decimal saldoEnColones = new SaldoEnColones(datosSaldoEnColones).ComoNumero();
            laValoracion.SaldoEnColones = saldoEnColones;

            decimal saldoEnDolares = new SaldoEnDolares(datosSaldoDolares).ComoNumero();
            laValoracion.SaldoEnDolares = saldoEnDolares;

            return laValoracion;
        }
    }
}