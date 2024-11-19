using CapaAccesoDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class logCliente
    {
        #region Singleton
        // Patrón Singleton
        private static readonly logCliente _instancia = new logCliente();

        // Propiedad pública para obtener la instancia única de la clase
        public static logCliente Instancia
        {
            get
            {
                return logCliente._instancia;
            }
        }
        #endregion Singleton

        #region Métodos

        // Listado de Clientes
        public List<entCliente> ListarCliente()
        {
            return datCliente.Instancia.ListarCliente();
        }

        // Insertar Cliente
        public void InsertarCliente(entCliente cliente)
        {
            datCliente.Instancia.InsertarCliente(cliente);
        }

        // Editar Cliente
        public void EditarCliente(entCliente cliente)
        {
            datCliente.Instancia.EditarCliente(cliente);
        }

        // Deshabilitar Cliente
        public void DeshabilitarCliente(entCliente cliente)
        {
            datCliente.Instancia.DeshabilitarCliente(cliente);
        }

        public entCliente BuscarClientePorId(string idCliente)
        {
            return datCliente.Instancia.BuscarClientePorId(idCliente);
        }


        #endregion Métodos
    }

}
