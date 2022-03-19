using CqrsMediatrExample.Data;
using CqrsMediatrExample.Models;
using CqrsMediatrExample.Queries;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CqrsMediatrExample.Handlers
{
    public class GetProductsQueryHandler: IRequestHandler<GetProductsQuery, IEnumerable<Product>>
    {
        private readonly FakeDataStore _fakeDataStore;
        public GetProductsQueryHandler(FakeDataStore fakeDataStore) => _fakeDataStore = fakeDataStore;

        public async Task<IEnumerable<Product>> Handle(GetProductsQuery request, CancellationToken cancellationToken)
        {
            return await _fakeDataStore.GetAllProducts();
        }
    }
}
