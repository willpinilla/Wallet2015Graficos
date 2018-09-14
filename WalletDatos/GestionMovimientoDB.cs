using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WalletEntidades;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System.Data.Common;
using System.Data;

namespace WalletDatos
{
    public class GestionMovimientoDB
    {
        //string constr = Properties.Settings.Default.WalletConnectionString;

        public void GuardarMovimientoDB(Movimiento movimiento)
        {
            DatabaseProviderFactory factory = new DatabaseProviderFactory();
            Database db = factory.Create("WalletConnectionString");
            DbCommand dbc = db.GetStoredProcCommand("dbo.paCrearMovimiento");
            db.AddInParameter(dbc, "@TipoMovimientoId", DbType.Int32, movimiento.TipoMovimientoId);
            db.AddInParameter(dbc, "@CuentaId", DbType.Int32, movimiento.CuentaId);
            db.AddInParameter(dbc, "@CategoriaId", DbType.Int32, movimiento.CategoriaId);
            db.AddInParameter(dbc, "@Valor", DbType.Decimal, movimiento.Valor);
            db.AddInParameter(dbc, "@Descripcion", DbType.String, movimiento.Descripcion);
            db.ExecuteNonQuery(dbc);
        }

        public List<Movimiento> GetMovimientosDB()
        {
            DatabaseProviderFactory factory = new DatabaseProviderFactory();
            Database db = factory.Create("WalletConnectionString");
            DbCommand dbc = db.GetStoredProcCommand("dbo.paGetMovimientos");
            DataSet dsMovimientos = db.ExecuteDataSet(dbc);
            List<Movimiento> listaMovimientos = ConvertToList(dsMovimientos);
            return listaMovimientos;
        }

        private static List<Movimiento> ConvertToList(DataSet dsMovimientos)
        {
            DataTable dt = dsMovimientos.Tables[0];
            List<Movimiento> listamovimientos = (from item in dt.AsEnumerable()
                                                 select new Movimiento()
                                                 {
                                                     //Id = item.Field<int>("Id"),
                                                     Descripcion = item.Field<string>("Descripcion"),
                                                     Valor = item.Field<decimal>("Valor"),
                                                     Fecha = item.Field<DateTime>("Fecha"),
                                                     TipoMovimiento = item.Field<string>("TipoMovimiento"),
                                                     Categoria = item.Field<string>("Categoria"),
                                                     Cuenta = item.Field<string>("Cuenta")
                                 }).ToList();
            return listamovimientos;
        }
    }
}
