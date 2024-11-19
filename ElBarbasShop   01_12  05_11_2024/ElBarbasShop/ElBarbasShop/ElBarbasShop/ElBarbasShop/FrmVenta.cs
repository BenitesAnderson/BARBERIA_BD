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
    public partial class FrmVenta : Form
    {

        public void limpiarVariables()
        {
            textBox4.Text = "";
            dateTimePicker1.Text = "";
            textBox1.Text = "";
            idclientetxt.Text  = "";
            textBox5.Text = "";
            textBox3.Text = "";

        }
        public FrmVenta()
        {
            InitializeComponent();
            timer1.Start();

        }
        private bool habilitarSeleccion = false;

        private void timer1_Tick(object sender, EventArgs e)
        {
            horaV.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            entVenta v = logVenta.Instancia.BuscarVentaPorId(textBox4.Text, dateTimePicker1, textBox1.Text, idclientetxt.Text, textBox5.Text, textBox3.Text);

            if (v != null)
            {
                // Asignamos a DataGridView una lista que contiene la barbería encontrada
                dataGridView1.DataSource = new List<entVenta> { v };
                habilitarSeleccion = true;
                MessageBox.Show("Haga clic en una fila del DataGridView para ver los detalles.");

            }
            else
            {
                MessageBox.Show("No se encontró ninguna Teléfono con el ID especificado.");
            }

            limpiarVariables();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string idventa, idcliente, idempleado, metododepago;
            decimal monto;
            DateTime fechadeventa;

            idventa = textBox4.Text;
            fechadeventa = Convert.ToDateTime(dateTimePicker1);
            monto = Convert.ToDecimal (textBox1.Text);
            idcliente = idclientetxt.Text;
            idempleado = textBox5.Text;
            metododepago = textBox3.Text;

            entVenta a = new entVenta(idventa,fechadeventa,monto,idcliente,idempleado,metododepago);
            logVenta.Instancia.InsertarVenta(a);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                entVenta c= new entVenta();

                c.idventa = textBox4.Text;

                logBarberia.Instancia.DeshabilitarCliente(c);
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
