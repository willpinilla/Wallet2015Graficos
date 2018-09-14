using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WalletPresentacion.Controlador;

namespace WalletPresentacion.Vista
{
    public partial class VistaWallet : Form
    {
        private CuentaControlador cuentacontrolador;
        private CategoriaControlador categoriacontrolador;
        private TipoMovimientoControlador tipomovimientocontrolador;
        private MovimientoControlador movimientocontrolador;
        private ReporteControlador reportecontrolador;

        #region General

        public VistaWallet()
        {
            InitializeComponent();
        }

        private void VistaWallet_Load(object sender, EventArgs e)
        {
            DataSet dsCuentas = getCuentaControlador().GetCuentas();
            dgvCuentas.DataSource = dsCuentas.Tables[0];
            dgvCuentas.Rows.Remove(dgvCuentas.Rows[0]);
        }

        private void tabHome_SelectedIndexChanged(object sender, EventArgs e)
        {
            TabPage current = (sender as TabControl).SelectedTab;
            if (current.Name == "tabCuentas")
            {
                DataSet dsCuentas = getCuentaControlador().GetCuentas();
                dgvCuentas.DataSource = dsCuentas.Tables[0];
                dgvCuentas.Rows.RemoveAt(0);
            }
            if (current.Name == "tabCategorias")
            {
                DataSet dsCategorias = getCategoriaControlador().GetCategorias();
                dgvCategorias.DataSource = dsCategorias.Tables[0];
            }
            if (current.Name == "tabMovimientos")
            {
                DataSet dsMovimientos = getMovimientoControlador().GetMovimientos();
                dgvMovimientosMOV.DataSource = dsMovimientos.Tables[0];
            }
            if (current.Name == "tabReportes")
            {
                //Tipos Movimiento
                DataSet dsTiposMovimiento = getTipoMovimientoControlador().GetTiposMovimiento();
                cmbTiposMovimientoConsulta.DisplayMember = "Nombre";
                cmbTiposMovimientoConsulta.ValueMember = "Id";
                cmbTiposMovimientoConsulta.DataSource = dsTiposMovimiento.Tables[0];

                //Cuentas
                DataSet dsCuentas = getCuentaControlador().GetCuentasMovimiento();
                cmbCuentasConsulta.DisplayMember = "Nombre";
                cmbCuentasConsulta.ValueMember = "Id";
                cmbCuentasConsulta.DataSource = dsCuentas.Tables[0];

                //Categorias
                //cmbCategoriasConsulta.Items.Insert(0,"Seleccione...");
                //cmbCategoriasConsulta.SelectedItem = "Seleccione...";
            }
        }
        
        #endregion

        #region Cuentas
        public CuentaControlador getCuentaControlador()
        {
            if (cuentacontrolador == null)
            {
                cuentacontrolador = new CuentaControlador(this);
            }
            return cuentacontrolador;
        }
        public TextBox getNombreCuenta()
        {
            return txtNombreCuenta;
        }

        private void btnAgregarCuenta_Click(object sender, EventArgs e)
        {
            grbNuevaCuenta.Visible = true;
        }

        private void btnGuardarCuenta_Click(object sender, EventArgs e)
        {
            //getmodelo.GuardarCuenta()sender;
            getCuentaControlador().GuardarCuenta();
            grbNuevaCuenta.Visible = false;

            DataSet dsCuentas = getCuentaControlador().GetCuentas();
            dgvCuentas.DataSource = dsCuentas.Tables[0];
        }

        #endregion
        #region TipoMovimiento
        public TipoMovimientoControlador getTipoMovimientoControlador()
        {
            if (tipomovimientocontrolador == null)
            {
                tipomovimientocontrolador = new TipoMovimientoControlador(this);
            }
            return tipomovimientocontrolador;
        }

        public ComboBox getTipoMovimientoCategoria()
        {
            return cmbTiposMovimiento;
        }

        public TextBox getNombreCategoria()
        {
            return txtNombreCategoria;
        }
        #endregion

        #region Categorias
        public CategoriaControlador getCategoriaControlador()
        {
            if (categoriacontrolador == null)
            {
                categoriacontrolador = new CategoriaControlador(this);
            }
            return categoriacontrolador;
        }
        private void btnNuevaCategoria_Click(object sender, EventArgs e)
        {
            grbCategoria.Visible = true;
            DataSet dsTiposMovimiento = getTipoMovimientoControlador().GetTiposMovimiento();
            cmbTiposMovimiento.DisplayMember = "Nombre";
            cmbTiposMovimiento.ValueMember = "Id";
            cmbTiposMovimiento.DataSource = dsTiposMovimiento.Tables[0];
        }
        
        private void btnGuardarCategoria_Click(object sender, EventArgs e)
        {
            getCategoriaControlador().GuardarCategoria();
            grbCategoria.Visible = false;

            DataSet dsCategorias = getCategoriaControlador().GetCategorias();
            dgvCategorias.DataSource = dsCategorias.Tables[0];
        }

        #endregion

