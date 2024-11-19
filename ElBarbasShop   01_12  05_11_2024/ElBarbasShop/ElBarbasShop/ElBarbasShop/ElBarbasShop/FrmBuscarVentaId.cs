using CapaEntidad;
using CapaLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElBarbasShop
{
    public partial class FrmBuscarVentaId : Form
    {
        public FrmBuscarVentaId()
        {
            InitializeComponent();
        }
        public static entVenta DVSSelect;
        public void limpiarVariables()
        {
            txtidsedebarberia.Text = "";

        }
        public void listarDVS()
        {
            dgvBuscarIdVenta.DataSource = logVenta.Instancia.ListarVenta();
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            entVenta auxba = logVenta.Instancia.BuscarVentaPorId(txtidsedebarberia.Text);

            if (auxba != null)
            {
                // Asignamos a DataGridView una lista que contiene la barbería encontrada
                dgvBuscarIdVenta.DataSource = new List<entVenta> { auxba };

            }
            else
            {
                MessageBox.Show("No se encontró el ID especificado.");
            }

            limpiarVariables();
        }

        private void btnSelec_Click(object sender, EventArgs e)
        {
            if (dgvBuscarIdVenta.SelectedRows.Count > 0)
            {

                var filaSeleccionada = dgvBuscarIdVenta.SelectedRows[0];
                var Seleccionada = (entVenta)filaSeleccionada.DataBoundItem;

                DVSSelect = Seleccionada;

                this.DialogResult = DialogResult.OK;

            }
            else
            {
                MessageBox.Show("Por favor, seleccione una venta del listado.");
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            listarDVS();
        }
    }
}
