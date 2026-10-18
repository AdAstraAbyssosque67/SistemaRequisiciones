namespace SistemaRequisiciones.Presentacion
{
    partial class FrmConsultaRequisiciones
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
            System.Windows.Forms.DataGridViewCellStyle estiloEncabezado_dgvResultados = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle estiloCelda_dgvResultados = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle estiloColumna_colFecha = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle estiloColumna_colSubtotal = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle estiloColumna_colImpuestos = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle estiloColumna_colTotal = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelEncabezado = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panelFiltros = new System.Windows.Forms.Panel();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblSolicitante = new System.Windows.Forms.Label();
            this.cmbSolicitante = new System.Windows.Forms.ComboBox();
            this.lblDesde = new System.Windows.Forms.Label();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.lblHasta = new System.Windows.Forms.Label();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.lblEstado = new System.Windows.Forms.Label();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.dgvResultados = new System.Windows.Forms.DataGridView();
            this.colCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSolicitante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDepartamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSubtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colImpuestos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblConteo = new System.Windows.Forms.Label();
            this.panelAcciones = new System.Windows.Forms.Panel();
            this.btnAbrir = new System.Windows.Forms.Button();
            this.btnNueva = new System.Windows.Forms.Button();
            this.btnGenerarReporte = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).BeginInit();
            this.panelEncabezado.SuspendLayout();
            this.panelFiltros.SuspendLayout();
            this.panelAcciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelEncabezado
            // 
            this.panelEncabezado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(115)))), ((int)(((byte)(150)))));
            this.panelEncabezado.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelEncabezado.Location = new System.Drawing.Point(0, 0);
            this.panelEncabezado.Size = new System.Drawing.Size(1100, 56);
            this.panelEncabezado.Name = "panelEncabezado";
            this.panelEncabezado.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblTitulo.Location = new System.Drawing.Point(24, 12);
            this.lblTitulo.Text = "Consulta de requisiciones";
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.TabIndex = 0;
            // 
            // panelFiltros
            // 
            this.panelFiltros.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panelFiltros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panelFiltros.Location = new System.Drawing.Point(24, 72);
            this.panelFiltros.Size = new System.Drawing.Size(1052, 112);
            this.panelFiltros.Name = "panelFiltros";
            this.panelFiltros.TabIndex = 1;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(66)))));
            this.lblCodigo.Location = new System.Drawing.Point(16, 12);
            this.lblCodigo.Text = "Código";
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.TabIndex = 0;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(16, 32);
            this.txtCodigo.Size = new System.Drawing.Size(150, 23);
            this.txtCodigo.MaxLength = 20;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.TabIndex = 1;
            // 
            // lblSolicitante
            // 
            this.lblSolicitante.AutoSize = true;
            this.lblSolicitante.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSolicitante.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(66)))));
            this.lblSolicitante.Location = new System.Drawing.Point(186, 12);
            this.lblSolicitante.Text = "Solicitante";
            this.lblSolicitante.Name = "lblSolicitante";
            this.lblSolicitante.TabIndex = 2;
            // 
            // cmbSolicitante
            // 
            this.cmbSolicitante.DisplayMember = "Texto";
            this.cmbSolicitante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSolicitante.FormattingEnabled = true;
            this.cmbSolicitante.Location = new System.Drawing.Point(186, 32);
            this.cmbSolicitante.Size = new System.Drawing.Size(230, 23);
            this.cmbSolicitante.ValueMember = "Valor";
            this.cmbSolicitante.Name = "cmbSolicitante";
            this.cmbSolicitante.TabIndex = 3;
            // 
            // lblDesde
            // 
            this.lblDesde.AutoSize = true;
            this.lblDesde.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesde.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(66)))));
            this.lblDesde.Location = new System.Drawing.Point(436, 12);
            this.lblDesde.Text = "Fecha desde";
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.TabIndex = 4;
            // 
            // dtpDesde
            // 
            this.dtpDesde.Checked = false;
            this.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDesde.Location = new System.Drawing.Point(436, 32);
            this.dtpDesde.ShowCheckBox = true;
            this.dtpDesde.Size = new System.Drawing.Size(140, 23);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.TabIndex = 5;
            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHasta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(66)))));
            this.lblHasta.Location = new System.Drawing.Point(596, 12);
            this.lblHasta.Text = "Fecha hasta";
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.TabIndex = 6;
            // 
            // dtpHasta
            // 
            this.dtpHasta.Checked = false;
            this.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHasta.Location = new System.Drawing.Point(596, 32);
            this.dtpHasta.ShowCheckBox = true;
            this.dtpHasta.Size = new System.Drawing.Size(140, 23);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.TabIndex = 7;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(66)))));
            this.lblEstado.Location = new System.Drawing.Point(756, 12);
            this.lblEstado.Text = "Estado";
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.TabIndex = 8;
            // 
            // cmbEstado
            // 
            this.cmbEstado.DisplayMember = "Texto";
            this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Location = new System.Drawing.Point(756, 32);
            this.cmbEstado.Size = new System.Drawing.Size(170, 23);
            this.cmbEstado.ValueMember = "Valor";
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.TabIndex = 9;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(105)))), ((int)(((byte)(170)))));
            this.btnBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(88)))), ((int)(((byte)(148)))));
            this.btnBuscar.Location = new System.Drawing.Point(16, 68);
            this.btnBuscar.Size = new System.Drawing.Size(100, 30);
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.TabIndex = 10;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnLimpiar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(66)))));
            this.btnLimpiar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(198)))), ((int)(((byte)(208)))));
            this.btnLimpiar.FlatAppearance.BorderSize = 1;
            this.btnLimpiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(241)))), ((int)(((byte)(247)))));
            this.btnLimpiar.Location = new System.Drawing.Point(126, 68);
            this.btnLimpiar.Size = new System.Drawing.Size(100, 30);
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.TabIndex = 11;
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // dgvResultados
            // 
            estiloEncabezado_dgvResultados.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            estiloEncabezado_dgvResultados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(248)))));
            estiloEncabezado_dgvResultados.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            estiloEncabezado_dgvResultados.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(66)))));
            estiloEncabezado_dgvResultados.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(248)))));
            estiloEncabezado_dgvResultados.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(66)))));
            estiloEncabezado_dgvResultados.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            estiloCelda_dgvResultados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            estiloCelda_dgvResultados.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            estiloCelda_dgvResultados.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(66)))));
            estiloCelda_dgvResultados.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(230)))), ((int)(((byte)(242)))));
            estiloCelda_dgvResultados.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(66)))));
            this.dgvResultados.AllowUserToAddRows = false;
            this.dgvResultados.AllowUserToDeleteRows = false;
            this.dgvResultados.AllowUserToResizeRows = false;
            this.dgvResultados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvResultados.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvResultados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvResultados.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvResultados.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvResultados.ColumnHeadersDefaultCellStyle = estiloEncabezado_dgvResultados;
            this.dgvResultados.ColumnHeadersHeight = 28;
            this.dgvResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvResultados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodigo,
            this.colFecha,
            this.colSolicitante,
            this.colDepartamento,
            this.colEstado,
            this.colSubtotal,
            this.colImpuestos,
            this.colTotal});
            this.dgvResultados.DefaultCellStyle = estiloCelda_dgvResultados;
            this.dgvResultados.EnableHeadersVisualStyles = false;
            this.dgvResultados.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(230)))), ((int)(((byte)(236)))));
            this.dgvResultados.MultiSelect = false;
            this.dgvResultados.ReadOnly = true;
            this.dgvResultados.RowHeadersVisible = false;
            this.dgvResultados.RowTemplate.Height = 26;
            this.dgvResultados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvResultados.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dgvResultados.Location = new System.Drawing.Point(24, 196);
            this.dgvResultados.Size = new System.Drawing.Size(1052, 340);
            this.dgvResultados.Name = "dgvResultados";
            this.dgvResultados.TabIndex = 2;
            this.dgvResultados.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvResultados_CellDoubleClick);
            this.dgvResultados.SelectionChanged += new System.EventHandler(this.dgvResultados_SelectionChanged);
            // 
            // colCodigo
            // 
            this.colCodigo.FillWeight = 12F;
            this.colCodigo.HeaderText = "Código";
            this.colCodigo.Name = "colCodigo";
            this.colCodigo.ReadOnly = true;
            // 
            // colFecha
            // 
            estiloColumna_colFecha.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            estiloColumna_colFecha.Format = "dd/MM/yyyy HH:mm";
            this.colFecha.DefaultCellStyle = estiloColumna_colFecha;
            this.colFecha.FillWeight = 13F;
            this.colFecha.HeaderText = "Fecha";
            this.colFecha.Name = "colFecha";
            this.colFecha.ReadOnly = true;
            // 
            // colSolicitante
            // 
            this.colSolicitante.FillWeight = 18F;
            this.colSolicitante.HeaderText = "Solicitante";
            this.colSolicitante.Name = "colSolicitante";
            this.colSolicitante.ReadOnly = true;
            // 
            // colDepartamento
            // 
            this.colDepartamento.FillWeight = 15F;
            this.colDepartamento.HeaderText = "Departamento";
            this.colDepartamento.Name = "colDepartamento";
            this.colDepartamento.ReadOnly = true;
            // 
            // colEstado
            // 
            this.colEstado.FillWeight = 11F;
            this.colEstado.HeaderText = "Estado";
            this.colEstado.Name = "colEstado";
            this.colEstado.ReadOnly = true;
            // 
            // colSubtotal
            // 
            estiloColumna_colSubtotal.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            estiloColumna_colSubtotal.Format = "N2";
            this.colSubtotal.DefaultCellStyle = estiloColumna_colSubtotal;
            this.colSubtotal.FillWeight = 10F;
            this.colSubtotal.HeaderText = "Subtotal";
            this.colSubtotal.Name = "colSubtotal";
            this.colSubtotal.ReadOnly = true;
            // 
            // colImpuestos
            // 
            estiloColumna_colImpuestos.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            estiloColumna_colImpuestos.Format = "N2";
            this.colImpuestos.DefaultCellStyle = estiloColumna_colImpuestos;
            this.colImpuestos.FillWeight = 10F;
            this.colImpuestos.HeaderText = "Impuestos";
            this.colImpuestos.Name = "colImpuestos";
            this.colImpuestos.ReadOnly = true;
            // 
            // colTotal
            // 
            estiloColumna_colTotal.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            estiloColumna_colTotal.Format = "N2";
            this.colTotal.DefaultCellStyle = estiloColumna_colTotal;
            this.colTotal.FillWeight = 11F;
            this.colTotal.HeaderText = "Total";
            this.colTotal.Name = "colTotal";
            this.colTotal.ReadOnly = true;
            // 
            // lblConteo
            // 
            this.lblConteo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblConteo.AutoSize = true;
            this.lblConteo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(112)))), ((int)(((byte)(128)))));
            this.lblConteo.Location = new System.Drawing.Point(24, 546);
            this.lblConteo.Text = "0 requisiciones encontradas";
            this.lblConteo.Name = "lblConteo";
            this.lblConteo.TabIndex = 3;
            // 
            // panelAcciones
            // 
            this.panelAcciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(233)))), ((int)(((byte)(240)))));
            this.panelAcciones.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelAcciones.Location = new System.Drawing.Point(0, 0);
            this.panelAcciones.Size = new System.Drawing.Size(1100, 60);
            this.panelAcciones.Name = "panelAcciones";
            this.panelAcciones.TabIndex = 4;
            // 
            // btnAbrir
            // 
            this.btnAbrir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAbrir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbrir.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbrir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(105)))), ((int)(((byte)(170)))));
            this.btnAbrir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAbrir.FlatAppearance.BorderSize = 0;
            this.btnAbrir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(88)))), ((int)(((byte)(148)))));
            this.btnAbrir.Location = new System.Drawing.Point(24, 15);
            this.btnAbrir.Size = new System.Drawing.Size(160, 30);
            this.btnAbrir.Text = "Abrir requisición";
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.TabIndex = 0;
            this.btnAbrir.UseVisualStyleBackColor = false;
            this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click);
            // 
            // btnNueva
            // 
            this.btnNueva.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNueva.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNueva.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNueva.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnNueva.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(66)))));
            this.btnNueva.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(198)))), ((int)(((byte)(208)))));
            this.btnNueva.FlatAppearance.BorderSize = 1;
            this.btnNueva.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(241)))), ((int)(((byte)(247)))));
            this.btnNueva.Location = new System.Drawing.Point(194, 15);
            this.btnNueva.Size = new System.Drawing.Size(150, 30);
            this.btnNueva.Text = "Nueva requisición";
            this.btnNueva.Name = "btnNueva";
            this.btnNueva.TabIndex = 1;
            this.btnNueva.UseVisualStyleBackColor = false;
            this.btnNueva.Click += new System.EventHandler(this.btnNueva_Click);
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
            this.btnGenerarReporte.Location = new System.Drawing.Point(354, 15);
            this.btnGenerarReporte.Size = new System.Drawing.Size(140, 30);
            this.btnGenerarReporte.Text = "Generar reporte";
            this.btnGenerarReporte.Name = "btnGenerarReporte";
            this.btnGenerarReporte.TabIndex = 2;
            this.btnGenerarReporte.UseVisualStyleBackColor = false;
            this.btnGenerarReporte.Click += new System.EventHandler(this.btnGenerarReporte_Click);
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
            this.btnCerrar.Location = new System.Drawing.Point(966, 15);
            this.btnCerrar.Size = new System.Drawing.Size(110, 30);
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.TabIndex = 3;
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // FrmConsultaRequisiciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(243)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(1100, 640);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Consulta de requisiciones";
            this.MinimumSize = new System.Drawing.Size(1116, 679);
            this.AcceptButton = this.btnBuscar;
            this.Name = "FrmConsultaRequisiciones";
            this.Load += new System.EventHandler(this.FrmConsultaRequisiciones_Load);
            this.Controls.Add(this.panelEncabezado);
            this.panelEncabezado.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.panelFiltros);
            this.panelFiltros.Controls.Add(this.lblCodigo);
            this.panelFiltros.Controls.Add(this.txtCodigo);
            this.panelFiltros.Controls.Add(this.lblSolicitante);
            this.panelFiltros.Controls.Add(this.cmbSolicitante);
            this.panelFiltros.Controls.Add(this.lblDesde);
            this.panelFiltros.Controls.Add(this.dtpDesde);
            this.panelFiltros.Controls.Add(this.lblHasta);
            this.panelFiltros.Controls.Add(this.dtpHasta);
            this.panelFiltros.Controls.Add(this.lblEstado);
            this.panelFiltros.Controls.Add(this.cmbEstado);
            this.panelFiltros.Controls.Add(this.btnBuscar);
            this.panelFiltros.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.dgvResultados);
            this.Controls.Add(this.lblConteo);
            this.Controls.Add(this.panelAcciones);
            this.panelAcciones.Controls.Add(this.btnAbrir);
            this.panelAcciones.Controls.Add(this.btnNueva);
            this.panelAcciones.Controls.Add(this.btnGenerarReporte);
            this.panelAcciones.Controls.Add(this.btnCerrar);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).EndInit();
            this.panelEncabezado.ResumeLayout(false);
            this.panelEncabezado.PerformLayout();
            this.panelFiltros.ResumeLayout(false);
            this.panelFiltros.PerformLayout();
            this.panelAcciones.ResumeLayout(false);
            this.panelAcciones.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelEncabezado;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel panelFiltros;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblSolicitante;
        private System.Windows.Forms.ComboBox cmbSolicitante;
        private System.Windows.Forms.Label lblDesde;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.DataGridView dgvResultados;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSolicitante;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDepartamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSubtotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colImpuestos;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotal;
        private System.Windows.Forms.Label lblConteo;
        private System.Windows.Forms.Panel panelAcciones;
        private System.Windows.Forms.Button btnAbrir;
        private System.Windows.Forms.Button btnNueva;
        private System.Windows.Forms.Button btnGenerarReporte;
        private System.Windows.Forms.Button btnCerrar;
    }
}
