using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WalletDatos;
using WalletEntidades;

namespace WalletLogica
{
    public class GestionCuenta
    {
        private GestionCuentaDB gestioncuentaDB;

        private GestionCuentaDB getGestionCuentaDB()
        {
            if (gestioncuentaDB == null)
            {
                gestioncuentaDB = new GestionCuentaDB();
            }
            return gestioncuentaDB;
        }

        public void GuardarCuenta(Cuenta cuenta)
        {
            getGestionCuentaDB().GuardarCuentaDB(cuenta);
        }

        public List<Cuenta> GetCuentas ()
        {
            List<Cuenta> listaCuentas = getGestionCuentaDB().GetCuentasDB();
            return listaCuentas;
        }

        public decimal GetSaldoCuenta(int intCuentaId)
        {
            return getGestionCuentaDB().GetSaldoCuentaDB(intCuentaId);
        }
    }
}
