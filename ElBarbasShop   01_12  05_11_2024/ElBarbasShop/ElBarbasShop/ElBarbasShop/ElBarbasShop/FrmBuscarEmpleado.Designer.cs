namespace ElBarbasShop
{
    partial class FrmBuscarEmpleado
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.horaBSB = new System.Windows.Forms.Label();
            this.dgvbuscar = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtidempleado = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvbuscar)).BeginInit();
            this.SuspendLayout();
            // 
            // horaBSB
            // 
            this.horaBSB.AutoSize = true;
            this.horaBSB.BackColor = System.Drawing.Color.Transparent;
            this.horaBSB.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.horaBSB.ForeColor = System.Drawing.Color.White;
            this.horaBSB.Location = new System.Drawing.Point(39, -9);
            this.horaBSB.Name = "horaBSB";
            this.horaBSB.Size = new System.Drawing.Size(78, 31);
            this.horaBSB.TabIndex = 119;
            this.horaBSB.Text = "        ";
            // 
            // dgvbuscar
            // 
            this.dgvbuscar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvbuscar.Location = new System.Drawing.Point(121, 162);
            this.dgvbuscar.Margin = new System.Windows.Forms.Padding(5);
            this.dgvbuscar.Name = "dgvbuscar";
            this.dgvbuscar.RowHeadersWidth = 51;
            this.dgvbuscar.Size = new System.Drawing.Size(516, 297);
            this.dgvbuscar.TabIndex = 118;
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Location = new System.Drawing.Point(501, 117);
            this.button4.Margin = new System.Windows.Forms.Padding(5);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(136, 34);
            this.button4.TabIndex = 117;
            this.button4.Text = "MOSTRAR TODO";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Location = new System.Drawing.Point(121, 117);
            this.button3.Margin = new System.Windows.Forms.Padding(5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(131, 34);
            this.button3.TabIndex = 116;
            this.button3.Text = "SELECCIONAR";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(660, 43);
            this.button1.Margin = new System.Windows.Forms.Padding(5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 44);
            this.button1.TabIndex = 115;
            this.button1.Text = "BUSCAR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(164, 55);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 20);
            this.label2.TabIndex = 114;
            this.label2.Text = "ID Empleado:";
            // 
            // txtidempleado
            // 
            this.txtidempleado.Location = new System.Drawing.Point(296, 53);
            this.txtidempleado.Margin = new System.Windows.Forms.Padding(5);
            this.txtidempleado.Name = "txtidempleado";
            this.txtidempleado.Size = new System.Drawing.Size(312, 22);
            this.txtidempleado.TabIndex = 113;
            // 
            // FrmBuscarEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 522);
            this.Controls.Add(this.horaBSB);
            this.Controls.Add(this.dgvbuscar);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtidempleado);
            this.Name = "FrmBuscarEmpleado";
            this.Text = "BuscarEmpleado";
            ((System.ComponentModel.ISupportInitialize)(this.dgvbuscar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label horaBSB;
        private System.Windows.Forms.DataGridView dgvbuscar;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtidempleado;
    }
}