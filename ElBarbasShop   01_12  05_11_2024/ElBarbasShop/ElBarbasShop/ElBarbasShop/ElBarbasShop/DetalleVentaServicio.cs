﻿using System;
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
    public partial class DetalleVentaServicio : Form
    {
        public DetalleVentaServicio()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            horaDVS.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            FrmPrincipal1 frm = new FrmPrincipal1();
            frm.Show();
            this.Close();
        }
    }
}
