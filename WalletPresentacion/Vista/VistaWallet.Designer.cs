namespace WalletPresentacion.Vista
{
    partial class VistaWallet
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
            this.tabHome = new System.Windows.Forms.TabControl();
            this.tabCuentas = new System.Windows.Forms.TabPage();
            this.grbNuevaCuenta = new System.Windows.Forms.GroupBox();
            this.lblNombreCuenta = new System.Windows.Forms.Label();
            this.txtNombreCuenta = new System.Windows.Forms.TextBox();
            this.btnGuardarCuenta = new System.Windows.Forms.Button();
            this.btnAgregarCuenta = new System.Windows.Forms.Button();
            this.dgvCuentas = new System.Windows.Forms.DataGridView();
            this.tabCategorias = new System.Windows.Forms.TabPage();
            this.grbCategoria = new System.Windows.Forms.GroupBox();
            this.cmbTiposMovimiento = new System.Windows.Forms.ComboBox();
            this.lblTipoMovimiento = new System.Windows.Forms.Label();
            this.lblNombreCategoria = new System.Windows.Forms.Label();
            this.txtNombreCategoria = new System.Windows.Forms.TextBox();
            this.btnGuardarCategoria = new System.Windows.Forms.Button();
            this.btnNuevaCategoria = new System.Windows.Forms.Button();
            this.dgvCategorias = new System.Windows.Forms.DataGridView();
            this.tabMovimientos = new System.Windows.Forms.TabPage();
            this.grbDatosMovimientoMOV = new System.Windows.Forms.GroupBox();
            this.lblDescripcionMOV = new System.Windows.Forms.Label();
            this.txtDescripcionMOV = new System.Windows.Forms.TextBox();
            this.cmbCategoriasMOV = new System.Windows.Forms.ComboBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.cmbCuentasMOV = new System.Windows.Forms.ComboBox();
            this.lblCuentaMOV = new System.Windows.Forms.Label();
            this.cmbTipoMovimientoMOV = new System.Windows.Forms.ComboBox();
            this.lblTipoMovimientoMOV = new System.Windows.Forms.Label();
            this.lblValorMOV = new System.Windows.Forms.Label();
            this.txtValorMOV = new System.Windows.Forms.TextBox();
            this.btnGuardarMovimientoMOV = new System.Windows.Forms.Button();
            this.dgvMovimientosMOV = new System.Windows.Forms.DataGridView();
            this.btnNuevoMovimientoMOV = new System.Windows.Forms.Button();
            this.tabReportes = new System.Windows.Forms.TabPage();
            this.cmbCuentasDestinoMOV = new System.Windows.Forms.ComboBox();
            this.lblCuentaDestinoMOV = new System.Windows.Forms.Label();
            this.grbConsultaMovimientos = new System.Windows.Forms.GroupBox();
            this.cmbCategoriasConsulta = new System.Windows.Forms.ComboBox();
            this.lblCategoriaConsulta = new System.Windows.Forms.Label();
            this.cmbCuentasConsulta = new System.Windows.Forms.ComboBox();
            this.lblCuentaConsulta = new System.Windows.Forms.Label();
            this.cmbTiposMovimientoConsulta = new System.Windows.Forms.ComboBox();
            this.lblTiposMovimientoConsulta = new System.Windows.Forms.Label();
            this.btnConsulta = new System.Windows.Forms.Button();
            this.dgvConsultaMovimientos = new System.Windows.Forms.DataGridView();
            this.lblFechaInicioConsulta = new System.Windows.Forms.Label();
            this.dtpFechaInicioConsulta = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaFinConsulta = new System.Windows.Forms.DateTimePicker();
            this.lblFechaFinalConsulta = new System.Windows.Forms.Label();
            this.tabHome.SuspendLayout();
            this.tabCuentas.SuspendLayout();
            this.grbNuevaCuenta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCuentas)).BeginInit();
            this.tabCategorias.SuspendLayout();
            this.grbCategoria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorias)).BeginInit();
            this.tabMovimientos.SuspendLayout();
            this.grbDatosMovimientoMOV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovimientosMOV)).BeginInit();
            this.tabReportes.SuspendLayout();
            this.grbConsultaMovimientos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaMovimientos)).BeginInit();
            this.SuspendLayout();
            // 
            // tabHome
            // 
            this.tabHome.Controls.Add(this.tabCuentas);
            this.tabHome.Controls.Add(this.tabCategorias);
            this.tabHome.Controls.Add(this.tabMovimientos);
            this.tabHome.Controls.Add(this.tabReportes);
            this.tabHome.Location = new System.Drawing.Point(12, 12);
            this.tabHome.Name = "tabHome";
            this.tabHome.SelectedIndex = 0;
            this.tabHome.Size = new System.Drawing.Size(747, 471);
            this.tabHome.TabIndex = 0;
            this.tabHome.SelectedIndexChanged += new System.EventHandler(this.tabHome_SelectedIndexChanged);
            // 
            // tabCuentas
            // 
            this.tabCuentas.Controls.Add(this.grbNuevaCuenta);
            this.tabCuentas.Controls.Add(this.btnAgregarCuenta);
            this.tabCuentas.Controls.Add(this.dgvCuentas);
            this.tabCuentas.Location = new System.Drawing.Point(4, 22);
            this.tabCuentas.Name = "tabCuentas";
            this.tabCuentas.Padding = new System.Windows.Forms.Padding(3);
            this.tabCuentas.Size = new System.Drawing.Size(739, 445);
            this.tabCuentas.TabIndex = 0;
            this.tabCuentas.Text = "Cuentas";
            this.tabCuentas.UseVisualStyleBackColor = true;
            // 
            // grbNuevaCuenta
            // 
            this.grbNuevaCuenta.Controls.Add(this.lblNombreCuenta);
            this.grbNuevaCuenta.Controls.Add(this.txtNombreCuenta);
            this.grbNuevaCuenta.Controls.Add(this.btnGuardarCuenta);
            this.grbNuevaCuenta.Location = new System.Drawing.Point(167, 190);
            this.grbNuevaCuenta.Name = "grbNuevaCuenta";
            this.grbNuevaCuenta.Size = new System.Drawing.Size(401, 123);
            this.grbNuevaCuenta.TabIndex = 2;
            this.grbNuevaCuenta.TabStop = false;
            this.grbNuevaCuenta.Text = "Datos Cuenta";
            this.grbNuevaCuenta.Visible = false;
            // 
            // lblNombreCuenta
            // 
            this.lblNombreCuenta.AutoSize = true;
            this.lblNombreCuenta.Location = new System.Drawing.Point(36, 38);
            this.lblNombreCuenta.Name = "lblNombreCuenta";
            this.lblNombreCuenta.Size = new System.Drawing.Size(44, 13);
            this.lblNombreCuenta.TabIndex = 1;
            this.lblNombreCuenta.Text = "Nombre";
            // 
            // txtNombreCuenta
            // 
            this.txtNombreCuenta.Location = new System.Drawing.Point(86, 35);
            this.txtNombreCuenta.Name = "txtNombreCuenta";
            this.txtNombreCuenta.Size = new System.Drawing.Size(108, 20);
            this.txtNombreCuenta.TabIndex = 2;
            // 
            // btnGuardarCuenta
            // 
            this.btnGuardarCuenta.Location = new System.Drawing.Point(230, 30);
            this.btnGuardarCuenta.Name = "btnGuardarCuenta";
            this.btnGuardarCuenta.Size = new System.Drawing.Size(102, 29);
            this.btnGuardarCuenta.TabIndex = 3;
            this.btnGuardarCuenta.Text = "Guardar";
            this.btnGuardarCuenta.UseVisualStyleBackColor = true;
            this.btnGuardarCuenta.Click += new System.EventHandler(this.btnGuardarCuenta_Click);
            // 
            // btnAgregarCuenta
            // 
            this.btnAgregarCuenta.Location = new System.Drawing.Point(35, 190);
            this.btnAgregarCuenta.Name = "btnAgregarCuenta";
            this.btnAgregarCuenta.Size = new System.Drawing.Size(94, 36);
            this.btnAgregarCuenta.TabIndex = 1;
            this.btnAgregarCuenta.Text = "Nueva Cuenta";
            this.btnAgregarCuenta.UseVisualStyleBackColor = true;
            this.btnAgregarCuenta.Click += new System.EventHandler(this.btnAgregarCuenta_Click);
            // 
            // dgvCuentas
            // 
            this.dgvCuentas.AllowUserToAddRows = false;
            this.dgvCuentas.AllowUserToDeleteRows = false;
            this.dgvCuentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCuentas.Location = new System.Drawing.Point(167, 19);
            this.dgvCuentas.Name = "dgvCuentas";
            this.dgvCuentas.ReadOnly = true;
            this.dgvCuentas.Size = new System.Drawing.Size(401, 132);
            this.dgvCuentas.TabIndex = 0;
            // 
            // tabCategorias
            // 
            this.tabCategorias.Controls.Add(this.grbCategoria);
            this.tabCategorias.Controls.Add(this.btnNuevaCategoria);
            this.tabCategorias.Controls.Add(this.dgvCategorias);
            this.tabCategorias.Location = new System.Drawing.Point(4, 22);
            this.tabCategorias.Name = "tabCategorias";
            this.tabCategorias.Padding = new System.Windows.Forms.Padding(3);
            this.tabCategorias.Size = new System.Drawing.Size(739, 445);
            this.tabCategorias.TabIndex = 1;
            this.tabCategorias.Text = "Categorias";
            this.tabCategorias.UseVisualStyleBackColor = true;
            // 
            // grbCategoria
            // 
            this.grbCategoria.Controls.Add(this.cmbTiposMovimiento);
            this.grbCategoria.Controls.Add(this.lblTipoMovimiento);
            this.grbCategoria.Controls.Add(this.lblNombreCategoria);
            this.grbCategoria.Controls.Add(this.txtNombreCategoria);
            this.grbCategoria.Controls.Add(this.btnGuardarCategoria);
            this.grbCategoria.Location = new System.Drawing.Point(193, 251);
            this.grbCategoria.Name = "grbCategoria";
            this.grbCategoria.Size = new System.Drawing.Size(401, 123);
            this.grbCategoria.TabIndex = 5;
            this.grbCategoria.TabStop = false;
            this.grbCategoria.Text = "Datos Categoria";
            this.grbCategoria.Visible = false;
            // 
            // cmbTiposMovimiento
            // 
            this.cmbTiposMovimiento.FormattingEnabled = true;
            this.cmbTiposMovimiento.Location = new System.Drawing.Point(128, 29);
            this.cmbTiposMovimiento.Name = "cmbTiposMovimiento";
            this.cmbTiposMovimiento.Size = new System.Drawing.Size(121, 21);
            this.cmbTiposMovimiento.TabIndex = 5;
            // 
            // lblTipoMovimiento
            // 
            this.lblTipoMovimiento.AutoSize = true;
            this.lblTipoMovimiento.Location = new System.Drawing.Point(20, 32);
            this.lblTipoMovimiento.Name = "lblTipoMovimiento";
            this.lblTipoMovimiento.Size = new System.Drawing.Size(85, 13);
            this.lblTipoMovimiento.TabIndex = 4;
            this.lblTipoMovimiento.Text = "Tipo Movimiento";
            // 
            // lblNombreCategoria
            // 
            this.lblNombreCategoria.AutoSize = true;
            this.lblNombreCategoria.Location = new System.Drawing.Point(61, 75);
            this.lblNombreCategoria.Name = "lblNombreCategoria";
            this.lblNombreCategoria.Size = new System.Drawing.Size(44, 13);
            this.lblNombreCategoria.TabIndex = 1;
            this.lblNombreCategoria.Text = "Nombre";
            // 
            // txtNombreCategoria
            // 
            this.txtNombreCategoria.Location = new System.Drawing.Point(128, 72);
            this.txtNombreCategoria.Name = "txtNombreCategoria";
            this.txtNombreCategoria.Size = new System.Drawing.Size(121, 20);
            this.txtNombreCategoria.TabIndex = 2;
            // 
            // btnGuardarCategoria
            // 
            this.btnGuardarCategoria.Location = new System.Drawing.Point(283, 67);
            this.btnGuardarCategoria.Name = "btnGuardarCategoria";
            this.btnGuardarCategoria.Size = new System.Drawing.Size(102, 29);
            this.btnGuardarCategoria.TabIndex = 3;
            this.btnGuardarCategoria.Text = "Guardar";
            this.btnGuardarCategoria.UseVisualStyleBackColor = true;
            this.btnGuardarCategoria.Click += new System.EventHandler(this.btnGuardarCategoria_Click);
            // 
            // btnNuevaCategoria
            // 
            this.btnNuevaCategoria.Location = new System.Drawing.Point(61, 251);
            this.btnNuevaCategoria.Name = "btnNuevaCategoria";
            this.btnNuevaCategoria.Size = new System.Drawing.Size(111, 36);
            this.btnNuevaCategoria.TabIndex = 4;
            this.btnNuevaCategoria.Text = "Nueva Categoria";
            this.btnNuevaCategoria.UseVisualStyleBackColor = true;
            this.btnNuevaCategoria.Click += new System.EventHandler(this.btnNuevaCategoria_Click);
            // 
            // dgvCategorias
            // 
            this.dgvCategorias.AllowUserToAddRows = false;
            this.dgvCategorias.AllowUserToDeleteRows = false;
            this.dgvCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategorias.Location = new System.Drawing.Point(220, 19);
            this.dgvCategorias.Name = "dgvCategorias";
            this.dgvCategorias.ReadOnly = true;
            this.dgvCategorias.Size = new System.Drawing.Size(313, 203);
            this.dgvCategorias.TabIndex = 3;
            // 
            // tabMovimientos
            // 
            this.tabMovimientos.Controls.Add(this.grbDatosMovimientoMOV);
            this.tabMovimientos.Controls.Add(this.dgvMovimientosMOV);
            this.tabMovimientos.Controls.Add(this.btnNuevoMovimientoMOV);
            this.tabMovimientos.Location = new System.Drawing.Point(4, 22);
            this.tabMovimientos.Name = "tabMovimientos";
            this.tabMovimientos.Size = new System.Drawing.Size(739, 445);
            this.tabMovimientos.TabIndex = 2;
            this.tabMovimientos.Text = "Movimientos";
            this.tabMovimientos.UseVisualStyleBackColor = true;
            // 
            // grbDatosMovimientoMOV
            // 
            this.grbDatosMovimientoMOV.Controls.Add(this.cmbCuentasDestinoMOV);
            this.grbDatosMovimientoMOV.Controls.Add(this.lblCuentaDestinoMOV);
            this.grbDatosMovimientoMOV.Controls.Add(this.lblDescripcionMOV);
            this.grbDatosMovimientoMOV.Controls.Add(this.txtDescripcionMOV);
            this.grbDatosMovimientoMOV.Controls.Add(this.cmbCategoriasMOV);
            this.grbDatosMovimientoMOV.Controls.Add(this.lblCategoria);
            this.grbDatosMovimientoMOV.Controls.Add(this.cmbCuentasMOV);
            this.grbDatosMovimientoMOV.Controls.Add(this.lblCuentaMOV);
            this.grbDatosMovimientoMOV.Controls.Add(this.cmbTipoMovimientoMOV);
            this.grbDatosMovimientoMOV.Controls.Add(this.lblTipoMovimientoMOV);
            this.grbDatosMovimientoMOV.Controls.Add(this.lblValorMOV);
            this.grbDatosMovimientoMOV.Controls.Add(this.txtValorMOV);
            this.grbDatosMovimientoMOV.Controls.Add(this.btnGuardarMovimientoMOV);
            this.grbDatosMovimientoMOV.Location = new System.Drawing.Point(146, 253);
            this.grbDatosMovimientoMOV.Name = "grbDatosMovimientoMOV";
            this.grbDatosMovimientoMOV.Size = new System.Drawing.Size(559, 178);
            this.grbDatosMovimientoMOV.TabIndex = 8;
            this.grbDatosMovimientoMOV.TabStop = false;
            this.grbDatosMovimientoMOV.Text = "Datos Categoria";
            this.grbDatosMovimientoMOV.Visible = false;
            // 
            // lblDescripcionMOV
            // 
            this.lblDescripcionMOV.AutoSize = true;
            this.lblDescripcionMOV.Location = new System.Drawing.Point(289, 66);
            this.lblDescripcionMOV.Name = "lblDescripcionMOV";
            this.lblDescripcionMOV.Size = new System.Drawing.Size(63, 13);
            this.lblDescripcionMOV.TabIndex = 10;
            this.lblDescripcionMOV.Text = "Descripcion";
            // 
            // txtDescripcionMOV
            // 
            this.txtDescripcionMOV.Location = new System.Drawing.Point(358, 62);
            this.txtDescripcionMOV.Name = "txtDescripcionMOV";
            this.txtDescripcionMOV.Size = new System.Drawing.Size(121, 20);
            this.txtDescripcionMOV.TabIndex = 11;
            // 
            // cmbCategoriasMOV
            // 
            this.cmbCategoriasMOV.FormattingEnabled = true;
            this.cmbCategoriasMOV.Location = new System.Drawing.Point(357, 32);
            this.cmbCategoriasMOV.Name = "cmbCategoriasMOV";
            this.cmbCategoriasMOV.Size = new System.Drawing.Size(121, 21);
            this.cmbCategoriasMOV.TabIndex = 9;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(297, 35);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(52, 13);
            this.lblCategoria.TabIndex = 8;
            this.lblCategoria.Text = "Categoria";
            // 
            // cmbCuentasMOV
            // 
            this.cmbCuentasMOV.FormattingEnabled = true;
            this.cmbCuentasMOV.Location = new System.Drawing.Point(127, 90);
            this.cmbCuentasMOV.Name = "cmbCuentasMOV";
            this.cmbCuentasMOV.Size = new System.Drawing.Size(121, 21);
            this.cmbCuentasMOV.TabIndex = 7;
            // 
            // lblCuentaMOV
            // 
            this.lblCuentaMOV.AutoSize = true;
            this.lblCuentaMOV.Location = new System.Drawing.Point(34, 93);
            this.lblCuentaMOV.Name = "lblCuentaMOV";
            this.lblCuentaMOV.Size = new System.Drawing.Size(68, 13);
            this.lblCuentaMOV.TabIndex = 6;
            this.lblCuentaMOV.Text = "Cuenta Mov.";
            // 
            // cmbTipoMovimientoMOV
            // 
            this.cmbTipoMovimientoMOV.FormattingEnabled = true;
            this.cmbTipoMovimientoMOV.Location = new System.Drawing.Point(128, 29);
            this.cmbTipoMovimientoMOV.Name = "cmbTipoMovimientoMOV";
            this.cmbTipoMovimientoMOV.Size = new System.Drawing.Size(121, 21);
            this.cmbTipoMovimientoMOV.TabIndex = 5;
            this.cmbTipoMovimientoMOV.SelectedIndexChanged += new System.EventHandler(this.cmbTipoMovimientoMOV_SelectedIndexChanged);
            // 
            // lblTipoMovimientoMOV
            // 
            this.lblTipoMovimientoMOV.AutoSize = true;
            this.lblTipoMovimientoMOV.Location = new System.Drawing.Point(20, 32);
            this.lblTipoMovimientoMOV.Name = "lblTipoMovimientoMOV";
            this.lblTipoMovimientoMOV.Size = new System.Drawing.Size(85, 13);
            this.lblTipoMovimientoMOV.TabIndex = 4;
            this.lblTipoMovimientoMOV.Text = "Tipo Movimiento";
            // 
            // lblValorMOV
            // 
            this.lblValorMOV.AutoSize = true;
            this.lblValorMOV.Location = new System.Drawing.Point(73, 65);
            this.lblValorMOV.Name = "lblValorMOV";
            this.lblValorMOV.Size = new System.Drawing.Size(31, 13);
            this.lblValorMOV.TabIndex = 1;
            this.lblValorMOV.Text = "Valor";
            // 
            // txtValorMOV
            // 
            this.txtValorMOV.Location = new System.Drawing.Point(127, 62);
            this.txtValorMOV.Name = "txtValorMOV";
            this.txtValorMOV.Size = new System.Drawing.Size(121, 20);
            this.txtValorMOV.TabIndex = 2;
            // 
            // btnGuardarMovimientoMOV
            // 
            this.btnGuardarMovimientoMOV.Location = new System.Drawing.Point(237, 132);
            this.btnGuardarMovimientoMOV.Name = "btnGuardarMovimientoMOV";
            this.btnGuardarMovimientoMOV.Size = new System.Drawing.Size(102, 29);
            this.btnGuardarMovimientoMOV.TabIndex = 3;
            this.btnGuardarMovimientoMOV.Text = "Guardar";
            this.btnGuardarMovimientoMOV.UseVisualStyleBackColor = true;
            this.btnGuardarMovimientoMOV.Click += new System.EventHandler(this.btnGuardarMovimientoMOV_Click);
            // 
            // dgvMovimientosMOV
            // 
            this.dgvMovimientosMOV.AllowUserToAddRows = false;
            this.dgvMovimientosMOV.AllowUserToDeleteRows = false;
            this.dgvMovimientosMOV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMovimientosMOV.Location = new System.Drawing.Point(29, 21);
            this.dgvMovimientosMOV.Name = "dgvMovimientosMOV";
            this.dgvMovimientosMOV.ReadOnly = true;
            this.dgvMovimientosMOV.Size = new System.Drawing.Size(676, 214);
            this.dgvMovimientosMOV.TabIndex = 6;
            // 
            // btnNuevoMovimientoMOV
            // 
            this.btnNuevoMovimientoMOV.Location = new System.Drawing.Point(29, 253);
            this.btnNuevoMovimientoMOV.Name = "btnNuevoMovimientoMOV";
            this.btnNuevoMovimientoMOV.Size = new System.Drawing.Size(111, 36);
            this.btnNuevoMovimientoMOV.TabIndex = 7;
            this.btnNuevoMovimientoMOV.Text = "Nuevo Movimiento";
            this.btnNuevoMovimientoMOV.UseVisualStyleBackColor = true;
            this.btnNuevoMovimientoMOV.Click += new System.EventHandler(this.btnNuevoMovimientoMOV_Click);
            // 
            // tabReportes
            // 
            this.tabReportes.Controls.Add(this.dgvConsultaMovimientos);
            this.tabReportes.Controls.Add(this.grbConsultaMovimientos);
            this.tabReportes.Location = new System.Drawing.Point(4, 22);
            this.tabReportes.Name = "tabReportes";
            this.tabReportes.Size = new System.Drawing.Size(739, 445);
            this.tabReportes.TabIndex = 3;
            this.tabReportes.Text = "Reporte";
            this.tabReportes.UseVisualStyleBackColor = true;
            // 
            // cmbCuentasDestinoMOV
            // 
            this.cmbCuentasDestinoMOV.FormattingEnabled = true;
            this.cmbCuentasDestinoMOV.Location = new System.Drawing.Point(359, 88);
            this.cmbCuentasDestinoMOV.Name = "cmbCuentasDestinoMOV";
            this.cmbCuentasDestinoMOV.Size = new System.Drawing.Size(121, 21);
            this.cmbCuentasDestinoMOV.TabIndex = 13;
            this.cmbCuentasDestinoMOV.Visible = false;
            // 
            // lblCuentaDestinoMOV
            // 
            this.lblCuentaDestinoMOV.AutoSize = true;
            this.lblCuentaDestinoMOV.Location = new System.Drawing.Point(273, 93);
            this.lblCuentaDestinoMOV.Name = "lblCuentaDestinoMOV";
            this.lblCuentaDestinoMOV.Size = new System.Drawing.Size(80, 13);
            this.lblCuentaDestinoMOV.TabIndex = 12;
            this.lblCuentaDestinoMOV.Text = "Cuenta Destino";
            this.lblCuentaDestinoMOV.Visible = false;
            // 
            // grbConsultaMovimientos
            // 
            this.grbConsultaMovimientos.Controls.Add(this.dtpFechaFinConsulta);
            this.grbConsultaMovimientos.Controls.Add(this.lblFechaFinalConsulta);
            this.grbConsultaMovimientos.Controls.Add(this.dtpFechaInicioConsulta);
            this.grbConsultaMovimientos.Controls.Add(this.lblFechaInicioConsulta);
            this.grbConsultaMovimientos.Controls.Add(this.cmbCategoriasConsulta);
            this.grbConsultaMovimientos.Controls.Add(this.lblCategoriaConsulta);
            this.grbConsultaMovimientos.Controls.Add(this.cmbCuentasConsulta);
            this.grbConsultaMovimientos.Controls.Add(this.lblCuentaConsulta);
            this.grbConsultaMovimientos.Controls.Add(this.cmbTiposMovimientoConsulta);
            this.grbConsultaMovimientos.Controls.Add(this.lblTiposMovimientoConsulta);
            this.grbConsultaMovimientos.Controls.Add(this.btnConsulta);
            this.grbConsultaMovimientos.Location = new System.Drawing.Point(3, 3);
            this.grbConsultaMovimientos.Name = "grbConsultaMovimientos";
            this.grbConsultaMovimientos.Size = new System.Drawing.Size(733, 145);
            this.grbConsultaMovimientos.TabIndex = 9;
            this.grbConsultaMovimientos.TabStop = false;
            this.grbConsultaMovimientos.Text = "Consulta Movimientos";
            // 
            // cmbCategoriasConsulta
            // 
            this.cmbCategoriasConsulta.FormattingEnabled = true;
            this.cmbCategoriasConsulta.Location = new System.Drawing.Point(335, 30);
            this.cmbCategoriasConsulta.Name = "cmbCategoriasConsulta";
            this.cmbCategoriasConsulta.Size = new System.Drawing.Size(121, 21);
            this.cmbCategoriasConsulta.TabIndex = 9;
            // 
            // lblCategoriaConsulta
            // 
            this.lblCategoriaConsulta.AutoSize = true;
            this.lblCategoriaConsulta.Location = new System.Drawing.Point(275, 33);
            this.lblCategoriaConsulta.Name = "lblCategoriaConsulta";
            this.lblCategoriaConsulta.Size = new System.Drawing.Size(52, 13);
            this.lblCategoriaConsulta.TabIndex = 8;
            this.lblCategoriaConsulta.Text = "Categoria";
            // 
            // cmbCuentasConsulta
            // 
            this.cmbCuentasConsulta.FormattingEnabled = true;
            this.cmbCuentasConsulta.Location = new System.Drawing.Point(591, 32);
            this.cmbCuentasConsulta.Name = "cmbCuentasConsulta";
            this.cmbCuentasConsulta.Size = new System.Drawing.Size(121, 21);
            this.cmbCuentasConsulta.TabIndex = 7;
            // 
            // lblCuentaConsulta
            // 
            this.lblCuentaConsulta.AutoSize = true;
            this.lblCuentaConsulta.Location = new System.Drawing.Point(498, 35);
            this.lblCuentaConsulta.Name = "lblCuentaConsulta";
            this.lblCuentaConsulta.Size = new System.Drawing.Size(68, 13);
            this.lblCuentaConsulta.TabIndex = 6;
            this.lblCuentaConsulta.Text = "Cuenta Mov.";
            // 
            // cmbTiposMovimientoConsulta
            // 
            this.cmbTiposMovimientoConsulta.FormattingEnabled = true;
            this.cmbTiposMovimientoConsulta.Location = new System.Drawing.Point(128, 29);
            this.cmbTiposMovimientoConsulta.Name = "cmbTiposMovimientoConsulta";
            this.cmbTiposMovimientoConsulta.Size = new System.Drawing.Size(121, 21);
            this.cmbTiposMovimientoConsulta.TabIndex = 5;
            this.cmbTiposMovimientoConsulta.SelectedIndexChanged += new System.EventHandler(this.cmbTiposMovimientoConsulta_SelectedIndexChanged);
            // 
            // lblTiposMovimientoConsulta
            // 
            this.lblTiposMovimientoConsulta.AutoSize = true;
            this.lblTiposMovimientoConsulta.Location = new System.Drawing.Point(20, 32);
            this.lblTiposMovimientoConsulta.Name = "lblTiposMovimientoConsulta";
            this.lblTiposMovimientoConsulta.Size = new System.Drawing.Size(85, 13);
            this.lblTiposMovimientoConsulta.TabIndex = 4;
            this.lblTiposMovimientoConsulta.Text = "Tipo Movimiento";
            // 
            // btnConsulta
            // 
            this.btnConsulta.Location = new System.Drawing.Point(309, 102);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(102, 29);
            this.btnConsulta.TabIndex = 3;
            this.btnConsulta.Text = "Consultar";
            this.btnConsulta.UseVisualStyleBackColor = true;
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click);
            // 
            // dgvConsultaMovimientos
            // 
            this.dgvConsultaMovimientos.AllowUserToAddRows = false;
            this.dgvConsultaMovimientos.AllowUserToDeleteRows = false;
            this.dgvConsultaMovimientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultaMovimientos.Location = new System.Drawing.Point(26, 171);
            this.dgvConsultaMovimientos.Name = "dgvConsultaMovimientos";
            this.dgvConsultaMovimientos.ReadOnly = true;
            this.dgvConsultaMovimientos.Size = new System.Drawing.Size(676, 214);
            this.dgvConsultaMovimientos.TabIndex = 7;
            // 
            // lblFechaInicioConsulta
            // 
            this.lblFechaInicioConsulta.AutoSize = true;
            this.lblFechaInicioConsulta.Location = new System.Drawing.Point(67, 67);
            this.lblFechaInicioConsulta.Name = "lblFechaInicioConsulta";
            this.lblFechaInicioConsulta.Size = new System.Drawing.Size(38, 13);
            this.lblFechaInicioConsulta.TabIndex = 10;
            this.lblFechaInicioConsulta.Text = "Desde";
            // 
            // dtpFechaInicioConsulta
            // 
            this.dtpFechaInicioConsulta.Location = new System.Drawing.Point(128, 65);
            this.dtpFechaInicioConsulta.Name = "dtpFechaInicioConsulta";
            this.dtpFechaInicioConsulta.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaInicioConsulta.TabIndex = 11;
            // 
            // dtpFechaFinConsulta
            // 
            this.dtpFechaFinConsulta.Location = new System.Drawing.Point(428, 65);
            this.dtpFechaFinConsulta.Name = "dtpFechaFinConsulta";
            this.dtpFechaFinConsulta.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaFinConsulta.TabIndex = 13;
            // 
            // lblFechaFinalConsulta
            // 
            this.lblFechaFinalConsulta.AutoSize = true;
            this.lblFechaFinalConsulta.Location = new System.Drawing.Point(376, 67);
            this.lblFechaFinalConsulta.Name = "lblFechaFinalConsulta";
            this.lblFechaFinalConsulta.Size = new System.Drawing.Size(35, 13);
            this.lblFechaFinalConsulta.TabIndex = 12;
            this.lblFechaFinalConsulta.Text = "Hasta";
            // 
            // VistaWallet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 495);
            this.Controls.Add(this.tabHome);
            this.Name = "VistaWallet";
            this.Text = "Wallet";
            this.Load += new System.EventHandler(this.VistaWallet_Load);
            this.tabHome.ResumeLayout(false);
            this.tabCuentas.ResumeLayout(false);
            this.grbNuevaCuenta.ResumeLayout(false);
            this.grbNuevaCuenta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCuentas)).EndInit();
            this.tabCategorias.ResumeLayout(false);
            this.grbCategoria.ResumeLayout(false);
            this.grbCategoria.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorias)).EndInit();
            this.tabMovimientos.ResumeLayout(false);
            this.grbDatosMovimientoMOV.ResumeLayout(false);
            this.grbDatosMovimientoMOV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovimientosMOV)).EndInit();
            this.tabReportes.ResumeLayout(false);
            this.grbConsultaMovimientos.ResumeLayout(false);
            this.grbConsultaMovimientos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaMovimientos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabHome;
        private System.Windows.Forms.TabPage tabCuentas;
        private System.Windows.Forms.Button btnAgregarCuenta;
        private System.Windows.Forms.DataGridView dgvCuentas;
        private System.Windows.Forms.TabPage tabCategorias;
        private System.Windows.Forms.TabPage tabMovimientos;
        private System.Windows.Forms.TabPage tabReportes;
        private System.Windows.Forms.GroupBox grbNuevaCuenta;
        private System.Windows.Forms.Label lblNombreCuenta;
        private System.Windows.Forms.TextBox txtNombreCuenta;
        private System.Windows.Forms.Button btnGuardarCuenta;
        private System.Windows.Forms.GroupBox grbCategoria;
        private System.Windows.Forms.ComboBox cmbTiposMovimiento;
        private System.Windows.Forms.Label lblTipoMovimiento;
        private System.Windows.Forms.Label lblNombreCategoria;
        private System.Windows.Forms.TextBox txtNombreCategoria;
        private System.Windows.Forms.Button btnGuardarCategoria;
        private System.Windows.Forms.Button btnNuevaCategoria;
        private System.Windows.Forms.DataGridView dgvCategorias;
        private System.Windows.Forms.GroupBox grbDatosMovimientoMOV;
        private System.Windows.Forms.Label lblDescripcionMOV;
        private System.Windows.Forms.TextBox txtDescripcionMOV;
        private System.Windows.Forms.ComboBox cmbCategoriasMOV;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.ComboBox cmbCuentasMOV;
        private System.Windows.Forms.Label lblCuentaMOV;
        private System.Windows.Forms.ComboBox cmbTipoMovimientoMOV;
        private System.Windows.Forms.Label lblTipoMovimientoMOV;
        private System.Windows.Forms.Label lblValorMOV;
        private System.Windows.Forms.TextBox txtValorMOV;
        private System.Windows.Forms.Button btnGuardarMovimientoMOV;
        private System.Windows.Forms.DataGridView dgvMovimientosMOV;
        private System.Windows.Forms.Button btnNuevoMovimientoMOV;
        private System.Windows.Forms.ComboBox cmbCuentasDestinoMOV;
        private System.Windows.Forms.Label lblCuentaDestinoMOV;
        private System.Windows.Forms.DataGridView dgvConsultaMovimientos;
        private System.Windows.Forms.GroupBox grbConsultaMovimientos;
        private System.Windows.Forms.DateTimePicker dtpFechaFinConsulta;
        private System.Windows.Forms.Label lblFechaFinalConsulta;
        private System.Windows.Forms.DateTimePicker dtpFechaInicioConsulta;
        private System.Windows.Forms.Label lblFechaInicioConsulta;
        private System.Windows.Forms.ComboBox cmbCategoriasConsulta;
        private System.Windows.Forms.Label lblCategoriaConsulta;
        private System.Windows.Forms.ComboBox cmbCuentasConsulta;
        private System.Windows.Forms.Label lblCuentaConsulta;
        private System.Windows.Forms.ComboBox cmbTiposMovimientoConsulta;
        private System.Windows.Forms.Label lblTiposMovimientoConsulta;
        private System.Windows.Forms.Button btnConsulta;
    }
}