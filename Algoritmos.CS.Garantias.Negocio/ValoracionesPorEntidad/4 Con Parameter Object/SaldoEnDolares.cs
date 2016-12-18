using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algoritmos.CS.Garantias.Negocio.ValoracionesPorISIN.ConPolimorfismo;

namespace ConParameterObject
{
    public class SaldoEnDolares
    {
        List<ValoracionPorISIN> valoracionEnDolares;

        public SaldoEnDolares(DatosSaldoDolares losDatos)
        {
            valoracionEnDolares = losDatos.valoracionEnDolares;
        }
    
        public decimal ComoNumero()
        {
            decimal saldoEnDolares = 0;
            // Genero el saldo en dolares
            foreach (ValoracionPorISIN unaValoracion in valoracionEnDolares)
            {
                saldoEnDolares += unaValoracion.AporteDeGarantia;
            }

            return saldoEnDolares;
        }
    }
}
