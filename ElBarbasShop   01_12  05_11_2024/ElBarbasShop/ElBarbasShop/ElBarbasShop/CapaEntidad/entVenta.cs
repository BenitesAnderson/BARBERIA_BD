using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entVenta
    {
        public string IdVenta { get; set; }
        public DateTime FechaVenta { get; set; }
        public decimal Monto { get; set; }
        public string IdCliente { get; set; }
        public string IdEmpleado { get; set; }
        public string IdMetodoPago { get; set; }

        public entCliente Cliente { get; set; }
        public entEmpleado Empleado { get; set; }
        public entMetodoPago MetodoPago { get; set; }
        public ICollection<entDetalleVentaServicio> DetallesServicios { get; set; }
        public ICollection<entDetalleVentaProducto> DetallesProductos { get; set; }
    }
}

