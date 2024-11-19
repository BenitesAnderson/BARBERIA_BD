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
    public partial class FrmTelefonoCliente : Form
    {
        public FrmTelefonoCliente()
        {
            InitializeComponent();
            timer1.Start();
        }
        private bool habilitarSeleccion = false;
        private void timer1_Tick(object sender, EventArgs e)
        {
            horaTC.Text = DateTime.Now.ToString("HH:mm:ss");
        }


        public void listarTelefonos()
        {
            dgvtelefonocliente.DataSource = logTelefonoCliente.Instancia.ListarTelefonosPorCliente();
        }

        public void limpiarVariables()
        {
            txtidcliente.Text = "";
            txtnumero.Text = "";
            txtoperador.Text = "";
            



        }


        private void button1_Click(object sender, EventArgs e)
        {
            string idcliente, numero, operador;
           
            idcliente = txtidcliente.Text;
            numero = txtnumero.Text;
            operador= txtoperador.Text;
           
            entTelefonoCliente pr = new entTelefonoCliente(idcliente, numero,   operador);
            logTelefonoCliente .Instancia.InsertarTelefono(pr);

            listarTelefonos();
            limpiarVariables();




        }

        private void button7_Click(object sender, EventArgs e)
        {
            limpiarVariables(); 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Consultamos el teléfono del cliente utilizando el ID y el número de teléfono
            entTelefonoCliente telefonoCliente = logTelefonoCliente.Instancia.BuscarTelefono(txtidcliente.Text, txtnumero.Text);

            if (telefonoCliente != null)
            {
                // Asignamos a DataGridView una lista que contiene el teléfono del cliente encontrado
                dgvtelefonocliente.DataSource = new List<entTelefonoCliente> { telefonoCliente };
                habilitarSeleccion = true;
                MessageBox.Show("Haga clic en una fila del DataGridView para ver los detalles.");
            }
            else
            {
                MessageBox.Show("No se encontró ningún teléfono con el ID de cliente y número especificados.");
            }

            // Limpiar las variables de entrada después de la consulta
            limpiarVariables();




        }

        private void button2_Click(object sender, EventArgs e)
        {
            


        }

        private void FrmTelefonoCliente_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                // Crear una instancia del objeto entTelefonoCliente con los datos ingresados
                entTelefonoCliente telefono = new entTelefonoCliente(
                    txtidcliente.Text,  // ID del cliente
                    txtnumero.Text,  // Número de teléfono
                    txtoperador.Text  // Operador del teléfono (si se ingresa)
                );

                // Llamar al método para editar el teléfono del cliente
                logTelefonoCliente.Instancia.EditarTelefono(telefono);

                MessageBox.Show("Teléfono actualizado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el teléfono del cliente: " + ex.Message);
            }

            // Limpiar los campos de texto y otras variables si es necesario
            limpiarVariables();

            // Actualizar la lista de teléfonos (si es necesario, puedes refrescar la vista)
            listarTelefonos();





        }

        private void button8_Click(object sender, EventArgs e)
        {
            listarTelefonos(); 

        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                // Llamar al método para eliminar el teléfono del cliente
                logTelefonoCliente.Instancia.EliminarTelefono(txtidcliente.Text, txtnumero.Text);

                MessageBox.Show("Teléfono eliminado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el teléfono, idcliente o numero vacios: " + ex.Message);
            }

            // Limpiar los campos de texto y otras variables si es necesario
            limpiarVariables();

            // Actualizar la lista de teléfonos (si es necesario, puedes refrescar la vista)
            listarTelefonos();




        }

        private void dgvtelefonocliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            FrmPrincipal1 frm = new FrmPrincipal1();
            frm.Show();
            this.Close();
        }
    }
}
