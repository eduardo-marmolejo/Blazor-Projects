using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Ecommerce.DTO
{
    public class LoginDTO
    {
        [Required(ErrorMessage = "Ingrese el correo")]
        public string Correo { get; set; }
        
        [Required(ErrorMessage = "Ingrese el contraseña")]
        public string Clave { get; set; }
    }
}
