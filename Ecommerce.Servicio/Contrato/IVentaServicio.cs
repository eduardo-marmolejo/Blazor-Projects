using System;
using System.Collections.Generic;
using System.Text;
using Ecommerce.DTO;

namespace Ecommerce.Servicio.Contrato
{
    public interface IVentaServicio
    {
        Task<VentaDTO> Registrar(VentaDTO modelo);
    }
}
