using CqrsMediatrExample.Models;
using MediatR;

namespace CqrsMediatrExample.Queries
{
    public class GetProductByIdQuery: IRequest<Product>
    {
        public int ProductId { get; set; }
    }
}
