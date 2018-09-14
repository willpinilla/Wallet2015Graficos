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
            List<ReporteResultados> listaReporteResultados = getGestionReporteDB().GetReporteDB(reporteparametros);
            return listaReporteResultados;
        }

    }
}
