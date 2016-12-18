using Algoritmos.CS.Garantias.Negocio.ValoracionesPorISIN.ConPolimorfismo;
using System;
using System.Collections.Generic;

namespace ConFunciones
{
    public static class GeneracionDeUnaValoracionPorEntidad
    {
        public static ValoracionDeLosISINDeUnaEntidad GenereLaValoracion(
            List<ISIN> listaDeISINEnColones,
            List<ISIN> listaDeISINEnDolares,
            List<ISIN> listaDeISINEnUDESAnotadosEnCuenta,
            List<ISIN> listaDeISINEnUDESNoAnotadosEnCuenta,
            DateTime fechaActual,
            decimal tipoDeCambioDeUDESDeAyer,
            decimal tipoDeCambioDeUDESDeHoy)
        {
            ValoracionDeLosISINDeUnaEntidad laValoracion = new ValoracionDeLosISINDeUnaEntidad();

            List<ValoracionPorISIN> lasValoracionesEnColones = GenereListaValoracionesEnColones(listaDeISINEnColones, fechaActual);
            laValoracion.ValoracionesDeLosISINEnColones = lasValoracionesEnColones;

            List<ValoracionPorISIN> lasValoracionesEnDolares = GenereListaValoracionesEnDolares(listaDeISINEnDolares, fechaActual);
            laValoracion.ValoracionesDeLosISINEnDolares = lasValoracionesEnDolares;

            List<ValoracionPorISIN> lasValoracionesEnUDESAnotados = GenereLaListaDeValoracionesEnUDESAnotados(listaDeISINEnUDESAnotadosEnCuenta, fechaActual, tipoDeCambioDeUDESDeAyer, tipoDeCambioDeUDESDeHoy);
            laValoracion.ValoracionesDeLosISINEnUDESAnotadosEnCuenta = lasValoracionesEnUDESAnotados;

            List<ValoracionPorISIN> lasValoracionesEnUDESNoAnotados = GenereLaListaDeValoracionesEnUDESNoAnotados(listaDeISINEnUDESNoAnotadosEnCuenta, fechaActual);
            laValoracion.ValoracionesDeLosISINEnUDESNoAnotadosEnCuenta = lasValoracionesEnUDESNoAnotados;

            decimal saldoEnDolares = GenereSaldoEnDolares(lasValoracionesEnDolares);
            laValoracion.SaldoEnDolares = saldoEnDolares;
        
            decimal saldoEnColones = GenereSaldoEnColones(lasValoracionesEnColones,lasValoracionesEnUDESAnotados,lasValoracionesEnUDESNoAnotados);
            laValoracion.SaldoEnColones = saldoEnColones;

            return laValoracion;
        }

        private static List<ValoracionPorISIN> GenereListaValoracionesEnColones(List<ISIN> listaDeISINEnColones, DateTime fechaActual)
        {
            // Genero las valoraciones en colones
            List<ValoracionPorISIN> lasValoracionesEnColones = new List<ValoracionPorISIN>();
            foreach (ISIN unISIN in listaDeISINEnColones)
            {
                DatosDeUnISINEnColones losDatos = GenereDatosDeUnISINEnColones(fechaActual, unISIN);

                ValoracionPorISIN laValoracionDelISIN = new ValoracionPorISIN(losDatos);
                lasValoracionesEnColones.Add(laValoracionDelISIN);
            }

            return lasValoracionesEnColones;
        }

        private static DatosDeUnISINEnColones GenereDatosDeUnISINEnColones(DateTime fechaActual, ISIN unISIN)
        {
            DatosDeUnISINEnColones losDatos = new DatosDeUnISINEnColones();
            losDatos.DiasMinimosAlVencimientoDelEmisor = unISIN.diasMinimosAlVencimientoDelEmisor;
            losDatos.FechaActual = fechaActual;
            losDatos.FechaDeVencimientoDelValorOficial = unISIN.fechaDeVencimientoDelValorOficial;
            losDatos.MontoNominalDelSaldo = unISIN.montoNominalDelSaldo;
            losDatos.NumeroISIN = unISIN.NumeroISIN;
            losDatos.PorcentajeCobertura = unISIN.porcentajeCobertura;
            losDatos.PrecioLimpioDelVectorDePrecios = unISIN.precioLimpioDelVectorDePrecios;
            return losDatos;
        }

