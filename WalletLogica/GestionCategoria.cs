using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WalletDatos;


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
            WalletDatos.Categoria CategoriaDB = new WalletDatos.Categoria()
            {
                Id = categoria.Id,
                Nombre = categoria.Nombre,
                TipoMovimiento = categoria.TipoMovimiento,
                TipoMovimientoId = categoria.TipoMovimientoId
            };
            getGestionCategoriaDB().GuardarCategoriaDB(CategoriaDB);
        }

        public List<Categoria> GetCategorias ()
        {
            List<WalletDatos.Categoria> listaCategoriasDB = getGestionCategoriaDB().GetCategoriasDB();
            List<Categoria> listaCategorias = new List<Categoria>();
            foreach (var item in listaCategoriasDB)
            {
                Categoria ct = new Categoria()
                {
                    Id = item.Id,
                    Nombre = item.Nombre,
                    TipoMovimientoId = item.TipoMovimientoId,
                    TipoMovimiento = item.TipoMovimiento
                };
                listaCategorias.Add(ct);
            }

            return listaCategorias;
        }

        public List<Categoria> GetCategoriasTipoMovimiento(int intTipoMovimientoId)
        {
            List<WalletDatos.Categoria> listaCategoriasDB = getGestionCategoriaDB().GetCategoriasTipoMovimientoDB(intTipoMovimientoId);
            List<Categoria> listaCategorias = new List<Categoria>();
            foreach (var item in listaCategoriasDB)
            {
                Categoria ct = new Categoria()
                {
                    Id = item.Id,
                    Nombre = item.Nombre,
                    TipoMovimientoId = item.TipoMovimientoId,
                    TipoMovimiento = item.TipoMovimiento
                };
                listaCategorias.Add(ct);
            }

            return listaCategorias;
        }
    }
}
