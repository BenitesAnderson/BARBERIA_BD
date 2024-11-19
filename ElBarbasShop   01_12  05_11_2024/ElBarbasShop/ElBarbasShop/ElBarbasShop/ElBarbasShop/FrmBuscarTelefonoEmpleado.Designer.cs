namespace ElBarbasShop
{
    partial class FrmBuscarTelefonoEmpleado
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
            this.dgvbuscarbarberia = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtidsedebarberia = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvbuscarbarberia)).BeginInit();
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
            this.horaBSB.TabIndex = 112;
            this.horaBSB.Text = "        ";
            // 
            // dgvbuscarbarberia
            // 
            this.dgvbuscarbarberia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvbuscarbarberia.Location = new System.Drawing.Point(121, 162);
            this.dgvbuscarbarberia.Margin = new System.Windows.Forms.Padding(5);
            this.dgvbuscarbarberia.Name = "dgvbuscarbarberia";
            this.dgvbuscarbarberia.RowHeadersWidth = 51;
            this.dgvbuscarbarberia.Size = new System.Drawing.Size(516, 297);
            this.dgvbuscarbarberia.TabIndex = 111;
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Location = new System.Drawing.Point(501, 117);
            this.button4.Margin = new System.Windows.Forms.Padding(5);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(136, 34);
            this.button4.TabIndex = 110;
            this.button4.Text = "MOSTRAR TODO";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Location = new System.Drawing.Point(121, 117);
            this.button3.Margin = new System.Windows.Forms.Padding(5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(131, 34);
            this.button3.TabIndex = 109;
            this.button3.Text = "SELECCIONAR";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(660, 43);
            this.button1.Margin = new System.Windows.Forms.Padding(5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 44);
            this.button1.TabIndex = 108;
            this.button1.Text = "BUSCAR";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(174, 55);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 20);
            this.label2.TabIndex = 107;
            this.label2.Text = "ID Telefono:";
            // 
            // txtidsedebarberia
            // 
            this.txtidsedebarberia.Location = new System.Drawing.Point(296, 53);
            this.txtidsedebarberia.Margin = new System.Windows.Forms.Padding(5);
            this.txtidsedebarberia.Name = "txtidsedebarberia";
            this.txtidsedebarberia.Size = new System.Drawing.Size(312, 22);
            this.txtidsedebarberia.TabIndex = 106;
            // 
            // FrmBuscarTelefonoEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 536);
            this.Controls.Add(this.horaBSB);
            this.Controls.Add(this.dgvbuscarbarberia);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtidsedebarberia);
            this.Name = "FrmBuscarTelefonoEmpleado";
            this.Text = "FrmBuscarTelefonoEmpleado";
            ((System.ComponentModel.ISupportInitialize)(this.dgvbuscarbarberia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label horaBSB;
        private System.Windows.Forms.DataGridView dgvbuscarbarberia;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtidsedebarberia;
    }
}