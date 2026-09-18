using ProductDataCacheApi.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductDataCacheApi.Infrastructure.Persistence.Interfaces
{
    public interface IProductRepository
    {
        Task<IReadOnlyList<Product>> GetListAsync(CancellationToken cancellationToken);
        Task<Product?> GetByIdAsync(int id, CancellationToken cancellationToken);
        Task UpsertAsync(IReadOnlyList<Product> products, CancellationToken cancellationToken);
    }
}
