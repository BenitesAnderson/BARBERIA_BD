using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entVenta
    {
        // Propiedades
        public string IdVenta { get; set; }
        public DateTime FechaVenta { get; set; }
        public decimal Monto { get; set; }
        public string IdCliente { get; set; }
        public string IdEmpleado { get; set; }
        public string IdMetodoPago { get; set; }

        // Constructor vacío
        public entVenta() { }

        // Constructor con parámetros
        public entVenta(string idVenta, DateTime fechaVenta, decimal monto, string idCliente, string idEmpleado, string idMetodoPago)
        {
            this.IdVenta = idVenta;
            this.FechaVenta = fechaVenta;
            this.Monto = monto;
            this.IdCliente = idCliente;
            this.IdEmpleado = idEmpleado;
            this.IdMetodoPago = idMetodoPago;
        }
    }
}
