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
    public partial class FrmTelefonoEmpleado : Form
    {
        private bool habilitarSeleccion = false;
        public FrmTelefonoEmpleado()
        {
            InitializeComponent();
            timer1.Start();
        }

        public void listarSedeBarberia()
        {
            dataGridViewtelefonoempleado.DataSource = logBarberia.Instancia.ListarBarberia();
        }

        public void limpiarVariables()
        {
            txtidempleado.Text = "";
            txtnumerodetelefono.Text = "";
            txtoperador.Text = "";

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            horaTE.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string idempleado, numerodetelefono, operador;

            idempleado = txtidempleado.Text;
            numerodetelefono = txtnumerodetelefono.Text;
            operador = txtoperador.Text;
            entTelefonoEmpleado Teleemple = new entTelefonoEmpleado(idempleado, numerodetelefono, operador);
            logTelefonoEmpleado.Instancia.InsertarTelefonoEmpleado(Teleemple);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            entTelefonoEmpleado t = logTelefonoEmpleado.Instancia.BuscarTelefonoEmpleado(txtidempleado.Text, txtnumerodetelefono.Text);

            if (t != null)
            {
                // Asignamos a DataGridView una lista que contiene la barbería encontrada
                dataGridViewtelefonoempleado.DataSource = new List<entTelefonoEmpleado> { t };
                habilitarSeleccion = true;
                MessageBox.Show("Haga clic en una fila del DataGridView para ver los detalles.");

            }
            else
            {
                MessageBox.Show("No se encontró ningun Teléfono con el ID especificado.");
            }

            limpiarVariables();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {


                entTelefonoEmpleado c = new entTelefonoEmpleado(txtidempleado.Text, txtnumerodetelefono.Text, txtoperador.Text);

                logTelefonoEmpleado.Instancia.EditarTelefonoEmpleado(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            limpiarVariables();

            listarSedeBarberia();


        }

        private void button2_Click(object sender, EventArgs e)
        {

            var frmBuscarEmpleado = new FrmBuscarEmpleado();
            if (frmBuscarEmpleado.ShowDialog() == DialogResult.OK)
            {
                // La barbería fue seleccionada, procede con la lógica

                entEmpleado Empleado = FrmBuscarEmpleado.P;
                if (Empleado != null)
                {

                    txtidempleado.Text = Empleado.idEmpleado.ToString();


                }
            }

        }

        private void dataGridViewtelefonoempleado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verifica que se haya seleccionado una fila válida (evita errores si se hace clic en el encabezado)
            if (habilitarSeleccion && e.RowIndex >= 0)
            {
                // Obtiene la fila seleccionada
                DataGridViewRow filaSeleccionada = dataGridViewtelefonoempleado.Rows[e.RowIndex];

                // Asigna los valores de las celdas a los TextBox
                txtidempleado.Text = filaSeleccionada.Cells["idEmpleado"].Value.ToString();
                txtnumerodetelefono.Text = filaSeleccionada.Cells["numerotelefono"].Value.ToString();
                txtoperador.Text = filaSeleccionada.Cells["operador"].Value.ToString();
                // Desactiva la selección después de cargar los datos
                habilitarSeleccion = false;
            }
        }

        private void dataGridViewtelefonoempleado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                entTelefonoEmpleado b = new entTelefonoEmpleado();

                b.idEmpleado = txtidempleado.Text;

                b.numeroTelefono = txtnumerodetelefono.Text;

                logTelefonoEmpleado.Instancia.EliminarTelefonoEmpleado(b);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            limpiarVariables();

            listarSedeBarberia();
        }
    }
}