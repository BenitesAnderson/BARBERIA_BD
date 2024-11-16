namespace ElBarbasShop
{
    partial class Frmprincipal
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
            this.pnlContenido = new System.Windows.Forms.Panel();
            this.pnlOpcion = new System.Windows.Forms.Panel();
            this.pnlSuperior = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pnlContenido
            // 
            this.pnlContenido.Location = new System.Drawing.Point(594, 289);
            this.pnlContenido.Name = "pnlContenido";
            this.pnlContenido.Size = new System.Drawing.Size(200, 100);
            this.pnlContenido.TabIndex = 6;
            // 
            // pnlOpcion
            // 
            this.pnlOpcion.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlOpcion.Location = new System.Drawing.Point(0, 66);
            this.pnlOpcion.Name = "pnlOpcion";
            this.pnlOpcion.Size = new System.Drawing.Size(200, 564);
            this.pnlOpcion.TabIndex = 5;
            // 
            // pnlSuperior
            // 
            this.pnlSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSuperior.Location = new System.Drawing.Point(0, 0);
            this.pnlSuperior.Name = "pnlSuperior";
            this.pnlSuperior.Size = new System.Drawing.Size(981, 66);
            this.pnlSuperior.TabIndex = 4;
            // 
            // Frmprincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 630);
            this.Controls.Add(this.pnlContenido);
            this.Controls.Add(this.pnlOpcion);
            this.Controls.Add(this.pnlSuperior);
            this.Name = "Frmprincipal";
            this.Text = "Frmprincipal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlContenido;
        private System.Windows.Forms.Panel pnlOpcion;
        private System.Windows.Forms.Panel pnlSuperior;
    }
}