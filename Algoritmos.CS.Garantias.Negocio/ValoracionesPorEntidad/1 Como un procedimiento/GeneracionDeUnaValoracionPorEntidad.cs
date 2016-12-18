using Algoritmos.CS.Garantias.Negocio.ValoracionesPorISIN.ConPolimorfismo;
using System;
using System.Collections.Generic;

namespace ComoProcedimiento
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

            // Genero las valoraciones en colones
            List<ValoracionPorISIN> lasValoracionesEnColones = new List<ValoracionPorISIN>();
            foreach (ISIN unISIN in listaDeISINEnColones)
            {
                DatosDeUnISINEnColones losDatos = new DatosDeUnISINEnColones();
                losDatos.DiasMinimosAlVencimientoDelEmisor = unISIN.diasMinimosAlVencimientoDelEmisor;
                losDatos.FechaActual = fechaActual;
                losDatos.FechaDeVencimientoDelValorOficial = unISIN.fechaDeVencimientoDelValorOficial;
                losDatos.MontoNominalDelSaldo = unISIN.montoNominalDelSaldo;
                losDatos.NumeroISIN = unISIN.NumeroISIN;
                losDatos.PorcentajeCobertura = unISIN.porcentajeCobertura;
                losDatos.PrecioLimpioDelVectorDePrecios = unISIN.precioLimpioDelVectorDePrecios;

                ValoracionPorISIN laValoracionDelISIN = new ValoracionPorISIN(losDatos);
                lasValoracionesEnColones.Add(laValoracionDelISIN);
            }

            ValoracionDeLosISINDeUnaEntidad laValoracion = new ValoracionDeLosISINDeUnaEntidad();
            laValoracion.ValoracionesDeLosISINEnColones = lasValoracionesEnColones;

            // Genero el saldo en colones de acuerdo a los ISIN en colones
            decimal saldoEnColones = 0;
            foreach (ValoracionPorISIN unaValoracion in lasValoracionesEnColones)
            {
                saldoEnColones += unaValoracion.AporteDeGarantia;
            }

            // Genero las valoraciones en dolares
            List<ValoracionPorISIN> lasValoracionesEnDolares = new List<ValoracionPorISIN>();
            foreach (ISIN unISIN in listaDeISINEnDolares)
            {
                DatosDeUnISINEnDolares losDatos = new DatosDeUnISINEnDolares();
                losDatos.DiasMinimosAlVencimientoDelEmisor = unISIN.diasMinimosAlVencimientoDelEmisor;
                losDatos.FechaActual = fechaActual;
                losDatos.FechaDeVencimientoDelValorOficial = unISIN.fechaDeVencimientoDelValorOficial;
                losDatos.MontoNominalDelSaldo = unISIN.montoNominalDelSaldo;
                losDatos.NumeroISIN = unISIN.NumeroISIN;
                losDatos.PorcentajeCobertura = unISIN.porcentajeCobertura;
                losDatos.PrecioLimpioDelVectorDePrecios = unISIN.precioLimpioDelVectorDePrecios;

                ValoracionPorISIN laValoracionDelISIN = new ValoracionPorISIN(losDatos);
                lasValoracionesEnDolares.Add(laValoracionDelISIN);
            }

            laValoracion.ValoracionesDeLosISINEnDolares = lasValoracionesEnDolares;

            // Genero el saldo en dolares
            decimal saldoEnDolares = 0;
            foreach (ValoracionPorISIN unaValoracion in lasValoracionesEnDolares)
            {
                saldoEnDolares += unaValoracion.AporteDeGarantia;
            }
            laValoracion.SaldoEnDolares = saldoEnDolares;

            // Genero las valoraciones en UDES anotados en cuenta
            List<ValoracionPorISIN> lasValoracionesEnUDESAnotados = new List<ValoracionPorISIN>();
            foreach (ISIN unISIN in listaDeISINEnUDESAnotadosEnCuenta)
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

                ValoracionPorISIN laValoracionDelISIN = new ValoracionPorISIN(losDatos);
                lasValoracionesEnUDESAnotados.Add(laValoracionDelISIN);
            }

            laValoracion.ValoracionesDeLosISINEnUDESAnotadosEnCuenta = lasValoracionesEnUDESAnotados;

            // Incremento el saldo en colones con el de UDES anotados en cuenta
            foreach (ValoracionPorISIN unaValoracion in lasValoracionesEnUDESAnotados)
            {
                saldoEnColones += unaValoracion.AporteDeGarantia;
            }

            // Genero las valoraciones en UDES no anotados en cuenta
            List<ValoracionPorISIN> lasValoracionesEnUDESNoAnotados = new List<ValoracionPorISIN>();
            foreach (ISIN unISIN in listaDeISINEnUDESNoAnotadosEnCuenta)
            {
                DatosDeUnISINNoAnotadoEnCuentaEnUDES losDatos = new DatosDeUnISINNoAnotadoEnCuentaEnUDES();
                losDatos.DiasMinimosAlVencimientoDelEmisor = unISIN.diasMinimosAlVencimientoDelEmisor;
                losDatos.FechaActual = fechaActual;
                losDatos.FechaDeVencimientoDelValorOficial = unISIN.fechaDeVencimientoDelValorOficial;
                losDatos.MontoNominalDelSaldo = unISIN.montoNominalDelSaldo;
                losDatos.NumeroISIN = unISIN.NumeroISIN;
                losDatos.PorcentajeCobertura = unISIN.porcentajeCobertura;
                losDatos.PrecioLimpioDelVectorDePrecios = unISIN.precioLimpioDelVectorDePrecios;

                ValoracionPorISIN laValoracionDelISIN = new ValoracionPorISIN(losDatos);
                lasValoracionesEnUDESNoAnotados.Add(laValoracionDelISIN);
            }

            laValoracion.ValoracionesDeLosISINEnUDESNoAnotadosEnCuenta = lasValoracionesEnUDESNoAnotados;

            // Incremento el saldo en colones con el de UDES no anotados en cuenta
            foreach (ValoracionPorISIN unaValoracion in lasValoracionesEnUDESNoAnotados)
            {
                saldoEnColones += unaValoracion.AporteDeGarantia;
            }
            laValoracion.SaldoEnColones = saldoEnColones;

            return laValoracion;
        }
    }
}