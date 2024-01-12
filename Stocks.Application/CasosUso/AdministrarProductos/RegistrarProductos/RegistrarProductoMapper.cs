using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Stocks.Domain.Models;
using System.Reflection;

namespace Stocks.Application.CasosUso.AdministrarProductos.ConsultarProductos
{
    public class RegistrarProductoMapper: Profile
    {
        public RegistrarProductoMapper()
        {
            CreateMap<RegistrarProductoRequest, Producto>();
            //    .ForMember();

            //CreateMap<RegistrarVentaRequest, Models.Venta>()
            //    .ForMember(dest => dest.Detalle, map => map.MapFrom(src => src.Productos));
        }
    }
}
