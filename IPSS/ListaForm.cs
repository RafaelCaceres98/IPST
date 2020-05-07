using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using Entity;

namespace IPSS
{
    public partial class ListaForm : Form
    {
        LiquidacionCuotaModeradoraService liquidacionCuotaModeradoraService;
        IList<Liquidacion> Liquidaciones;
        double Total, TotalLiquidado;
        string TipoLiquidacion;
        public ListaForm()
        {
            InitializeComponent();
            liquidacionCuotaModeradoraService = new LiquidacionCuotaModeradoraService();
        }

        private void TipoBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TipoBox.SelectedItem.Equals("contributiva"))
            {
                TipoLiquidacion = ("contributiva");
               
            } else if (TipoBox.SelectedItem.Equals("subsidiada"))
            {
                TipoLiquidacion =  ("subsidiada");
                
            }
            else
            {
                Liquidaciones = liquidacionCuotaModeradoraService.Leer();
                Total = liquidacionCuotaModeradoraService.Leer().Count();
                TotalLiquidado = liquidacionCuotaModeradoraService.TotalLiquidadoTodos();
            }
            Liquidaciones = liquidacionCuotaModeradoraService.MostrarLiquidacionPorTipo(TipoLiquidacion);
            Total = liquidacionCuotaModeradoraService.MostrarTotalLiquidacionesPorTipo(TipoLiquidacion);
            TotalLiquidado = liquidacionCuotaModeradoraService.TotalLiquidadoPorTipo(TipoLiquidacion);
            LlenarTabla(Liquidaciones);
            PintarLabels(Total, TotalLiquidado);
        }

        private void LlenarTabla(IList<Liquidacion> liquidaciones)
        {
            TablaLiquidaciones.DataSource = liquidaciones;
        }

        private void BuscarBtn_Click(object sender, EventArgs e)
        {
            Liquidaciones = liquidacionCuotaModeradoraService.TextoConsultar(BuscarTxt.Text);
            LlenarTabla(Liquidaciones);
        }

        private void BuscarTxt_TextChanged(object sender, EventArgs e)
        {
            Liquidaciones = liquidacionCuotaModeradoraService.TextoConsultar(BuscarTxt.Text);
            LlenarTabla(Liquidaciones);
        }

        private void FechaFiltro_ValueChanged(object sender, EventArgs e)
        {
            Liquidaciones = liquidacionCuotaModeradoraService.ConsultarFecha(FechaFiltro.Value.Month, FechaFiltro.Value.Year);
            LlenarTabla(Liquidaciones);
        }

        private void TablaLiquidaciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ListaForm_Load(object sender, EventArgs e)
        {

        }

        private void PintarLabels(double total, double totalLiquidado)
        {
            TotalBox.Text = total + "";
            TotalLiquidadoTxt.Text = totalLiquidado + "";
        }
    }
}
