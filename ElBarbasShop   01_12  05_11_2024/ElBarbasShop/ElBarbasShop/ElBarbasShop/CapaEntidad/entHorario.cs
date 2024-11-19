using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entHorario
    {
      
        public string diaSemana { get; set; }
        public TimeSpan  horaInicio { get; set; }
        public TimeSpan horaFin { get; set; }
        public string idEmpleado { get; set; }




        // Constructor sin parámetros
        public entHorario()
        {
        }

        // Constructor con todos los parámetros
        //
        public entHorario( string diaSemana, TimeSpan horaInicio, TimeSpan horaFin, string idEmpleado)
        {
           
           this. diaSemana = diaSemana;
            this.horaInicio = horaInicio;
            this.horaFin = horaFin;
            this.idEmpleado = idEmpleado;
        }




    }
}
