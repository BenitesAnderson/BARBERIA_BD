using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entDetalleVentaServicio
    {
        public int IdDetalle { get; set; }
        public string IdVenta { get; set; }
        public string IdServicio { get; set; }

        public entVenta Venta { get; set; }
        public entServicio Servicio { get; set; }
    }
}

