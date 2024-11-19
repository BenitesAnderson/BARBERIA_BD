namespace ElBarbasShop
{
    partial class FrmServicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmServicio));
            this.button6 = new System.Windows.Forms.Button();
            this.dgvservicio = new System.Windows.Forms.DataGridView();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtnombreservicio = new System.Windows.Forms.TextBox();
            this.txtduracion = new System.Windows.Forms.TextBox();
            this.txtprecio = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtidservicio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.horaS = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvservicio)).BeginInit();
            this.SuspendLayout();
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Red;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button6.Location = new System.Drawing.Point(1300, 775);
            this.button6.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(133, 49);
            this.button6.TabIndex = 91;
            this.button6.Text = "SALIR";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // dgvservicio
            // 
            this.dgvservicio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvservicio.Location = new System.Drawing.Point(756, 175);
            this.dgvservicio.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.dgvservicio.Name = "dgvservicio";
            this.dgvservicio.RowHeadersWidth = 51;
            this.dgvservicio.Size = new System.Drawing.Size(691, 567);
            this.dgvservicio.TabIndex = 90;
            this.dgvservicio.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvservicio_CellClick);
            this.dgvservicio.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvservicio_CellContentClick);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Red;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.Location = new System.Drawing.Point(1300, 121);
            this.button5.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(133, 46);
            this.button5.TabIndex = 89;
            this.button5.Text = "ELIMINAR";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Location = new System.Drawing.Point(925, 119);
            this.button4.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(133, 46);
            this.button4.TabIndex = 88;
            this.button4.Text = "ACTUALIZAR";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Location = new System.Drawing.Point(756, 119);
            this.button3.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(136, 46);
            this.button3.TabIndex = 87;
            this.button3.Text = "CONSULTAR";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(427, 570);
            this.button1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 49);
            this.button1.TabIndex = 86;
            this.button1.Text = "AGREGAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.White;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Location = new System.Drawing.Point(868, 362);
            this.button7.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(53, 33);
            this.button7.TabIndex = 85;
            this.button7.Text = "...";
            this.button7.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(868, 262);
            this.button2.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(53, 33);
            this.button2.TabIndex = 82;
            this.button2.Text = "...";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // txtnombreservicio
            // 
            this.txtnombreservicio.Location = new System.Drawing.Point(417, 357);
            this.txtnombreservicio.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtnombreservicio.Name = "txtnombreservicio";
            this.txtnombreservicio.Size = new System.Drawing.Size(175, 22);
            this.txtnombreservicio.TabIndex = 81;
            // 
            // txtduracion
            // 
            this.txtduracion.Location = new System.Drawing.Point(417, 418);
            this.txtduracion.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtduracion.Name = "txtduracion";
            this.txtduracion.Size = new System.Drawing.Size(175, 22);
            this.txtduracion.TabIndex = 80;
            // 
            // txtprecio
            // 
            this.txtprecio.Location = new System.Drawing.Point(417, 474);
            this.txtprecio.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.Size = new System.Drawing.Size(175, 22);
            this.txtprecio.TabIndex = 79;
            this.txtprecio.TextChanged += new System.EventHandler(this.txtprecio_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(288, 474);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 20);
            this.label5.TabIndex = 78;
            this.label5.Text = "Precio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(268, 420);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 20);
            this.label4.TabIndex = 77;
            this.label4.Text = "Duracion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(247, 306);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 20);
            this.label3.TabIndex = 76;
            this.label3.Text = "ID Servicio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(172, 359);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 20);
            this.label2.TabIndex = 75;
            this.label2.Text = "Nombre del servicio";
            // 
            // txtidservicio
            // 
            this.txtidservicio.Location = new System.Drawing.Point(417, 306);
            this.txtidservicio.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtidservicio.Name = "txtidservicio";
            this.txtidservicio.Size = new System.Drawing.Size(175, 22);
            this.txtidservicio.TabIndex = 74;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(333, 175);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 51);
            this.label1.TabIndex = 73;
            this.label1.Text = "Servicio";
            // 
            // horaS
            // 
            this.horaS.AutoSize = true;
            this.horaS.BackColor = System.Drawing.Color.Transparent;
            this.horaS.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.horaS.ForeColor = System.Drawing.Color.White;
            this.horaS.Location = new System.Drawing.Point(3, 2);
            this.horaS.Name = "horaS";
            this.horaS.Size = new System.Drawing.Size(78, 31);
            this.horaS.TabIndex = 111;
            this.horaS.Text = "        ";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button8
            // 
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button8.Location = new System.Drawing.Point(1103, 119);
            this.button8.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(172, 46);
            this.button8.TabIndex = 112;
            this.button8.Text = "MOSTRAR TODO";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button9.Location = new System.Drawing.Point(227, 570);
            this.button9.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(133, 49);
            this.button9.TabIndex = 113;
            this.button9.Text = "LIMPIAR";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // FrmServicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1716, 924);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.horaS);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.dgvservicio);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtnombreservicio);
            this.Controls.Add(this.txtduracion);
            this.Controls.Add(this.txtprecio);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtidservicio);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmServicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EL BARBAS";
            this.Load += new System.EventHandler(this.FrmServicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvservicio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.DataGridView dgvservicio;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtnombreservicio;
        private System.Windows.Forms.TextBox txtduracion;
        private System.Windows.Forms.TextBox txtprecio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtidservicio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label horaS;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
    }
}