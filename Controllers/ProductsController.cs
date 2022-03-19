using CqrsMediatrExample.Commands;
using CqrsMediatrExample.Models;
using CqrsMediatrExample.Queries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CqrsMediatrExample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IMediator _mediator;
        public ProductsController(IMediator mediator) => _mediator = mediator;

        [HttpGet]
        public async Task<ActionResult> GetProducts()
        {
            var response = await _mediator.Send(new GetProductsQuery());
            return Ok(response);
        }

        [HttpPost]
        public async Task<ActionResult> AddProduct([FromBody] AddProductCommand command)
        {
            var response = await _mediator.Send(command);
            return CreatedAtRoute("GetProductById", new { productId = response.Id }, response);
        }

        [HttpGet("{productId}", Name = "GetProductById")]
        public async Task<ActionResult> GetProductById(int productId)
        {
            var response = await _mediator.Send(new GetProductByIdQuery { ProductId = productId});
            return Ok(response);
        }
    }
}
