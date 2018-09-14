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
    public class GestionMovimiento
    {
        private GestionMovimientoDB gestionmovimientoDB;

        private GestionMovimientoDB getGestionMovimientoDB()
        {
            if (gestionmovimientoDB == null)
            {
                gestionmovimientoDB = new GestionMovimientoDB();
            }
            return gestionmovimientoDB;
        }

        public void GuardarMovimiento(Movimiento movimiento)
        {
            getGestionMovimientoDB().GuardarMovimientoDB(movimiento);
        }

        public List<Movimiento> GetMovimientos ()
        {
            List<Movimiento> listaMovimientos = getGestionMovimientoDB().GetMovimientosDB();
            return listaMovimientos;
        }

    }
}
