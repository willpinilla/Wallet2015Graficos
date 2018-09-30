using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WalletPresentacion.Vista
{
    public partial class VistaWallet : Form
    {
        private Modelo modelo;

        #region General

        public VistaWallet()
        {
            InitializeComponent();
        }

        public Modelo getModelo()
        {
            if (modelo == null)
            {
                modelo = new Modelo(this);
            }
            return modelo;
        }

        private void VistaWallet_Load(object sender, EventArgs e)
        {
            DataSet dsCuentas = getModelo().GetCuentas();
            dgvCuentas.DataSource = dsCuentas.Tables[0];
            dgvCuentas.Rows.Remove(dgvCuentas.Rows[0]);
        }

        private void tabHome_SelectedIndexChanged(object sender, EventArgs e)
        {
            TabPage current = (sender as TabControl).SelectedTab;
            if (current.Name == "tabCuentas")
            {
                DataSet dsCuentas = getModelo().GetCuentas();
                dgvCuentas.DataSource = dsCuentas.Tables[0];
                dgvCuentas.Rows.RemoveAt(0);
            }
            if (current.Name == "tabCategorias")
            {
                DataSet dsCategorias = getModelo().GetCategorias();
                dgvCategorias.DataSource = dsCategorias.Tables[0];
            }
            if (current.Name == "tabMovimientos")
            {
                DataSet dsMovimientos = getModelo().GetMovimientos();
                dgvMovimientosMOV.DataSource = dsMovimientos.Tables[0];
            }
            if (current.Name == "tabReportes")
            {
                //Tipos Movimiento
                DataSet dsTiposMovimiento = getModelo().GetTiposMovimiento();
                cmbTiposMovimientoConsulta.DisplayMember = "Nombre";
                cmbTiposMovimientoConsulta.ValueMember = "Id";
                cmbTiposMovimientoConsulta.DataSource = dsTiposMovimiento.Tables[0];

                //Cuentas
                DataSet dsCuentas = getModelo().GetCuentasMovimiento();
                cmbCuentasConsulta.DisplayMember = "Nombre";
                cmbCuentasConsulta.ValueMember = "Id";
                cmbCuentasConsulta.DataSource = dsCuentas.Tables[0];

            }
            if (current.Name == "tabGraficoIngresosGastos")
            {
                grbBusquedaIngresosGastos.Visible = true;
            }
            if (current.Name == "tabGraficoGastos")
            {
                grbBusquedaGastos.Visible = true;
            }
        }

        #endregion

        #region Cuentas

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
            getModelo().GuardarCuenta();
            grbNuevaCuenta.Visible = false;

            DataSet dsCuentas = getModelo().GetCuentas();
            dgvCuentas.DataSource = dsCuentas.Tables[0];
        }

        #endregion
        #region TipoMovimiento
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
        private void btnNuevaCategoria_Click(object sender, EventArgs e)
        {
            grbCategoria.Visible = true;
            DataSet dsTiposMovimiento = getModelo().GetTiposMovimiento();
            cmbTiposMovimiento.DisplayMember = "Nombre";
            cmbTiposMovimiento.ValueMember = "Id";
            cmbTiposMovimiento.DataSource = dsTiposMovimiento.Tables[0];
        }

        private void btnGuardarCategoria_Click(object sender, EventArgs e)
        {
            getModelo().GuardarCategoria();
            grbCategoria.Visible = false;

            DataSet dsCategorias = getModelo().GetCategorias();
            dgvCategorias.DataSource = dsCategorias.Tables[0];
        }

        #endregion

        #region Movimientos
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
            DataSet dsTiposMovimiento = getModelo().GetTiposMovimiento();
            cmbTipoMovimientoMOV.DisplayMember = "Nombre";
            cmbTipoMovimientoMOV.ValueMember = "Id";
            cmbTipoMovimientoMOV.DataSource = dsTiposMovimiento.Tables[0];

            //Cuentas
            DataSet dsCuentas = getModelo().GetCuentasMovimiento();
            cmbCuentasMOV.DisplayMember = "Nombre";
            cmbCuentasMOV.ValueMember = "Id";
            cmbCuentasMOV.DataSource = dsCuentas.Tables[0];

            //Categorias
            DataSet dsCategorias = getModelo().GetCategoriasTipoMovimiento();
            cmbCategoriasMOV.DisplayMember = "Nombre";
            cmbCategoriasMOV.ValueMember = "Id";
            cmbCategoriasMOV.DataSource = dsCategorias.Tables[0];
        }

        private void cmbTipoMovimientoMOV_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Categorias
            DataSet dsCategorias = getModelo().GetCategoriasTipoMovimiento();
            cmbCategoriasMOV.DisplayMember = "Nombre";
            cmbCategoriasMOV.ValueMember = "Id";
            cmbCategoriasMOV.DataSource = dsCategorias.Tables[0];

            int intTipoMovimientoId = Convert.ToInt32(cmbTipoMovimientoMOV.SelectedValue);
            if (intTipoMovimientoId == 3) //Traslado
            {
                //Cuentas Destino
                DataSet dsCuentas = getModelo().GetCuentasMovimiento();
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
            bool bMovimientoGuardado = getModelo().GuardarMovimiento();

            if (bMovimientoGuardado)
            {
                grbDatosMovimientoMOV.Visible = false;

                DataSet dsMovientos = getModelo().GetMovimientos();
                dgvMovimientosMOV.DataSource = dsMovientos.Tables[0];
            }
            else
            {
                MessageBox.Show("No se pudo guardar el movimiento. Revise Saldo Cuenta");
            }
        }

        #endregion

        #region Reporte
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
            DataSet dsCategorias = getModelo().GetCategoriasConsulta();
            cmbCategoriasConsulta.DisplayMember = "Nombre";
            cmbCategoriasConsulta.ValueMember = "Id";
            cmbCategoriasConsulta.DataSource = dsCategorias.Tables[0];
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            DataSet dsReporteResultados = getModelo().GetReporte();
            dgvConsultaMovimientos.DataSource = dsReporteResultados.Tables[0];
        }

        #endregion

        #region GraficoIngresosGastos
        public TabPage getTabPage()
        {
            return tabHome.SelectedTab;
        }

        public ComboBox getAnoConsultaIngresosGastos()
        {
            return cmbAnoIngresosGastos;
        }

        public ComboBox getMesConsultaIngresosGastos()
        {
            return cmbMesIngresosGastos;

        }
        private void btnDibujarIngresosGastos_Click(object sender, EventArgs e)
        {
            getModelo().DibujarIngresosGastos();
        }


        #endregion

        #region GraficoGastos
        public ComboBox getAnoConsultaGastos()
        {
            return cmbAnoConsultaGastos;
        }

        public ComboBox getMesConsultaGastos()
        {
            return cmbMesConsultaGastos;

        }
        private void btnDibujarGastos_Click(object sender, EventArgs e)
        {
            getModelo().DibujarGastos();
        }
        #endregion
    }
}
