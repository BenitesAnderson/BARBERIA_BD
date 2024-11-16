using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using CapaEntidad; 


namespace ElBarbasShop
{
    public partial class Frmlogin : Form
    {
        public Frmlogin()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        { // Obtener la conexión desde la clase de conexión
            SqlConnection con = CapaEntidad.Conexion.Instancia.Conectar();

            try
            {
                if (con != null && con.State == ConnectionState.Closed)
                {
                    con.Open();
                    MessageBox.Show("Conexión exitosa :)");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la conexión: " + ex.Message);
            }
            finally
            {
                // Cierra la conexión si está abierta
                if (con != null && con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }




        

        private void Frmlogin_Load(object sender, EventArgs e)
        {

        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            FrmSedeBarberia f  = new FrmSedeBarberia();
            f.ShowDialog();
            this.Hide();

        }
    }
}
