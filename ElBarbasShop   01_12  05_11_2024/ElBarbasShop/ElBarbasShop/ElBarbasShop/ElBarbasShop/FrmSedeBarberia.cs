using CapaEntidad;
using CapaLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidad;


namespace ElBarbasShop
{
    public partial class FrmSedeBarberia : Form
    {
        public FrmSedeBarberia()
        {
            InitializeComponent();
            timer1.Start();
        }

        private bool habilitarSeleccion = false;

        private void button1_Click(object sender, EventArgs e)
        {

        }

        public void listarSedeBarberia()
        {
            dgvbarberia.DataSource = logBarberia.Instancia.ListarBarberia();
        }

        public void limpiarVariables()
        {
            txtnombre.Text = "";
            txtidsede.Text = "";
            txtubicacion.Text = "";

        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            string idsede, nombre, ubicacion;

            idsede = txtidsede.Text;
            nombre = txtnombre.Text;
            ubicacion = txtubicacion.Text;
            entBarberia entBarberia = new entBarberia(idsede, nombre, ubicacion);
            logBarberia.Instancia.InsertaBarberia(entBarberia);

            listarSedeBarberia(); 
            limpiarVariables();


        }

        private void txtsede_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmSedeBarberia_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

            FrmEmpleado frmEmpleado = new FrmEmpleado();
            frmEmpleado.ShowDialog();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {// 
         // Obtiene la conexión
            SqlConnection connection = Conexion.Instancia.Conectar();

            try
            {
                // Intenta abrir la conexión
                connection.Open();

                // Verifica si la conexión está abierta
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    MessageBox.Show("Conexión exitosa :)");
                }
                else
                {
                    MessageBox.Show("Error en la conexión con la base de datos");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al intentar conectar: {ex.Message}");
            }
            finally
            {
                // Asegúrate de cerrar la conexión si está abierta
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }
            private void button7_Click(object sender, EventArgs e)
            {

            }

        private void button3_Click(object sender, EventArgs e)
        {



            entBarberia auxbarberia = logBarberia.Instancia.BuscarBarberiaPorId(txtidsede.Text);

            if (auxbarberia != null)
            {
                // Asignamos a DataGridView una lista que contiene la barbería encontrada
                dgvbarberia.DataSource = new List<entBarberia> { auxbarberia };
                habilitarSeleccion = true;
                MessageBox.Show("Haga clic en una fila del DataGridView para ver los detalles.");

            }
            else
            {
                MessageBox.Show("No se encontró ninguna barbería con el ID especificado.");
            }

            limpiarVariables();

        }

        private void dgvbarberia_Click(object sender, EventArgs e)
        {



        }

        private void dgvbarberia_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            // Verifica que se haya seleccionado una fila válida (evita errores si se hace clic en el encabezado)
            if (habilitarSeleccion && e.RowIndex >= 0)
            {
                // Obtiene la fila seleccionada
                DataGridViewRow filaSeleccionada = dgvbarberia.Rows[e.RowIndex];

                // Asigna los valores de las celdas a los TextBox
                txtidsede.Text = filaSeleccionada.Cells["idBarberia"].Value.ToString();
                txtnombre.Text = filaSeleccionada.Cells["nombre"].Value.ToString();
                txtubicacion.Text = filaSeleccionada.Cells["ubicacion"].Value.ToString();
                // Desactiva la selección después de cargar los datos
                habilitarSeleccion = false;
            }

        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            limpiarVariables(); 


        }

        private void button7_Click_1(object sender, EventArgs e)
        {

            listarSedeBarberia();


        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                
                
                entBarberia c = new entBarberia(txtidsede.Text, txtnombre.Text,txtubicacion.Text);
               
                logBarberia.Instancia.EditaBarberia(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            limpiarVariables();
     
            listarSedeBarberia();


        }

        private void button5_Click(object sender, EventArgs e)
        {

            try
            {
                entBarberia b = new entBarberia();

                b.idBarberia = txtidsede.Text;
               
                logBarberia.Instancia.DeshabilitarCliente(b);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            limpiarVariables();
           
            listarSedeBarberia();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            horaSB.Text = DateTime.Now.ToString("HH:mm:ss");
        }
    }
} 