        #region Movimientos
        public MovimientoControlador getMovimientoControlador()
        {
            if (movimientocontrolador == null)
            {
                movimientocontrolador = new MovimientoControlador(this);
            }
            return movimientocontrolador;
        }
        public TextBox getValorMovimiento()
        {
            return txtValorMOV;
        }

        public TextBox getDescripcionMovimiento()
        {
            return txtDescripcionMOV;
        }

        public ComboBox getCategoriaMovimiento()
        {
            return cmbCategoriasMOV;
        }

        public ComboBox getCuentaMovimiento()
        {
            return cmbCuentasMOV;
        }
        public ComboBox getCuentaDestinoMovimiento()
        {
            return cmbCuentasDestinoMOV;
        }

        public ComboBox getTipoMovimientoMovimiento()
        {
            return cmbTipoMovimientoMOV;
        }

        private void btnNuevoMovimientoMOV_Click(object sender, EventArgs e)
        {
            grbDatosMovimientoMOV.Visible = true;
            
            //Tipos Movimiento
            DataSet dsTiposMovimiento = getTipoMovimientoControlador().GetTiposMovimiento();
            cmbTipoMovimientoMOV.DisplayMember = "Nombre";
            cmbTipoMovimientoMOV.ValueMember = "Id";
            cmbTipoMovimientoMOV.DataSource = dsTiposMovimiento.Tables[0];

            //Cuentas
            DataSet dsCuentas = getCuentaControlador().GetCuentasMovimiento();
            cmbCuentasMOV.DisplayMember = "Nombre";
            cmbCuentasMOV.ValueMember = "Id";
            cmbCuentasMOV.DataSource = dsCuentas.Tables[0];

            //Categorias
            DataSet dsCategorias = getCategoriaControlador().GetCategoriasTipoMovimiento();
            cmbCategoriasMOV.DisplayMember = "Nombre";
            cmbCategoriasMOV.ValueMember = "Id";
            cmbCategoriasMOV.DataSource = dsCategorias.Tables[0];
        }

        private void cmbTipoMovimientoMOV_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Categorias
            DataSet dsCategorias = getCategoriaControlador().GetCategoriasTipoMovimiento();
            cmbCategoriasMOV.DisplayMember = "Nombre";
            cmbCategoriasMOV.ValueMember = "Id";
            cmbCategoriasMOV.DataSource = dsCategorias.Tables[0];

            int intTipoMovimientoId = Convert.ToInt32(cmbTipoMovimientoMOV.SelectedValue);
            if (intTipoMovimientoId == 3) //Traslado
            {
                //Cuentas Destino
                DataSet dsCuentas = getCuentaControlador().GetCuentasMovimiento();
                cmbCuentasDestinoMOV.DisplayMember = "Nombre";
                cmbCuentasDestinoMOV.ValueMember = "Id";
                cmbCuentasDestinoMOV.DataSource = dsCuentas.Tables[0];

                lblCuentaDestinoMOV.Visible = true;
                cmbCuentasDestinoMOV.Visible = true;

                lblCuentaMOV.Text = "Cuenta Origen";
            }
            else
            {
                lblCuentaDestinoMOV.Visible = false;
                cmbCuentasDestinoMOV.Visible = false;
                lblCuentaMOV.Text = "Cuenta Mov.";
            }
            
        }

        private void btnGuardarMovimientoMOV_Click(object sender, EventArgs e)
        {
            bool bMovimientoGuardado = getMovimientoControlador().GuardarMovimiento();

            if (bMovimientoGuardado)
            {
                grbDatosMovimientoMOV.Visible = false;

                DataSet dsMovientos = getMovimientoControlador().GetMovimientos();
                dgvMovimientosMOV.DataSource = dsMovientos.Tables[0];
            }
            else
            {
                MessageBox.Show("No se pudo guardar el movimiento. Revise Saldo Cuenta");
            }
        }

        #endregion

        #region Reporte
        public ReporteControlador getReporteControlador()
        {
            if (reportecontrolador == null)
            {
                reportecontrolador = new ReporteControlador(this);
            }
            return reportecontrolador;
        }
        public DateTimePicker getFechaFinConsulta()
        {
            return dtpFechaFinConsulta;
        }

        public DateTimePicker getFechaInicioConsulta()
        {
            return dtpFechaInicioConsulta;
        }

        public ComboBox getCategoriaConsulta()
        {
            return cmbCategoriasConsulta;
        }

        public ComboBox getCuentaConsulta()
        {
            return cmbCuentasConsulta;
        }

        public ComboBox getTipoMovimientoConsulta()
        {
            return cmbTiposMovimientoConsulta;
        }

        private void cmbTiposMovimientoConsulta_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Categorias
            DataSet dsCategorias = getReporteControlador().GetCategoriasConsulta();
            cmbCategoriasConsulta.DisplayMember = "Nombre";
            cmbCategoriasConsulta.ValueMember = "Id";
            cmbCategoriasConsulta.DataSource = dsCategorias.Tables[0];
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            DataSet dsReporteResultados = getReporteControlador().GetReporte();
            dgvConsultaMovimientos.DataSource = dsReporteResultados.Tables[0];
        }

        #endregion

        
    }
}
