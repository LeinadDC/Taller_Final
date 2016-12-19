using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConInversionDeDependencias;

namespace TallerFinal.Negocio.Dependencia
{
    class Program
    {
        static void Main(string[] args)
        {
            DatosDeLaValoracionPorEntidad losDatos = new DatosDeISINPorEntidadDependencia();

            losDatos.listaDeISINEnColones = new List<ISIN>();
            losDatos.listaDeISINEnDolares = new List<ISIN>();
            losDatos.listaDeISINEnUDESAnotadosEnCuenta = new List<ISIN>();
            losDatos.listaDeISINEnUDESNoAnotadosEnCuenta = new List<ISIN>();

            ISIN unISINEnDolares = new ISIN();
            unISINEnDolares.NumeroISIN = "HDA000000000001";
            unISINEnDolares.fechaDeVencimientoDelValorOficial = new DateTime(2016, 6, 6);
            unISINEnDolares.diasMinimosAlVencimientoDelEmisor = 7;
            unISINEnDolares.porcentajeCobertura = 0.8M;
            unISINEnDolares.precioLimpioDelVectorDePrecios = 80;
            unISINEnDolares.montoNominalDelSaldo = 3578000;
            losDatos.listaDeISINEnColones.Add(unISINEnDolares);

            ISIN unISINEnColones = new ISIN();
            unISINEnColones.NumeroISIN = "HDA000000000001";
            unISINEnColones.fechaDeVencimientoDelValorOficial = new DateTime(2016, 6, 6);
            unISINEnColones.diasMinimosAlVencimientoDelEmisor = 7;
            unISINEnColones.porcentajeCobertura = 0.8M;
            unISINEnColones.precioLimpioDelVectorDePrecios = 80;
            unISINEnColones.montoNominalDelSaldo = 3578000;
            losDatos.listaDeISINEnColones.Add(unISINEnColones);

            ISIN unISINUDESAnotados = new ISIN();
            unISINUDESAnotados.NumeroISIN = "HDA000000000001";
            unISINUDESAnotados.fechaDeVencimientoDelValorOficial = new DateTime(2016, 6, 6);
            unISINUDESAnotados.diasMinimosAlVencimientoDelEmisor = 7;
            unISINUDESAnotados.porcentajeCobertura = 0.8M;
            unISINUDESAnotados.precioLimpioDelVectorDePrecios = 80;
            unISINUDESAnotados.montoNominalDelSaldo = 3578000;
            losDatos.listaDeISINEnUDESAnotadosEnCuenta.Add(unISINUDESAnotados);

            ISIN unISINUDESNoAnotados = new ISIN();
            unISINUDESNoAnotados.NumeroISIN = "HDA000000000001";
            unISINUDESNoAnotados.fechaDeVencimientoDelValorOficial = new DateTime(2016, 6, 6);
            unISINUDESNoAnotados.diasMinimosAlVencimientoDelEmisor = 7;
            unISINUDESNoAnotados.porcentajeCobertura = 0.8M;
            unISINUDESNoAnotados.precioLimpioDelVectorDePrecios = 80;
            unISINUDESNoAnotados.montoNominalDelSaldo = 3578000;
            losDatos.listaDeISINEnUDESNoAnotadosEnCuenta.Add(unISINUDESNoAnotados);

            Console.ReadLine();




        }
    }
}
