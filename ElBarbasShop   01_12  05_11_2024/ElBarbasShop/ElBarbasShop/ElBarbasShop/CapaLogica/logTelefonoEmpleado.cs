using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaAccesoDatos;
using CapaEntidad;

namespace CapaLogica
{
    public class logTelefonoEmpleado
    {
        #region Singleton
        // Patrón Singleton
        private static readonly logTelefonoEmpleado _instancia = new logTelefonoEmpleado();

        // Propiedad pública para obtener la instancia única de la clase
        public static logTelefonoEmpleado Instancia
        {
            get
            {
                return logTelefonoEmpleado._instancia;
            }
        }
        #endregion Singleton

        #region Métodos

        // Listado de Teléfonos de un Empleado
        public List<entTelefonoEmpleado> ListarTelefonoEmpleado(string idEmpleado)
        {
            return datTelefonoEmpleado.Instancia.ListarTelefonoEmpleado(idEmpleado);
        }

        // Insertar Teléfono de Empleado
        public void InsertarTelefonoEmpleado(entTelefonoEmpleado telefonoEmpleado)
        {
            datTelefonoEmpleado.Instancia.InsertarTelefonoEmpleado(telefonoEmpleado);
        }

        // Editar Teléfono de Empleado
        public void EditarTelefonoEmpleado(entTelefonoEmpleado telefonoEmpleado)
        {
            datTelefonoEmpleado.Instancia.EditarTelefonoEmpleado(telefonoEmpleado);
        }

        // Eliminar Teléfono de Empleado
        public void EliminarTelefonoEmpleado(entTelefonoEmpleado telefonoEmpleado)
        {
            datTelefonoEmpleado.Instancia.EliminarTelefonoEmpleado(telefonoEmpleado);
        }

        // Buscar Teléfono de Empleado
        public entTelefonoEmpleado BuscarTelefonoEmpleado(string idEmpleado, string numeroTelefono)
        {
            return datTelefonoEmpleado.Instancia.BuscarTelefonoEmpleado(idEmpleado, numeroTelefono);
        }

        #endregion Métodos
    }
}
