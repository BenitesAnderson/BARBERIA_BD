using CapaAccesoDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public  class logHorario
    {

        #region Singleton
        // Instancia única de la clase
        private static readonly logHorario _instancia = new logHorario();
        public static logHorario Instancia => _instancia;
        #endregion

        #region Métodos

        // Listar Horarios
        public List<entHorario> ListarHorarios()
        {
            return datHorario.Instancia.ListarHorarios();
        }

        // Insertar Horario
        public void InsertarHorario(entHorario horario)
        {
            datHorario.Instancia.InsertarHorario(horario);
        }

        // Editar Horario
        public void EditarHorario(entHorario horario)
        {
            datHorario.Instancia.EditarHorario(horario);
        }

        // Eliminar Horario
        // public bool EliminarHorario(string idEmpleado, string diaSemana, TimeSpan horaInicio)
        public void EliminarHorario(string idempleado, string diasemana, TimeSpan horainicio)
        {
            datHorario.Instancia.EliminarHorario(idempleado, diasemana, horainicio);
        }

        // Buscar Horario por ID
        public entHorario BuscarHorario(string  idempleado)
        {
            return datHorario.Instancia.BuscarHorariosPorEmpleado(idempleado);
        }

        #endregion




    }
}
