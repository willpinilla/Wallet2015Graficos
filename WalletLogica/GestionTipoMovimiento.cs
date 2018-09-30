using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WalletDatos;

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
            List<WalletDatos.TipoMovimiento> listaTiposMovimientoDB = getGestionMovimientoDB().GetTiposMovimientoDB();
            List<TipoMovimiento> listaTiposMovimiento = new List<TipoMovimiento>();
            foreach (var item in listaTiposMovimientoDB)
            {
                TipoMovimiento tp = new TipoMovimiento()
                {
                    Id = item.Id,
                    Nombre = item.Nombre
                };
                listaTiposMovimiento.Add(tp);
            }
           
            return listaTiposMovimiento;
        }

    }
}
