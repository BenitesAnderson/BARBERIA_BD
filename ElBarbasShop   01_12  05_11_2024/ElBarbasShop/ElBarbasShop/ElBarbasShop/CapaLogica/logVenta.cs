using System;
using System.Collections.Generic;
using CapaAccesoDatos;
using CapaEntidad;

namespace CapaLogica
{
    public class logVenta
    {
        #region Singleton
        private static readonly logVenta _instancia = new logVenta();

        public static logVenta Instancia
        {
            get
            {
                return logVenta._instancia;
            }
        }
        #endregion Singleton

        #region Métodos

        // Listado de Ventas
        public List<entVenta> ListarVenta()
        {
            return datVenta.Instancia.ListarVenta();
        }

        // Buscar Venta por ID
        public entVenta BuscarVentaPorId(string idVenta)
        {
            return datVenta.Instancia.BuscarVentaPorId(idVenta);
        }

        // Insertar Venta
        public void InsertarVenta(entVenta venta)
        {
            datVenta.Instancia.InsertarVenta(venta);
        }

        // Anular Venta
        public void AnularVenta(string idVenta)
        {
            datVenta.Instancia.AnularVenta(idVenta);
        }

        #endregion Métodos
    }
}
