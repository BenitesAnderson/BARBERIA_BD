using CapaAccesoDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class logTelefonoCliente
    {
        #region Singleton
        // Instancia única de la clase
        private static readonly logTelefonoCliente _instancia = new logTelefonoCliente();
        public static logTelefonoCliente Instancia => _instancia;
        #endregion Singleton

        #region Métodos

        // Listar Teléfonos por Cliente
        public List<entTelefonoCliente> ListarTelefonosPorCliente()
        {
            return datTelefonoCliente.Instancia.ListarTelefonoCliente();
        }

        // Insertar Teléfono
        public void InsertarTelefono(entTelefonoCliente telefono)
        {
            datTelefonoCliente.Instancia.InsertarTelefono(telefono);
        }

        // Editar Teléfono
        public void EditarTelefono(entTelefonoCliente telefono)
        {
            datTelefonoCliente.Instancia.EditarTelefono(telefono);
        }

        // Eliminar Teléfono
        public void EliminarTelefono(string idCliente, string numeroTelefono)
        {
            datTelefonoCliente.Instancia.EliminarTelefono(idCliente, numeroTelefono);
        }
        // Buscar Teléfono por Cliente y Número de Teléfono
        public entTelefonoCliente BuscarTelefono(string idCliente, string numeroTelefono)
        {
            try
            {
                return datTelefonoCliente.Instancia.BuscarTelefono(idCliente, numeroTelefono);
            }
            catch (Exception e)
            {
                throw new Exception("Error al buscar teléfono del cliente: ", e);
            }
        }





        #endregion Métodos





    }
}
