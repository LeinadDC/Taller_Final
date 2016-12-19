using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algoritmos.CS.Garantias.Negocio.ValoracionesPorISIN.ConPolimorfismo;

namespace ConInversionDeDependencias
{
    public class DatosSaldoColones
    {
        public List<ValoracionPorISIN> valoracionEnColones { get; set; }
        public List<ValoracionPorISIN> valoracionUDESEnCuenta { get; set; }
        public List<ValoracionPorISIN> valoracionUDESNoAnotadosEnCuenta { get; set; }
    }
}
