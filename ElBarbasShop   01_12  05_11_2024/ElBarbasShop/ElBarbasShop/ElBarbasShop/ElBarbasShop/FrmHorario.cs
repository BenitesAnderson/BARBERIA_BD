using CapaEntidad;
using CapaLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElBarbasShop
{
    public partial class FrmHorario : Form
    {
        public FrmHorario()
        {
            InitializeComponent();
            timer1.Start();
        }
        private bool habilitarSeleccion = false;
        private void timer1_Tick(object sender, EventArgs e)
        {
            horaH.Text = DateTime.Now.ToString("HH:mm:ss");
        }
        public void listarHorarios()
        {
            dgvhorario.DataSource = logHorario.Instancia.ListarHorarios();
        }

        public void limpiarVariables()
        {
            txtidempleado.Text = "";
            txtdiasemana.Text = "";
            txthorainicio.Text = "";
            txthorafin.Text = "";
          


        }


        private void button1_Click(object sender, EventArgs e)
        {

            string idempleado, diasemana;
          
            idempleado = txtidempleado.Text;
            diasemana = txtdiasemana.Text;
            
            TimeSpan horainicio = TimeSpan.Parse(txthorainicio.Text);
            TimeSpan horafin = TimeSpan.Parse(txthorafin.Text);
            entHorario pr = new entHorario( diasemana, horainicio, horafin, idempleado);
            logHorario.Instancia.InsertarHorario(pr);

            listarHorarios();
            limpiarVariables();






        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            entHorario pr = logHorario.Instancia.BuscarHorario(txtidempleado.Text);

            if (pr != null)
            {
                // Asignamos a DataGridView una lista que contiene la barbería encontrada
                dgvhorario.DataSource = new List<entHorario >{ pr };
                habilitarSeleccion = true;
                MessageBox.Show("Haga clic en una fila del DataGridView para ver los detalles.");

            }
            else
            {
                MessageBox.Show("No se encontró ningun horario con el ID especificado.");
            }

            limpiarVariables();







        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                TimeSpan horainicio = TimeSpan.Parse(txthorainicio.Text);
                TimeSpan horafin = TimeSpan.Parse(txthorafin.Text);

                entHorario c = new entHorario(txtdiasemana.Text, horainicio, horafin, txtidempleado.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            limpiarVariables();

            listarHorarios();




        }

        private void button5_Click(object sender, EventArgs e)
        {

          



            try
            {
                TimeSpan horainicio = TimeSpan.Parse(txthorainicio.Text); 
                logHorario.Instancia.EliminarHorario(txtidempleado.Text,txtdiasemana.Text, horainicio );
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            limpiarVariables();

            listarHorarios();



        }

        private void button7_Click(object sender, EventArgs e)
        {

            listarHorarios();



        }

        private void button2_Click(object sender, EventArgs e)
        {
            var frmBuscarEmpleado = new FrmBuscarSedeBarberia();
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
    }
}