        private static List<ValoracionPorISIN> GenereListaValoracionesEnDolares(List<ISIN> listaDeISINEnDolares, DateTime fechaActual)
        {

            // Genero las valoraciones en dolares
            List<ValoracionPorISIN> lasValoracionesEnDolares = new List<ValoracionPorISIN>();
            foreach (ISIN unISIN in listaDeISINEnDolares)
            {
                DatosDeUnISINEnDolares losDatos = GenereDatosDeUnISINEnDolares(fechaActual, unISIN);

                ValoracionPorISIN laValoracionDelISIN = new ValoracionPorISIN(losDatos);
                lasValoracionesEnDolares.Add(laValoracionDelISIN);
            }

            return lasValoracionesEnDolares;
        }

        private static DatosDeUnISINEnDolares GenereDatosDeUnISINEnDolares(DateTime fechaActual, ISIN unISIN)
        {
            DatosDeUnISINEnDolares losDatos = new DatosDeUnISINEnDolares();
            losDatos.DiasMinimosAlVencimientoDelEmisor = unISIN.diasMinimosAlVencimientoDelEmisor;
            losDatos.FechaActual = fechaActual;
            losDatos.FechaDeVencimientoDelValorOficial = unISIN.fechaDeVencimientoDelValorOficial;
            losDatos.MontoNominalDelSaldo = unISIN.montoNominalDelSaldo;
            losDatos.NumeroISIN = unISIN.NumeroISIN;
            losDatos.PorcentajeCobertura = unISIN.porcentajeCobertura;
            losDatos.PrecioLimpioDelVectorDePrecios = unISIN.precioLimpioDelVectorDePrecios;
            return losDatos;
        }

        private static List<ValoracionPorISIN> GenereLaListaDeValoracionesEnUDESAnotados(List<ISIN> listaDeISINEnUDESAnotadosEnCuenta, DateTime fechaActual, decimal tipoDeCambioDeUDESDeAyer, decimal tipoDeCambioDeUDESDeHoy)
        {

            // Genero las valoraciones en UDES anotados en cuenta
            List<ValoracionPorISIN> lasValoracionesEnUDESAnotados = new List<ValoracionPorISIN>();
            foreach (ISIN unISIN in listaDeISINEnUDESAnotadosEnCuenta)
            {
                DatosDeUnISINAnotadoEnCuentaEnUDES losDatos = GenereDatosDeUnISINEnUDESEnCuenta(fechaActual, tipoDeCambioDeUDESDeAyer, tipoDeCambioDeUDESDeHoy, unISIN);

                ValoracionPorISIN laValoracionDelISIN = new ValoracionPorISIN(losDatos);
                lasValoracionesEnUDESAnotados.Add(laValoracionDelISIN);
            }

            return lasValoracionesEnUDESAnotados;
        }

        private static DatosDeUnISINAnotadoEnCuentaEnUDES GenereDatosDeUnISINEnUDESEnCuenta(DateTime fechaActual, decimal tipoDeCambioDeUDESDeAyer, decimal tipoDeCambioDeUDESDeHoy, ISIN unISIN)
        {
            DatosDeUnISINAnotadoEnCuentaEnUDES losDatos = new DatosDeUnISINAnotadoEnCuentaEnUDES();
            losDatos.DiasMinimosAlVencimientoDelEmisor = unISIN.diasMinimosAlVencimientoDelEmisor;
            losDatos.FechaActual = fechaActual;
            losDatos.FechaDeVencimientoDelValorOficial = unISIN.fechaDeVencimientoDelValorOficial;
            losDatos.MontoNominalDelSaldo = unISIN.montoNominalDelSaldo;
            losDatos.NumeroISIN = unISIN.NumeroISIN;
            losDatos.PorcentajeCobertura = unISIN.porcentajeCobertura;
            losDatos.PrecioLimpioDelVectorDePrecios = unISIN.precioLimpioDelVectorDePrecios;
            losDatos.TipoDeCambioDeUDESDeAyer = tipoDeCambioDeUDESDeAyer;
            losDatos.TipoDeCambioDeUDESDeHoy = tipoDeCambioDeUDESDeHoy;
            return losDatos;
        }

