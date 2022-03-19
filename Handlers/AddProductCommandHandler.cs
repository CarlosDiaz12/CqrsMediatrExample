using CqrsMediatrExample.Commands;
using CqrsMediatrExample.Data;
using CqrsMediatrExample.Models;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace CqrsMediatrExample.Handlers
{
    public class AddProductCommandHandler : IRequestHandler<AddProductCommand, Product>
    {
        private readonly FakeDataStore _fakeDataStore;
        public AddProductCommandHandler(FakeDataStore fakeDataStore) => _fakeDataStore = fakeDataStore;
        public async Task<Product> Handle(AddProductCommand request, CancellationToken cancellationToken)
        {
            var newProduct = new Product { Id = request.ProductId, Name = request.ProductName };
            await _fakeDataStore.AddProduct(newProduct);
            return newProduct;
        }
    }
}
