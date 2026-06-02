using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Ecommerce.DTO
{
    public class TarjetaDTO
    {
        [Required(ErrorMessage = "Ingrese Titular")]
        public string? Titular { get; set; }
        [Required(ErrorMessage = "Ingrese Numero de Tarjeta")]
        public string? Numero { get;set; }
        [Required(ErrorMessage = "Ingrese Vidgencia")]
        public string? Vigencia { get; set; }
        [Required(ErrorMessage = "Ingrese CVV")]
        public string? CVV { get; set; }
    }
}
