using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WalletEntidades
{
    public class Categoria
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string TipoMovimiento { get; set; }
        public int TipoMovimientoId { get; set; }
    }
}
