using CqrsMediatrExample.Models;
using MediatR;

namespace CqrsMediatrExample.Commands
{
    public class AddProductCommand: IRequest<Product>
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
    }
}
