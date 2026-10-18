namespace SistemaRequisiciones.Presentacion
{
    partial class FrmRequisicion
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
            System.Windows.Forms.DataGridViewCellStyle estiloEncabezado_dgvDetalle = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle estiloCelda_dgvDetalle = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle estiloColumna_colCantidad = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle estiloColumna_colPrecioUnitario = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle estiloColumna_colImporte = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelEncabezado = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.panelDatos = new System.Windows.Forms.Panel();
            this.lblTituloDatos = new System.Windows.Forms.Label();
            this.lblSolicitante = new System.Windows.Forms.Label();
            this.cmbSolicitante = new System.Windows.Forms.ComboBox();
            this.lblDepartamento = new System.Windows.Forms.Label();
            this.cmbDepartamento = new System.Windows.Forms.ComboBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.lblJustificacion = new System.Windows.Forms.Label();
            this.txtJustificacion = new System.Windows.Forms.TextBox();
            this.panelArticulos = new System.Windows.Forms.Panel();
            this.lblTituloArticulos = new System.Windows.Forms.Label();
            this.lblArticulo = new System.Windows.Forms.Label();
            this.cmbArticulo = new System.Windows.Forms.ComboBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.nudCantidad = new System.Windows.Forms.NumericUpDown();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.nudPrecio = new System.Windows.Forms.NumericUpDown();
            this.btnAgregarArticulo = new System.Windows.Forms.Button();
            this.btnQuitarArticulo = new System.Windows.Forms.Button();
            this.dgvDetalle = new System.Windows.Forms.DataGridView();
            this.colCodigoArticulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombreArticulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrecioUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colImporte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelMontos = new System.Windows.Forms.Panel();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.lblImpuestos = new System.Windows.Forms.Label();
            this.txtImpuestos = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblPolitica = new System.Windows.Forms.Label();
            this.panelAcciones = new System.Windows.Forms.Panel();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelarCaptura = new System.Windows.Forms.Button();
            this.btnEnviarRevision = new System.Windows.Forms.Button();
            this.btnAprobar = new System.Windows.Forms.Button();
            this.btnRechazar = new System.Windows.Forms.Button();
            this.btnCancelarRequisicion = new System.Windows.Forms.Button();
            this.btnGenerarReporte = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).BeginInit();
            this.panelEncabezado.SuspendLayout();
            this.panelDatos.SuspendLayout();
            this.panelArticulos.SuspendLayout();
            this.panelMontos.SuspendLayout();
            this.panelAcciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelEncabezado
            // 
            this.panelEncabezado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(115)))), ((int)(((byte)(150)))));
            this.panelEncabezado.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelEncabezado.Location = new System.Drawing.Point(0, 0);
            this.panelEncabezado.Size = new System.Drawing.Size(1000, 64);
            this.panelEncabezado.Name = "panelEncabezado";
            this.panelEncabezado.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblTitulo.Location = new System.Drawing.Point(24, 8);
            this.lblTitulo.Text = "Nueva requisición";
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.TabIndex = 0;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblCodigo.Location = new System.Drawing.Point(26, 40);
            this.lblCodigo.Text = "Código: se asigna al guardar";
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.TabIndex = 1;
            // 
            // lblEstado
            // 
            this.lblEstado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEstado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(158)))), ((int)(((byte)(170)))));
            this.lblEstado.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblEstado.Location = new System.Drawing.Point(806, 17);
            this.lblEstado.Size = new System.Drawing.Size(170, 30);
            this.lblEstado.Text = "Nueva";
            this.lblEstado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.TabIndex = 2;
            // 
            // panelDatos
            // 
            this.panelDatos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.panelDatos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panelDatos.Location = new System.Drawing.Point(24, 80);
            this.panelDatos.Size = new System.Drawing.Size(952, 172);
            this.panelDatos.Name = "panelDatos";
            this.panelDatos.TabIndex = 1;
            // 
            // lblTituloDatos
            // 
            this.lblTituloDatos.AutoSize = true;
            this.lblTituloDatos.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloDatos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(66)))));
            this.lblTituloDatos.Location = new System.Drawing.Point(16, 10);
            this.lblTituloDatos.Text = "Datos generales";
            this.lblTituloDatos.Name = "lblTituloDatos";
            this.lblTituloDatos.TabIndex = 0;
            // 
            // lblSolicitante
            // 
            this.lblSolicitante.AutoSize = true;
            this.lblSolicitante.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSolicitante.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(66)))));
            this.lblSolicitante.Location = new System.Drawing.Point(16, 44);
            this.lblSolicitante.Text = "Solicitante";
            this.lblSolicitante.Name = "lblSolicitante";
            this.lblSolicitante.TabIndex = 1;
            // 
            // cmbSolicitante
            // 
            this.cmbSolicitante.DisplayMember = "Nombre";
            this.cmbSolicitante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSolicitante.FormattingEnabled = true;
            this.cmbSolicitante.Location = new System.Drawing.Point(16, 64);
            this.cmbSolicitante.Size = new System.Drawing.Size(300, 23);
            this.cmbSolicitante.ValueMember = "IdSolicitante";
            this.cmbSolicitante.Name = "cmbSolicitante";
            this.cmbSolicitante.TabIndex = 2;
            this.cmbSolicitante.SelectedIndexChanged += new System.EventHandler(this.cmbSolicitante_SelectedIndexChanged);
            // 
            // lblDepartamento
            // 
            this.lblDepartamento.AutoSize = true;
            this.lblDepartamento.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartamento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(66)))));
            this.lblDepartamento.Location = new System.Drawing.Point(336, 44);
            this.lblDepartamento.Text = "Departamento";
            this.lblDepartamento.Name = "lblDepartamento";
            this.lblDepartamento.TabIndex = 3;
            // 
            // cmbDepartamento
            // 
            this.cmbDepartamento.DisplayMember = "Nombre";
            this.cmbDepartamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDepartamento.FormattingEnabled = true;
            this.cmbDepartamento.Location = new System.Drawing.Point(336, 64);
            this.cmbDepartamento.Size = new System.Drawing.Size(300, 23);
            this.cmbDepartamento.ValueMember = "IdDepartamento";
            this.cmbDepartamento.Name = "cmbDepartamento";
            this.cmbDepartamento.TabIndex = 4;
            this.cmbDepartamento.SelectedIndexChanged += new System.EventHandler(this.cmbDepartamento_SelectedIndexChanged);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(66)))));
            this.lblFecha.Location = new System.Drawing.Point(656, 44);
            this.lblFecha.Text = "Fecha de creación";
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.TabIndex = 5;
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(656, 64);
            this.txtFecha.Size = new System.Drawing.Size(280, 23);
            this.txtFecha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.txtFecha.ReadOnly = true;
            this.txtFecha.TabStop = false;
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.TabIndex = 6;
            // 
            // lblJustificacion
            // 
            this.lblJustificacion.AutoSize = true;
            this.lblJustificacion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJustificacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(66)))));
            this.lblJustificacion.Location = new System.Drawing.Point(16, 98);
            this.lblJustificacion.Text = "Justificación de la compra";
            this.lblJustificacion.Name = "lblJustificacion";
            this.lblJustificacion.TabIndex = 7;
            // 
            // txtJustificacion
            // 
            this.txtJustificacion.Location = new System.Drawing.Point(16, 118);
            this.txtJustificacion.Size = new System.Drawing.Size(920, 44);
            this.txtJustificacion.MaxLength = 500;
            this.txtJustificacion.Multiline = true;
            this.txtJustificacion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtJustificacion.Name = "txtJustificacion";
            this.txtJustificacion.TabIndex = 8;
            this.txtJustificacion.TextChanged += new System.EventHandler(this.txtJustificacion_TextChanged);
            // 
            // panelArticulos
            // 
            this.panelArticulos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.panelArticulos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panelArticulos.Location = new System.Drawing.Point(24, 264);
            this.panelArticulos.Size = new System.Drawing.Size(952, 310);
            this.panelArticulos.Name = "panelArticulos";
            this.panelArticulos.TabIndex = 2;
            // 
            // lblTituloArticulos
            // 
            this.lblTituloArticulos.AutoSize = true;
            this.lblTituloArticulos.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloArticulos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(66)))));
            this.lblTituloArticulos.Location = new System.Drawing.Point(16, 10);
            this.lblTituloArticulos.Text = "Artículos solicitados";
            this.lblTituloArticulos.Name = "lblTituloArticulos";
            this.lblTituloArticulos.TabIndex = 0;
            // 
            // lblArticulo
            // 
            this.lblArticulo.AutoSize = true;
            this.lblArticulo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArticulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(66)))));
            this.lblArticulo.Location = new System.Drawing.Point(16, 42);
            this.lblArticulo.Text = "Artículo";
            this.lblArticulo.Name = "lblArticulo";
            this.lblArticulo.TabIndex = 1;
            // 
            // cmbArticulo
            // 
            this.cmbArticulo.DisplayMember = "Descripcion";
            this.cmbArticulo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbArticulo.FormattingEnabled = true;
            this.cmbArticulo.Location = new System.Drawing.Point(16, 62);
            this.cmbArticulo.Size = new System.Drawing.Size(380, 23);
            this.cmbArticulo.ValueMember = "IdArticulo";
            this.cmbArticulo.Name = "cmbArticulo";
            this.cmbArticulo.TabIndex = 2;
            this.cmbArticulo.SelectedIndexChanged += new System.EventHandler(this.cmbArticulo_SelectedIndexChanged);
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(66)))));
            this.lblCantidad.Location = new System.Drawing.Point(412, 42);
            this.lblCantidad.Text = "Cantidad";
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.TabIndex = 3;
            // 
            // nudCantidad
            // 
            this.nudCantidad.Location = new System.Drawing.Point(412, 62);
            this.nudCantidad.Maximum = new decimal(new int[] {100000, 0, 0, 0});
            this.nudCantidad.Minimum = new decimal(new int[] {1, 0, 0, 0});
            this.nudCantidad.Size = new System.Drawing.Size(90, 23);
            this.nudCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudCantidad.Value = new decimal(new int[] {1, 0, 0, 0});
            this.nudCantidad.Name = "nudCantidad";
            this.nudCantidad.TabIndex = 4;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(66)))));
            this.lblPrecio.Location = new System.Drawing.Point(518, 42);
            this.lblPrecio.Text = "Precio unitario";
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.TabIndex = 5;
            // 
            // nudPrecio
            // 
            this.nudPrecio.DecimalPlaces = 2;
            this.nudPrecio.Location = new System.Drawing.Point(518, 62);
            this.nudPrecio.Maximum = new decimal(new int[] {100000000, 0, 0, 0});
            this.nudPrecio.Minimum = new decimal(new int[] {1, 0, 0, 131072});
            this.nudPrecio.Size = new System.Drawing.Size(130, 23);
            this.nudPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudPrecio.ThousandsSeparator = true;
            this.nudPrecio.Value = new decimal(new int[] {1, 0, 0, 131072});
            this.nudPrecio.Name = "nudPrecio";
            this.nudPrecio.TabIndex = 6;
            // 
            // btnAgregarArticulo
            // 
            this.btnAgregarArticulo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarArticulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarArticulo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarArticulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(105)))), ((int)(((byte)(170)))));
            this.btnAgregarArticulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAgregarArticulo.FlatAppearance.BorderSize = 0;
            this.btnAgregarArticulo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(88)))), ((int)(((byte)(148)))));
            this.btnAgregarArticulo.Location = new System.Drawing.Point(664, 60);
            this.btnAgregarArticulo.Size = new System.Drawing.Size(120, 27);
            this.btnAgregarArticulo.Text = "Agregar";
            this.btnAgregarArticulo.Name = "btnAgregarArticulo";
            this.btnAgregarArticulo.TabIndex = 7;
            this.btnAgregarArticulo.UseVisualStyleBackColor = false;
            this.btnAgregarArticulo.Click += new System.EventHandler(this.btnAgregarArticulo_Click);
            // 
            // btnQuitarArticulo
            // 
            this.btnQuitarArticulo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuitarArticulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitarArticulo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitarArticulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnQuitarArticulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(66)))));
            this.btnQuitarArticulo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(198)))), ((int)(((byte)(208)))));
            this.btnQuitarArticulo.FlatAppearance.BorderSize = 1;
            this.btnQuitarArticulo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(241)))), ((int)(((byte)(247)))));
            this.btnQuitarArticulo.Location = new System.Drawing.Point(794, 60);
            this.btnQuitarArticulo.Size = new System.Drawing.Size(142, 27);
            this.btnQuitarArticulo.Text = "Quitar seleccionado";
            this.btnQuitarArticulo.Name = "btnQuitarArticulo";
            this.btnQuitarArticulo.TabIndex = 8;
            this.btnQuitarArticulo.UseVisualStyleBackColor = false;
            this.btnQuitarArticulo.Click += new System.EventHandler(this.btnQuitarArticulo_Click);
            // 
            // dgvDetalle
            // 
            estiloEncabezado_dgvDetalle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            estiloEncabezado_dgvDetalle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(248)))));
            estiloEncabezado_dgvDetalle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            estiloEncabezado_dgvDetalle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(66)))));
            estiloEncabezado_dgvDetalle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(248)))));
            estiloEncabezado_dgvDetalle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(66)))));
            estiloEncabezado_dgvDetalle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            estiloCelda_dgvDetalle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            estiloCelda_dgvDetalle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            estiloCelda_dgvDetalle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(66)))));
            estiloCelda_dgvDetalle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(230)))), ((int)(((byte)(242)))));
            estiloCelda_dgvDetalle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(66)))));
            this.dgvDetalle.AllowUserToAddRows = false;
            this.dgvDetalle.AllowUserToDeleteRows = false;
            this.dgvDetalle.AllowUserToResizeRows = false;
            this.dgvDetalle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetalle.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvDetalle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDetalle.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDetalle.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvDetalle.ColumnHeadersDefaultCellStyle = estiloEncabezado_dgvDetalle;
            this.dgvDetalle.ColumnHeadersHeight = 28;
            this.dgvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodigoArticulo,
            this.colNombreArticulo,
            this.colCantidad,
            this.colPrecioUnitario,
            this.colImporte});
            this.dgvDetalle.DefaultCellStyle = estiloCelda_dgvDetalle;
            this.dgvDetalle.EnableHeadersVisualStyles = false;
            this.dgvDetalle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(230)))), ((int)(((byte)(236)))));
            this.dgvDetalle.MultiSelect = false;
            this.dgvDetalle.ReadOnly = true;
            this.dgvDetalle.RowHeadersVisible = false;
            this.dgvDetalle.RowTemplate.Height = 26;
            this.dgvDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetalle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dgvDetalle.Location = new System.Drawing.Point(16, 100);
            this.dgvDetalle.Size = new System.Drawing.Size(920, 198);
            this.dgvDetalle.Name = "dgvDetalle";
            this.dgvDetalle.TabIndex = 9;
            // 
            // colCodigoArticulo
            // 
            this.colCodigoArticulo.FillWeight = 14F;
            this.colCodigoArticulo.HeaderText = "Código";
            this.colCodigoArticulo.Name = "colCodigoArticulo";
            this.colCodigoArticulo.ReadOnly = true;
            // 
            // colNombreArticulo
            // 
            this.colNombreArticulo.FillWeight = 40F;
            this.colNombreArticulo.HeaderText = "Artículo";
            this.colNombreArticulo.Name = "colNombreArticulo";
            this.colNombreArticulo.ReadOnly = true;
            // 
            // colCantidad
            // 
            estiloColumna_colCantidad.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            estiloColumna_colCantidad.Format = "N0";
            this.colCantidad.DefaultCellStyle = estiloColumna_colCantidad;
            this.colCantidad.FillWeight = 14F;
            this.colCantidad.HeaderText = "Cantidad";
            this.colCantidad.Name = "colCantidad";
            this.colCantidad.ReadOnly = true;
            // 
            // colPrecioUnitario
            // 
            estiloColumna_colPrecioUnitario.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            estiloColumna_colPrecioUnitario.Format = "N2";
            this.colPrecioUnitario.DefaultCellStyle = estiloColumna_colPrecioUnitario;
            this.colPrecioUnitario.FillWeight = 16F;
            this.colPrecioUnitario.HeaderText = "Precio unitario";
            this.colPrecioUnitario.Name = "colPrecioUnitario";
            this.colPrecioUnitario.ReadOnly = true;
            // 
            // colImporte
            // 
            estiloColumna_colImporte.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            estiloColumna_colImporte.Format = "N2";
            this.colImporte.DefaultCellStyle = estiloColumna_colImporte;
            this.colImporte.FillWeight = 16F;
            this.colImporte.HeaderText = "Importe";
            this.colImporte.Name = "colImporte";
            this.colImporte.ReadOnly = true;
            // 
            // panelMontos
            // 
            this.panelMontos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.panelMontos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panelMontos.Location = new System.Drawing.Point(24, 586);
            this.panelMontos.Size = new System.Drawing.Size(952, 80);
            this.panelMontos.Name = "panelMontos";
            this.panelMontos.TabIndex = 3;
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(112)))), ((int)(((byte)(128)))));
            this.lblSubtotal.Location = new System.Drawing.Point(16, 12);
            this.lblSubtotal.Text = "Subtotal";
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.TabIndex = 0;
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Location = new System.Drawing.Point(16, 36);
            this.txtSubtotal.Size = new System.Drawing.Size(200, 23);
            this.txtSubtotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.txtSubtotal.ReadOnly = true;
            this.txtSubtotal.TabStop = false;
            this.txtSubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.TabIndex = 1;
            // 
            // lblImpuestos
            // 
            this.lblImpuestos.AutoSize = true;
            this.lblImpuestos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImpuestos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(112)))), ((int)(((byte)(128)))));
            this.lblImpuestos.Location = new System.Drawing.Point(240, 12);
            this.lblImpuestos.Text = "Impuestos";
            this.lblImpuestos.Name = "lblImpuestos";
            this.lblImpuestos.TabIndex = 2;
            // 
            // txtImpuestos
            // 
            this.txtImpuestos.Location = new System.Drawing.Point(240, 36);
            this.txtImpuestos.Size = new System.Drawing.Size(200, 23);
            this.txtImpuestos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.txtImpuestos.ReadOnly = true;
            this.txtImpuestos.TabStop = false;
            this.txtImpuestos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtImpuestos.Name = "txtImpuestos";
            this.txtImpuestos.TabIndex = 3;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(66)))));
            this.lblTotal.Location = new System.Drawing.Point(464, 12);
            this.lblTotal.Text = "Total";
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.TabIndex = 4;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(464, 36);
            this.txtTotal.Size = new System.Drawing.Size(200, 23);
            this.txtTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.txtTotal.ReadOnly = true;
            this.txtTotal.TabStop = false;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTotal.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.TabIndex = 5;
            // 
            // lblPolitica
            // 
            this.lblPolitica.AutoSize = true;
            this.lblPolitica.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPolitica.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(112)))), ((int)(((byte)(128)))));
            this.lblPolitica.Location = new System.Drawing.Point(690, 40);
            this.lblPolitica.Text = "Política de impuestos";
            this.lblPolitica.Name = "lblPolitica";
            this.lblPolitica.TabIndex = 6;
            // 
            // panelAcciones
            // 
            this.panelAcciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(233)))), ((int)(((byte)(240)))));
            this.panelAcciones.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelAcciones.Location = new System.Drawing.Point(0, 0);
            this.panelAcciones.Size = new System.Drawing.Size(1000, 60);
            this.panelAcciones.Name = "panelAcciones";
            this.panelAcciones.TabIndex = 4;
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
            this.btnGuardar.Location = new System.Drawing.Point(24, 15);
            this.btnGuardar.Size = new System.Drawing.Size(110, 30);
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.TabIndex = 0;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelarCaptura
            // 
            this.btnCancelarCaptura.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelarCaptura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarCaptura.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarCaptura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnCancelarCaptura.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(66)))));
            this.btnCancelarCaptura.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(198)))), ((int)(((byte)(208)))));
            this.btnCancelarCaptura.FlatAppearance.BorderSize = 1;
            this.btnCancelarCaptura.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(241)))), ((int)(((byte)(247)))));
            this.btnCancelarCaptura.Location = new System.Drawing.Point(144, 15);
            this.btnCancelarCaptura.Size = new System.Drawing.Size(130, 30);
            this.btnCancelarCaptura.Text = "Cancelar captura";
            this.btnCancelarCaptura.Name = "btnCancelarCaptura";
            this.btnCancelarCaptura.TabIndex = 1;
            this.btnCancelarCaptura.UseVisualStyleBackColor = false;
            this.btnCancelarCaptura.Click += new System.EventHandler(this.btnCancelarCaptura_Click);
            // 
            // btnEnviarRevision
            // 
            this.btnEnviarRevision.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnviarRevision.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnviarRevision.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviarRevision.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnEnviarRevision.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(66)))));
            this.btnEnviarRevision.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(198)))), ((int)(((byte)(208)))));
            this.btnEnviarRevision.FlatAppearance.BorderSize = 1;
            this.btnEnviarRevision.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(241)))), ((int)(((byte)(247)))));
            this.btnEnviarRevision.Location = new System.Drawing.Point(300, 15);
            this.btnEnviarRevision.Size = new System.Drawing.Size(150, 30);
            this.btnEnviarRevision.Text = "Enviar a revisión";
            this.btnEnviarRevision.Name = "btnEnviarRevision";
            this.btnEnviarRevision.TabIndex = 2;
            this.btnEnviarRevision.UseVisualStyleBackColor = false;
            this.btnEnviarRevision.Click += new System.EventHandler(this.btnEnviarRevision_Click);
            // 
            // btnAprobar
            // 
            this.btnAprobar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAprobar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAprobar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAprobar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAprobar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(66)))));
            this.btnAprobar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(198)))), ((int)(((byte)(208)))));
            this.btnAprobar.FlatAppearance.BorderSize = 1;
            this.btnAprobar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(241)))), ((int)(((byte)(247)))));
            this.btnAprobar.Location = new System.Drawing.Point(460, 15);
            this.btnAprobar.Size = new System.Drawing.Size(100, 30);
            this.btnAprobar.Text = "Aprobar";
            this.btnAprobar.Name = "btnAprobar";
            this.btnAprobar.TabIndex = 3;
            this.btnAprobar.UseVisualStyleBackColor = false;
            this.btnAprobar.Click += new System.EventHandler(this.btnAprobar_Click);
            // 
            // btnRechazar
            // 
            this.btnRechazar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRechazar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRechazar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRechazar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnRechazar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnRechazar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(198)))), ((int)(((byte)(208)))));
            this.btnRechazar.FlatAppearance.BorderSize = 1;
            this.btnRechazar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(241)))), ((int)(((byte)(247)))));
            this.btnRechazar.Location = new System.Drawing.Point(570, 15);
            this.btnRechazar.Size = new System.Drawing.Size(100, 30);
            this.btnRechazar.Text = "Rechazar";
            this.btnRechazar.Name = "btnRechazar";
            this.btnRechazar.TabIndex = 4;
            this.btnRechazar.UseVisualStyleBackColor = false;
            this.btnRechazar.Click += new System.EventHandler(this.btnRechazar_Click);
            // 
            // btnCancelarRequisicion
            // 
            this.btnCancelarRequisicion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelarRequisicion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarRequisicion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarRequisicion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnCancelarRequisicion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnCancelarRequisicion.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(198)))), ((int)(((byte)(208)))));
            this.btnCancelarRequisicion.FlatAppearance.BorderSize = 1;
            this.btnCancelarRequisicion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(241)))), ((int)(((byte)(247)))));
            this.btnCancelarRequisicion.Location = new System.Drawing.Point(680, 15);
            this.btnCancelarRequisicion.Size = new System.Drawing.Size(150, 30);
            this.btnCancelarRequisicion.Text = "Cancelar requisición";
            this.btnCancelarRequisicion.Name = "btnCancelarRequisicion";
            this.btnCancelarRequisicion.TabIndex = 5;
            this.btnCancelarRequisicion.UseVisualStyleBackColor = false;
            this.btnCancelarRequisicion.Click += new System.EventHandler(this.btnCancelarRequisicion_Click);
            // 
            // btnGenerarReporte
            // 
            this.btnGenerarReporte.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerarReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerarReporte.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarReporte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnGenerarReporte.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(66)))));
            this.btnGenerarReporte.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(198)))), ((int)(((byte)(208)))));
            this.btnGenerarReporte.FlatAppearance.BorderSize = 1;
            this.btnGenerarReporte.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(241)))), ((int)(((byte)(247)))));
            this.btnGenerarReporte.Location = new System.Drawing.Point(846, 15);
            this.btnGenerarReporte.Size = new System.Drawing.Size(130, 30);
            this.btnGenerarReporte.Text = "Generar reporte";
            this.btnGenerarReporte.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGenerarReporte.Name = "btnGenerarReporte";
            this.btnGenerarReporte.TabIndex = 6;
            this.btnGenerarReporte.UseVisualStyleBackColor = false;
            this.btnGenerarReporte.Click += new System.EventHandler(this.btnGenerarReporte_Click);
            // 
            // FrmRequisicion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(243)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(1000, 744);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Requisición de compra";
            this.Name = "FrmRequisicion";
            this.Load += new System.EventHandler(this.FrmRequisicion_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmRequisicion_FormClosing);
            this.Controls.Add(this.panelEncabezado);
            this.panelEncabezado.Controls.Add(this.lblTitulo);
            this.panelEncabezado.Controls.Add(this.lblCodigo);
            this.panelEncabezado.Controls.Add(this.lblEstado);
            this.Controls.Add(this.panelDatos);
            this.panelDatos.Controls.Add(this.lblTituloDatos);
            this.panelDatos.Controls.Add(this.lblSolicitante);
            this.panelDatos.Controls.Add(this.cmbSolicitante);
            this.panelDatos.Controls.Add(this.lblDepartamento);
            this.panelDatos.Controls.Add(this.cmbDepartamento);
            this.panelDatos.Controls.Add(this.lblFecha);
            this.panelDatos.Controls.Add(this.txtFecha);
            this.panelDatos.Controls.Add(this.lblJustificacion);
            this.panelDatos.Controls.Add(this.txtJustificacion);
            this.Controls.Add(this.panelArticulos);
            this.panelArticulos.Controls.Add(this.lblTituloArticulos);
            this.panelArticulos.Controls.Add(this.lblArticulo);
            this.panelArticulos.Controls.Add(this.cmbArticulo);
            this.panelArticulos.Controls.Add(this.lblCantidad);
            this.panelArticulos.Controls.Add(this.nudCantidad);
            this.panelArticulos.Controls.Add(this.lblPrecio);
            this.panelArticulos.Controls.Add(this.nudPrecio);
            this.panelArticulos.Controls.Add(this.btnAgregarArticulo);
            this.panelArticulos.Controls.Add(this.btnQuitarArticulo);
            this.panelArticulos.Controls.Add(this.dgvDetalle);
            this.Controls.Add(this.panelMontos);
            this.panelMontos.Controls.Add(this.lblSubtotal);
            this.panelMontos.Controls.Add(this.txtSubtotal);
            this.panelMontos.Controls.Add(this.lblImpuestos);
            this.panelMontos.Controls.Add(this.txtImpuestos);
            this.panelMontos.Controls.Add(this.lblTotal);
            this.panelMontos.Controls.Add(this.txtTotal);
            this.panelMontos.Controls.Add(this.lblPolitica);
            this.Controls.Add(this.panelAcciones);
            this.panelAcciones.Controls.Add(this.btnGuardar);
            this.panelAcciones.Controls.Add(this.btnCancelarCaptura);
            this.panelAcciones.Controls.Add(this.btnEnviarRevision);
            this.panelAcciones.Controls.Add(this.btnAprobar);
            this.panelAcciones.Controls.Add(this.btnRechazar);
            this.panelAcciones.Controls.Add(this.btnCancelarRequisicion);
            this.panelAcciones.Controls.Add(this.btnGenerarReporte);
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).EndInit();
            this.panelEncabezado.ResumeLayout(false);
            this.panelEncabezado.PerformLayout();
            this.panelDatos.ResumeLayout(false);
            this.panelDatos.PerformLayout();
            this.panelArticulos.ResumeLayout(false);
            this.panelArticulos.PerformLayout();
            this.panelMontos.ResumeLayout(false);
            this.panelMontos.PerformLayout();
            this.panelAcciones.ResumeLayout(false);
            this.panelAcciones.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelEncabezado;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Panel panelDatos;
        private System.Windows.Forms.Label lblTituloDatos;
        private System.Windows.Forms.Label lblSolicitante;
        private System.Windows.Forms.ComboBox cmbSolicitante;
        private System.Windows.Forms.Label lblDepartamento;
        private System.Windows.Forms.ComboBox cmbDepartamento;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.Label lblJustificacion;
        private System.Windows.Forms.TextBox txtJustificacion;
        private System.Windows.Forms.Panel panelArticulos;
        private System.Windows.Forms.Label lblTituloArticulos;
        private System.Windows.Forms.Label lblArticulo;
        private System.Windows.Forms.ComboBox cmbArticulo;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.NumericUpDown nudCantidad;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.NumericUpDown nudPrecio;
        private System.Windows.Forms.Button btnAgregarArticulo;
        private System.Windows.Forms.Button btnQuitarArticulo;
        private System.Windows.Forms.DataGridView dgvDetalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigoArticulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombreArticulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrecioUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn colImporte;
        private System.Windows.Forms.Panel panelMontos;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.Label lblImpuestos;
        private System.Windows.Forms.TextBox txtImpuestos;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblPolitica;
        private System.Windows.Forms.Panel panelAcciones;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelarCaptura;
        private System.Windows.Forms.Button btnEnviarRevision;
        private System.Windows.Forms.Button btnAprobar;
        private System.Windows.Forms.Button btnRechazar;
        private System.Windows.Forms.Button btnCancelarRequisicion;
        private System.Windows.Forms.Button btnGenerarReporte;
    }
}
