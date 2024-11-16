namespace ElBarbasShop
{
    partial class FrmBuscarSedeBarberia
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
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtidsedebarberia = new System.Windows.Forms.TextBox();
            this.dgvbuscarbarberia = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvbuscarbarberia)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(467, 45);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 89;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(84, 55);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 88;
            this.label2.Text = "idSedeBarberia";
            // 
            // txtidsedebarberia
            // 
            this.txtidsedebarberia.Location = new System.Drawing.Point(194, 53);
            this.txtidsedebarberia.Margin = new System.Windows.Forms.Padding(4);
            this.txtidsedebarberia.Name = "txtidsedebarberia";
            this.txtidsedebarberia.Size = new System.Drawing.Size(235, 20);
            this.txtidsedebarberia.TabIndex = 87;
            this.txtidsedebarberia.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // dgvbuscarbarberia
            // 
            this.dgvbuscarbarberia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvbuscarbarberia.Location = new System.Drawing.Point(63, 141);
            this.dgvbuscarbarberia.Margin = new System.Windows.Forms.Padding(4);
            this.dgvbuscarbarberia.Name = "dgvbuscarbarberia";
            this.dgvbuscarbarberia.Size = new System.Drawing.Size(387, 241);
            this.dgvbuscarbarberia.TabIndex = 92;
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(350, 105);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 28);
            this.button4.TabIndex = 91;
            this.button4.Text = "Todos";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(63, 105);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 28);
            this.button3.TabIndex = 90;
            this.button3.Text = "Seleccionar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // FrmBuscarSedeBarberia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 496);
            this.Controls.Add(this.dgvbuscarbarberia);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtidsedebarberia);
            this.Name = "FrmBuscarSedeBarberia";
            this.Text = "FrmBuscarSedeBarberia";
            this.Load += new System.EventHandler(this.FrmBuscarSedeBarberia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvbuscarbarberia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtidsedebarberia;
        private System.Windows.Forms.DataGridView dgvbuscarbarberia;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
    }
}