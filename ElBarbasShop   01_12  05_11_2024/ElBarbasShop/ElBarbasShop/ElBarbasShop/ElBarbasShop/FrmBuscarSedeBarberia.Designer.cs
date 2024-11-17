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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBuscarSedeBarberia));
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtidsedebarberia = new System.Windows.Forms.TextBox();
            this.dgvbuscarbarberia = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.horaBSB = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvbuscarbarberia)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(623, 55);
            this.button1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 44);
            this.button1.TabIndex = 89;
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
            this.label2.Location = new System.Drawing.Point(158, 68);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 88;
            this.label2.Text = "ID Sede:";
            // 
            // txtidsedebarberia
            // 
            this.txtidsedebarberia.Location = new System.Drawing.Point(259, 65);
            this.txtidsedebarberia.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtidsedebarberia.Name = "txtidsedebarberia";
            this.txtidsedebarberia.Size = new System.Drawing.Size(312, 22);
            this.txtidsedebarberia.TabIndex = 87;
            this.txtidsedebarberia.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // dgvbuscarbarberia
            // 
            this.dgvbuscarbarberia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvbuscarbarberia.Location = new System.Drawing.Point(84, 174);
            this.dgvbuscarbarberia.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.dgvbuscarbarberia.Name = "dgvbuscarbarberia";
            this.dgvbuscarbarberia.RowHeadersWidth = 51;
            this.dgvbuscarbarberia.Size = new System.Drawing.Size(516, 297);
            this.dgvbuscarbarberia.TabIndex = 92;
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Location = new System.Drawing.Point(464, 129);
            this.button4.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(136, 34);
            this.button4.TabIndex = 91;
            this.button4.Text = "MOSTRAR TODO";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Location = new System.Drawing.Point(84, 129);
            this.button3.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(131, 34);
            this.button3.TabIndex = 90;
            this.button3.Text = "SELECCIONAR";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // horaBSB
            // 
            this.horaBSB.AutoSize = true;
            this.horaBSB.BackColor = System.Drawing.Color.Transparent;
            this.horaBSB.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.horaBSB.ForeColor = System.Drawing.Color.White;
            this.horaBSB.Location = new System.Drawing.Point(2, 3);
            this.horaBSB.Name = "horaBSB";
            this.horaBSB.Size = new System.Drawing.Size(78, 31);
            this.horaBSB.TabIndex = 105;
            this.horaBSB.Text = "        ";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FrmBuscarSedeBarberia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(850, 619);
            this.Controls.Add(this.horaBSB);
            this.Controls.Add(this.dgvbuscarbarberia);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtidsedebarberia);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmBuscarSedeBarberia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EL BARBAS";
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
        private System.Windows.Forms.Label horaBSB;
        private System.Windows.Forms.Timer timer1;
    }
}