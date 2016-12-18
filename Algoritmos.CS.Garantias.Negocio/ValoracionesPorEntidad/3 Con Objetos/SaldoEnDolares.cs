using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algoritmos.CS.Garantias.Negocio.ValoracionesPorISIN.ConPolimorfismo;

namespace ConObjetos
{
    public class SaldoEnDolares
    {
        List<ValoracionPorISIN> lasValoracionesEnDolares;

        public SaldoEnDolares(List<ValoracionPorISIN> lasValoracionesEnDolares)
        {
            this.lasValoracionesEnDolares = lasValoracionesEnDolares;
        }
    
        public decimal ComoNumero()
        {
            decimal saldoEnDolares = 0;
            // Genero el saldo en dolares
            foreach (ValoracionPorISIN unaValoracion in lasValoracionesEnDolares)
            {
                saldoEnDolares += unaValoracion.AporteDeGarantia;
            }

            return saldoEnDolares;
        }
    }
}
