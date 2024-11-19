using CapaEntidad;
using CapaLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace ElBarbasShop
{
    public partial class FrmEmpleado : Form
    {

       

        public FrmEmpleado()
        {
            InitializeComponent();
            cmbcargo.SelectedIndex = 0;
            timer1.Start();
        }
        private bool habilitarSeleccion = false;

        public void listarEmpleados()
        {
            dgvempleado.DataSource = logEmpleado.Instancia.ListarEmpleado();    
        }

        public void limpiarVariables()
        {
            txtnombre.Text = "";
            txtidempleado.Text = ""; 
            txtapellidos.Text = "";
            txtdni.Text = "";
            txtidbarberia.Text="";
            txtcorreo.Text = "";

            cmbcargo.SelectedIndex = 0;



        }



        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void FrmEmpleado_Load(object sender, EventArgs e)
        {






            
        
        
        }

        private void button2_Click(object sender, EventArgs e)
        {

            var frmBuscarSedeBarberia = new FrmBuscarSedeBarberia();
            if (frmBuscarSedeBarberia.ShowDialog() == DialogResult.OK)
            {
                // La barbería fue seleccionada, procede con la lógica

                entBarberia barberia = FrmBuscarSedeBarberia.barberiaSelect;
                if (barberia != null)
                {

                    txtidbarberia.Text = barberia.idBarberia.ToString();


                }

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string idempleado,idsede,  nombre,apellido, correo, cargo, dni;

            idempleado = txtidempleado.Text;
            nombre = txtnombre.Text;
            apellido = txtapellidos.Text;
            idsede = txtidbarberia.Text;
            correo = txtcorreo.Text;
            cargo = cmbcargo.SelectedIndex.ToString();
            dni = txtdni.Text;
            entBarberia bar = logBarberia.Instancia.BuscarBarberiaPorId(idsede);

            // (string idempleado , string nombres, string apellidos,string dni,  string cargo, string correo , entBarberia barberia) 

            entEmpleado em = new entEmpleado(idempleado, nombre, apellido, dni, cargo, correo, bar); 
            logEmpleado.Instancia.InsertarEmpleado(em);

            listarEmpleados(); 
            limpiarVariables();



        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
         

        }

        private void button7_Click(object sender, EventArgs e)
        {

            listarEmpleados(); 


        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            limpiarVariables(); 

        }

        private void button3_Click(object sender, EventArgs e)
        {


            entEmpleado auxempleado = logEmpleado.Instancia.BuscarEmpeladoPorId(txtidempleado.Text);

            if (auxempleado != null)
            {
                // Asignamos a DataGridView una lista que contiene la barbería encontrada
                dgvempleado.DataSource = new List<entEmpleado> { auxempleado };
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

            
                    entBarberia bar = logBarberia.Instancia.BuscarBarberiaPorId(txtidbarberia.Text);
                entEmpleado c = new entEmpleado(txtidempleado.Text, txtnombre.Text, txtapellidos.Text, txtdni.Text, cmbcargo.SelectedIndex.ToString(), txtcorreo.Text, bar) ;

                logEmpleado.Instancia.EditarEmpleado(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            limpiarVariables();

            listarEmpleados();

        }

        private void dgvempleado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvempleado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verifica que se haya seleccionado una fila válida (evita errores si se hace clic en el encabezado)
            if (habilitarSeleccion && e.RowIndex >= 0)
            {
                // Obtiene la fila seleccionada
                DataGridViewRow filaSeleccionada = dgvempleado.Rows[e.RowIndex];

                // Asigna los valores de las celdas a los TextBox
                txtidempleado.Text = filaSeleccionada.Cells["idEmpleado"].Value.ToString();
                txtnombre.Text = filaSeleccionada.Cells["nombre"].Value.ToString();
                txtapellidos.Text = filaSeleccionada.Cells["apellidos"].Value.ToString();
                txtdni.Text = filaSeleccionada.Cells["dni"].Value.ToString();
                txtidbarberia.Text = filaSeleccionada.Cells["idBarberia"].Value.ToString();
                txtcorreo.Text = filaSeleccionada.Cells["correo"].Value.ToString();

                // Asigna el cargo seleccionado al ComboBox
                string cargoSeleccionado = filaSeleccionada.Cells["cargo"].Value.ToString();
                int index = cmbcargo.FindStringExact(cargoSeleccionado);  // Busca el cargo en el ComboBox

                if (index >= 0) // Si se encuentra, lo selecciona
                {
                    cmbcargo.SelectedIndex = index;
                }
                else // Si no se encuentra, puedes asignar un valor predeterminado o dejarlo vacío
                {
                    cmbcargo.SelectedIndex = -1; // O puedes poner un valor predeterminado si lo deseas
                }

                // Desactiva la selección después de cargar los datos
                habilitarSeleccion = false;
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            horaE.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
