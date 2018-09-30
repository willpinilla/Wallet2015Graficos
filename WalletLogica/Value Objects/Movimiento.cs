using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WalletLogica
{
    public class Movimiento
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Valor { get; set; }
        public string TipoMovimiento { get; set; }
        public int TipoMovimientoId { get; set; }
        public string Cuenta { get; set; }
        public int CuentaId { get; set; }
        public string Categoria { get; set; }
        public int CategoriaId { get; set; }
    }
}
