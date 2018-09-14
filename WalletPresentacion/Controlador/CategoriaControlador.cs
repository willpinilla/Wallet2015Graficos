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
    public class CategoriaControlador
    {
        private VistaWallet ventana;
        private GestionCategoria gestioncategoria;
        private Categoria categoria;

        public CategoriaControlador(VistaWallet vistawallet)
        {
            if (ventana == null)
            {
                ventana = vistawallet;
            }
        }

        private GestionCategoria getGestionCategoria()
        {
            if (gestioncategoria == null)
            {
                gestioncategoria = new GestionCategoria();
            }
            return gestioncategoria;
        }

        public DataSet GetCategorias()
        {
            List<Categoria> listaCategorias = getGestionCategoria().GetCategorias();
            DataSet dsCategorias = Conversiones.ConvertToDataSetCategorias(listaCategorias, false);
            return dsCategorias;
        }

        public void GuardarCategoria()
        {
            int intTipoMovimientoId = Convert.ToInt32(ventana.getTipoMovimientoCategoria().SelectedValue);
            string strNombreCategoria = ventana.getNombreCategoria().Text;
            categoria = new Categoria() { Nombre = strNombreCategoria, TipoMovimientoId = intTipoMovimientoId };
            getGestionCategoria().GuardarCategoria(categoria);
        }

        public DataSet GetCategoriasTipoMovimiento()
        {
            int intTipoMovimientoId = Convert.ToInt32(ventana.getTipoMovimientoMovimiento().SelectedValue);
            List<Categoria> listaCategorias = getGestionCategoria().GetCategoriasTipoMovimiento(intTipoMovimientoId);
            DataSet dsCategorias = Conversiones.ConvertToDataSetCategorias(listaCategorias, true);
            return dsCategorias;
        }
    }
}
