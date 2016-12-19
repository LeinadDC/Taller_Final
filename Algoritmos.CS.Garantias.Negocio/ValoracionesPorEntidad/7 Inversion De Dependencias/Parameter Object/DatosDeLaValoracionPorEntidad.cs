using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algoritmos.CS.Garantias.Negocio.ValoracionesPorISIN.ConPolimorfismo;

namespace ConInversionDeDependencias
{
    public abstract class DatosDeLaValoracionPorEntidad
    {
        public List<ISIN> listaDeISINEnColones { get; set; }
        public List<ISIN> listaDeISINEnDolares { get; set; }
        public List<ISIN> listaDeISINEnUDESAnotadosEnCuenta { get; set; }
        public List<ISIN> listaDeISINEnUDESNoAnotadosEnCuenta { get; set; }
        public abstract DateTime fechaActual { get; }
        public abstract decimal tipoDeCambioDeUDESDeAyer { get;}
        public abstract decimal tipoDeCambioDeUDESDeHoy { get; }
    }
}
