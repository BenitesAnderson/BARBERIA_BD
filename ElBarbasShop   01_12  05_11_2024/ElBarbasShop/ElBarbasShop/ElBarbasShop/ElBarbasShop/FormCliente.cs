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
    public partial class FormCliente : Form
    {
        public FormCliente()
        {
            InitializeComponent();

        }
        private bool habilitarSeleccion = false;
        public void listarDVP()
        {
            dgvDVP.DataSource = logCliente.Instancia.ListarCliente();
        }

        public void limpiarVariables()
        {
            txtIdCliente.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtDni.Text = "";
            cmbTipoCliente.Text = "";
        }

        private void FormCliente_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            entCliente datos = new entCliente
            {
                idCliente = txtIdCliente.Text,
                nombres = txtNombre.Text,
                apellidos = txtApellido.Text,
                dni = txtDni.Text,
                tipoCliente = cmbTipoCliente.Text

            };

            logCliente.Instancia.InsertarCliente(datos);

            listarDVP();
            limpiarVariables();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            horaCliente.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            entCliente aux = logCliente.Instancia.BuscarClientePorId(txtIdCliente.Text);

            if (aux != null)
            {
                dgvDVP.DataSource = new List<entCliente> { aux };
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
                entCliente datos = new entCliente
                {
                    idCliente = txtIdCliente.Text,
                    nombres = txtNombre.Text,
                    apellidos = txtApellido.Text,
                    dni = txtDni.Text,
                    tipoCliente = cmbTipoCliente.Text

                };

                logCliente.Instancia.EditarCliente(datos);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            limpiarVariables();

            listarDVP();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            entCliente em = new entCliente();
            em = logCliente.Instancia.BuscarClientePorId(txtIdCliente.Text);
            logCliente.Instancia.DeshabilitarCliente(em);

            listarDVP();
            limpiarVariables();
        }

        private void dgvDVP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (habilitarSeleccion && e.RowIndex >= 0)
            {

                DataGridViewRow filaSeleccionada = dgvDVP.Rows[e.RowIndex];


                txtIdCliente.Text = filaSeleccionada.Cells["idCliente"].Value.ToString();
                txtNombre.Text = filaSeleccionada.Cells["nombre"].Value.ToString();
                txtApellido.Text = filaSeleccionada.Cells["Apellido"].Value.ToString();
                txtDni.Text = filaSeleccionada.Cells["dni"].Value.ToString();
                cmbTipoCliente.Text = filaSeleccionada.Cells["tipoCliente"].Value.ToString();

                habilitarSeleccion = false;
            }
        }
    }
}
