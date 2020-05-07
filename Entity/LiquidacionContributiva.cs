using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class LiquidacionContributiva : Liquidacion
    {
        public LiquidacionContributiva(double salario) : base (salario)
        {
            TipoAfiliacion = "contributiva";
        }
        public override void CalcularTarifa()
        {
            if (Salario < (980000 * 2))
            {
                Tarifa= 0.15;
             }
            else if ((Salario >= (980000 * 2)) && (Salario <= (980000 * 5)))
            {
                Tarifa = 0.2;

            }
            else
            {
                Tarifa = 0.25;
            }
            }

        public override void CalcularTope()
        {
            if (Salario < (980000 * 2))
            {
                Tope =250000;
            }
            else if ((Salario >= (980000 * 2)) && (Salario <= (980000 * 5)))
            {
                Tope = 900000;

            }
            else
            {
                Tope = 1500000;
            }
        }
    }
}
