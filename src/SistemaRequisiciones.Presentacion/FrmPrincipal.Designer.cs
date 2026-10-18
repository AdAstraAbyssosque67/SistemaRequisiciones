namespace SistemaRequisiciones.Presentacion
{
    partial class FrmPrincipal
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle33 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle36 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle34 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle35 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle37 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle40 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle38 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle39 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelNavegacion = new System.Windows.Forms.Panel();
            this.lblMarca = new System.Windows.Forms.Label();
            this.btnInicio = new System.Windows.Forms.Button();
            this.btnNavNueva = new System.Windows.Forms.Button();
            this.btnNavConsulta = new System.Windows.Forms.Button();
            this.btnNavArticulos = new System.Windows.Forms.Button();
            this.btnNavReportes = new System.Windows.Forms.Button();
            this.lblTituloPagina = new System.Windows.Forms.Label();
            this.panelRecordatorios = new System.Windows.Forms.Panel();
            this.lblTituloRecordatorios = new System.Windows.Forms.Label();
            this.panelBarraPendientes = new System.Windows.Forms.Panel();
            this.lblNumeroPendientes = new System.Windows.Forms.Label();
            this.linkPendientes = new System.Windows.Forms.LinkLabel();
            this.panelBarraCreadas = new System.Windows.Forms.Panel();
            this.lblNumeroCreadas = new System.Windows.Forms.Label();
            this.linkCreadas = new System.Windows.Forms.LinkLabel();
            this.panelAccesos = new System.Windows.Forms.Panel();
            this.lblTituloAccesos = new System.Windows.Forms.Label();
            this.btnTileNueva = new System.Windows.Forms.Button();
            this.btnTileConsulta = new System.Windows.Forms.Button();
            this.btnTileArticulos = new System.Windows.Forms.Button();
            this.btnTileReportes = new System.Windows.Forms.Button();
            this.panelKpiTotal = new System.Windows.Forms.Panel();
            this.lblKpiTotalTitulo = new System.Windows.Forms.Label();
            this.lblKpiTotalValor = new System.Windows.Forms.Label();
            this.lblKpiTotalDetalle = new System.Windows.Forms.Label();
            this.panelKpiPendientes = new System.Windows.Forms.Panel();
            this.lblKpiPendientesTitulo = new System.Windows.Forms.Label();
            this.lblKpiPendientesValor = new System.Windows.Forms.Label();
            this.lblKpiPendientesDetalle = new System.Windows.Forms.Label();
            this.panelKpiMonto = new System.Windows.Forms.Panel();
            this.lblKpiMontoTitulo = new System.Windows.Forms.Label();
            this.lblKpiMontoValor = new System.Windows.Forms.Label();
            this.lblKpiMontoDetalle = new System.Windows.Forms.Label();
            this.panelResumen = new System.Windows.Forms.Panel();
            this.lblTituloResumen = new System.Windows.Forms.Label();
            this.dgvResumen = new System.Windows.Forms.DataGridView();
            this.colResumenEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colResumenCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colResumenMonto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelRecientes = new System.Windows.Forms.Panel();
            this.lblTituloRecientes = new System.Windows.Forms.Label();
            this.dgvRecientes = new System.Windows.Forms.DataGridView();
            this.colRecCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRecFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRecSolicitante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRecEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRecTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelNavegacion.SuspendLayout();
            this.panelRecordatorios.SuspendLayout();
            this.panelAccesos.SuspendLayout();
            this.panelKpiTotal.SuspendLayout();
            this.panelKpiPendientes.SuspendLayout();
            this.panelKpiMonto.SuspendLayout();
            this.panelResumen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResumen)).BeginInit();
            this.panelRecientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecientes)).BeginInit();
            this.SuspendLayout();
            // 
            // panelNavegacion
            // 
            this.panelNavegacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(115)))), ((int)(((byte)(150)))));
            this.panelNavegacion.Controls.Add(this.lblMarca);
            this.panelNavegacion.Controls.Add(this.btnInicio);
            this.panelNavegacion.Controls.Add(this.btnNavNueva);
            this.panelNavegacion.Controls.Add(this.btnNavConsulta);
            this.panelNavegacion.Controls.Add(this.btnNavArticulos);
            this.panelNavegacion.Controls.Add(this.btnNavReportes);
            this.panelNavegacion.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelNavegacion.Location = new System.Drawing.Point(0, 0);
            this.panelNavegacion.Name = "panelNavegacion";
            this.panelNavegacion.Size = new System.Drawing.Size(1100, 48);
            this.panelNavegacion.TabIndex = 0;
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblMarca.Location = new System.Drawing.Point(20, 12);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(250, 28);
            this.lblMarca.TabIndex = 0;
            this.lblMarca.Text = "Sistema de Requisiciones";
            // 
            // btnInicio
            // 
            this.btnInicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(89)))), ((int)(((byte)(125)))));
            this.btnInicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInicio.FlatAppearance.BorderSize = 0;
            this.btnInicio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(138)))), ((int)(((byte)(172)))));
            this.btnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInicio.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInicio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnInicio.Location = new System.Drawing.Point(270, 0);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(90, 48);
            this.btnInicio.TabIndex = 1;
            this.btnInicio.Text = "Inicio";
            this.btnInicio.UseVisualStyleBackColor = false;
            this.btnInicio.Click += new System.EventHandler(this.Inicio_Click);
            // 
            // btnNavNueva
            // 
            this.btnNavNueva.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(115)))), ((int)(((byte)(150)))));
            this.btnNavNueva.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavNueva.FlatAppearance.BorderSize = 0;
            this.btnNavNueva.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(138)))), ((int)(((byte)(172)))));
            this.btnNavNueva.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavNueva.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNavNueva.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnNavNueva.Location = new System.Drawing.Point(360, 0);
            this.btnNavNueva.Name = "btnNavNueva";
            this.btnNavNueva.Size = new System.Drawing.Size(150, 48);
            this.btnNavNueva.TabIndex = 2;
            this.btnNavNueva.Text = "Nueva requisición";
            this.btnNavNueva.UseVisualStyleBackColor = false;
            this.btnNavNueva.Click += new System.EventHandler(this.NuevaRequisicion_Click);
            // 
            // btnNavConsulta
            // 
            this.btnNavConsulta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(115)))), ((int)(((byte)(150)))));
            this.btnNavConsulta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavConsulta.FlatAppearance.BorderSize = 0;
            this.btnNavConsulta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(138)))), ((int)(((byte)(172)))));
            this.btnNavConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavConsulta.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNavConsulta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnNavConsulta.Location = new System.Drawing.Point(510, 0);
            this.btnNavConsulta.Name = "btnNavConsulta";
            this.btnNavConsulta.Size = new System.Drawing.Size(120, 48);
            this.btnNavConsulta.TabIndex = 3;
            this.btnNavConsulta.Text = "Consulta";
            this.btnNavConsulta.UseVisualStyleBackColor = false;
            this.btnNavConsulta.Click += new System.EventHandler(this.Consulta_Click);
            // 
            // btnNavArticulos
            // 
            this.btnNavArticulos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(115)))), ((int)(((byte)(150)))));
            this.btnNavArticulos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavArticulos.FlatAppearance.BorderSize = 0;
            this.btnNavArticulos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(138)))), ((int)(((byte)(172)))));
            this.btnNavArticulos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavArticulos.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNavArticulos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnNavArticulos.Location = new System.Drawing.Point(630, 0);
            this.btnNavArticulos.Name = "btnNavArticulos";
            this.btnNavArticulos.Size = new System.Drawing.Size(110, 48);
            this.btnNavArticulos.TabIndex = 4;
            this.btnNavArticulos.Text = "Artículos";
            this.btnNavArticulos.UseVisualStyleBackColor = false;
            this.btnNavArticulos.Click += new System.EventHandler(this.Articulos_Click);
            // 
            // btnNavReportes
            // 
            this.btnNavReportes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(115)))), ((int)(((byte)(150)))));
            this.btnNavReportes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavReportes.FlatAppearance.BorderSize = 0;
            this.btnNavReportes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(138)))), ((int)(((byte)(172)))));
            this.btnNavReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavReportes.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNavReportes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnNavReportes.Location = new System.Drawing.Point(740, 0);
            this.btnNavReportes.Name = "btnNavReportes";
            this.btnNavReportes.Size = new System.Drawing.Size(110, 48);
            this.btnNavReportes.TabIndex = 5;
            this.btnNavReportes.Text = "Reportes";
            this.btnNavReportes.UseVisualStyleBackColor = false;
            this.btnNavReportes.Click += new System.EventHandler(this.Reportes_Click);
            // 
            // lblTituloPagina
            // 
            this.lblTituloPagina.AutoSize = true;
            this.lblTituloPagina.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloPagina.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(66)))));
            this.lblTituloPagina.Location = new System.Drawing.Point(22, 56);
            this.lblTituloPagina.Name = "lblTituloPagina";
            this.lblTituloPagina.Size = new System.Drawing.Size(81, 37);
            this.lblTituloPagina.TabIndex = 1;
            this.lblTituloPagina.Text = "Inicio";
            // 
            // panelRecordatorios
            // 
            this.panelRecordatorios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panelRecordatorios.Controls.Add(this.lblTituloRecordatorios);
            this.panelRecordatorios.Controls.Add(this.panelBarraPendientes);
            this.panelRecordatorios.Controls.Add(this.lblNumeroPendientes);
            this.panelRecordatorios.Controls.Add(this.linkPendientes);
            this.panelRecordatorios.Controls.Add(this.panelBarraCreadas);
            this.panelRecordatorios.Controls.Add(this.lblNumeroCreadas);
            this.panelRecordatorios.Controls.Add(this.linkCreadas);
            this.panelRecordatorios.Location = new System.Drawing.Point(24, 96);
            this.panelRecordatorios.Name = "panelRecordatorios";
            this.panelRecordatorios.Size = new System.Drawing.Size(300, 140);
            this.panelRecordatorios.TabIndex = 2;
            // 
            // lblTituloRecordatorios
            // 
            this.lblTituloRecordatorios.AutoSize = true;
            this.lblTituloRecordatorios.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloRecordatorios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(66)))));
            this.lblTituloRecordatorios.Location = new System.Drawing.Point(16, 10);
            this.lblTituloRecordatorios.Name = "lblTituloRecordatorios";
            this.lblTituloRecordatorios.Size = new System.Drawing.Size(137, 25);
            this.lblTituloRecordatorios.TabIndex = 0;
            this.lblTituloRecordatorios.Text = "Recordatorios";
            // 
            // panelBarraPendientes
            // 
            this.panelBarraPendientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            this.panelBarraPendientes.Location = new System.Drawing.Point(16, 40);
            this.panelBarraPendientes.Name = "panelBarraPendientes";
            this.panelBarraPendientes.Size = new System.Drawing.Size(4, 40);
            this.panelBarraPendientes.TabIndex = 1;
            // 
            // lblNumeroPendientes
            // 
            this.lblNumeroPendientes.AutoSize = true;
            this.lblNumeroPendientes.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroPendientes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(66)))));
            this.lblNumeroPendientes.Location = new System.Drawing.Point(28, 34);
            this.lblNumeroPendientes.Name = "lblNumeroPendientes";
            this.lblNumeroPendientes.Size = new System.Drawing.Size(35, 41);
            this.lblNumeroPendientes.TabIndex = 2;
            this.lblNumeroPendientes.Text = "0";
            // 
            // linkPendientes
            // 
            this.linkPendientes.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(88)))), ((int)(((byte)(148)))));
            this.linkPendientes.AutoSize = true;
            this.linkPendientes.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkPendientes.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(81)))), ((int)(((byte)(148)))));
            this.linkPendientes.Location = new System.Drawing.Point(28, 66);
            this.linkPendientes.Name = "linkPendientes";
            this.linkPendientes.Size = new System.Drawing.Size(183, 20);
            this.linkPendientes.TabIndex = 3;
            this.linkPendientes.TabStop = true;
            this.linkPendientes.Text = "Requisiciones por aprobar";
            this.linkPendientes.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkPendientes_LinkClicked);
            // 
            // panelBarraCreadas
            // 
            this.panelBarraCreadas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            this.panelBarraCreadas.Location = new System.Drawing.Point(16, 92);
            this.panelBarraCreadas.Name = "panelBarraCreadas";
            this.panelBarraCreadas.Size = new System.Drawing.Size(4, 40);
            this.panelBarraCreadas.TabIndex = 4;
            // 
            // lblNumeroCreadas
            // 
            this.lblNumeroCreadas.AutoSize = true;
            this.lblNumeroCreadas.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroCreadas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(66)))));
            this.lblNumeroCreadas.Location = new System.Drawing.Point(28, 86);
            this.lblNumeroCreadas.Name = "lblNumeroCreadas";
            this.lblNumeroCreadas.Size = new System.Drawing.Size(35, 41);
            this.lblNumeroCreadas.TabIndex = 5;
            this.lblNumeroCreadas.Text = "0";
            // 
            // linkCreadas
            // 
            this.linkCreadas.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(88)))), ((int)(((byte)(148)))));
            this.linkCreadas.AutoSize = true;
            this.linkCreadas.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkCreadas.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(81)))), ((int)(((byte)(148)))));
            this.linkCreadas.Location = new System.Drawing.Point(28, 118);
            this.linkCreadas.Name = "linkCreadas";
            this.linkCreadas.Size = new System.Drawing.Size(195, 20);
            this.linkCreadas.TabIndex = 6;
            this.linkCreadas.TabStop = true;
            this.linkCreadas.Text = "Creadas sin enviar a revisión";
            this.linkCreadas.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkCreadas_LinkClicked);
            // 
            // panelAccesos
            // 
            this.panelAccesos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelAccesos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panelAccesos.Controls.Add(this.lblTituloAccesos);
            this.panelAccesos.Controls.Add(this.btnTileNueva);
            this.panelAccesos.Controls.Add(this.btnTileConsulta);
            this.panelAccesos.Controls.Add(this.btnTileArticulos);
            this.panelAccesos.Controls.Add(this.btnTileReportes);
            this.panelAccesos.Location = new System.Drawing.Point(340, 96);
            this.panelAccesos.Name = "panelAccesos";
            this.panelAccesos.Size = new System.Drawing.Size(736, 140);
            this.panelAccesos.TabIndex = 3;
            // 
            // lblTituloAccesos
            // 
            this.lblTituloAccesos.AutoSize = true;
            this.lblTituloAccesos.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloAccesos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(66)))));
            this.lblTituloAccesos.Location = new System.Drawing.Point(16, 10);
            this.lblTituloAccesos.Name = "lblTituloAccesos";
            this.lblTituloAccesos.Size = new System.Drawing.Size(153, 25);
            this.lblTituloAccesos.TabIndex = 0;
            this.lblTituloAccesos.Text = "Accesos rápidos";
            // 
            // btnTileNueva
            // 
            this.btnTileNueva.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnTileNueva.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTileNueva.FlatAppearance.BorderSize = 0;
            this.btnTileNueva.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.btnTileNueva.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTileNueva.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTileNueva.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(66)))));
            this.btnTileNueva.Location = new System.Drawing.Point(14, 40);
            this.btnTileNueva.Name = "btnTileNueva";
            this.btnTileNueva.Padding = new System.Windows.Forms.Padding(8, 8, 8, 0);
            this.btnTileNueva.Size = new System.Drawing.Size(168, 88);
            this.btnTileNueva.TabIndex = 1;
            this.btnTileNueva.Text = "Nueva requisición";
            this.btnTileNueva.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnTileNueva.UseVisualStyleBackColor = false;
            this.btnTileNueva.Click += new System.EventHandler(this.NuevaRequisicion_Click);
            // 
            // btnTileConsulta
            // 
            this.btnTileConsulta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(240)))), ((int)(((byte)(218)))));
            this.btnTileConsulta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTileConsulta.FlatAppearance.BorderSize = 0;
            this.btnTileConsulta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(232)))), ((int)(((byte)(198)))));
            this.btnTileConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTileConsulta.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTileConsulta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(66)))));
            this.btnTileConsulta.Location = new System.Drawing.Point(194, 40);
            this.btnTileConsulta.Name = "btnTileConsulta";
            this.btnTileConsulta.Padding = new System.Windows.Forms.Padding(8, 8, 8, 0);
            this.btnTileConsulta.Size = new System.Drawing.Size(168, 88);
            this.btnTileConsulta.TabIndex = 2;
            this.btnTileConsulta.Text = "Consultar requisiciones";
            this.btnTileConsulta.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnTileConsulta.UseVisualStyleBackColor = false;
            this.btnTileConsulta.Click += new System.EventHandler(this.Consulta_Click);
            // 
            // btnTileArticulos
            // 
            this.btnTileArticulos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(228)))), ((int)(((byte)(210)))));
            this.btnTileArticulos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTileArticulos.FlatAppearance.BorderSize = 0;
            this.btnTileArticulos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(214)))), ((int)(((byte)(188)))));
            this.btnTileArticulos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTileArticulos.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTileArticulos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(66)))));
            this.btnTileArticulos.Location = new System.Drawing.Point(374, 40);
            this.btnTileArticulos.Name = "btnTileArticulos";
            this.btnTileArticulos.Padding = new System.Windows.Forms.Padding(8, 8, 8, 0);
            this.btnTileArticulos.Size = new System.Drawing.Size(168, 88);
            this.btnTileArticulos.TabIndex = 3;
            this.btnTileArticulos.Text = "Catálogo de artículos";
            this.btnTileArticulos.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnTileArticulos.UseVisualStyleBackColor = false;
            this.btnTileArticulos.Click += new System.EventHandler(this.Articulos_Click);
            // 
            // btnTileReportes
            // 
            this.btnTileReportes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(230)))), ((int)(((byte)(243)))));
            this.btnTileReportes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTileReportes.FlatAppearance.BorderSize = 0;
            this.btnTileReportes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(236)))));
            this.btnTileReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTileReportes.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTileReportes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(66)))));
            this.btnTileReportes.Location = new System.Drawing.Point(554, 40);
            this.btnTileReportes.Name = "btnTileReportes";
            this.btnTileReportes.Padding = new System.Windows.Forms.Padding(8, 8, 8, 0);
            this.btnTileReportes.Size = new System.Drawing.Size(168, 88);
            this.btnTileReportes.TabIndex = 4;
            this.btnTileReportes.Text = "Reportes de aprobadas";
            this.btnTileReportes.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnTileReportes.UseVisualStyleBackColor = false;
            this.btnTileReportes.Click += new System.EventHandler(this.Reportes_Click);
            // 
            // panelKpiTotal
            // 
            this.panelKpiTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panelKpiTotal.Controls.Add(this.lblKpiTotalTitulo);
            this.panelKpiTotal.Controls.Add(this.lblKpiTotalValor);
            this.panelKpiTotal.Controls.Add(this.lblKpiTotalDetalle);
            this.panelKpiTotal.Location = new System.Drawing.Point(24, 248);
            this.panelKpiTotal.Name = "panelKpiTotal";
            this.panelKpiTotal.Size = new System.Drawing.Size(300, 128);
            this.panelKpiTotal.TabIndex = 4;
            // 
            // lblKpiTotalTitulo
            // 
            this.lblKpiTotalTitulo.AutoSize = true;
            this.lblKpiTotalTitulo.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKpiTotalTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(112)))), ((int)(((byte)(128)))));
            this.lblKpiTotalTitulo.Location = new System.Drawing.Point(16, 12);
            this.lblKpiTotalTitulo.Name = "lblKpiTotalTitulo";
            this.lblKpiTotalTitulo.Size = new System.Drawing.Size(112, 19);
            this.lblKpiTotalTitulo.TabIndex = 0;
            this.lblKpiTotalTitulo.Text = "REQUISICIONES";
            // 
            // lblKpiTotalValor
            // 
            this.lblKpiTotalValor.AutoSize = true;
            this.lblKpiTotalValor.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKpiTotalValor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(66)))));
            this.lblKpiTotalValor.Location = new System.Drawing.Point(14, 36);
            this.lblKpiTotalValor.Name = "lblKpiTotalValor";
            this.lblKpiTotalValor.Size = new System.Drawing.Size(46, 54);
            this.lblKpiTotalValor.TabIndex = 1;
            this.lblKpiTotalValor.Text = "0";
            // 
            // lblKpiTotalDetalle
            // 
            this.lblKpiTotalDetalle.AutoSize = true;
            this.lblKpiTotalDetalle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKpiTotalDetalle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(112)))), ((int)(((byte)(128)))));
            this.lblKpiTotalDetalle.Location = new System.Drawing.Point(16, 94);
            this.lblKpiTotalDetalle.Name = "lblKpiTotalDetalle";
            this.lblKpiTotalDetalle.Size = new System.Drawing.Size(176, 20);
            this.lblKpiTotalDetalle.TabIndex = 2;
            this.lblKpiTotalDetalle.Text = "Registradas en el sistema";
            // 
            // panelKpiPendientes
            // 
            this.panelKpiPendientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panelKpiPendientes.Controls.Add(this.lblKpiPendientesTitulo);
            this.panelKpiPendientes.Controls.Add(this.lblKpiPendientesValor);
            this.panelKpiPendientes.Controls.Add(this.lblKpiPendientesDetalle);
            this.panelKpiPendientes.Location = new System.Drawing.Point(24, 386);
            this.panelKpiPendientes.Name = "panelKpiPendientes";
            this.panelKpiPendientes.Size = new System.Drawing.Size(300, 128);
            this.panelKpiPendientes.TabIndex = 5;
            // 
            // lblKpiPendientesTitulo
            // 
            this.lblKpiPendientesTitulo.AutoSize = true;
            this.lblKpiPendientesTitulo.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKpiPendientesTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(112)))), ((int)(((byte)(128)))));
            this.lblKpiPendientesTitulo.Location = new System.Drawing.Point(16, 12);
            this.lblKpiPendientesTitulo.Name = "lblKpiPendientesTitulo";
            this.lblKpiPendientesTitulo.Size = new System.Drawing.Size(183, 19);
            this.lblKpiPendientesTitulo.TabIndex = 0;
            this.lblKpiPendientesTitulo.Text = "PENDIENTES DE APROBAR";
            // 
            // lblKpiPendientesValor
            // 
            this.lblKpiPendientesValor.AutoSize = true;
            this.lblKpiPendientesValor.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKpiPendientesValor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(66)))));
            this.lblKpiPendientesValor.Location = new System.Drawing.Point(14, 36);
            this.lblKpiPendientesValor.Name = "lblKpiPendientesValor";
            this.lblKpiPendientesValor.Size = new System.Drawing.Size(46, 54);
            this.lblKpiPendientesValor.TabIndex = 1;
            this.lblKpiPendientesValor.Text = "0";
            // 
            // lblKpiPendientesDetalle
            // 
            this.lblKpiPendientesDetalle.AutoSize = true;
            this.lblKpiPendientesDetalle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKpiPendientesDetalle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(112)))), ((int)(((byte)(128)))));
            this.lblKpiPendientesDetalle.Location = new System.Drawing.Point(16, 94);
            this.lblKpiPendientesDetalle.Name = "lblKpiPendientesDetalle";
            this.lblKpiPendientesDetalle.Size = new System.Drawing.Size(174, 20);
            this.lblKpiPendientesDetalle.TabIndex = 2;
            this.lblKpiPendientesDetalle.Text = "Requisiciones en revisión";
            // 
            // panelKpiMonto
            // 
            this.panelKpiMonto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panelKpiMonto.Controls.Add(this.lblKpiMontoTitulo);
            this.panelKpiMonto.Controls.Add(this.lblKpiMontoValor);
            this.panelKpiMonto.Controls.Add(this.lblKpiMontoDetalle);
            this.panelKpiMonto.Location = new System.Drawing.Point(24, 524);
            this.panelKpiMonto.Name = "panelKpiMonto";
            this.panelKpiMonto.Size = new System.Drawing.Size(300, 128);
            this.panelKpiMonto.TabIndex = 6;
            // 
            // lblKpiMontoTitulo
            // 
            this.lblKpiMontoTitulo.AutoSize = true;
            this.lblKpiMontoTitulo.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKpiMontoTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(112)))), ((int)(((byte)(128)))));
            this.lblKpiMontoTitulo.Location = new System.Drawing.Point(16, 12);
            this.lblKpiMontoTitulo.Name = "lblKpiMontoTitulo";
            this.lblKpiMontoTitulo.Size = new System.Drawing.Size(145, 19);
            this.lblKpiMontoTitulo.TabIndex = 0;
            this.lblKpiMontoTitulo.Text = "MONTO APROBADO";
            // 
            // lblKpiMontoValor
            // 
            this.lblKpiMontoValor.AutoSize = true;
            this.lblKpiMontoValor.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKpiMontoValor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(66)))));
            this.lblKpiMontoValor.Location = new System.Drawing.Point(14, 36);
            this.lblKpiMontoValor.Name = "lblKpiMontoValor";
            this.lblKpiMontoValor.Size = new System.Drawing.Size(43, 50);
            this.lblKpiMontoValor.TabIndex = 1;
            this.lblKpiMontoValor.Text = "0";
            // 
            // lblKpiMontoDetalle
            // 
            this.lblKpiMontoDetalle.AutoSize = true;
            this.lblKpiMontoDetalle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKpiMontoDetalle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(112)))), ((int)(((byte)(128)))));
            this.lblKpiMontoDetalle.Location = new System.Drawing.Point(16, 94);
            this.lblKpiMontoDetalle.Name = "lblKpiMontoDetalle";
            this.lblKpiMontoDetalle.Size = new System.Drawing.Size(224, 20);
            this.lblKpiMontoDetalle.TabIndex = 2;
            this.lblKpiMontoDetalle.Text = "Suma del total de las aprobadas";
            // 
            // panelResumen
            // 
            this.panelResumen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelResumen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panelResumen.Controls.Add(this.lblTituloResumen);
            this.panelResumen.Controls.Add(this.dgvResumen);
            this.panelResumen.Location = new System.Drawing.Point(340, 248);
            this.panelResumen.Name = "panelResumen";
            this.panelResumen.Size = new System.Drawing.Size(736, 204);
            this.panelResumen.TabIndex = 7;
            // 
            // lblTituloResumen
            // 
            this.lblTituloResumen.AutoSize = true;
            this.lblTituloResumen.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloResumen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(66)))));
            this.lblTituloResumen.Location = new System.Drawing.Point(16, 10);
            this.lblTituloResumen.Name = "lblTituloResumen";
            this.lblTituloResumen.Size = new System.Drawing.Size(194, 25);
            this.lblTituloResumen.TabIndex = 0;
            this.lblTituloResumen.Text = "Resumen por estado";
            // 
            // dgvResumen
            // 
            this.dgvResumen.AllowUserToAddRows = false;
            this.dgvResumen.AllowUserToDeleteRows = false;
            this.dgvResumen.AllowUserToResizeRows = false;
            this.dgvResumen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvResumen.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvResumen.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvResumen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvResumen.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvResumen.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle33.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle33.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(248)))));
            dataGridViewCellStyle33.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle33.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(66)))));
            dataGridViewCellStyle33.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(248)))));
            dataGridViewCellStyle33.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(66)))));
            dataGridViewCellStyle33.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvResumen.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle33;
            this.dgvResumen.ColumnHeadersHeight = 28;
            this.dgvResumen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvResumen.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colResumenEstado,
            this.colResumenCantidad,
            this.colResumenMonto});
            dataGridViewCellStyle36.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle36.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle36.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle36.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(66)))));
            dataGridViewCellStyle36.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(230)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle36.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(66)))));
            dataGridViewCellStyle36.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvResumen.DefaultCellStyle = dataGridViewCellStyle36;
            this.dgvResumen.EnableHeadersVisualStyles = false;
            this.dgvResumen.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(230)))), ((int)(((byte)(236)))));
            this.dgvResumen.Location = new System.Drawing.Point(16, 40);
            this.dgvResumen.MultiSelect = false;
            this.dgvResumen.Name = "dgvResumen";
            this.dgvResumen.ReadOnly = true;
            this.dgvResumen.RowHeadersVisible = false;
            this.dgvResumen.RowHeadersWidth = 51;
            this.dgvResumen.RowTemplate.Height = 26;
            this.dgvResumen.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvResumen.Size = new System.Drawing.Size(704, 160);
            this.dgvResumen.TabIndex = 1;
            // 
            // colResumenEstado
            // 
            this.colResumenEstado.FillWeight = 40F;
            this.colResumenEstado.HeaderText = "Estado";
            this.colResumenEstado.MinimumWidth = 6;
            this.colResumenEstado.Name = "colResumenEstado";
            this.colResumenEstado.ReadOnly = true;
            // 
            // colResumenCantidad
            // 
            dataGridViewCellStyle34.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle34.Format = "N0";
            this.colResumenCantidad.DefaultCellStyle = dataGridViewCellStyle34;
            this.colResumenCantidad.FillWeight = 25F;
            this.colResumenCantidad.HeaderText = "Requisiciones";
            this.colResumenCantidad.MinimumWidth = 6;
            this.colResumenCantidad.Name = "colResumenCantidad";
            this.colResumenCantidad.ReadOnly = true;
            // 
            // colResumenMonto
            // 
            dataGridViewCellStyle35.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle35.Format = "N2";
            this.colResumenMonto.DefaultCellStyle = dataGridViewCellStyle35;
            this.colResumenMonto.FillWeight = 35F;
            this.colResumenMonto.HeaderText = "Monto total";
            this.colResumenMonto.MinimumWidth = 6;
            this.colResumenMonto.Name = "colResumenMonto";
            this.colResumenMonto.ReadOnly = true;
            // 
            // panelRecientes
            // 
            this.panelRecientes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelRecientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panelRecientes.Controls.Add(this.lblTituloRecientes);
            this.panelRecientes.Controls.Add(this.dgvRecientes);
            this.panelRecientes.Location = new System.Drawing.Point(340, 464);
            this.panelRecientes.Name = "panelRecientes";
            this.panelRecientes.Size = new System.Drawing.Size(736, 188);
            this.panelRecientes.TabIndex = 8;
            // 
            // lblTituloRecientes
            // 
            this.lblTituloRecientes.AutoSize = true;
            this.lblTituloRecientes.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloRecientes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(66)))));
            this.lblTituloRecientes.Location = new System.Drawing.Point(16, 10);
            this.lblTituloRecientes.Name = "lblTituloRecientes";
            this.lblTituloRecientes.Size = new System.Drawing.Size(412, 25);
            this.lblTituloRecientes.TabIndex = 0;
            this.lblTituloRecientes.Text = "Requisiciones recientes (doble clic para abrir)";
            // 
            // dgvRecientes
            // 
            this.dgvRecientes.AllowUserToAddRows = false;
            this.dgvRecientes.AllowUserToDeleteRows = false;
            this.dgvRecientes.AllowUserToResizeRows = false;
            this.dgvRecientes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRecientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRecientes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvRecientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRecientes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvRecientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle37.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle37.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(248)))));
            dataGridViewCellStyle37.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle37.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(66)))));
            dataGridViewCellStyle37.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(248)))));
            dataGridViewCellStyle37.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(66)))));
            dataGridViewCellStyle37.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRecientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle37;
            this.dgvRecientes.ColumnHeadersHeight = 28;
            this.dgvRecientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvRecientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colRecCodigo,
            this.colRecFecha,
            this.colRecSolicitante,
            this.colRecEstado,
            this.colRecTotal});
            dataGridViewCellStyle40.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle40.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle40.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle40.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(66)))));
            dataGridViewCellStyle40.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(230)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle40.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(66)))));
            dataGridViewCellStyle40.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRecientes.DefaultCellStyle = dataGridViewCellStyle40;
            this.dgvRecientes.EnableHeadersVisualStyles = false;
            this.dgvRecientes.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(230)))), ((int)(((byte)(236)))));
            this.dgvRecientes.Location = new System.Drawing.Point(16, 40);
            this.dgvRecientes.MultiSelect = false;
            this.dgvRecientes.Name = "dgvRecientes";
            this.dgvRecientes.ReadOnly = true;
            this.dgvRecientes.RowHeadersVisible = false;
            this.dgvRecientes.RowHeadersWidth = 51;
            this.dgvRecientes.RowTemplate.Height = 26;
            this.dgvRecientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRecientes.Size = new System.Drawing.Size(704, 136);
            this.dgvRecientes.TabIndex = 1;
            this.dgvRecientes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRecientes_CellDoubleClick);
            // 
            // colRecCodigo
            // 
            this.colRecCodigo.FillWeight = 22F;
            this.colRecCodigo.HeaderText = "Código";
            this.colRecCodigo.MinimumWidth = 6;
            this.colRecCodigo.Name = "colRecCodigo";
            this.colRecCodigo.ReadOnly = true;
            // 
            // colRecFecha
            // 
            dataGridViewCellStyle38.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle38.Format = "dd/MM/yyyy";
            this.colRecFecha.DefaultCellStyle = dataGridViewCellStyle38;
            this.colRecFecha.FillWeight = 22F;
            this.colRecFecha.HeaderText = "Fecha";
            this.colRecFecha.MinimumWidth = 6;
            this.colRecFecha.Name = "colRecFecha";
            this.colRecFecha.ReadOnly = true;
            // 
            // colRecSolicitante
            // 
            this.colRecSolicitante.FillWeight = 26F;
            this.colRecSolicitante.HeaderText = "Solicitante";
            this.colRecSolicitante.MinimumWidth = 6;
            this.colRecSolicitante.Name = "colRecSolicitante";
            this.colRecSolicitante.ReadOnly = true;
            // 
            // colRecEstado
            // 
            this.colRecEstado.FillWeight = 14F;
            this.colRecEstado.HeaderText = "Estado";
            this.colRecEstado.MinimumWidth = 6;
            this.colRecEstado.Name = "colRecEstado";
            this.colRecEstado.ReadOnly = true;
            // 
            // colRecTotal
            // 
            dataGridViewCellStyle39.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle39.Format = "N2";
            this.colRecTotal.DefaultCellStyle = dataGridViewCellStyle39;
            this.colRecTotal.FillWeight = 16F;
            this.colRecTotal.HeaderText = "Total";
            this.colRecTotal.MinimumWidth = 6;
            this.colRecTotal.Name = "colRecTotal";
            this.colRecTotal.ReadOnly = true;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(243)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(1100, 676);
            this.Controls.Add(this.panelNavegacion);
            this.Controls.Add(this.lblTituloPagina);
            this.Controls.Add(this.panelRecordatorios);
            this.Controls.Add(this.panelAccesos);
            this.Controls.Add(this.panelKpiTotal);
            this.Controls.Add(this.panelKpiPendientes);
            this.Controls.Add(this.panelKpiMonto);
            this.Controls.Add(this.panelResumen);
            this.Controls.Add(this.panelRecientes);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumSize = new System.Drawing.Size(1116, 715);
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Requisiciones de Compra";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.panelNavegacion.ResumeLayout(false);
            this.panelNavegacion.PerformLayout();
            this.panelRecordatorios.ResumeLayout(false);
            this.panelRecordatorios.PerformLayout();
            this.panelAccesos.ResumeLayout(false);
            this.panelAccesos.PerformLayout();
            this.panelKpiTotal.ResumeLayout(false);
            this.panelKpiTotal.PerformLayout();
            this.panelKpiPendientes.ResumeLayout(false);
            this.panelKpiPendientes.PerformLayout();
            this.panelKpiMonto.ResumeLayout(false);
            this.panelKpiMonto.PerformLayout();
            this.panelResumen.ResumeLayout(false);
            this.panelResumen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResumen)).EndInit();
            this.panelRecientes.ResumeLayout(false);
            this.panelRecientes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelNavegacion;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.Button btnNavNueva;
        private System.Windows.Forms.Button btnNavConsulta;
        private System.Windows.Forms.Button btnNavArticulos;
        private System.Windows.Forms.Button btnNavReportes;
        private System.Windows.Forms.Label lblTituloPagina;
        private System.Windows.Forms.Panel panelRecordatorios;
        private System.Windows.Forms.Label lblTituloRecordatorios;
        private System.Windows.Forms.Panel panelBarraPendientes;
        private System.Windows.Forms.Label lblNumeroPendientes;
        private System.Windows.Forms.LinkLabel linkPendientes;
        private System.Windows.Forms.Panel panelBarraCreadas;
        private System.Windows.Forms.Label lblNumeroCreadas;
        private System.Windows.Forms.LinkLabel linkCreadas;
        private System.Windows.Forms.Panel panelAccesos;
        private System.Windows.Forms.Label lblTituloAccesos;
        private System.Windows.Forms.Button btnTileNueva;
        private System.Windows.Forms.Button btnTileConsulta;
        private System.Windows.Forms.Button btnTileArticulos;
        private System.Windows.Forms.Button btnTileReportes;
        private System.Windows.Forms.Panel panelKpiTotal;
        private System.Windows.Forms.Label lblKpiTotalTitulo;
        private System.Windows.Forms.Label lblKpiTotalValor;
        private System.Windows.Forms.Label lblKpiTotalDetalle;
        private System.Windows.Forms.Panel panelKpiPendientes;
        private System.Windows.Forms.Label lblKpiPendientesTitulo;
        private System.Windows.Forms.Label lblKpiPendientesValor;
        private System.Windows.Forms.Label lblKpiPendientesDetalle;
        private System.Windows.Forms.Panel panelKpiMonto;
        private System.Windows.Forms.Label lblKpiMontoTitulo;
        private System.Windows.Forms.Label lblKpiMontoValor;
        private System.Windows.Forms.Label lblKpiMontoDetalle;
        private System.Windows.Forms.Panel panelResumen;
        private System.Windows.Forms.Label lblTituloResumen;
        private System.Windows.Forms.DataGridView dgvResumen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colResumenEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn colResumenCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colResumenMonto;
        private System.Windows.Forms.Panel panelRecientes;
        private System.Windows.Forms.Label lblTituloRecientes;
        private System.Windows.Forms.DataGridView dgvRecientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRecCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRecFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRecSolicitante;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRecEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRecTotal;
    }
}
