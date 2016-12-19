using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algoritmos.CS.Garantias.Negocio.ValoracionesPorISIN.ConPolimorfismo;

namespace ConInversionDeDependencias
{
   public class SaldoEnColones
    {
        List<ValoracionPorISIN> valoracionEnColones;
        List<ValoracionPorISIN> valoracionUDESEnCuenta;
        List<ValoracionPorISIN> valoracionUDESNoAnotadosEnCuenta;

        public SaldoEnColones(DatosSaldoColones losDatos)
        {
            valoracionEnColones = losDatos.valoracionEnColones;
            valoracionUDESEnCuenta = losDatos.valoracionUDESEnCuenta;
            valoracionUDESNoAnotadosEnCuenta = losDatos.valoracionUDESNoAnotadosEnCuenta;
        }

        public decimal ComoNumero()
        {
            decimal saldoEnColones = 0;
            foreach (ValoracionPorISIN unaValoracion in valoracionEnColones)
            {
                saldoEnColones += unaValoracion.AporteDeGarantia;
            }

            foreach (ValoracionPorISIN unaValoracion in valoracionUDESEnCuenta)
            {
                saldoEnColones += unaValoracion.AporteDeGarantia;
            }

            foreach (ValoracionPorISIN unaValoracion in valoracionUDESNoAnotadosEnCuenta)
            {
                saldoEnColones += unaValoracion.AporteDeGarantia;
            }

            return saldoEnColones;

        }
    }
}
