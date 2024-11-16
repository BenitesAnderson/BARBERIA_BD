using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaAccesoDatos;
using CapaEntidad;

namespace CapaLogica
{
    public class logEmpleado
    {
        #region Singleton
        // Patrón Singleton
        // Variable estática para la instancia
        private static readonly logEmpleado _instancia = new logEmpleado();

        // Propiedad pública para obtener la instancia única de la clase
        public static logEmpleado Instancia
        {
            get
            {
                return logEmpleado._instancia;
            }
        }
        #endregion Singleton

        #region Métodos

        // Listado de Empleados
        public List<entEmpleado> ListarEmpleado()
        {
            return datEmpleado.Instancia.ListarEmpleado();
        }

        // Insertar Empleado
        public void InsertarEmpleado(entEmpleado empleado)
        {
            datEmpleado.Instancia.InsertarEmpleado(empleado);
        }

        // Editar Empleado
        public void EditarEmpleado(entEmpleado empleado)
        {
            datEmpleado.Instancia.EditarEmpleado(empleado);
        }

        // Deshabilitar Empleado
        public void DeshabilitarEmpleado(entEmpleado empleado)
        {
            datEmpleado.Instancia.DeshabilitarEmpleado(empleado);
        }

        #endregion Métodos

        public entEmpleado BuscarEmpeladoPorId(string idEmpleado)
        {
            return datEmpleado.Instancia.BuscarEmpleadoPorId(idEmpleado);
        }



    }










}

