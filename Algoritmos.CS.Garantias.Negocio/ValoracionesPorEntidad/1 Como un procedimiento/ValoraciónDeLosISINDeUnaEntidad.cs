using Algoritmos.CS.Garantias.Negocio.ValoracionesPorISIN.ConPolimorfismo;
using System.Collections.Generic;

namespace ComoProcedimiento
{
    public class ValoracionDeLosISINDeUnaEntidad
    {
        public decimal SaldoEnColones { get; set; }
        public decimal SaldoEnDolares { get; set; }
        public List<ValoracionPorISIN> ValoracionesDeLosISINEnColones { get; set; }
        public List<ValoracionPorISIN> ValoracionesDeLosISINEnDolares { get; set; }
        public List<ValoracionPorISIN> ValoracionesDeLosISINEnUDESAnotadosEnCuenta { get; set; }
        public List<ValoracionPorISIN> ValoracionesDeLosISINEnUDESNoAnotadosEnCuenta { get; set; }
    }
}