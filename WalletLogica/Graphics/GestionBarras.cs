using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WalletDatos.Graphics;

namespace WalletLogica.Graphics
{
    public class GestionBarras
    {
        private GestionBarrasDB gestionbarrasDB;

        public GestionBarrasDB getGestionBarrasDB()
        {
            if (gestionbarrasDB == null)
            {
                gestionbarrasDB = new GestionBarrasDB();
            }
            return gestionbarrasDB;
        }

        public List<Barra> getIngresosGastos(string strAnoConsultaIngresosGastos, string strMesConsultaIngresosGastos)
        {
            List<WalletDatos.Graphics.Barra> listaIngresosGastosDB = getGestionBarrasDB().GetIngresosGastosDB(strAnoConsultaIngresosGastos, strMesConsultaIngresosGastos);
            List<Barra> listaBarras = new List<Barra>();
            foreach (var item in listaIngresosGastosDB)
            {
                Barra ct = new Barra()
                {
                    Valor = item.Valor,
                    Leyenda = item.Leyenda
                };
                listaBarras.Add(ct);
            }

            return listaBarras;
        }


        public List<Barra> getGastos(string strAnoConsultaGastos, string strMesConsultaGastos)
        {
            List<WalletDatos.Graphics.Barra> listaGastosDB = getGestionBarrasDB().GetGastosDB(strAnoConsultaGastos, strMesConsultaGastos);
            List<Barra> listaBarras = new List<Barra>();
            foreach (var item in listaGastosDB)
            {
                Barra ct = new Barra()
                {
                    Valor = item.Valor,
                    Leyenda = item.Leyenda
                };
                listaBarras.Add(ct);
            }

            return listaBarras;
        }
    }
}
