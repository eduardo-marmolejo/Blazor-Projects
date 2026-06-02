using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Ecommerce.DTO
{
    public class UsuarioDTO
    {
        public int IdUsuario { get; set; }

        [Required(ErrorMessage = "Ingrese nombre completo")]

        public string NombreCompleto { get; set; }
        [Required(ErrorMessage = "Ingrese el correo")]

        public string Correo { get; set; }
        [Required(ErrorMessage = "Ingrese el contraseña")]

        public string Clave { get; set; }
        [Required(ErrorMessage = "Ingrese confirmar contraseña")]

        public string ConfirmarClave { get; set; }

        public string Rol { get; set; }
    }
}
