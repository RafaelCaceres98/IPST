using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class LiquidacionSubsidada : Liquidacion
    {
        public LiquidacionSubsidada(double salario) : base (salario)
        {
            TipoAfiliacion = "subsidiada";
        }
        public override void CalcularTarifa()
        {
            Tarifa = 0.05;
        }

        public override void CalcularTope()
        {
            Tope= 200000;
        }
    }
}
