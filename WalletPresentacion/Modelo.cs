using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WalletPresentacion.Vista;
using WalletLogica;
using System.Data;
using WalletPresentacion.Util;
using System.Windows.Forms;
using System.Drawing;
using WalletLogica.Graphics;

namespace WalletPresentacion
{
    public class Modelo
    {
        private VistaWallet ventana;
        private GestionCategoria gestioncategoria;
        private Categoria categoria;
        private GestionCuenta gestioncuenta;
        private Cuenta cuenta;
        private GestionMovimiento gestionmovimiento;
        private Movimiento movimiento;
        private GestionReporte gestionreporte;
        private ReporteParametros reporteparametros;
        //private ReporteResultados reporteresultados;
        private GestionTipoMovimiento gestiontipomovimiento;
        private Dimension tamanoLienzo;
        public GestionBarras gestionbarras;

        public Modelo(VistaWallet vistawallet)
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



        private GestionCuenta getGestionCuenta()
        {
            if (gestioncuenta == null)
            {
                gestioncuenta = new GestionCuenta();
            }
            return gestioncuenta;
        }

        public void GuardarCuenta()
        {
            string strNombreCuenta = ventana.getNombreCuenta().Text;
            cuenta = new Cuenta() { Nombre = strNombreCuenta };
            getGestionCuenta().GuardarCuenta(cuenta);
        }

        public DataSet GetCuentas()
        {
            List<Cuenta> listaCuentas = getGestionCuenta().GetCuentas();
            DataSet dsCuentas = Conversiones.ConvertToDataSetCuentas(listaCuentas, false);
            return dsCuentas;
        }

        public DataSet GetCuentasMovimiento()
        {
            List<Cuenta> listaCuentas = getGestionCuenta().GetCuentas();
            DataSet dsCuentas = Conversiones.ConvertToDataSetCuentas(listaCuentas, true);
            return dsCuentas;
        }



        private GestionMovimiento getGestionMovimiento()
        {
            if (gestionmovimiento == null)
            {
                gestionmovimiento = new GestionMovimiento();
            }
            return gestionmovimiento;
        }

        public DataSet GetMovimientos()
        {
            List<Movimiento> listaMovimientos = getGestionMovimiento().GetMovimientos();
            DataSet dsMovimientos = Conversiones.ConvertToDataSetMovimientos(listaMovimientos, false);
            return dsMovimientos;
        }

