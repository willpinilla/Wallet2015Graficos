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
    public class CuentaControlador
    {
        private VistaWallet ventana;
        private GestionCuenta gestioncuenta;
        private Cuenta cuenta;

        public CuentaControlador(VistaWallet vistawallet)
        {
            if (ventana == null)
            {
                ventana = vistawallet;
            }
        }

        private GestionCuenta getGestionCuenta()
        {
            if (gestioncuenta == null)
            {
                gestioncuenta = new GestionCuenta();
            }
            return gestioncuenta;
        }

        public void GuardarCuenta()
        {
            string strNombreCuenta = ventana.getNombreCuenta().Text;
            cuenta = new Cuenta() { Nombre = strNombreCuenta };
            getGestionCuenta().GuardarCuenta(cuenta);
        }

        public DataSet GetCuentas()
        {
            List<Cuenta> listaCuentas = getGestionCuenta().GetCuentas();
            DataSet dsCuentas = Conversiones.ConvertToDataSetCuentas(listaCuentas, false);
            return dsCuentas;
        }

        public DataSet GetCuentasMovimiento()
        {
            List<Cuenta> listaCuentas = getGestionCuenta().GetCuentas();
            DataSet dsCuentas = Conversiones.ConvertToDataSetCuentas(listaCuentas, true);
            return dsCuentas;
        }
    }
}
