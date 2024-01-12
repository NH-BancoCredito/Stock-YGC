using MediatR;
using Microsoft.AspNetCore.Mvc;
using Stocks.Application.CasosUso.AdministrarProductos.ConsultarProductos;

using Stocks.Application.CasosUso.ReponerStock;
using Stocks.Application.CasosUso.ReservarStock;

namespace Stocks.Api.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class ProductosController : ControllerBase
    {
        private readonly IMediator _mediator;
        public ProductosController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("consultar")]
        public async Task<IActionResult> Consultar([FromQuery] ConsultarProductosRequest request)
        {
            var response = await _mediator.Send(request);

            return Ok(response);
        }

        [HttpGet("reservar")]
        public async Task<IActionResult> Reservar([FromQuery] ReservarStockRequest request)
        {
            var response = await _mediator.Send(request);

            return Ok(response);
        }

        [HttpGet("reponer")]
        public async Task<IActionResult> Reponer([FromQuery] ReponerStockRequest request)
        {
            var response = await _mediator.Send(request);

            return Ok(response);
        }
        [HttpGet("registrar")]
        public async Task<IActionResult> Registrar([FromQuery] RegistrarProductoRequest request)
        {
            var response = await _mediator.Send(request);

            return Ok(response);
        }
    }
}
