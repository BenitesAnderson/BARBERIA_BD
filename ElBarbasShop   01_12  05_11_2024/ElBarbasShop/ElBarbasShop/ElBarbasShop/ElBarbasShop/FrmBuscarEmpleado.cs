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

    public partial class FrmBuscarEmpleado : Form
    {

        public static entEmpleado P;
        public FrmBuscarEmpleado()
        {
            InitializeComponent();
        }

        public void listarEmpleado()
        {
            dgvbuscar.DataSource = logEmpleado.Instancia.ListarEmpleado();
        }

        public void limpiarVariables()
        {
            txtidempleado.Text = "";

        }


        private void button4_Click(object sender, EventArgs e)
        {
            listarEmpleado();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Verificar que se ha seleccionado un elemento en el DataGridView
            if (dgvbuscar.SelectedRows.Count > 0)
            {
                // Obtener la barbería seleccionada desde el DataGridView
                var filaSeleccionada = dgvbuscar.SelectedRows[0];
                var EmpleadoSeleccionado = (entEmpleado)filaSeleccionada.DataBoundItem;

                // Asignar la barbería seleccionada a la variable estática
                P = EmpleadoSeleccionado;

                // Cerrar el formulario actual y volver al formulario anterior
                this.DialogResult = DialogResult.OK;

            }
            else
            {
                MessageBox.Show("Por favor, seleccione una barbería del listado.");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

            entEmpleado entEmpleado = logEmpleado.Instancia.BuscarEmpeladoPorId(txtidempleado.Text);

            if (entEmpleado != null)
            {
                // Asignamos a DataGridView una lista que contiene la barbería encontrada
                dgvbuscar.DataSource = new List<entEmpleado> { entEmpleado };

            }
            else
            {
                MessageBox.Show("No se encontró ninguna barbería con el ID especificado.");
            }

            limpiarVariables();

        }
    }
}
