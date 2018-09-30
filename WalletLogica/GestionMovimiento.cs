using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WalletDatos;

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
            WalletDatos.Movimiento MovimientoDB = new WalletDatos.Movimiento()
            {
                Id = movimiento.Id,
                Descripcion = movimiento.Descripcion,
                Fecha = movimiento.Fecha,
                Valor = movimiento.Valor,
                TipoMovimiento = movimiento.TipoMovimiento,
                TipoMovimientoId = movimiento.TipoMovimientoId,
                Cuenta = movimiento.Cuenta,
                CuentaId = movimiento.CuentaId,
                Categoria = movimiento.Categoria,
                CategoriaId = movimiento.CategoriaId
    };
            getGestionMovimientoDB().GuardarMovimientoDB(MovimientoDB);
        }

        public List<Movimiento> GetMovimientos ()
        {
            List<WalletDatos.Movimiento> listaMovimientosDB = getGestionMovimientoDB().GetMovimientosDB();
            List<Movimiento> listaMovimientos = new List<Movimiento>();
            foreach (var item in listaMovimientosDB)
            {
                Movimiento mov = new Movimiento()
                {
                    Id = item.Id,
                    Descripcion = item.Descripcion,
                    Fecha = item.Fecha,
                    Valor = item.Valor,
                    TipoMovimiento = item.TipoMovimiento,
                    TipoMovimientoId = item.TipoMovimientoId,
                    Cuenta = item.Cuenta,
                    CuentaId = item.CuentaId,
                    CategoriaId = item.CategoriaId,
                    Categoria = item.Categoria
                };
                listaMovimientos.Add(mov);
            }

            return listaMovimientos;
        }

    }
}
