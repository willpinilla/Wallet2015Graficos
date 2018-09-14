using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WalletPresentacion.Vista;
using WalletLogica;
using WalletEntidades;
using System.Data;
using WalletPresentacion.Util;

namespace WalletPresentacion.Controlador
{
    public class MovimientoControlador
    {
        private VistaWallet ventana;
        private GestionMovimiento gestionmovimiento;
        private GestionCuenta gestioncuenta;
        private Movimiento movimiento;

        public MovimientoControlador(VistaWallet vistawallet)
        {
            if (ventana == null)
            {
                ventana = vistawallet;
            }
        }

        private GestionMovimiento getGestionMovimiento()
        {
            if (gestionmovimiento == null)
            {
                gestionmovimiento = new GestionMovimiento();
            }
            return gestionmovimiento;
        }

        private GestionCuenta getGestionCuenta()
        {
            if (gestioncuenta == null)
            {
                gestioncuenta = new GestionCuenta();
            }
            return gestioncuenta;
        }

        public DataSet GetMovimientos()
        {
            List<Movimiento> listaMovimientos = getGestionMovimiento().GetMovimientos();
            DataSet dsMovimientos = Conversiones.ConvertToDataSetMovimientos(listaMovimientos, false);
            return dsMovimientos;
        }

        public bool GuardarMovimiento()
        {
            int intTipoMovimientoId = Convert.ToInt32(ventana.getTipoMovimientoMovimiento().SelectedValue);
            int intCuentaId = Convert.ToInt32(ventana.getCuentaMovimiento().SelectedValue);
            int intCategoriaId = Convert.ToInt32(ventana.getCategoriaMovimiento().SelectedValue);
            decimal decValorMovimiento = Convert.ToDecimal(ventana.getValorMovimiento().Text);
            string strDescripcionMovimiento = ventana.getDescripcionMovimiento().Text;
            int intCuentaDestinoId = 0;
            bool bMovimientoGuardado = false;
             
            //traslado
            if (intTipoMovimientoId == 3)
            {
                //Validar que la Cuenta tenga Saldo suficiente
                decimal decSaldoCuenta = getGestionCuenta().GetSaldoCuenta(intCuentaId);
                if (decSaldoCuenta - decValorMovimiento >= 0)
                {
                    //Movimiento Egreso
                    movimiento = new Movimiento()
                    {
                        Descripcion = strDescripcionMovimiento,
                        Valor = decValorMovimiento * -1,
                        TipoMovimientoId = intTipoMovimientoId,
                        CuentaId = intCuentaId,
                        CategoriaId = intCategoriaId
                    };
                    getGestionMovimiento().GuardarMovimiento(movimiento);

                    //Movimiento Ingreso
                    intCuentaDestinoId = Convert.ToInt32(ventana.getCuentaDestinoMovimiento().SelectedValue);
                    movimiento = new Movimiento()
                    {
                        Descripcion = strDescripcionMovimiento,
                        Valor = decValorMovimiento,
                        TipoMovimientoId = intTipoMovimientoId,
                        CuentaId = intCuentaDestinoId,
                        CategoriaId = intCategoriaId
                    };
                    getGestionMovimiento().GuardarMovimiento(movimiento);
                    bMovimientoGuardado = true;
                }
            }
            else if (intTipoMovimientoId == 2)//Egreso
            {
                //Validar Saldo Cuenta
                decimal decSaldoCuenta = getGestionCuenta().GetSaldoCuenta(intCuentaId);
                if (decSaldoCuenta - decValorMovimiento >= 0)
                {
                    movimiento = new Movimiento()
                    {
                        Descripcion = strDescripcionMovimiento,
                        Valor = decValorMovimiento * -1,
                        TipoMovimientoId = intTipoMovimientoId,
                        CuentaId = intCuentaId,
                        CategoriaId = intCategoriaId
                    };
                    getGestionMovimiento().GuardarMovimiento(movimiento);
                    bMovimientoGuardado = true;
                }
            }
            else if (intTipoMovimientoId == 1) //Ingreso 
            {
                movimiento = new Movimiento()
                {
                    Descripcion = strDescripcionMovimiento,
                    Valor = decValorMovimiento,
                    TipoMovimientoId = intTipoMovimientoId,
                    CuentaId = intCuentaId,
                    CategoriaId = intCategoriaId
                };
                getGestionMovimiento().GuardarMovimiento(movimiento);
                bMovimientoGuardado = true;
            }
            return bMovimientoGuardado;
        }
    }
}
