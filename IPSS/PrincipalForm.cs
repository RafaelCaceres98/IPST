using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IPSS
{
    public partial class PrincipalForm : Form
    {
        public PrincipalForm()
        {
            InitializeComponent();
        }

        private void ListaBtn_Click(object sender, EventArgs e)
        {
            AbrirForm(new ListaForm());
        }

       

        private void IngresarBtn_Click(object sender, EventArgs e)
        {
            AbrirForm(new AgregarLiquidacion());
        }

        private void AbrirForm(object agregarForm)
        {
            if (this.PanelPrincipal.Controls.Count > 0)
                this.PanelPrincipal.Controls.RemoveAt(0);
            Form fa = agregarForm as Form;
            fa.TopLevel = false;
            fa.Dock = DockStyle.Fill;
            this.PanelPrincipal.Controls.Add(fa);
            this.PanelPrincipal.Tag = fa;
            fa.Show();
        }

        private void ModificarBtn_Click(object sender, EventArgs e)
        {
            AbrirForm(new ModificarLiquidacionForm());
        }


        private void EliminarBtn_Click(object sender, EventArgs e)
        {
            AbrirForm(new EliminarLiquidacion());
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void PanelPrincipal_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
