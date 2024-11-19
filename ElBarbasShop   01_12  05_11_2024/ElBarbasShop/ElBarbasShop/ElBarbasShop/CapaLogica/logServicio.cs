using CapaAccesoDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    
        public class logServicio
        {
            #region Singleton
            // Patrón Singleton
            private static readonly logServicio _instancia = new logServicio();

            // Propiedad pública para obtener la instancia única de la clase
            public static logServicio Instancia
            {
                get
                {
                    return _instancia;
                }
            }
            #endregion Singleton

            #region Métodos

            // Listar servicios
            public List<entServicio> ListarServicios()
            {
                return datServicio.Instancia.ListarServicios();
            }

            // Insertar servicio
            public void InsertarServicio(entServicio servicio)
            {
                datServicio.Instancia.InsertarServicio(servicio);
            }

            // Editar servicio
            public void EditarServicio(entServicio servicio)
            {
                datServicio.Instancia.EditarServicio(servicio);
            }

            // Eliminar servicio
            public void EliminarServicio(string idServicio)
            {
                datServicio.Instancia.EliminarServicio(idServicio);
            }

            // Buscar servicio por ID
            public entServicio BuscarServicioPorId(string idServicio)
            {
                return datServicio.Instancia.BuscarServicioPorId(idServicio);
            }

            #endregion Métodos
        }





    
}
