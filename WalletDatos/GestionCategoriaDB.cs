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
    public class GestionCategoriaDB
    {
        //string constr = Properties.Settings.Default.WalletConnectionString;

        public void GuardarCategoriaDB(Categoria categoria)
        {
            DatabaseProviderFactory factory = new DatabaseProviderFactory();
            Database db = factory.Create("WalletConnectionString");
            DbCommand dbc = db.GetStoredProcCommand("dbo.paCrearCategoria");
            db.AddInParameter(dbc, "@NombreCategoria", DbType.String, categoria.Nombre);
            db.AddInParameter(dbc, "@TipoMovimientoId", DbType.Int32, categoria.TipoMovimientoId);
            db.ExecuteNonQuery(dbc);
        }

        public List<Categoria> GetCategoriasDB()
        {
            DatabaseProviderFactory factory = new DatabaseProviderFactory();
            Database db = factory.Create("WalletConnectionString");
            DbCommand dbc = db.GetStoredProcCommand("dbo.paGetCategorias");
            DataSet dsCategorias = db.ExecuteDataSet(dbc);
            List<Categoria> listaCategorias = ConvertToList(dsCategorias);
            return listaCategorias;
        }

        public List<Categoria> GetCategoriasTipoMovimientoDB(int intTipoMovimientoId)
        {
            DatabaseProviderFactory factory = new DatabaseProviderFactory();
            Database db = factory.Create("WalletConnectionString");
            DbCommand dbc = db.GetStoredProcCommand("dbo.paGetCategoriasTipoMovimiento");
            db.AddInParameter(dbc, "@TipoMovimientoId", DbType.String, intTipoMovimientoId);
            DataSet dsCategorias = db.ExecuteDataSet(dbc);
            List<Categoria> listaCategorias = ConvertToList(dsCategorias);
            return listaCategorias;
        }

        private static List<Categoria> ConvertToList(DataSet dsCuentas)
        {
            DataTable dt = dsCuentas.Tables[0];
            List<Categoria> listacategorias = (from item in dt.AsEnumerable()
                                 select new Categoria()
                                 {
                                     Id = item.Field<int>("Id"),
                                     Nombre = item.Field<string>("Nombre"),
                                     TipoMovimiento = item.Field<string>("TipoMovimiento")
                                 }).ToList();
            return listacategorias;
        }
    }
}
