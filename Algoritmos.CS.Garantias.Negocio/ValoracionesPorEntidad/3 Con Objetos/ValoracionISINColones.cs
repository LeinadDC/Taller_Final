using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algoritmos.CS.Garantias.Negocio.ValoracionesPorISIN.ConPolimorfismo;

namespace ConObjetos
{
    public class ValoracionISINColones
    {
        List<ISIN> listaDeISINEnColones;
        DateTime fechaActual;

        public ValoracionISINColones(List<ISIN> listaDeISINEnColones, DateTime fechaActual)
        {
            this.listaDeISINEnColones = listaDeISINEnColones;
            this.fechaActual = fechaActual;
        }

        public List<ValoracionPorISIN> ComoLista()
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
    }
}