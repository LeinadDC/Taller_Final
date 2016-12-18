using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algoritmos.CS.Garantias.Negocio.ValoracionesPorISIN.ConPolimorfismo;

namespace ConParameterObject
{
    public class ValoracionISINDolares
    {
        List<ISIN> listaDeISINEnDolares;
        DateTime fechaActual;

        public ValoracionISINDolares(DatosDeLaValoracionPorEntidad losDatos)
        {
            listaDeISINEnDolares = losDatos.listaDeISINEnDolares;
            fechaActual = losDatos.fechaActual;
        }

        public List<ValoracionPorISIN> ComoLista()
        {
            // Genero las valoraciones en dolares
            List<ValoracionPorISIN> lasValoracionesEnDolares = new List<ValoracionPorISIN>();
            foreach (ISIN unISIN in listaDeISINEnDolares)
            {
                DatosDeUnISINEnDolares losDatos = GenereDatosDeUnISINEnDolares(fechaActual, unISIN);

                ValoracionPorISIN laValoracionDelISIN = new ValoracionPorISIN(losDatos);
                lasValoracionesEnDolares.Add(laValoracionDelISIN);
            }

            return lasValoracionesEnDolares;

        }

        private static DatosDeUnISINEnDolares GenereDatosDeUnISINEnDolares(DateTime fechaActual, ISIN unISIN)
        {
            DatosDeUnISINEnDolares losDatos = new DatosDeUnISINEnDolares();
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
