using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WalletDatos;

namespace WalletLogica
{
    public class GestionReporte
    {
        private GestionReporteDB gestionreporteDB;

        private GestionReporteDB getGestionReporteDB()
        {
            if (gestionreporteDB == null)
            {
                gestionreporteDB = new GestionReporteDB();
            }
            return gestionreporteDB;
        }

        public List<ReporteResultados> GetReporte(ReporteParametros reporteparametros)
        {
            WalletDatos.ReporteParametros ReporteParametrosDB = new WalletDatos.ReporteParametros()
            {
                TipoMovimientoId = reporteparametros.TipoMovimientoId,
                CategoriaId = reporteparametros.CategoriaId,
                CuentaId = reporteparametros.CuentaId,
                FechaInicio = reporteparametros.FechaInicio,
                FechaFin = reporteparametros.FechaFin
            };

            List<WalletDatos.ReporteResultados> listaReporteResultadosDB = getGestionReporteDB().GetReporteDB(ReporteParametrosDB);
            List<ReporteResultados> listaReporteResultados = new List<ReporteResultados>();
            foreach (var item in listaReporteResultadosDB)
            {
                ReporteResultados rpt = new ReporteResultados()
                {
                   TipoMovimiento = item.TipoMovimiento,
                   Categoria = item.Categoria,
                   Cuenta = item.Cuenta,
                   Valor = item.Valor
                };
                listaReporteResultados.Add(rpt);
            }

            return listaReporteResultados;
        }

    }
}
