using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WalletPresentacion.Vista;
using WalletLogica;
using WalletEntidades;
using System.Data;
using WalletPresentacion.Util;

namespace WalletPresentacion.Controlador
{
    public class TipoMovimientoControlador
    {
        private VistaWallet ventana;
        private GestionTipoMovimiento gestiontipomovimiento;

        public TipoMovimientoControlador(VistaWallet vistawallet)
        {
            if (ventana == null)
            {
                ventana = vistawallet;
            }
        }

        private GestionTipoMovimiento getGestionTipoMovimiento()
        {
            if (gestiontipomovimiento == null)
            {
                gestiontipomovimiento = new GestionTipoMovimiento();
            }
            return gestiontipomovimiento;
        }

        public DataSet GetTiposMovimiento()
        {
            List<TipoMovimiento> listaTiposMovimiento = getGestionTipoMovimiento().GetTiposMovimiento();
            DataSet dsTiposMovimiento = Conversiones.ConvertToDataSetTiposMovimiento(listaTiposMovimiento, true);
            return dsTiposMovimiento;
        }
    }
}
