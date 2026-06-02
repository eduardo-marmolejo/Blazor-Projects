using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using Ecommerce.DTO;
using Ecommerce.Modelo;

namespace Ecommerce.Utilidades
{
    public class AutoMapperProfile:Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Usuario, UsuarioDTO>()
                .ForMember(dest => dest.NombreCompleto, opt => opt.MapFrom(src => $"{src.NombreCompleto}"));
            CreateMap<Usuario, SesionDTO>();
            CreateMap<UsuarioDTO, Usuario>()
                .ForMember(dest => dest.NombreCompleto, opt => opt.MapFrom(src => src.NombreCompleto));

            CreateMap<Categoria, CategoriaDTO>();
            CreateMap<CategoriaDTO, Categoria>();

            CreateMap<Producto, ProductoDTO>();
            CreateMap<ProductoDTO, Producto>().ForMember(destino=>destino.IdCategoriaNavigation,
                opt=>opt.Ignore());

            CreateMap<DetalleVenta, DetalleVentaDTO>();
            CreateMap<DetalleVentaDTO, DetalleVenta>();

            CreateMap<Venta, VentaDTO>();
            CreateMap<VentaDTO, Venta>();
        }
    }
}
