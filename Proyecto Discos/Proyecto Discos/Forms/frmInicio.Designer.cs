namespace Proyecto_Discos
{
    partial class frmInicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInicio));
            this.btnListadoDiscos = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnListadoDiscos
            // 
            this.btnListadoDiscos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(70)))), ((int)(((byte)(90)))));
            this.btnListadoDiscos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnListadoDiscos.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnListadoDiscos, "btnListadoDiscos");
            this.btnListadoDiscos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(247)))), ((int)(((byte)(242)))));
            this.btnListadoDiscos.Name = "btnListadoDiscos";
            this.btnListadoDiscos.UseVisualStyleBackColor = false;
            this.btnListadoDiscos.Click += new System.EventHandler(this.btnListadoDiscos_Click);
            // 
            // lblTitulo
            // 
            resources.ApplyResources(this.lblTitulo, "lblTitulo");
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(70)))), ((int)(((byte)(90)))));
            this.lblTitulo.Name = "lblTitulo";
            // 
            // frmInicio
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(247)))), ((int)(((byte)(242)))));
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnListadoDiscos);
            this.Name = "frmInicio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnListadoDiscos;
        private System.Windows.Forms.Label lblTitulo;
    }
}

