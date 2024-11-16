using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entBarberia
    {
        public string idBarberia { get; set; }
        public string nombre { get; set; }
        public string ubicacion { get; set; }
        
      

        public entBarberia() { 
        
      
        }

        public entBarberia(string idbarberia, string nombre, string ubicacion)
        {
            this.idBarberia = idbarberia; 
            this.nombre = nombre;   
            this.ubicacion = ubicacion;


        }



    }
}

