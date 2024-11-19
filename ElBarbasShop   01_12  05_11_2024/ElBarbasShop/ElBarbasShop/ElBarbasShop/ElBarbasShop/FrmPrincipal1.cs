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
    public partial class FrmPrincipal1 : Form
    {
        public FrmPrincipal1()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FrmPrincipal principal = new FrmPrincipal();
            principal.Show();
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            horaP1.Text = DateTime.Now.ToString("HH:mm:ss");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmEmpleado frm = new FrmEmpleado();
            frm.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmVenta frm = new FrmVenta();
            frm.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmUsuario frm = new FrmUsuario();
            frm.Show();
            this.Close();   
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DetalleVentaProducto frm = new DetalleVentaProducto();
            frm.Show();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DetalleVentaServicio frm = new DetalleVentaServicio();
            frm.Show();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FrmTelefonoCliente frm = new FrmTelefonoCliente();
            frm.Show();
            this.Close();
        }
    }
}
