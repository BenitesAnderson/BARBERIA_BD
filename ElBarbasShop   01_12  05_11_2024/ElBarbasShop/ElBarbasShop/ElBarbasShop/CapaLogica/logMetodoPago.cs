using CapaAccesoDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class logMetodoPago
    {
        #region sigleton      
        private static readonly logMetodoPago _instancia = new logMetodoPago();
        public static logMetodoPago Instancia
        {
            get
            {
                return logMetodoPago._instancia;
            }
        }
        #endregion singleton
        #region Metodos 
        public List<entMetodoPago> ListarMetodoPago()
        {
            return datMetodoPago.Instancia.ListarMetodoPago();
        }
        public entMetodoPago BuscarMetodoPagoPorId(string idDetalleVentaProducto)
        {
            return datMetodoPago.Instancia.BuscarMetodoPagoPorId(idDetalleVentaProducto);
        }
        public void InsertaMetodoPago(entMetodoPago dvp)
        {
            datMetodoPago.Instancia.InsertarMetodoPago(dvp);
        }
        public void EditaMetodoPago(entMetodoPago Cli)
        {
            datMetodoPago.Instancia.EditarMetodoPago(Cli);
        }

        #endregion Metodos 
    }
}
