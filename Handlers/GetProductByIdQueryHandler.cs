using CqrsMediatrExample.Data;
using CqrsMediatrExample.Models;
using CqrsMediatrExample.Queries;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace CqrsMediatrExample.Handlers
{
    public class GetProductByIdQueryHandler : IRequestHandler<GetProductByIdQuery, Product>
    {
        private readonly FakeDataStore _fakeDataStore;
        public GetProductByIdQueryHandler(FakeDataStore fakeDataStore) => _fakeDataStore = fakeDataStore;

        public async Task<Product> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
        {
            return await _fakeDataStore.GetProductById(request.ProductId);
        }
    }
}
