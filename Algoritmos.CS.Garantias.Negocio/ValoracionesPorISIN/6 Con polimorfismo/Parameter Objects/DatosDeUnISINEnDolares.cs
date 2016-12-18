namespace Algoritmos.CS.Garantias.Negocio.ValoracionesPorISIN.ConPolimorfismo
{
    public class DatosDeUnISINEnDolares : DatosDeLaValoracionPorISIN
    {
        public override decimal MontoConvertido
        {
            get
            {
                return MontoNominalDelSaldo;
            }
        }
    }
}