using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce.DTO
{
    public class DetalleVentaDTO
    {
        public int IdDetalleVenta { get; set; }

        public int IdVenta { get; set; }

        public int IdProducto { get; set; }

        public int Cantidad { get; set; }

        public decimal Total { get; set; }
    }
}
