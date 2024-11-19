namespace ElBarbasShop
{
    partial class DetalleVentaProducto
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DetalleVentaProducto));
            this.btnAbrirBusquedaIdProducto = new System.Windows.Forms.Button();
            this.txtIdProducto = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button6 = new System.Windows.Forms.Button();
            this.dgvDVP = new System.Windows.Forms.DataGridView();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAbrirBusquedaIdVenta = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.txtIdDetalleVenta = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdVenta = new System.Windows.Forms.TextBox();
            this.horaDVP = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDVP)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAbrirBusquedaIdProducto
            // 
            this.btnAbrirBusquedaIdProducto.Location = new System.Drawing.Point(390, 317);
            this.btnAbrirBusquedaIdProducto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAbrirBusquedaIdProducto.Name = "btnAbrirBusquedaIdProducto";
            this.btnAbrirBusquedaIdProducto.Size = new System.Drawing.Size(28, 22);
            this.btnAbrirBusquedaIdProducto.TabIndex = 109;
            this.btnAbrirBusquedaIdProducto.Text = "...";
            this.btnAbrirBusquedaIdProducto.UseVisualStyleBackColor = true;
            this.btnAbrirBusquedaIdProducto.Click += new System.EventHandler(this.btnAbrirBusquedaIdProducto_Click);
            // 
            // txtIdProducto
            // 
            this.txtIdProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIdProducto.Location = new System.Drawing.Point(247, 317);
            this.txtIdProducto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIdProducto.Name = "txtIdProducto";
            this.txtIdProducto.Size = new System.Drawing.Size(116, 20);
            this.txtIdProducto.TabIndex = 108;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(964, 84);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(34, 34);
            this.pictureBox2.TabIndex = 107;
            this.pictureBox2.TabStop = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Red;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button6.Location = new System.Drawing.Point(862, 683);
            this.button6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(93, 33);
            this.button6.TabIndex = 106;
            this.button6.Text = "SALIR";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // dgvDVP
            // 
            this.dgvDVP.BackgroundColor = System.Drawing.Color.DarkGray;
            this.dgvDVP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDVP.GridColor = System.Drawing.SystemColors.Control;
            this.dgvDVP.Location = new System.Drawing.Point(448, 190);
            this.dgvDVP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvDVP.Name = "dgvDVP";
            this.dgvDVP.RowHeadersWidth = 51;
            this.dgvDVP.Size = new System.Drawing.Size(508, 470);
            this.dgvDVP.TabIndex = 105;
            this.dgvDVP.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDVP_CellContentClick);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Red;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminar.Location = new System.Drawing.Point(851, 135);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(88, 34);
            this.btnEliminar.TabIndex = 104;
            this.btnEliminar.Text = "ANULAR";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.White;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnActualizar.Location = new System.Drawing.Point(670, 135);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(88, 34);
            this.btnActualizar.TabIndex = 103;
            this.btnActualizar.Text = "ACTUALIZAR";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.Color.White;
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConsultar.Location = new System.Drawing.Point(490, 135);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(95, 34);
            this.btnConsultar.TabIndex = 102;
            this.btnConsultar.Text = "CONSULTAR";
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.White;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregar.Location = new System.Drawing.Point(262, 430);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(88, 30);
            this.btnAgregar.TabIndex = 101;
            this.btnAgregar.Text = "AGREGAR";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Silver;
            this.label7.Location = new System.Drawing.Point(29, 72);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(602, 44);
            this.label7.TabIndex = 97;
            this.label7.Text = "DETALLE DE VENTA DE PRODUCTO";
            // 
            // btnAbrirBusquedaIdVenta
            // 
            this.btnAbrirBusquedaIdVenta.Location = new System.Drawing.Point(390, 250);
            this.btnAbrirBusquedaIdVenta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAbrirBusquedaIdVenta.Name = "btnAbrirBusquedaIdVenta";
            this.btnAbrirBusquedaIdVenta.Size = new System.Drawing.Size(28, 22);
            this.btnAbrirBusquedaIdVenta.TabIndex = 100;
            this.btnAbrirBusquedaIdVenta.Text = "...";
            this.btnAbrirBusquedaIdVenta.UseVisualStyleBackColor = true;
            this.btnAbrirBusquedaIdVenta.Click += new System.EventHandler(this.btnAbrirBusquedaIdVenta_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(479, 226);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(28, 22);
            this.button2.TabIndex = 99;
            this.button2.Text = "...";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(479, 420);
            this.button7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(28, 22);
            this.button7.TabIndex = 98;
            this.button7.Text = "...";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(479, 346);
            this.button9.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(28, 22);
            this.button9.TabIndex = 96;
            this.button9.Text = "...";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // txtIdDetalleVenta
            // 
            this.txtIdDetalleVenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIdDetalleVenta.Location = new System.Drawing.Point(247, 190);
            this.txtIdDetalleVenta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIdDetalleVenta.Name = "txtIdDetalleVenta";
            this.txtIdDetalleVenta.Size = new System.Drawing.Size(116, 20);
            this.txtIdDetalleVenta.TabIndex = 95;
            // 
            // txtCantidad
            // 
            this.txtCantidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCantidad.Location = new System.Drawing.Point(247, 371);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(116, 20);
            this.txtCantidad.TabIndex = 94;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(158, 373);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 17);
            this.label5.TabIndex = 93;
            this.label5.Text = "Cantidad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(146, 316);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 17);
            this.label4.TabIndex = 92;
            this.label4.Text = "idProducto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(166, 254);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 17);
            this.label3.TabIndex = 91;
            this.label3.Text = "idVenta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(122, 192);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 17);
            this.label2.TabIndex = 90;
            this.label2.Text = "idDetalleVenta ";
            // 
            // txtIdVenta
            // 
            this.txtIdVenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIdVenta.Location = new System.Drawing.Point(247, 253);
            this.txtIdVenta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIdVenta.Name = "txtIdVenta";
            this.txtIdVenta.Size = new System.Drawing.Size(116, 20);
            this.txtIdVenta.TabIndex = 89;
            // 
            // horaDVP
            // 
            this.horaDVP.AutoSize = true;
            this.horaDVP.BackColor = System.Drawing.Color.Transparent;
            this.horaDVP.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.horaDVP.ForeColor = System.Drawing.Color.White;
            this.horaDVP.Location = new System.Drawing.Point(2, 2);
            this.horaDVP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.horaDVP.Name = "horaDVP";
            this.horaDVP.Size = new System.Drawing.Size(68, 26);
            this.horaDVP.TabIndex = 110;
            this.horaDVP.Text = "        ";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // DetalleVentaProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1026, 789);
            this.Controls.Add(this.horaDVP);
            this.Controls.Add(this.btnAbrirBusquedaIdProducto);
            this.Controls.Add(this.txtIdProducto);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.dgvDVP);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnAbrirBusquedaIdVenta);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.txtIdDetalleVenta);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIdVenta);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DetalleVentaProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EL BARBAS";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDVP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAbrirBusquedaIdProducto;
        private System.Windows.Forms.TextBox txtIdProducto;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.DataGridView dgvDVP;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnAbrirBusquedaIdVenta;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.TextBox txtIdDetalleVenta;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIdVenta;
        private System.Windows.Forms.Label horaDVP;
        private System.Windows.Forms.Timer timer1;
    }
}