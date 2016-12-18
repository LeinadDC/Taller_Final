using Algoritmos.CS.Garantias.Negocio.ValoracionesPorISIN.ConPolimorfismo;
using System;
using System.Collections.Generic;

namespace ConObjetos
{
    public class ValoracionPorEntidad
    {
        List<ISIN> listaDeISINEnColones;
        List<ISIN> listaDeISINEnDolares;
        List<ISIN> listaDeISINEnUDESAnotadosEnCuenta;
        List<ISIN> listaDeISINEnUDESNoAnotadosEnCuenta;
        DateTime fechaActual;
        decimal tipoDeCambioDeUDESDeAyer;
        decimal tipoDeCambioDeUDESDeHoy;

        public ValoracionPorEntidad(List<ISIN> listaDeISINEnColones,
            List<ISIN> listaDeISINEnDolares,
            List<ISIN> listaDeISINEnUDESAnotadosEnCuenta,
            List<ISIN> listaDeISINEnUDESNoAnotadosEnCuenta,
            DateTime fechaActual,
            decimal tipoDeCambioDeUDESDeAyer,
            decimal tipoDeCambioDeUDESDeHoy)
        {
            this.listaDeISINEnColones = listaDeISINEnColones;
            this.listaDeISINEnDolares = listaDeISINEnDolares;
            this.listaDeISINEnUDESAnotadosEnCuenta = listaDeISINEnUDESAnotadosEnCuenta;
            this.listaDeISINEnUDESNoAnotadosEnCuenta = listaDeISINEnUDESNoAnotadosEnCuenta;
            this.fechaActual = fechaActual;
            this.tipoDeCambioDeUDESDeAyer = tipoDeCambioDeUDESDeAyer;
            this.tipoDeCambioDeUDESDeHoy = tipoDeCambioDeUDESDeHoy;

        }

        public ValoracionDeLosISINDeUnaEntidad GenereLaValoracion()
        {
            List<ValoracionPorISIN> lasValoracionesEnColones = new ValoracionISINColones(listaDeISINEnColones, fechaActual).ComoLista();
            ValoracionDeLosISINDeUnaEntidad laValoracion = new ValoracionDeLosISINDeUnaEntidad();
            laValoracion.ValoracionesDeLosISINEnColones = lasValoracionesEnColones;


            List<ValoracionPorISIN> lasValoracionesEnDolares = new ValoracionISINDolares(listaDeISINEnDolares, fechaActual).ComoLista();
            laValoracion.ValoracionesDeLosISINEnDolares = lasValoracionesEnDolares;


            List<ValoracionPorISIN> lasValoracionesEnUDESAnotados = new ValoracionISINAnotadoEnCuenta(listaDeISINEnUDESAnotadosEnCuenta, fechaActual, tipoDeCambioDeUDESDeAyer, tipoDeCambioDeUDESDeHoy).ComoLista();
            laValoracion.ValoracionesDeLosISINEnUDESAnotadosEnCuenta = lasValoracionesEnUDESAnotados;


            List<ValoracionPorISIN> lasValoracionesEnUDESNoAnotados = new ValoracionISINNoAnotadoEnCuenta(listaDeISINEnUDESNoAnotadosEnCuenta, fechaActual).ComoLista();
            laValoracion.ValoracionesDeLosISINEnUDESNoAnotadosEnCuenta = lasValoracionesEnUDESNoAnotados;

            decimal saldoEnColones = new SaldoEnColones(lasValoracionesEnColones, lasValoracionesEnUDESAnotados, lasValoracionesEnUDESNoAnotados).ComoNumero();
            laValoracion.SaldoEnColones = saldoEnColones;

            decimal saldoEnDolares = new SaldoEnDolares(lasValoracionesEnDolares).ComoNumero();
            laValoracion.SaldoEnDolares = saldoEnDolares;

            return laValoracion;
        }
    }
}