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
    public class GestionCategoria
    {
        private GestionCategoriaDB gestioncategoriaDB;

        private GestionCategoriaDB getGestionCategoriaDB()
        {
            if (gestioncategoriaDB == null)
            {
                gestioncategoriaDB = new GestionCategoriaDB();
            }
            return gestioncategoriaDB;
        }

        public void GuardarCategoria(Categoria categoria)
        {
            getGestionCategoriaDB().GuardarCategoriaDB(categoria);
        }

        public List<Categoria> GetCategorias ()
        {
            List<Categoria> listaCategorias = getGestionCategoriaDB().GetCategoriasDB();
            return listaCategorias;
        }

        public List<Categoria> GetCategoriasTipoMovimiento(int intTipoMovimientoId)
        {
            List<Categoria> listaCategorias = getGestionCategoriaDB().GetCategoriasTipoMovimientoDB(intTipoMovimientoId);
            return listaCategorias;
        }
    }
}
