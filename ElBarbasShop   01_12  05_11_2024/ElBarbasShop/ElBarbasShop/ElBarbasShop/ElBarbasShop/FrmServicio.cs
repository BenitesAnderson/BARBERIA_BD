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
    public partial class FrmServicio : Form
    {
        public FrmServicio()
        {
            InitializeComponent();
            timer1.Start();
        }
        private bool habilitarSeleccion = false;
        private void timer1_Tick(object sender, EventArgs e)
        {
            horaS.Text = DateTime.Now.ToString("HH:mm:ss");
        }
        public void listarServicios()
        {
            dgvservicio.DataSource = logServicio.Instancia.ListarServicios();
        }

        public void limpiarVariables()
        {
            txtidservicio.Text = "";
            txtnombreservicio.Text = "";
            txtduracion.Text = "";
          
            txtprecio.Text = "";



        }
        private void button1_Click(object sender, EventArgs e)
        {



            string idservicio, nombreservicio;
            int duracion;
            decimal precio;
            idservicio = txtidservicio.Text;
            nombreservicio = txtnombreservicio.Text;
            duracion  = int.Parse(txtduracion.Text);
            precio = Convert.ToDecimal(txtprecio.Text); 
            entServicio s = new entServicio(idservicio, nombreservicio, duracion, precio);
            logServicio.Instancia.InsertarServicio(s);

            listarServicios();
            limpiarVariables();




        }

        private void txtprecio_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmServicio_Load(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

            listarServicios(); 

        }

        private void button3_Click(object sender, EventArgs e)
        {

            entServicio s = logServicio.Instancia.BuscarServicioPorId(txtidservicio.Text);

            if (s != null)
            {
                // Asignamos a DataGridView una lista que contiene la barbería encontrada
                dgvservicio.DataSource = new List<entServicio> { s };
                habilitarSeleccion = true;
                MessageBox.Show("Haga clic en una fila del DataGridView para ver los detalles.");

            }
            else
            {
                MessageBox.Show("No se encontró ninguna barbería con el ID especificado.");
            }

            limpiarVariables();






        }

        private void button4_Click(object sender, EventArgs e)
        {

            try
            {


                entServicio c = new entServicio(txtidservicio.Text, txtnombreservicio.Text, int.Parse(txtduracion.Text), Convert.ToDecimal(txtprecio.Text));

                logServicio.Instancia.EditarServicio(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            limpiarVariables();

            listarServicios();

        }

        private void dgvservicio_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvservicio_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (habilitarSeleccion && e.RowIndex >= 0)
            {
                // Obtiene la fila seleccionada
                DataGridViewRow filaSeleccionada = dgvservicio.Rows[e.RowIndex];

                // Asigna los valores de las celdas a los TextBox
                txtidservicio.Text = filaSeleccionada.Cells["idServicio"].Value.ToString();
                txtnombreservicio.Text = filaSeleccionada.Cells["nombreServicio"].Value.ToString();
                txtduracion.Text = filaSeleccionada.Cells["duracion"].Value.ToString();
                txtprecio.Text = filaSeleccionada.Cells["precio"].Value.ToString();

                // Desactiva la selección después de cargar los datos
                habilitarSeleccion = false;
            }





        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {

                logServicio.Instancia.EliminarServicio(txtidservicio.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            limpiarVariables();

            listarServicios();




        }

        private void button9_Click(object sender, EventArgs e)
        {
            limpiarVariables(); 
        }
    }
}
