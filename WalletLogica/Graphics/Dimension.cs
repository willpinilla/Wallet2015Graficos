using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WalletLogica.Graphics
{
    public class Dimension
    {
        public int ancho { get; set; }
        public int alto { get; set; }

        public Dimension(int ancho, int alto)
        {
            this.ancho = ancho;
            this.alto = alto;
        }
    }
}
