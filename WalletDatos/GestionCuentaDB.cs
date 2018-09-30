using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System.Data.Common;
using System.Data;

namespace WalletDatos
{
    public class GestionCuentaDB
    {
        //string constr = Properties.Settings.Default.WalletConnectionString;

        public void GuardarCuentaDB(Cuenta cuenta)
        {
            DatabaseProviderFactory factory = new DatabaseProviderFactory();
            Database db = factory.Create("WalletConnectionString");
            DbCommand dbc = db.GetStoredProcCommand("dbo.paCrearCuenta");
            db.AddInParameter(dbc, "@NombreCuenta", DbType.String, cuenta.Nombre);
            db.ExecuteNonQuery(dbc);
        }

        public List<Cuenta> GetCuentasDB()
        {
            DatabaseProviderFactory factory = new DatabaseProviderFactory();
            Database db = factory.Create("WalletConnectionString");
            DbCommand dbc = db.GetStoredProcCommand("dbo.paGetCuentas");
            DataSet dsCuentas = db.ExecuteDataSet(dbc);
            List<Cuenta> listaCuentas = ConvertToList(dsCuentas);
            return listaCuentas;
        }

        public decimal GetSaldoCuentaDB(int intCuentaId)
        {
            DatabaseProviderFactory factory = new DatabaseProviderFactory();
            Database db = factory.Create("WalletConnectionString");
            DbCommand dbc = db.GetStoredProcCommand("dbo.paGetSaldoCuenta");
            db.AddInParameter(dbc, "@CuentaId", DbType.Int32, intCuentaId);
            decimal decSaldoCuenta = Convert.ToDecimal(db.ExecuteScalar(dbc));
            return decSaldoCuenta;
        }

        private static List<Cuenta> ConvertToList(DataSet dsCuentas)
        {
            DataTable dt = dsCuentas.Tables[0];
            List<Cuenta> listacuentas = (from item in dt.AsEnumerable()
                                 select new Cuenta()
                                 {
                                     Id = item.Field<int>("Id"),
                                     Nombre = item.Field<string>("Nombre"),
                                     FechaCreacion = item.Field<DateTime>("Fecha_creacion")
                                 }).ToList();
            return listacuentas;
        }
    }
}
