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
    public partial class FrmMetodoPago : Form
    {
        public FrmMetodoPago()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            horaMP.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