        public bool GuardarMovimiento()
        {
            int intTipoMovimientoId = Convert.ToInt32(ventana.getTipoMovimientoMovimiento().SelectedValue);
            int intCuentaId = Convert.ToInt32(ventana.getCuentaMovimiento().SelectedValue);
            int intCategoriaId = Convert.ToInt32(ventana.getCategoriaMovimiento().SelectedValue);
            decimal decValorMovimiento = Convert.ToDecimal(ventana.getValorMovimiento().Text);
            string strDescripcionMovimiento = ventana.getDescripcionMovimiento().Text;
            int intCuentaDestinoId = 0;
            bool bMovimientoGuardado = false;

            //traslado
            if (intTipoMovimientoId == 3)
            {
                //Validar que la Cuenta tenga Saldo suficiente
                decimal decSaldoCuenta = getGestionCuenta().GetSaldoCuenta(intCuentaId);
                if (decSaldoCuenta - decValorMovimiento >= 0)
                {
                    //Movimiento Egreso
                    movimiento = new Movimiento()
                    {
                        Descripcion = strDescripcionMovimiento,
                        Valor = decValorMovimiento * -1,
                        TipoMovimientoId = intTipoMovimientoId,
                        CuentaId = intCuentaId,
                        CategoriaId = intCategoriaId
                    };
                    getGestionMovimiento().GuardarMovimiento(movimiento);

                    //Movimiento Ingreso
                    intCuentaDestinoId = Convert.ToInt32(ventana.getCuentaDestinoMovimiento().SelectedValue);
                    movimiento = new Movimiento()
                    {
                        Descripcion = strDescripcionMovimiento,
                        Valor = decValorMovimiento,
                        TipoMovimientoId = intTipoMovimientoId,
                        CuentaId = intCuentaDestinoId,
                        CategoriaId = intCategoriaId
                    };
                    getGestionMovimiento().GuardarMovimiento(movimiento);
                    bMovimientoGuardado = true;
                }
            }
            else if (intTipoMovimientoId == 2)//Egreso
            {
                //Validar Saldo Cuenta
                decimal decSaldoCuenta = getGestionCuenta().GetSaldoCuenta(intCuentaId);
                if (decSaldoCuenta - decValorMovimiento >= 0)
                {
                    movimiento = new Movimiento()
                    {
                        Descripcion = strDescripcionMovimiento,
                        Valor = decValorMovimiento * -1,
                        TipoMovimientoId = intTipoMovimientoId,
                        CuentaId = intCuentaId,
                        CategoriaId = intCategoriaId
                    };
                    getGestionMovimiento().GuardarMovimiento(movimiento);
                    bMovimientoGuardado = true;
                }
            }
            else if (intTipoMovimientoId == 1) //Ingreso 
            {
                movimiento = new Movimiento()
                {
                    Descripcion = strDescripcionMovimiento,
                    Valor = decValorMovimiento,
                    TipoMovimientoId = intTipoMovimientoId,
                    CuentaId = intCuentaId,
                    CategoriaId = intCategoriaId
                };
                getGestionMovimiento().GuardarMovimiento(movimiento);
                bMovimientoGuardado = true;
            }
            return bMovimientoGuardado;
        }


