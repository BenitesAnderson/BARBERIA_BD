using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entProducto
    {
        public string idProducto { get; set; }
        public string nombreProducto { get; set; }
        public string descripcion { get; set; }
        public decimal precio { get; set; }
        public int stock { get; set; }





        public entProducto() { }

        public entProducto(string idProducto, string nombreProducto, string descripcion, decimal precio, int stock)
        {
           this.idProducto = idProducto;
            this.nombreProducto = nombreProducto;
            this.descripcion = descripcion;
            this.precio = precio;
            this.stock = stock;
        }

    }
}




