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
    public partial class DetalleVentaProducto : Form
    {
        public DetalleVentaProducto()
        {
            InitializeComponent();
            timer1.Start();
        }

        private bool habilitarSeleccion = false;
        public void listarDVP()
        {
            dgvDVP.DataSource = logDetalleVentaProducto.Instancia.ListarDetalleVentaProducto();
        }
        public void limpiarVariables()
        {
            txtIdDetalleVenta.Text = "";
            txtIdProducto.Text = "";
            txtIdVenta.Text = "";
            txtCantidad.Text = "";
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            horaDVP.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            entDetalleVentaProducto datos = new entDetalleVentaProducto
            {
                idDetalle = Convert.ToInt32(txtIdDetalleVenta.Text),
                cantidad = Convert.ToInt32(txtCantidad.Text),
                idProducto = txtCantidad.Text,
                idVenta = txtIdVenta.Text,
            };

            logDetalleVentaProducto.Instancia.InsertaDetalleVentaProducto(datos);

            listarDVP();
            limpiarVariables();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            entDetalleVentaProducto auxempleado = logDetalleVentaProducto.Instancia.BuscarDetalleVentaProductoPorId(txtIdDetalleVenta.Text);

            if (auxempleado != null)
            {
                // Asignamos a DataGridView una lista que contiene la barbería encontrada
                dgvDVP.DataSource = new List<entDetalleVentaProducto> { auxempleado };
                habilitarSeleccion = true;
                MessageBox.Show("Haga clic en una fila del DataGridView para ver los detalles.");

            }
            else
            {
                MessageBox.Show("No se encontró ningun empleado con el ID especificado.");
            }

            limpiarVariables();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                entDetalleVentaProducto datos = new entDetalleVentaProducto
                {
                    idDetalle = Convert.ToInt32(txtIdDetalleVenta.Text),
                    cantidad = Convert.ToInt32(txtCantidad.Text),                                       
                    idProducto = txtCantidad.Text,
                    idVenta = txtIdVenta.Text,
                };

                logDetalleVentaProducto.Instancia.EditaDetalleVentaProducto(datos);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            limpiarVariables();

            listarDVP();

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            entDetalleVentaProducto em = new entDetalleVentaProducto();
            em = logDetalleVentaProducto.Instancia.BuscarDetalleVentaProductoPorId(txtIdDetalleVenta.Text);
            logDetalleVentaProducto.Instancia.DeshabilitarDetalleVentaProducto(em);

            listarDVP();
            limpiarVariables();
        }

        private void btnAbrirBusquedaIdVenta_Click(object sender, EventArgs e)
        {
            var frmBuscarVentaID = new FrmBuscarVentaId();
            if (frmBuscarVentaID.ShowDialog() == DialogResult.OK)
            {

                entVenta bar = FrmBuscarVentaId.dgvBuscarIdVenta;
                if (bar != null)
                {
                    txtIdDetalleVenta.Text = bar.IdVenta.ToString();
                }

            }
        }

        private void btnAbrirBusquedaIdProducto_Click(object sender, EventArgs e)
        {
            var frmBuscarProductoID = new FrmBuscarProductoId();
            if (frmBuscarProductoID.ShowDialog() == DialogResult.OK)
            {
                entDetalleVentaProducto barberia = FrmBuscarProductoId.DVPSelect;
                if (barberia != null)
                {
                    txtIdProducto.Text = barberia.idProducto.ToString();
                }
            }
        }

        private void dgvDVP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (habilitarSeleccion && e.RowIndex >= 0)
            {

                DataGridViewRow filaSeleccionada = dgvDVP.Rows[e.RowIndex];


                txtIdDetalleVenta.Text = filaSeleccionada.Cells["idDetalle"].Value.ToString();
                txtIdProducto.Text = filaSeleccionada.Cells["cantidad"].Value.ToString();
                txtIdVenta.Text = filaSeleccionada.Cells["idProducto"].Value.ToString();
                txtCantidad.Text = filaSeleccionada.Cells["idVenta"].Value.ToString();

                habilitarSeleccion = false;
            }
        }
    }
}