        private GestionReporte getGestionReporte()
        {
            if (gestionreporte == null)
            {
                gestionreporte = new GestionReporte();
            }
            return gestionreporte;
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

        public Dimension getTamanoLienzo()
        {
            if (tamanoLienzo == null)
            {
                //int ancho = ventana.getTabPage().Width;
                //int alto = ventana.getTabPage().Height;
                int ancho = 500;
                int alto = 300;
                tamanoLienzo = new Dimension(ancho, alto);
            }
            return tamanoLienzo;
        }

        private GestionBarras getGestionBarras()
        {
            if (gestionbarras == null)
            {
                gestionbarras = new GestionBarras();
            }
            return gestionbarras;
        }

        public void DibujarIngresosGastos()
        {
            var cmbAno = ventana.getAnoConsultaIngresosGastos().SelectedItem;
            var cmbMes = ventana.getMesConsultaIngresosGastos().SelectedItem;

            string strAnoConsultaIngresosGastos = "";
            if (cmbAno != null)
            {
                strAnoConsultaIngresosGastos = ventana.getAnoConsultaIngresosGastos().SelectedItem.ToString();
            }

            string strMesConsultaIngresosGastos = "";
            if (cmbMes != null)
            {
                strMesConsultaIngresosGastos = ventana.getMesConsultaIngresosGastos().SelectedItem.ToString();
            }

            //Llamar al método de la base de datos q devuelve el listado de barras
            List<Barra> listadoBarras = getGestionBarras().getIngresosGastos(strAnoConsultaIngresosGastos, strMesConsultaIngresosGastos);
            DibujarEnLienzo(listadoBarras);
        }

        public void DibujarGastos()
        {
            var cmbAno = ventana.getAnoConsultaGastos().SelectedItem;
            var cmbMes = ventana.getMesConsultaGastos().SelectedItem;

            string strAnoConsultaIngresosGastos = "";
            if (cmbAno != null)
            {
                strAnoConsultaIngresosGastos = ventana.getAnoConsultaGastos().SelectedItem.ToString();
            }

            string strMesConsultaIngresosGastos = "";
            if (cmbMes != null)
            {
                strMesConsultaIngresosGastos = ventana.getMesConsultaGastos().SelectedItem.ToString();
            }

            //Llamar al método de la base de datos q devuelve el listado de barras
            List<Barra> listadoBarras = getGestionBarras().getGastos(strAnoConsultaIngresosGastos, strMesConsultaIngresosGastos);
            DibujarEnLienzo(listadoBarras);
        }

        private void DibujarEnLienzo(List<Barra> listadoBarras)
        {
            TabPage tabgraficos = ventana.getTabPage();

            //crear lienzo de dibjo
            Graphics g = tabgraficos.CreateGraphics();

            int iAnchoGrafico = getTamanoLienzo().ancho;
            int iAltoGrafico = getTamanoLienzo().alto;

            Pen lapiz = new Pen(Color.Black, 1);
            Point puntoOrigenLineaBase = new Point(100, 400);
            Point puntoFinLineaBase = new Point(600, 400);
            g.DrawLine(lapiz, puntoOrigenLineaBase, puntoFinLineaBase);
            Pen lapizEnBlanco = new Pen(Color.Transparent, 3);

            int iCantidadBarras = listadoBarras.Count;

            int iAvanceX = 100;
            int iAvanceY = 100;

            int iCantidadBarrasDibujo = (iCantidadBarras * 2) + 1;
            int iAnchoBarrasDibujo = iAnchoGrafico / iCantidadBarrasDibujo;
            int iAltoBarraDibujo = -1;

            Point puntoOrigenEnBlanco;
            Size tamanoEnBlanco;
            Rectangle rectBlanco;

            decimal dValorAnterior = 0;
            decimal dValorActual = 0;

            Random r = new Random();

            foreach (var item in listadoBarras)
            {
                //Barra en blanco
                puntoOrigenEnBlanco = new Point(iAvanceX, iAvanceY);
                tamanoEnBlanco = new Size(iAnchoBarrasDibujo, 300);
                rectBlanco = new Rectangle(puntoOrigenEnBlanco, tamanoEnBlanco);
                g.DrawRectangle(lapizEnBlanco, rectBlanco);
                iAvanceX += iAnchoBarrasDibujo;

                //Barra Real
                //La primera barra real la pinta al 100%
                if (iAltoBarraDibujo == -1)
                {
                    iAltoBarraDibujo = 300;
                    dValorActual = item.Valor;
                }
                else //A las siguientes barras se les calcula el alto
                {
                    dValorAnterior = dValorActual;
                    dValorActual = item.Valor;
                    //Punto Origen Y de barra
                    iAvanceY = 400 - (Convert.ToInt32((dValorActual * 300) / dValorAnterior));
                    //Longitud de Barra
                    iAltoBarraDibujo = 400 - iAvanceY;
                }
                Point puntoOrigenBarra = new Point(iAvanceX, iAvanceY);
                Size tamanoBarra = new Size(iAnchoBarrasDibujo, iAltoBarraDibujo);
                Rectangle rectReal = new Rectangle(puntoOrigenBarra, tamanoBarra);
                //g.DrawRectangle(lapiz, rectReal);

                //Relleno con un color aleatorio
                SolidBrush myBrush = new SolidBrush(Color.FromArgb(r.Next(0, 256), r.Next(0, 256), r.Next(0, 256)));
                g.FillRectangle(myBrush, rectReal);
                g.DrawString(item.Leyenda + " (" + item.Valor + ")", new Font("Arial", 8, FontStyle.Bold, GraphicsUnit.Point), Brushes.Black, rectReal);
                iAvanceX += iAnchoBarrasDibujo;
            }

            if (iCantidadBarras > 0)
            {
                //Barra Final
                puntoOrigenEnBlanco = new Point(iAvanceX, iAvanceY);
                tamanoEnBlanco = new Size(iAnchoBarrasDibujo, 300);
                rectBlanco = new Rectangle(puntoOrigenEnBlanco, tamanoEnBlanco);
                g.DrawRectangle(lapizEnBlanco, rectBlanco);
            }
            else
            {
                //Limpiar Lienzo
                g.Clear(Color.White);
            }

        }
    }
}
