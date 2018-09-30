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
    public class GestionTipoMovimientoDB
    {
        //string constr = Properties.Settings.Default.WalletConnectionString;

        public List<TipoMovimiento> GetTiposMovimientoDB()
        {
            DatabaseProviderFactory factory = new DatabaseProviderFactory();
            Database db = factory.Create("WalletConnectionString");
            DbCommand dbc = db.GetStoredProcCommand("dbo.paGetTiposMovimiento");
            DataSet dsTiposMovimiento = db.ExecuteDataSet(dbc);
            List<TipoMovimiento> listaTiposMovimiento = ConvertToList(dsTiposMovimiento);
            return listaTiposMovimiento;
        }

        private static List<TipoMovimiento> ConvertToList(DataSet dsTiposMovimiento)
        {
            DataTable dt = dsTiposMovimiento.Tables[0];
            List<TipoMovimiento> listatiposmovimiento = (from item in dt.AsEnumerable()
                                 select new TipoMovimiento()
                                 {
                                     Id = item.Field<int>("Id"),
                                     Nombre = item.Field<string>("Nombre")
                                 }).ToList();
            return listatiposmovimiento;
        }
    }
}
