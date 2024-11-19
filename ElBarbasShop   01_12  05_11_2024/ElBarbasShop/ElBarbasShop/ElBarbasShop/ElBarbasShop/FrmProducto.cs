using CapaEntidad;
using CapaLogica;
using System;
using System.Collections;
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
    public partial class FrmProducto : Form
    {
        public FrmProducto()
        {
            InitializeComponent();
            timer1.Start();
        }
        private bool habilitarSeleccion = false;
        private void FrmProducto_Load(object sender, EventArgs e)
        {

        }

        public void listarProductos()
        {
            dgvproducto.DataSource = logProducto.Instancia.ListarProducto();
        }

        public void limpiarVariables()
        {
            txtnombre.Text = "";
            txtidproducto.Text = "";
            txtdescripcion.Text = "";
            txtstock.Text = "";
            txtprecio.Text = "";
      


        }




        private void button4_Click(object sender, EventArgs e)
        {
            try
            {


                entProducto c = new entProducto(txtidproducto.Text, txtnombre.Text, txtdescripcion.Text, Convert.ToDecimal(txtprecio.Text), int.Parse(txtstock.Text));

                logProducto.Instancia.EditarProducto(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            limpiarVariables();

            listarProductos();


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            horaP.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string idproducto, nombre, descripcion;
            decimal precio;
            int stock; 
            idproducto = txtidproducto.Text;
            nombre = txtnombre.Text;
            descripcion = txtdescripcion.Text;
            precio = Convert.ToDecimal(txtprecio.Text);
            stock = int.Parse(txtstock.Text);
            entProducto pr = new entProducto(idproducto , nombre, descripcion, precio, stock);
            logProducto.Instancia.InsertarProducto(pr);

            listarProductos(); 
            limpiarVariables();



        }

        private void button3_Click(object sender, EventArgs e)
        {

            entProducto pr = logProducto.Instancia.BuscarProductoPorId(txtidproducto.Text);

            if (pr != null)
            {
                // Asignamos a DataGridView una lista que contiene la barbería encontrada
                dgvproducto.DataSource = new List<entProducto> { pr };
                habilitarSeleccion = true;
                MessageBox.Show("Haga clic en una fila del DataGridView para ver los detalles.");

            }
            else
            {
                MessageBox.Show("No se encontró ninguna barbería con el ID especificado.");
            }

            limpiarVariables();




        }

        private void button5_Click(object sender, EventArgs e)
        {

            try
            {

                logProducto.Instancia.EliminarProducto(txtidproducto.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            limpiarVariables();

            listarProductos();



        }

        private void button8_Click(object sender, EventArgs e)
        {
            listarProductos(); 
        }

        private void dgvproducto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvproducto_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (habilitarSeleccion && e.RowIndex >= 0)
            {
                // Obtiene la fila seleccionada
                DataGridViewRow filaSeleccionada = dgvproducto.Rows[e.RowIndex];

                // Asigna los valores de las celdas a los TextBox
                txtidproducto.Text = filaSeleccionada.Cells["idProducto"].Value.ToString();
                txtnombre.Text = filaSeleccionada.Cells["nombreProducto"].Value.ToString();
                txtdescripcion.Text = filaSeleccionada.Cells["descripcion"].Value.ToString();
                txtprecio.Text = filaSeleccionada.Cells["precio"].Value.ToString();
                txtstock.Text = filaSeleccionada.Cells["stock"].Value.ToString();

                // Desactiva la selección después de cargar los datos
                habilitarSeleccion = false;
            }


        }

        private void button9_Click(object sender, EventArgs e)
        {

            limpiarVariables();

        }
    }
}
