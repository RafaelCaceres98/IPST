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
    
    public partial class ModificarLiquidacionForm : Form
    {
        Liquidacion liquidacion;
        LiquidacionCuotaModeradoraService liquidacionCuotaModeradoraService;
        public ModificarLiquidacionForm()
        {
            InitializeComponent();
            liquidacionCuotaModeradoraService = new LiquidacionCuotaModeradoraService();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try {
                DialogResult dialogResult =MessageBox.Show("¿Seguro que desea modificar?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes) {
                    liquidacion.ValorServicio = Convert.ToDouble(ValorServicioTxt.Text);
                    liquidacion.CuotaModeradora = liquidacion.CalcularCuotaModeradora();
                    MessageBox.Show(liquidacionCuotaModeradoraService.Modificar(liquidacion), "Modifacada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
            }catch(Exception a)
            {
                MessageBox.Show("Verifique el dato ingresado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BuscarPersona()
        {
            liquidacion = liquidacionCuotaModeradoraService.Buscar(IdentificacionTxt.Text);
        }

        private void BuscarBtn_Click(object sender, EventArgs e)
        {
            BuscarPersona();
            if (liquidacion == null)
            {
                MessageBox.Show("Persona no encontrada", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else
            {
                PintarLabels();
            }
        }

        private void PintarLabels()
        {
            IdentificacionnTxt.Text = liquidacion.Identificacion;
            NombreTxt.Text = liquidacion.Nombre;
            tipoBox.SelectedItem = liquidacion.TipoAfiliacion;
            SalarioTxt.Text = liquidacion.Salario + "";
            ValorServicioTxt.Text = liquidacion.ValorServicio + "";
            TarifaTxt.Text = liquidacion.Tarifa + "";
        }
    }
}
