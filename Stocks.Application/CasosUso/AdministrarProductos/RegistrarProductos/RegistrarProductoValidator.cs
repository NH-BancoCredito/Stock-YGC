using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stocks.Application.CasosUso.AdministrarProductos.ConsultarProductos
{
    public class RegistrarProductoValidator: AbstractValidator<RegistrarProductoRequest>
    {
        public RegistrarProductoValidator()
        {
            RuleFor(item => item.Nombre).NotEmpty().WithMessage("Debe especificar un nombre");
            RuleFor(item => item.Stock).NotEmpty().WithMessage("Debe especificar un Stock");
            RuleFor(item => item.StockMinimo).NotEmpty().WithMessage("Debe especificar un Stock mínimo");
            RuleFor(item => item.PrecioUnitario).NotEmpty().WithMessage("Debe especificar un precio unitario");
        }
    }
}
