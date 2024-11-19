using CapaAccesoDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class logProducto
    {
        #region Singleton
        // Patrón Singleton
        private static readonly logProducto _instancia = new logProducto();

        // Propiedad pública para obtener la instancia única de la clase
        public static logProducto Instancia
        {
            get
            {
                return logProducto._instancia;
            }
        }
        #endregion Singleton

        #region Métodos

        // Listado de Productos
        public List<entProducto> ListarProducto()
        {
            return datProducto.Instancia.ListarProducto();
        }

        // Insertar Producto
        public void InsertarProducto(entProducto producto)
        {
            datProducto.Instancia.InsertarProducto(producto);
        }

        // Editar Producto
        public void EditarProducto(entProducto producto)
        {
            datProducto.Instancia.EditarProducto(producto);
        }

        // Eliminar Producto
        public void EliminarProducto(string idProducto)
        {
            datProducto.Instancia.EliminarProducto(idProducto);
        }

        // Buscar Producto por ID
        public entProducto BuscarProductoPorId(string idProducto)
        {
            return datProducto.Instancia.BuscarProductoPorId(idProducto);
        }

        #endregion Métodos
    }




}
