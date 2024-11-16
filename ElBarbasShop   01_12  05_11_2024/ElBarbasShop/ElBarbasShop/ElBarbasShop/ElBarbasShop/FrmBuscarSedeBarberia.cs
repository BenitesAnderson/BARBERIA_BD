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
    public partial class FrmBuscarSedeBarberia : Form
    {
        public FrmBuscarSedeBarberia()
        {
            InitializeComponent();
        

        }

        public static entBarberia barberiaSelect; 




        public void listarSedeBarberia()
        {
            dgvbuscarbarberia.DataSource = logBarberia.Instancia.ListarBarberia();
        }



        public void limpiarVariables()
        {
            txtidsedebarberia.Text = "";
          
        }

        entBarberia auxbarberia = new entBarberia();
        private void button1_Click(object sender, EventArgs e)
        {

            entBarberia auxbarberia = logBarberia.Instancia.BuscarBarberiaPorId(txtidsedebarberia.Text);

            if (auxbarberia != null)
            {
                // Asignamos a DataGridView una lista que contiene la barbería encontrada
                dgvbuscarbarberia.DataSource = new List<entBarberia> { auxbarberia };
             
            }
            else
            {
                MessageBox.Show("No se encontró ninguna barbería con el ID especificado.");
            }

            limpiarVariables();



        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            // Verificar que se ha seleccionado un elemento en el DataGridView
            if (dgvbuscarbarberia.SelectedRows.Count > 0)
            {
                // Obtener la barbería seleccionada desde el DataGridView
                var filaSeleccionada = dgvbuscarbarberia.SelectedRows[0];
                var barberiaSeleccionada = (entBarberia)filaSeleccionada.DataBoundItem;

                // Asignar la barbería seleccionada a la variable estática
                barberiaSelect = barberiaSeleccionada;

                // Cerrar el formulario actual y volver al formulario anterior
                this.DialogResult = DialogResult.OK;    
                
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una barbería del listado.");
            }


        }

        private void FrmBuscarSedeBarberia_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {



            listarSedeBarberia(); 





        }
    }
}
