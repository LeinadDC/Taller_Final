using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConInversionDeDependencias;

namespace TallerFinal.Negocio.Dependencia
{
    public class DatosDeISINPorEntidadDependencia : DatosDeLaValoracionPorEntidad
    {
        public override DateTime fechaActual
        {
            get
            {
                return DateTime.Now;
            }
        }

        public override decimal tipoDeCambioDeUDESDeAyer
        {
            get
            {
                Console.WriteLine("Introduzca el tipo de cambio UDES de ayer: ");
                return Console.Read();
            }
        }

        public override decimal tipoDeCambioDeUDESDeHoy
        {
            get
            {
                Console.WriteLine("Introduzca el tipo de cambio UDES de hoy: ");
                return Console.Read();
            }
        }
    }
}
