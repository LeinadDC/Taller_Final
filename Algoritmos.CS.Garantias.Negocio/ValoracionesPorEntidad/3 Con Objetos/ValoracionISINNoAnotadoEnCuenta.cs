using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algoritmos.CS.Garantias.Negocio.ValoracionesPorISIN.ConPolimorfismo;

namespace ConObjetos
{
    public class ValoracionISINNoAnotadoEnCuenta
    {
        List<ISIN> listaDeISINEnUDESNoAnotadosEnCuenta;
        DateTime fechaActual;

        public ValoracionISINNoAnotadoEnCuenta(List<ISIN> listaDeISINEnUDESNoAnotadosEnCuenta, DateTime fechaActual)
        {
            this.listaDeISINEnUDESNoAnotadosEnCuenta = listaDeISINEnUDESNoAnotadosEnCuenta;
            this.fechaActual = fechaActual;
        }

        public List<ValoracionPorISIN> ComoLista()
        {
            // Genero las valoraciones en UDES no anotados en cuenta
            List<ValoracionPorISIN> lasValoracionesEnUDESNoAnotados = new List<ValoracionPorISIN>();
            foreach (ISIN unISIN in listaDeISINEnUDESNoAnotadosEnCuenta)
            {
                DatosDeUnISINNoAnotadoEnCuentaEnUDES losDatos = GenereDatosDeUnISINNoAnotado(fechaActual, unISIN);

                ValoracionPorISIN laValoracionDelISIN = new ValoracionPorISIN(losDatos);
                lasValoracionesEnUDESNoAnotados.Add(laValoracionDelISIN);
            }

            return lasValoracionesEnUDESNoAnotados;
        }

        private DatosDeUnISINNoAnotadoEnCuentaEnUDES GenereDatosDeUnISINNoAnotado(DateTime fechaActual, ISIN unISIN)
        {
            DatosDeUnISINNoAnotadoEnCuentaEnUDES losDatos = new DatosDeUnISINNoAnotadoEnCuentaEnUDES();
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


