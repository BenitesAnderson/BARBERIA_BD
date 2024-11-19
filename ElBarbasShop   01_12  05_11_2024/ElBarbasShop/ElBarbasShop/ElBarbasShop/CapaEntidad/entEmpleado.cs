using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entEmpleado
    {
        public string idEmpleado { get; set; }
        public string nombres { get; set; }
        public string apellidos { get; set; }
        public string dni { get; set; }
        public string cargo { get; set; }
        public string correo { get; set; }
     

        public string idBarberia { get; set; }


        public entEmpleado()
        {
        }
        
        public entEmpleado(string idempleado , string nombres, string apellidos,string dni,  string cargo, string correo , string barberia)

        { 

            this.idEmpleado = idempleado;    
            this.nombres = nombres;  
            this.apellidos = apellidos; 
            this.dni = dni;
            this.cargo = cargo;  
            this.correo = correo;    
            this.idBarberia = barberia;    


        }













    }
}
