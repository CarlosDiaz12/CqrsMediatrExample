using CqrsMediatrExample.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CqrsMediatrExample.Queries
{
    public class GetProductsQuery: IRequest<IEnumerable<Product>> { }
}
