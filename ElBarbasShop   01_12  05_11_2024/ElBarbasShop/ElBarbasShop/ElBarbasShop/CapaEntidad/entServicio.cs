using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entServicio
    {
        public string idServicio { get; set; }
        public string nombreServicio { get; set; }
        public int duracion { get; set; }
        public decimal precio { get; set; }



        public entServicio() { }

        // Constructor con parámetros
        public entServicio(string idServicio, string nombreServicio, int duracion, decimal precio)
        {
            this.idServicio = idServicio;
            this.nombreServicio = nombreServicio;
            this.duracion = duracion;
            this.precio = precio;
        }






    }








}
