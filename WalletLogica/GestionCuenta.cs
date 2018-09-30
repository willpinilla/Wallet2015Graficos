using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WalletDatos;

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
            WalletDatos.Cuenta CuentaDB = new WalletDatos.Cuenta()
            {
                Id = cuenta.Id,
                Nombre = cuenta.Nombre,
                FechaCreacion = cuenta.FechaCreacion
            };
            getGestionCuentaDB().GuardarCuentaDB(CuentaDB);
        }

        public List<Cuenta> GetCuentas ()
        {
            List<WalletDatos.Cuenta> listaCuentasDB = getGestionCuentaDB().GetCuentasDB();
            List<Cuenta> listaCuentas = new List<Cuenta>();
            foreach (var item in listaCuentasDB)
            {
                Cuenta ct = new Cuenta()
                {
                    Id = item.Id,
                    Nombre = item.Nombre,
                    FechaCreacion = item.FechaCreacion
                };
                listaCuentas.Add(ct);
            }

            return listaCuentas;
        }

        public decimal GetSaldoCuenta(int intCuentaId)
        {
            return getGestionCuentaDB().GetSaldoCuentaDB(intCuentaId);
        }
    }
}
