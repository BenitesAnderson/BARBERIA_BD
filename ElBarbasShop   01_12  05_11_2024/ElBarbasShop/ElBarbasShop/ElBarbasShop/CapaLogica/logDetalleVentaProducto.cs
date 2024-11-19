using CapaAccesoDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{

    public class logDetalleVentaProducto
    {
        #region sigleton      
        private static readonly logDetalleVentaProducto _instancia = new logDetalleVentaProducto();
        public static logDetalleVentaProducto Instancia
        {
            get
            {
                return logDetalleVentaProducto._instancia;
            }
        }
        #endregion singleton

        #region Metodos 
        public List<entDetalleVentaProducto> ListarDetalleVentaProducto()
        {
            return datDetalleVentaProducto.Instancia.ListarDetalleVentaProducto();
        }
        public entDetalleVentaProducto BuscarDetalleVentaProductoPorId(string idDetalleVentaProducto)
        {
            return datDetalleVentaProducto.Instancia.BuscarDetalleVentaProductoPorId(idDetalleVentaProducto);
        }
        public void InsertaDetalleVentaProducto(entDetalleVentaProducto dvp)
        {
            datDetalleVentaProducto.Instancia.InsertarDetalleVentaProducto(dvp);
        }
        public void EditaDetalleVentaProducto(entDetalleVentaProducto Cli)
        {
            datDetalleVentaProducto.Instancia.EditarDetalleVentaProducto(Cli);
        }
        public void DeshabilitarDetalleVentaProducto(entDetalleVentaProducto cliente)
        {
            datDetalleVentaProducto.Instancia.DeshabilitarDetalleVentaProducto(cliente);
        }
        #endregion Metodos
    }
}
