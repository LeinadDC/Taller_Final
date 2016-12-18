using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algoritmos.CS.Garantias.Negocio.ValoracionesPorISIN.ConPolimorfismo;

namespace ConParameterObject
{
    public class ValoracionISINAnotadoEnCuenta
    {
        List<ISIN> listaDeISINEnUDESAnotadosEnCuenta;
        DateTime fechaActual;
        decimal tipoDeCambioDeUDESDeAyer;
        decimal tipoDeCambioDeUDESDeHoy;


        public ValoracionISINAnotadoEnCuenta(DatosDeLaValoracionPorEntidad losDatos)
        {
            listaDeISINEnUDESAnotadosEnCuenta = losDatos.listaDeISINEnUDESAnotadosEnCuenta;
            fechaActual = losDatos.fechaActual;
            tipoDeCambioDeUDESDeAyer = losDatos.tipoDeCambioDeUDESDeAyer;
            tipoDeCambioDeUDESDeHoy = losDatos.tipoDeCambioDeUDESDeHoy;
        }

        public List<ValoracionPorISIN> ComoLista()
        { 
            // Genero las valoraciones en UDES anotados en cuenta
            List<ValoracionPorISIN> lasValoracionesEnUDESAnotados = new List<ValoracionPorISIN>();
            foreach (ISIN unISIN in listaDeISINEnUDESAnotadosEnCuenta)
            {
                DatosDeUnISINAnotadoEnCuentaEnUDES losDatos = GenereDatosDeUnISINEnUDESEnCuenta(fechaActual, tipoDeCambioDeUDESDeAyer, tipoDeCambioDeUDESDeHoy, unISIN);

                ValoracionPorISIN laValoracionDelISIN = new ValoracionPorISIN(losDatos);
                lasValoracionesEnUDESAnotados.Add(laValoracionDelISIN);
            }

            return lasValoracionesEnUDESAnotados;
        }

        private static DatosDeUnISINAnotadoEnCuentaEnUDES GenereDatosDeUnISINEnUDESEnCuenta(DateTime fechaActual, decimal tipoDeCambioDeUDESDeAyer, decimal tipoDeCambioDeUDESDeHoy, ISIN unISIN)
        {
            DatosDeUnISINAnotadoEnCuentaEnUDES losDatos = new DatosDeUnISINAnotadoEnCuentaEnUDES();
            losDatos.DiasMinimosAlVencimientoDelEmisor = unISIN.diasMinimosAlVencimientoDelEmisor;
            losDatos.FechaActual = fechaActual;
            losDatos.FechaDeVencimientoDelValorOficial = unISIN.fechaDeVencimientoDelValorOficial;
            losDatos.MontoNominalDelSaldo = unISIN.montoNominalDelSaldo;
            losDatos.NumeroISIN = unISIN.NumeroISIN;
            losDatos.PorcentajeCobertura = unISIN.porcentajeCobertura;
            losDatos.PrecioLimpioDelVectorDePrecios = unISIN.precioLimpioDelVectorDePrecios;
            losDatos.TipoDeCambioDeUDESDeAyer = tipoDeCambioDeUDESDeAyer;
            losDatos.TipoDeCambioDeUDESDeHoy = tipoDeCambioDeUDESDeHoy;
            return losDatos;
        }
    }
}

