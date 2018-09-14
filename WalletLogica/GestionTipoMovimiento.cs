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
    public class GestionTipoMovimiento
    {
        private GestionTipoMovimientoDB gestiontipomovimientoDB;

        private GestionTipoMovimientoDB getGestionMovimientoDB()
        {
            if (gestiontipomovimientoDB == null)
            {
                gestiontipomovimientoDB = new GestionTipoMovimientoDB();
            }
            return gestiontipomovimientoDB;
        }

        public List<TipoMovimiento> GetTiposMovimiento ()
        {
            List<TipoMovimiento> listaTiposMovimiento = getGestionMovimientoDB().GetTiposMovimientoDB();
            return listaTiposMovimiento;
        }

    }
}
