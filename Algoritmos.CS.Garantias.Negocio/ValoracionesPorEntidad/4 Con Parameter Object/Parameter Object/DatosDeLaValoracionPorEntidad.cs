using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algoritmos.CS.Garantias.Negocio.ValoracionesPorISIN.ConPolimorfismo;

namespace ConParameterObject
{
    public class DatosDeLaValoracionPorEntidad
    {
        public List<ISIN> listaDeISINEnColones { get; set; }
        public List<ISIN> listaDeISINEnDolares { get; set; }
        public List<ISIN> listaDeISINEnUDESAnotadosEnCuenta { get; set; }
        public List<ISIN> listaDeISINEnUDESNoAnotadosEnCuenta { get; set; }
        public DateTime fechaActual { get; set; }
        public decimal tipoDeCambioDeUDESDeAyer { get; set; }
        public decimal tipoDeCambioDeUDESDeHoy { get; set; }
    }
}
