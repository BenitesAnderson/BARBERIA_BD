using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidad;
using CapaLogica;
namespace ElBarbasShop
{
    public partial class FrmServicio : Form
    {
        public FrmServicio()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            horaS.Text = DateTime.Now.ToString("HH:mm:ss");
        }


    }

}        