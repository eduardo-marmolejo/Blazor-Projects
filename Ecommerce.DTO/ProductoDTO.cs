using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Ecommerce.DTO
{
    public class ProductoDTO
    {
        public int IdProducto { get; set; }

        public int IdCategoria { get; set; }
        [Required(ErrorMessage = "Ingrese el nombre")]

        public string Nombre { get; set; }
        [Required(ErrorMessage = "Ingrese el descripción")]

        public string Descripcion { get; set; }
        [Required(ErrorMessage = "Ingrese el precio")]

        public decimal Precio { get; set; }
        [Required(ErrorMessage = "Ingrese el precio de oferta")]

        public decimal PrecioOferta { get; set; }
        [Required(ErrorMessage = "Ingrese el cantidad")]

        public int Cantidad { get; set; }
        [Required(ErrorMessage = "Ingrese imagen")]

        public string Imagen { get; set; }

        public DateTime? FechaCreacion { get; set; }

        public virtual CategoriaDTO?IdCategoriaNavigation { get; set; }
    }
}
