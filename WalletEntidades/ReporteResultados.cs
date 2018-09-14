using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WalletEntidades
{
    public class ReporteResultados
    {
        public string TipoMovimiento { get; set; }
        public string Categoria { get; set; }
        public string Cuenta { get; set; }
        //public DateTime Fecha { get; set; }
        //public string Descripcion { get; set; }
        public decimal Valor { get; set; }
    }
}
