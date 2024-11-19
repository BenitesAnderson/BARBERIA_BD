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
    public partial class FrmBuscarProductoId : Form
    {
        public FrmBuscarProductoId()
        {
            InitializeComponent();
        }
        public static entDetalleVentaProducto DVPSelect;
        public void listarDVP()
        {
            dgvBuscarIdProducto.DataSource = logDetalleVentaProducto.Instancia.ListarDetalleVentaProducto();
        }
        public void limpiarVariables()
        {
            txtidsedebarberia.Text = "";

        }
        entDetalleVentaProducto aux = new entDetalleVentaProducto();

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            entDetalleVentaProducto auxba = logDetalleVentaProducto.Instancia.BuscarDetalleVentaProductoPorId(txtidsedebarberia.Text);

            if (auxba != null)
            {
               dgvBuscarIdProducto.DataSource = new List<entDetalleVentaProducto> { auxba };

            }
            else
            {
                MessageBox.Show("No se encontró ID especificado.");
            }

            limpiarVariables();
        }

        private void bntSelec_Click(object sender, EventArgs e)
        {
            if (dgvBuscarIdProducto.SelectedRows.Count > 0)
            {

                var filaSeleccionada = dgvBuscarIdProducto.SelectedRows[0];
                var Seleccionada = (entDetalleVentaProducto)filaSeleccionada.DataBoundItem;

                DVPSelect = Seleccionada;

                this.DialogResult = DialogResult.OK;

            }
            else
            {
                MessageBox.Show("Por favor, seleccione un producto del listado.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listarDVP();
        }
    }
}
