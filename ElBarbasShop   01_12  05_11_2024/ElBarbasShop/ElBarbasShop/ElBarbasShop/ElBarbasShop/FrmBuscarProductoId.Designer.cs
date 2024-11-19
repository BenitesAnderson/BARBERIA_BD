namespace ElBarbasShop
{
    partial class FrmBuscarProductoId
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
            this.btnBuscar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.bntSelec = new System.Windows.Forms.Button();
            this.txtidsedebarberia = new System.Windows.Forms.TextBox();
            this.lblno = new System.Windows.Forms.Label();
            this.dgvBuscarIdProducto = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscarIdProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(436, 61);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 0;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(420, 178);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Mostrar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // bntSelec
            // 
            this.bntSelec.Location = new System.Drawing.Point(222, 178);
            this.bntSelec.Name = "bntSelec";
            this.bntSelec.Size = new System.Drawing.Size(75, 23);
            this.bntSelec.TabIndex = 2;
            this.bntSelec.Text = "Seleccionar";
            this.bntSelec.UseVisualStyleBackColor = true;
            this.bntSelec.Click += new System.EventHandler(this.bntSelec_Click);
            // 
            // txtidsedebarberia
            // 
            this.txtidsedebarberia.Location = new System.Drawing.Point(302, 63);
            this.txtidsedebarberia.Name = "txtidsedebarberia";
            this.txtidsedebarberia.Size = new System.Drawing.Size(100, 20);
            this.txtidsedebarberia.TabIndex = 3;
            // 
            // lblno
            // 
            this.lblno.AutoSize = true;
            this.lblno.Location = new System.Drawing.Point(176, 67);
            this.lblno.Name = "lblno";
            this.lblno.Size = new System.Drawing.Size(98, 13);
            this.lblno.TabIndex = 4;
            this.lblno.Text = "Buscar Id Producto";
            // 
            // dgvBuscarIdProducto
            // 
            this.dgvBuscarIdProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBuscarIdProducto.Location = new System.Drawing.Point(255, 231);
            this.dgvBuscarIdProducto.Name = "dgvBuscarIdProducto";
            this.dgvBuscarIdProducto.Size = new System.Drawing.Size(240, 150);
            this.dgvBuscarIdProducto.TabIndex = 5;
            // 
            // FrmBuscarProductoId
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvBuscarIdProducto);
            this.Controls.Add(this.lblno);
            this.Controls.Add(this.txtidsedebarberia);
            this.Controls.Add(this.bntSelec);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnBuscar);
            this.Name = "FrmBuscarProductoId";
            this.Text = "FrmBuscarProductoId";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscarIdProducto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button bntSelec;
        private System.Windows.Forms.TextBox txtidsedebarberia;
        private System.Windows.Forms.Label lblno;
        private System.Windows.Forms.DataGridView dgvBuscarIdProducto;
    }
}