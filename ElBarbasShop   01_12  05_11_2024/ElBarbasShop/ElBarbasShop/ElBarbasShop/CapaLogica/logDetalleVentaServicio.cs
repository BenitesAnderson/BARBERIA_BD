using CapaAccesoDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class logDetalleVentaServicio
    {
        #region sigleton      
        private static readonly logDetalleVentaServicio _instancia = new logDetalleVentaServicio();
        public static logDetalleVentaServicio Instancia
        {
            get
            {
                return logDetalleVentaServicio._instancia;
            }
        }
        #endregion singleton

        #region Metodos 
        public List<entDetalleVentaServicio> ListarDetalleVentaServicio()
        {
            return datDetalleVentaServicio.Instancia.ListarDetalleVentaServicio();
        }
        public entDetalleVentaServicio BuscarDetalleVentaServicioPorId(string idDetalleVentaServicio)
        {
            return datDetalleVentaServicio.Instancia.BuscarDetalleVentaServicioPorId(idDetalleVentaServicio);
        }
        public void InsertaDetalleVentaServicio(entDetalleVentaServicio dvp)
        {
            datDetalleVentaServicio.Instancia.InsertarDetalleVentaServicio(dvp);
        }
        public void EditaDetalleVentaServicio(entDetalleVentaServicio Cli)
        {
            datDetalleVentaServicio.Instancia.EditarDetalleVentaServicio(Cli);
        }

        #endregion Metodos
    }
}
