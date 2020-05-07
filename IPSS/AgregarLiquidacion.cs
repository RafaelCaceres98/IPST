using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entity;
using BLL;

namespace IPSS
{
    public partial class AgregarLiquidacion : Form
    {
        Liquidacion liquidacion;
        LiquidacionCuotaModeradoraService liquidacionCuotaModeradoraService;
        IList<Liquidacion> listaLiquidaciones;
        public AgregarLiquidacion()
        {
            InitializeComponent();
            liquidacionCuotaModeradoraService = new LiquidacionCuotaModeradoraService();
        }

        private void LiquidacionFecha_ValueChanged(object sender, EventArgs e)
        {

        }

        private void AgregarBtn_Click(object sender, EventArgs e)
        {
            
            liquidacion = liquidacionCuotaModeradoraService.Buscar(IdentificacionTxt.Text);
            if (liquidacion != null)
            {
                MessageBox.Show("Paciente ya se encuentra registrado", "Cuidado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else
            {
                if (tipoBox.SelectedItem.ToString().Equals("CONTRIBUTIVO"))
                {
                    liquidacion = new LiquidacionContributiva(0);
                } else
                {
                    liquidacion = new LiquidacionSubsidada(0);
                }
                listaLiquidaciones = liquidacionCuotaModeradoraService.Leer();
                liquidacion.Nombre = NombreTxt.Text;
                liquidacion.Identificacion = IdentificacionTxt.Text;
                liquidacion.Salario = Convert.ToDouble(SalarioTxt.Text);
                liquidacion.ValorServicio = Convert.ToDouble(ValorServicioTxt.Text);
                liquidacion.NumeroLiquidacion = listaLiquidaciones.Count() + 1;
                liquidacion.CuotaModeradora = liquidacion.CalcularCuotaModeradora();
                liquidacion.FechaSolicitudLiquidacion = LiquidacionFecha.Value.Date;
                MessageBox.Show(liquidacionCuotaModeradoraService.AgregarPaciente(liquidacion), "Verificando", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
