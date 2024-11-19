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
    public partial class FrmMetodoPago : Form
    {
        public FrmMetodoPago()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            horaMP.Text = DateTime.Now.ToString("HH:mm:ss");
        }
        private bool habilitarSeleccion = false;
        public void listarDVP()
        {
            dgvDVP.DataSource = logDetalleVentaProducto.Instancia.ListarDetalleVentaProducto();
        }
        public void limpiarVariables()
        {
            txtDescripcion.Text = "";
            txtIdMetodo.Text = "";            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            entMetodoPago datos = new entMetodoPago
            {
                IdMetodoPago = txtIdMetodo.Text,
                Descripcion = txtDescripcion.Text,                

            };
            logMetodoPago.Instancia.InsertaMetodoPago(datos);

            listarDVP();
            limpiarVariables();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            entMetodoPago aux = logMetodoPago.Instancia.BuscarMetodoPagoPorId(txtIdMetodo.Text);

            if (aux != null)
            {
                // Asignamos a DataGridView una lista que contiene la barbería encontrada
                dgvDVP.DataSource = new List<entMetodoPago> { aux };
                habilitarSeleccion = true;
                MessageBox.Show("Haga clic en una fila del DataGridView para ver los detalles.");

            }
            else
            {
                MessageBox.Show("No se encontró ningun empleado con el ID especificado.");
            }

            limpiarVariables();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                entMetodoPago datos = new entMetodoPago
                {
                    IdMetodoPago = txtIdMetodo.Text,
                    Descripcion = txtDescripcion.Text,

                };
                logMetodoPago.Instancia.EditaMetodoPago(datos);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            limpiarVariables();

            listarDVP();
        }
    }
}
