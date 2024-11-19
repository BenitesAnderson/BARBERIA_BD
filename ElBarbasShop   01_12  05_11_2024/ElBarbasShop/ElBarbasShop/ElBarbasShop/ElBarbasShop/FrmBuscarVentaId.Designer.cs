namespace ElBarbasShop
{
    partial class FrmBuscarVentaId
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
            this.btnMostrar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnSelec = new System.Windows.Forms.Button();
            this.dgvBuscarIdVenta = new System.Windows.Forms.DataGridView();
            this.txtidsedebarberia = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscarIdVenta)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(518, 99);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(75, 23);
            this.btnMostrar.TabIndex = 0;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(489, 30);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.Text = "btnBuscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnSelec
            // 
            this.btnSelec.Location = new System.Drawing.Point(231, 99);
            this.btnSelec.Name = "btnSelec";
            this.btnSelec.Size = new System.Drawing.Size(75, 23);
            this.btnSelec.TabIndex = 2;
            this.btnSelec.Text = "Seleccionar";
            this.btnSelec.UseVisualStyleBackColor = true;
            this.btnSelec.Click += new System.EventHandler(this.btnSelec_Click);
            // 
            // dgvBuscarIdVenta
            // 
            this.dgvBuscarIdVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBuscarIdVenta.Location = new System.Drawing.Point(262, 199);
            this.dgvBuscarIdVenta.Name = "dgvBuscarIdVenta";
            this.dgvBuscarIdVenta.Size = new System.Drawing.Size(240, 150);
            this.dgvBuscarIdVenta.TabIndex = 3;
            // 
            // txtidsedebarberia
            // 
            this.txtidsedebarberia.Location = new System.Drawing.Point(262, 40);
            this.txtidsedebarberia.Name = "txtidsedebarberia";
            this.txtidsedebarberia.Size = new System.Drawing.Size(100, 20);
            this.txtidsedebarberia.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(131, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Bucar id Venta";
            // 
            // FrmBuscarVentaId
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtidsedebarberia);
            this.Controls.Add(this.dgvBuscarIdVenta);
            this.Controls.Add(this.btnSelec);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnMostrar);
            this.Name = "FrmBuscarVentaId";
            this.Text = "FrmBuscarVentaId";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscarIdVenta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnSelec;
        private System.Windows.Forms.DataGridView dgvBuscarIdVenta;
        private System.Windows.Forms.TextBox txtidsedebarberia;
        private System.Windows.Forms.Label label1;
    }
}