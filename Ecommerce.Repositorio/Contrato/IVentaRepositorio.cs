using Ecommerce.Modelo;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce.Repositorio.Contrato
{
    public interface IVentaRepositorio:IGenericoRepositorio<Venta>
    {
        Task<Venta> Registrar(Venta modelo);
    }
}
