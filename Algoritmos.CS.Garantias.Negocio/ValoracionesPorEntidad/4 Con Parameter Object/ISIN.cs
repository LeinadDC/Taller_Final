using System;

namespace ConParameterObject
{
    public class ISIN
    {
        public DateTime fechaDeVencimientoDelValorOficial { get; set; }
        public int diasMinimosAlVencimientoDelEmisor { get; set; }
        public decimal porcentajeCobertura { get; set; }
        public decimal precioLimpioDelVectorDePrecios { get; set; }
        public decimal montoNominalDelSaldo { get; set; }
        public string NumeroISIN { get; set; }
    }
}