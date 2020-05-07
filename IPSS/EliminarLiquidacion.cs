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
    public partial class EliminarLiquidacion : Form
    {
        Liquidacion liquidacion;
        LiquidacionCuotaModeradoraService liquidacionCuotaModeradoraService;
        public EliminarLiquidacion()
        {
            InitializeComponent();
            liquidacionCuotaModeradoraService = new LiquidacionCuotaModeradoraService();
        }

        private void BuscarBtn_Click(object sender, EventArgs e)
        {
            BuscarPersona();
            if (liquidacion == null)
            {
                MessageBox.Show("Persona no encontrada", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                PintarTextos();
            }
        }

        private void BuscarPersona()
        {
            liquidacion = liquidacionCuotaModeradoraService.Buscar(IdentificacionTxt.Text);
        }

        private void PintarTextos()
        {
            IdentificacionnTxt.Text = liquidacion.Identificacion;
            NombreTxt.Text = liquidacion.Nombre;
            tipoBox.SelectedItem = liquidacion.TipoAfiliacion;
            SalarioTxt.Text = liquidacion.Salario + "";
            ValorServicioTxt.Text = liquidacion.ValorServicio + "";
            TarifaTxt.Text = liquidacion.Tarifa + "";
        }

        private void EliminarBtn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Seguro que desea eliminar?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
               
                MessageBox.Show(liquidacionCuotaModeradoraService.Eliminar(liquidacion), "Eliminada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
