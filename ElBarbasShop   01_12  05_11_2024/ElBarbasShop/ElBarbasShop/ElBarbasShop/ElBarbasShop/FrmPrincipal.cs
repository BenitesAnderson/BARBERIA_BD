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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmProducto formProducto = new FrmProducto();
            formProducto.Show();
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            horaP.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmServicio frmServicio = new FrmServicio();
            frmServicio.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmSedeBarberia frmSedeBarberia = new FrmSedeBarberia();
            frmSedeBarberia.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormCliente formCliente = new FormCliente();
            formCliente.Show();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FrmHorario formHorario = new FrmHorario();
            formHorario.Show();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FrmPrincipal1 formPrincipal1 = new FrmPrincipal1();
            formPrincipal1.Show();
            this.Close();
        }
    }
}
