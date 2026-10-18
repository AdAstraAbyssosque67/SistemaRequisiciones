namespace SistemaRequisiciones.Presentacion
{
    partial class FrmArticulos
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle estiloEncabezado_dgvArticulos = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle estiloCelda_dgvArticulos = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle estiloColumna_colPrecio = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelEncabezado = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.dgvArticulos = new System.Windows.Forms.DataGridView();
            this.colCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colActivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chkSoloActivos = new System.Windows.Forms.CheckBox();
            this.panelEdicion = new System.Windows.Forms.Panel();
            this.lblTituloEdicion = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.nudPrecio = new System.Windows.Forms.NumericUpDown();
            this.chkActivo = new System.Windows.Forms.CheckBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.panelAcciones = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecio)).BeginInit();
            this.panelEncabezado.SuspendLayout();
            this.panelEdicion.SuspendLayout();
            this.panelAcciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelEncabezado
            // 
            this.panelEncabezado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(115)))), ((int)(((byte)(150)))));
            this.panelEncabezado.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelEncabezado.Location = new System.Drawing.Point(0, 0);
            this.panelEncabezado.Size = new System.Drawing.Size(900, 56);
            this.panelEncabezado.Name = "panelEncabezado";
            this.panelEncabezado.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblTitulo.Location = new System.Drawing.Point(24, 12);
            this.lblTitulo.Text = "Catálogo de artículos";
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.TabIndex = 0;
            // 
            // dgvArticulos
            // 
            estiloEncabezado_dgvArticulos.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            estiloEncabezado_dgvArticulos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(248)))));
            estiloEncabezado_dgvArticulos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            estiloEncabezado_dgvArticulos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(66)))));
            estiloEncabezado_dgvArticulos.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(248)))));
            estiloEncabezado_dgvArticulos.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(66)))));
            estiloEncabezado_dgvArticulos.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            estiloCelda_dgvArticulos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            estiloCelda_dgvArticulos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            estiloCelda_dgvArticulos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(66)))));
            estiloCelda_dgvArticulos.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(230)))), ((int)(((byte)(242)))));
            estiloCelda_dgvArticulos.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(66)))));
            this.dgvArticulos.AllowUserToAddRows = false;
            this.dgvArticulos.AllowUserToDeleteRows = false;
            this.dgvArticulos.AllowUserToResizeRows = false;
            this.dgvArticulos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvArticulos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvArticulos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvArticulos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvArticulos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvArticulos.ColumnHeadersDefaultCellStyle = estiloEncabezado_dgvArticulos;
            this.dgvArticulos.ColumnHeadersHeight = 28;
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvArticulos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodigo,
            this.colNombre,
            this.colPrecio,
            this.colActivo});
            this.dgvArticulos.DefaultCellStyle = estiloCelda_dgvArticulos;
            this.dgvArticulos.EnableHeadersVisualStyles = false;
            this.dgvArticulos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(230)))), ((int)(((byte)(236)))));
            this.dgvArticulos.MultiSelect = false;
            this.dgvArticulos.ReadOnly = true;
            this.dgvArticulos.RowHeadersVisible = false;
            this.dgvArticulos.RowTemplate.Height = 26;
            this.dgvArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArticulos.Location = new System.Drawing.Point(24, 72);
            this.dgvArticulos.Size = new System.Drawing.Size(560, 420);
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.TabIndex = 1;
            this.dgvArticulos.SelectionChanged += new System.EventHandler(this.dgvArticulos_SelectionChanged);
            // 
            // colCodigo
            // 
            this.colCodigo.FillWeight = 16F;
            this.colCodigo.HeaderText = "Código";
            this.colCodigo.Name = "colCodigo";
            this.colCodigo.ReadOnly = true;
            // 
            // colNombre
            // 
            this.colNombre.FillWeight = 40F;
            this.colNombre.HeaderText = "Nombre";
            this.colNombre.Name = "colNombre";
            this.colNombre.ReadOnly = true;
            // 
            // colPrecio
            // 
            estiloColumna_colPrecio.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            estiloColumna_colPrecio.Format = "N2";
            this.colPrecio.DefaultCellStyle = estiloColumna_colPrecio;
            this.colPrecio.FillWeight = 30F;
            this.colPrecio.HeaderText = "Precio de referencia";
            this.colPrecio.Name = "colPrecio";
            this.colPrecio.ReadOnly = true;
            // 
            // colActivo
            // 
            this.colActivo.FillWeight = 14F;
            this.colActivo.HeaderText = "Activo";
            this.colActivo.Name = "colActivo";
            this.colActivo.ReadOnly = true;
            // 
            // chkSoloActivos
            // 
            this.chkSoloActivos.AutoSize = true;
            this.chkSoloActivos.Location = new System.Drawing.Point(24, 502);
            this.chkSoloActivos.Text = "Mostrar solo artículos activos";
            this.chkSoloActivos.Name = "chkSoloActivos";
            this.chkSoloActivos.TabIndex = 2;
            this.chkSoloActivos.CheckedChanged += new System.EventHandler(this.chkSoloActivos_CheckedChanged);
            // 
            // panelEdicion
            // 
            this.panelEdicion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.panelEdicion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panelEdicion.Location = new System.Drawing.Point(604, 72);
            this.panelEdicion.Size = new System.Drawing.Size(272, 300);
            this.panelEdicion.Name = "panelEdicion";
            this.panelEdicion.TabIndex = 3;
            // 
            // lblTituloEdicion
            // 
            this.lblTituloEdicion.AutoSize = true;
            this.lblTituloEdicion.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloEdicion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(66)))));
            this.lblTituloEdicion.Location = new System.Drawing.Point(16, 10);
            this.lblTituloEdicion.Text = "Nuevo artículo";
            this.lblTituloEdicion.Name = "lblTituloEdicion";
            this.lblTituloEdicion.TabIndex = 0;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(66)))));
            this.lblCodigo.Location = new System.Drawing.Point(16, 46);
            this.lblCodigo.Text = "Código";
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.TabIndex = 1;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(16, 66);
            this.txtCodigo.Size = new System.Drawing.Size(240, 23);
            this.txtCodigo.MaxLength = 20;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.TabIndex = 2;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(66)))));
            this.lblNombre.Location = new System.Drawing.Point(16, 100);
            this.lblNombre.Text = "Nombre";
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.TabIndex = 3;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(16, 120);
            this.txtNombre.Size = new System.Drawing.Size(240, 23);
            this.txtNombre.MaxLength = 150;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.TabIndex = 4;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(66)))));
            this.lblPrecio.Location = new System.Drawing.Point(16, 154);
            this.lblPrecio.Text = "Precio de referencia";
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.TabIndex = 5;
            // 
            // nudPrecio
            // 
            this.nudPrecio.DecimalPlaces = 2;
            this.nudPrecio.Location = new System.Drawing.Point(16, 174);
            this.nudPrecio.Maximum = new decimal(new int[] {100000000, 0, 0, 0});
            this.nudPrecio.Minimum = new decimal(new int[] {1, 0, 0, 131072});
            this.nudPrecio.Size = new System.Drawing.Size(140, 23);
            this.nudPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudPrecio.ThousandsSeparator = true;
            this.nudPrecio.Value = new decimal(new int[] {1, 0, 0, 131072});
            this.nudPrecio.Name = "nudPrecio";
            this.nudPrecio.TabIndex = 6;
            // 
            // chkActivo
            // 
            this.chkActivo.AutoSize = true;
            this.chkActivo.Checked = true;
            this.chkActivo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkActivo.Location = new System.Drawing.Point(16, 212);
            this.chkActivo.Text = "Artículo activo";
            this.chkActivo.Name = "chkActivo";
            this.chkActivo.TabIndex = 7;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(105)))), ((int)(((byte)(170)))));
            this.btnGuardar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(88)))), ((int)(((byte)(148)))));
            this.btnGuardar.Location = new System.Drawing.Point(16, 252);
            this.btnGuardar.Size = new System.Drawing.Size(116, 30);
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnNuevo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(66)))));
            this.btnNuevo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(198)))), ((int)(((byte)(208)))));
            this.btnNuevo.FlatAppearance.BorderSize = 1;
            this.btnNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(241)))), ((int)(((byte)(247)))));
            this.btnNuevo.Location = new System.Drawing.Point(140, 252);
            this.btnNuevo.Size = new System.Drawing.Size(116, 30);
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.TabIndex = 9;
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // panelAcciones
            // 
            this.panelAcciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(233)))), ((int)(((byte)(240)))));
            this.panelAcciones.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelAcciones.Location = new System.Drawing.Point(0, 0);
            this.panelAcciones.Size = new System.Drawing.Size(900, 60);
            this.panelAcciones.Name = "panelAcciones";
            this.panelAcciones.TabIndex = 4;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnCerrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(66)))));
            this.btnCerrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(198)))), ((int)(((byte)(208)))));
            this.btnCerrar.FlatAppearance.BorderSize = 1;
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(241)))), ((int)(((byte)(247)))));
            this.btnCerrar.Location = new System.Drawing.Point(766, 15);
            this.btnCerrar.Size = new System.Drawing.Size(110, 30);
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // FrmArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(243)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Catálogo de artículos";
            this.CancelButton = this.btnCerrar;
            this.Name = "FrmArticulos";
            this.Load += new System.EventHandler(this.FrmArticulos_Load);
            this.Controls.Add(this.panelEncabezado);
            this.panelEncabezado.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.dgvArticulos);
            this.Controls.Add(this.chkSoloActivos);
            this.Controls.Add(this.panelEdicion);
            this.panelEdicion.Controls.Add(this.lblTituloEdicion);
            this.panelEdicion.Controls.Add(this.lblCodigo);
            this.panelEdicion.Controls.Add(this.txtCodigo);
            this.panelEdicion.Controls.Add(this.lblNombre);
            this.panelEdicion.Controls.Add(this.txtNombre);
            this.panelEdicion.Controls.Add(this.lblPrecio);
            this.panelEdicion.Controls.Add(this.nudPrecio);
            this.panelEdicion.Controls.Add(this.chkActivo);
            this.panelEdicion.Controls.Add(this.btnGuardar);
            this.panelEdicion.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.panelAcciones);
            this.panelAcciones.Controls.Add(this.btnCerrar);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecio)).EndInit();
            this.panelEncabezado.ResumeLayout(false);
            this.panelEncabezado.PerformLayout();
            this.panelEdicion.ResumeLayout(false);
            this.panelEdicion.PerformLayout();
            this.panelAcciones.ResumeLayout(false);
            this.panelAcciones.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelEncabezado;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridView dgvArticulos;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn colActivo;
        private System.Windows.Forms.CheckBox chkSoloActivos;
        private System.Windows.Forms.Panel panelEdicion;
        private System.Windows.Forms.Label lblTituloEdicion;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.NumericUpDown nudPrecio;
        private System.Windows.Forms.CheckBox chkActivo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Panel panelAcciones;
        private System.Windows.Forms.Button btnCerrar;
    }
}
