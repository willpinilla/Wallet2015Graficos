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
    public class GestionReporteDB
    {
        //string constr = Properties.Settings.Default.WalletConnectionString;

        public List<ReporteResultados> GetReporteDB(ReporteParametros reporteparametros)
        {
            DatabaseProviderFactory factory = new DatabaseProviderFactory();
            Database db = factory.Create("WalletConnectionString");
            DbCommand dbc = db.GetStoredProcCommand("dbo.paGetReporte");
            db.AddInParameter(dbc, "@TipoMovimientoId", DbType.Int32, reporteparametros.TipoMovimientoId);
            db.AddInParameter(dbc, "@CuentaId", DbType.Int32, reporteparametros.CuentaId);
            db.AddInParameter(dbc, "@CategoriaId", DbType.Int32, reporteparametros.CategoriaId);
            db.AddInParameter(dbc, "@FechaInicio", DbType.String, reporteparametros.FechaInicio);
            db.AddInParameter(dbc, "@FechaFin", DbType.String, reporteparametros.FechaFin);
            DataSet dsReporteResultados = db.ExecuteDataSet(dbc);
            List<ReporteResultados> listaReporteResultados = ConvertToList(dsReporteResultados);
            return listaReporteResultados;
        }

        private static List<ReporteResultados> ConvertToList(DataSet dsReporteResultados)
        {
            DataTable dt = dsReporteResultados.Tables[0];
            List<ReporteResultados> listaReporteResultados = (from item in dt.AsEnumerable()
                                                 select new ReporteResultados()
                                                 {
                                                     TipoMovimiento = item.Field<string>("TipoMovimiento"),
                                                     Categoria = item.Field<string>("Categoria"),
                                                     Cuenta = item.Field<string>("Cuenta"),
                                                     Valor = item.Field<decimal>("Valor")
                                                 }).ToList();
            return listaReporteResultados;
        }
    }
}
