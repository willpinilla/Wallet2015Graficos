using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WalletDatos
{
    public class ReporteParametros
    {
        public int TipoMovimientoId { get; set; }
        public int CategoriaId { get; set; }
        public int CuentaId { get; set; }
        public string FechaInicio { get; set; }
        public string FechaFin { get; set; }
    }

}