        private static List<ValoracionPorISIN> GenereLaListaDeValoracionesEnUDESNoAnotados(List<ISIN> listaDeISINEnUDESNoAnotadosEnCuenta, DateTime fechaActual)
        {
            // Genero las valoraciones en UDES no anotados en cuenta
            List<ValoracionPorISIN> lasValoracionesEnUDESNoAnotados = new List<ValoracionPorISIN>();
            foreach (ISIN unISIN in listaDeISINEnUDESNoAnotadosEnCuenta)
            {
                DatosDeUnISINNoAnotadoEnCuentaEnUDES losDatos = GenereDatosDeUnISINNoAnotado(fechaActual, unISIN);

                ValoracionPorISIN laValoracionDelISIN = new ValoracionPorISIN(losDatos);
                lasValoracionesEnUDESNoAnotados.Add(laValoracionDelISIN);
            }

            return lasValoracionesEnUDESNoAnotados;
        }

        private static DatosDeUnISINNoAnotadoEnCuentaEnUDES GenereDatosDeUnISINNoAnotado(DateTime fechaActual, ISIN unISIN)
        {
            DatosDeUnISINNoAnotadoEnCuentaEnUDES losDatos = new DatosDeUnISINNoAnotadoEnCuentaEnUDES();
            losDatos.DiasMinimosAlVencimientoDelEmisor = unISIN.diasMinimosAlVencimientoDelEmisor;
            losDatos.FechaActual = fechaActual;
            losDatos.FechaDeVencimientoDelValorOficial = unISIN.fechaDeVencimientoDelValorOficial;
            losDatos.MontoNominalDelSaldo = unISIN.montoNominalDelSaldo;
            losDatos.NumeroISIN = unISIN.NumeroISIN;
            losDatos.PorcentajeCobertura = unISIN.porcentajeCobertura;
            losDatos.PrecioLimpioDelVectorDePrecios = unISIN.precioLimpioDelVectorDePrecios;
            return losDatos;
        }

        private static decimal GenereSaldoEnDolares(List<ValoracionPorISIN> lasValoracionesEnDolares)
        {
            // Genero el saldo en dolares
            decimal saldoEnDolares = 0;
            foreach (ValoracionPorISIN unaValoracion in lasValoracionesEnDolares)
            {
                saldoEnDolares += unaValoracion.AporteDeGarantia;
            }

            return saldoEnDolares;
        }

        private static decimal GenereSaldoEnColones(List<ValoracionPorISIN> lasValoracionesEnColones, List<ValoracionPorISIN> lasValoracionesEnUDESAnotados, List<ValoracionPorISIN> lasValoracionesEnUDESNoAnotados)
        {
            /*
             * Confimar si dejarlos así o separados.
             */
            // Genero el saldo en colones de acuerdo a los ISIN en colones
            decimal saldoEnColones = 0;
            foreach (ValoracionPorISIN unaValoracion in lasValoracionesEnColones)
            {
                saldoEnColones += unaValoracion.AporteDeGarantia;
            }

            // Incremento el saldo en colones con el de UDES anotados en cuenta
            foreach (ValoracionPorISIN unaValoracion in lasValoracionesEnUDESAnotados)
            {
                saldoEnColones += unaValoracion.AporteDeGarantia;
            }

            // Incremento el saldo en colones con el de UDES no anotados en cuenta
            foreach (ValoracionPorISIN unaValoracion in lasValoracionesEnUDESNoAnotados)
            {
                saldoEnColones += unaValoracion.AporteDeGarantia;
            }
            return saldoEnColones;

        }

    }
}