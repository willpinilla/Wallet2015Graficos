using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WalletDatos.Graphics;

namespace WalletDatos.Graphics
{
    public class GestionBarrasDB
    {
        public List<Barra>GetIngresosGastosDB(string strAnoConsultaIngresosGastos, string strMesConsultaIngresosGastos)
        {
            DatabaseProviderFactory factory = new DatabaseProviderFactory();
            Database db = factory.Create("WalletConnectionString");
            DbCommand dbc = db.GetStoredProcCommand("dbo.paGetIngresosGastos");
            db.AddInParameter(dbc, "@Ano", DbType.String, strAnoConsultaIngresosGastos);
            db.AddInParameter(dbc, "@Mes", DbType.String, strMesConsultaIngresosGastos);
            DataSet dsIngresosGastos = db.ExecuteDataSet(dbc);
            List<Barra> listaBarras = ConvertToList(dsIngresosGastos);
            return listaBarras;
        }

        public List<Barra> GetGastosDB(string strAnoConsultaGastos, string strMesConsultaGastos)
        {
            DatabaseProviderFactory factory = new DatabaseProviderFactory();
            Database db = factory.Create("WalletConnectionString");
            DbCommand dbc = db.GetStoredProcCommand("dbo.paGetGastos");
            db.AddInParameter(dbc, "@Ano", DbType.String, strAnoConsultaGastos);
            db.AddInParameter(dbc, "@Mes", DbType.String, strMesConsultaGastos);
            DataSet dsGastos = db.ExecuteDataSet(dbc);
            List<Barra> listaBarras = ConvertToList(dsGastos);
            return listaBarras;
        }

        private static List<Barra> ConvertToList(DataSet dsBarras)
        {
            DataTable dt = dsBarras.Tables[0];
            List<Barra> listaBarras = (from item in dt.AsEnumerable()
                                         select new Barra()
                                         {
                                             Valor = item.Field<decimal>("Valor"),
                                             Leyenda = item.Field<string>("Leyenda")
                                         }).ToList();
            return listaBarras;
        }
    }
}
