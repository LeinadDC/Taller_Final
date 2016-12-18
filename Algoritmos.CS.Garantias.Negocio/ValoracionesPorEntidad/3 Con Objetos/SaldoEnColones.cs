using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algoritmos.CS.Garantias.Negocio.ValoracionesPorISIN.ConPolimorfismo;

namespace ConObjetos
{
   public class SaldoEnColones
    {
        List<ValoracionPorISIN> lasValoracionesEnColones;
        List<ValoracionPorISIN> lasValoracionesEnUDESAnotados;
        List<ValoracionPorISIN> lasValoracionesEnUDESNoAnotados;

        public SaldoEnColones(List<ValoracionPorISIN> lasValoracionesEnColones, List<ValoracionPorISIN> lasValoracionesEnUDESAnotados, List<ValoracionPorISIN> lasValoracionesEnUDESNoAnotados)
        {
            this.lasValoracionesEnColones = lasValoracionesEnColones;
            this.lasValoracionesEnUDESAnotados = lasValoracionesEnUDESAnotados;
            this.lasValoracionesEnUDESNoAnotados = lasValoracionesEnUDESNoAnotados;
        }

        public decimal ComoNumero()
        {
            decimal saldoEnColones = 0;
            // Genero el saldo en colones de acuerdo a los ISIN en colones
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
