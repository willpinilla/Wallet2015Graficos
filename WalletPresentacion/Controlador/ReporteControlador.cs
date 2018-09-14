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
    public class ReporteControlador
    {
        private VistaWallet ventana;
        private GestionReporte gestionreporte;
        private GestionCategoria gestioncategoria;
        private ReporteParametros reporteparametros;
        private ReporteResultados reporteresultados;

        public ReporteControlador(VistaWallet vistawallet)
        {
            if (ventana == null)
            {
                ventana = vistawallet;
            }
        }

        private GestionReporte getGestionReporte()
        {
            if (gestionreporte == null)
            {
                gestionreporte = new GestionReporte();
            }
            return gestionreporte;
        }

        private GestionCategoria getGestionCategoria()
        {
            if (gestioncategoria == null)
            {
                gestioncategoria = new GestionCategoria();
            }
            return gestioncategoria;
        }

        public DataSet GetReporte()
        {
            int intTipoMovimientoId = Convert.ToInt32(ventana.getTipoMovimientoConsulta().SelectedValue);
            int intCuentaId = Convert.ToInt32(ventana.getCuentaConsulta().SelectedValue);
            int intCategoriaId = Convert.ToInt32(ventana.getCategoriaConsulta().SelectedValue);
            string strFechaInicio = ventana.getFechaInicioConsulta().Value.ToShortDateString();
            string strFechaFin = ventana.getFechaFinConsulta().Value.ToShortDateString();

            reporteparametros = new ReporteParametros()
            {
                TipoMovimientoId = intTipoMovimientoId,
                CategoriaId = intCategoriaId,
                CuentaId = intCuentaId,
                FechaInicio = strFechaInicio,
                FechaFin = strFechaFin
            };

            List<ReporteResultados> listaReporteResultados = getGestionReporte().GetReporte(reporteparametros);
            DataSet dsReporteResultados = Conversiones.ConvertToDataSetReportes(listaReporteResultados, false);
            return dsReporteResultados;
        }

        public DataSet GetCategoriasConsulta()
        {
            int intTipoMovimientoId = Convert.ToInt32(ventana.getTipoMovimientoConsulta().SelectedValue);
            List<Categoria> listaCategorias = getGestionCategoria().GetCategoriasTipoMovimiento(intTipoMovimientoId);
            DataSet dsCategorias = Conversiones.ConvertToDataSetCategorias(listaCategorias, true);
            return dsCategorias;
        }
    }
}
