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
    public partial class FrmDetalleVentaServicio : Form
    {
        public FrmDetalleVentaServicio()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            horaDVS.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
