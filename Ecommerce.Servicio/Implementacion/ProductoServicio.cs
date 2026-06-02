using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Ecommerce.Modelo;
using Ecommerce.DTO;
using Ecommerce.Repositorio.Contrato;
using Ecommerce.Servicio.Contrato;
using AutoMapper;

namespace Ecommerce.Servicio.Implementacion
{
    public class ProductoServicio : IProductoServicio
    {
        private readonly IGenericoRepositorio<Producto> _modeloRepositorio;
        private readonly IMapper _mapper;

        public ProductoServicio(IGenericoRepositorio<Producto> modeloRepositorio, IMapper mapper)
        {
            _modeloRepositorio = modeloRepositorio;
            _mapper = mapper;
        }

        public async Task<List<ProductoDTO>> Catalogo(string categoria, string buscar)
        {
            try
            {
                var consulta = _modeloRepositorio.Consultar(null);
                consulta = consulta.Include(c => c.IdCategoriaNavigation);

                if (!string.IsNullOrEmpty(buscar))
                    consulta = consulta.Where(p => p.Nombre.ToLower().Contains(buscar.ToLower()));

                if (!string.IsNullOrEmpty(categoria))
                    consulta = consulta.Where(p => p.IdCategoriaNavigation.Nombre.ToLower().Contains(categoria.ToLower()));

                List<ProductoDTO> lista = _mapper.Map<List<ProductoDTO>>(await consulta.ToListAsync());
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<ProductoDTO> Crear(ProductoDTO modelo)
        {
            try
            {
                var dbModelo = _mapper.Map<Producto>(modelo);
                var rspModelo = await _modeloRepositorio.Crear(dbModelo);

                if (rspModelo.IdProducto != 0)
                {
                    return _mapper.Map<ProductoDTO>(rspModelo);
                }
                else
                {
                    throw new TaskCanceledException("No se puede crear");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<bool> Editar(ProductoDTO modelo)
        {
            try
            {
                var consulta = _modeloRepositorio.Consultar(p => p.IdProducto == modelo.IdProducto);
                var fromDBModelo = await consulta.FirstOrDefaultAsync();

                if (fromDBModelo != null)
                {
                    fromDBModelo.Nombre = modelo.Nombre;
                    fromDBModelo.Descripcion = modelo.Descripcion;
                    fromDBModelo.IdCategoria = modelo.IdCategoria;
                    fromDBModelo.Precio = modelo.Precio;
                    fromDBModelo.PrecioOferta = modelo.PrecioOferta;
                    fromDBModelo.Cantidad = modelo.Cantidad;

                    var respuesta = await _modeloRepositorio.Editar(fromDBModelo);

                    if (respuesta)
                    {
                        return true;
                    }
                    else
                    {
                        throw new TaskCanceledException("No se puede editar");
                    }
                }
                else
                {
                    throw new TaskCanceledException("No se encontraron resultados");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<bool> Eliminar(int id)
        {
            try
            {
                var consulta = _modeloRepositorio.Consultar(p => p.IdProducto == id);
                var fromDBModelo = await consulta.FirstOrDefaultAsync();

                if (fromDBModelo != null)
                {
                    var respuesta = await _modeloRepositorio.Eliminar(fromDBModelo);

                    if (respuesta)
                    {
                        return true;
                    }
                    else
                    {
                        throw new TaskCanceledException("No se puede eliminar");
                    }
                }
                else
                {
                    throw new TaskCanceledException("No se encontraron resultados");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<List<ProductoDTO>> Lista(string buscar)
        {
            try
            {
                var consulta = _modeloRepositorio.Consultar(p => p.Nombre.ToLower().Contains(buscar.ToLower()));

                consulta = consulta.Include(c => c.IdCategoriaNavigation);

                List<ProductoDTO> lista = _mapper.Map<List<ProductoDTO>>(await consulta.ToListAsync());
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<ProductoDTO> Obtener(int id)
        {
            try
            {
                var consulta = _modeloRepositorio.Consultar(p => p.IdProducto == id);
                consulta = consulta.Include(c => c.IdCategoriaNavigation);
                var fromDBModelo = await consulta.FirstOrDefaultAsync();

                if (fromDBModelo != null)
                {
                    return _mapper.Map<ProductoDTO>(fromDBModelo);
                }
                else
                {
                    throw new TaskCanceledException("No se encontraron coincidencias");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
