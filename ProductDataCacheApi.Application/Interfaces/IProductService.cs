using ProductDataCacheApi.Application.DTOs;
using ProductDataCacheApi.Shared.Results;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductDataCacheApi.Application.Interfaces
{
    public interface IProductService
    {
        Task<IReadOnlyList<ProductDetailDto>> GetListAsync(CancellationToken cancellationToken);

        Task<Result<ProductDetailDto>> GetByIdAsync(int id, CancellationToken cancellationToken);
    }
}
