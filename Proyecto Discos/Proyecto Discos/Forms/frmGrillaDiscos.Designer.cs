namespace Proyecto_Discos.Forms
{
    partial class frmGrillaDiscos
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
            this.dgvListado = new System.Windows.Forms.DataGridView();
            this.picDisco = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.lblFiltrarPor = new System.Windows.Forms.Label();
            this.cboFiltroCampo = new System.Windows.Forms.ComboBox();
            this.lblFiltroCampo = new System.Windows.Forms.Label();
            this.lblFiltroCriterio = new System.Windows.Forms.Label();
            this.cboFiltroCiterio = new System.Windows.Forms.ComboBox();
            this.lblFiltroAvanzado = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtFiltroAvanzado = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDisco)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListado
            // 
            this.dgvListado.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(247)))), ((int)(((byte)(242)))));
            this.dgvListado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListado.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvListado.Location = new System.Drawing.Point(12, 258);
            this.dgvListado.MultiSelect = false;
            this.dgvListado.Name = "dgvListado";
            this.dgvListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListado.Size = new System.Drawing.Size(644, 370);
            this.dgvListado.TabIndex = 0;
            this.dgvListado.SelectionChanged += new System.EventHandler(this.dgvListado_SelectionChanged);
            // 
            // picDisco
            // 
            this.picDisco.Location = new System.Drawing.Point(667, 295);
            this.picDisco.Name = "picDisco";
            this.picDisco.Size = new System.Drawing.Size(307, 283);
            this.picDisco.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picDisco.TabIndex = 1;
            this.picDisco.TabStop = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(70)))), ((int)(((byte)(90)))));
            this.lblTitulo.Location = new System.Drawing.Point(342, 29);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(284, 45);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "Listado de albums";
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(70)))), ((int)(((byte)(90)))));
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnAgregar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(247)))), ((int)(((byte)(242)))));
            this.btnAgregar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAgregar.Location = new System.Drawing.Point(263, 643);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(135, 44);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "Agregar Nuevo ";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(70)))), ((int)(((byte)(90)))));
            this.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnModificar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(247)))), ((int)(((byte)(242)))));
            this.btnModificar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnModificar.Location = new System.Drawing.Point(674, 643);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(135, 44);
            this.btnModificar.TabIndex = 5;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Firebrick;
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnEliminar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(247)))), ((int)(((byte)(242)))));
            this.btnEliminar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnEliminar.Location = new System.Drawing.Point(828, 643);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(135, 44);
            this.btnEliminar.TabIndex = 6;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(383, 106);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(256, 20);
            this.txtBuscar.TabIndex = 7;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(70)))), ((int)(((byte)(90)))));
            this.lblBuscar.Location = new System.Drawing.Point(321, 103);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(56, 21);
            this.lblBuscar.TabIndex = 8;
            this.lblBuscar.Text = "Buscar";
            // 
            // lblFiltrarPor
            // 
            this.lblFiltrarPor.AutoSize = true;
            this.lblFiltrarPor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltrarPor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(70)))), ((int)(((byte)(90)))));
            this.lblFiltrarPor.Location = new System.Drawing.Point(13, 133);
            this.lblFiltrarPor.Name = "lblFiltrarPor";
            this.lblFiltrarPor.Size = new System.Drawing.Size(84, 21);
            this.lblFiltrarPor.TabIndex = 9;
            this.lblFiltrarPor.Text = "Filtrar por ";
            // 
            // cboFiltroCampo
            // 
            this.cboFiltroCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFiltroCampo.FormattingEnabled = true;
            this.cboFiltroCampo.Location = new System.Drawing.Point(80, 185);
            this.cboFiltroCampo.Name = "cboFiltroCampo";
            this.cboFiltroCampo.Size = new System.Drawing.Size(124, 21);
            this.cboFiltroCampo.TabIndex = 10;
            this.cboFiltroCampo.SelectedIndexChanged += new System.EventHandler(this.cboFiltroCampo_SelectedIndexChanged);
            // 
            // lblFiltroCampo
            // 
            this.lblFiltroCampo.AutoSize = true;
            this.lblFiltroCampo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltroCampo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(70)))), ((int)(((byte)(90)))));
            this.lblFiltroCampo.Location = new System.Drawing.Point(13, 183);
            this.lblFiltroCampo.Name = "lblFiltroCampo";
            this.lblFiltroCampo.Size = new System.Drawing.Size(64, 21);
            this.lblFiltroCampo.TabIndex = 11;
            this.lblFiltroCampo.Text = "Campo";
            // 
            // lblFiltroCriterio
            // 
            this.lblFiltroCriterio.AutoSize = true;
            this.lblFiltroCriterio.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltroCriterio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(70)))), ((int)(((byte)(90)))));
            this.lblFiltroCriterio.Location = new System.Drawing.Point(218, 184);
            this.lblFiltroCriterio.Name = "lblFiltroCriterio";
            this.lblFiltroCriterio.Size = new System.Drawing.Size(67, 21);
            this.lblFiltroCriterio.TabIndex = 13;
            this.lblFiltroCriterio.Text = "Criterio";
            // 
            // cboFiltroCiterio
            // 
            this.cboFiltroCiterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFiltroCiterio.FormattingEnabled = true;
            this.cboFiltroCiterio.Location = new System.Drawing.Point(290, 186);
            this.cboFiltroCiterio.Name = "cboFiltroCiterio";
            this.cboFiltroCiterio.Size = new System.Drawing.Size(137, 21);
            this.cboFiltroCiterio.TabIndex = 12;
            // 
            // lblFiltroAvanzado
            // 
            this.lblFiltroAvanzado.AutoSize = true;
            this.lblFiltroAvanzado.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltroAvanzado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(70)))), ((int)(((byte)(90)))));
            this.lblFiltroAvanzado.Location = new System.Drawing.Point(447, 185);
            this.lblFiltroAvanzado.Name = "lblFiltroAvanzado";
            this.lblFiltroAvanzado.Size = new System.Drawing.Size(55, 21);
            this.lblFiltroAvanzado.TabIndex = 15;
            this.lblFiltroAvanzado.Text = "Filtrar";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(70)))), ((int)(((byte)(90)))));
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(247)))), ((int)(((byte)(242)))));
            this.btnBuscar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnBuscar.Location = new System.Drawing.Point(812, 170);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(92, 45);
            this.btnBuscar.TabIndex = 16;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtFiltroAvanzado
            // 
            this.txtFiltroAvanzado.Location = new System.Drawing.Point(505, 187);
            this.txtFiltroAvanzado.Name = "txtFiltroAvanzado";
            this.txtFiltroAvanzado.Size = new System.Drawing.Size(163, 20);
            this.txtFiltroAvanzado.TabIndex = 18;
            // 
            // frmGrillaDiscos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(247)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(984, 700);
            this.Controls.Add(this.txtFiltroAvanzado);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblFiltroAvanzado);
            this.Controls.Add(this.lblFiltroCriterio);
            this.Controls.Add(this.cboFiltroCiterio);
            this.Controls.Add(this.lblFiltroCampo);
            this.Controls.Add(this.cboFiltroCampo);
            this.Controls.Add(this.lblFiltrarPor);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.picDisco);
            this.Controls.Add(this.dgvListado);
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "frmGrillaDiscos";
            this.Text = "GRILLA DE ALBUMS";
            this.Load += new System.EventHandler(this.frmGrillaDiscos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDisco)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListado;
        private System.Windows.Forms.PictureBox picDisco;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.Label lblFiltrarPor;
        private System.Windows.Forms.ComboBox cboFiltroCampo;
        private System.Windows.Forms.Label lblFiltroCampo;
        private System.Windows.Forms.Label lblFiltroCriterio;
        private System.Windows.Forms.ComboBox cboFiltroCiterio;
        private System.Windows.Forms.Label lblFiltroAvanzado;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtFiltroAvanzado;
    }
}